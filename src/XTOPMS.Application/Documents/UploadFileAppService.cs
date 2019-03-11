//
//  UploadFile.cs
//
//  Author:
//       Eric-Zhong Xu <xu.zhong@hotmail.com>
//
//  Copyright (c) 2019 
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.IO;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using XTOPMS.Documents.Dto;
using XTOPMS.Utilities;

namespace XTOPMS.Documents
{
    public class UploadFileAppService: XTOPMSAppServiceBase, IUploadFileAppService
    {
        private readonly IHttpContextAccessor _httpContext = null;
        private readonly IRepository<Document, long> _documentRepository;
        private readonly IHostingEnvironment _hostingEnvironment;


        public const string separator = "_XTOPMS_";

        public UploadFileAppService(
            IHttpContextAccessor httpContext,
            IRepository<Document, long> documentRepository,
            IHostingEnvironment hostingEnvironment
            )
        {
            _httpContext = httpContext;
            _documentRepository = documentRepository;
            _hostingEnvironment = hostingEnvironment;
        }

        public async System.Threading.Tasks.Task<UploadResultOutput> SaveAsync()
        {
            UploadResultOutput output = new UploadResultOutput();
            output.Files = new List<DocumentDto>();

            HttpContext hcx = this._httpContext.HttpContext;
            IFormFileCollection ffc = hcx.Request.Form.Files;

            var method = this._httpContext.HttpContext.Request.Method;
            var filesCount = ffc.Count;
            var success = false;

            for (int i = 0; i < filesCount; i++)
            {
                DocumentDto doc = new DocumentDto();
                var file = ffc[i];

                doc.FileId = IdFactory.NewId();
                doc.OrginalName = file.FileName;
                doc.FileName = System.IO.Path.GetFileNameWithoutExtension(file.FileName);
                doc.Extension = System.IO.Path.GetExtension(file.FileName).Trim('.');
                doc.ContentType = file.ContentType;
                doc.Size = file.Length;

                // Save file to local storage.
                // TODO: Add code to save file.

                // Software design:
                // 00100: Get default storage root path
                // 00200: Create folder for save file
                // 00300: Save file
                // 00400: Update database for saving file detail information

                // 00100: Get default storage root path
                string defaultRootFolder = GetTendentDefaultFileFolderPath(); // The file will be saved in this folder.

                string fileName =
                    doc.FileId + separator +        // File ID
                    doc.Extension + separator +     // File Extension Name
                    doc.OrginalName;                // File Name

                string filePath = defaultRootFolder.TrimEnd('/') + "/" + fileName;

                doc.FilePath = filePath;

                try
                {
                    // Create folder
                    if (false == Directory.Exists(defaultRootFolder))
                    {
                        Directory.CreateDirectory(defaultRootFolder);
                    }

                    // 00300 Save to hard disk
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    // 00400 Save to database

                    // If save file success, set result as success = true.
                    doc.Success = true;
                    doc.Message = "Upload success";
                    doc.Error = null;
                }
                catch (Exception exc)
                {
                    doc.Success = false;
                    doc.Message = "Upload failed";
                    doc.Error = exc.ToString();
                }

                output.Files.Add(doc);
            }

            output.FileCount = filesCount;
            output.Success = success;

            return output;
        }

        /// <summary>
        /// Get tenant's default file folder path.
        /// </summary>
        /// <returns>The tendent default file folder path.</returns>
        private string GetTendentDefaultFileFolderPath()
        {
            string defaultFildFolderPath = "upload_files";

            var hostFolder = _hostingEnvironment.ContentRootPath;

            var tenantId = this.AbpSession.TenantId;

            var dateFolder = DateTime.Now.ToString("yyyy/MM/dd");

            // <Root_Path>/<Tenant_Id>
            var output = hostFolder.TrimEnd('/') + "/" + defaultFildFolderPath + "/" + (tenantId != null ? tenantId.ToString() : "000") + "/" + dateFolder;

            return output;
        }
    }
}

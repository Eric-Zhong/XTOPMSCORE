//
//  HttpClient.cs
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
using System.IO;
using System.Net;
using System.Text;
using com.alibaba.openapi.client.policy;
using com.alibaba.openapi.client.serialize;

namespace XTOPMS.Henkel
{
    public class HttpClient
    {
        public HttpClient()
        {
        }

        public string Post(string apiUri, string body)
        {
            String postString = body;  // JsonConvert.SerializeObject(body);
            byte[] postData = Encoding.UTF8.GetBytes(body);
            String uriStr = apiUri;
            Uri uri = new Uri(uriStr);
            HttpWebRequest httpWebRequest = WebRequest.Create(uri) as HttpWebRequest;

            httpWebRequest.Method = "POST";
            httpWebRequest.KeepAlive = false;
            httpWebRequest.AllowAutoRedirect = true;
            // httpWebRequest.ContentType = "application/x-www-form-urlencoded";    // Salesforce not support.
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.UserAgent = "Alibaba/XTOPMS";
            httpWebRequest.ContentLength = postData.Length;

            System.IO.Stream outputStream = httpWebRequest.GetRequestStream();
            outputStream.Write(postData, 0, postData.Length);
            outputStream.Close();

            try
            {
                HttpWebResponse response = httpWebRequest.GetResponse() as HttpWebResponse;
                Stream responseStream = response.GetResponseStream();

                string resp = "";
                using (StreamReader reader = new StreamReader(responseStream, Encoding.UTF8))
                {
                    resp = reader.ReadToEnd();
                }
                return resp;
            }
            catch (System.Net.WebException webException)
            {
                Console.WriteLine(webException.Message);
                throw webException;
            }

        }

    }
}

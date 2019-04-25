//
//  XTOPMSAsyncCrudAppService.cs
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
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Repositories;
using Abp.Linq;
using Abp.UI;
using XTOPMS.Dto;

namespace XTOPMS
{

    public abstract class XTOPMSAsyncCrudAppService<TEntity, TEntityDto>
        : XTOPMSAsyncCrudAppService<TEntity, TEntityDto, long>
           where TEntity : class, IEntity<long>, IXTOPMSEntity, ICreationAudited
           where TEntityDto : IEntityDto<long>
    {
        protected XTOPMSAsyncCrudAppService(IRepository<TEntity, long> repository) : base(repository)
        {
        }

    }


    public abstract class XTOPMSAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey>
        : XTOPMSAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, PagedAndSortedResultRequestDto>
           where TEntity : class, IEntity<TPrimaryKey>, IXTOPMSEntity, ICreationAudited
           where TEntityDto : IEntityDto<TPrimaryKey>
    {
        protected XTOPMSAsyncCrudAppService(IRepository<TEntity, TPrimaryKey> repository) : base(repository)
        {
        }

    }


    public abstract class XTOPMSAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetAllInput>
        : XTOPMSAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TEntityDto, TEntityDto>
           where TEntity : class, IEntity<TPrimaryKey>, IXTOPMSEntity, ICreationAudited
           where TEntityDto : IEntityDto<TPrimaryKey>
    {
        protected XTOPMSAsyncCrudAppService(IRepository<TEntity, TPrimaryKey> repository) : base(repository)
        {
        }

    }


    public abstract class XTOPMSAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput>
        : XTOPMSAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TCreateInput>
            where TEntity : class, IEntity<TPrimaryKey>, IXTOPMSEntity, ICreationAudited
            where TEntityDto : IEntityDto<TPrimaryKey>
            where TCreateInput : IEntityDto<TPrimaryKey>
    {
        protected XTOPMSAsyncCrudAppService(IRepository<TEntity, TPrimaryKey> repository) : base(repository)
        {
        }

    }


    public abstract class XTOPMSAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput>
        : XTOPMSAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput, EntityDto<TPrimaryKey>>
           where TEntity : class, IEntity<TPrimaryKey>, IXTOPMSEntity, ICreationAudited
           where TEntityDto : IEntityDto<TPrimaryKey>
           where TUpdateInput : IEntityDto<TPrimaryKey>
    {
        protected XTOPMSAsyncCrudAppService(IRepository<TEntity, TPrimaryKey> repository) : base(repository)
        {
        }

    }


    public abstract class XTOPMSAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput, TGetInput>
        : XTOPMSAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput, TGetInput, IEntityDto<TPrimaryKey>>
           where TEntity : class, IEntity<TPrimaryKey>, IXTOPMSEntity, ICreationAudited
           where TEntityDto : IEntityDto<TPrimaryKey>
           where TUpdateInput : IEntityDto<TPrimaryKey>
           where TGetInput : IEntityDto<TPrimaryKey>
    {
        protected XTOPMSAsyncCrudAppService(IRepository<TEntity, TPrimaryKey> repository) : base(repository)
        {
        }

    }

    public abstract class XTOPMSAsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput, TGetInput, TDeleteInput>
       : AsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput, TGetInput, TDeleteInput>,
        IXTOPMSAsyncCrudAppService<TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput, TGetInput, TDeleteInput>,
        IAsyncCrudAppService<TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput, TGetInput, TDeleteInput>
           where TEntity : class, IEntity<TPrimaryKey>, IXTOPMSEntity, ICreationAudited
           where TEntityDto : IEntityDto<TPrimaryKey>
           where TUpdateInput : IEntityDto<TPrimaryKey>
           where TGetInput : IEntityDto<TPrimaryKey>
           where TDeleteInput : IEntityDto<TPrimaryKey>
    {
        protected XTOPMSAsyncCrudAppService(IRepository<TEntity, TPrimaryKey> repository) : base(repository)
        {
        }


        public override async Task<TEntityDto> Get(TGetInput input)
        {
            return await base.Get(input);
        }


        public override async Task<PagedResultDto<TEntityDto>> GetAll(TGetAllInput input)
        {
            return await base.GetAll(input);
        }


        public override async Task<TEntityDto> Create(TCreateInput input)
        {
            return await base.Create(input);
        }


        public override async Task<TEntityDto> Update(TUpdateInput input)
        {
            return await base.Update(input);
        }

        public override Task Delete(TDeleteInput input)
        {
            return base.Delete(input);
        }

        public Task Remove(TPrimaryKey id)
        {
            TEntity entity= Repository.Get(id);
            if(entity != null)
            {
                return Repository.DeleteAsync(entity);
            }
            else
            {
                throw new UserFriendlyException(id.ToString() + " not found");
            }
        }


        /// <summary>
        /// 获取可以自己的下属信息，默认是按用户的 line-manager进行查找
        /// </summary>
        /// <returns>The direct reports.</returns>
        protected virtual List<long> GetDirectReports()
        {
            var myId = this.AbpSession.UserId;
            return new List<long>();
        }


        /// <summary>
        /// Gets my all.
        /// </summary>
        /// <returns>The my all.</returns>
        /// <param name="input">Input.</param>
        public virtual async Task<PagedResultDto<TEntityDto>> GetMyAll(TGetAllInput input)
        {
            // XTOPMS 封闭的方法，暂不加这一步权限判断。
            // TODO: 需要花时间研究一下这里是用来干什么的。
            // CheckGetAllPermission();

            var query = CreateFilteredQuery(input);

            var directReports = this.GetDirectReports();
            var myId = this.AbpSession.UserId;
            directReports.Add(myId.Value);

            query = query.Where(t => directReports.Contains(t.CreatorUserId.Value));

            var totalCount = await AsyncQueryableExecuter.CountAsync(query);

            query = ApplySorting(query, input);
            query = ApplyPaging(query, input);

            var entities = await AsyncQueryableExecuter.ToListAsync(query);

            return new PagedResultDto<TEntityDto>(
                totalCount,
                entities.Select(MapToEntityDto).ToList()
            );
        }


        public virtual async Task<List<TEntityDto>> QuickSearch(QuickSearchInputDto input)
        {
            var value = input.Value;
            var count = input.Count;

            var query = Repository.GetAll();

            query = query.Where(t => 
                t.Name.Contains(value) || 
                t.Code.Contains(value) || 
                t.ErpId.Contains(value)
                );

            query = query.Take(count);
            query = query.OrderBy(t => t.Name);

            var list = await Task.FromResult(query.ToList());

            var items = ObjectMapper.Map<List<TEntityDto>>(list);

            return items;
        }

    }



    public interface IXTOPMSAsyncCrudAppService<TEntityDto, TPrimaryKey, in TGetAllInput, in TCreateInput, in TUpdateInput, in TGetInput, in TDeleteInput>
        : IApplicationService,
        IAsyncCrudAppService<TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput, TGetInput, TDeleteInput>
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TUpdateInput : IEntityDto<TPrimaryKey>
        where TGetInput : IEntityDto<TPrimaryKey>
        where TDeleteInput : IEntityDto<TPrimaryKey>
    {
        Task<PagedResultDto<TEntityDto>> GetMyAll(TGetAllInput input);
        Task<List<TEntityDto>> QuickSearch(QuickSearchInputDto input);
        Task Remove(TPrimaryKey id);
    }
}

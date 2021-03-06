﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.Organizations;
using Microsoft.EntityFrameworkCore;
using XTOPMS;
using XTOPMS.Organizations.Dto;

namespace XTOPMS.Organizations
{

    public class OrganizationUnitAppService : XTOPMSAppServiceBase, IOrganizationUnitAppService
    {
        private readonly OrganizationUnitManager _organizationUnitManager;
        private readonly IRepository<OrganizationUnit, long> _organizationUnitRepository;
        private readonly IRepository<UserOrganizationUnit, long> _userOrganizationUnitRepository;

        public OrganizationUnitAppService(
            OrganizationUnitManager organizationUnitManager,
            IRepository<OrganizationUnit, long> organizationUnitRepository,
            IRepository<UserOrganizationUnit, long> userOrganizationUnitRepository)
        {
            _organizationUnitManager = organizationUnitManager;
            _organizationUnitRepository = organizationUnitRepository;
            _userOrganizationUnitRepository = userOrganizationUnitRepository;
        }

        public async Task<ListResultDto<OrganizationUnitDto>> GetOrganizationUnits()
        {
            var query =
                from ou in _organizationUnitRepository.GetAll()
                join uou in _userOrganizationUnitRepository.GetAll() on ou.Id equals uou.OrganizationUnitId into g
                select new { ou, memberCount = g.Count() };

            var items = await query.ToListAsync();

            return new ListResultDto<OrganizationUnitDto>(
                items.Select(item =>
                {
                    var dto = item.ou.MapTo<OrganizationUnitDto>();
                    dto.MemberCount = item.memberCount;
                    return dto;
                }).ToList());
        }

        public async Task<PagedResultDto<OrganizationUnitUserListDto>> GetOrganizationUnitUsers(GetOrganizationUnitUsersInput input)
        {
            var query = from uou in _userOrganizationUnitRepository.GetAll()
                        join ou in _organizationUnitRepository.GetAll() on uou.OrganizationUnitId equals ou.Id
                        join user in UserManager.Users on uou.UserId equals user.Id
                        where uou.OrganizationUnitId == input.Id
                        orderby input.Sorting
                        select new { uou, user };

            var totalCount = await query.CountAsync();
            var items = await query.PageBy(input).ToListAsync();

            return new PagedResultDto<OrganizationUnitUserListDto>(
                totalCount,
                items.Select(item =>
                {
                    var dto = item.user.MapTo<OrganizationUnitUserListDto>();
                    dto.AddedTime = item.uou.CreationTime;
                    return dto;
                }).ToList());
        }

        public async Task<OrganizationUnitDto> CreateOrganizationUnit(CreateOrganizationUnitInput input)
        {
            var organizationUnit = new OrganizationUnit(AbpSession.TenantId, input.DisplayName, input.ParentId);

            await _organizationUnitManager.CreateAsync(organizationUnit);
            await CurrentUnitOfWork.SaveChangesAsync();

            return organizationUnit.MapTo<OrganizationUnitDto>();
        }

        public async Task<OrganizationUnitDto> UpdateOrganizationUnit(UpdateOrganizationUnitInput input)
        {
            var organizationUnit = await _organizationUnitRepository.GetAsync(input.Id);

            organizationUnit.DisplayName = input.DisplayName;

            await _organizationUnitManager.UpdateAsync(organizationUnit);

            return await CreateOrganizationUnitDto(organizationUnit);
        }

        public async Task<OrganizationUnitDto> MoveOrganizationUnit(MoveOrganizationUnitInput input)
        {
            await _organizationUnitManager.MoveAsync(input.Id, input.NewParentId);

            return await CreateOrganizationUnitDto(
                await _organizationUnitRepository.GetAsync(input.Id)
                );
        }

        public async Task DeleteOrganizationUnit(long input)
        {
            await _organizationUnitManager.DeleteAsync(input);
        }

        public async Task AddUserToOrganizationUnit(UserToOrganizationUnitInput input)
        {
            await UserManager.AddToOrganizationUnitAsync(input.UserId, input.OrganizationUnitId);
        }

        public async Task RemoveUserFromOrganizationUnit(UserToOrganizationUnitInput input)
        {
            await UserManager.RemoveFromOrganizationUnitAsync(input.UserId, input.OrganizationUnitId);
        }

        public async Task<bool> IsInOrganizationUnit(UserToOrganizationUnitInput input)
        {
            return await UserManager.IsInOrganizationUnitAsync(input.UserId, input.OrganizationUnitId);
        }

        private async Task<OrganizationUnitDto> CreateOrganizationUnitDto(OrganizationUnit organizationUnit)
        {
            var dto = organizationUnit.MapTo<OrganizationUnitDto>();
            dto.MemberCount = await _userOrganizationUnitRepository.CountAsync(uou => uou.OrganizationUnitId == organizationUnit.Id);
            return dto;
        }
        /// <summary>
        /// 取当前登录用户的部门
        /// </summary>
        /// <returns></returns>
        public UserOrganizationUnit GetUserOrganizationUnit()
        {
            long userid = Convert.ToInt64(AbpSession.UserId);

            //UserOrganizationUnit uu = _userOrganizationUnitRepository.FirstOrDefault(s => s.UserId == userid);
            //20170608修改
            var query = from uou in _userOrganizationUnitRepository.GetAll()
                        join ou in _organizationUnitRepository.GetAll() on uou.OrganizationUnitId equals ou.Id
                        where ou.IsDeleted == false && uou.UserId == userid
                        select new { uou };

            UserOrganizationUnit uu = query.Select(item => item.uou).FirstOrDefault();

            if (uu == null)
            {
                return null;
            }
            return uu;
        }
        /// <summary>
        /// 根据用户ID返回部门
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public UserOrganizationUnit GetUserOrganizationUnitByUserid(string userid)
        {
            long longuserid = Convert.ToInt64(userid);

            //20170608修改
            var query = from uou in _userOrganizationUnitRepository.GetAll()
                        join ou in _organizationUnitRepository.GetAll() on uou.OrganizationUnitId equals ou.Id
                        where ou.IsDeleted == false && uou.UserId == longuserid
                        select new { uou };

            UserOrganizationUnit uu = query.Select(item => item.uou).FirstOrDefault();

            if (uu == null)
            {
                return null;
            }
            return uu;
        }


        /// <summary>
        /// Get current user's organization unit tree structure.
        /// </summary>
        /// <returns>The organization units tree.</returns>
        public async Task<OrganizationUnitTreeDto> GetOrganizationUnitsTree()
        {
            var query =
                from ou in _organizationUnitRepository.GetAll()
                where ou.ParentId == null
                select ou;

            var root = await query.FirstOrDefaultAsync();
            var rootNode = root.MapTo<OrganizationUnitTreeDto>();

            InitChildOU(rootNode);

            return rootNode;
        }

        private void InitChildOU(OrganizationUnitTreeDto rootNode)
        {
            var query =
                from ou in _organizationUnitRepository.GetAll()
                where ou.ParentId == rootNode.Id
                select ou;

            var childOUs = query.ToList();

            if (childOUs.Any())
            {
                rootNode.Children = new List<OrganizationUnitTreeDto>();
                rootNode.ChildrenCount = childOUs.Count();

                foreach (var ou in childOUs)
                {
                    var ouDto = ou.MapTo<OrganizationUnitTreeDto>();
                    InitChildOU(ouDto);
                    rootNode.Children.Add(ouDto);
                }
            }
            else
            {
                rootNode.Children = null;
                rootNode.ChildrenCount = 0;
            }
        }
    }
}
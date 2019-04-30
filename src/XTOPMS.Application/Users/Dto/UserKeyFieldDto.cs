using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using XTOPMS.Authorization.Users;

namespace XTOPMS.Users.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserKeyFieldDto : EntityDto<long>
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string EmployeeNumber { get; set; }
        public string Avatar { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }

        /*
        public string UserName { get; set; }
        public string Surname { get; set; }
        public bool IsActive { get; set; }
        public string FullName { get; set; }
        */       
    }
}

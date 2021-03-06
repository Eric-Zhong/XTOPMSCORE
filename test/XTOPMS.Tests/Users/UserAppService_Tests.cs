﻿using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shouldly;
using Xunit;
using Abp.Application.Services.Dto;
using XTOPMS.Users;
using XTOPMS.Users.Dto;
using XTOPMS.Authorization.Users;
using XTOPMS.Application.Dto;

namespace XTOPMS.Tests.Users
{
    public class UserAppService_Tests : XTOPMSTestBase
    {
        private readonly IUserAppService _userAppService;
        private readonly UserManager _userManager;

        public UserAppService_Tests()
        {
            _userAppService = Resolve<IUserAppService>();
            _userManager = Resolve<UserManager>();
        }

        [Fact]
        public async Task GetUsers_Test()
        {
            // Act
            var output = await _userAppService.GetAll(new QueryBaseDto{MaxResultCount=20, SkipCount=0} );

            // Assert
            output.Items.Count.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task CreateUser_Test()
        {
            // Act
            await _userAppService.Create(
                new CreateUserDto
                {
                    EmailAddress = "john@volosoft.com",
                    IsActive = true,
                    Name = "John",
                    Surname = "Nash",
                    Password = "123qwe",
                    UserName = "john.nash"
                });

            await UsingDbContextAsync(async context =>
            {
                var johnNashUser = await context.Users.FirstOrDefaultAsync(u => u.UserName == "john.nash");
                johnNashUser.ShouldNotBeNull();
            });
        }

        [Fact]
        public async Task GetUser_Test()
        {
            var user = await _userManager.GetUserByIdAsync(3);
            var creator = user.CreatorUser;
            Assert.NotNull(creator);
        }
    }
}

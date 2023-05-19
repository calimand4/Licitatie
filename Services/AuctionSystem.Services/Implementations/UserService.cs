﻿namespace AuctionSystem.Services.Implementations
{
    using System.Threading.Tasks;
    using Data;
    using Interfaces;
    using Microsoft.EntityFrameworkCore;

    public class UserService : BaseService, IUserService
    {
        public UserService(AuctionSystemDbContext context)
            : base(context)
        {
        }

        public async Task<string> GetUserIdByUsernameAsync(string username)
        {
            var user = await this.Context
                .Users
                .SingleOrDefaultAsync(u => u.UserName == username);

            return user?.Id;
        }
    }
}

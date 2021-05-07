using MoviePageSolution.Data.EF;
using MoviePageSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MoviePageSolution.Data.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> getAll();
        Task<User> get(int? userID);
        Task<int> add(User user);
        Task<int> delete(int? userID);
        Task update(User user);

    }
    public class UserRepository : IUserRepository
    {
        private readonly MoviePageDbContext _moviePageDbContext;
        public UserRepository(MoviePageDbContext moviePageDbContext)
        {
            _moviePageDbContext = moviePageDbContext;
        }

        public async Task<List<User>> getAll()
        {
            var query = await _moviePageDbContext.Users.ToListAsync();
            return query;
        }
        public async Task<User> get(int? userID)
        {
            if(_moviePageDbContext != null)
            {
                return await(from p in _moviePageDbContext.Users
                             where p.Id == userID
                             select new User
                             {
                                 Id = p.Id,
                                 Username = p.Username,
                                 Password = p.Password,
                                 Fullname = p.Fullname,
                                 Gender = p.Gender,
                                 Email = p.Email,
                                 DoB = p.DoB,
                                 PhoneNumber = p.PhoneNumber,
                                 Position = p.Position
                             }).FirstOrDefaultAsync();
            }
            return null;
        }

        public async Task<int> add(User user)
        {
            if(_moviePageDbContext != null)
            {
                await _moviePageDbContext.Users.AddAsync(user);
                await _moviePageDbContext.SaveChangesAsync();
                return user.Id;
            }
            return 0;
        }

        public async Task<int> delete(int? userID)
        {
            if(_moviePageDbContext != null)
            {
                var user = await _moviePageDbContext.Users.FirstOrDefaultAsync(x => x.Id == userID);
                if(user != null)
                {
                    _moviePageDbContext.Users.Remove(user);
                    int result = await _moviePageDbContext.SaveChangesAsync();
                    return result;
                }
            }
            return 0;
        }

        public async Task update(User user)
        {
            if(_moviePageDbContext != null)
            {
                _moviePageDbContext.Users.Update(user);
                await _moviePageDbContext.SaveChangesAsync();
            }
        }
    }
}

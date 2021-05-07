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
    public interface ICastRepository
    {
        Task<List<Cast>> getAll();
        Task<Cast> get(int? castID);
        Task<int> add(Cast cast);
        Task<int> delete(int? castID);
        Task update(Cast cast);
    }
    public class CastRepository : ICastRepository
    {
        private readonly MoviePageDbContext _moviePageDbContext;
        public CastRepository(MoviePageDbContext moviePageDbContext)
        {
            _moviePageDbContext = moviePageDbContext;
        }

        public async Task<List<Cast>> getAll()
        {
            return await _moviePageDbContext.Casts.ToListAsync();
        }

        public async Task<Cast> get(int? castID)
        {
            if(_moviePageDbContext != null)
            {
                return await (from p in _moviePageDbContext.Casts
                              where p.Id == castID
                              select new Cast
                              {
                                  Id = p.Id,
                                  Fullname = p.Fullname,
                                  DoB = p.DoB,
                                  Gender = p.Gender,
                                  Nationality = p.Nationality,
                                  Avatar = p.Avatar
                              }).FirstOrDefaultAsync();
            }
            return null;
        }

        public async Task<int> add(Cast cast)
        {
            if (_moviePageDbContext != null)
            {
                await _moviePageDbContext.Casts.AddAsync(cast);
                await _moviePageDbContext.SaveChangesAsync();
                return cast.Id;
            }
            return 0;
        }

        public async Task<int> delete(int? castID)
        {
            if (_moviePageDbContext != null)
            {
                var cast = await _moviePageDbContext.Casts.FirstOrDefaultAsync(x => x.Id == castID);
                if(cast != null)
                {
                    _moviePageDbContext.Casts.Remove(cast);
                    int result = await _moviePageDbContext.SaveChangesAsync();
                    return result;
                }
            }
            return 0;
        }

        public async Task update(Cast cast)
        {
            if (_moviePageDbContext != null)
            {
                _moviePageDbContext.Casts.Update(cast);
                await _moviePageDbContext.SaveChangesAsync();
            }
        }
    }
}

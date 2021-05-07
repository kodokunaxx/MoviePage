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
    public interface IMovieCastRepository
    {
        Task<List<MovieCast>> getAll();
        Task<int> add(MovieCast movieCast);
        Task<int> delete(int? movieCastID);
        Task update(MovieCast movieCast);
    }
    public class MovieCastRepository : IMovieCastRepository
    {
        private readonly MoviePageDbContext _moviePageDbContext;
        public MovieCastRepository(MoviePageDbContext moviePageDbContext)
        {
            _moviePageDbContext = moviePageDbContext;
        }

        public async Task<List<MovieCast>> getAll()
        {
            var query = await _moviePageDbContext.MovieCasts.ToListAsync();
            return query;
        }

        public async Task<int> add(MovieCast movieCast)
        {
            if (_moviePageDbContext != null)
            {
                await _moviePageDbContext.MovieCasts.AddAsync(movieCast);
                await _moviePageDbContext.SaveChangesAsync();
                return movieCast.Id;
            }
            return 0;
        }

        public async Task<int> delete(int? movieCastID)
        {
            if (_moviePageDbContext != null)
            {
                var movieCast = await _moviePageDbContext.MovieCasts.FirstOrDefaultAsync(x => x.Id == movieCastID);
                if (movieCast != null)
                {
                    _moviePageDbContext.MovieCasts.Remove(movieCast);
                    int result = await _moviePageDbContext.SaveChangesAsync();
                    return result;
                }
            }
            return 0;
        }

        public async Task update(MovieCast movieCast)
        {
            _moviePageDbContext.MovieCasts.Update(movieCast);
            await _moviePageDbContext.SaveChangesAsync();
        }
    }
}

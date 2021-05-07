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
    public interface IMovieRepository
    {
        Task<List<Movie>> getAll();
        Task<Movie> get(int? movieID);
        Task<int> add(Movie movie);
        Task<int> delete(int? movieID);
        Task update(Movie movie);
    }
    public class MovieRepository : IMovieRepository
    {
        private readonly MoviePageDbContext _moviePageDbContext;
        public MovieRepository(MoviePageDbContext moviePageDbContext)
        {
            _moviePageDbContext = moviePageDbContext;
        }

        public async Task<List<Movie>> getAll()
        {
            return await _moviePageDbContext.Movies.ToListAsync();
        }

        public async Task<Movie> get(int? movieID)
        {
            if (_moviePageDbContext != null)
            {
                return await (from p in _moviePageDbContext.Movies
                              where p.Id == movieID
                              select new Movie
                              {
                                  Id = p.Id,
                                  Title = p.Title,
                                  Overview = p.Overview,
                                  Release_date = p.Release_date,
                                  Director = p.Director,
                                  Backdrop = p.Backdrop,
                                  Poster = p.Poster,
                                  Time = p.Time,
                                  Nation = p.Nation,
                                  Episodes = p.Episodes,
                                  Language = p.Language,
                                  Youtube = p.Youtube
                              }).FirstOrDefaultAsync();
            }
            return null;
        }

        public async Task<int> add(Movie movie)
        {
            if (_moviePageDbContext != null)
            {
                await _moviePageDbContext.Movies.AddAsync(movie);
                await _moviePageDbContext.SaveChangesAsync();
                return movie.Id;
            }
            return 0;
        }

        public async Task<int> delete(int? movieID)
        {
            if (_moviePageDbContext != null)
            {
                var movie = await _moviePageDbContext.Movies.FirstOrDefaultAsync(x => x.Id == movieID);
                if(movie != null)
                {
                    _moviePageDbContext.Movies.Remove(movie);
                    int result = await _moviePageDbContext.SaveChangesAsync();
                    return result;
                }
            }
            return 0;
        }

        public async Task update(Movie movie)
        {
            if(_moviePageDbContext != null)
            {
                _moviePageDbContext.Movies.Update(movie);
                await _moviePageDbContext.SaveChangesAsync();
            }
        }
    }
}

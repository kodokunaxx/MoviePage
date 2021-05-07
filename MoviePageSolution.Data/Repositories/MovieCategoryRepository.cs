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
    public interface IMovieCategoryRepository
    {
        Task<int> add(MovieCategory movieCategory);
        Task<int> delete(int? movieCategoryID);
        Task update(MovieCategory movieCategory);
    }
    public class MovieCategoryRepository : IMovieCategoryRepository
    {
        private readonly MoviePageDbContext _moviePageDbContext;
        public MovieCategoryRepository(MoviePageDbContext moviePageDbContext)
        {
            _moviePageDbContext = moviePageDbContext;
        }
        public async Task<int> add(MovieCategory movieCategory)
        {

            if (_moviePageDbContext != null)
            {
                await _moviePageDbContext.MovieCategories.AddAsync(movieCategory);
                await _moviePageDbContext.SaveChangesAsync();
                return movieCategory.Id;
            }
            return 0;
        }

        public async Task<int> delete(int? movieCategoryID)
        {
            if (_moviePageDbContext != null)
            {
                var movieCategory = await _moviePageDbContext.MovieCategories.FirstOrDefaultAsync(x => x.Id == movieCategoryID);
                if (movieCategory != null)
                {
                    _moviePageDbContext.MovieCategories.Remove(movieCategory);
                    int result = await _moviePageDbContext.SaveChangesAsync();
                    return result;
                }
            }
            return 0;
        }

        public async Task update(MovieCategory movieCategory)
        {
            if (_moviePageDbContext != null)
            {
                _moviePageDbContext.MovieCategories.Update(movieCategory);
                await _moviePageDbContext.SaveChangesAsync();
            }
        }
    }
}

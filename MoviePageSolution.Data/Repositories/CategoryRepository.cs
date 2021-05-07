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
    public interface ICategoryRepository
    {
        Task<List<Category>> getAll();
        Task<int> add(Category category);
        Task<int> delete(int? categoryID);
        Task update(Category category);

    }
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MoviePageDbContext _moviePageDbContext;
        public CategoryRepository(MoviePageDbContext moviePageDbContext)
        {
            _moviePageDbContext = moviePageDbContext;
        }

        public async Task<List<Category>> getAll()
        {
            var query = await _moviePageDbContext.Categories.ToListAsync();
            return query;
        }

        public async Task<int> add(Category category)
        {
            if (_moviePageDbContext != null)
            {
                await _moviePageDbContext.Categories.AddAsync(category);
                await _moviePageDbContext.SaveChangesAsync();
                return category.Id;
            }
            return 0;
        }

        public async Task<int> delete(int? categoryID)
        {
            if (_moviePageDbContext != null)
            {
                var category = await _moviePageDbContext.Categories.FirstOrDefaultAsync(x => x.Id == categoryID);
                if (category != null)
                {
                    _moviePageDbContext.Categories.Remove(category);
                    int result = await _moviePageDbContext.SaveChangesAsync();
                    return result;
                }
            }
            return 0;
        }

        public async Task update(Category category)
        {
            _moviePageDbContext.Categories.Update(category);
            await _moviePageDbContext.SaveChangesAsync();
        }
    }
}

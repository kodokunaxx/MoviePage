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
    public interface IHistoryRepository
    {
        Task<List<History>> getAll();
        Task<int> add(History history);
        Task<int> delete(int? historyID);

    }
    public class HistoryRepository : IHistoryRepository
    {
        private readonly MoviePageDbContext _moviePageDbContext;
        public HistoryRepository(MoviePageDbContext moviePageDbContext)
        {
            _moviePageDbContext = moviePageDbContext;
        }

        public async Task<List<History>> getAll()
        {
            var query = await _moviePageDbContext.Histories.ToListAsync();
            return query;
        }

        public async Task<int> add(History history)
        {
            if (_moviePageDbContext != null)
            {
                await _moviePageDbContext.Histories.AddAsync(history);
                await _moviePageDbContext.SaveChangesAsync();
                return history.Id;
            }
            return 0;
        }

        public async Task<int> delete(int? historyID)
        {
            if (_moviePageDbContext != null)
            {
                var history = await _moviePageDbContext.Histories.FirstOrDefaultAsync(x => x.Id == historyID);
                if (history != null)
                {
                    _moviePageDbContext.Histories.Remove(history);
                    int result = await _moviePageDbContext.SaveChangesAsync();
                    return result;
                }
            }
            return 0;
        }
    }
}

using SQLitePCL;
using TheMovieWatchlist.Data;
using TheMovieWatchlist.Pages;

namespace TheMovieWatchlist.Services
{
    public class MovieWatchListService
    {
        private Dictionary<string, List<WatchlistItem>> userWatchlist = new Dictionary<string, List<WatchlistItem>>();


        public List<WatchlistItem> GetUserWatchList(string userId)
        {
            if (userWatchlist.ContainsKey(userId))
            {
                return userWatchlist[userId];
            }
            
            userWatchlist.Add(userId, new List<WatchlistItem>());
            return userWatchlist[userId];
        }

        public void AddMovie(string userId, WatchlistItem item)
        {
            userWatchlist[userId].Add(item);
        }

        public void RemoveMovie(string userId, WatchlistItem item)
        {
            var itemToBeRemoved = userWatchlist[userId].Where(w => w.MovieId == item.MovieId).FirstOrDefault();
            userWatchlist[userId].Remove(itemToBeRemoved);
        }

        public void UpdateStatus(string userId, string status, WatchlistItem item)
        {
            var itemToBeUpdated = userWatchlist[userId].Where(w => w.MovieId == item.MovieId).FirstOrDefault();
            itemToBeUpdated.Status = status;
        }
    }
}

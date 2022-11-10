using SQLitePCL;
using TheMovieWatchlist.Data;
using TheMovieWatchlist.Pages;

namespace TheMovieWatchlist.Services
{
    public class MovieWatchListService
    {
        private Dictionary<string, List<WatchlistItem>> userWatchlist = new Dictionary<string, List<WatchlistItem>>();


        public List<WatchlistItem> GetUserWatchList(string userEmail)
        {
            return userWatchlist[userEmail];
        }

        public void AddMovie(string userEmail, WatchlistItem item)
        {
            userWatchlist[userEmail].Add(item);
        }

        public void RemoveMovie(string userEmail, WatchlistItem item)
        {
            var itemToBeRemoved = userWatchlist[userEmail].Where(w => w.MovieId == item.MovieId).FirstOrDefault();
            userWatchlist[userEmail].Remove(itemToBeRemoved);
        }

        public void UpdateStatus(string userEmail, string status, WatchlistItem item)
        {
            var itemToBeUpdated = userWatchlist[userEmail].Where(w => w.MovieId == item.MovieId).FirstOrDefault();
            itemToBeUpdated.Status = status;
        }
    }
}

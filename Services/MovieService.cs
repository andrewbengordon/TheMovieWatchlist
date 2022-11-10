using System.Net.Http.Json;
using TheMovieWatchlist.Data;

namespace TheMovieWatchlist.Services
{
    public class MovieService
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl;
        private readonly string apiKey;

        public MovieService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            apiUrl = "https://imdb-api.com/en/API/";
            apiKey = "k_nclb94g0";
        }

        public async Task<MovieDetails> GetMovieDetailsAsync(string movieId)
        {
            var url = $"{apiUrl}Title/{apiKey}/{movieId}/FullActor";
            var movieDetails = await httpClient.GetFromJsonAsync<MovieDetails>(url);
            return movieDetails;
        }

        public async Task<YoutubeTrailer> GetMovieYoutubeTrailerAsync(string movieId)
        {
            var url = $"{apiUrl}YouTubeTrailer/{apiKey}/{movieId}";
            var youtubeTrailer = await httpClient.GetFromJsonAsync<YoutubeTrailer>(url);
            return youtubeTrailer;
        }
    }
}

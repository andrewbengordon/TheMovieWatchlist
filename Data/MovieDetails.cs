namespace TheMovieWatchlist.Data
{
    public class MovieDetails
    {
        public string id { get; set; }
        public string title { get; set; }
        public string originalTitle { get; set; }
        public string fullTitle { get; set; }
        public string type { get; set; }
        public string year { get; set; }
        public string image { get; set; }
        public string releaseDate { get; set; }
        public string runtimeMins { get; set; }
        public string runtimeStr { get; set; }
        public string plot { get; set; }
        public string plotLocal { get; set; }
        public bool plotLocalIsRtl { get; set; }
        public string awards { get; set; }
        public string directors { get; set; }
        public Directorlist[] directorList { get; set; }
        public string writers { get; set; }
        public Writerlist[] writerList { get; set; }
        public string stars { get; set; }
        public Starlist[] starList { get; set; }
        public Actorlist[] actorList { get; set; }
        public object fullCast { get; set; }
        public string genres { get; set; }
        public Genrelist[] genreList { get; set; }
        public string companies { get; set; }
        public Companylist[] companyList { get; set; }
        public string countries { get; set; }
        public Countrylist[] countryList { get; set; }
        public string languages { get; set; }
        public Languagelist[] languageList { get; set; }
        public string contentRating { get; set; }
        public string imDbRating { get; set; }
        public string imDbRatingVotes { get; set; }
        public string metacriticRating { get; set; }
        public object ratings { get; set; }
        public object wikipedia { get; set; }
        public object posters { get; set; }
        public object images { get; set; }
        public object trailer { get; set; }
        public Boxoffice boxOffice { get; set; }
        public object tagline { get; set; }
        public string keywords { get; set; }
        public string[] keywordList { get; set; }
        public Similar[] similars { get; set; }
        public object tvSeriesInfo { get; set; }
        public object tvEpisodeInfo { get; set; }
        public object errorMessage { get; set; }
    }

    public class Boxoffice
    {
        public string budget { get; set; }
        public string openingWeekendUSA { get; set; }
        public string grossUSA { get; set; }
        public string cumulativeWorldwideGross { get; set; }
    }

    public class Directorlist
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Writerlist
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Starlist
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Actorlist
    {
        public string id { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public string asCharacter { get; set; }
    }

    public class Genrelist
    {
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Companylist
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Countrylist
    {
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Languagelist
    {
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Similar
    {
        public string id { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string imDbRating { get; set; }
    }

}
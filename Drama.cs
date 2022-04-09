using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DramaLister
{
    [Serializable]
    public class Drama
    {
        public Drama()
        {

        }

        public Drama(string name)
        {
            dramaName = name;
        }

        public string dramaName { get; set; }
        public int epCount { get; set; }

        public enum Country
        {
            China,
            Japan,
            Korea,
            Taiwan,
            Thailand
        }

        public Country CountryOrigin { get; set; }

        public bool fave { get; set; }
        public bool popular { get; set; }
        public bool wellMade { get; set; }

        public bool unknownDate { get; set; }

        public Dictionary<string, bool> genres = new Dictionary<string, bool>
        {
            { "Romance", false },
            { "Action", false },
            { "Horror", false },
            { "Fantasy", false },
            { "Wuxia", false },
            { "Comedy", false },
            { "BL", false },
            { "Drama", false },
            { "Melodrama", false },
            { "Sci-Fi", false },
            { "Sports", false },
            { "Thriller", false },
            { "Web Drama", false },
            { "Historical", false }
        };

        public List<string> tropes = new List<string>();

        public int rating { get; set; }

        public string comments { get; set; }
    }
}

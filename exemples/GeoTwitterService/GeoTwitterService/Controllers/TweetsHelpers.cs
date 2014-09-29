using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeoTwitterService.Controllers
{
    public static class TweetsHelpers
    {
        public static IEnumerable<Tweet> NearBy(this IEnumerable<Tweet> tweets, int nbKm)
        {
            return tweets;
        }
        public static IEnumerable<Tweet> FromAndTo(this IEnumerable<Tweet> tweets, string user)
        {
            return tweets;
        }
    }
}

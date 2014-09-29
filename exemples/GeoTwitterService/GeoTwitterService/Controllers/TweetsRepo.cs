using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeoTwitterService.Controllers
{
    public class TweetsRepo
    {
        public TweetsRepo()
        {
            tweets = new Stack<Tweet>();
        }

        public IEnumerable<Tweet> Tweets { get { return tweets; } }

        internal void Save(dynamic tweet)
        {
            tweets.Push(FromDynamic(tweet));
        }

        private Tweet FromDynamic(dynamic tweet)
        {
            return new Tweet
            {
                Lat = tweet.lat,
                Lon = tweet.lon,
                Text = tweet.text,
                Date = tweet.date,
                User = tweet.User
            };
        }

        Stack<Tweet> tweets;
    }
}

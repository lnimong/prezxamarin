namespace GeoTwitter.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    using GeoTwitter.Tools;

    using Xamarin.Forms;

    public class Repository
    {
        private static readonly List<Tweet> Tweets = new List<Tweet>
                                            {
                                                new Tweet
                                                {
                                                    Date = DateTime.Now.AddDays(-1),
                                                    Text = "le troisième tweet",
                                                    User = "moi"
                                                },
                                                new Tweet
                                                {
                                                    Date = DateTime.Now.AddDays(-1),
                                                    Text = "le deuxieme tweet",
                                                    User = "moi"
                                                },
                                                new Tweet
                                                {
                                                    Date = DateTime.Now.AddDays(-1),
                                                    Text = "le promier tweet",
                                                    User = "moi"
                                                }
                                            };


        public IList<Tweet> GetTweets()
        {
            return Tweets;
        }

        public void Save(Tweet tweet)
        {
            var position = DependencyService.Get<IPositionManager>().GetCurrentPosition();

            if (position != null)
            {
                tweet.Position = position;
            }

            Tweets.Add(tweet);
        }
    }
}
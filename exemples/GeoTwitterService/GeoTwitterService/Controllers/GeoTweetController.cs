using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GeoTwitterService.Controllers
{
    public class GeoTweetController : ApiController
    {
        TweetsRepo repo = new TweetsRepo();

        // GET api/values
        public TweetResponse Get(double lat, double lon)
        {
            try
            {
                return new TweetResponse
                {
                    Tweets = repo.Tweets.NearBy(1)
                };
            }
            catch (Exception ex)
            {
                return new TweetResponse
                {
                    Error = ex.Message
                };
            }
        }

        // GET api/values
        public TweetResponse Get(string user)
        {
            try
            {
                return new TweetResponse
                {
                    Tweets = repo.Tweets.FromAndTo(user)
                };
            }
            catch (Exception ex)
            {
                return new TweetResponse
                {
                    Error = ex.Message
                };
            }
        }

        // POST api/values
        public TweetResponse Post([FromBody]string user, [FromBody]string text, [FromBody]double lat, [FromBody]double lon)
        {
            try
            {
                repo.Save(new
                {
                    text,
                    lat,
                    lon,
                    date = DateTime.Now,
                    user
                });
                return Get(lat, lon);
            }
            catch (Exception ex)
            {
                return new TweetResponse
                {
                    Error = ex.Message
                };
            }
        }

    }
}

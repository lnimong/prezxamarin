using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeoTwitterService.Controllers
{
    public class TweetResponse
    {
        public IEnumerable<Tweet> Tweets { get; set; }

        public string Error { get; set; }
    }
}

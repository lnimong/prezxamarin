using GeoTwitter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoTwitter.VM
{
    public class TweetsViewModel
    {
        public IEnumerable<Tweet> Tweets
        {
            get
            {
                return new Tweet[] { 
                    new Tweet{
                        Date = "hier",
                        Text = "le troisième tweet",
                        User = "moi"
                    }, 
                    new Tweet{
                        Date = "hier",
                        Text = "le deuxieme tweet",
                        User = "moi"
                    }, 
                    new Tweet{
                        Date = "hier",
                        Text = "le promier tweet",
                        User = "moi"
                    }};
            }
        }
    }
}

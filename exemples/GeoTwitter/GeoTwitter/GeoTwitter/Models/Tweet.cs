﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoTwitter.Models
{
    using GeoTwitter.Tools;

    public class Tweet
    {
        public string Text { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public Position Position { get; set; }
    }
}

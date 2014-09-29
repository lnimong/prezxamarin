using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeoTwitterService.Controllers
{
    public class Tweet
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string Text { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public string DateDesc
        {
            get
            {
                if (Date == null)
                {
                    return string.Empty;
                }

                var now = DateTime.Now;
                var timespan = (now - Date);
                if (timespan.TotalMinutes <= 5) return "à l'instant";
                if (timespan.TotalHours <= 3) return "tout à l'heure";
                if (timespan.TotalDays <= 1 && Date.Day == now.Day) return "aujourd'hui";
                if (Date.Day == now.AddDays(-1).Day) return "hier";
                if (timespan.TotalDays <= 7) return "dans la semaine";
                return "il y a longtemps";
            }
        }
    }
}

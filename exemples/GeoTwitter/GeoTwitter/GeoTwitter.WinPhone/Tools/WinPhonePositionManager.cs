using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoTwitter.WinPhone.Tools
{
    using Windows.Devices.Geolocation;

    using GeoTwitter.Tools;

    public class WinPhonePositionManager : IPositionManager
    {
        public Position GetCurrentPosition()
        {
            var geo = new Geolocator();

            var async = geo.GetGeopositionAsync().AsTask();

            var result = Task.WhenAny(async);

            return new Position()
                       {
                           Latitude = result.Result.Result.Coordinate.Latitude,
                           Longitude = result.Result.Result.Coordinate.Longitude
                       };
        }
    }
}

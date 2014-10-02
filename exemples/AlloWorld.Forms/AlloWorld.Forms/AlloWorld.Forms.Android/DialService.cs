using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AlloWorld.Forms.Droid;


[assembly: Xamarin.Forms.Dependency(typeof(DialService))]
namespace AlloWorld.Forms.Droid
{
    using AlloWorld.Forms.Models;

    using Android.App;
    using Android.Content;

    public class DialService : IDialService
    {
        private static Activity mainActivity;

        public static void SetMainActivity(Activity mainActivity)
        {
            DialService.mainActivity = mainActivity;
        }

        public void Dial(string name, string number)
        {
            Intent callIntent = new Intent(Intent.ActionCall);
            callIntent.SetData(Android.Net.Uri.Parse("tel:" + number));
            mainActivity.StartActivity(callIntent);
        }
    }
}

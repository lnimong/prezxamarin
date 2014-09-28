using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using AlloWorld.SharedCode;
using System.Linq;

namespace Android
{
    [Activity(Label = "Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        private DialerModel model;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            model = new DialerModel(new DialService (this));

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            
            
            
            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton0);

            InitButton(button, model.Contacts.First(), model.Dial);

        }

        private void InitButton(Button button, string buttonname, Action<string> call)
        {
            button.Text = buttonname;
            button.Click += delegate { call(buttonname); };
        }
    }
}


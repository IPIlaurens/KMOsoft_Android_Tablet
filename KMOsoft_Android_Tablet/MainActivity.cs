using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace KMOsoft_Android_Tablet
{
    [Activity(Label = "KMOsoft_Android_Tablet", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Initialise Variables from main screen
            Button leveringenBtn = FindViewById<Button>(Resource.Id.leveringenBtn);


            //OnClick events for buttons
            leveringenBtn.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(LeveringActivity));
                StartActivity(intent);
            };


        }
    }
        
}


using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaPoderosaApp2022
{
    [Activity(Label = "ActivityInicio")]
    public class ActivityInicio : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
             SetContentView(Resource.Layout.inicio);
        }
    }
}
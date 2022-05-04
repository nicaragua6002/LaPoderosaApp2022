using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace LaPoderosaApp2022
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btn1, btn2,btn3;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            //Inicio
            btn1 = FindViewById<Button>(Resource.Id.Button1);
            btn1.Click += Btn1_Click;
            //Historia
            btn2 = FindViewById<Button>(Resource.Id.Button2);
            btn2.Click += Btn2_Click;
            //Mision
            btn3 = FindViewById<Button>(Resource.Id.Button3);
            btn3.Click += Btn3_Click;
        }

        private void Btn3_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityMision));
            StartActivity(i);
        }

        private void Btn2_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityHistoria));
            StartActivity(i);
        }

        private void Btn1_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityInicio));
            StartActivity(i);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
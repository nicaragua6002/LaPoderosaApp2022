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
    [Activity(Label = "ActivitySucursales")]
    public class ActivitySucursales : Activity
    {
        ListView lvsucursales;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.sucursales);
            lvsucursales = FindViewById<ListView>(Resource.Id.listView1);
            //Asignamos los valores a mostrar mediante el adaptador
                   
                /* 
                     //Ejemplo 1 cargar valores a partir de una lista de string
                    List<string> listavalores = new List<string> { "Leon", "Masaya","Boaco"};
                    lvsucursales.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, listavalores);
                */
            
            //Ejemplo 2: Cargar valores con un adaptador personalizado y una lista de objetos
            lvsucursales.Adapter = new AdapterSucursales(this,  Global.Sucursales);

          
        }

      
    }
}
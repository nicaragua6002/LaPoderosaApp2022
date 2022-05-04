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
    class AdapterSucursales : BaseAdapter
    {
        //Definimos un variable para el contexto y la lista de los valores a mostrar
        Activity context;
        List<Global.Sucursal> lista;

        //Generamos su respectivo constructor
        public AdapterSucursales(Activity context, List<Global.Sucursal> lista)
        {
            this.context = context;
            this.lista = lista;
        }

        public override int Count => lista.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = lista[position];
            View view = convertView;
            if (view == null) //no hay vista para reusar, se crea una nueva
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);
            //Asigamos los valores a los campos del diseño selecionado para el listview
            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Departamento;
            view.FindViewById<TextView>(Android.Resource.Id.Text2).Text = item.Responsable;

            return view;
        }
    }
}
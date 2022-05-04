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
    public static class Global
    {
        public static List<Sucursal> Sucursales = new List<Sucursal>()
        {
            new Sucursal(1,"Leon","LOPEZ ORTIZ ISABEL","22564578","Del la catedral","")
            , new Sucursal(2,"Chinandega","PEREZ BERNAL MANUELA","22564578","Del la catedral","")
            , new Sucursal(3,"Ocotal","MORALES GARCIA JUAN JOSE","22564578","Del la catedral","")
            , new Sucursal(4,"Estelí","SOLA FLORES MONICA","22564578","Del la catedral","")
             ,new Sucursal(5,"Matagalpa","DOÑA MORALES MONICA","22564578","Del la catedral","")
        };
        public class Sucursal
        {
            int id;
            string departamento;
            string responsable;
            string tel;
            string direccion;
            string coordenadas;

            public Sucursal(int id, string departamento, string responsable, string tel, string direccion, string coordenadas)
            {
                this.id = id;
                this.departamento = departamento;
                this.responsable = responsable;
                this.tel = tel;
                this.direccion = direccion;
                this.coordenadas = coordenadas;
            }

            public int Id { get => id; set => id = value; }
            public string Departamento { get => departamento; set => departamento = value; }
            public string Responsable { get => responsable; set => responsable = value; }
            public string Tel { get => tel; set => tel = value; }
            public string Direccion { get => direccion; set => direccion = value; }
            public string Coordenadas { get => coordenadas; set => coordenadas = value; }
        }
    }
}
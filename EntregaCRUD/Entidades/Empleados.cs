using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaCRUD.Entidades
{
    internal class Empleados
    {
        private int Id;
        private string Nombre;
        private string Apellido;
        private string Direccion;
        private string Telefono;
        private DateTime FechaIngreso;
        private int idArea;

        public int Id1 { get => Id; set => Id = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public DateTime FechaIngreso1 { get => FechaIngreso; set => FechaIngreso = value; }
        public int IdArea { get => idArea; set => idArea = value; }
    }
}

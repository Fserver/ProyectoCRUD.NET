using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaCRUD.Entidades
{
    internal class Nominas
    {
        private int Id;
        private DateTime Fecha;
        private int idEmpleado;
        private decimal sueldo;
        private decimal DiasLaborados;
        private decimal Basico;
        private decimal TotalDevengado;

        public int Id1 { get => Id; set => Id = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public decimal Sueldo { get => sueldo; set => sueldo = value; }
        public decimal DiasLaborados1 { get => DiasLaborados; set => DiasLaborados = value; }
        public decimal Basico1 { get => Basico; set => Basico = Sueldo * DiasLaborados; }
        public decimal TotalDevengado1 { get => TotalDevengado; set => TotalDevengado = Basico1; }
    }
}

using EntregaCRUD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaCRUD.Controladores
{
    internal class NominasController
    {
        private List<Nominas> _Nominas;
        public NominasController()
        {
            _Nominas = new List<Nominas>();
        }
        public List<Nominas> Nominas { get { return _Nominas; } }

        public void post(DateTime fecha, int idEmpleado, decimal sueldo, decimal diasLaborados)
        {
            Nominas.Add(new Nominas()
            {
                Id1 = Funciones.autoIncremento(Nominas),
                Fecha1 = fecha,
                IdEmpleado = idEmpleado,
                Sueldo = sueldo,
                DiasLaborados1 = diasLaborados,
                Basico1 = (sueldo * diasLaborados)/30,
                TotalDevengado1 = (sueldo * diasLaborados) / 30
            });
        }
        public void get()
        {
            Funciones.Imprimir(Nominas);
        }
        public bool getById(int id)
        {
            List<Nominas> lista = new List<Nominas>();
            lista.AddRange(from o in Nominas where o.Id1 == id select o);
            Funciones.Imprimir(lista);
            if (lista.Count() != 0)
            {
                return true;
            }
            return false;
        }
        public void put(int id, DateTime fecha, int idEmpleado, decimal sueldo, decimal diasLaborados)
        {
            Nominas.Where(o => o.Id1 == id).ToList().ForEach(o =>
            {
                o.Fecha1 = fecha;
                o.IdEmpleado = idEmpleado;
                o.Sueldo = sueldo;
                o.DiasLaborados1 = diasLaborados;
                o.Basico1 = (sueldo * diasLaborados) / 30;
                o.TotalDevengado1 = (sueldo * diasLaborados) / 30;
            });
        }
        public void delete(int id)
        {
            var elemento = Nominas.FirstOrDefault(o => o.Id1 == id);
            Nominas.Remove(elemento);
        }
    }
}
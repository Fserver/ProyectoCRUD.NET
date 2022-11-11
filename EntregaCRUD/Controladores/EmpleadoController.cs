using EntregaCRUD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaCRUD.Controladores
{
    internal class EmpleadoController
    {
        private List<Empleados> _Empleados;

        public EmpleadoController()
        {
            _Empleados = new List<Empleados>();
        }

        public List<Empleados> Empleados
        {
            get { return _Empleados; }
        }

        public void post(string nombre, string apellido, string direccion, string telefono, DateTime fechaIngreso, int idArea)
        {
            AreaController areaController = new AreaController();
            areaController.get();

            Console.WriteLine("Bbb");

            if (AreaController.Existe)
            {
                Empleados.Add(new Empleados()
                {
                    Id1 = Funciones.autoIncremento(Empleados),
                    Nombre1 = nombre,
                    Apellido1 = apellido,
                    Direccion1 = direccion,
                    Telefono1 = telefono,
                    FechaIngreso1 = fechaIngreso,
                    IdArea = idArea
                });
            }
        }
        public void get()
        {
            Funciones.Imprimir(Empleados);
        }
        public void getById(int id)
        {
            List<Empleados> lista = new List<Empleados>();
            lista.AddRange(from o in Empleados where o.Id1 == id select o);
            Funciones.Imprimir(lista);
        }
        public void put(int id, string nombre, string apellido, string direccion, string telefono, DateTime fechaIngreso, int idArea)
        {
            Empleados.Where(o => o.Id1 == id).ToList().ForEach(o =>
            {
                o.Nombre1 = nombre;
                o.Apellido1 = apellido;
                o.Direccion1 = direccion;
                o.Telefono1 = telefono;
                o.FechaIngreso1 = fechaIngreso;
                o.IdArea = idArea;
            });
        }
        public void delete(int id)
        {
            var elemento = Empleados.FirstOrDefault(o => o.Id1 == id);
            Empleados.Remove(elemento);
        }
    }
}

using EntregaCRUD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaCRUD.Controladores
{
    internal class AreaController
    {
        private List<Areas> _Areas;
        public static bool Existe;
        public AreaController()
        {
            if (_Areas == null) { _Areas = new List<Areas>(); } else { _Areas = Areas.ToList(); }
        }

        public List<Areas> Areas { get { return _Areas; } }

        public void post(string nombre)
        {
            Areas.Add(new Areas()
            {
                Id1 = Funciones.autoIncremento(Areas),
                Nombre1 = nombre
            });
        }
        public void get()
        {
            Funciones.Imprimir(Areas);
        }
        public void getById(int id)
        {
            List<Areas> lista = new List<Areas>();
            lista.AddRange(from o in Areas where o.Id1 == id select o);
            Funciones.Imprimir(lista);
        }
        public void put(int id, string nombre)
        {
            Areas.Where(o => o.Id1 == id).ToList().ForEach(o =>
            {
                o.Nombre1 = nombre;
            });
        }
        public void delete(int id)
        {
            var elemento = Areas.FirstOrDefault(o => o.Id1 == id);
            Areas.Remove(elemento);
        }
    }
}

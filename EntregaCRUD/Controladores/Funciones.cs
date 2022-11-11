using EntregaCRUD.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaCRUD.Controladores
{
    static internal class Funciones
    {
        public static void Imprimir(List<Areas> areas)
        {
            foreach (var item in areas)
            {
                Console.WriteLine($"ID: {item.Id1} NOMBRE: {item.Nombre1}");
            }
        }
        public static void Imprimir(List<Empleados> empleados)
        {
            foreach (var item in empleados)
            {
                Console.WriteLine($"ID: {item.Id1} " +
                    $"\nNOMBRE: {item.Nombre1} " +
                    $"\nAPELLIDO: {item.Apellido1} " +
                    $"\nDIRECCION: {item.Direccion1} " +
                    $"\nTELEFONO: {item.Telefono1} " +
                    $"\nFECHA DE INGRESO: {item.FechaIngreso1} " +
                    $"\nAREA: {item.IdArea}");
            }
        }
        public static void Imprimir(List<Nominas> nominas)
        {
            foreach (var item in nominas)
            {
                Console.WriteLine($"ID: {item.Id1}" +
                    $"\nFECHA: {item.Fecha1}" +
                    $"\nFECHA: {item.IdEmpleado}" +
                    $"\nFECHA: {item.Sueldo}" +
                    $"\nFECHA: {item.DiasLaborados1}" +
                    $"\nSUELDO BÁSICO: {item.Basico1}" +
                    $"\nTOTAL DEVENGADO: {item.TotalDevengado1}");
            }
        }
        public static int autoIncremento(List<Areas> lista)
        {
            return lista.Count == 0 ?
                1
                :
                (lista[lista.Count - 1].Id1) + 1;
        }
        public static int autoIncremento(List<Empleados> lista)
        {
            return lista.Count == 0 ?
                1
                :
                (lista[lista.Count - 1].Id1) + 1;
        }
        public static int autoIncremento(List<Nominas> lista)
        {
            return lista.Count == 0 ?
                1
                :
                (lista[lista.Count - 1].Id1) + 1;
        }
    }
}

using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicacion de Gestion de Empleados");

            List<Empleado> listaEmpleados = new List<Empleado>();

            listaEmpleados.Add(new Empleado("Juan", 101, 30000));
            listaEmpleados.Add(new Empleado("Maria", 102, 35000));
            listaEmpleados.Add(new Empleado("Pedro", 103, 32000, false));


            foreach (var empleado in listaEmpleados)
            {
                empleado.MostrarDetalles();
            }

            int numeroEmpleadoCambiarEstado = 103;
            Empleado empleadoCambiarEstado = BuscarEmpleado(listaEmpleados, numeroEmpleadoCambiarEstado);

            if (empleadoCambiarEstado != null)
            {
                empleadoCambiarEstado.CambiarEstado(1);
                empleadoCambiarEstado.AumentarSalario(25);
                empleadoCambiarEstado.MostrarDetalles();

            }
            else
            {
                Console.WriteLine($"Empleado con numero {numeroEmpleadoCambiarEstado} no encontrado.");
            }
            

            static Empleado BuscarEmpleado(List<Empleado> empleados, int numeroEmpleado)
            {
                foreach(var empleado in empleados)
                {
                    if(empleado.ObtenerNumeroEmpleado() == numeroEmpleado)
                    {
                        return empleado;
                    }
                }
                return null;

            }
            
        }   
    }
}

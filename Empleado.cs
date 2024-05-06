using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Empleado
    {
        private string nombre;
        private int numeroEmpleado;
        private decimal salario;
        private bool activo;

       
        public Empleado(string nombre, int numeroEmpleado, decimal salario, bool activo = true)
        {
            this.nombre = nombre;
            this.numeroEmpleado = numeroEmpleado;
            this.salario = salario;
            this.activo = activo;
        }

        public void MostrarDetalles()
        {
            string estado = (activo) ? "Activo" : "Inactivo";
            Console.WriteLine($"Nombre: {nombre}, Numero de Empleado: {numeroEmpleado}, Salario: {salario:C}, Estado: {estado}");
        }
        public int ObtenerNumeroEmpleado()
        {
            return this.numeroEmpleado;
        }

        public void CambiarEstado(int nuevoEstado)
        {
            if (nuevoEstado ==1)
            {
                activo = true ;
                Console.WriteLine("Empleado activado.");

            }
            else if(nuevoEstado ==0)
            { 
                activo= false ;
                Console.WriteLine("Empleado desactivado.");

            }
            else
            {
                Console.WriteLine("Estado no valido.");
            }
        }
    }   
}

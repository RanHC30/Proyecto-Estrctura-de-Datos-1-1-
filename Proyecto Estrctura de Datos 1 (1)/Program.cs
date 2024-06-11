using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Estrctura_de_Datos_1__1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
        }//Fin del main

        static void MostrarMenu()
        {
            string opcion = "";
            string menu = "***Aplicación pago de servicios públicos***\n";
            menu += "1. Inicializar Vectores\n";
            menu += "2. Realizar Pagos\n";
            menu += "3. Consultar Pagos\n";
            menu += "4. Modificar Pagos\n";
            menu += "5. Eliminar Pagos\n";
            menu += "6. Submenú Reportes\n";
            menu += "7. Salir\n";
            menu += "Digite una opción: ";
            do
            {
                Console.WriteLine(menu);
                opcion = Console.ReadLine();
                //Validar

                switch (opcion)
                {

                    case "1":
                        InicializarVectores();
                        break;

                    case "2":

                        break;

                    case "3":

                        break;

                    case "4":

                        break;

                    case "5":
                        break;

                    case "6":
                        SubMenu();
                        break;


                    case "7":
                        Environment.Exit(0);
                        break;

                }


            } while (opcion != "7");

        }//Fin mostrar menu


        static void SubMenu()
        {
            string opci = "";
            string men = "***Sub Menú Reportes***\n";
            men += "1.Ver todos los Pagos\n";
            men += "2.Ver Pagos por tipo de Servicio\n";
            men += "3.Ver Pagos por código de caja\n";
            men += "4.Ver Dinero Comisionado por servicios\n";
            men += "5.Regresar Menú Principal\n";
            men += "Digite una opción";

            do
            {

                Console.WriteLine(men);
                opci = Console.ReadLine();

                switch (opci)
                {
                    case "1":
                        
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5:":
                        MostrarMenu();
                        break;
                }

            } while (opci != "5");

        }//Fin SubMenu


        static void InicializarVectores()
        {
            int[] numeroPago = new int[10];
            Console.WriteLine("Vectores inicializados correctamente");
        }





    }//Fin del program
}//Fin del namespace

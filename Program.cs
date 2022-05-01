using System;
using Control;

namespace View
{
    class Program
    {
        const PRODUCT_PRICE = 2000;

        static public void Main(String[] args)
        {
            Console.WriteLine("Bienvenido a la maquina expendedora");
            bool expected_answer = false;

            string input_client = "";

            do
            {
                Console.WriteLine(
                    "Por favor indique si es cliente o proveedor [Cliente] o [Proveedor]"
                );

                input_client = Console.ReadLine();

                if (input_client == "Cliente" || input_client == "Proveedor")
                {
                    expected_answer = true;
                }
            } while (!expected_answer);

            if (input_client == "Proveedor")
            {
                Console.WriteLine(
                    "Por favor ingrese los productos con el siguiente formato: 'Nombre, Precio'"
                );

                bool finished_product_input = false;
                List<string> product_list = new List<string>();
                while (!finished_product_input)
                {
                    Console.WriteLine("Ingrese el producto: ");

                    // TO-DO Manejar exepciones cuando el dato ingresado no sea un string
                    product_list.Add(Console.ReadLine());

                    Console.WriteLine("Desea ingresar otro producto? [Si] o [No]");
                    string client_input = Console.ReadLine();
                    if (client_input == "N")
                    {
                        finished_product_input = true;
                    }
                }
            }else
            {
                
                //TO-DO: Debemos cambiar la constante de precio del producto, por el precio de cada instancia de la clase consumable

                Controller controller = new Controller();

                controler.MoneyReceived(PRODUCT_PRICE);

                Console.WriteLine("Por favor ingrese la cantidad de dinero total: "+ PRODUCT_PRICE);
               
            }


        }
    }
}

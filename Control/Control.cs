using System;
using Model;
namespace Control {

    class Controller{

        private Queue<int> money_received{get;set;}

        public Controller(){

        }

        public void MoneyReceived(int price){

                int accumulated_bills = 0;

                 while(accumulated_bills <= price){

                    int temp_money_received = Convert.ToInt32(Console.ReadLine);

                    money_received.Enqueue(temp_money_received);

                    accumulated_bills += temp_money_received;

                    Console.WriteLine("Usted ingreso: "+ accumulated_bills);
                }


            }
        

    }
}
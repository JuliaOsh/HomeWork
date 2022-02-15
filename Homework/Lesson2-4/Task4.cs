using System;

namespace Lesson2_4
{
    class Task4
    {
        static void Main(string[] args)
        {
            int znkkt = 46005869;
            string rnkkt = "0005393479040745";
            long fn = 92820000100243388;
            DateTime day = new DateTime(21, 12, 18, 21, 50, 00);
            int cashier = 487341;
            int shop = 320799;
            int check = 2863;
            int register = 3;
            DateTime time = new DateTime(21, 12, 18, 21, 49, 00);
            int id = 1129533121;
            int articul = 0991755;
            string price = "2299.00";
            int NDS = 20;
            int numberOfItems = 2;
            string total = "4598.00";
            double NDStotal = 766.34;

            Console.WriteLine($"                   H&M                                \n" +
                              $"         H and M Hannes and Maurits                   \n" +
                              $"                  CHECK                               \n" +
                              $"ZN KKT:{znkkt}      PN KKT:{rnkkt}                    \n" +
                              $"FN:{fn}   {day:MM/dd/yy H:mm}                         \n" +
                              $"                  INCOME                              \n" +
                              $" --------------------------------------------------   \n" +
                              $" Cashier:{cashier}   Shop:{shop} Check:{check}        \n" +
                              $" {day:MM/dd/yy} Register:{register} Time:{time:H:mm}  \n" +
                              $" F Check: 0005393479040745 139 148           \n" +
                              $" --------------------------------------------------   \n" +
                              $" Customer ID {id}                                     \n" +
                              $" {articul} Robe L/XL Purple                           \n" +
                              $" 1.00*{price}                                 ={price}   \n" +
                              $" {NDS}%                                               \n" +
                              $" {articul} Robe S/M Black                             \n" +
                              $" 1.00*{price}                                 ={price}   \n" +
                              $" {NDS}%                                               \n" +
                              $" Number of items: {numberOfItems}                     \n" +
                              $" TOTAL                                        ={total}   \n" +
                              $" TOTAL FEES  {NDS}%                              ={NDStotal}\n" +
                              $" MASTERCARD                                   ={total}   \n" +
                              $" --------------------------------------------------   \n"
                              );
                               
        }
    }
}

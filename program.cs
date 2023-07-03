using OOPVendingMachineConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Wish1(int amountOfdrinks)
        {
            Console.WriteLine("Do you wish to buy " + (int)amountOfdrinks + " of this drink Yes or No");

        }
        static void Main(string[] args)
        {


            int loop = 0;
            int totalPrice;
            Menu menu1 = new Menu(); //Menu Class
            menu1.Drinknames = "           1 .Cocacola               ";
            menu1.PriceofDrinks = 48;

            Menu menu2 = new Menu();
            menu2.Drinknames = "           2. Pepsi                  ";
            menu2.PriceofDrinks = 45;

            Menu menu3 = new Menu();
            menu3.Drinknames = "           3. Royal                  ";
            menu3.PriceofDrinks = 46;

            Menu menu4 = new Menu();
            menu4.Drinknames = "           4. Sprite                 ";
            menu4.PriceofDrinks = 43;

            Menu menu5 = new Menu();
            menu5.Drinknames = "           5. Lemonade               ";
            menu5.PriceofDrinks = 20;

            Menu menu6 = new Menu();
            menu6.Drinknames = "           6. Mug Rootbeer           ";
            menu6.PriceofDrinks = 49;

            Menu menu7 = new Menu();
            menu7.Drinknames = "           7. YaKult                 ";
            menu7.PriceofDrinks = 36;

            Menu menu8 = new Menu();
            menu8.Drinknames = "           8. Mountain Dew           ";
            menu8.PriceofDrinks = 43;







            do
            {
                Console.WriteLine("-----------Vending Machine-----------");
                Console.WriteLine("-----------Choose a drink------------");
                Console.WriteLine(menu1.Drinknames);
                Console.WriteLine(menu2.Drinknames);
                Console.WriteLine(menu3.Drinknames);
                Console.WriteLine(menu4.Drinknames);
                Console.WriteLine(menu5.Drinknames);
                Console.WriteLine(menu6.Drinknames);
                Console.WriteLine(menu7.Drinknames);
                Console.WriteLine(menu8.Drinknames);
                Console.WriteLine("___________PRESS 0 TO EXIT___________");

                Console.WriteLine("         ENTER YOUR CHOICE           ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 1)
                {
                    Console.WriteLine("         You Selected Cocacola       ");
                    Console.WriteLine("          Cocacola = P48             ");

                    Console.WriteLine("Enter the amount you want to purchase");
                    int amountOfdrinks = Convert.ToInt32(Console.ReadLine());

                    totalPrice = 48 * amountOfdrinks;

                    Wish1((int)amountOfdrinks);
                    string userInput2 = Console.ReadLine();

                    if (userInput2.ToLower() == "Yes" || userInput2.ToLower() == "YES" || userInput2.ToLower() == "yes")
                    {
                        Console.WriteLine("You Purchase " + (int)amountOfdrinks + " Cocacola = P" + (int)totalPrice);
                    }
                    else if (userInput2.ToLower() == "No" || userInput2.ToLower() == "NO" || userInput2.ToLower() == "no")
                    {
                        Console.WriteLine("!!!Your cancel your order!!!");
                        continue; // pag pinili yung no ibabalik sya sa choose a drink
                    }
                    else
                    {
                        Console.WriteLine("");
                    }



                }
                else if (userInput == 2)
                {
                    Console.WriteLine("          You Selected Pepsi         ");
                    Console.WriteLine("             Pepsi = P45             ");

                    Console.WriteLine("Enter the amount you want to purchase");
                    int amountOfdrinks = Convert.ToInt32(Console.ReadLine());

                    totalPrice = 45 * amountOfdrinks;

                    Wish1((int)amountOfdrinks);
                    string userInput2 = Console.ReadLine();
                    if (userInput2.ToLower() == "Yes" || userInput2.ToLower() == "YES" || userInput2.ToLower() == "yes")
                    {
                        Console.WriteLine("You Purchase " + (int)amountOfdrinks + " Pepsi = P" + (int)totalPrice);
                    }
                    else if (userInput2.ToLower() == "No" || userInput2.ToLower() == "NO" || userInput2.ToLower() == "no")
                    {
                        Console.WriteLine("!!!Your cancel your order!!!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("          You Selected Royal         ");
                    Console.WriteLine("              Royal = P46            ");

                    Console.WriteLine("Enter the amount you want to purchase");
                    int amountOfdrinks = Convert.ToInt32(Console.ReadLine());

                    totalPrice = 46 * amountOfdrinks;

                    Wish1((int)amountOfdrinks);
                    string userInput2 = Console.ReadLine();
                    if (userInput2.ToLower() == "Yes" || userInput2.ToLower() == "YES" || userInput2.ToLower() == "yes")
                    {
                        Console.WriteLine("You Purchase " + (int)amountOfdrinks + " Royal = P" + (int)totalPrice);
                    }
                    else if (userInput2.ToLower() == "No" || userInput2.ToLower() == "NO" || userInput2.ToLower() == "no")
                    {
                        Console.WriteLine("!!!Your cancel your order!!!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }


                }
                else if (userInput == 4)
                {
                    Console.WriteLine("          You Selected Sprite        ");
                    Console.WriteLine("             Sprite = P43            ");

                    Console.WriteLine("Enter the amount you want to purchase");
                    int amountOfdrinks = Convert.ToInt32(Console.ReadLine());

                    totalPrice = 43 * amountOfdrinks;

                    Wish1((int)amountOfdrinks);
                    string userInput2 = Console.ReadLine();
                    if (userInput2.ToLower() == "Yes" || userInput2.ToLower() == "YES" || userInput2.ToLower() == "yes")
                    {
                        Console.WriteLine("You Purchase " + (int)amountOfdrinks + " Sprite = P" + (int)totalPrice);
                    }
                    else if (userInput2.ToLower() == "No" || userInput2.ToLower() == "NO" || userInput2.ToLower() == "no")
                    {
                        Console.WriteLine("!!!Your cancel your order!!!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
                else if (userInput == 5)
                {
                    Console.WriteLine("       You Selected Lemonade         ");
                    Console.WriteLine("           Lemonade = P20            ");

                    Console.WriteLine("Enter the amount you want to purchase");
                    int amountOfdrinks = Convert.ToInt32(Console.ReadLine());

                    totalPrice = 20 * amountOfdrinks;

                    Wish1((int)amountOfdrinks);
                    string userInput2 = Console.ReadLine();
                    if (userInput2.ToLower() == "Yes" || userInput2.ToLower() == "YES" || userInput2.ToLower() == "yes")
                    {
                        Console.WriteLine("You Purchase " + (int)amountOfdrinks + " Lemonade = P" + (int)totalPrice);
                    }
                    else if (userInput2.ToLower() == "No" || userInput2.ToLower() == "NO" || userInput2.ToLower() == "no")
                    {
                        Console.WriteLine("!!!Your cancel your order!!!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
                else if (userInput == 6)
                {
                    Console.WriteLine("       You Selected Mug Rootbeer     ");
                    Console.WriteLine("          Mug Rootbeer = P49         ");

                    Console.WriteLine("Enter the amount you want to purchase");
                    int amountOfdrinks = Convert.ToInt32(Console.ReadLine());

                    totalPrice = 49 * amountOfdrinks;

                    Wish1((int)amountOfdrinks);
                    string userInput2 = Console.ReadLine();
                    if (userInput2.ToLower() == "Yes" || userInput2.ToLower() == "YES" || userInput2.ToLower() == "yes")
                    {
                        Console.WriteLine("You Purchase " + (int)amountOfdrinks + " Mug Rootbeer = P" + (int)totalPrice);
                    }
                    else if (userInput2.ToLower() == "No" || userInput2.ToLower() == "NO" || userInput2.ToLower() == "no")
                    {
                        Console.WriteLine("!!!Your cancel your order!!!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
                else if (userInput == 7)
                {
                    Console.WriteLine("          You Selected YaKult        ");
                    Console.WriteLine("             YaKult = P36            ");

                    Console.WriteLine("Enter the amount you want to purchase");
                    int amountOfdrinks = Convert.ToInt32(Console.ReadLine());

                    totalPrice = 36 * amountOfdrinks;
                    Wish1((int)amountOfdrinks);
                    string userInput2 = Console.ReadLine();
                    if (userInput2.ToLower() == "Yes" || userInput2.ToLower() == "YES" || userInput2.ToLower() == "yes")
                    {
                        Console.WriteLine("You Purchase " + (int)amountOfdrinks + " YaKult = P" + (int)totalPrice);
                    }
                    else if (userInput2.ToLower() == "No" || userInput2.ToLower() == "NO" || userInput2.ToLower() == "no")
                    {
                        Console.WriteLine("!!!Your cancel your order!!!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
                else if (userInput == 8)
                {
                    Console.WriteLine("       You Selected Mountain Dew     ");
                    Console.WriteLine("          Mountain Dew = P43         ");

                    Console.WriteLine("Enter the amount you want to purchase");
                    int amountOfdrinks = Convert.ToInt32(Console.ReadLine());

                    totalPrice = 43 * amountOfdrinks;
                    Wish1((int)amountOfdrinks);
                    string userInput2 = Console.ReadLine();
                    if (userInput2.ToLower() == "Yes" || userInput2.ToLower() == "YES" || userInput2.ToLower() == "yes")
                    {
                        Console.WriteLine("You Purchase " + (int)amountOfdrinks + " Mountain Dew = P" + (int)totalPrice);
                    }
                    else if (userInput2.ToLower() == "No" || userInput2.ToLower() == "NO" || userInput2.ToLower() == "no")
                    {
                        Console.WriteLine("!!!Your cancel your order!!!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("");
                    }

                }
                else if (userInput == 0)
                {
                    Console.WriteLine("EXITING THE PROGRAM");

                    break; // Pang stop nung program
                }
                else
                {
                    Console.WriteLine("");
                }
            } while (loop == 0);

        }
    }
}

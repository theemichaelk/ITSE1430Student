

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        public static double price = 0;
        public static bool isSmall = false;
        public static bool isMedium = false;
        public static bool isLarge = false;
        public static bool aBacon = false, Ham = false, Peporine = false, Sausage = false, BlackOlives = false, Mushrooms = false, Onions = false, Peppers = false, Traditional = false, Garlic = false, Oregano = false, Regular = false, Extra = false, TakeOut = false, Delivery = false;
        static void Main(string[] args)
        {
            bool isCOrrectInputMainMenu = false;
            bool isQuit = false;
            do
            {
                do
                {
                    Console.WriteLine("Welcome to Pizza Shop");


                    Console.WriteLine("Press N for New Order\nPress M for Modify Order\nPress D for display order\nPress Q for quit");
                    String MainMenuVar = Console.ReadLine().ToUpper();
                    if (MainMenuVar == "N")
                    {
                        isCOrrectInputMainMenu = true;
                        NewOrder();
                        Console.WriteLine("\n\n");
                       


                    }
                    else if (MainMenuVar == "M")
                    {
                        isCOrrectInputMainMenu = true;
                        MOdifyData();
                    }
                    
                    else if (MainMenuVar == "D") {
                        isCOrrectInputMainMenu = true;
                        DisplayData();
                    }
                    else if (MainMenuVar == "Q") {
                        isCOrrectInputMainMenu = true;
                        isQuit = true;
                        Environment.Exit(0);
                    }



                } while (!isCOrrectInputMainMenu);
            } while (!isQuit);
            Console.Write("\n\n\n");
            Console.WriteLine("Press Any Key to Continue");
            Console.ReadKey();
        }

        private static void DisplayData()
        {
            Console.WriteLine("Your Order is Below\n\n");
            Console.WriteLine((isSmall) ? "Small Pizza            $5" : (isMedium) ? "Medium Pizza            $6.25" : "Large Pizza            $8.75");
            if (aBacon || Ham || Sausage || Peporine)
            {
                Console.WriteLine("Meat\n");
                if (aBacon)
                {
                    Console.WriteLine("Bacon            $0.75");
                }
                if (Ham)
                {
                    Console.WriteLine("Ham              $0.75");
                }
                if (Peporine)
                {
                    Console.WriteLine("Peporine          $0.75");
                }
                if (Sausage)
                {
                    Console.WriteLine("Sausage           $0.75");
                }
            }
            //veg
            if (aBacon || Ham || Sausage || Peporine)
            {
                Console.WriteLine("Vegetables\n");
                if (BlackOlives)
                {
                    Console.WriteLine("Black Olives      $0.75");
                }
                if (Mushrooms)
                {
                    Console.WriteLine("MUshrooms         $0.75");
                }
                if (Onions)
                {
                    Console.WriteLine("Onions            $0.75");
                }
                if (Peppers)
                {
                    Console.WriteLine("Peppers           $0.75");
                }
            }
            //sause
            {
                if (Traditional)
                {
                    Console.WriteLine("Sause");
                    Console.WriteLine("Traditional          $0.0");
                }
                else if (Garlic)
                {
                    Console.WriteLine("Sause");
                    Console.WriteLine("Garlic               $1.0");
                }
                else if (Oregano)
                {
                    Console.WriteLine("Sause");
                    Console.WriteLine("Oregani               $1.0");
                }
            }

            //cheese
            if (Regular)
            {
                Console.WriteLine("Cheese");
                Console.WriteLine("Regular            $0.0");
            }
            else if (Extra)
            {
                Console.WriteLine("Cheese");
                Console.WriteLine("Extra               $1.25");
            }
            Console.WriteLine("-----------------------------------------------------");
            if (Delivery) {
                Console.WriteLine("Delivery             $2.50");
            }
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\nTotal                  $"+price);

        }

        private static void MOdifyData()
        {
            if (!isSmall && !isMedium && !isLarge)
            {
                Console.WriteLine("Sorry!! NO order Exists");
            }
            else {
                MOdification();
            }
        }

        private static void MOdification()
        {
            
            Console.WriteLine("Ok  MOdify Size Your Previous Choosen Size is: "+((isSmall)?"Small":(isMedium)?"Medium":"Large"));
            bool isSizeChoosenCOrrectyl = false;
            do
            {
                Console.WriteLine("Press S for small ($5) \nPress M for medium ($6.25)\nPress L for Large($8.75)\n");
                String SizeOfPizza = Console.ReadLine().ToUpper();
                if (SizeOfPizza == "S")
                {
                    if (isSmall) { price -= 5; }
                    if (isMedium) { price -= 6.25; } if (isLarge) { price -= 8.75; } isSmall = true; isLarge = false; isMedium = false;
                    price += 5;

                    isSizeChoosenCOrrectyl = true;
                }
                else if (SizeOfPizza == "M")
                {

                    if (isSmall) { price -= 5; }
                    if (isMedium) { price -= 6.25; } if (isLarge) { price -= 8.75; } isSmall = false; isLarge = false; 
                    isMedium = true;
                    price += 6.25;
                    isSizeChoosenCOrrectyl = true;
                }
                else if (SizeOfPizza == "L")
                {
                    if (isSmall) { price -= 5; }
                    if (isMedium) { price -= 6.25; } if (isLarge) { price -= 8.75; } isSmall = false; isLarge = true; isMedium = false;
                    price += 8.75;
                    isSizeChoosenCOrrectyl = true;
                }
            } while (!isSizeChoosenCOrrectyl);

            Console.WriteLine("Ok now time to choose the meat");
            Console.WriteLine("Press 1 to add Bacon ($0.75) and anyother key to skip it. Your Previous Option is:"+((aBacon)?"Yes add Bacon":"No Don't add"));
            String Bacon = Console.ReadLine();
            if (Bacon == "1")
            {
                if (aBacon) { price -= 0.75; }
                price += 0.75;
                aBacon = true;

            }
            if (Bacon!="1") {
                aBacon = false;
            }
            
            Console.WriteLine("Press 1 to add Ham ($0.75) and anyother key to skip it.Your Previous Option is:"+((Ham)?"Yes add Bacon":"No Don't add"));
            String ham = Console.ReadLine();
            if (ham == "1")
            {
                if (Ham) { price-=0.75;}
                price += 0.75;
                Ham = true;

            }
            if (ham != "1") { Ham = false; }


            Console.WriteLine("Press 1 to add Peporani ($0.75) and anyother key to skip it.Your Previous Option is:" + ((Peporine) ? "Yes add Bacon" : "No Don't add"));
            String perporani = Console.ReadLine();
            if (perporani == "1")
            {
                if (Peporine) { price -= 0.75; }
                price += 0.75;
                Peporine = true;

            }
            if (perporani != "1") { Peporine = false; }
            Console.WriteLine("Press 1 to add Sausage ($0.75) and anyother key to skip it.Your Previous Option is:" + ((Sausage) ? "Yes add Bacon" : "No Don't add"));
            String sausage = Console.ReadLine();
            if (sausage == "1")
            {
                if (Sausage) { price -= 0.75; }
                price += 0.75;
                Sausage = true;

            }
            if (sausage != "1") { Sausage = false; }

            Console.WriteLine("Ok now time to choose the Vegetables");
            Console.WriteLine("Press 1 to add Black Olives ($0.50) and anyother key to skip it.Your Previous Option is:" + ((BlackOlives) ? "Yes add Bacon" : "No Don't add"));
            String blackolives = Console.ReadLine();
            if (blackolives == "1"){
            
                if(BlackOlives){price-=0.50;}
                price += 0.50;
                BlackOlives = true;

            }
            if (blackolives != "1") {
                BlackOlives = false;
            }
            Console.WriteLine("Press 1 to add Mushrooms ($0.50) and anyother key to skip it.Your Previous Option is:" + ((Mushrooms) ? "Yes add Bacon" : "No Don't add"));
            String muhsrooms = Console.ReadLine();
            if (muhsrooms == "1")
            {
                if (Mushrooms) { price -= 0.50; }
                price += 0.50;
                Mushrooms = true;

            }
            if (muhsrooms != "1") { Mushrooms = false; }
            Console.WriteLine("Press 1 to add Onions ($0.50) and anyother key to skip it.Your Previous Option is:" + ((Onions) ? "Yes add Bacon" : "No Don't add"));
            String onions = Console.ReadLine();
            if (onions == "1")
            {
                if (Onions) { price -= 0.50; }
                price += 0.50;
                Onions = true;

            }
            if (onions != "1") { Onions = false; }
            Console.WriteLine("Press 1 to add Peppers ($0.50) and anyother key to skip it.Your Previous Option is:" + ((Peppers) ? "Yes add Bacon" : "No Don't add"));
            String peppers = Console.ReadLine();
            if (peppers == "1")
            {
                if (Peppers) { price -= 0.50; }
                price += 0.50;
                Peppers = true;

            }
            if (peppers != "1") { Peppers = false; }

            Console.WriteLine("Ok  MOdify the Sause for your pizza");
            bool isSauseChoosenCOrrectyl = false;
            do
            {
                Console.WriteLine("Press T for Traditional ($0) \nPress G for Garlic ($1)\nPress O for Oregeno($1)\nYour Previous Choice is: "+((Traditional)?"Traditional":(Garlic)?"Garlic":"Orgeno"));
                String SauseOfPizza = Console.ReadLine().ToUpper();
                if (SauseOfPizza == "T")
                {
                    if(Garlic||Oregano){price-=1;}
                    Traditional = true; Garlic=false;Oregano=false;
                    price += 0;
                    isSauseChoosenCOrrectyl = true;
                }
                else if (SauseOfPizza == "G")
                {
                    if(Garlic||Oregano){price-=1;}
                    Traditional = false; Garlic=true;Oregano=false;
                    
                    price += 1;
                    isSauseChoosenCOrrectyl = true;
                }
                else if (SauseOfPizza == "O")
                {
                    if(Garlic||Oregano){price-=1;}
                    Traditional = false; Garlic=false;
                    Oregano = true;
                    price += 1;
                    isSauseChoosenCOrrectyl = true;
                }
            } while (!isSauseChoosenCOrrectyl);



            Console.WriteLine("Ok  its time to choose the Cheese for your pizza");
            bool isCheeseChoosenCOrrectyl = false;
            do
            {
                Console.WriteLine("Press R for Regular ($0) \nPress E for Extra ($1.25)\nYour Previous Choice is:"+((Regular)?"Regular":"Extra"));
                String CHeeseOfPizza = Console.ReadLine().ToUpper();
                if (CHeeseOfPizza == "R")
                {if(Extra){price-=0.25;}
                    Extra=false;
                    Regular = true;
                    price += 0;
                    isCheeseChoosenCOrrectyl = true;
                }
                else if (CHeeseOfPizza == "E")
                {if(Extra){price-=1.25;}
                    Regular=false;
                    Extra = true;
                    price += 1.25;
                    isCheeseChoosenCOrrectyl = true;
                }

            } while (!isCheeseChoosenCOrrectyl);




            Console.WriteLine("Almost DOne!! NOw choose from the following");
            bool isDeliveryChoosenCOrrectyl = false;
            do
            {
                Console.WriteLine("Press T for TakeOut ($0) \nPress D for Delivery ($2.50)\nYOur Previous Choice is:"+((Delivery)?"DElivery":"TakeOut"));
                String Devlivery = Console.ReadLine().ToUpper();
                if (Devlivery == "T")
                {
                    if (Delivery) { price -= 2.50; }
                    Delivery = false;
                    TakeOut = true;
                    price += 0;
                    isDeliveryChoosenCOrrectyl = true;
                }
                else if (Devlivery == "D")
                {
                    if (Delivery) { price -= 2.50; }
                    TakeOut = false;
                    price += 2.50;
                    Delivery = true;
                    isDeliveryChoosenCOrrectyl = true;
                }

            } while (!isDeliveryChoosenCOrrectyl);


        }

        private static void NewOrder()
        {
            Console.WriteLine("Please Choose Your order from the following");
            Console.WriteLine("Ok  its time to choose hte size for your pizza");
            bool isSizeChoosenCOrrectyl = false;
            do{
            Console.WriteLine("Press S for small ($5) \nPress M for medium ($6.25)\nPress L for Large($8.75)\n");
            String SizeOfPizza = Console.ReadLine().ToUpper();
            if(SizeOfPizza=="S"){
                isSmall = true;
                price += 5;
                isSizeChoosenCOrrectyl = true;
            }
            else if (SizeOfPizza == "M")
            {
                isMedium = true;
                price += 6.25;
                isSizeChoosenCOrrectyl = true;
            }
            else if (SizeOfPizza == "L")
            {
                isLarge = true;
                price += 8.75;
                isSizeChoosenCOrrectyl = true;
            }
            }while(!isSizeChoosenCOrrectyl);

            Console.WriteLine("Ok now time to choose the meat");
            Console.WriteLine("Press 1 to add Bacon ($0.75) and anyother key to skip it.");
            String Bacon = Console.ReadLine();
            if (Bacon == "1") {
                price += 0.75;
                aBacon = true;
               
            }
            Console.WriteLine("Press 1 to add Ham ($0.75) and anyother key to skip it.");
            String ham = Console.ReadLine();
            if (ham == "1")
            {
                price += 0.75;
                Ham = true;
                 
            }

            
            Console.WriteLine("Press 1 to add Peporani ($0.75) and anyother key to skip it.");
            String perporani = Console.ReadLine();
            if (perporani == "1")
            {
                price += 0.75;
                Peporine = true;
                
            }
            Console.WriteLine("Press 1 to add Peporani ($0.75) and anyother key to skip it.");
            String sausage = Console.ReadLine();
            if (sausage == "1")
            {
                price += 0.75;
                Sausage = true;
                
            }

            Console.WriteLine("Ok now time to choose the Vegetables");
            Console.WriteLine("Press 1 to add Black Olives ($0.50) and anyother key to skip it.");
            String blackolives = Console.ReadLine();
            if (blackolives == "1")
            {
                price += 0.50;
                BlackOlives = true;
                
            }
            Console.WriteLine("Press 1 to add Mushrooms ($0.50) and anyother key to skip it.");
            String muhsrooms = Console.ReadLine();
            if (muhsrooms == "1")
            {
                price += 0.50;
                Mushrooms = true;
                
            }
            Console.WriteLine("Press 1 to add Onions ($0.50) and anyother key to skip it.");
            String onions = Console.ReadLine();
            if (onions == "1")
            {
                price += 0.50;
                Onions = true;
                
            }
            Console.WriteLine("Press 1 to add Peppers ($0.50) and anyother key to skip it.");
            String peppers = Console.ReadLine();
            if (peppers == "1")
            {
                price += 0.50;
                Peppers = true;
                
            }


            Console.WriteLine("Ok  its time to choose the Sause for your pizza");
            bool isSauseChoosenCOrrectyl = false;
            do
            {
                Console.WriteLine("Press T for Traditional ($0) \nPress G for Garlic ($1)\nPress O for Oregeno($1)\n");
                String SauseOfPizza = Console.ReadLine().ToUpper();
                if (SauseOfPizza == "T")
                {
                    Traditional = true;
                    price += 0;
                    isSauseChoosenCOrrectyl = true;
                }
                else if (SauseOfPizza == "G")
                {
                    Garlic = true;
                    price += 1;
                    isSauseChoosenCOrrectyl = true;
                }
                else if (SauseOfPizza == "O")
                {
                    Oregano = true;
                    price += 1;
                    isSauseChoosenCOrrectyl = true;
                }
            } while (!isSauseChoosenCOrrectyl);



            Console.WriteLine("Ok  its time to choose the Cheese for your pizza");
            bool isCheeseChoosenCOrrectyl = false;
            do
            {
                Console.WriteLine("Press R for Regular ($0) \nPress E for Extra ($1.25)\n");
                String CHeeseOfPizza = Console.ReadLine().ToUpper();
                if (CHeeseOfPizza == "R")
                {
                    Regular = true;
                    price += 0;
                    isCheeseChoosenCOrrectyl = true;
                }
                else if (CHeeseOfPizza == "E")
                {
                    Extra = true;
                    price += 1.25;
                    isCheeseChoosenCOrrectyl = true;
                }

            } while (!isCheeseChoosenCOrrectyl);




            Console.WriteLine("Almost DOne!! NOw choose from the following");
            bool isDeliveryChoosenCOrrectyl = false;
            do
            {
                Console.WriteLine("Press T for TakeOut ($0) \nPress D for Delivery ($2.50)\n");
                String Devlivery = Console.ReadLine().ToUpper();
                if (Devlivery == "T")
                {
                    TakeOut = true;
                    price += 0;
                    isDeliveryChoosenCOrrectyl = true;
                }
                else if (Devlivery == "D")
                {                    price += 2.50;
                Delivery = true;
                    isDeliveryChoosenCOrrectyl = true;
                }

            } while (!isDeliveryChoosenCOrrectyl);


        }
    }
}


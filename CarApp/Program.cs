using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace CarApp
{
    enum TypeEnum { Car = 1 , SuperCars = 2};
    class Program
    {
        

        static void Main(string[] args)
        {
            CarInput carInput = new CarInput();
            

            Console.WriteLine("Willkommen in der Auto Eingabe.\n");

            int action = chooseInput();

            while(action != 0)
            {
                Console.WriteLine("Deine auswahl " + action);

                switch (action)
                {
                    case 1:
                        Console.WriteLine("Du hast hinzufügen ausgewählt.\n");

                        String carModel = "";
                        String carName = "";
                        String carBrand = "";
                        int carConstructionYear = 0;
                        String carColor = "";

                        Console.WriteLine("Bitte such dir ein Type aus!\n");
                        Console.WriteLine("Gib bitte ein (1) für Car und (2) für SuperCar.\n");

                        for(int i=0; i < 2; i++)
                        {
                            int input = Convert.ToInt32(Console.ReadLine());
                            {
                                if(input >= 1 && input <= 2)
                                {
                                    carModel = ((TypeEnum)input).ToString();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Falsche Eingabe!");
                                    Environment.Exit(0);
                                }
                            }
                        }
                        

                        Console.WriteLine("Gib bitte die Automarke ein.\n");
                        carBrand = Console.ReadLine();

                        Console.WriteLine("Gib bitte die Variante ein.\n");
                        carName = Console.ReadLine();

                        Console.WriteLine("Gib bitte die Farbe ein.\n");
                        carColor = Console.ReadLine();

                        Console.WriteLine("Gib bitte das Baujahr ein.\n");
                        carConstructionYear = int.Parse(Console.ReadLine());

                        Car newCar = new Car(carModel, carBrand, carName, carConstructionYear, carColor);
                        carInput.CarList.Add(newCar);

                        break;

                    case 2:

                        Console.WriteLine("Du hast 2 ausgewählt! Hier siehst du alle Autos aus der Liste.\n");
                        printCarList(carInput);

                        break;
                    
                }       


                action = chooseInput();
            }

            

        }

        private static void printCarList(CarInput carInput)
        {
            foreach(Car car in carInput.CarList)
            {
                Console.WriteLine("Auto: " + car);

            }
        }

        static public int chooseInput()
        {
            int choice = 0;
            Console.WriteLine("Wähle eine action (0) für abbruch, (1) für Hinzufügen, (2) für CarLst anschauen.\n ");

            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}

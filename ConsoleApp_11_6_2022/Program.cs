//using statements are used to tell the compiler which code we are using.
//using [namespace]

using ConsoleApp_11_6_2022.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

//Namespace is used to organize classes
//Format of making a namespace:
//namespace [name of the namespace]
namespace ConsoleApp_11_6_2022
{
    //A class is used to organize methods and variables.
    //Format of making a class goes like this:
    //[Scope] class [Name of the class]
    class Program
    {
        //Format of a variable (inside of a class)
        //[Scope] [Data type] [Name];
        internal int height;

        // optionally: [Scope] [Data type] [Name] = [value];
        public static string hairColor = "Yellow";

        // the backslash \ is considered the escape character

        //other scopes: private and protected

        //A method is used to perform some action or code.
        //Format of a method:
        //[Scope] [Static or omit it] [Return type, use void to say there is no return] [Name of the method](parameter list)
        private static void Main(string[] args)
        {
            //Format of a variable (inside of a method)
            //[Data type] [Name];
            char characterNoDefaultValue;

            //optionally [Data type] [Name] = [value];
            double fractionalNumber = 0.54124125125124123;
            float smallerFractionalNumber = 0.54124125125124123f;
            char character = 'p';

            long longNumber = 1231235151251252312;
            int integerNumber = 124545;
            short smallInteger = 256;

            //Console.WriteLine(hairColor);
            //double roomTemperature = 40;
            //double convertedTemperature = TemperatureFahrenheitToCelcius(roomTemperature);
            //Console.WriteLine(convertedTemperature);
            
            double temp1 = 10;
            double temp2 = 72;
            double temp3 = 92;

            double average = TemperatureAverage(temp1, temp2, temp3);

            string foo = "10";
            string bar = "72";

            string foobar = foo + bar; //the term for adding strings together is called "concatination"
            string foobar2 = temp1.ToString();

            int basket1 = 10;
            int basket2 = 20;

            string appleCountString = (basket1 + basket2).ToString();

            string foobar3 = "I have this many apples: 10";
            string foobar4 = "I have this many apples: " + appleCountString;

            double input1 = 10;
            double input2 = 72;
            double input3 = 92;

            //Arrays are 0-indexed, so the first value starts at 0!
            //An array with a length 3, has 0, 1, 2 indices
            double[] array = new double[4];
            array[0] = 1;
            array[1] = 2;
            array[2] = 9;
            array[3] = 100;

            double arrayAverage = TemperatureAverage(array[0], array[1], array[2]);

            string[] stringArray = new string[3];
            stringArray[0] = "Hello World!";
            stringArray[1] = "123";
            //stringArray[2] is null

            string[] stringArraySecondName = stringArray;
            string str1 = stringArraySecondName[0];
            stringArraySecondName[0] = "444";

            string str2 = stringArray[0];

            string firstNameTaylor = "Taylor";

            string secondName = "Zach";

            string copyOfFirstName = firstNameTaylor;
            firstNameTaylor = secondName;

            secondName = "Jacob";

            string finalName = firstNameTaylor + " " + secondName + " " + copyOfFirstName;

            //Console.WriteLine(finalName);

            int first_Number = 100;
            int second_Number = 200;
            int third_Number = -25;
            int fourth_Number = 0;

            if (first_Number == second_Number && first_Number == -25)
            {
                Console.WriteLine("It's true!");
            }
            else if (third_Number > 0)
            {
                Console.WriteLine("Third number is less than zero.");
            }
            else if (fourth_Number != 0)
            {
                Console.WriteLine("Fourth number is 0");
            }
            else
            {
                //Console.WriteLine("They were all false.");
            }

            /*
            Console.WriteLine("Please type your first number.");
            string firstNumberString = Console.ReadLine();

            Console.WriteLine("Please type your second number.");
            string secondNumberString = Console.ReadLine();

            double firstNumber = double.Parse(firstNumberString);
            double secondNumber = double.Parse(secondNumberString);
            double doubleParse = double.Parse("0.333");
            float floatParse = float.Parse("0.333");
            decimal decimalParse = decimal.Parse("0.333");

            bool firstNumberPositive = IsOdd(firstNumber);

            Console.WriteLine("The result is: " + firstNumberPositive);

            Console.WriteLine("End of program.");
            */

            /*
            Console.WriteLine("This is a while loop:");
            int counter = 1;
            while (counter < 6)
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.WriteLine("This is a do while loop:");
            counter = 1;
            do
            {
                Console.WriteLine(counter);
                counter = counter + 1;
            }
            while (counter < 6);

            Console.WriteLine("This is a for loop:");
            //the format of a for loop is like so:
            //for ([Create Variable Here]; [Conditional that determines when to leave the loop]; [Add to the variable to meet the conditional])
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("This is a foreach loop:");
            foreach (string s in stringArray)
            {
                if (s == null)
                {
                    Console.WriteLine("Null");
                }
                else
                {
                    Console.WriteLine(s);
                }
            }



            //Write a method that will sum the first 10 numbers in a loop that loops at least 10 times.
            //So 1+2+3+4+5+6+7+8+9+10 = 55 should returned.

            int methodResult = SumOfInts();
            Console.WriteLine(methodResult);
            */

            long[] longArray = new long[6];
            longArray[0] = 1000;
            longArray[1] = 300;
            longArray[2] = 900;
            longArray[3] = 420;
            longArray[4] = 750;
            longArray[5] = -666;

            longArray[5]--;

            int firstIndex = 1;
            long lg = longArray[firstIndex];
            //Console.WriteLine(lg);

            foreach (long l in longArray)
            {
                //Console.WriteLine(l);
            }

            //This gets the number of elements (elements is general since arrays can be strings/numbers/etc) in an array.
            //int lengthOfArray = longArray.Length;

            //ZachForeachReplacement();

            //JacobReverseLoop();
            //ZachReverseLoop();

            string[] arrayToFill = new string[6];
            arrayToFill[0] = "A";
            arrayToFill[1] = "B";
            arrayToFill[2] = "C";
            arrayToFill[3] = null;
            arrayToFill[4] = "E";
            arrayToFill[5] = "F";

            //TODO: Make the below method.
            /*
            string gapVar = "Missing";
            FillGap(gapVar, arrayToFill);


            for (int i = 0; i < arrayToFill.Length; i++)
            {
                Console.WriteLine(arrayToFill[i]);
            }
            */

            //ObjectPractice();

            string[] arrayPractice = new string[3];
            arrayPractice[0] = "A";
            arrayPractice[1] = "B";
            arrayPractice[2] = "C";

            //Method needs to:
            //1) Accept in two indices that will be swapped.
            //2) Accept in the array whose elements are getting swap.
            //3) Swap the elements at the given indices in the given array.


            //Swap(0,2,arrayPractice);

            //Method needs to add a new string to an array even if the array is full.
            //1) Accept in a string that will get added, and an array that the string will get added to.

            /*
            arrayPractice = AddElement("D", arrayPractice);
            arrayPractice = AddElement("E", arrayPractice);
            arrayPractice = AddElement("F", arrayPractice);


            for (int i = 0; i <arrayPractice.Length; i++)
            {
                Console.WriteLine(arrayPractice[i]);
            }
            */

            //GuitarShopObjectPractice();


            //VisitGuitarShop();

            //ReferencePractice1();

            ShopGame.Start();
        }

        //Pillars of Object Oriented Programming:

        //1) Encapsulation

        //2) Abstraction

        //3) Polymorphism

        //4) Inheritance

        public static void VisitGuitarShop()
        {
            GuitarShop shop = GenerateGuitarShop();
            decimal wallet = 1000;
            
            Customer customer = new Customer("Bob", wallet);

            string greeting = shop.GetWelcomeMessage();
            Console.WriteLine(greeting);
            Console.WriteLine();//Empty line here for a better look.
            bool running = true;

            while (running)
            {
                Console.WriteLine($"{customer.Name} has ${customer.Money} left.");
                Console.WriteLine("Please type the number of the guitar you wish to buy. Or type 0 to leave the shop.");

                //I pull the guitar shop's guitars out into a variable here because I expect to be accessing it below.
                List<Guitar> shopGuitars = shop.GetGuitarStock();

                if (shop.IsGuitarShopEmpty())
                {
                    Console.WriteLine();//Empty line here for a better look.
                    Console.WriteLine("Sorry, we're all sold out!");
                }
                else
                {
                    PrintGuitarShopStock(shop);
                }

                string input = Console.ReadLine();

                int value;
                bool result = int.TryParse(input, out value);

                if (result)
                {
                    //Because the user typed 0, we stop running the application.
                    if (value == 0)
                    {
                        running = false;
                    }
                    else
                    {
                        //Because they typed another number, we can view the guitar in detail.
                        //But we need to convert the display index we showed to them back to the
                        //real index of that guitar in the shop.
                        int guitarIndex = value - 1;

                        //We also need to make sure they didn't type something out of bounds like a negative number.
                        if (guitarIndex < 0)
                        {
                            Console.WriteLine("That wasn't an option. Try again.");
                        }
                        else if (guitarIndex >= shopGuitars.Count || guitarIndex < 0)
                        {//And we also need to make sure it isn't out of bounds of the guitars we have.
                            Console.WriteLine("That was out of bounds. Try again.");
                        }
                        else
                        {
                            Guitar guitarToRemove = shop.GetGuitar(guitarIndex);

                            if (customer.Money >= guitarToRemove.Price)
                            {
                                customer.Money -= guitarToRemove.Price;

                                shop.RemoveGuitar(guitarIndex);
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough money.");
                            }
                        }


                    }
                }
                else
                {
                    Console.WriteLine("It was NOT a number. Please type a number.");
                }
                Console.WriteLine($"You typed in: {input}");
            }
        }

        public static void PrintGuitarShopStock(GuitarShop shop)
        {
            //Get the guitars out of the shop
            List<Guitar> guitars = shop.GetGuitarStock();

            //Now loop through and write them out.
            for (int i = 0; i < guitars.Count; i++)
            {
                int displayIndex = i + 1;
                Guitar currentGuitar = guitars[i];
                if (currentGuitar != null)
                {
                    Console.WriteLine(displayIndex + " " + currentGuitar.GetDisplayString());
                }
            }

        }

        public static GuitarShop GenerateGuitarShop()
        {
            ShopOwner owner = new ShopOwner("Taylor", 10000, "Guitarbonaza");

            GuitarShop newShop = new GuitarShop(owner);

            //This makes 10 generated guitars.
            for (int i = 0; i < 10; i++)
            {
                Guitar generatedGuitar = RandomGenerator.GenerateGuitar();
                newShop.AddGuitar(generatedGuitar);
            }
            return newShop;
        }

        public static void ReferencePractice1()
        {
            Guitar guitar1 = new Guitar("Fender1");
            Guitar guitar2 = new Guitar("Fender2");
            guitar1 = guitar2;

            bool comparisonResult = guitar1 == guitar2;

            Console.WriteLine(comparisonResult);
        }

        public static string[] AddElement(string newStr, string[] array)
        {
            int newSize = array.Length + 1;
            string[] newArray = new string[newSize];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            newArray[newArray.Length - 1] = newStr;

            return newArray;
        }

        public static void Swap(int index1, int index2, string[] array)
        {
            string temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        public static void GuitarShopObjectPractice()
        {
            ShopOwner owner = new ShopOwner("Taylor", 10000, "The Shop");

            GuitarShop theGuitarShop = new GuitarShop(owner);

            string brand = "Fender";
            Guitar myGuitar = new Guitar(brand); 
            
            brand = "Fender2";
            Guitar myGuitar2 = new Guitar(brand);

            brand = "Fender3";
            Guitar myGuitar3 = new Guitar(brand);

            brand = "Fender4";
            Guitar myGuitar4 = new Guitar(brand);

            brand = "Fender5";
            Guitar myGuitar5 = new Guitar(brand);


            theGuitarShop.AddGuitar(myGuitar);
            theGuitarShop.AddGuitar(myGuitar2);
            theGuitarShop.AddGuitar(myGuitar3);
            theGuitarShop.AddGuitar(myGuitar4);
            theGuitarShop.AddGuitar(myGuitar5);

            theGuitarShop.RemoveGuitar(myGuitar3);
            theGuitarShop.RemoveGuitar(2);

            theGuitarShop.AddGuitar(myGuitar5);
        }

        public static void ObjectPractice()
        {
            string brand = "Fender";
            Guitar myGuitar = new Guitar(brand);

            brand = "Walmart";
            Guitar mySecondGuitar = new Guitar(brand);

            myGuitar.SetNumberOfStrings(12);
            mySecondGuitar.SetNumberOfStrings(36);

            myGuitar.SetWeight(100);
            mySecondGuitar.SetWeight(4);

            int myGuitarStringCount = myGuitar.GetNumberOfStrings();
            int mySecondGuitarStringCount = mySecondGuitar.GetNumberOfStrings();

            Console.WriteLine("Checking the first guitar.");
            if (myGuitarStringCount > 12)
            {
                Console.WriteLine("That's stupid.");
            }

            Console.WriteLine("Checking the second guitar now...");
            if (mySecondGuitarStringCount > 12)
            {
                Console.WriteLine("That's stupid.");
            }

        }

        public static void JacobReverseLoop()
        {
            string[] greetings = new string[4];
            greetings[0] = "Hello!";
            greetings[1] = "Welcome!";
            greetings[2] = "Hello World!";
            greetings[3] = "Guten Tag!";

            string s = greetings[0];
            Console.WriteLine(s);

            s = greetings[1];
            Console.WriteLine(s);

            s = greetings[2];
            Console.WriteLine(s);

            Console.WriteLine("The Loop's Output is below:");

            string tempS;
            int i2 = greetings.Length;
            for (int i = 0; i < greetings.Length; i++)
            {
                i2--;
                tempS = greetings[i2];
                Console.WriteLine(tempS);
            }
        }

        public static void ZachReverseLoop()
        {
            string[] greetings = new string[4];
            greetings[0] = "Hello!";
            greetings[1] = "Welcome!";
            greetings[2] = "Hello World!";
            greetings[3] = "This is the fourth greeting.";

            /*string s = greetings[0];
            Console.WriteLine(s);

            s = greetings[1];
            Console.WriteLine(s);

            s = greetings[2];
            Console.WriteLine(s);
            */
            // Console.WriteLine("The Loop's Output is below:");


            string tempS;

            for (int i = greetings.Length - 1; i > -1; i--)
            {
                //s = greetings[1];
                tempS = greetings[i];
                Console.WriteLine(tempS);
            }
        }

        public static void JacobForeachReplacement()
        {
            long[] longArray = new long[7];
            longArray[0] = 1000;
            longArray[1] = 300;
            longArray[2] = 900;
            longArray[3] = 420;
            longArray[4] = 750;
            longArray[5] = -666;
            longArray[6] = long.MaxValue;

            int arrayLength = longArray.Length;
            int arrayLength2 = 0;

            for (long l = 0; l < arrayLength; l++)
            {
                Console.WriteLine(longArray[arrayLength2]);
                arrayLength2++;
            }
        } 

        public static void ZachForeachReplacement()
        {
            long[] longArray = new long[6];
            longArray[0] = 1000;
            longArray[1] = 300;
            longArray[2] = 900;
            longArray[3] = 420;
            longArray[4] = 750;
            longArray[5] = -666;

            int lengthOfArray = longArray.Length;
            int firstIndex = 0;
            long l1;

            for (long i = 0; i < lengthOfArray; i++)
            {
                l1 = longArray[firstIndex];
                firstIndex++;
                Console.WriteLine(l1);
            }
        }

        public static void TaylorForeachReplacement()
        {
            long[] longArray = new long[7];
            longArray[0] = 1000;
            longArray[1] = 300;
            longArray[2] = 900;
            longArray[3] = 420;
            longArray[4] = 750;
            longArray[5] = -666;
            longArray[6] = long.MaxValue;

            //three sections of for loop
            //make the counter variable
            //define the condition to exit the loop
            //define how to change the counter variable
            for (int i = 0; i < longArray.Length; i++)
            {
                long l = longArray[i];
                Console.WriteLine(l);
            }
        }

        public static int SumOfInts()
        {
            int Sum = 0;
            int Ints = 1;
            while (Sum < 55)
            {
                Sum = (Sum + Ints);
                Ints++;
            }

            return Sum;
        }

        public static double TemperatureFahrenheitToCelcius(double fahrenheit)
        {
            double celcius = (fahrenheit - 32) * .5556;

            return celcius;
        }


        public static double TemperatureFahrenheitToKelvin(double fahrenheit)
        {
            double celcius = TemperatureFahrenheitToCelcius(fahrenheit);
            double kelvin = celcius + 273;
            return kelvin;
        }

        public static double TemperatureAverage(double temperature1, double temperature2, double temperature3)
        {
            double finalNumber = (temperature1 + temperature2 + temperature3) / 3;

            return finalNumber;
        }

        public static bool IsOdd(double number)
        {

            double FinalNumber = 1;
            FinalNumber = number % 2;
            if (FinalNumber == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
        }

        public static string FillGapZach(string gapFill, string[] arrayToFill) //This is the second for fillgap method
        {
            gapFill = "123Skipafew";
            string nullFinder;
            for (int i = 0; i < arrayToFill.Length; i++)
            {
                if (arrayToFill[i] == null)
                {
                    nullFinder = gapFill;
                    Console.WriteLine(nullFinder);
                }
                else
                {
                    Console.WriteLine(arrayToFill[i]);
                }

            }
            nullFinder = null;
            return nullFinder;
        }

        public static void FillGap(string gap, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = gap;
                }
            }
        }

    }


}

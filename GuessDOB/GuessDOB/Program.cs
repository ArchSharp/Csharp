using System;

namespace GuessDOB
{
    class Program
    {
        static void Main(string[] args)
        {
            // App name
            AppInfo();
            Console.WriteLine("What is your name");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello {0} I can guess your birthday correctly without you saying it out", userName);
            Console.WriteLine("\n");

            while (true)
            {
                int birthday = MainGame("birthday", 4);
                int birthMonth = MainGame("birth month", 3);
                int birthYear = MainGame("birth years' last digit", 3);

                int yearRange = SelectYear();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hello {0} Your Date of Birth is {1}/{2}/{3}{4}: ", userName, birthday, birthMonth, yearRange, birthYear);
                Console.ResetColor();

                Console.WriteLine("Do you want to play again? Press Y for Yes or N for No");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }

                Console.ReadLine();
            }
        }


        static void AppInfo()
        {
            string appName = "Birthday Guesser";
            string appRelease = "1.0.0";
            string appAuthor = "Raphael Olaiyapo";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0} Version {1} by {2}", appName, appRelease, appAuthor);
            Console.ResetColor();
        }

        static string Calender(int select)
        {
            string set = "";
            switch (select)
            {
                case 0:
                    set = "1  3  5  7 \n" +
                          "9  11 13 15 \n" +
                          "17 19 21 23\n" +
                          "25 27 29 31";
                    break;

                case 1:
                    set = "2  3  6  7 \n" +
                          "10 11 14 15\n" +
                          "18 19 22 23\n" +
                          "26 27 30 31";
                    break;
                case 2:
                    set = "4  5  6  7 \n" +
                          "12 13 14 15\n" +
                          "20 21 22 23\n" +
                          "28 29 30 31";
                    break;
                case 3:
                    set = "8  9  10 11 \n" +
                          "12 13 14 15\n" +
                          "24 25 26 27\n" +
                          "28 29 30 31";
                    break;
                case 4:
                    set = "16 17 18 19\n" +
                          "20 21 22 23\n" +
                          "24 25 26 27\n" +
                          "28 29 30 31";
                    break;
            }
            return set;
        }

        static int MainGame(string selectTime, int numOfSet)
        {
            int firstInput = 0;
            int theTime = 0;
            while (firstInput <= numOfSet)
            {
                Console.WriteLine("is your {0} in set {1}", selectTime, firstInput + 1);
                Console.WriteLine(Calender(firstInput));
                Console.WriteLine("Press Y for YES and N for NO");
                int validInt = 0;
                string answer = Console.ReadLine().ToUpper();
                bool convert = int.TryParse(answer, out validInt);
                if (convert == true)
                {
                    Console.WriteLine("Response must be either Y for Yes or N for No");
                    break;
                }

                int[] magicNum = new int[] { 1, 2, 4, 8, 16 };

                if (answer == "Y")
                {
                    theTime += magicNum[firstInput];
                }
                else if (answer == "N")
                {
                    theTime += 0;
                }
                firstInput++;
            }
            return theTime;
        }
        static int SelectYear()
        {
            Console.WriteLine("Please Select year range you were born.");
            Console.WriteLine("1 for 2020s, 2 for 2010s, 3 for 2000s, 4 for 1990s, 5 for 1980s 6 for 1970s, 7 for 1960s");

            int mainYear = 0;
            int theYear = Int32.Parse(Console.ReadLine());
            switch(theYear)
            {
                case 1:
                    mainYear = 202;
                    break;
                case 2:
                    mainYear = 201;
                    break;
                case 3:
                    mainYear = 200;
                    break;
                case 4:
                    mainYear = 199;
                    break;
                case 5:
                    mainYear = 198;
                    break;
                case 6:
                    mainYear = 197;
                    break;
                case 7:
                    mainYear = 196;
                    break;
                case 8:
                    mainYear = 195;
                    break;
            }
            return mainYear;
        }
    }
}

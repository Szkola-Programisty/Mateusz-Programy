using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;

namespace KalkulatorBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            double KG = 0;
            double cm = 0;
            bool weight = false;
            bool height = false;
            Console.WriteLine("BMI calculator");
            Console.WriteLine("---------------\n");

            while (!endApp)
            {
                while (!weight)
                { 
                    //kg value
                    Console.Write("Podaj swoją wagę w kg: ");

                try
                {
                    KG = Convert.ToInt32(Console.ReadLine());
                    weight = true;
                    break;
                }
                catch (Exception e)
                {
                    
                    Console.WriteLine("Źle podałeś wartość wagi, spróbuj podać ją w kilogramach.\n - Szczegóły dotyczące błędu: " + e.Message);
                    
                }
            }

                while (!height)
                {
                    //kg value
                    Console.Write("Podaj swój wzrost w cm: ");

                    try
                    {
                        cm = Convert.ToInt32(Console.ReadLine());
                        height = true;
                        break;
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("Źle podałeś wartość wzrostu, spróbuj podać ją w centymetrach.\n - Szczegóły dotyczące błędu: " + e.Message);

                    }
                }
                //gender pick
                Console.Write("Podaj swoją płeć (K/M): ");
                string gender = Console.ReadLine();

                //modula for BMI
                double BMI = KG / Math.Pow(cm / 100.0, 2);
                if (gender == "M" || gender == "m")
                {
                    BMI = Math.Round(BMI, 2);
                    Console.WriteLine($"Pana BMI wynosi: {BMI}\n Co oznacza, że: \n");
                    
                }
                else if (gender == "K" || gender == "k")
                {
                    BMI = Math.Round(BMI, 2);
                    Console.WriteLine($"Pani BMI wynosi: {BMI}\n Co oznacza, że: \n");
                    
                }

                //doing BMI maths for woman
                if (gender == "K" || gender == "k")
                {
                    if (BMI < 16)
                    {
                        Console.WriteLine("Jesteś wygłodzona.");
                    }
                    else if (BMI > 16.1 && BMI <= 17.0)
                    {
                        Console.WriteLine("Jesteś wychudzona.");
                    }
                    else if (BMI > 17.1 && BMI <= 18.5)
                    {
                        Console.WriteLine("Masz niedowagę.");
                    }
                    else if (BMI > 18.6 && BMI <= 25.0)
                    {
                        Console.WriteLine("Masz prawidłową wagę.");
                    }
                    else if (BMI > 25.1 && BMI <= 30.0)
                    {
                        Console.WriteLine("Masz nadwagę.");
                    }
                    else if (BMI > 30.1)
                    {
                        Console.WriteLine("Masz poważną nadwagę");
                    }
                }
                //Doing BMI maths for Man
                if (gender == "M" || gender == "m")
                {
                    if (BMI < 16)
                    {
                        Console.WriteLine("Jesteś wygłodzony.");
                    }
                    else if (BMI > 16.1 && BMI <= 17.0)
                    {
                        Console.WriteLine("Jesteś wychudzony.");
                    }
                    else if (BMI > 17.1 && BMI <= 18.5)
                    {
                        Console.WriteLine("Masz niedowagę.");
                    }
                    else if (BMI > 18.6 && BMI <= 25.0)
                    {
                        Console.WriteLine("Masz prawidłową wagę.");
                    }
                    else if (BMI > 25.1 && BMI <= 30.0)
                    {
                        Console.WriteLine("Masz nadwagę.");
                    }
                    else if (BMI > 30.1)
                    {
                        Console.WriteLine("Masz poważną nadwagę");
                    }
                }
                //solving automatic killing program when maths ends.
                Console.WriteLine("------------------------\n");
                Console.Write("Naciśnij 'n' i Enter żeby zamknąć aplikację, albo inny dowolny guzik i enter żeby kontynuować: ");
                if (Console.ReadLine() == "n") endApp = true;
                Console.WriteLine("\n");
            }

        }
    }
}


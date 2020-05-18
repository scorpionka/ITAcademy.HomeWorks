using log4net;
using log4net.Config;
using System;

[assembly: XmlConfigurator(ConfigFile = "HW_11.dll.config", Watch = true)]

namespace HW_11
{
    class Program
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            log.Info("Program start!");
            Shape[] setOfFigures = new Shape[3];
            CreateArrayOfShapes(setOfFigures);
            PrintInfoAboutArrayOfShapes(setOfFigures);
            log.Info("Program completed successfully!");
        }

        internal static string GetCallingAssembly()
        {
            throw new NotImplementedException();
        }

        static public Shape[] CreateArrayOfShapes(Shape[] setOfFigures)
        {
            Random rnd = new Random();
            int counter = 2;
            while (!counter.Equals(-1))
            {
                switch (rnd.Next(1, 4))
                {
                    case 1:
                        setOfFigures[counter] = new Circle(rnd.Next(1, 10));
                        log.Info($"{setOfFigures[counter].GetType().Name} created!");
                        counter--;
                        break;
                    case 2:
                        int sideA = rnd.Next(1, 10);
                        setOfFigures[counter] = new IsoscelesTriangle(sideA, rnd.Next(1, sideA * 2));
                        log.Info($"{setOfFigures[counter].GetType().Name} created!");
                        counter--;
                        break;
                    case 3:
                        setOfFigures[counter] = new Square(rnd.Next(1, 10));
                        log.Info($"{setOfFigures[counter].GetType().Name} created!");
                        counter--;
                        break;
                    default:
                        break;
                }
            }
            return setOfFigures;
        }
        static public void PrintInfoAboutArrayOfShapes(Shape[] setOfFigures)
        {
            log.Info("The process of outputting data to the console has begun!");
            foreach (var aShape in setOfFigures)
            {
                string typeOfShape = aShape.GetType().Name;
                if (typeOfShape.Equals("IsoscelesTriangle"))
                {
                    System.Console.WriteLine($"Side A: {aShape.SideOrRadius}, side B: {aShape.BaseOfTriangle}");
                }
                else if (typeOfShape.Equals("Circle"))
                {
                    System.Console.WriteLine($"Radius: {aShape.SideOrRadius}");
                }
                else System.Console.WriteLine($"Side: {aShape.SideOrRadius}");
                System.Console.WriteLine($"This is {aShape.GetType().Name}. CLR type is {aShape.GetType()}. Area is {aShape.Area}");
            }
        }
    }
}
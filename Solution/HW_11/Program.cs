using System;

namespace HW_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] setOfFigures = new Shape[3];
            CreateArrayOfShapes(setOfFigures);
            PrintInfoAboutArrayOfShapes(setOfFigures);
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
                        counter--;
                        break;
                    case 2:
                        int sideA = rnd.Next(1, 10);
                        setOfFigures[counter] = new IsoscelesTriangle(sideA, rnd.Next(1, sideA * 2));
                        counter--;
                        break;
                    case 3:
                        setOfFigures[counter] = new Square(rnd.Next(1, 10));
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
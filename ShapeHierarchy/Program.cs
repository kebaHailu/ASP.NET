using System;
using Shape;

namespace Shape
{
    class Program{

        public static void PrintShapeArea(Shapes element){
            Console.WriteLine($"Shape Name - {element.Name}");
            Console.WriteLine($"Area = {element.CalculateArea()}");
            Console.WriteLine();
            


        }
        public static void Main(){
            Circle circle = new("Circle",34);
            Rectangle rectangle = new("square",40,40);
            Triangle triangle = new("equiliateral",50,50);

            PrintShapeArea(circle);
            PrintShapeArea(rectangle);
            PrintShapeArea(triangle);


        }
    }

}



namespace Shape
{
    public class Shapes
    {
        public string? Name { get; set; }
        
        public virtual double CalculateArea(){

            return 0;
        }
    }

    public class Circle: Shapes
    {
        public Circle(String Name,double radius){
            this.Name = Name;
            this.Radius = radius;

        }
        public double Radius {get;}

        public override double CalculateArea()
        {
            return Math.PI * (Radius * Radius);
        }
    }
    public class Rectangle: Shapes
    {
        public Rectangle(string Name,double height, double width){
            this.Name = Name;
            this.Height = height;
            this.Width = width;

        }
        public double Height {get;}
        public double Width {get;}

        public override double CalculateArea(){
            return this.Height * this.Width;
        }

    }
    public class Triangle:Shapes 
    {
        public Triangle(string Name,double bases, double height){
            this.Name=Name; 
            this.Base = bases;
            this.Height = height;
        }
        public double Base {get;}
        public double Height{get;}
        public override double CalculateArea(){
            return this.Base * this.Height*0.5;
        }

    }
}

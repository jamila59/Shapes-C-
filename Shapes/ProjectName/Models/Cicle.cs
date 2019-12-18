namespace Shapes.Models
{
    public class Circle
    {
        public int Radius {get; set;}
        public int Diameter {get; set;}
        public double Circumference {get; set;}
   
    public Circle(int radius, int diameter, double circumference)
    {
        Radius =  radius;
        Diameter = diameter;
        Circumference = circumference;
    }
    public double getCircumference(int diameter)
    {
        return (3.14* diameter);
    }
    public double getDiameter(int radius)
    {
        return (radius*2);
    }
    public bool IsCircle(int radius, double diameter)
    {
        if (diameter / 2 == radius)
        {
            return true;
        }
        return false;
    }

    }
}
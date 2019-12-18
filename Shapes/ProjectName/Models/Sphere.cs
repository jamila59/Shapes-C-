using System;

namespace Shapes.Models
{
    public class Sphere
    {
        public int Radius {get; set;}
        
    public Sphere(int radius)
    {
        Radius =  radius;

    }
    public double getVolume(int radius)
    {
        return ((4/ 3.0) * Math.PI * Math.Pow(radius,3));
    }
    public double getSurfaceArea(int radius)
    {
        return (4.1887 * Math.Pow(radius, 2));
    }
    

    }
}
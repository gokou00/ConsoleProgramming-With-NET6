
public class Cube : Shape, IShape
{

    public Cube(double width,double height, double length)
    {
       
        Width = width;
        Height = height;
        Length = length;
    }

    public double Width { get; set; }


    public double getArea()
    {
        return Width * Length;
    }
    public double getVolume()
    {
        return Length * Width * Height;
    }
}


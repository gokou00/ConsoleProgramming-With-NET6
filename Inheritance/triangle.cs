public class triangle : Shape, IShape
{

    public triangle()
    {

    }
    public triangle(double hypotenuese)
    {
        Hypotenuese = hypotenuese;
    }

    public double Hypotenuese { get; set; }

    public double getArea()
    {
        return 1.0 / 2.0 * Length * Height; 
    }
    
}


namespace MathTutor;

using HW10;
using static HW10.CartesianPlane;
public class Tutor
{

    static void Main(string[] args)
    {
        var r = new GeometricObjects.Rectangle(new GeometricObjects.Point[]{ new GeometricObjects.Point(0, 1), new GeometricObjects.Point(2, 0), new GeometricObjects.Point(0, 0), new GeometricObjects.Point(2, 1) });
        Console.WriteLine(r.ToString());
        var p = new CartesianPlane();
        p.AddObljectToPlane(r);
        p.Print();


    }
}

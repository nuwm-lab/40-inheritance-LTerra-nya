using System;
using System.Security.Cryptography;
using System.Text;
public class Line
{
    double[] vals = new double[3];
    // тут я задав так трохи по "рагульски" змінні для того щоб я не заплутався, бо функція йде як a1x + a2y + a0
    public Line(double a1, double a2, double a0)
    {
        this.vals[1] = a1;
        this.vals[2] = a2;
        this.vals[0] = a0;
    }
    public Line()
    {
        this.vals[1] = 0;
        this.vals[2] = 0;
        this.vals[0] = 0;
    }
    public void SetLine(double a1x, double a2x, double a0x)
    {
        vals[1] = a1x;
        vals[2] = a2x;
        vals[0] = a0x;
    }
    public void PrintVals()
    {
        for (int i = 0; i < this.vals.Length; i++)
        {
            Console.WriteLine(" a" + i + ": " + this.vals[i]);
        }

    }

    public bool IsBel(double x, double y)
    {
        //xa1 + ya2 + a0 = 0
        if (x * vals[1] + y * vals[2] + vals[0] == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
public class Hyper : Line
{
    double[] vals = new double[5];

    public Hyper(double a1, double a2, double a3, double a4, double a0) : base(a1, a2, a0)
    {
        this.vals[1] = a1;
        this.vals[2] = a2;
        this.vals[3] = a3;
        this.vals[4] = a4;
        this.vals[0] = a0;
    }
    public void SetHyper(double a1x, double a2x, double a3x, double a4x, double a0x)
    {
        vals[1] = a1x;
        vals[2] = a2x;
        vals[3] = a3x;
        vals[4] = a4x;
        vals[0] = a0x;
    }
    public void PrintVals()
    {
        for (int i = 0; i < vals.Length; i++)
        {
            Console.WriteLine(" a" + i + ": " + vals[i]);
        }

    }
    public bool IsBel(double x, double y, double z, double f)
    {
        //xa1 + ya2 + a0 = 0

        if (x * vals[1] + y * vals[2] + z * vals[3] + f * vals[4] + vals[0] == 0)
        {

            return true;
        }
        else
        {
            return false;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Line Funct = new Line();
        Funct.SetLine(4, -5, 2);
        Funct.PrintVals();
        Console.WriteLine("A = {2,2} - " + Funct.IsBel(2, 2));
        Console.WriteLine("A = {5,5} - " + Funct.IsBel(5, 5));
        Console.WriteLine("Try for yourself, enter two values");
        int A = Convert.ToInt32(Console.ReadLine());
        int B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("A = {" + A + "," + B + "} - " + Funct.IsBel(A, B));

        Console.WriteLine("Now try a line, enter three values");
        A = Convert.ToInt32(Console.ReadLine());
        B = Convert.ToInt32(Console.ReadLine());
        int C = Convert.ToInt32(Console.ReadLine());
        Line UserFunct = new Line(A, B, C);
        UserFunct.PrintVals();
        Console.WriteLine("Two values for the line to check");
        A = Convert.ToInt32(Console.ReadLine());
        B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("A = {2,2} - " + UserFunct.IsBel(2, 2));
        Console.WriteLine("A = {5,5} - " + UserFunct.IsBel(5, 5));
        Console.WriteLine("A = {" + A + "," + B + "} - " + UserFunct.IsBel(A, B));


        Hyper Plane = new Hyper(-2, -3, -2, -2, 28);
        Plane.PrintVals();
        Console.WriteLine("X = {2,2,4,5} - " + Plane.IsBel(2, 2, 4, 5));
        Console.WriteLine("X = {5,1,3,8} - " + Plane.IsBel(5, 1, 3, 8));

        Console.WriteLine("Try for yourself, enter four values");
        A = Convert.ToInt32(Console.ReadLine());
        B = Convert.ToInt32(Console.ReadLine());
        C = Convert.ToInt32(Console.ReadLine());
        int D = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("X = {" + A + "," + B + "," + C + "," + D + "} - " + Plane.IsBel(A, B, C, D));

        Console.WriteLine("Now a plane, enter five values");
        A = Convert.ToInt32(Console.ReadLine());
        B = Convert.ToInt32(Console.ReadLine());
        C = Convert.ToInt32(Console.ReadLine());
        D = Convert.ToInt32(Console.ReadLine());
        int E = Convert.ToInt32(Console.ReadLine());
        Hyper UserPlane = new Hyper(A, B, C, D, E);
        UserPlane.PrintVals();
        Console.WriteLine("X = {2,2,4,5} - " + UserPlane.IsBel(2, 2, 4, 5));
        Console.WriteLine("X = {5,1,3,8} - " + UserPlane.IsBel(5, 1, 3, 8));
        Console.WriteLine("And now test it yourself, four values!");
        A = Convert.ToInt32(Console.ReadLine());
        B = Convert.ToInt32(Console.ReadLine());
        C = Convert.ToInt32(Console.ReadLine());
        D = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("X = {" + A + "," + B + "," + C + "," + D + "} - " + UserPlane.IsBel(A, B, C, D));

    }
}
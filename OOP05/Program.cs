using System;
#region Q1
public class POINT : ICloneable, IComparable<POINT>
{
    public int x { get; set; }
    public int y { get; set; }
    public int z { get; set; }

    public POINT()
    {
    }
    public POINT(int X)
    {
        x = X;
    }
    public POINT(int X, int Y)
    {
        x = X; y = Y;
    }

    public POINT(int X, int Y, int Z)
    {
        x = X; y = Y; z = Z;
    }
    public override string ToString() => ($"{x},{y},{z}");

    public object Clone() => new POINT(x, y, z);


    public int CompareTo(POINT other)
    {

        int result = x.CompareTo(other.x);
        if (result == 0)
            result = y.CompareTo(other.y);
        if (result == 0)
            result = z.CompareTo(other.z);
        return result;


    }
    public static bool operator ==(POINT A, POINT B) => A?.Equals(B) ?? B is null;

    public static bool operator !=(POINT A, POINT B) => !(A == B);
}
#endregion
namespace OOP05
{
    internal class Program
    {
        static void Main()
        {
            #region Q1
            POINT[] pOINTs = {
            new POINT(10,30,40),
            new POINT(30,80,10),
            new POINT(33,44,66),

            };
            foreach (POINT p in pOINTs)
            {
                Console.WriteLine(p);
            }
            Array.Sort(pOINTs);
            Console.WriteLine("----------");
                foreach (POINT p in pOINTs)
                Console.WriteLine(p);

            #endregion
        }
    }
}

using System;
#region Q1
public class POINT:ICloneable, IComparable<POINT>
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
    public POINT(int X,int Y)
    {
        x=X; y=Y;
    }

    public POINT(int X,int Y, int Z)
    {
        x=X; y=Y; z=Z;  
    }
    public override string ToString()=>($"{x},{y},{z}");

    public object Clone()=>new POINT();


    public int CompareTo(POINT other)
    {

        int result = x.CompareTo(other.x);
        if (result == 0)
            result = y.CompareTo(other.y);
        return result;
    }
}
#endregion
namespace OOP05
{
    internal class Program
    {
        static void Main()
        {
          
        }
    }
}

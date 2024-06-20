using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Square s1 = new Square( "red" , 3 );

        //Console.WriteLine($"the side is {s1.GetArea()}, And the color is {s1.GetColor()}");

        //Circle c1 = new Circle( "green" , 6 );

        //Console.WriteLine($"The area of the circle is {c1.GetArea()}, And the color of the circle is {c1.GetColor()}");

        //Rectangle r1 =  new Rectangle("blue", 4,5 );

        //Console.WriteLine($"The are of the rectangle is {r1.GetArea()}, and the color of the rectangle is {r1.GetColor()}");

        List<Shape> mylist = new List<Shape>();
        Square s1 = new Square("red", 3);
        mylist.Add(s1);

        Rectangle r1 = new Rectangle("blue", 4,5);
        mylist.Add(r1);

        Circle c1 = new Circle("green" , 6);
        mylist.Add(c1);


        foreach(Shape x in mylist)
        {
            string color = x.GetColor();
            double area = x.GetArea();

            Console.WriteLine($"the {color} shape has an area of {area}");
        }


        

    }
}
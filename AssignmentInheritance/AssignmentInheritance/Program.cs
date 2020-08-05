using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace AssignmentInheritance
{
    abstract class Quadrilateral
    {
       public int length;
        
        public Quadrilateral()
        {

        }
       public Quadrilateral(int _length)
        {
            length = _length;
        }
        public abstract int Area();

       
    }

    class Square : Quadrilateral
    {
        public Square ()
        {

        }
         
        public Square(int _length) 
        {
           
        }
        public override int Area()
        {
            return length*length ;
        }
    }

    class Rectangle : Quadrilateral
    {
        int breadth;

        public Rectangle()
        {

        }

        public Rectangle(int _length,int _breadth)
        {
            length = _length;
            breadth = _breadth;
           
        }
        public override int Area()
        {
            return length*breadth  ;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(4);
            s.Area();
            
           

            Rectangle r = new Rectangle(5, 6);
            r.Area();

            if (s.Area()>r.Area())
            {
                Console.WriteLine("square area is greater than rectangle area");
            }
            else
            {
                Console.WriteLine("rectangle area is greater than square");
            }


            Console.Read();

            

           
        }
    }
}

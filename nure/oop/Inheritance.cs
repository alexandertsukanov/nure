using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nure.oop
{

   abstract class Shape
   {

       abstract public double length();
       abstract public void moveUp(double y);
       abstract public void moveDown(double y);
       abstract public void moveLeft(double y);
       abstract public void moveRight(double y);

   }

    class Line : Shape
    {

        
        protected double x1 { get; set; }
        protected double y1 { get; set; }
        protected double x2 { get; set; }
        protected double y2 { get; set; }

        public override double length()
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        public override void moveUp(double y)
        {

            this.y1 += y;
            this.y2 += y;

        }
        public override void moveDown(double y)
        {

            this.y1 -= y;
            this.y2 -= y;

        }
        public override void moveLeft(double x)
        {

            this.x1 -= x;
            this.x2 -= x;

        }
        public override void moveRight(double x)
        {

            this.x1 += x;
            this.x2 += x;

        }

        public Line(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public override string ToString()
        {

            return "Класс: " + this.GetType().Name + "\n" + "Длина: " + this.length() + "\n";

        }

    }

    class Rhombus : Line
    {


      protected double angle;

      double  Square()
        {
            return Math.Pow(length(), 2) * Math.Sin(angle);
        }

      double P()
        {

            return 4 * length();

        }

      public override string ToString()
        {

            return "Класс: " + this.GetType().Name + "\n" + "Площадь: " + Square() + "\n" + "Периметр: " + P() + "\n" + "Угол: " + angle + "\n";

        }



        public Rhombus(double angle, double x1, double y1, double x2, double y2)
            : base(x1, y1, x2, y2)
        {

            angle = Math.PI * angle / 180;
            this.angle = angle;

        }
    }

    class Parallelepiped : Rhombus
    {

        double h;

        
        double Square()
        {
            return 2 * (length() + length() + h);
        }

        //Периметр онснования
        double P()
        {

            return 2 * length() + 2 * length();

        }

        public Parallelepiped(double h, double angle, double x1, double y1, double x2, double y2)
            : base(angle, x1, y1, x2, y2)
        {
            this.h = h;
        }

        public override string ToString()
        {

            return "Класс: " + this.GetType().Name + "\n" + "Площадь: " + Square() + "\n" + "Периметр основания: " + P() + "\n" + "Угол: " + angle + "\n" + "Высота: " + h + "\n";

        }

    }

    class TestClass
    {

        static void Main(string[] args)
        {
            //Задание А

            Line line = new Line(2, 2, 4, 4);
            Console.WriteLine(line);
            Rhombus rhombus = new Rhombus(15, 2, 2, 4, 4);
            Console.WriteLine(rhombus);
            Parallelepiped parallelepiped = new Parallelepiped(2, 15, 2, 2, 4, 4);
            Console.WriteLine(parallelepiped);

            //Задание Б

            Shape[] links = new Shape[3];
            links[0] = line;
            links[1] = rhombus;
            links[2] = parallelepiped;

            Console.WriteLine(links[0]);
            Console.WriteLine(links[1]);
            Console.WriteLine(links[2]);

        }

    }


}

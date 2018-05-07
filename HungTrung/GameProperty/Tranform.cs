using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungTrung.GameProperty
{
    class Tranform
    {
      public class Position
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Position()
            {
                X = 0;
                Y = 0;
            }
            public Position(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public static Position operator +(Position a, Position b)
            {
                return new Position(a.X + b.X, a.Y + b.Y);
            }


            public static Position operator *(int a, Position b)
            {
                return new Position(a *  b.X, a * b.Y);
            }
        }

      public class Size
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Size()
            {
                X = 1;
                Y = 1;
            }
            public Size(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }
       
      public class Rotration
        {
            public double phi { get; set; }

            public Rotration()
            {
                phi = 0;
            }

        }

        public static Tranform.Position Up = new Position(0,-1);
        public static Tranform.Position Down = new Position(0, 1);
        public static Tranform.Position Left = new Position(-1, 0);
        public static Tranform.Position Right = new Position(1, 0);

        public Position position { get; set; }
        public Size size { get; set; }
        public Rotration rotration { get; set; }
        
        public Tranform()
        {
            position = new Position();
            size = new Size();
            rotration = new Rotration();
        }

        public static Tranform operator +(Tranform a, Tranform b)
        {
            Position pnew = new Position();
            pnew = a.position + b.position;
            Tranform newtran = new Tranform();
            newtran.position = pnew;
            return newtran;
        }


        public static Tranform operator +(Tranform a,Position b)
        {
            Position p = new Position(a.position.X + b.X, a.position.Y + b.Y);
            Tranform t = new Tranform();
            t.position = p;
            return t;     
        }


        public void Move(Tranform.Position k)
        {
            this.position += k;
        }

      

    }
}

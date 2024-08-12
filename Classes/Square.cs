using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Square : Shape, IFaces, IShape
    {
        private int side;

        public Square(int s) 
        {
            SetSide(s);
            if (s > 10)
            {
                throw new Exception("Cannot be greater then 10");
            }

            side = s;
        }

        public Square() { }

        private void SetSide(int s)
        {
        

            side = s;
        }

        public override int GetArea()
        {
            return side * side;
        }

        public int GetFaces() 
        {
            throw new NotImplementedException();
        }

        public readonly int Sides;

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1ObjectOriented.Classes
{
    public abstract class Shape : Interfaces.IShape
    {
        private int area;

        public abstract int GetArea();

        public void SetArea(int Area)
        {
            area = Area;
        }

        public string? Colour { get; set; }


    } 

}

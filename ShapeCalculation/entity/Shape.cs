﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation
{
    public abstract class Shape
    {
        protected double area;
        protected double perimeter;

        public abstract String getName();
        public abstract void calculateArea();
        public abstract void calculatePerimeter();

        protected abstract void invokeValidations();

        public double getArea() {
            return area;
        }

        public double getPerimeter()
        {
            return perimeter;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeCalculation.adapter.exception
{
    public class InvalidOperationNameException : Exception
    {
         public InvalidOperationNameException() : base("The name of the operation is not valid") { }
    
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    public class PriceMustBeGratherThanZeroException : Exception
    {
        public PriceMustBeGratherThanZeroException(string? message) : base(message)
        {
        }
    }
}
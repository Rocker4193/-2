﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class MyClass<T> where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }
}

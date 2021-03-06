﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;

        private static ChocolateBoiler uniqueInstancep;

        public static ChocolateBoiler getInstance()
        {
            if (uniqueInstancep == null)
            {
                uniqueInstancep = new ChocolateBoiler();

            }
            return uniqueInstancep;
        }

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public void fill()
        {
            if (isEmpty())
            {
                empty = false;
                boiled = false;
            }
        }
        public void drain()
        {
            if (!isEmpty() && isBoiled())
            {
                empty = true;
            }
        }

        public void boil()
        {
            if (!isEmpty() && !isBoiled())
            {
                boiled = true;
            }
        }

        public bool isEmpty()
        {
            return empty;
        }
        public bool isBoiled()
        {
            return boiled;
        }
    }
}

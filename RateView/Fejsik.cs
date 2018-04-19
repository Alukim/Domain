using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fejsik
    {
        private bool isLogged;

        public bool Login(string credential)
        {
            return true;
        }

        public void SendRate(string comment, Meal meal)
        {
            if (isLogged)
            {
                //Send rate to fejsik
            }
        }
    }
}

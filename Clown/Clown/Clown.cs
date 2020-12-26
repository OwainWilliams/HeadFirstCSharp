using System;
using System.Collections.Generic;
using System.Text;

namespace Clown
{
    class Clown
    {
        // Fields
        public string Name;
        public int Height;

        //Method
        public void TalkAboutYourself()
        {
            Console.WriteLine("My name is " + Name + " and I'm " + Height + " inches tall.");
        }
    }
}

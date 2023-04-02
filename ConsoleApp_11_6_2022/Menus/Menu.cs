using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_11_6_2022.Menus
{
    public class Menu
    {
        /*
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        */

        public string Options
        {
            get { return options; }
        }


        private string newLineString = "\n";
        private string lineSeparater = "_______________________";

        private string numberSeparator = ")";
        private string numberSpacing = " ";

        //private string message;
        private string options = "";


        public virtual string CreateMessage()
        {
            return "ERROR: No message found.";
        }

        public void WriteMessage()
        {
            string message = CreateMessage();

            Console.WriteLine(message);
        }

        public void WriteOptions()
        {
            Console.WriteLine();
            Console.WriteLine(lineSeparater);
            Console.WriteLine(options);
            Console.WriteLine(lineSeparater);
            Console.WriteLine();
        }

        protected void AddOption(string option, int number)
        {
            if (options.Length != 0)
            {
                options += newLineString;
            }
            options +=  number + numberSeparator + numberSpacing + option;
        }

        protected void RemoveAllOptions()
        {
            options = "";
        }

        public virtual MenuList CheckInput(int input, out string message)
        {
            message = "";
            return MenuList.None;
        }

    }
}

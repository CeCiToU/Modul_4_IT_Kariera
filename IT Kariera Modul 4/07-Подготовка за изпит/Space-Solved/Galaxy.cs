using System.Collections.Generic;
using System;

namespace ConsoleApp333
{
    internal class Galaxy
    {
        private string name;
        private string type;
        private string age;

        public Galaxy()
        {

        }

        public Galaxy(string name, string type, string age)
        {
            Name = name;
            Type = type;
            Age = age;
        }
        public string Name { get { return name; } set { name = value; } }
        public string Type
        {
            get { return type; }
            set
            {
                switch (value)
                {
                    case "elliptical":
                        type = value;
                            break;
                    case "lenticular":
                        type = value;
                        break;
                    case "spiral":
                        type = value;
                        break;
                    case "irregular":
                        type = value;
                        break;
                }
            }
        }
        public string Age { get { return age; } set { age = value; } }

    }
}
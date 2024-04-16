using ClassTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask.Models
{
    internal class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (CheckName(value))
                {

                    _name = value;

                }
            }
        }
        public Person(string name)
        {
            Name = name;
        }
        static bool CheckName(string name)
        {
            if (name.Length < 3 || name.Length > 25)
            {
                throw new CheckNameException("adin olcusu duzgun deyil");
            }
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                {
                    throw new CheckNameException("ad duzgun daxil edilmiyib");
                }
            }
            return true;
        }
    }
}

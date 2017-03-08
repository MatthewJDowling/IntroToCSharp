using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExercises
{
    public class Name1
    {
        public string firstName;
        public string middleName;
        public string lastName;

        public string FullName
        {
            get
            {
                return firstName + " " + middleName + " " + lastName;
            }
            set
            {
                string[] names = value.Split(' ');
                
                if(names.Count() == 3)
                {
                    firstName = names[0];
                    middleName = names[1];
                    lastName = names[2];
                }  
                else if (names.Count() == 2)
                {
                    firstName = names[0];
                    middleName = "";
                    lastName = names[1];
                }
                else if (names.Count() == 1)
                {
                    firstName = names[0];
                    middleName = "";
                    lastName = "";
                }
            }
            }
        }
    }
}
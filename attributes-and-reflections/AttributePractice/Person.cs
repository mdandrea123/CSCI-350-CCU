using System.ComponentModel.DataAnnotations;
using System;
using System.Text;
using System.Reflection;

namespace AttributePractice
{

    public class Person
    {

        [Required]
        [PersonalInformation(1)]
        [Number(1)]
        public string FirstName { get; set; }
        [PersonalInformation(1)]
        [Letter('a')]
        public string LastName { get; set; }

        [PersonalInformation(3)]
        [Number(3)]
        public string SSN { get; set; }
        [PersonalInformation(3)]
        [Letter('b')]
        public int Age { get; set; }
        [PersonalInformation(1)]
        [Number(2)]
        public string Birthday { get; set; }

        public Person()
        {
            FirstName = null;
            LastName = null;
        }
        [Obsolete]
        public Person(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName}";
        }

        public string ToStringRedacted()
        {
            StringBuilder sb = new StringBuilder();
            Type t1 = this.GetType();
            PropertyInfo[] p = t1.GetProperties();
            foreach (PropertyInfo pi in p)
            {
                object[] obj = pi.GetCustomAttributes(true);
                foreach (object o in obj)
                {
                    if (o is PersonalInformationAttribute)
                    {
                        PersonalInformationAttribute pia = (PersonalInformationAttribute)o;
                        if (pia.Level > 1)
                        {
                            sb.Append(pi.Name + ": ***** ");
                        }
                        else
                        {
                            sb.Append(pi.Name + ": " + pi.GetValue(this) + " ");
                        }
                    }
                }
            }
            return sb.ToString();
        }
    }
}
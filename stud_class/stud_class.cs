using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stud_class
{
    public class Students
    {
        public string fio;
        public string age;
        public string dr;

        public Students(string n, string a, string drr) { fio = n; age = a; dr = drr; }

        public string GetInfo()
        {
            return $"ФИО: {fio} \n Возраст: {age} \n Дата рождения: {dr}";
        }
    }
}

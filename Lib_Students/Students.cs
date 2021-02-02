using System;

namespace Lib_Students
{
    public class Students
    {
        public string fio;
        private string age;
        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                if (Age == "")
                {
                    age = "Пустое поле";
                }
                else
                {
                    age = value;
                }
                
            }
        }
        public string dr;

        public Students(string n, string a, string drr) { fio = n; Age = a; dr = drr; }

        public string GetInfo ()
        {
            return $"ФИО: {fio} \n Возраст: {Age} \n Дата рождения: {dr}";
        }
    }
}

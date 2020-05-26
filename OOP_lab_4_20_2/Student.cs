using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab_4_20_2
{
    class Student
    {
        private DateTime _birthday;
        private string _lastname;
        private string _initials;

        public DateTime Birthday
        {
            get => _birthday;
            set => _birthday = value;
        }
        public string Lastname
        {
            get => _lastname;
            set => _lastname = value;
        }
        public string Initials
        {
            get => _initials;
            set => _initials = value;
        }

        public Student()
        {
            Birthday = DateTime.Parse("01.01.01");
            Lastname = "Не вказали";
            Initials = "Не вказали";
        }
    }

}

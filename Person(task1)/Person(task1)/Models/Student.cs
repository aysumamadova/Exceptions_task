using System;
using System.Collections.Generic;
using System.Text;

namespace Person_task1_.Models
{
    class Student:Person
    {
        private double _IQRank;
        private double _LanguageRank;
        public double IQRank
        {
            get
            {
                return _IQRank;
            }
            set
            {   _IQRank = value;
            }

        }
        public double LanguageRank
        {
            get
            {
                return _LanguageRank;
            }
            set
            {
                  _LanguageRank = value;
                
            }

        }

        public Student(string name,string surname,int age, double IQRank, double LanguageRank)
        { 
            this.name = name;
            this.surname = surname; 
            this.age = age;
            this.IQRank = IQRank;
            this.LanguageRank = LanguageRank;

        }


        public void ExamResult(double LanguageRank,double IQRank,double Exam)
        {
            if ((LanguageRank+IQRank)>=120)
            {
                Exam = LanguageRank + IQRank;
                Console.WriteLine($"Imtahandan kecdiniz:neticeniz {Exam}bal" );

            }
            else
            {
                Console.WriteLine("Kesildiniz");
            }
        }

    }
}

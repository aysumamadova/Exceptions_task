using System;
using Person_task1_.Models;
using static Person_task1_.Exceptions.Exceptions;

namespace Person_task1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string surname = "";
            int age = 0;
            double workingHour = 0;
            double salaryOfHoure = 0;
            double salary = 0;
            double IQRank = 0;
            double LanguageRank = 0;
            double Exam = 0;
            int Key;
            do
            { 
                Start:
                try
                {
                    Console.WriteLine("Reqem daxil edin");
                    Console.WriteLine("1.Maaşın hesablanması");
                    Console.WriteLine("2.Imtahan balinin hesablanması");
                    Key = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Reqem daxil etmelisiniz");
                    goto Start;
                }
               

                switch (Key)
                {
                    case 1:
                        InputEmployee(name, surname, age,ref workingHour,ref salaryOfHoure);
                        Employee emp = new Employee(name, surname, age, workingHour, salaryOfHoure);
                        emp.CalculateSalary(salaryOfHoure,workingHour,salary);
                       break;
                    case 2:
                        InputStudent(name, surname, age, ref IQRank, ref LanguageRank);
                        Student stu = new Student(name, surname, age, IQRank, LanguageRank);
                        stu.ExamResult(LanguageRank,IQRank,Exam);
                        break;
                    default:
                        Console.WriteLine("Yanlis daxil etdiniz");
                        break;
                }

            } while (Key!=3);

            static void InputEmployee( string name, string surname, int age,ref double workingHour,ref double salaryOfHour)
            {
                EmpName(name);
                EmpSurname(surname);
                EmpAge(age);
                EmpWorkingHour(ref workingHour);
                EmpSalaryOfHour(ref salaryOfHour);

            }
            static void EmpName(string name)
            {
                Console.WriteLine("Iscinin adini daxil edin");
                 name = Convert.ToString(Console.ReadLine());
            }
          

            static void EmpSurname(string surname)
            {
              //Start:
              //  try
              //  {
                    Console.WriteLine("Iscinin soyadini daxil edin");
                    surname = Convert.ToString(Console.ReadLine());
                //    throw new NullEmptyWhiteSpaceException("Herf  daxil etmelisiniz");
                ////}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //    goto Start;
                //}
               
            }

            static void EmpAge(int age)
            {
             Start:
                try
                {
                    Console.WriteLine("Iscinin yasini daxil edinn");
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age < 18 || age >= 70)
                        throw new NotAvailableException("Islemek olmaz");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Yalniz reqem daxil edilmelidir");
                    goto Start;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Start;
                }

            }

            static void EmpWorkingHour(ref double workingHour)
            {

             Start:
                try
                {
                    Console.WriteLine("Ayliq is saatini daxil edin");
                    workingHour = Convert.ToDouble(Console.ReadLine());
                    if (workingHour <= 0 || workingHour > 240)
                        throw new NotAvailableException("Duzgun is sati deyil");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Yalniz reqem daxil edilmelidir");
                    goto Start;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Start;
                }

            }
            static void EmpSalaryOfHour( ref double salaryOfHour)
            {
              Start:
                try
                {
                    Console.WriteLine("Saat basi qadanzigi maasi daxil edin");
                    salaryOfHour = Convert.ToDouble(Console.ReadLine());
                    if (salaryOfHour <= 0)
                        throw new NotAvailableException("Yanlis daxil edildi");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Yalniz reqem daxil edilmelidir");
                    goto Start;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Start;
                }
              
            }


            static void InputStudent(string name, string surname, int age, ref double IQRank, ref double LanguageRank)
            {

                StuName(name);
                StuSurname(surname);
                StuAge(age);
                StuIQRank(ref IQRank);
                StuLanguageRank(ref LanguageRank);

            }
            static void StuName(string name)
            {
             //Start:
             //   try
             //   {
                    Console.WriteLine("Sagirdin adini daxil edin");
                    name = Convert.ToString(Console.ReadLine());
                //    throw new NullEmptyWhiteSpaceException("Herf daxil etmelisiniz");
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //    goto Start;
                //}

            }


            static void StuSurname(string surname)
            {
            //Start:
            //    try
            //    {
                    Console.WriteLine("Sagirdin soyadini daxil edin");
                    surname = Convert.ToString(Console.ReadLine());
                //    throw new NullEmptyWhiteSpaceException("Herf  daxil etmelisiniz");
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //    goto Start;
                //}

            }

            static void StuAge(int age)
            {
            Start:
                try
                {
                    Console.WriteLine("Sagirdin yasini daxil edin");
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age < 6 || age > 20)
                        throw new NotAvailableException("Sagird deyil");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Yalniz reqem daxil edilmelidir");
                    goto Start;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Start;
                }

            }

            static void StuIQRank(ref double IQRank)
            {
            Start:
                try
                {
                    Console.WriteLine("IQ imtahan bali");
                    IQRank = Convert.ToDouble(Console.ReadLine());
                    if (IQRank < 0 || IQRank > 100)
                        throw new NotAvailableException("Duzgun deyil");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Yalniz reqem daxil edilmelidir");
                    goto Start;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Start;
                }

            }
            static void StuLanguageRank(ref double LanguageRank)
            {
            Start:
                try
                {
                    Console.WriteLine("Dil imtahan bali");
                    LanguageRank = Convert.ToDouble(Console.ReadLine());
                    if (LanguageRank < 0 || LanguageRank > 100)
                        throw new NotAvailableException("Duzgun deyil");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Yalniz reqem daxil edilmelidir");
                    goto Start;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Start;
                }

            }

        }
    }
    
}

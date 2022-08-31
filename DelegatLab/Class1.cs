using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLab
{
    class Journal
    {
        public static string NameOfStudent = "John Dow", Discipline = "Discipline";
        public static byte Mark = 0;
        public static string DateOfBirth = "";
        private static string path = "Journal.txt";
        private string Hobby = "";

        public void SetDateOfBirth(string _date)
        {
            DateOfBirth = _date;
        }
        public string GetDateOfBirth()
        {
            return DateOfBirth;
        }
        public void PrintDateOfBirth()
        {
            Console.WriteLine("Дата рождения: " + DateOfBirth);
        }
       
        public void SetHobby(string _hobby)
        {
            Hobby = _hobby;
        }
        public string GetHobby()
        {
            return Hobby;
        }
        public void PrintHobby()
        {
            Console.WriteLine("Хобби студента: " + Hobby);
        }
        public void SetMark(byte _mark)
        {
            Mark = _mark;
        }
        public byte GetMark()
        {
            return Mark;
        }
        public void PrintMark()
        {
            Console.WriteLine("Оценка студента: " + Mark);
        }
        public void SetDiscipline(string nameDiscipline)
        {
            Discipline = nameDiscipline;
        }
        public string GetDiscipline()
        {
            return Discipline;
        }
        public void PrintDiscipline()
        {
            Console.WriteLine("Дисциплина по каторой обучается студент: " + Discipline);
        }
        public void SetName(string _name)
        {
            NameOfStudent = _name;
        }
        public string GetName()
        {
            return NameOfStudent;
        }
        public void PrintName()
        {
            Console.WriteLine("Имя студента: " + NameOfStudent);
        }
        public void WriteNameToFile()
        {
            string myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = myDocs + "\\" + path;
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Имя студента: " + NameOfStudent);
                sw.WriteLine("день рождения: " + DateOfBirth);
                sw.WriteLine("Дисциплина по каторой обучается студент: " + Discipline);
                sw.WriteLine("Оценка: " + Mark);
                sw.WriteLine("Хобби студента: " + Hobby + "\n");
            }
            Console.WriteLine("Информация добавлена в файл {0}.", path);
        }
      
    }
}
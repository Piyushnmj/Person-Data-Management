﻿namespace PersonDataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management");
            List<Person> objListOfPersonsInCity = new List<Person>();
            Repository objRep = new Repository();
            objRep.AddRecords(objListOfPersonsInCity);
        }
    }
}
// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using Entities.Concrete;
using System.Runtime.CompilerServices;


SelamVer("Betül");

static void SelamVer(string isim ="isimsiz")
{
    Console.WriteLine("Merhaba "+isim);
}
Person person1 = new Person();
person1.FirstName = "Betül";
person1.LastName = "Cengiz";
person1.NationalIdentity = 10519819970;
person1.DateOfBirthYear = 1999;


PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);
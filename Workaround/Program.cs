// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.FirstName = "Ümmü Gülsüm";
person1.LastName = "Özaslan";
person1.NationalIdentity = 11111111111;
person1.DateOfBirthYear = 1998;

//PersonManager personManager = new PersonManager();

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

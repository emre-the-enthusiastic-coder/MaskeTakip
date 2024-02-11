// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;

Person fake_citizen = new() { FirstName = "Emre", LastName = "Testingoğulları", NatiaonalIdentity = 12345678910, DateOfBirthYear = 1990 };
Person hasso_citizen = new() { FirstName = "Emre", LastName = "Tekbaş", NatiaonalIdentity = 00000000000, DateOfBirthYear = 1997 };

new PTTManager(new CitizenManager()).GiveMask(fake_citizen);


// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using DataAccess.Concrete.InMemory;

SanatciManager sanatciManager = new SanatciManager(new InMemorySanatciDal());

foreach (var sanatci in sanatciManager.GetAll())
{
    Console.WriteLine(sanatci.SanatciName);
}



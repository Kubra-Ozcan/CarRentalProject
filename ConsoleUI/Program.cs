using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle: Eğer evcut koduna yeni bir özellik ekliyorsan  mevcuttaki hiçbi koduna dokunamazsın .
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetByDailyPrice(0,300))
            {
                Console.WriteLine(car.Description);
            }
            
        }
    }
}

using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1 , BrandId=1,ColorId=1, DailyPrice=15 ,ModelYear=2000 ,Description="BMW"},
                new Car{Id=2 , BrandId=1,ColorId=1, DailyPrice=150 ,ModelYear=2020 ,Description="Peugeot"},
                new Car{Id=3 , BrandId=2,ColorId=1, DailyPrice=200 ,ModelYear=2023 ,Description="Mercedes"},
                new Car{Id=4 , BrandId=2,ColorId=1, DailyPrice=300 ,ModelYear=2022 ,Description="Volkswagen"},
                new Car{Id=5 , BrandId=2,ColorId=1, DailyPrice=500 ,ModelYear=2019 ,Description="Toyota"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars ;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            //Gönderdiğimürün Idsine sahip olan listedki arabayı bul 
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }

}

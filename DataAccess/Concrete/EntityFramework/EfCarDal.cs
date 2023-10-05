using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            //IDispossable pattern implementation of C#
            using (NorthwindContext context= new NorthwindContext())
            {
                var addedEntity = context.Entry(entity); //Referansı yakala(Bu Entityi  Northwind  Contexe  Bağla)
                addedEntity.State = EntityState.Added; //Bu kullanılabilir bir nesne ekleme olarak durumu set et
                context.SaveChanges();  //Şimdi ekle
            };
        }

        public void Delete(Car entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity); //Referansı yakala(Bu Entityi  Northwind  Contexe  Bağla)
                deletedEntity.State = EntityState.Deleted; //Bu kullanılabilir bir nesne ekleme olarak durumu set et
                context.SaveChanges();  //Şimdi ekle
            };
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (NorthwindContext context =new NorthwindContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList(); // Veritabanındaki bütün tabloyu listeye çevir ve bana ve yani arka planda Selct * From komutunu çağırıyor.
            };
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity); //Referansı yakala(Bu Entityi  Northwind  Contexe  Bağla)
                updatedEntity.State = EntityState.Modified; //Bu kullanılabilir bir nesne ekleme olarak durumu set et
                context.SaveChanges();  //Şimdi ekle
            };
        }
    }
}



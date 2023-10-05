using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }


        //public Car()
        //{
        //    // Boş yapıcı metod
        //}

        //public Car(int id, int brandId, int colorId, int modelYear, decimal dailyPrice, string description)
        //{
        //    Id = id;
        //    BrandId = brandId;
        //    ColorId = colorId;
        //    ModelYear = modelYear;
        //    DailyPrice = DailyPrice;
        //    Description = description;
        //}

        //public bool IsValid()
        //{
        //    return Description.Length >= 2 && DailyPrice > 0;
        //}

    }
}

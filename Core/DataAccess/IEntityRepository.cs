using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //class:referans tip 
    // generic constraint 
    //IEntity:IEntity olabilir veya IEntity implemente eden bir nesne olabilir .
    //new() :newlenebilir olmalı .
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        // T ya entity olabilir yada IEntityden kısıtlı bir  şey olabilir 
        //Generic Constraint: Generic kısıt
        //
        List<T> GetAll(Expression <Func<T,bool>> filter=null); // null:Filtre vermeyedebilirsin . 
        //Burası genel olarak filteler olrak yazmaya yarar.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAllByBrand(int brandId);
    }
}

using Infrastructure.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.GenericRepository
{
    //constraint-> T must be a BaseEntity
    interface IGenericRepository<T> where T : BaseEntity
    {
        //CRUD+1

        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task InsertAsync(T obj);
        void Update(T obj);
        void Delete(int id);

        //WithInClude

        IQueryable<T> WithInClude();
    }
}

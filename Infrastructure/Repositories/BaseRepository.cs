using Infrastructure.GenericRepository;
using Infrastructure.Models.Ref;
using Infrastructure.DbCont;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Models.Base;

namespace Infrastructure.Repositories
{
    public class BaseRepository<T> : IGenericRepository<T> where T : BaseEntity
    {

        private readonly Infrastructure.DbCont.DbCont _context;

        public BaseRepository(Infrastructure.DbCont.DbCont context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await WithInClude().ToListAsync();
        }
        
        public void Delete(int id)
        {
            _context.Remove(GetByIdAsync(id));
        }

        public async Task<T> GetByIdAsync(int id)
        {
            //előfordulhat hogy nullt kapunk vissza ha rossz ID adtunk meg
                       
            return (await GetAllAsync())
                .FirstOrDefault(x => x.Id == id);                
        }

        public async Task InsertAsync(T obj)
        {
            await _context.Set<T>().AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public void Update(T obj)
        {
            //azert hogy a T BaseEntity igy az objnak van ID-je meg az osszes BaseEntity property
            var oldObj = GetByIdAsync(obj.Id);

            foreach (var prop in oldObj.GetType().GetProperties())
            {
                prop.SetValue(oldObj, prop.GetValue(obj));
            }

            _context.SaveChanges();
        }

        public virtual IQueryable<T> WithInClude()
        {
            return _context.Set<T>();
        }
    }
}

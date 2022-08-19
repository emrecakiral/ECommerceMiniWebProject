using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        MyContext _context = new MyContext();

        public int Insert(T item)
        {
            _context.Add(item);
            try
            {
                _context.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int Delete(T item)
        {
            _context.Remove(item);
            try
            {
                _context.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public int Update(T item)
        {
            _context.Update(item);
            try
            {
                _context.SaveChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public List<T> FindByCriter(Func<T, bool> expression)
        {
            return _context.Set<T>().Where(expression).ToList();
        }
    }
}

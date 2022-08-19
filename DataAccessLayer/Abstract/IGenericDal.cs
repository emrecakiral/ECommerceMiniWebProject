using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        List<T> GetAll();

        T GetByID(int id);

        int Insert(T item);

        int Update(T item);

        int Delete(T item);

        List<T> FindByCriter(Func<T, bool> expression);
    }
}

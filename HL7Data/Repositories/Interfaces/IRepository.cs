using System.Linq;

namespace HL7Data.Repositories.Interfaces
{
    // http://www.codeproject.com/Articles/615499/Models-POCO-Entity-Framework-and-Data-Patterns

    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
    } 
}

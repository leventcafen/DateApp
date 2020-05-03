using System.Collections.Generic;
using System.Threading.Tasks;
using DateApp_API.Model;

namespace DateApp_API.Data
{
    public interface IDatingRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>>GetUsers();
         Task<User> GetUser(int id);

    }
}
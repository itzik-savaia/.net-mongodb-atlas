using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Models
{
    public interface I_UsersRepository
    {
        Task Add(Users employee);
        Task Update(Users employee);
        Task Delete(string id);
        Task<Users> GetEmployee(string id);
        Task<IEnumerable<Users>> GetEmployees();
    }
}

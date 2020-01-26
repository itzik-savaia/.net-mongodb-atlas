using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Models
{
    public class UsersRepository : I_UsersRepository
    {
        mongocs db = new mongocs();

        public async Task Add(Users employee)
        {
            try
            {
                await db.Users.InsertOneAsync(employee);
            }
            catch
            {
                throw;
            }
        }
        public async Task<Users> GetEmployee(string id)
        {
            try
            {
                FilterDefinition<Users> filter = Builders<Users>.Filter.Eq("Id", id);
                return await db.Users.Find(filter).FirstOrDefaultAsync();
            }
            catch
            {
                throw;
            }
        }
        public async Task<IEnumerable<Users>> GetEmployees()
        {
            try
            {
                return await db.Users.Find(_ => true).ToListAsync();
            }
            catch
            {
                throw;
            }
        }
        public async Task Update(Users employee)
        {
            try
            {
                await db.Users.ReplaceOneAsync(filter: g => g.Id == employee.Id, replacement: employee);
            }
            catch
            {
                throw;
            }
        }
        public async Task Delete(string id)
        {
            try
            {
                FilterDefinition<Users> data = Builders<Users>.Filter.Eq("Id", id);
                await db.Users.DeleteOneAsync(data);
            }
            catch
            {
                throw;
            }
        }
    }
}

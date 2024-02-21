using crudSmall.Data;
using crudSmall.Interfaces;
using crudSmall.Models;

namespace crudSmall.Repositorys
{
    public class UserService(AppDbContext dbContext)
        : IUserInterface
    {
        private readonly AppDbContext _dbContext = dbContext;

        public void Add(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public void Delete(User user)
        {
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        }

        public List<User> GetAll()
        {
            List<User> users = _dbContext.Users.ToList();
            return users;
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}

using crudSmall.Models;

namespace crudSmall.Interfaces
{
    public interface IUserInterface
    {
        public List<User> GetAll();
        public User GetById(int id);
        public void Add(User user);
        public void Delete(User user);
        public void Update(User user);
    }
}

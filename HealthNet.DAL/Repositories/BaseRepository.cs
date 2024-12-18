using HealthNet.DAL.Entities;
using HealthNet.DAL.Repositories.Abstraction;
namespace HealthNet.DAL.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly HealthNetContext _context;
        public BaseRepository(HealthNetContext context)
        {
            _context = context;
        }

        public virtual void Add(T item)
        {
            _context.Add(item);
        }

        public virtual async Task Delete(int id)
        {
            var item = await _context.FindAsync<T>(id);
            if (item != null)
            {
                ((IBaseEntity)item).IsActive = false;
                _context.Update(item);
            }
        }

        public virtual IQueryable<T> Get(int id)
        {
            return _context.Set<T>().Where(x => ((IBaseEntity)x).IsActive && ((IBaseEntity)x).Id == id);
        }

        public virtual IQueryable<T> Get()
        {
            return _context.Set<T>().Where(x => ((IBaseEntity)x).IsActive);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public virtual void Update(T item)
        {
            _context.Update(item);
        }
    }
}

using LeaveManagement.Contracts;
using LeaveManagement.Data;
using LeaveManagement.Data.Migrations.Entity;
using System.Collections.Generic;
using System.Linq;

namespace LeaveManagement.Repository
{
    public class LeaveHistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _context;
        public LeaveHistoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }   
        public bool Create(LeaveHistory entity)
        {
            _context.LeaveHistories.Add(entity);
            return Save();
        }

        public bool Delete(LeaveHistory entity)
        {
            _context.LeaveHistories.Remove(entity);
           return Save();
        }

        public ICollection<LeaveHistory> FindAllAsList()
        {
            return _context.LeaveHistories.ToList();
        }

        public LeaveHistory FindById(int id)
        {
            return _context.LeaveHistories.Find(id);
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }

        public bool Update(LeaveHistory entity)
        {
            _context.LeaveHistories.Update(entity);
            return Save();
        }

        public IEnumerable<LeaveHistory> FindAll()
        {
            return _context.LeaveHistories.AsEnumerable();
        }
    }
}

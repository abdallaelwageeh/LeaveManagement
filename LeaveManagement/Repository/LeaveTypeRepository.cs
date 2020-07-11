using LeaveManagement.Contracts;
using LeaveManagement.Data;
using LeaveManagement.Data.Migrations.Entity;
using System.Collections.Generic;
using System.Linq;

namespace LeaveManagement.Repository
{
    public class LeaveTypeRepository:ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _context;
        public LeaveTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Create(LeaveType entity)
        {
            _context.LeaveTypes.Add(entity);
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _context.LeaveTypes.Remove(entity);
            return Save();
        }

        public ICollection<LeaveType> FindAllAsList()
        {
            return _context.LeaveTypes.ToList();
        }

        public LeaveType FindById(int id)
        {
            return _context.LeaveTypes.Find(id);
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }

        public bool Update(LeaveType entity)
        {
            _context.LeaveTypes.Update(entity);
            return Save();
        }

        public IEnumerable<LeaveType> FindAll()
        {
            return _context.LeaveTypes.AsEnumerable();
        }
    }
}

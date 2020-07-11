﻿using LeaveManagement.Contracts;
using LeaveManagement.Data;
using LeaveManagement.Data.Migrations.Entity;
using System.Collections.Generic;
using System.Linq;

namespace LeaveManagement.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _context;
        public LeaveAllocationRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Create(LeaveAllocation entity)
        {
            _context.LeaveAllocations.Add(entity);
            return Save();
        }

        public bool Delete(LeaveAllocation entity)
        {
            _context.LeaveAllocations.Remove(entity);
            return Save();
        }

        public ICollection<LeaveAllocation> FindAllAsList()
        {
            return _context.LeaveAllocations.ToList();
        }

        public LeaveAllocation FindById(int id)
        {
            return _context.LeaveAllocations.Find(id);
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }

        public bool Update(LeaveAllocation entity)
        {
            _context.LeaveAllocations.Update(entity);
            return Save();
        }

        public IEnumerable<LeaveAllocation> FindAll()
        {
            return _context.LeaveAllocations.AsEnumerable();
        }
    }
}

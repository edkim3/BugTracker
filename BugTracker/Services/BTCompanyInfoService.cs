using BugTracker.Data;
using BugTracker.Models;
using BugTracker.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Services
{
    public class BTCompanyInfoService : IBTCompanyInfoService
    {
        private readonly ApplicationDbContext _context;

        public BTCompanyInfoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<BTUser>> GetAllMembersAsync(int companyId)
        {
            List<BTUser> result = new();
            result = await _context.Users.Where(u => u.CompanyId == companyId).ToListAsync();
            return result;
        }

        public Task<List<Project>> GetAllProjectsAsync(int companyId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Ticket>> GetAllTicketsAsync(int companyId)
        {
            throw new NotImplementedException();
        }

        public Task<Company> GetCompanyInfoByIdAsync(int? companyId)
        {
            throw new NotImplementedException();
        }
    }
}

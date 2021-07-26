﻿using EducationProcess.DataAccess.Entities;
using EducationProcess.DataAccess.Repositories.Interfaces;

namespace EducationProcess.DataAccess.Repositories
{
    public class GroupRepository : RepositoryBase<Group>, IGroupRepository
    {
        private readonly EducationProcessContext _context;
        
        public GroupRepository(EducationProcessContext context) : base(context)
        {
            _context = context;
        }
    }
}
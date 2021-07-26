﻿using EducationProcess.DataAccess.Entities;
using EducationProcess.DataAccess.Repositories.Interfaces;

namespace EducationProcess.DataAccess.Repositories
{
    public class SemesterRepository : RepositoryBase<Semester>, ISemesterRepository
    {
        private readonly EducationProcessContext _context;
        
        public SemesterRepository(EducationProcessContext context) : base(context)
        {
            _context = context;
        }
    }
}
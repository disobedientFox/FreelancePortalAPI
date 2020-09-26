﻿using AutoMapper;
using Core.Models;
using Core.Repositories.Interfaces;

namespace Services.Services.Subjects
{
    class SubjectsService : BaseService<Subject>
    {
        public SubjectsService(IRepository<Subject> repository, IMapper mapper) : base(repository, mapper) { }
    }
}
﻿using AutoMapper;
using Core.Models;
using Core.Repositories.Interfaces;

namespace Services.Services.Reviews
{
    class ReviewsService : BaseService<Review>
    {
        public ReviewsService(IRepository<Review> repository, IMapper mapper) : base(repository, mapper) { }
    }
}

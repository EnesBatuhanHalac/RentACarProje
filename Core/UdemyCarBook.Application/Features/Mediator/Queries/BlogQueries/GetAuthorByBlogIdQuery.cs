﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.Mediator.Results.BlogResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetAuthorByBlogIdQuery:IRequest<GetAuthorByBlogIdQueryResult>
    {
        public int BlogId { get; set; }

        public GetAuthorByBlogIdQuery(int blogId)
        {
            BlogId = blogId;
        }
    }
}

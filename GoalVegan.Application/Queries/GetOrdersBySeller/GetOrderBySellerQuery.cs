﻿using GoalVegan.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Queries.GetOrdersBySeller
{
    public class GetOrderBySellerQuery : IRequest<List<Order>>
    {
        public GetOrderBySellerQuery(int idSeller)
        {
            IdSeller = idSeller;
        }

        public int IdSeller { get; private set; }
    }
}

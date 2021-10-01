﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalVegan.Application.Commands.CancelOrder
{
    public class CancelOrderCommand  : IRequest<Unit>
    {
        public int Id { get; private set; }
    }
}

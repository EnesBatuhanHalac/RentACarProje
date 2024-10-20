﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Commands.FeatureCommands
{
    public class RemoveFeatureCommand:IRequest
    {
        public int FeatureID { get; set; }

        public RemoveFeatureCommand(int featureID)
        {
            FeatureID = featureID;
        }
    }
}

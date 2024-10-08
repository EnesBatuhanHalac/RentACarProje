﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Commands.CarCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var value = await _repository.GetByIdAsync(command.CarID);
            value.Fuel = command.Fuel;
            value.Seat = command.Seat;
            value.BigImageUrl = command.BigImageUrl;
            value.Km=command.Km;
            value.Transmission=command.Transmission;
            value.BrandID = command.BrandID;
            value.BigImageUrl=command.BigImageUrl;
            value.CoverImageUrl=command.CoverImageUrl;
            value.Model=command.Model;
            await _repository.UpdateAsync(value);

        }
    }
}

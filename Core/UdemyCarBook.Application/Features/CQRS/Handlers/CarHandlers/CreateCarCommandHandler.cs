using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Commands.CarCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
          private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle (CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                 BrandID = command.BrandID,
                 Model = command.Model,
                 CoverImageUrl = command.CoverImageUrl,
                 Km = command.Km,
                 Transmission = command.Transmission,
                 Seat = command.Seat,
                 Luggage = command.Luggage,
                 Fuel = command.Fuel,
                 BigImageUrl = command.BigImageUrl
            });
        }
    }
}
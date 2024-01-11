using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Domain;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Propiedad.Commands.DeletePropiedad
{
     public class DeletePropiedadCommandHandler : IRequestHandler<DeletePropiedadCommand>
     {
          private readonly IUnitOfWork _unitOfWork;        
          private readonly IMapper _mapper;
          private readonly ILogger<DeletePropiedadCommandHandler> _logger;

          public DeletePropiedadCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<DeletePropiedadCommandHandler> logger)
          {
               _unitOfWork = unitOfWork;
               _mapper = mapper;
               _logger = logger;
          }



          public async Task<Unit> Handle(DeletePropiedadCommand request, CancellationToken cancellationToken)
          {
               var PropiedadDelete = await _unitOfWork.PropiedadRepository.GetByIdAsync(request.Id);
               if (PropiedadDelete == null)
               {
                    _logger.LogError($"{request.Id} Propiedad no existe en el sistema");
                    throw new NotFoundException(nameof(Domain.Models.sgp.Propiedad), request.Id);
               }
              
               _unitOfWork.PropiedadRepository.DeleteEntity(PropiedadDelete);

               await _unitOfWork.Complete();

               _logger.LogInformation($"El {request.Id} Propiedad fue eliminado con exito");

               return Unit.Value;
          }


     } 
     
}

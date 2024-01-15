using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Application.Exceptions;
using CleanArchitecture.Application.Features.Propiedad.Commands.DeletePropiedad;
using CleanArchitecture.Application.Features.Streamers.Commands.UpdateStreamer;
using CleanArchitecture.Domain;
using CleanArchitecture.Domain.Models.sgp;
using MediatR;
using Microsoft.Extensions.Logging;


namespace CleanArchitecture.Application.Features.Propiedad.Commands.UpdatePropiedad
{
     public  class UpdatePropiedadCommandHandler: IRequest<UpdatePropiedadCommand>
     {
          private readonly IUnitOfWork _unitOfWork;
          //private readonly IStreamerRepository _streamerRepository;
          private readonly IMapper _mapper;
          private readonly ILogger<DeletePropiedadCommand> _logger;

          public UpdatePropiedadCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<DeletePropiedadCommandHandler> logger)
          {
               _unitOfWork = unitOfWork;
               _mapper = mapper;
               _logger = (ILogger<DeletePropiedadCommand>?)logger;
          }

          public async Task<Unit> Handle(UpdatePropiedadCommand request, CancellationToken cancellationToken)
          {
               //var streamerToUpdate =  await  _streamerRepository.GetByIdAsync(request.Id);
               var PropiedadToUpdate = await _unitOfWork.PropiedadRepository.GetByIdAsync(request.Id);

               if (PropiedadToUpdate == null)
               {
                    _logger.LogError($"No se encontro la propiedad id {request.Id}");
                    throw new NotFoundException(nameof(Domain.Models.sgp.Propiedad), request.Id);
               }

               _mapper.Map(request, PropiedadToUpdate, typeof(UpdatePropiedadCommand), typeof(Domain.Models.sgp.Propiedad));



               //await _streamerRepository.UpdateAsync(streamerToUpdate);

               _unitOfWork.PropiedadRepository.UpdateEntity(PropiedadToUpdate);

               await _unitOfWork.Complete();

               _logger.LogInformation($"La operacion fue exitosa actualizando la Propiedad {request.Id}");

               return Unit.Value;
          }
     }
}

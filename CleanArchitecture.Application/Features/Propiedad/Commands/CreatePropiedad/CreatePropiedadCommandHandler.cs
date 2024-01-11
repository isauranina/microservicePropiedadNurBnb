using AutoMapper;
using CleanArchitecture.Application.Contracts.Infrastructure;
using CleanArchitecture.Application.Contracts.Persistence;
using CleanArchitecture.Application.Contracts.Persistence.IRepositories.sgp;
using CleanArchitecture.Application.Models;
using CleanArchitecture.Domain;
using CleanArchitecture.Domain.Models.sgp;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CleanArchitecture.Application.Features.Propiedad.Commands.CreatePropiedad
{
     public class CreatePropiedadCommandHandler : IRequestHandler<CreatePropiedadCommand, long>
     {
          private readonly IUnitOfWork _unitOfWork;
          private readonly IPropiedadRepository _propiedadRepository;
          private readonly IMapper _mapper;
          private readonly IEmailService _emailservice;
          private readonly ILogger<CreatePropiedadCommandHandler> _logger;

          public CreatePropiedadCommandHandler(IUnitOfWork unitOfWork, IPropiedadRepository propiedadRepository, IMapper mapper, IEmailService emailservice, ILogger<CreatePropiedadCommandHandler> logger)
          {
               _unitOfWork = unitOfWork;
               _propiedadRepository = propiedadRepository;
               _mapper = mapper;
               _emailservice = emailservice;
               _logger = logger;
          }

          public async Task<long> Handle(CreatePropiedadCommand request, CancellationToken cancellationToken)
          {
               
               var propiedadEntity = _mapper.Map<Domain.Models.sgp.Propiedad>(request);
               //añadir en MappingProfile
               var newPropiedad = await _propiedadRepository.AddAsync(propiedadEntity);
               return newPropiedad.Id;
          }
          private async Task SendEmail(Streamer streamer)
          {
               var email = new Email
               {
                    To = "bnbnur@gmail.com",
                    Body = "Se añadio una nueva propiedad",
                    Subject = "Mensaje de notificacion"
               };

               try
               {
                    await _emailservice.SendEmail(email);
               }
               catch (Exception ex)
               {
                    _logger.LogError($"El envio de Email no tubo exito {streamer.Id}");
               }

          }
     }
}

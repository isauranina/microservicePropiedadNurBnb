using AutoMapper;
using CleanArchitecture.Application.Contracts.Persistence.IRepositories.sgp;
using MediatR;


namespace CleanArchitecture.Application.Features.Propiedad.Query.GetPropiedadList
{
     public class GetPropiedadListQueryHandler : IRequestHandler<GetPropiedadListQuery, List<PropiedadVm>>
     {
          private readonly IPropiedadRepository _propiedadRepository;
          private readonly IMapper _mapper;

          public GetPropiedadListQueryHandler(IPropiedadRepository propiedadRepository, IMapper mapper)
          {
               _propiedadRepository = propiedadRepository;
               _mapper = mapper;
          }

          public async Task<List<PropiedadVm>> Handle(GetPropiedadListQuery request, CancellationToken cancellationToken)
          {
               var propiedadList =await  _propiedadRepository.GetPropiedadVerificado();
               return _mapper.Map<List<PropiedadVm>>(propiedadList);
               // añadir MappingProfile
          }
     }
}

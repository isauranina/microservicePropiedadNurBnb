using MediatR;


namespace CleanArchitecture.Application.Features.Propiedad.Query.GetPropiedadList
{
     public class GetPropiedadListQuery : IRequest<List<PropiedadVm>>
     {
          public string _Username { get; set; } = String.Empty;
          public GetPropiedadListQuery(string username)
          {
               _Username = username ?? throw new ArgumentNullException(nameof(username));
          }
     }
}

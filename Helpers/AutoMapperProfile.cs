namespace Cadeteria;

using AutoMapper;
using Cadeteria.Models;

public class AutoMapperProfile : AutoMapper.Profile
{
    public AutoMapperProfile()
    {

        // User -> AuthenticateResponse
        CreateMap<User, AuthenticateResponse>();


        // RegisterRequest -> User
        CreateMap<RegisterRequest, User>();


        // UpdateRequest -> User
        CreateMap<UpdateRequest, User>()
            .ForAllMembers(x => x.Condition(
                (src, dest, prop) =>
                {
                    // ignore null & empty string properties
                    if (prop == null) return false;
                    if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                    return true;
                }
            ));

        CreateMap<Pedido, PedidoResponce>();
        CreateMap<PedidoResponce, Models.Profile>()
            .ForMember(
                des => des.Nombre,
                opt => opt.MapFrom(src => src.Nombre)
            );



    }
}
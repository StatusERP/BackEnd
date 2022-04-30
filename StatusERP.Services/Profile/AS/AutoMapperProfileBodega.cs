using AutoMapper;
using StatusERP.Dto.Request.AS;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.Services.Profile.AS
{
    public class AutoMapperProfileBodega :AutoMapper.Profile
    {
        public AutoMapperProfileBodega()
        {
            CreateMap<Bodega, DtoUpdateBodega>()
                .ForMember(o => o.Nombre ,d=> d.MapFrom(x => x.Nombre))
                .ForMember(o => o.Telefono, d => d.MapFrom(y => y.Telefono))
                .ForMember(o => o.Activa, d => d.MapFrom(y => y.Activa))
                .ForMember(o => o.Tipo, d => d.MapFrom(y => y.Tipo))
                .ForMember(o => o.Direccion, d => d.MapFrom(y => y.Direccion));


        }
    }
}

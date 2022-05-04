using StatusERP.Dto.Request.CI;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.Services.Profile.CI
{
    public class MapperArtriculo:AutoMapper.Profile
    {
        public MapperArtriculo()
        {
            CreateMap<Articulo, DtoArticulo>()
               .ForMember(o => o.Activo, d => d.MapFrom(x => x.Activo))
               .ForMember(o => o.ArticuloDelProv, d => d.MapFrom(y => y.ArticuloDelProv))
               .ForMember(o => o.Bultos, d => d.MapFrom(y => y.Bultos))
               .ForMember(o => o.CalculaPercep , d => d.MapFrom(y => y.CalculaPercep))
               .ForMember(o => o.ClaseABC, d => d.MapFrom(y => y.ClaseABC))
               .ForMember(o => o.Clasificacion1Id, d => d.MapFrom(y => y.Clasificacion1Id))
               .ForMember(o => o.Clasificacion2Id, d => d.MapFrom(y => y.Clasificacion2Id))
               .ForMember(o => o.Clasificacion3Id, d => d.MapFrom(y => y.Clasificacion3Id))
               .ForMember(o => o.Clasificacion4Id, d => d.MapFrom(y => y.Clasificacion4Id))
               .ForMember(o => o.Clasificacion5Id, d => d.MapFrom(y => y.Clasificacion5Id))
               .ForMember(o => o.Clasificacion6Id, d => d.MapFrom(y => y.Clasificacion6Id))
               .ForMember(o => o.CodArticulo, d => d.MapFrom(y => y.CodArticulo))
               .ForMember(o => o.CodigoBarrasInvt, d => d.MapFrom(y => y.CodigoBarrasInvt))
               .ForMember(o => o.CodigoBarrasVent, d => d.MapFrom(y => y.CodigoBarrasVent))
               .ForMember(o => o.CodigoRetencion, d => d.MapFrom(y => y.CodigoRetencion))
               .ForMember(o => o.Color, d => d.MapFrom(y => y.Color))
               .ForMember(o => o.Color, d => d.MapFrom(y => y.Color))
               .ForMember(o => o.Color, d => d.MapFrom(y => y.Color))
               .ForMember(o => o.Color, d => d.MapFrom(y => y.Color))
               .ForMember(o => o.Color, d => d.MapFrom(y => y.Color))
               .ForMember(o => o.Color, d => d.MapFrom(y => y.Color))
               .ForMember(o => o.Color, d => d.MapFrom(y => y.Color))
               .ForMember(o => o.Color, d => d.MapFrom(y => y.Color))
               .ForMember(o => o.Color, d => d.MapFrom(y => y.Color))
               .ForMember(o => o.Color, d => d.MapFrom(y => y.Color))
               .ForMember(o => o.Color, d => d.MapFrom(y => y.Color))
               .ForMember(o => o.Color, d => d.MapFrom(y => y.Color))
               .ForMember(o => o.Color, d => d.MapFrom(y => y.Color))
               .ForMember(o => o.Color, d => d.MapFrom(y => y.Color))
               .ForMember(o => o.Color, d => d.MapFrom(y => y.Color))
               .ForMember(o => o.Color, d => d.MapFrom(y => y.Color))
               .ForMember(o => o.Color, d => d.MapFrom(y => y.Color))
               .ForMember(o => o.Color, d => d.MapFrom(y => y.Color))
               ;
        }
    }
}

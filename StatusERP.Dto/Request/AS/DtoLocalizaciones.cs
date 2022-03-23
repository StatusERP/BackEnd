namespace StatusERP.Dto.Request.AS;

public record DtoLocalizaciones(string CodLocalizacion,string Descripcion,decimal Volumen,decimal Pesomaximo,int bodegaId , bool activa);
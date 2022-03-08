namespace StatusERP.Dto.Request.AS;

public record DtoCondicionPago( string CodCondiconPago,string Descripcion,int DiasNeto,bool PagosParciales,decimal DescuentoContado,string TipoCondPago,int PlazoCondPago,bool Activa);
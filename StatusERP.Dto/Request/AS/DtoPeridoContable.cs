namespace StatusERP.Dto.Request.AS;

public record DtoPeridoContable(DateTime FechaFinal,string Contabilidad,string Descripcion, bool FinPeriodoAnual,bool Abierto);
namespace StatusERP.Dto.Request.AS;

public record DtoGlobalesAS(DateTime FechaAdvIni,DateTime FechaAdvFin,DateTime FechaTraIni,DateTime FechaTraFin,string NombreMoneda,string SimboloMoneda,string Imp1,string Imp2, string PaisLocal,string MonedaLocal, string MonedaDolar,string TipoCambioDolar,string PatronCeCo);
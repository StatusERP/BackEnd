﻿namespace StatusERP.Dto.Request.AS;

public record DtoGlobalesAS(DateTime FechaAdvIni,DateTime FechaAdvFin,DateTime FechaTraIni,DateTime FechaTraFin,string NombreMoneda,string SimboloMoneda,string Imp1,string Imp2, int PaisLocal,string MonedaLocal, string MonedaDolar,int TipoCambioDolar,string PatronCeCo);
namespace StatusERP.Dto.Request.ERPADMIN;

public record DtoAccion(int Accion ,string nombreAccion,string Descripicon,string NombreConstante,bool EsModulo,bool EsEstandar,string Tipo,string SubTipo,string Tabla,string Invocacion);
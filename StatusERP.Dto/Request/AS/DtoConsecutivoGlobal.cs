namespace StatusERP.Dto.Request.AS;

public record DtoConsecutivoGlobal(string CodConsecutivoGlobal,string Descripcion,bool activo,int Longitud,string Entidad,string Documento,string FormatoImpresionDetallado,string FormatoImpresionResumido,string Mascara,string ValorInicial,string ValorFinal,string UltimoValor,string UltimoUsuario,DateTime FechaHoraUlt);

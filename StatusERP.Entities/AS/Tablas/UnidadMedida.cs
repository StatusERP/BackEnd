﻿using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.AS.Tablas
{
    public class UnidadMedida:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
﻿using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.CG.Tablas
{
    public class Diferido:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
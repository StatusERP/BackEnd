﻿using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.Entities.AS.Tablas
{
    public class Bodega:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}
 
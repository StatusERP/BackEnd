﻿namespace StatusERP.Entities.ERPADMIN.Tablas
{
    public class Usuario:EntityBase
    {
        public int ConjuntoId { get; set; }
        public Conjunto Conjunto { get; set; }
    }
}

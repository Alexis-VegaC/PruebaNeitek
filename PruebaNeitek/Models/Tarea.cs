﻿namespace PruebaNeitek.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Completada { get; set; }
        public int MetaId { get; set; }
        public Meta Meta { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace Sabores_Backend.Models
{
    public partial class Sede
    {
        public Sede()
        {
            
        }

        public int IdSede { get; set; }
        public string? NombreSede { get; set; }
        public string? Direccion { get; set; }
        public int? Parqueaderos { get; set; }
        public bool? Activo { get; set; }

        
    }
}

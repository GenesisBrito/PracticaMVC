﻿using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class usuarios
    {
        [Key]

        [Display (Name = "ID")]
        public int usuario_id { get; set; }

        [Display(Name = "Nombre")]
        public string? nombre { get; set; }

        [Display(Name = "Documento")]
        public string? documento { get; set; }

        [Display(Name = "Tipo")]
        public string? tipo { get;set; }

        [Display(Name = "Carnet")]
        public string? carnet { get; set; }

        [Display(Name = "ID de la Carrera")]
        public int carrera_id{ get; set; }

        [Display(Name = "Estado")]
        public string? estado { get; set; }

    }
}

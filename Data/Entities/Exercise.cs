﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitHub.Data.Entities
{
    public class Exercise
    {
        [Key]
        public int ExID { get; set; }

        [StringLength(50)]
        public string ExName { get; set; }

        public int ExMgID { get; set; }

        [ForeignKey("ExMgID")]
        [Column("MgId")]
        public MuscleGroup MuscleGroup { get; set; }


    }
}

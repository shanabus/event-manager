﻿using Microsoft.EntityFrameworkCore;

namespace EvManagerDemo.Data
{
    [EntityTypeConfiguration(typeof(TreatmentConfiguration))]
    public class Treatment
    {
        public int TreatmentId { get; set; }

        public string? TypeOfTreatment { get; set; }

        public string? LengthOfStay { get; set; }

        public decimal Cost { get; set; }
    }
}
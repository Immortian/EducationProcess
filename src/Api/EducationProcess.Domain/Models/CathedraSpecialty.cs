﻿namespace EducationProcess.Domain.Models
{
    public class CathedraSpecialty
    {
        public int CathedraId { get; set; }
        public int FsesCategoryPatitionId { get; set; }

        public Cathedra Cathedra { get; set; }
        public FsesCategoryPartition FsesCategoryPatition { get; set; }
    }
}
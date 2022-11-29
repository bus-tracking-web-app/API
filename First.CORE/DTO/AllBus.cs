using System;
using System.Collections.Generic;
using System.Text;

namespace First.CORE.DTO
{
    public class AllBus
    {
        public decimal Id { get; set; }
        public decimal? Busnumber { get; set; }
        public decimal? Busdriver { get; set; }
        public decimal? Round { get; set; }
        public decimal? Teacher { get; set; }
        public string Driver { get; set; }
        public string Roundstatus { get; set; }
        public string TeacherName { get; set; }
    }
}

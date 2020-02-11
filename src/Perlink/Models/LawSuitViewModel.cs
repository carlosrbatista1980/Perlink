using Perlink.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Perlink.Models
{
    public class LawSuitViewModel
    {
        public string SuitNumber { get; set; }
        public DateTime SuitCreationTime { get; set; }
        public decimal CourtCosts { get; set; }
        public Lawoffice Lawoffice { get; set; }
        public int LawofficeId { get; set; }

        public string numeroDoProcesso { get; set; }
        public string dataDeCriacaoDoProcesso { get; set; }
        public string valor { get; set; }
        public string escritorio { get; set; }
    }
}

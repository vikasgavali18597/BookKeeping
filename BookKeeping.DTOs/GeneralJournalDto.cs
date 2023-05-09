using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BookKeeping.DTOs
{
    public class GeneralJournalDto
    {
        public string GlNO { get; set; }

        public DateTime Date { get; set; }

        public string Narration { get; set; }

        public DebitDto Debit { get; set; }

        public CreditDto Credit { get; set; }
    }
}

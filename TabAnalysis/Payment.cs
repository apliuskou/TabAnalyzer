using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabAnalysis
{
    public class Payment
    {
        //PUBLIC?
            public int Id { get; set; }
            public Banks Bank { get; set; }
            public decimal Money { get; set; }
            public DateTime Date { get; set; }

    }
}

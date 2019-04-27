using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Migration
{
    public class Visitor
    {
        public Guid Id { get; set; }
        public DateTime DateJoin { get; set; }
        public DateTime DateLeave { get; set; }
        public string Name { get; set; }
        public string DocumentNumber { get; set; }
        public string VisitPurpose { get; set; }

        public Visitor()
        {
            Id = Guid.NewGuid();
        }
    }
}

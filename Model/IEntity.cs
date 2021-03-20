using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace remittance.api.Model
{
    public interface IEntity
    {
        int Id { get; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}

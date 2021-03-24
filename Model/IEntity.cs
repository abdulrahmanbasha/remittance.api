using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace remittance.api.Model
{
    public interface IEntity
    {
        int id { get; }
        public string createdby { get; set; }
        public DateTime? createdon { get; set; }
    }
}

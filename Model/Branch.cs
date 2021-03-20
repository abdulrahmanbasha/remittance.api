using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace remittance.api.Model
{
    public class Branch : IEntity
    {

        [StringLength(maximumLength:4, MinimumLength =4)]
        public string BranchCode { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string ParentBranch { get; set; }
        public string ReferenceBranch { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string BaseCountry { get; set; }
        public string Domain { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public bool BranchStatus { get; set; }
        public bool Payee { get; set; }
        public bool CanReceiveFromMMT { get; set; }
        public bool CanReceiveTMTFromPartner { get; set; }
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }



        // Commission

        public decimal? TmtCommForSending { get; set; }
        public bool? TmtCommForSendingStatus { get; set; }

        public decimal? MmtCommForSending { get; set; }

        public bool? MmtCommForSendingStatus { get; set; }


        public decimal? CommForPayingBranch { get; set; }

        public bool? CommForPayingBranchStatus { get; set; }




    }
}

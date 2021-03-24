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
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string parentBranch { get; set; }
        public string referenceBranch { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string baseCountry { get; set; }
        public string domain { get; set; }
        public string telephone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public bool isActive { get; set; }
        public bool isPayee { get; set; }
        
        public bool canReceiveFromMMT { get; set; }
        public bool canReceiveTMTFromPartner { get; set; }
     



        // commission

        public decimal? tmtCommForSending { get; set; }
        public bool? tmtCommForSendingStatus { get; set; }

        public decimal? mmtCommForSending { get; set; }

        public bool? mmtCommForSendingStatus { get; set; }


        public decimal? commForPayingBranch { get; set; }

        public bool? commForPayingBranchStatus { get; set; }


        public int?  maxAmountApproval { get; set; }
        public bool?  maxAmountApprovalRequired { get; set; }
        public bool?  maxAmountParentApprovalRequired { get; set; }
        public bool?  maxAmountCpoApprovalRequired { get; set; }
        public bool?  maxAmountApprovalIsActive { get; set; }


        public bool?  minCommApproval { get; set; }
        public bool?  minCommApprovalRequired { get; set; }
        public bool?  minCommParentApprovalRequired { get; set; }
        public bool?  minCommCpoApprovalRequired { get; set; }
        public bool?  minCommApprovalIsActive { get; set; }
         
        public bool?  maxCommApproval { get; set; }
        public bool?  maxCommApprovalRequired { get; set; }
        public bool?  maxCommParentApprovalRequired { get; set; }
        public bool?  maxCommCpoApprovalRequired { get; set; }
        public bool?  maxCommApprovalIsActive { get; set; }
        
        public bool?  commDiscountApprovalRequired { get; set; }
        public bool?  commDiscountParentApprovalRequired { get; set; }
        public bool?  commDiscountCpoApprovalRequired { get; set; }
        public bool? commDiscountApprovalIsActive { get; set; }

        public int limit { get; set; }

        public int id { get; set; }
        public string createdby { get; set; }
        public DateTime? createdon { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reward_Backoffice.Models
{
    public class Client
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("Client ID")]
        
        public int client_id { get; set; } = 0;
        //[Required]
        [DisplayName("Client Code")]
        public string client_code { get; set; } = "";
        [DisplayName("Client Type")]
        public string client_type { get; set; } = "";

        [DisplayName("Balance Reward Points")]
        public decimal balance_reward_points { get; set; }

        [DisplayName("Salutation")]
        public string salutation { get; set; } = "";
        // [Required]
        [DisplayName("Client Name")]
        public string client_name { get; set; } = "";
        [DisplayName("Gender")]
        public char gender { get; set; }

        [DisplayName("Race")]
        public char race { get; set; }
        [DisplayName("Identification Number")]
        public string IC { get; set; } = "";

        [DisplayName("Passport")]
        public string passport { get; set; } = "";

        [DisplayName("Email")]       
        public string email { get; set; } = "";
        [DisplayName("Religion")]
        public string religion { get; set; } = "";
        [DisplayName("Nationality")]
        public string nationality { get; set; } = "";
        [DisplayName("Country")]
        public string country { get; set; } = "";
        [DisplayName("Permanent Resident")]
        public bool PermRes { get; set; } = false;
        [DisplayName("Bumiputera")]
        public bool bumi { get; set; } = false;
        [DisplayName("Telephone")]
        public string telephone { get; set; } = "";
        [DisplayName("Fax")]
        public string fax { get; set; } = "";

        [DataType(DataType.Date)]
        [DisplayName("Birthday")]
        public DateTime birthday { get; set; }
        [DisplayName("Client Tier Id")]
        public int client_tier_id { get; set; }
        [DisplayName("Remarks")]
        public string remarks { get; set; } = "";
        [DisplayName("Register Date")]
        public DateTime date_added { get; set; } 
        public DateTime date_modified { get; set; }
        public int created_by { get; set; }
        public int modified_by { get; set; }
        [DisplayName("Status")]
        public bool status { get; set; } = false;
        [DisplayName("Branch Id")]
        public string branch_id { get; set; } = "";
        [DisplayName("Trading Type")]
        public string trading_type { get; set; } = "";
        public string UserIDHash { get; set; } = "";

        //public IEnumerable<Branch> name { set; get; }

    }
}

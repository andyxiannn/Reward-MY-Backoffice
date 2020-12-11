using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reward_Backoffice.Models
{
    public class Branch
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        
        public int branch_table_id { get; set; } = 0;
        //[Required]
        [DisplayName("Branch id")]
        public string branch_id { get; set; } = "";
        [DisplayName("Branch Name")]
        public string name { get; set; } = "";
        [DisplayName("Country")]
        public string country { get; set; } = "";
        [DisplayName("Status")]
        public bool status { get; set; } = false;
        public DateTime date_added { get; set; } 
        public DateTime date_modified { get; set; }
        public int added_by { get; set; }
        public int modified_by { get; set; }
        
        



    }
}

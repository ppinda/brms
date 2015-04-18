using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BRMS.Model.Enums;
using Newtonsoft.Json;

namespace BRMS.Model.Entities
{
    public class Payment
    {
        public decimal Total { get; set; }
        public PaymentType Type { get; set; }

        [Key, ForeignKey("Service")]
        public int ServiceId { get; set; }
        [JsonIgnore]
        public virtual Service Service { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.Models
{
    public class NocurrentAsetsMaterial
    {
        [Key]
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int NocurrentAsetsId { get; set; }
        public int NomenclatureId { get; set; }
        public int ReceiptId { get; set; }
        public decimal Quantity { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Percentage { get; set; }
        public int Status { get; set; }
    }
}

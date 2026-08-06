using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class NocurrentAsetsMaterialDTO
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int NocurrentAsetsId { get; set; }
        public int NomenclatureId { get; set; }
        public string NomenclatureName { get; set; }
        public string Nomenclature { get; set; }
        public int ReceiptId { get; set; }
        public string ReceiptNum { get; set; }
        public decimal Quantity { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int?  Percentage { get; set; }
        public int Status { get; set; }
    }
}

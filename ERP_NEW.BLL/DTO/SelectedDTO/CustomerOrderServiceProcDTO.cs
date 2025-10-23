using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.SelectedDTO
{
    public class CustomerOrderServiceProcDTO
    {
        public int Id { get; set; }
        public string CustomerOrderNumber { get; set; }
        public string ContractorName { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? CustomerOrderId { get; set; }
        public int OrderId { get; set; }
        public string Note { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string ReceiptNum { get; set; }
        public decimal? TotalPrice { get; set; }
    }
}

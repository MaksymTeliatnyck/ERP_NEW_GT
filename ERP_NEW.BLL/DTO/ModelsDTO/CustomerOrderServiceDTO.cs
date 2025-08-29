using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.BLL.DTO.ModelsDTO
{
    public class CustomerOrderServiceDTO
    {
        public int Id { get; set; }
        public int? CustomerOrderId { get; set; }
        public int? OrderId { get; set; }
        public DateTime? DateAdded { get; set; }
        public string Note { get; set; }
    }
}

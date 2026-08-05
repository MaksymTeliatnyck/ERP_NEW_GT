using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_NEW.DAL.Entities.QueryModels
{
    public class NocurrentAssetsMaterialJournal
    {
        [Key]
        public int ReceiptId { get; set; }
        public string NomenclatureName { get; set; }
        public string Nomenclature { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ReceiptNum { get; set; }
        public decimal? RemainsQuantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public string DebitNum { get; set; }
        public string Correction { get; set; }
        public int NomenclatureId { get; set; }
    }
}

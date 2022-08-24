using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransaction.App.Models
{
    public class Transactions
    {
        [Key]
        public int TransactionId { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        public string AccountNumber { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficiary Name")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        public string BankName { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Swift Code")]
        public string SwiftCode { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
    }
}

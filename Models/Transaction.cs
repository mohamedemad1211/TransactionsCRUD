using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.Models
{
    public class Transaction
    {
        [Key]
        public int TranId { get; set; }
        [Column(TypeName ="nvarchar(12)")]
        [DisplayName("Account Name")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only.")]
        [Required]
        public string AccountNun { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficiary Name")]
        [Required]

        public string BenName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required]

        public string BankName { get; set; }
        public int Amount { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required]
        [MaxLength(11, ErrorMessage = "Maximum 11 characters only.")]

        public string SwCode { get; set; }
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime Date { get; set; }
    }
}
 
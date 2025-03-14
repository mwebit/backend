using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datacom.Models
{
    public class JobTrackingInfo
    {
        [Key]
        public int Id { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        public string CompanyName { get; set; } = string.Empty;
        
        [Column(TypeName = "nvarchar(100)")]
        public string Position { get; set; } = string.Empty;
        
        [Column(TypeName = "nvarchar(20)")]
        public string Status { get; set; } = string.Empty;

        [Column(TypeName = "date")]
        public DateTime DateApplied { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace Wipro_API_DFA_27_08_2024.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }

        public int? CustomerId { get; set; }

        public string OrderedProducts { get; set; } = null!;

        public DateTime OrderDate { get; set; }

        public int TotalAmount { get; set; }

        [JsonIgnore] // Add this attribute
        public virtual Customer? Customer { get; set; }
    }
}

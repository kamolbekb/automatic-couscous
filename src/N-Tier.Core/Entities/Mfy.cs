using System.Text.Json.Serialization;
using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class Mfy : BaseEntity,IAuditedEntity
{
    public string Title { get; set; }
    public Guid CityId { get; set; }
    public City City { get; set; }
    [JsonIgnore]
    public ICollection<Address> Addresses { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime? UpdatedOn { get; set; }
}
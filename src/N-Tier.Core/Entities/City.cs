using System.Text.Json.Serialization;
using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class City: BaseEntity,IAuditedEntity
{
    public string Title { get; set; }
    public Guid RegionId { get; set; }
    public Region Region { get; set; }
    [JsonIgnore]
    public ICollection<Mfy> Mfies  { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime? UpdatedOn { get; set; }
}
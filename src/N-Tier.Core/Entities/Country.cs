using System.Text.Json.Serialization;
using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class Country : BaseEntity,IAuditedEntity
{
    public string Title { get; set; }
    [JsonIgnore]
    public ICollection<Region> Regions { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime? UpdatedOn { get; set; }
}
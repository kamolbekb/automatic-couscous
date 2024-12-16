using System.Text.Json.Serialization;
using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class Region : BaseEntity,IAuditedEntity
{
    public string Title { get; set; }
    public Guid CountryId { get; set; }
    public Country Country { get; set; }
    [JsonIgnore]
    public ICollection<City> Cities { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime? UpdatedOn { get; set; }
}
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// CrossVersionObjectReference contains enough information to let you
    /// identify the referred resource.
    /// </summary>
    public partial class V1CrossVersionObjectReference
    {
        /// <summary>
        /// Initializes a new instance of the V1CrossVersionObjectReference
        /// class.
        /// </summary>
        public V1CrossVersionObjectReference()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1CrossVersionObjectReference
        /// class.
        /// </summary>
        /// <param name="kind">Kind of the referent; More info:
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds"</param>
        /// <param name="name">Name of the referent; More info:
        /// http://kubernetes.io/docs/user-guide/identifiers#names</param>
        /// <param name="apiVersion">API version of the referent</param>
        public V1CrossVersionObjectReference(string kind, string name, string apiVersion = default(string))
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets API version of the referent
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets kind of the referent; More info:
        /// http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds"
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets name of the referent; More info:
        /// http://kubernetes.io/docs/user-guide/identifiers#names
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Kind == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Kind");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}

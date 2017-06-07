// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Affinity is a group of affinity scheduling rules.
    /// </summary>
    public partial class V1Affinity
    {
        /// <summary>
        /// Initializes a new instance of the V1Affinity class.
        /// </summary>
        public V1Affinity()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1Affinity class.
        /// </summary>
        /// <param name="nodeAffinity">Describes node affinity scheduling rules
        /// for the pod.</param>
        /// <param name="podAffinity">Describes pod affinity scheduling rules
        /// (e.g. co-locate this pod in the same node, zone, etc. as some other
        /// pod(s)).</param>
        /// <param name="podAntiAffinity">Describes pod anti-affinity
        /// scheduling rules (e.g. avoid putting this pod in the same node,
        /// zone, etc. as some other pod(s)).</param>
        public V1Affinity(V1NodeAffinity nodeAffinity = default(V1NodeAffinity), V1PodAffinity podAffinity = default(V1PodAffinity), V1PodAntiAffinity podAntiAffinity = default(V1PodAntiAffinity))
        {
            NodeAffinity = nodeAffinity;
            PodAffinity = podAffinity;
            PodAntiAffinity = podAntiAffinity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets describes node affinity scheduling rules for the pod.
        /// </summary>
        [JsonProperty(PropertyName = "nodeAffinity")]
        public V1NodeAffinity NodeAffinity { get; set; }

        /// <summary>
        /// Gets or sets describes pod affinity scheduling rules (e.g.
        /// co-locate this pod in the same node, zone, etc. as some other
        /// pod(s)).
        /// </summary>
        [JsonProperty(PropertyName = "podAffinity")]
        public V1PodAffinity PodAffinity { get; set; }

        /// <summary>
        /// Gets or sets describes pod anti-affinity scheduling rules (e.g.
        /// avoid putting this pod in the same node, zone, etc. as some other
        /// pod(s)).
        /// </summary>
        [JsonProperty(PropertyName = "podAntiAffinity")]
        public V1PodAntiAffinity PodAntiAffinity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NodeAffinity != null)
            {
                NodeAffinity.Validate();
            }
        }
    }
}

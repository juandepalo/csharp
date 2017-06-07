// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The node this Taint is attached to has the effect "effect" on any pod
    /// that that does not tolerate the Taint.
    /// </summary>
    public partial class V1Taint
    {
        /// <summary>
        /// Initializes a new instance of the V1Taint class.
        /// </summary>
        public V1Taint()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1Taint class.
        /// </summary>
        /// <param name="effect">Required. The effect of the taint on pods that
        /// do not tolerate the taint. Valid effects are NoSchedule,
        /// PreferNoSchedule and NoExecute.</param>
        /// <param name="key">Required. The taint key to be applied to a
        /// node.</param>
        /// <param name="timeAdded">TimeAdded represents the time at which the
        /// taint was added. It is only written for NoExecute taints.</param>
        /// <param name="value">Required. The taint value corresponding to the
        /// taint key.</param>
        public V1Taint(string effect, string key, System.DateTime? timeAdded = default(System.DateTime?), string value = default(string))
        {
            Effect = effect;
            Key = key;
            TimeAdded = timeAdded;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets required. The effect of the taint on pods that do not
        /// tolerate the taint. Valid effects are NoSchedule, PreferNoSchedule
        /// and NoExecute.
        /// </summary>
        [JsonProperty(PropertyName = "effect")]
        public string Effect { get; set; }

        /// <summary>
        /// Gets or sets required. The taint key to be applied to a node.
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets timeAdded represents the time at which the taint was
        /// added. It is only written for NoExecute taints.
        /// </summary>
        [JsonProperty(PropertyName = "timeAdded")]
        public System.DateTime? TimeAdded { get; set; }

        /// <summary>
        /// Gets or sets required. The taint value corresponding to the taint
        /// key.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Effect == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Effect");
            }
            if (Key == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Key");
            }
        }
    }
}

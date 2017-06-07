// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Pod affinity is a group of inter pod affinity scheduling rules.
    /// </summary>
    public partial class V1PodAffinity
    {
        /// <summary>
        /// Initializes a new instance of the V1PodAffinity class.
        /// </summary>
        public V1PodAffinity()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1PodAffinity class.
        /// </summary>
        /// <param name="preferredDuringSchedulingIgnoredDuringExecution">The
        /// scheduler will prefer to schedule pods to nodes that satisfy the
        /// affinity expressions specified by this field, but it may choose a
        /// node that violates one or more of the expressions. The node that is
        /// most preferred is the one with the greatest sum of weights, i.e.
        /// for each node that meets all of the scheduling requirements
        /// (resource request, requiredDuringScheduling affinity expressions,
        /// etc.), compute a sum by iterating through the elements of this
        /// field and adding "weight" to the sum if the node has pods which
        /// matches the corresponding podAffinityTerm; the node(s) with the
        /// highest sum are the most preferred.</param>
        /// <param name="requiredDuringSchedulingIgnoredDuringExecution">NOT
        /// YET IMPLEMENTED. TODO: Uncomment field once it is implemented. If
        /// the affinity requirements specified by this field are not met at
        /// scheduling time, the pod will not be scheduled onto the node. If
        /// the affinity requirements specified by this field cease to be met
        /// at some point during pod execution (e.g. due to a pod label
        /// update), the system will try to eventually evict the pod from its
        /// node. When there are multiple elements, the lists of nodes
        /// corresponding to each podAffinityTerm are intersected, i.e. all
        /// terms must be satisfied.
        /// RequiredDuringSchedulingRequiredDuringExecution []PodAffinityTerm
        /// `json:"requiredDuringSchedulingRequiredDuringExecution,omitempty"`
        /// If the affinity requirements specified by this field are not met at
        /// scheduling time, the pod will not be scheduled onto the node. If
        /// the affinity requirements specified by this field cease to be met
        /// at some point during pod execution (e.g. due to a pod label
        /// update), the system may or may not try to eventually evict the pod
        /// from its node. When there are multiple elements, the lists of nodes
        /// corresponding to each podAffinityTerm are intersected, i.e. all
        /// terms must be satisfied.</param>
        public V1PodAffinity(IList<V1WeightedPodAffinityTerm> preferredDuringSchedulingIgnoredDuringExecution = default(IList<V1WeightedPodAffinityTerm>), IList<V1PodAffinityTerm> requiredDuringSchedulingIgnoredDuringExecution = default(IList<V1PodAffinityTerm>))
        {
            PreferredDuringSchedulingIgnoredDuringExecution = preferredDuringSchedulingIgnoredDuringExecution;
            RequiredDuringSchedulingIgnoredDuringExecution = requiredDuringSchedulingIgnoredDuringExecution;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the scheduler will prefer to schedule pods to nodes
        /// that satisfy the affinity expressions specified by this field, but
        /// it may choose a node that violates one or more of the expressions.
        /// The node that is most preferred is the one with the greatest sum of
        /// weights, i.e. for each node that meets all of the scheduling
        /// requirements (resource request, requiredDuringScheduling affinity
        /// expressions, etc.), compute a sum by iterating through the elements
        /// of this field and adding "weight" to the sum if the node has pods
        /// which matches the corresponding podAffinityTerm; the node(s) with
        /// the highest sum are the most preferred.
        /// </summary>
        [JsonProperty(PropertyName = "preferredDuringSchedulingIgnoredDuringExecution")]
        public IList<V1WeightedPodAffinityTerm> PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

        /// <summary>
        /// Gets or sets NOT YET IMPLEMENTED. TODO: Uncomment field once it is
        /// implemented. If the affinity requirements specified by this field
        /// are not met at scheduling time, the pod will not be scheduled onto
        /// the node. If the affinity requirements specified by this field
        /// cease to be met at some point during pod execution (e.g. due to a
        /// pod label update), the system will try to eventually evict the pod
        /// from its node. When there are multiple elements, the lists of nodes
        /// corresponding to each podAffinityTerm are intersected, i.e. all
        /// terms must be satisfied.
        /// RequiredDuringSchedulingRequiredDuringExecution []PodAffinityTerm
        /// `json:"requiredDuringSchedulingRequiredDuringExecution,omitempty"`
        /// If the affinity requirements specified by this field are not met at
        /// scheduling time, the pod will not be scheduled onto the node. If
        /// the affinity requirements specified by this field cease to be met
        /// at some point during pod execution (e.g. due to a pod label
        /// update), the system may or may not try to eventually evict the pod
        /// from its node. When there are multiple elements, the lists of nodes
        /// corresponding to each podAffinityTerm are intersected, i.e. all
        /// terms must be satisfied.
        /// </summary>
        [JsonProperty(PropertyName = "requiredDuringSchedulingIgnoredDuringExecution")]
        public IList<V1PodAffinityTerm> RequiredDuringSchedulingIgnoredDuringExecution { get; set; }

    }
}

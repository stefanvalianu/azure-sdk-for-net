// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using System.Linq;

    /// <summary>
    /// Describes a storage account connection.
    /// </summary>
    public partial class StorageAccount
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccount class.
        /// </summary>
        public StorageAccount() { }

        /// <summary>
        /// Initializes a new instance of the StorageAccount class.
        /// </summary>
        /// <param name="id">The Azure Resource Manager ID of the storage
        /// account resource.</param>
        /// <param name="key">The storage account key.</param>
        public StorageAccount(string id, string key)
        {
            Id = id;
            Key = key;
        }

        /// <summary>
        /// Gets or sets the Azure Resource Manager ID of the storage account
        /// resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the storage account key.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Id");
            }
            if (Key == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Key");
            }
        }
    }
}

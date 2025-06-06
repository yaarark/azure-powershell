// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.HybridCompute.Models
{
    using System.Linq;

    /// <summary>
    /// Metadata pertaining to the geographic location of the resource.
    /// </summary>
    public partial class LocationData
    {
        /// <summary>
        /// Initializes a new instance of the LocationData class.
        /// </summary>
        public LocationData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LocationData class.
        /// </summary>

        /// <param name="name">A canonical name for the geographic or physical location.
        /// </param>

        /// <param name="city">The city or locality where the resource is located.
        /// </param>

        /// <param name="district">The district, state, or province where the resource is located.
        /// </param>

        /// <param name="countryOrRegion">The country or region where the resource is located
        /// </param>
        public LocationData(string name, string city = default(string), string district = default(string), string countryOrRegion = default(string))

        {
            this.Name = name;
            this.City = city;
            this.District = district;
            this.CountryOrRegion = countryOrRegion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets a canonical name for the geographic or physical location.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets or sets the city or locality where the resource is located.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "city")]
        public string City {get; set; }

        /// <summary>
        /// Gets or sets the district, state, or province where the resource is
        /// located.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "district")]
        public string District {get; set; }

        /// <summary>
        /// Gets or sets the country or region where the resource is located
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "countryOrRegion")]
        public string CountryOrRegion {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
            if (this.Name != null)
            {
                if (this.Name.Length > 256)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.MaxLength, "Name", 256);
                }
            }



        }
    }
}
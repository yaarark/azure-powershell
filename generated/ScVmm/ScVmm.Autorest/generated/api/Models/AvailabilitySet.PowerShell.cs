// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.PowerShell;

    /// <summary>The AvailabilitySets resource definition.</summary>
    [System.ComponentModel.TypeConverter(typeof(AvailabilitySetTypeConverter))]
    public partial class AvailabilitySet
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.AvailabilitySet"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AvailabilitySet(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.AvailabilitySetPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtendedLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).ExtendedLocation = (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IExtendedLocation) content.GetValueForProperty("ExtendedLocation",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).ExtendedLocation, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ExtendedLocationTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedLocationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).ExtendedLocationType = (string) content.GetValueForProperty("ExtendedLocationType",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).ExtendedLocationType, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedLocationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).ExtendedLocationName = (string) content.GetValueForProperty("ExtendedLocationName",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).ExtendedLocationName, global::System.Convert.ToString);
            }
            if (content.Contains("AvailabilitySetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).AvailabilitySetName = (string) content.GetValueForProperty("AvailabilitySetName",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).AvailabilitySetName, global::System.Convert.ToString);
            }
            if (content.Contains("VmmServerId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).VmmServerId = (string) content.GetValueForProperty("VmmServerId",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).VmmServerId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.AvailabilitySet"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AvailabilitySet(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.AvailabilitySetPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ExtendedLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).ExtendedLocation = (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IExtendedLocation) content.GetValueForProperty("ExtendedLocation",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).ExtendedLocation, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ExtendedLocationTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ITrackedResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ITrackedResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ITrackedResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.TrackedResourceTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ITrackedResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.ITrackedResourceInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedLocationType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).ExtendedLocationType = (string) content.GetValueForProperty("ExtendedLocationType",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).ExtendedLocationType, global::System.Convert.ToString);
            }
            if (content.Contains("ExtendedLocationName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).ExtendedLocationName = (string) content.GetValueForProperty("ExtendedLocationName",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).ExtendedLocationName, global::System.Convert.ToString);
            }
            if (content.Contains("AvailabilitySetName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).AvailabilitySetName = (string) content.GetValueForProperty("AvailabilitySetName",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).AvailabilitySetName, global::System.Convert.ToString);
            }
            if (content.Contains("VmmServerId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).VmmServerId = (string) content.GetValueForProperty("VmmServerId",((Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySetInternal)this).VmmServerId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.AvailabilitySet"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySet" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySet DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AvailabilitySet(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.AvailabilitySet"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySet" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySet DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AvailabilitySet(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AvailabilitySet" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AvailabilitySet" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAvailabilitySet FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// The AvailabilitySets resource definition.
    [System.ComponentModel.TypeConverter(typeof(AvailabilitySetTypeConverter))]
    public partial interface IAvailabilitySet

    {

    }
}
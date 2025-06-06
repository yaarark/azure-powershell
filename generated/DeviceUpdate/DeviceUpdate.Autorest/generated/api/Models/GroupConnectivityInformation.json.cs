// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Extensions;

    /// <summary>Group connectivity details.</summary>
    public partial class GroupConnectivityInformation
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IGroupConnectivityInformation.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IGroupConnectivityInformation.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Models.IGroupConnectivityInformation FromJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonObject json ? new GroupConnectivityInformation(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonObject into a new instance of <see cref="GroupConnectivityInformation" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal GroupConnectivityInformation(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_groupId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonString>("groupId"), out var __jsonGroupId) ? (string)__jsonGroupId : (string)_groupId;}
            {_memberName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonString>("memberName"), out var __jsonMemberName) ? (string)__jsonMemberName : (string)_memberName;}
            {_customerVisibleFqdn = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonArray>("customerVisibleFqdns"), out var __jsonCustomerVisibleFqdns) ? If( __jsonCustomerVisibleFqdns as Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : _customerVisibleFqdn;}
            {_internalFqdn = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonString>("internalFqdn"), out var __jsonInternalFqdn) ? (string)__jsonInternalFqdn : (string)_internalFqdn;}
            {_redirectMapId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonString>("redirectMapId"), out var __jsonRedirectMapId) ? (string)__jsonRedirectMapId : (string)_redirectMapId;}
            {_privateLinkServiceArmRegion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonString>("privateLinkServiceArmRegion"), out var __jsonPrivateLinkServiceArmRegion) ? (string)__jsonPrivateLinkServiceArmRegion : (string)_privateLinkServiceArmRegion;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="GroupConnectivityInformation" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="GroupConnectivityInformation" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._groupId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonString(this._groupId.ToString()) : null, "groupId" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._memberName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonString(this._memberName.ToString()) : null, "memberName" ,container.Add );
            }
            if (null != this._customerVisibleFqdn)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.XNodeArray();
                foreach( var __x in this._customerVisibleFqdn )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("customerVisibleFqdns",__w);
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._internalFqdn)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonString(this._internalFqdn.ToString()) : null, "internalFqdn" ,container.Add );
            }
            AddIf( null != (((object)this._redirectMapId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonString(this._redirectMapId.ToString()) : null, "redirectMapId" ,container.Add );
            AddIf( null != (((object)this._privateLinkServiceArmRegion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.DeviceUpdate.Runtime.Json.JsonString(this._privateLinkServiceArmRegion.ToString()) : null, "privateLinkServiceArmRegion" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Extensions;

    /// <summary>Domain Security Settings</summary>
    public partial class DomainSecuritySettings
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonObject into a new instance of <see cref="DomainSecuritySettings" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal DomainSecuritySettings(Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_ntlmV1 = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonString>("ntlmV1"), out var __jsonNtlmV1) ? (string)__jsonNtlmV1 : (string)_ntlmV1;}
            {_tlsV1 = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonString>("tlsV1"), out var __jsonTlsV1) ? (string)__jsonTlsV1 : (string)_tlsV1;}
            {_syncNtlmPassword = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonString>("syncNtlmPasswords"), out var __jsonSyncNtlmPasswords) ? (string)__jsonSyncNtlmPasswords : (string)_syncNtlmPassword;}
            {_syncKerberosPassword = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonString>("syncKerberosPasswords"), out var __jsonSyncKerberosPasswords) ? (string)__jsonSyncKerberosPasswords : (string)_syncKerberosPassword;}
            {_syncOnPremPassword = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonString>("syncOnPremPasswords"), out var __jsonSyncOnPremPasswords) ? (string)__jsonSyncOnPremPasswords : (string)_syncOnPremPassword;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Models.IDomainSecuritySettings.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Models.IDomainSecuritySettings.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Models.IDomainSecuritySettings FromJson(Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonObject json ? new DomainSecuritySettings(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="DomainSecuritySettings" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="DomainSecuritySettings" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._ntlmV1)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonString(this._ntlmV1.ToString()) : null, "ntlmV1" ,container.Add );
            AddIf( null != (((object)this._tlsV1)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonString(this._tlsV1.ToString()) : null, "tlsV1" ,container.Add );
            AddIf( null != (((object)this._syncNtlmPassword)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonString(this._syncNtlmPassword.ToString()) : null, "syncNtlmPasswords" ,container.Add );
            AddIf( null != (((object)this._syncKerberosPassword)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonString(this._syncKerberosPassword.ToString()) : null, "syncKerberosPasswords" ,container.Add );
            AddIf( null != (((object)this._syncOnPremPassword)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ADDomainServices.Runtime.Json.JsonString(this._syncOnPremPassword.ToString()) : null, "syncOnPremPasswords" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}
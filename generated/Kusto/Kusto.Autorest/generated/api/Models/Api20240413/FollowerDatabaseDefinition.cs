// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Extensions;

    /// <summary>A class representing follower database request.</summary>
    public partial class FollowerDatabaseDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IFollowerDatabaseDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IFollowerDatabaseDefinitionInternal
    {

        /// <summary>Backing field for <see cref="AttachedDatabaseConfigurationName" /> property.</summary>
        private string _attachedDatabaseConfigurationName;

        /// <summary>Resource name of the attached database configuration in the follower cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string AttachedDatabaseConfigurationName { get => this._attachedDatabaseConfigurationName; set => this._attachedDatabaseConfigurationName = value; }

        /// <summary>Backing field for <see cref="ClusterResourceId" /> property.</summary>
        private string _clusterResourceId;

        /// <summary>Resource id of the cluster that follows a database owned by this cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string ClusterResourceId { get => this._clusterResourceId; set => this._clusterResourceId = value; }

        /// <summary>Backing field for <see cref="DatabaseName" /> property.</summary>
        private string _databaseName;

        /// <summary>
        /// The database name owned by this cluster that was followed. * in case following all databases.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string DatabaseName { get => this._databaseName; }

        /// <summary>Backing field for <see cref="DatabaseShareOrigin" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseShareOrigin? _databaseShareOrigin;

        /// <summary>The origin of the following setup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseShareOrigin? DatabaseShareOrigin { get => this._databaseShareOrigin; }

        /// <summary>Internal Acessors for DatabaseName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IFollowerDatabaseDefinitionInternal.DatabaseName { get => this._databaseName; set { {_databaseName = value;} } }

        /// <summary>Internal Acessors for DatabaseShareOrigin</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseShareOrigin? Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IFollowerDatabaseDefinitionInternal.DatabaseShareOrigin { get => this._databaseShareOrigin; set { {_databaseShareOrigin = value;} } }

        /// <summary>Internal Acessors for TableLevelSharingProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ITableLevelSharingProperties Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IFollowerDatabaseDefinitionInternal.TableLevelSharingProperty { get => (this._tableLevelSharingProperty = this._tableLevelSharingProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.TableLevelSharingProperties()); set { {_tableLevelSharingProperty = value;} } }

        /// <summary>Backing field for <see cref="TableLevelSharingProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ITableLevelSharingProperties _tableLevelSharingProperty;

        /// <summary>Table level sharing specifications</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ITableLevelSharingProperties TableLevelSharingProperty { get => (this._tableLevelSharingProperty = this._tableLevelSharingProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.TableLevelSharingProperties()); }

        /// <summary>List of external tables to exclude from the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string[] TableLevelSharingPropertyExternalTablesToExclude { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ITableLevelSharingPropertiesInternal)TableLevelSharingProperty).ExternalTablesToExclude; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ITableLevelSharingPropertiesInternal)TableLevelSharingProperty).ExternalTablesToExclude = value ?? null /* arrayOf */; }

        /// <summary>List of external tables to include in the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string[] TableLevelSharingPropertyExternalTablesToInclude { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ITableLevelSharingPropertiesInternal)TableLevelSharingProperty).ExternalTablesToInclude; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ITableLevelSharingPropertiesInternal)TableLevelSharingProperty).ExternalTablesToInclude = value ?? null /* arrayOf */; }

        /// <summary>List of functions to exclude from the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string[] TableLevelSharingPropertyFunctionsToExclude { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ITableLevelSharingPropertiesInternal)TableLevelSharingProperty).FunctionsToExclude; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ITableLevelSharingPropertiesInternal)TableLevelSharingProperty).FunctionsToExclude = value ?? null /* arrayOf */; }

        /// <summary>List of functions to include in the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string[] TableLevelSharingPropertyFunctionsToInclude { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ITableLevelSharingPropertiesInternal)TableLevelSharingProperty).FunctionsToInclude; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ITableLevelSharingPropertiesInternal)TableLevelSharingProperty).FunctionsToInclude = value ?? null /* arrayOf */; }

        /// <summary>List of materialized views to exclude from the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string[] TableLevelSharingPropertyMaterializedViewsToExclude { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ITableLevelSharingPropertiesInternal)TableLevelSharingProperty).MaterializedViewsToExclude; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ITableLevelSharingPropertiesInternal)TableLevelSharingProperty).MaterializedViewsToExclude = value ?? null /* arrayOf */; }

        /// <summary>List of materialized views to include in the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string[] TableLevelSharingPropertyMaterializedViewsToInclude { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ITableLevelSharingPropertiesInternal)TableLevelSharingProperty).MaterializedViewsToInclude; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ITableLevelSharingPropertiesInternal)TableLevelSharingProperty).MaterializedViewsToInclude = value ?? null /* arrayOf */; }

        /// <summary>List of tables to exclude from the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string[] TableLevelSharingPropertyTablesToExclude { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ITableLevelSharingPropertiesInternal)TableLevelSharingProperty).TablesToExclude; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ITableLevelSharingPropertiesInternal)TableLevelSharingProperty).TablesToExclude = value ?? null /* arrayOf */; }

        /// <summary>List of tables to include in the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Inlined)]
        public string[] TableLevelSharingPropertyTablesToInclude { get => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ITableLevelSharingPropertiesInternal)TableLevelSharingProperty).TablesToInclude; set => ((Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ITableLevelSharingPropertiesInternal)TableLevelSharingProperty).TablesToInclude = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="FollowerDatabaseDefinition" /> instance.</summary>
        public FollowerDatabaseDefinition()
        {

        }
    }
    /// A class representing follower database request.
    public partial interface IFollowerDatabaseDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.IJsonSerializable
    {
        /// <summary>Resource name of the attached database configuration in the follower cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Resource name of the attached database configuration in the follower cluster.",
        SerializedName = @"attachedDatabaseConfigurationName",
        PossibleTypes = new [] { typeof(string) })]
        string AttachedDatabaseConfigurationName { get; set; }
        /// <summary>Resource id of the cluster that follows a database owned by this cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Resource id of the cluster that follows a database owned by this cluster.",
        SerializedName = @"clusterResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterResourceId { get; set; }
        /// <summary>
        /// The database name owned by this cluster that was followed. * in case following all databases.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The database name owned by this cluster that was followed. * in case following all databases.",
        SerializedName = @"databaseName",
        PossibleTypes = new [] { typeof(string) })]
        string DatabaseName { get;  }
        /// <summary>The origin of the following setup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The origin of the following setup.",
        SerializedName = @"databaseShareOrigin",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseShareOrigin) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseShareOrigin? DatabaseShareOrigin { get;  }
        /// <summary>List of external tables to exclude from the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of external tables to exclude from the follower database",
        SerializedName = @"externalTablesToExclude",
        PossibleTypes = new [] { typeof(string) })]
        string[] TableLevelSharingPropertyExternalTablesToExclude { get; set; }
        /// <summary>List of external tables to include in the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of external tables to include in the follower database",
        SerializedName = @"externalTablesToInclude",
        PossibleTypes = new [] { typeof(string) })]
        string[] TableLevelSharingPropertyExternalTablesToInclude { get; set; }
        /// <summary>List of functions to exclude from the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of functions to exclude from the follower database",
        SerializedName = @"functionsToExclude",
        PossibleTypes = new [] { typeof(string) })]
        string[] TableLevelSharingPropertyFunctionsToExclude { get; set; }
        /// <summary>List of functions to include in the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of functions to include in the follower database",
        SerializedName = @"functionsToInclude",
        PossibleTypes = new [] { typeof(string) })]
        string[] TableLevelSharingPropertyFunctionsToInclude { get; set; }
        /// <summary>List of materialized views to exclude from the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of materialized views to exclude from the follower database",
        SerializedName = @"materializedViewsToExclude",
        PossibleTypes = new [] { typeof(string) })]
        string[] TableLevelSharingPropertyMaterializedViewsToExclude { get; set; }
        /// <summary>List of materialized views to include in the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of materialized views to include in the follower database",
        SerializedName = @"materializedViewsToInclude",
        PossibleTypes = new [] { typeof(string) })]
        string[] TableLevelSharingPropertyMaterializedViewsToInclude { get; set; }
        /// <summary>List of tables to exclude from the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of tables to exclude from the follower database",
        SerializedName = @"tablesToExclude",
        PossibleTypes = new [] { typeof(string) })]
        string[] TableLevelSharingPropertyTablesToExclude { get; set; }
        /// <summary>List of tables to include in the follower database</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of tables to include in the follower database",
        SerializedName = @"tablesToInclude",
        PossibleTypes = new [] { typeof(string) })]
        string[] TableLevelSharingPropertyTablesToInclude { get; set; }

    }
    /// A class representing follower database request.
    internal partial interface IFollowerDatabaseDefinitionInternal

    {
        /// <summary>Resource name of the attached database configuration in the follower cluster.</summary>
        string AttachedDatabaseConfigurationName { get; set; }
        /// <summary>Resource id of the cluster that follows a database owned by this cluster.</summary>
        string ClusterResourceId { get; set; }
        /// <summary>
        /// The database name owned by this cluster that was followed. * in case following all databases.
        /// </summary>
        string DatabaseName { get; set; }
        /// <summary>The origin of the following setup.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseShareOrigin? DatabaseShareOrigin { get; set; }
        /// <summary>Table level sharing specifications</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.ITableLevelSharingProperties TableLevelSharingProperty { get; set; }
        /// <summary>List of external tables to exclude from the follower database</summary>
        string[] TableLevelSharingPropertyExternalTablesToExclude { get; set; }
        /// <summary>List of external tables to include in the follower database</summary>
        string[] TableLevelSharingPropertyExternalTablesToInclude { get; set; }
        /// <summary>List of functions to exclude from the follower database</summary>
        string[] TableLevelSharingPropertyFunctionsToExclude { get; set; }
        /// <summary>List of functions to include in the follower database</summary>
        string[] TableLevelSharingPropertyFunctionsToInclude { get; set; }
        /// <summary>List of materialized views to exclude from the follower database</summary>
        string[] TableLevelSharingPropertyMaterializedViewsToExclude { get; set; }
        /// <summary>List of materialized views to include in the follower database</summary>
        string[] TableLevelSharingPropertyMaterializedViewsToInclude { get; set; }
        /// <summary>List of tables to exclude from the follower database</summary>
        string[] TableLevelSharingPropertyTablesToExclude { get; set; }
        /// <summary>List of tables to include in the follower database</summary>
        string[] TableLevelSharingPropertyTablesToInclude { get; set; }

    }
}
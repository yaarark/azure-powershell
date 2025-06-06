// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support
{

    /// <summary>Current resource status</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.RedisEnterpriseCache.Support.ResourceStateTypeConverter))]
    public partial struct ResourceState :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Running".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Running'", "Running", global::System.Management.Automation.CompletionResultType.ParameterValue, "Running");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Creating".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Creating'", "Creating", global::System.Management.Automation.CompletionResultType.ParameterValue, "Creating");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "CreateFailed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'CreateFailed'", "CreateFailed", global::System.Management.Automation.CompletionResultType.ParameterValue, "CreateFailed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Updating".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Updating'", "Updating", global::System.Management.Automation.CompletionResultType.ParameterValue, "Updating");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "UpdateFailed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'UpdateFailed'", "UpdateFailed", global::System.Management.Automation.CompletionResultType.ParameterValue, "UpdateFailed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Deleting".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Deleting'", "Deleting", global::System.Management.Automation.CompletionResultType.ParameterValue, "Deleting");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DeleteFailed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'DeleteFailed'", "DeleteFailed", global::System.Management.Automation.CompletionResultType.ParameterValue, "DeleteFailed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Enabling".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Enabling'", "Enabling", global::System.Management.Automation.CompletionResultType.ParameterValue, "Enabling");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "EnableFailed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'EnableFailed'", "EnableFailed", global::System.Management.Automation.CompletionResultType.ParameterValue, "EnableFailed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Disabling".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Disabling'", "Disabling", global::System.Management.Automation.CompletionResultType.ParameterValue, "Disabling");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "DisableFailed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'DisableFailed'", "DisableFailed", global::System.Management.Automation.CompletionResultType.ParameterValue, "DisableFailed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Disabled".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Disabled'", "Disabled", global::System.Management.Automation.CompletionResultType.ParameterValue, "Disabled");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Scaling".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Scaling'", "Scaling", global::System.Management.Automation.CompletionResultType.ParameterValue, "Scaling");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ScalingFailed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ScalingFailed'", "ScalingFailed", global::System.Management.Automation.CompletionResultType.ParameterValue, "ScalingFailed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Moving".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Moving'", "Moving", global::System.Management.Automation.CompletionResultType.ParameterValue, "Moving");
            }
        }
    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.DataShare
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for AccountsOperations
    /// </summary>
    public static partial class AccountsOperationsExtensions
    {
        /// <summary>
        /// Get an account
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        public static Account Get(this IAccountsOperations operations, string resourceGroupName, string accountName)
        {
                return ((IAccountsOperations)operations).GetAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get an account
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Account> GetAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Create an account
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        public static Account Create(this IAccountsOperations operations, string resourceGroupName, string accountName, Account account)
        {
                return ((IAccountsOperations)operations).CreateAsync(resourceGroupName, accountName, account).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an account
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Account> CreateAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, Account account, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, account, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// DeleteAccount
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        public static OperationResponse Delete(this IAccountsOperations operations, string resourceGroupName, string accountName)
        {
                return ((IAccountsOperations)operations).DeleteAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DeleteAccount
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<OperationResponse> DeleteAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Patch an account
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        public static Account Update(this IAccountsOperations operations, string resourceGroupName, string accountName, AccountUpdateParameters accountUpdateParameters)
        {
                return ((IAccountsOperations)operations).UpdateAsync(resourceGroupName, accountName, accountUpdateParameters).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Patch an account
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Account> UpdateAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, AccountUpdateParameters accountUpdateParameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, accountUpdateParameters, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// List Accounts in Subscription
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='skipToken'>
        /// Continuation token
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Account> ListBySubscription(this IAccountsOperations operations, string skipToken = default(string))
        {
                return ((IAccountsOperations)operations).ListBySubscriptionAsync(skipToken).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List Accounts in Subscription
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='skipToken'>
        /// Continuation token
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Account>> ListBySubscriptionAsync(this IAccountsOperations operations, string skipToken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(skipToken, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// List Accounts in ResourceGroup
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='skipToken'>
        /// Continuation token
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Account> ListByResourceGroup(this IAccountsOperations operations, string resourceGroupName, string skipToken = default(string))
        {
                return ((IAccountsOperations)operations).ListByResourceGroupAsync(resourceGroupName, skipToken).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List Accounts in ResourceGroup
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='skipToken'>
        /// Continuation token
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Account>> ListByResourceGroupAsync(this IAccountsOperations operations, string resourceGroupName, string skipToken = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, skipToken, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Create an account
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        public static Account BeginCreate(this IAccountsOperations operations, string resourceGroupName, string accountName, Account account)
        {
                return ((IAccountsOperations)operations).BeginCreateAsync(resourceGroupName, accountName, account).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an account
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Account> BeginCreateAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, Account account, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, accountName, account, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// DeleteAccount
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        public static OperationResponse BeginDelete(this IAccountsOperations operations, string resourceGroupName, string accountName)
        {
                return ((IAccountsOperations)operations).BeginDeleteAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DeleteAccount
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<OperationResponse> BeginDeleteAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// List Accounts in Subscription
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Account> ListBySubscriptionNext(this IAccountsOperations operations, string nextPageLink)
        {
                return ((IAccountsOperations)operations).ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List Accounts in Subscription
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Account>> ListBySubscriptionNextAsync(this IAccountsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// List Accounts in ResourceGroup
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<Account> ListByResourceGroupNext(this IAccountsOperations operations, string nextPageLink)
        {
                return ((IAccountsOperations)operations).ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List Accounts in ResourceGroup
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<Account>> ListByResourceGroupNextAsync(this IAccountsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}

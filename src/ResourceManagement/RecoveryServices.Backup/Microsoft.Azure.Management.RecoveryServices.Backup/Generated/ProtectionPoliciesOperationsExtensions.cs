// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for ProtectionPoliciesOperations.
    /// </summary>
    public static partial class ProtectionPoliciesOperationsExtensions
    {
            /// <summary>
            /// Provides the details of the backup policies associated to Recovery
            /// Services Vault. This is an asynchronous operation. Status of the
            /// operation can be fetched using GetPolicyOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='policyName'>
            /// Backup policy information to be fetched.
            /// </param>
            public static ProtectionPolicyResource Get(this IProtectionPoliciesOperations operations, string vaultName, string resourceGroupName, string policyName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IProtectionPoliciesOperations)s).GetAsync(vaultName, resourceGroupName, policyName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Provides the details of the backup policies associated to Recovery
            /// Services Vault. This is an asynchronous operation. Status of the
            /// operation can be fetched using GetPolicyOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='policyName'>
            /// Backup policy information to be fetched.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ProtectionPolicyResource> GetAsync(this IProtectionPoliciesOperations operations, string vaultName, string resourceGroupName, string policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(vaultName, resourceGroupName, policyName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or modifies a backup policy. This is an asynchronous operation.
            /// Status of the operation can be fetched using GetPolicyOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='policyName'>
            /// Backup policy to be created.
            /// </param>
            /// <param name='resourceProtectionPolicy'>
            /// resource backup policy
            /// </param>
            public static ProtectionPolicyResource CreateOrUpdate(this IProtectionPoliciesOperations operations, string vaultName, string resourceGroupName, string policyName, ProtectionPolicyResource resourceProtectionPolicy)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IProtectionPoliciesOperations)s).CreateOrUpdateAsync(vaultName, resourceGroupName, policyName, resourceProtectionPolicy), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or modifies a backup policy. This is an asynchronous operation.
            /// Status of the operation can be fetched using GetPolicyOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='policyName'>
            /// Backup policy to be created.
            /// </param>
            /// <param name='resourceProtectionPolicy'>
            /// resource backup policy
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ProtectionPolicyResource> CreateOrUpdateAsync(this IProtectionPoliciesOperations operations, string vaultName, string resourceGroupName, string policyName, ProtectionPolicyResource resourceProtectionPolicy, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(vaultName, resourceGroupName, policyName, resourceProtectionPolicy, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes specified backup policy from your Recovery Services Vault. This is
            /// an asynchronous operation. Status of the operation can be fetched using
            /// GetPolicyOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='policyName'>
            /// Backup policy to be deleted.
            /// </param>
            public static void Delete(this IProtectionPoliciesOperations operations, string vaultName, string resourceGroupName, string policyName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IProtectionPoliciesOperations)s).DeleteAsync(vaultName, resourceGroupName, policyName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes specified backup policy from your Recovery Services Vault. This is
            /// an asynchronous operation. Status of the operation can be fetched using
            /// GetPolicyOperationResult API.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='policyName'>
            /// Backup policy to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IProtectionPoliciesOperations operations, string vaultName, string resourceGroupName, string policyName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(vaultName, resourceGroupName, policyName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Lists of backup policies associated with Recovery Services Vault. API
            /// provides pagination parameters to fetch scoped results.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ProtectionPolicyResource> List(this IProtectionPoliciesOperations operations, string vaultName, string resourceGroupName, Microsoft.Rest.Azure.OData.ODataQuery<ProtectionPolicyQueryObject> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<ProtectionPolicyQueryObject>))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IProtectionPoliciesOperations)s).ListAsync(vaultName, resourceGroupName, odataQuery), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists of backup policies associated with Recovery Services Vault. API
            /// provides pagination parameters to fetch scoped results.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<ProtectionPolicyResource>> ListAsync(this IProtectionPoliciesOperations operations, string vaultName, string resourceGroupName, Microsoft.Rest.Azure.OData.ODataQuery<ProtectionPolicyQueryObject> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<ProtectionPolicyQueryObject>), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(vaultName, resourceGroupName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists of backup policies associated with Recovery Services Vault. API
            /// provides pagination parameters to fetch scoped results.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<ProtectionPolicyResource> ListNext(this IProtectionPoliciesOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IProtectionPoliciesOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists of backup policies associated with Recovery Services Vault. API
            /// provides pagination parameters to fetch scoped results.
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
            public static async Task<Microsoft.Rest.Azure.IPage<ProtectionPolicyResource>> ListNextAsync(this IProtectionPoliciesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

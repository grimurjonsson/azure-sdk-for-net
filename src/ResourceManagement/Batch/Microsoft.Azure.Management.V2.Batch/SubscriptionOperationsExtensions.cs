// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for SubscriptionOperations.
    /// </summary>
    public static partial class SubscriptionOperationsExtensions
    {
            /// <summary>
            /// Gets the Batch service quotas for the specified suscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationName'>
            /// The desired region for the quotas.
            /// </param>
            public static SubscriptionQuotasGetResultInner GetSubscriptionQuotas(this ISubscriptionOperations operations, string locationName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISubscriptionOperations)s).GetSubscriptionQuotasAsync(locationName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Batch service quotas for the specified suscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationName'>
            /// The desired region for the quotas.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<SubscriptionQuotasGetResultInner> GetSubscriptionQuotasAsync(this ISubscriptionOperations operations, string locationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetSubscriptionQuotasWithHttpMessagesAsync(locationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
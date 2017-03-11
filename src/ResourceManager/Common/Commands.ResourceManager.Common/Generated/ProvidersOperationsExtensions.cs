// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Internal.Resources
{
    using Azure;
    using Management;
    using Internal;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProvidersOperations.
    /// </summary>
    public static partial class ProvidersOperationsExtensions
    {
            /// <summary>
            /// Unregisters a subscription from a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider to unregister.
            /// </param>
            public static Provider Unregister(this IProvidersOperations operations, string resourceProviderNamespace)
            {
                return operations.UnregisterAsync(resourceProviderNamespace).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Unregisters a subscription from a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider to unregister.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Provider> UnregisterAsync(this IProvidersOperations operations, string resourceProviderNamespace, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UnregisterWithHttpMessagesAsync(resourceProviderNamespace, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Registers a subscription with a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider to register.
            /// </param>
            public static Provider Register(this IProvidersOperations operations, string resourceProviderNamespace)
            {
                return operations.RegisterAsync(resourceProviderNamespace).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Registers a subscription with a resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider to register.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Provider> RegisterAsync(this IProvidersOperations operations, string resourceProviderNamespace, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegisterWithHttpMessagesAsync(resourceProviderNamespace, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all resource providers for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The number of results to return. If null is passed returns all deployments.
            /// </param>
            /// <param name='expand'>
            /// The properties to include in the results. For example, use
            /// &amp;$expand=metadata in the query string to retrieve resource provider
            /// metadata. To include property aliases in response, use
            /// $expand=resourceTypes/aliases.
            /// </param>
            public static IPage<Provider> List(this IProvidersOperations operations, int? top = default(int?), string expand = default(string))
            {
                return operations.ListAsync(top, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all resource providers for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The number of results to return. If null is passed returns all deployments.
            /// </param>
            /// <param name='expand'>
            /// The properties to include in the results. For example, use
            /// &amp;$expand=metadata in the query string to retrieve resource provider
            /// metadata. To include property aliases in response, use
            /// $expand=resourceTypes/aliases.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Provider>> ListAsync(this IProvidersOperations operations, int? top = default(int?), string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(top, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the specified resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='expand'>
            /// The $expand query parameter. For example, to include property aliases in
            /// response, use $expand=resourceTypes/aliases.
            /// </param>
            public static Provider Get(this IProvidersOperations operations, string resourceProviderNamespace, string expand = default(string))
            {
                return operations.GetAsync(resourceProviderNamespace, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified resource provider.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceProviderNamespace'>
            /// The namespace of the resource provider.
            /// </param>
            /// <param name='expand'>
            /// The $expand query parameter. For example, to include property aliases in
            /// response, use $expand=resourceTypes/aliases.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Provider> GetAsync(this IProvidersOperations operations, string resourceProviderNamespace, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceProviderNamespace, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all resource providers for a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Provider> ListNext(this IProvidersOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all resource providers for a subscription.
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
            public static async Task<IPage<Provider>> ListNextAsync(this IProvidersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}


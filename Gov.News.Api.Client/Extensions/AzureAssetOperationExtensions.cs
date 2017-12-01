

namespace Gov.News.Api
{
    using Gov.News.Api.Models;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;


    /// <summary>
    /// Additional Extension methods for AzureAssetOperationExtensions.
    /// </summary>
    public static partial class AzureAssetOperationExtensions
    {

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='apiVersion'>
        /// The requested API version
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        public static AzureAsset GetFromPost(this IAzureAssetOperations operations, Post post)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(s => ((IAzureAssetOperations)s).GetFromPostAsync(post), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='apiVersion'>
        /// The requested API version
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<AzureAsset> GetFromPostAsync(this IAzureAssetOperations operations, Post post, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.GetFromPostWithHttpMessagesAsync(ClientExtensions.currentAPIVersion, post, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
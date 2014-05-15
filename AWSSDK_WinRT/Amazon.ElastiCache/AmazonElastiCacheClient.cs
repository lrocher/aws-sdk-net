/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

using Amazon.ElastiCache.Model;
using Amazon.ElastiCache.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElastiCache
{
    /// <summary>
    /// Implementation for accessing AmazonElastiCache.
    /// 
    /// Amazon ElastiCache <para>Amazon ElastiCache is a web service that makes it easier to set up, operate, and scale a distributed cache in the
    /// cloud.</para> <para>With ElastiCache, customers gain all of the benefits of a high-performance, in-memory cache with far less of the
    /// administrative burden of launching and managing a distributed cache. The service makes set-up, scaling, and cluster failure handling much
    /// simpler than in a self-managed cache deployment.</para> <para>In addition, through integration with Amazon CloudWatch, customers get
    /// enhanced visibility into the key performance statistics associated with their cache and can receive alarms if a part of their cache runs
    /// hot.</para>
    /// </summary>
	public partial class AmazonElastiCacheClient : AmazonWebServiceClient, Amazon.ElastiCache.IAmazonElastiCache
    {

        AWS4Signer signer = new AWS4Signer();
        #region Constructors

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElastiCacheClient(AWSCredentials credentials)
            : this(credentials, new AmazonElastiCacheConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElastiCacheClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElastiCacheConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Credentials and an
        /// AmazonElastiCacheClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElastiCacheClient Configuration Object</param>
        public AmazonElastiCacheClient(AWSCredentials credentials, AmazonElastiCacheConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElastiCacheConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElastiCacheConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElastiCacheClient Configuration object.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElastiCacheClient Configuration Object</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElastiCacheConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElastiCacheConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElastiCacheConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElastiCacheClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElastiCacheClient Configuration object.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElastiCacheClient Configuration Object</param>
        public AmazonElastiCacheClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElastiCacheConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
		internal AuthorizeCacheSecurityGroupIngressResponse AuthorizeCacheSecurityGroupIngress(AuthorizeCacheSecurityGroupIngressRequest request)
        {
            var task = AuthorizeCacheSecurityGroupIngressAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>AuthorizeCacheSecurityGroupIngress</i> operation allows network ingress to a cache security group. Applications using
        /// ElastiCache must be running on Amazon EC2, and Amazon EC2 security groups are used as the authorization mechanism.</para> <para><b>NOTE:</b>
        /// You cannot authorize ingress from an Amazon EC2 security group in one Region to an ElastiCache cluster in another Region. </para>
        /// </summary>
        /// 
        /// <param name="authorizeCacheSecurityGroupIngressRequest">Container for the necessary parameters to execute the
        /// AuthorizeCacheSecurityGroupIngress service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the AuthorizeCacheSecurityGroupIngress service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.AuthorizationAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<AuthorizeCacheSecurityGroupIngressResponse> AuthorizeCacheSecurityGroupIngressAsync(AuthorizeCacheSecurityGroupIngressRequest authorizeCacheSecurityGroupIngressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeCacheSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeCacheSecurityGroupIngressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AuthorizeCacheSecurityGroupIngressRequest, AuthorizeCacheSecurityGroupIngressResponse>(authorizeCacheSecurityGroupIngressRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CopySnapshotResponse CopySnapshot(CopySnapshotRequest request)
        {
            var task = CopySnapshotAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>CopySnapshot</i> operation makes a copy of an existing snapshot.</para>
        /// </summary>
        /// 
        /// <param name="copySnapshotRequest">Container for the necessary parameters to execute the CopySnapshot service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CopySnapshot service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidSnapshotStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotQuotaExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest copySnapshotRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopySnapshotRequestMarshaller();
            var unmarshaller = CopySnapshotResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CopySnapshotRequest, CopySnapshotResponse>(copySnapshotRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateCacheClusterResponse CreateCacheCluster(CreateCacheClusterRequest request)
        {
            var task = CreateCacheClusterAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>CreateCacheCluster</i> operation creates a new cache cluster. All nodes in the cache cluster run the same protocol-compliant
        /// cache engine software - either Memcached or Redis.</para>
        /// </summary>
        /// 
        /// <param name="createCacheClusterRequest">Container for the necessary parameters to execute the CreateCacheCluster service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.NodeQuotaForCustomerExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ClusterQuotaForCustomerExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InsufficientCacheClusterCapacityException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReplicationGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.NodeQuotaForClusterExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidReplicationGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidVPCNetworkStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateCacheClusterResponse> CreateCacheClusterAsync(CreateCacheClusterRequest createCacheClusterRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCacheClusterRequestMarshaller();
            var unmarshaller = CreateCacheClusterResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateCacheClusterRequest, CreateCacheClusterResponse>(createCacheClusterRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateCacheParameterGroupResponse CreateCacheParameterGroup(CreateCacheParameterGroupRequest request)
        {
            var task = CreateCacheParameterGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>CreateCacheParameterGroup</i> operation creates a new cache parameter group. A cache parameter group is a collection of
        /// parameters that you apply to all of the nodes in a cache cluster.</para>
        /// </summary>
        /// 
        /// <param name="createCacheParameterGroupRequest">Container for the necessary parameters to execute the CreateCacheParameterGroup service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheParameterGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateCacheParameterGroupResponse> CreateCacheParameterGroupAsync(CreateCacheParameterGroupRequest createCacheParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCacheParameterGroupRequestMarshaller();
            var unmarshaller = CreateCacheParameterGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateCacheParameterGroupRequest, CreateCacheParameterGroupResponse>(createCacheParameterGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateCacheSecurityGroupResponse CreateCacheSecurityGroup(CreateCacheSecurityGroupRequest request)
        {
            var task = CreateCacheSecurityGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>CreateCacheSecurityGroup</i> operation creates a new cache security group. Use a cache security group to control access to one
        /// or more cache clusters.</para> <para>Cache security groups are only used when you are creating a cluster outside of an Amazon Virtual
        /// Private Cloud (VPC). If you are creating a cluster inside of a VPC, use a cache subnet group instead. For more information, see
        /// <i>CreateCacheSubnetGroup</i> .</para>
        /// </summary>
        /// 
        /// <param name="createCacheSecurityGroupRequest">Container for the necessary parameters to execute the CreateCacheSecurityGroup service method
        /// on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheSecurityGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateCacheSecurityGroupResponse> CreateCacheSecurityGroupAsync(CreateCacheSecurityGroupRequest createCacheSecurityGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCacheSecurityGroupRequestMarshaller();
            var unmarshaller = CreateCacheSecurityGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateCacheSecurityGroupRequest, CreateCacheSecurityGroupResponse>(createCacheSecurityGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateCacheSubnetGroupResponse CreateCacheSubnetGroup(CreateCacheSubnetGroupRequest request)
        {
            var task = CreateCacheSubnetGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>CreateCacheSubnetGroup</i> operation creates a new cache subnet group.</para> <para>Use this parameter only when you are
        /// creating a cluster in an Amazon Virtual Private Cloud (VPC).</para>
        /// </summary>
        /// 
        /// <param name="createCacheSubnetGroupRequest">Container for the necessary parameters to execute the CreateCacheSubnetGroup service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateCacheSubnetGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupQuotaExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetQuotaExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidSubnetException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateCacheSubnetGroupResponse> CreateCacheSubnetGroupAsync(CreateCacheSubnetGroupRequest createCacheSubnetGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCacheSubnetGroupRequestMarshaller();
            var unmarshaller = CreateCacheSubnetGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateCacheSubnetGroupRequest, CreateCacheSubnetGroupResponse>(createCacheSubnetGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateReplicationGroupResponse CreateReplicationGroup(CreateReplicationGroupRequest request)
        {
            var task = CreateReplicationGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>CreateReplicationGroup</i> operation creates a replication group. A replication group is a collection of cache clusters, where
        /// one of the clusters is a read/write primary and the other clusters are read-only replicas. Writes to the primary are automatically
        /// propagated to the replicas.</para> <para>When you create a replication group, you must specify an existing cache cluster that is in the
        /// primary role. When the replication group has been successfully created, you can add one or more read replica replicas to it, up to a total
        /// of five read replicas.</para>
        /// </summary>
        /// 
        /// <param name="createReplicationGroupRequest">Container for the necessary parameters to execute the CreateReplicationGroup service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateReplicationGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.ReplicationGroupAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheClusterStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateReplicationGroupResponse> CreateReplicationGroupAsync(CreateReplicationGroupRequest createReplicationGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateReplicationGroupRequestMarshaller();
            var unmarshaller = CreateReplicationGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateReplicationGroupRequest, CreateReplicationGroupResponse>(createReplicationGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var task = CreateSnapshotAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>CreateSnapshot</i> operation creates a copy of an entire cache cluster at a specific moment in time.</para>
        /// </summary>
        /// 
        /// <param name="createSnapshotRequest">Container for the necessary parameters to execute the CreateSnapshot service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotFeatureNotSupportedException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheClusterStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotQuotaExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest createSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSnapshotRequestMarshaller();
            var unmarshaller = CreateSnapshotResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateSnapshotRequest, CreateSnapshotResponse>(createSnapshotRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteCacheClusterResponse DeleteCacheCluster(DeleteCacheClusterRequest request)
        {
            var task = DeleteCacheClusterAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>DeleteCacheCluster</i> operation deletes a previously provisioned cache cluster. <i>DeleteCacheCluster</i> deletes all
        /// associated cache nodes, node endpoints and the cache cluster itself. When you receive a successful response from this operation, Amazon
        /// ElastiCache immediately begins deleting the cache cluster; you cannot cancel or revert this operation.</para>
        /// </summary>
        /// 
        /// <param name="deleteCacheClusterRequest">Container for the necessary parameters to execute the DeleteCacheCluster service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DeleteCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotFeatureNotSupportedException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheClusterStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotQuotaExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteCacheClusterResponse> DeleteCacheClusterAsync(DeleteCacheClusterRequest deleteCacheClusterRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCacheClusterRequestMarshaller();
            var unmarshaller = DeleteCacheClusterResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteCacheClusterRequest, DeleteCacheClusterResponse>(deleteCacheClusterRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteCacheParameterGroupResponse DeleteCacheParameterGroup(DeleteCacheParameterGroupRequest request)
        {
            var task = DeleteCacheParameterGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>DeleteCacheParameterGroup</i> operation deletes the specified cache parameter group. You cannot delete a cache parameter group
        /// if it is associated with any cache clusters.</para>
        /// </summary>
        /// 
        /// <param name="deleteCacheParameterGroupRequest">Container for the necessary parameters to execute the DeleteCacheParameterGroup service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteCacheParameterGroupResponse> DeleteCacheParameterGroupAsync(DeleteCacheParameterGroupRequest deleteCacheParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCacheParameterGroupRequestMarshaller();
            var unmarshaller = DeleteCacheParameterGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteCacheParameterGroupRequest, DeleteCacheParameterGroupResponse>(deleteCacheParameterGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteCacheSecurityGroupResponse DeleteCacheSecurityGroup(DeleteCacheSecurityGroupRequest request)
        {
            var task = DeleteCacheSecurityGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>DeleteCacheSecurityGroup</i> operation deletes a cache security group.</para> <para><b>NOTE:</b>You cannot delete a cache
        /// security group if it is associated with any cache clusters.</para>
        /// </summary>
        /// 
        /// <param name="deleteCacheSecurityGroupRequest">Container for the necessary parameters to execute the DeleteCacheSecurityGroup service method
        /// on AmazonElastiCache.</param>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteCacheSecurityGroupResponse> DeleteCacheSecurityGroupAsync(DeleteCacheSecurityGroupRequest deleteCacheSecurityGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCacheSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteCacheSecurityGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteCacheSecurityGroupRequest, DeleteCacheSecurityGroupResponse>(deleteCacheSecurityGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteCacheSubnetGroupResponse DeleteCacheSubnetGroup(DeleteCacheSubnetGroupRequest request)
        {
            var task = DeleteCacheSubnetGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>DeleteCacheSubnetGroup</i> operation deletes a cache subnet group.</para> <para><b>NOTE:</b>You cannot delete a cache subnet
        /// group if it is associated with any cache clusters.</para>
        /// </summary>
        /// 
        /// <param name="deleteCacheSubnetGroupRequest">Container for the necessary parameters to execute the DeleteCacheSubnetGroup service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupInUseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteCacheSubnetGroupResponse> DeleteCacheSubnetGroupAsync(DeleteCacheSubnetGroupRequest deleteCacheSubnetGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCacheSubnetGroupRequestMarshaller();
            var unmarshaller = DeleteCacheSubnetGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteCacheSubnetGroupRequest, DeleteCacheSubnetGroupResponse>(deleteCacheSubnetGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteReplicationGroupResponse DeleteReplicationGroup(DeleteReplicationGroupRequest request)
        {
            var task = DeleteReplicationGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>DeleteReplicationGroup</i> operation deletes an existing replication group. By default, this operation deletes the entire
        /// replication group, including the primary cache cluster and all of the read replicas. You can optionally delete only the read replicas, while
        /// retaining the primary cache cluster.</para> <para>When you receive a successful response from this operation, Amazon ElastiCache immediately
        /// begins deleting the selected resources; you cannot cancel or revert this operation.</para>
        /// </summary>
        /// 
        /// <param name="deleteReplicationGroupRequest">Container for the necessary parameters to execute the DeleteReplicationGroup service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DeleteReplicationGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidReplicationGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotFeatureNotSupportedException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReplicationGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotQuotaExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteReplicationGroupResponse> DeleteReplicationGroupAsync(DeleteReplicationGroupRequest deleteReplicationGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteReplicationGroupRequestMarshaller();
            var unmarshaller = DeleteReplicationGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteReplicationGroupRequest, DeleteReplicationGroupResponse>(deleteReplicationGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var task = DeleteSnapshotAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>DeleteSnapshot</i> operation deletes an existing snapshot. When you receive a successful response from this operation,
        /// ElastiCache immediately begins deleting the snapshot; you cannot cancel or revert this operation.</para>
        /// </summary>
        /// 
        /// <param name="deleteSnapshotRequest">Container for the necessary parameters to execute the DeleteSnapshot service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DeleteSnapshot service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidSnapshotStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest deleteSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSnapshotRequestMarshaller();
            var unmarshaller = DeleteSnapshotResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteSnapshotRequest, DeleteSnapshotResponse>(deleteSnapshotRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeCacheClustersResponse DescribeCacheClusters(DescribeCacheClustersRequest request)
        {
            var task = DescribeCacheClustersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>DescribeCacheClusters</i> operation returns information about all provisioned cache clusters if no cache cluster identifier is
        /// specified, or about a specific cache cluster if a cache cluster identifier is supplied.</para> <para>By default, abbreviated information
        /// about the cache clusters(s) will be returned. You can use the optional <i>ShowDetails</i> flag to retrieve detailed information about the
        /// cache nodes associated with the cache clusters. These details include the DNS address and port for the cache node endpoint.</para> <para>If
        /// the cluster is in the CREATING state, only cluster level information will be displayed until all of the nodes are successfully
        /// provisioned.</para> <para>If the cluster is in the DELETING state, only cluster level information will be displayed.</para> <para>If cache
        /// nodes are currently being added to the cache cluster, node endpoint information and creation time for the additional nodes will not be
        /// displayed until they are completely provisioned. When the cache cluster state is <i>available</i> , the cluster is ready for use.</para>
        /// <para>If cache nodes are currently being removed from the cache cluster, no endpoint information for the removed nodes is displayed.</para>
        /// </summary>
        /// 
        /// <param name="describeCacheClustersRequest">Container for the necessary parameters to execute the DescribeCacheClusters service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheClusters service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeCacheClustersResponse> DescribeCacheClustersAsync(DescribeCacheClustersRequest describeCacheClustersRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCacheClustersRequestMarshaller();
            var unmarshaller = DescribeCacheClustersResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeCacheClustersRequest, DescribeCacheClustersResponse>(describeCacheClustersRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeCacheEngineVersionsResponse DescribeCacheEngineVersions(DescribeCacheEngineVersionsRequest request)
        {
            var task = DescribeCacheEngineVersionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>DescribeCacheEngineVersions</i> operation returns a list of the available cache engines and their versions.</para>
        /// </summary>
        /// 
        /// <param name="describeCacheEngineVersionsRequest">Container for the necessary parameters to execute the DescribeCacheEngineVersions service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheEngineVersions service method, as returned by AmazonElastiCache.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeCacheEngineVersionsResponse> DescribeCacheEngineVersionsAsync(DescribeCacheEngineVersionsRequest describeCacheEngineVersionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCacheEngineVersionsRequestMarshaller();
            var unmarshaller = DescribeCacheEngineVersionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeCacheEngineVersionsRequest, DescribeCacheEngineVersionsResponse>(describeCacheEngineVersionsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeCacheParameterGroupsResponse DescribeCacheParameterGroups(DescribeCacheParameterGroupsRequest request)
        {
            var task = DescribeCacheParameterGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>DescribeCacheParameterGroups</i> operation returns a list of cache parameter group descriptions. If a cache parameter group
        /// name is specified, the list will contain only the descriptions for that group.</para>
        /// </summary>
        /// 
        /// <param name="describeCacheParameterGroupsRequest">Container for the necessary parameters to execute the DescribeCacheParameterGroups service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheParameterGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeCacheParameterGroupsResponse> DescribeCacheParameterGroupsAsync(DescribeCacheParameterGroupsRequest describeCacheParameterGroupsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCacheParameterGroupsRequestMarshaller();
            var unmarshaller = DescribeCacheParameterGroupsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeCacheParameterGroupsRequest, DescribeCacheParameterGroupsResponse>(describeCacheParameterGroupsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeCacheParametersResponse DescribeCacheParameters(DescribeCacheParametersRequest request)
        {
            var task = DescribeCacheParametersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>DescribeCacheParameters</i> operation returns the detailed parameter list for a particular cache parameter group.</para>
        /// </summary>
        /// 
        /// <param name="describeCacheParametersRequest">Container for the necessary parameters to execute the DescribeCacheParameters service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheParameters service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeCacheParametersResponse> DescribeCacheParametersAsync(DescribeCacheParametersRequest describeCacheParametersRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCacheParametersRequestMarshaller();
            var unmarshaller = DescribeCacheParametersResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeCacheParametersRequest, DescribeCacheParametersResponse>(describeCacheParametersRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeCacheSecurityGroupsResponse DescribeCacheSecurityGroups(DescribeCacheSecurityGroupsRequest request)
        {
            var task = DescribeCacheSecurityGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>DescribeCacheSecurityGroups</i> operation returns a list of cache security group descriptions. If a cache security group name
        /// is specified, the list will contain only the description of that group.</para>
        /// </summary>
        /// 
        /// <param name="describeCacheSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeCacheSecurityGroups service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheSecurityGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeCacheSecurityGroupsResponse> DescribeCacheSecurityGroupsAsync(DescribeCacheSecurityGroupsRequest describeCacheSecurityGroupsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCacheSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeCacheSecurityGroupsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeCacheSecurityGroupsRequest, DescribeCacheSecurityGroupsResponse>(describeCacheSecurityGroupsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeCacheSubnetGroupsResponse DescribeCacheSubnetGroups(DescribeCacheSubnetGroupsRequest request)
        {
            var task = DescribeCacheSubnetGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>DescribeCacheSubnetGroups</i> operation returns a list of cache subnet group descriptions. If a subnet group name is specified,
        /// the list will contain only the description of that group.</para>
        /// </summary>
        /// 
        /// <param name="describeCacheSubnetGroupsRequest">Container for the necessary parameters to execute the DescribeCacheSubnetGroups service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeCacheSubnetGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeCacheSubnetGroupsResponse> DescribeCacheSubnetGroupsAsync(DescribeCacheSubnetGroupsRequest describeCacheSubnetGroupsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCacheSubnetGroupsRequestMarshaller();
            var unmarshaller = DescribeCacheSubnetGroupsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeCacheSubnetGroupsRequest, DescribeCacheSubnetGroupsResponse>(describeCacheSubnetGroupsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeEngineDefaultParametersResponse DescribeEngineDefaultParameters(DescribeEngineDefaultParametersRequest request)
        {
            var task = DescribeEngineDefaultParametersAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>DescribeEngineDefaultParameters</i> operation returns the default engine and system parameter information for the specified
        /// cache engine.</para>
        /// </summary>
        /// 
        /// <param name="describeEngineDefaultParametersRequest">Container for the necessary parameters to execute the DescribeEngineDefaultParameters
        /// service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeEngineDefaultParameters service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeEngineDefaultParametersResponse> DescribeEngineDefaultParametersAsync(DescribeEngineDefaultParametersRequest describeEngineDefaultParametersRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEngineDefaultParametersRequestMarshaller();
            var unmarshaller = DescribeEngineDefaultParametersResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeEngineDefaultParametersRequest, DescribeEngineDefaultParametersResponse>(describeEngineDefaultParametersRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var task = DescribeEventsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>DescribeEvents</i> operation returns events related to cache clusters, cache security groups, and cache parameter groups. You
        /// can obtain events specific to a particular cache cluster, cache security group, or cache parameter group by providing the name as a
        /// parameter.</para> <para>By default, only the events occurring within the last hour are returned; however, you can retrieve up to 14 days'
        /// worth of events if necessary.</para>
        /// </summary>
        /// 
        /// <param name="describeEventsRequest">Container for the necessary parameters to execute the DescribeEvents service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest describeEventsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeEventsRequestMarshaller();
            var unmarshaller = DescribeEventsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeEventsRequest, DescribeEventsResponse>(describeEventsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeReplicationGroupsResponse DescribeReplicationGroups(DescribeReplicationGroupsRequest request)
        {
            var task = DescribeReplicationGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>DescribeReplicationGroups</i> operation returns information about a particular replication group. If no identifier is
        /// specified, <i>DescribeReplicationGroups</i> returns information about all replication groups.</para>
        /// </summary>
        /// 
        /// <param name="describeReplicationGroupsRequest">Container for the necessary parameters to execute the DescribeReplicationGroups service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeReplicationGroups service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReplicationGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeReplicationGroupsResponse> DescribeReplicationGroupsAsync(DescribeReplicationGroupsRequest describeReplicationGroupsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReplicationGroupsRequestMarshaller();
            var unmarshaller = DescribeReplicationGroupsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeReplicationGroupsRequest, DescribeReplicationGroupsResponse>(describeReplicationGroupsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeReservedCacheNodesResponse DescribeReservedCacheNodes(DescribeReservedCacheNodesRequest request)
        {
            var task = DescribeReservedCacheNodesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>DescribeReservedCacheNodes</i> operation returns information about reserved cache nodes for this account, or about a specified
        /// reserved cache node.</para>
        /// </summary>
        /// 
        /// <param name="describeReservedCacheNodesRequest">Container for the necessary parameters to execute the DescribeReservedCacheNodes service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodes service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodeNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeReservedCacheNodesResponse> DescribeReservedCacheNodesAsync(DescribeReservedCacheNodesRequest describeReservedCacheNodesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedCacheNodesRequestMarshaller();
            var unmarshaller = DescribeReservedCacheNodesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeReservedCacheNodesRequest, DescribeReservedCacheNodesResponse>(describeReservedCacheNodesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeReservedCacheNodesOfferingsResponse DescribeReservedCacheNodesOfferings(DescribeReservedCacheNodesOfferingsRequest request)
        {
            var task = DescribeReservedCacheNodesOfferingsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>DescribeReservedCacheNodesOfferings</i> operation lists available reserved cache node offerings.</para>
        /// </summary>
        /// 
        /// <param name="describeReservedCacheNodesOfferingsRequest">Container for the necessary parameters to execute the
        /// DescribeReservedCacheNodesOfferings service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeReservedCacheNodesOfferings service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodesOfferingNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeReservedCacheNodesOfferingsResponse> DescribeReservedCacheNodesOfferingsAsync(DescribeReservedCacheNodesOfferingsRequest describeReservedCacheNodesOfferingsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedCacheNodesOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedCacheNodesOfferingsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeReservedCacheNodesOfferingsRequest, DescribeReservedCacheNodesOfferingsResponse>(describeReservedCacheNodesOfferingsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            var task = DescribeSnapshotsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>DescribeSnapshots</i> operation returns information about cache cluster snapshots. By default, <i>DescribeSnapshots</i> lists
        /// all of your snapshots; it can optionally describe a single snapshot, or just the snapshots associated with a particular cache
        /// cluster.</para>
        /// </summary>
        /// 
        /// <param name="describeSnapshotsRequest">Container for the necessary parameters to execute the DescribeSnapshots service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.SnapshotNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest describeSnapshotsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSnapshotsRequestMarshaller();
            var unmarshaller = DescribeSnapshotsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeSnapshotsRequest, DescribeSnapshotsResponse>(describeSnapshotsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ModifyCacheClusterResponse ModifyCacheCluster(ModifyCacheClusterRequest request)
        {
            var task = ModifyCacheClusterAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>ModifyCacheCluster</i> operation modifies the settings for a cache cluster. You can use this operation to change one or more
        /// cluster configuration parameters by specifying the parameters and the new values.</para>
        /// </summary>
        /// 
        /// <param name="modifyCacheClusterRequest">Container for the necessary parameters to execute the ModifyCacheCluster service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ModifyCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.NodeQuotaForCustomerExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.NodeQuotaForClusterExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheClusterStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ModifyCacheClusterResponse> ModifyCacheClusterAsync(ModifyCacheClusterRequest modifyCacheClusterRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyCacheClusterRequestMarshaller();
            var unmarshaller = ModifyCacheClusterResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyCacheClusterRequest, ModifyCacheClusterResponse>(modifyCacheClusterRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ModifyCacheParameterGroupResponse ModifyCacheParameterGroup(ModifyCacheParameterGroupRequest request)
        {
            var task = ModifyCacheParameterGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>ModifyCacheParameterGroup</i> operation modifies the parameters of a cache parameter group. You can modify up to 20 parameters
        /// in a single request by submitting a list parameter name and value pairs.</para>
        /// </summary>
        /// 
        /// <param name="modifyCacheParameterGroupRequest">Container for the necessary parameters to execute the ModifyCacheParameterGroup service
        /// method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ModifyCacheParameterGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ModifyCacheParameterGroupResponse> ModifyCacheParameterGroupAsync(ModifyCacheParameterGroupRequest modifyCacheParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyCacheParameterGroupRequestMarshaller();
            var unmarshaller = ModifyCacheParameterGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyCacheParameterGroupRequest, ModifyCacheParameterGroupResponse>(modifyCacheParameterGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ModifyCacheSubnetGroupResponse ModifyCacheSubnetGroup(ModifyCacheSubnetGroupRequest request)
        {
            var task = ModifyCacheSubnetGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>ModifyCacheSubnetGroup</i> operation modifies an existing cache subnet group.</para>
        /// </summary>
        /// 
        /// <param name="modifyCacheSubnetGroupRequest">Container for the necessary parameters to execute the ModifyCacheSubnetGroup service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ModifyCacheSubnetGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSubnetQuotaExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.SubnetInUseException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ModifyCacheSubnetGroupResponse> ModifyCacheSubnetGroupAsync(ModifyCacheSubnetGroupRequest modifyCacheSubnetGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyCacheSubnetGroupRequestMarshaller();
            var unmarshaller = ModifyCacheSubnetGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyCacheSubnetGroupRequest, ModifyCacheSubnetGroupResponse>(modifyCacheSubnetGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ModifyReplicationGroupResponse ModifyReplicationGroup(ModifyReplicationGroupRequest request)
        {
            var task = ModifyReplicationGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>ModifyReplicationGroup</i> operation modifies the settings for a replication group.</para>
        /// </summary>
        /// 
        /// <param name="modifyReplicationGroupRequest">Container for the necessary parameters to execute the ModifyReplicationGroup service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ModifyReplicationGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidReplicationGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidVPCNetworkStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReplicationGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheClusterStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ModifyReplicationGroupResponse> ModifyReplicationGroupAsync(ModifyReplicationGroupRequest modifyReplicationGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyReplicationGroupRequestMarshaller();
            var unmarshaller = ModifyReplicationGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyReplicationGroupRequest, ModifyReplicationGroupResponse>(modifyReplicationGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal PurchaseReservedCacheNodesOfferingResponse PurchaseReservedCacheNodesOffering(PurchaseReservedCacheNodesOfferingRequest request)
        {
            var task = PurchaseReservedCacheNodesOfferingAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>PurchaseReservedCacheNodesOffering</i> operation allows you to purchase a reserved cache node offering.</para>
        /// </summary>
        /// 
        /// <param name="purchaseReservedCacheNodesOfferingRequest">Container for the necessary parameters to execute the
        /// PurchaseReservedCacheNodesOffering service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the PurchaseReservedCacheNodesOffering service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodeQuotaExceededException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodeAlreadyExistsException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.ReservedCacheNodesOfferingNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<PurchaseReservedCacheNodesOfferingResponse> PurchaseReservedCacheNodesOfferingAsync(PurchaseReservedCacheNodesOfferingRequest purchaseReservedCacheNodesOfferingRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PurchaseReservedCacheNodesOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedCacheNodesOfferingResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PurchaseReservedCacheNodesOfferingRequest, PurchaseReservedCacheNodesOfferingResponse>(purchaseReservedCacheNodesOfferingRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal RebootCacheClusterResponse RebootCacheCluster(RebootCacheClusterRequest request)
        {
            var task = RebootCacheClusterAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>RebootCacheCluster</i> operation reboots some, or all, of the cache cluster nodes within a provisioned cache cluster. This API
        /// will apply any modified cache parameter groups to the cache cluster. The reboot action takes place as soon as possible, and results in a
        /// momentary outage to the cache cluster. During the reboot, the cache cluster status is set to REBOOTING.</para> <para>The reboot causes the
        /// contents of the cache (for each cache cluster node being rebooted) to be lost.</para> <para>When the reboot is complete, a cache cluster
        /// event is created.</para>
        /// </summary>
        /// 
        /// <param name="rebootCacheClusterRequest">Container for the necessary parameters to execute the RebootCacheCluster service method on
        /// AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the RebootCacheCluster service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheClusterNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheClusterStateException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<RebootCacheClusterResponse> RebootCacheClusterAsync(RebootCacheClusterRequest rebootCacheClusterRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebootCacheClusterRequestMarshaller();
            var unmarshaller = RebootCacheClusterResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RebootCacheClusterRequest, RebootCacheClusterResponse>(rebootCacheClusterRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ResetCacheParameterGroupResponse ResetCacheParameterGroup(ResetCacheParameterGroupRequest request)
        {
            var task = ResetCacheParameterGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>ResetCacheParameterGroup</i> operation modifies the parameters of a cache parameter group to the engine or system default
        /// value. You can reset specific parameters by submitting a list of parameter names. To reset the entire cache parameter group, specify the
        /// <i>ResetAllParameters</i> and <i>CacheParameterGroupName</i> parameters.</para>
        /// </summary>
        /// 
        /// <param name="resetCacheParameterGroupRequest">Container for the necessary parameters to execute the ResetCacheParameterGroup service method
        /// on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the ResetCacheParameterGroup service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheParameterGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheParameterGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ResetCacheParameterGroupResponse> ResetCacheParameterGroupAsync(ResetCacheParameterGroupRequest resetCacheParameterGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetCacheParameterGroupRequestMarshaller();
            var unmarshaller = ResetCacheParameterGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ResetCacheParameterGroupRequest, ResetCacheParameterGroupResponse>(resetCacheParameterGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal RevokeCacheSecurityGroupIngressResponse RevokeCacheSecurityGroupIngress(RevokeCacheSecurityGroupIngressRequest request)
        {
            var task = RevokeCacheSecurityGroupIngressAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <summary>
        /// <para>The <i>RevokeCacheSecurityGroupIngress</i> operation revokes ingress from a cache security group. Use this operation to disallow
        /// access from an Amazon EC2 security group that had been previously authorized.</para>
        /// </summary>
        /// 
        /// <param name="revokeCacheSecurityGroupIngressRequest">Container for the necessary parameters to execute the RevokeCacheSecurityGroupIngress
        /// service method on AmazonElastiCache.</param>
        /// 
        /// <returns>The response from the RevokeCacheSecurityGroupIngress service method, as returned by AmazonElastiCache.</returns>
        /// 
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterValueException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidCacheSecurityGroupStateException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.AuthorizationNotFoundException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.InvalidParameterCombinationException" />
        /// <exception cref="T:Amazon.ElastiCache.Model.CacheSecurityGroupNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<RevokeCacheSecurityGroupIngressResponse> RevokeCacheSecurityGroupIngressAsync(RevokeCacheSecurityGroupIngressRequest revokeCacheSecurityGroupIngressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeCacheSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeCacheSecurityGroupIngressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RevokeCacheSecurityGroupIngressRequest, RevokeCacheSecurityGroupIngressResponse>(revokeCacheSecurityGroupIngressRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
    }
}

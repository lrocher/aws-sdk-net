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

using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3
{
    /// <summary>
    /// Implementation for accessing AmazonS3.
    /// 
    /// 
    /// </summary>
	public partial class AmazonS3Client : AmazonWebServiceClient, Amazon.S3.IAmazonS3
    {

        S3Signer signer = new S3Signer();
        #region Constructors

        /// <summary>
        /// Constructs AmazonS3Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonS3Client(AWSCredentials credentials)
            : this(credentials, new AmazonS3Config())
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonS3Config(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Credentials and an
        /// AmazonS3Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(AWSCredentials credentials, AmazonS3Config clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3Config())
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3Client Configuration object.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonS3Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3Config())
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3Config(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3Client Configuration object.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonS3Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
		internal AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request)
        {
            var task = AbortMultipartUploadAsync(request);
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
        /// <para>Aborts a multipart upload.</para>
        /// </summary>
        /// 
        /// <param name="abortMultipartUploadRequest">Container for the necessary parameters to execute the AbortMultipartUpload service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<AbortMultipartUploadResponse> AbortMultipartUploadAsync(AbortMultipartUploadRequest abortMultipartUploadRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AbortMultipartUploadRequestMarshaller();
            var unmarshaller = AbortMultipartUploadResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AbortMultipartUploadRequest, AbortMultipartUploadResponse>(abortMultipartUploadRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest request)
        {
            var task = CompleteMultipartUploadAsync(request);
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
        /// <para>Completes a multipart upload by assembling previously uploaded parts.</para>
        /// </summary>
        /// 
        /// <param name="completeMultipartUploadRequest">Container for the necessary parameters to execute the CompleteMultipartUpload service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the CompleteMultipartUpload service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CompleteMultipartUploadResponse> CompleteMultipartUploadAsync(CompleteMultipartUploadRequest completeMultipartUploadRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CompleteMultipartUploadRequestMarshaller();
            var unmarshaller = CompleteMultipartUploadResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CompleteMultipartUploadRequest, CompleteMultipartUploadResponse>(completeMultipartUploadRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CopyObjectResponse CopyObject(CopyObjectRequest request)
        {
            var task = CopyObjectAsync(request);
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
        /// <para>Creates a copy of an object that is already stored in Amazon S3.</para>
        /// </summary>
        /// 
        /// <param name="copyObjectRequest">Container for the necessary parameters to execute the CopyObject service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CopyObjectResponse> CopyObjectAsync(CopyObjectRequest copyObjectRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyObjectRequestMarshaller();
            var unmarshaller = CopyObjectResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CopyObjectRequest, CopyObjectResponse>(copyObjectRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CopyPartResponse CopyPart(CopyPartRequest request)
        {
            var task = CopyPartAsync(request);
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
        /// <para>Uploads a part by copying data from an existing object as data source.</para>
        /// </summary>
        /// 
        /// <param name="copyPartRequest">Container for the necessary parameters to execute the CopyPart service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CopyPartResponse> CopyPartAsync(CopyPartRequest copyPartRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyPartRequestMarshaller();
            var unmarshaller = CopyPartResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CopyPartRequest, CopyPartResponse>(copyPartRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteBucketResponse DeleteBucket(DeleteBucketRequest request)
        {
            var task = DeleteBucketAsync(request);
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
        /// <para>Deletes the bucket. All objects (including all object versions and Delete Markers) in the bucket must be deleted before the bucket
        /// itself can be deleted.</para>
        /// </summary>
        /// 
        /// <param name="deleteBucketRequest">Container for the necessary parameters to execute the DeleteBucket service method on AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteBucketResponse> DeleteBucketAsync(DeleteBucketRequest deleteBucketRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBucketRequestMarshaller();
            var unmarshaller = DeleteBucketResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteBucketRequest, DeleteBucketResponse>(deleteBucketRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteBucketPolicyResponse DeleteBucketPolicy(DeleteBucketPolicyRequest request)
        {
            var task = DeleteBucketPolicyAsync(request);
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
        /// <para>Deletes the policy from the bucket.</para>
        /// </summary>
        /// 
        /// <param name="deleteBucketPolicyRequest">Container for the necessary parameters to execute the DeleteBucketPolicy service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteBucketPolicyResponse> DeleteBucketPolicyAsync(DeleteBucketPolicyRequest deleteBucketPolicyRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBucketPolicyRequestMarshaller();
            var unmarshaller = DeleteBucketPolicyResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteBucketPolicyRequest, DeleteBucketPolicyResponse>(deleteBucketPolicyRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteBucketTaggingResponse DeleteBucketTagging(DeleteBucketTaggingRequest request)
        {
            var task = DeleteBucketTaggingAsync(request);
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
        /// <para>Deletes the tags from the bucket.</para>
        /// </summary>
        /// 
        /// <param name="deleteBucketTaggingRequest">Container for the necessary parameters to execute the DeleteBucketTagging service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteBucketTaggingResponse> DeleteBucketTaggingAsync(DeleteBucketTaggingRequest deleteBucketTaggingRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBucketTaggingRequestMarshaller();
            var unmarshaller = DeleteBucketTaggingResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteBucketTaggingRequest, DeleteBucketTaggingResponse>(deleteBucketTaggingRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteBucketWebsiteResponse DeleteBucketWebsite(DeleteBucketWebsiteRequest request)
        {
            var task = DeleteBucketWebsiteAsync(request);
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
        /// <para>This operation removes the website configuration from the bucket.</para>
        /// </summary>
        /// 
        /// <param name="deleteBucketWebsiteRequest">Container for the necessary parameters to execute the DeleteBucketWebsite service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteBucketWebsiteResponse> DeleteBucketWebsiteAsync(DeleteBucketWebsiteRequest deleteBucketWebsiteRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteBucketWebsiteRequestMarshaller();
            var unmarshaller = DeleteBucketWebsiteResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteBucketWebsiteRequest, DeleteBucketWebsiteResponse>(deleteBucketWebsiteRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteCORSConfigurationResponse DeleteCORSConfiguration(DeleteCORSConfigurationRequest request)
        {
            var task = DeleteCORSConfigurationAsync(request);
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
        /// <para>Deletes the cors configuration information set for the bucket.</para>
        /// </summary>
        /// 
        /// <param name="deleteCORSConfigurationRequest">Container for the necessary parameters to execute the DeleteCORSConfiguration service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteCORSConfigurationResponse> DeleteCORSConfigurationAsync(DeleteCORSConfigurationRequest deleteCORSConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCORSConfigurationRequestMarshaller();
            var unmarshaller = DeleteCORSConfigurationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteCORSConfigurationRequest, DeleteCORSConfigurationResponse>(deleteCORSConfigurationRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteLifecycleConfigurationResponse DeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest request)
        {
            var task = DeleteLifecycleConfigurationAsync(request);
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
        /// <para>Deletes the lifecycle configuration from the bucket.</para>
        /// </summary>
        /// 
        /// <param name="deleteLifecycleConfigurationRequest">Container for the necessary parameters to execute the DeleteLifecycleConfiguration service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteLifecycleConfigurationResponse> DeleteLifecycleConfigurationAsync(DeleteLifecycleConfigurationRequest deleteLifecycleConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLifecycleConfigurationRequestMarshaller();
            var unmarshaller = DeleteLifecycleConfigurationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteLifecycleConfigurationRequest, DeleteLifecycleConfigurationResponse>(deleteLifecycleConfigurationRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteObjectResponse DeleteObject(DeleteObjectRequest request)
        {
            var task = DeleteObjectAsync(request);
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
        /// <para>Removes the null version (if there is one) of an object and inserts a delete marker, which becomes the latest version of the object.
        /// If there isn''t a null version, Amazon S3 does not remove any objects.</para>
        /// </summary>
        /// 
        /// <param name="deleteObjectRequest">Container for the necessary parameters to execute the DeleteObject service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteObjectResponse> DeleteObjectAsync(DeleteObjectRequest deleteObjectRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteObjectRequestMarshaller();
            var unmarshaller = DeleteObjectResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteObjectRequest, DeleteObjectResponse>(deleteObjectRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteObjectsResponse DeleteObjects(DeleteObjectsRequest request)
        {
            var task = DeleteObjectsAsync(request);
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
        /// <para>This operation enables you to delete multiple objects from a bucket using a single HTTP request. You may specify up to 1000
        /// keys.</para>
        /// </summary>
        /// 
        /// <param name="deleteObjectsRequest">Container for the necessary parameters to execute the DeleteObjects service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the DeleteObjects service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteObjectsResponse> DeleteObjectsAsync(DeleteObjectsRequest deleteObjectsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteObjectsRequestMarshaller();
            var unmarshaller = DeleteObjectsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteObjectsRequest, DeleteObjectsResponse>(deleteObjectsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetACLResponse GetACL(GetACLRequest request)
        {
            var task = GetACLAsync(request);
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
        /// <para>Returns the access control list (ACL) of an object.</para>
        /// </summary>
        /// 
        /// <param name="getACLRequest">Container for the necessary parameters to execute the GetACL service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the GetACL service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetACLResponse> GetACLAsync(GetACLRequest getACLRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetACLRequestMarshaller();
            var unmarshaller = GetACLResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetACLRequest, GetACLResponse>(getACLRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetBucketLocationResponse GetBucketLocation(GetBucketLocationRequest request)
        {
            var task = GetBucketLocationAsync(request);
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
        /// <para>Returns the region the bucket resides in.</para>
        /// </summary>
        /// 
        /// <param name="getBucketLocationRequest">Container for the necessary parameters to execute the GetBucketLocation service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketLocation service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetBucketLocationResponse> GetBucketLocationAsync(GetBucketLocationRequest getBucketLocationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketLocationRequestMarshaller();
            var unmarshaller = GetBucketLocationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetBucketLocationRequest, GetBucketLocationResponse>(getBucketLocationRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetBucketLoggingResponse GetBucketLogging(GetBucketLoggingRequest request)
        {
            var task = GetBucketLoggingAsync(request);
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
        /// <para>Returns the logging status of a bucket and the permissions users have to view and modify that status. To use GET, you must be the
        /// bucket owner.</para>
        /// </summary>
        /// 
        /// <param name="getBucketLoggingRequest">Container for the necessary parameters to execute the GetBucketLogging service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketLogging service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetBucketLoggingResponse> GetBucketLoggingAsync(GetBucketLoggingRequest getBucketLoggingRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketLoggingRequestMarshaller();
            var unmarshaller = GetBucketLoggingResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetBucketLoggingRequest, GetBucketLoggingResponse>(getBucketLoggingRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetBucketNotificationResponse GetBucketNotification(GetBucketNotificationRequest request)
        {
            var task = GetBucketNotificationAsync(request);
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
        /// <para>Return the notification configuration of a bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketNotificationRequest">Container for the necessary parameters to execute the GetBucketNotification service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketNotification service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetBucketNotificationResponse> GetBucketNotificationAsync(GetBucketNotificationRequest getBucketNotificationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketNotificationRequestMarshaller();
            var unmarshaller = GetBucketNotificationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetBucketNotificationRequest, GetBucketNotificationResponse>(getBucketNotificationRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetBucketPolicyResponse GetBucketPolicy(GetBucketPolicyRequest request)
        {
            var task = GetBucketPolicyAsync(request);
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
        /// <para>Returns the policy of a specified bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketPolicyRequest">Container for the necessary parameters to execute the GetBucketPolicy service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketPolicy service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetBucketPolicyResponse> GetBucketPolicyAsync(GetBucketPolicyRequest getBucketPolicyRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketPolicyRequestMarshaller();
            var unmarshaller = GetBucketPolicyResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetBucketPolicyRequest, GetBucketPolicyResponse>(getBucketPolicyRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetBucketRequestPaymentResponse GetBucketRequestPayment(GetBucketRequestPaymentRequest request)
        {
            var task = GetBucketRequestPaymentAsync(request);
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
        /// <para>Returns the request payment configuration of a bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketRequestPaymentRequest">Container for the necessary parameters to execute the GetBucketRequestPayment service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketRequestPayment service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetBucketRequestPaymentResponse> GetBucketRequestPaymentAsync(GetBucketRequestPaymentRequest getBucketRequestPaymentRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketRequestPaymentRequestMarshaller();
            var unmarshaller = GetBucketRequestPaymentResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetBucketRequestPaymentRequest, GetBucketRequestPaymentResponse>(getBucketRequestPaymentRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetBucketTaggingResponse GetBucketTagging(GetBucketTaggingRequest request)
        {
            var task = GetBucketTaggingAsync(request);
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
        /// <para>Returns the tag set associated with the bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketTaggingRequest">Container for the necessary parameters to execute the GetBucketTagging service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketTagging service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetBucketTaggingResponse> GetBucketTaggingAsync(GetBucketTaggingRequest getBucketTaggingRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketTaggingRequestMarshaller();
            var unmarshaller = GetBucketTaggingResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetBucketTaggingRequest, GetBucketTaggingResponse>(getBucketTaggingRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetBucketVersioningResponse GetBucketVersioning(GetBucketVersioningRequest request)
        {
            var task = GetBucketVersioningAsync(request);
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
        /// <para>Returns the versioning state of a bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketVersioningRequest">Container for the necessary parameters to execute the GetBucketVersioning service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketVersioning service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetBucketVersioningResponse> GetBucketVersioningAsync(GetBucketVersioningRequest getBucketVersioningRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketVersioningRequestMarshaller();
            var unmarshaller = GetBucketVersioningResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetBucketVersioningRequest, GetBucketVersioningResponse>(getBucketVersioningRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetBucketWebsiteResponse GetBucketWebsite(GetBucketWebsiteRequest request)
        {
            var task = GetBucketWebsiteAsync(request);
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
        /// <para>Returns the website configuration for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketWebsiteRequest">Container for the necessary parameters to execute the GetBucketWebsite service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketWebsite service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetBucketWebsiteResponse> GetBucketWebsiteAsync(GetBucketWebsiteRequest getBucketWebsiteRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetBucketWebsiteRequestMarshaller();
            var unmarshaller = GetBucketWebsiteResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetBucketWebsiteRequest, GetBucketWebsiteResponse>(getBucketWebsiteRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetCORSConfigurationResponse GetCORSConfiguration(GetCORSConfigurationRequest request)
        {
            var task = GetCORSConfigurationAsync(request);
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
        /// <para>Returns the cors configuration for the bucket.</para>
        /// </summary>
        /// 
        /// <param name="getCORSConfigurationRequest">Container for the necessary parameters to execute the GetCORSConfiguration service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the GetCORSConfiguration service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetCORSConfigurationResponse> GetCORSConfigurationAsync(GetCORSConfigurationRequest getCORSConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetCORSConfigurationRequestMarshaller();
            var unmarshaller = GetCORSConfigurationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetCORSConfigurationRequest, GetCORSConfigurationResponse>(getCORSConfigurationRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetLifecycleConfigurationResponse GetLifecycleConfiguration(GetLifecycleConfigurationRequest request)
        {
            var task = GetLifecycleConfigurationAsync(request);
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
        /// <para>Returns the lifecycle configuration information set on the bucket.</para>
        /// </summary>
        /// 
        /// <param name="getLifecycleConfigurationRequest">Container for the necessary parameters to execute the GetLifecycleConfiguration service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetLifecycleConfiguration service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetLifecycleConfigurationResponse> GetLifecycleConfigurationAsync(GetLifecycleConfigurationRequest getLifecycleConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetLifecycleConfigurationRequestMarshaller();
            var unmarshaller = GetLifecycleConfigurationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetLifecycleConfigurationRequest, GetLifecycleConfigurationResponse>(getLifecycleConfigurationRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetObjectResponse GetObject(GetObjectRequest request)
        {
            var task = GetObjectAsync(request);
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
        /// <para>Retrieves objects from Amazon S3.</para>
        /// </summary>
        /// 
        /// <param name="getObjectRequest">Container for the necessary parameters to execute the GetObject service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetObjectResponse> GetObjectAsync(GetObjectRequest getObjectRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetObjectRequestMarshaller();
            var unmarshaller = GetObjectResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetObjectRequest, GetObjectResponse>(getObjectRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetObjectMetadataResponse GetObjectMetadata(GetObjectMetadataRequest request)
        {
            var task = GetObjectMetadataAsync(request);
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
        /// Returns information about a specified object.
        /// </summary>
        /// <remarks>
        /// Retrieves information about a specific object or object size, without actually fetching the object itself.
        /// This is useful if you're only interested in the object metadata, and don't want to waste bandwidth on the object data.
        /// The response is identical to the GetObject response, except that there is no response body.
        /// </remarks>
        /// <param name="getObjectMetadataRequest">Container for the necessary parameters to execute the GetObjectMetadata service method on AmazonS3.</param>
        /// <returns>The response from the HeadObject service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetObjectMetadataResponse> GetObjectMetadataAsync(GetObjectMetadataRequest getObjectMetadataRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetObjectMetadataRequestMarshaller();
            var unmarshaller = GetObjectMetadataResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetObjectMetadataRequest, GetObjectMetadataResponse>(getObjectMetadataRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetObjectTorrentResponse GetObjectTorrent(GetObjectTorrentRequest request)
        {
            var task = GetObjectTorrentAsync(request);
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
        /// <para>Return torrent files from a bucket.</para>
        /// </summary>
        /// 
        /// <param name="getObjectTorrentRequest">Container for the necessary parameters to execute the GetObjectTorrent service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetObjectTorrent service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetObjectTorrentResponse> GetObjectTorrentAsync(GetObjectTorrentRequest getObjectTorrentRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetObjectTorrentRequestMarshaller();
            var unmarshaller = GetObjectTorrentResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetObjectTorrentRequest, GetObjectTorrentResponse>(getObjectTorrentRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request)
        {
            var task = InitiateMultipartUploadAsync(request);
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
        /// <para>Initiates a multipart upload and returns an upload ID.</para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// After you initiate a multipart upload and upload one or more parts, you must either complete or abort
        /// the multipart upload in order to stop getting charged for storage of the uploaded parts. Once you
        /// complete or abort the multipart upload, Amazon S3 will release the stored parts and stop charging you
        /// for their storage.
        /// </para>
        /// </remarks>
        /// <param name="initiateMultipartUploadRequest">Container for the necessary parameters to execute the InitiateMultipartUpload service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(InitiateMultipartUploadRequest initiateMultipartUploadRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new InitiateMultipartUploadRequestMarshaller();
            var unmarshaller = InitiateMultipartUploadResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, InitiateMultipartUploadRequest, InitiateMultipartUploadResponse>(initiateMultipartUploadRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListBucketsResponse ListBuckets(ListBucketsRequest request)
        {
            var task = ListBucketsAsync(request);
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
        /// <para>Returns a list of all buckets owned by the authenticated sender of the request.</para>
        /// </summary>
        /// 
        /// <param name="listBucketsRequest">Container for the necessary parameters to execute the ListBuckets service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the ListBuckets service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListBucketsResponse> ListBucketsAsync(ListBucketsRequest listBucketsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListBucketsRequestMarshaller();
            var unmarshaller = ListBucketsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListBucketsRequest, ListBucketsResponse>(listBucketsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest request)
        {
            var task = ListMultipartUploadsAsync(request);
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
        /// <para>This operation lists in-progress multipart uploads.</para>
        /// </summary>
        /// 
        /// <param name="listMultipartUploadsRequest">Container for the necessary parameters to execute the ListMultipartUploads service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(ListMultipartUploadsRequest listMultipartUploadsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListMultipartUploadsRequestMarshaller();
            var unmarshaller = ListMultipartUploadsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListMultipartUploadsRequest, ListMultipartUploadsResponse>(listMultipartUploadsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListObjectsResponse ListObjects(ListObjectsRequest request)
        {
            var task = ListObjectsAsync(request);
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
        /// <para>Returns some or all (up to 1000) of the objects in a bucket. You can use the request parameters as selection criteria to return a
        /// subset of the objects in a bucket.</para>
        /// </summary>
        /// 
        /// <param name="listObjectsRequest">Container for the necessary parameters to execute the ListObjects service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListObjectsResponse> ListObjectsAsync(ListObjectsRequest listObjectsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListObjectsRequestMarshaller();
            var unmarshaller = ListObjectsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListObjectsRequest, ListObjectsResponse>(listObjectsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListPartsResponse ListParts(ListPartsRequest request)
        {
            var task = ListPartsAsync(request);
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
        /// <para>Lists the parts that have been uploaded for a specific multipart upload.</para>
        /// </summary>
        /// 
        /// <param name="listPartsRequest">Container for the necessary parameters to execute the ListParts service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the ListParts service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListPartsResponse> ListPartsAsync(ListPartsRequest listPartsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListPartsRequestMarshaller();
            var unmarshaller = ListPartsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListPartsRequest, ListPartsResponse>(listPartsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ListVersionsResponse ListVersions(ListVersionsRequest request)
        {
            var task = ListVersionsAsync(request);
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
        /// <para>Returns metadata about all of the versions of objects in a bucket.</para>
        /// </summary>
        /// 
        /// <param name="listVersionsRequest">Container for the necessary parameters to execute the ListVersions service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest listVersionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListVersionsRequestMarshaller();
            var unmarshaller = ListVersionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListVersionsRequest, ListVersionsResponse>(listVersionsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal PutACLResponse PutACL(PutACLRequest request)
        {
            var task = PutACLAsync(request);
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
        /// <para>uses the acl subresource to set the access control list (ACL) permissions for an object that already exists in a bucket</para>
        /// </summary>
        /// 
        /// <param name="putACLRequest">Container for the necessary parameters to execute the PutObjectAcl service method on AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<PutACLResponse> PutACLAsync(PutACLRequest putACLRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutACLRequestMarshaller();
            var unmarshaller = PutACLResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PutACLRequest, PutACLResponse>(putACLRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal PutBucketResponse PutBucket(PutBucketRequest request)
        {
            var task = PutBucketAsync(request);
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
        /// <para>Creates a new bucket.</para>
        /// </summary>
        /// 
        /// <param name="putBucketRequest">Container for the necessary parameters to execute the PutBucket service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the PutBucket service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<PutBucketResponse> PutBucketAsync(PutBucketRequest putBucketRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketRequestMarshaller();
            var unmarshaller = PutBucketResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PutBucketRequest, PutBucketResponse>(putBucketRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal PutBucketLoggingResponse PutBucketLogging(PutBucketLoggingRequest request)
        {
            var task = PutBucketLoggingAsync(request);
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
        /// <para>Set the logging parameters for a bucket and to specify permissions for who can view and modify the logging parameters. To set the
        /// logging status of a bucket, you must be the bucket owner.</para>
        /// </summary>
        /// 
        /// <param name="putBucketLoggingRequest">Container for the necessary parameters to execute the PutBucketLogging service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<PutBucketLoggingResponse> PutBucketLoggingAsync(PutBucketLoggingRequest putBucketLoggingRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketLoggingRequestMarshaller();
            var unmarshaller = PutBucketLoggingResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PutBucketLoggingRequest, PutBucketLoggingResponse>(putBucketLoggingRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal PutBucketNotificationResponse PutBucketNotification(PutBucketNotificationRequest request)
        {
            var task = PutBucketNotificationAsync(request);
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
        /// <para>Enables notifications of specified events for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="putBucketNotificationRequest">Container for the necessary parameters to execute the PutBucketNotification service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<PutBucketNotificationResponse> PutBucketNotificationAsync(PutBucketNotificationRequest putBucketNotificationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketNotificationRequestMarshaller();
            var unmarshaller = PutBucketNotificationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PutBucketNotificationRequest, PutBucketNotificationResponse>(putBucketNotificationRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal PutBucketPolicyResponse PutBucketPolicy(PutBucketPolicyRequest request)
        {
            var task = PutBucketPolicyAsync(request);
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
        /// <para>Replaces a policy on a bucket. If the bucket already has a policy, the one in this request completely replaces it.</para>
        /// </summary>
        /// 
        /// <param name="putBucketPolicyRequest">Container for the necessary parameters to execute the PutBucketPolicy service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<PutBucketPolicyResponse> PutBucketPolicyAsync(PutBucketPolicyRequest putBucketPolicyRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketPolicyRequestMarshaller();
            var unmarshaller = PutBucketPolicyResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PutBucketPolicyRequest, PutBucketPolicyResponse>(putBucketPolicyRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal PutBucketRequestPaymentResponse PutBucketRequestPayment(PutBucketRequestPaymentRequest request)
        {
            var task = PutBucketRequestPaymentAsync(request);
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
        /// <para>Sets the request payment configuration for a bucket. By default, the bucket owner pays for downloads from the bucket. This
        /// configuration parameter enables the bucket owner (only) to specify that the person requesting the download will be charged for the
        /// download.</para>
        /// </summary>
        /// 
        /// <param name="putBucketRequestPaymentRequest">Container for the necessary parameters to execute the PutBucketRequestPayment service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<PutBucketRequestPaymentResponse> PutBucketRequestPaymentAsync(PutBucketRequestPaymentRequest putBucketRequestPaymentRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketRequestPaymentRequestMarshaller();
            var unmarshaller = PutBucketRequestPaymentResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PutBucketRequestPaymentRequest, PutBucketRequestPaymentResponse>(putBucketRequestPaymentRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal PutBucketTaggingResponse PutBucketTagging(PutBucketTaggingRequest request)
        {
            var task = PutBucketTaggingAsync(request);
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
        /// <para>Sets the tags for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="putBucketTaggingRequest">Container for the necessary parameters to execute the PutBucketTagging service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<PutBucketTaggingResponse> PutBucketTaggingAsync(PutBucketTaggingRequest putBucketTaggingRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketTaggingRequestMarshaller();
            var unmarshaller = PutBucketTaggingResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PutBucketTaggingRequest, PutBucketTaggingResponse>(putBucketTaggingRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal PutBucketVersioningResponse PutBucketVersioning(PutBucketVersioningRequest request)
        {
            var task = PutBucketVersioningAsync(request);
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
        /// <para>Puts the versioning state of an existing bucket. To set the versioning state, you must be the bucket owner.</para>
        /// </summary>
        /// 
        /// <param name="putBucketVersioningRequest">Container for the necessary parameters to execute the PutBucketVersioning service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<PutBucketVersioningResponse> PutBucketVersioningAsync(PutBucketVersioningRequest putBucketVersioningRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketVersioningRequestMarshaller();
            var unmarshaller = PutBucketVersioningResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PutBucketVersioningRequest, PutBucketVersioningResponse>(putBucketVersioningRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal PutBucketWebsiteResponse PutBucketWebsite(PutBucketWebsiteRequest request)
        {
            var task = PutBucketWebsiteAsync(request);
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
        /// <para>Set the website configuration for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="putBucketWebsiteRequest">Container for the necessary parameters to execute the PutBucketWebsite service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<PutBucketWebsiteResponse> PutBucketWebsiteAsync(PutBucketWebsiteRequest putBucketWebsiteRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutBucketWebsiteRequestMarshaller();
            var unmarshaller = PutBucketWebsiteResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PutBucketWebsiteRequest, PutBucketWebsiteResponse>(putBucketWebsiteRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal PutCORSConfigurationResponse PutCORSConfiguration(PutCORSConfigurationRequest request)
        {
            var task = PutCORSConfigurationAsync(request);
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
        /// <para>Sets the cors configuration for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="putCORSConfigurationRequest">Container for the necessary parameters to execute the PutCORSConfiguration service method on AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<PutCORSConfigurationResponse> PutCORSConfigurationAsync(PutCORSConfigurationRequest putCORSConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutCORSConfigurationRequestMarshaller();
            var unmarshaller = PutCORSConfigurationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PutCORSConfigurationRequest, PutCORSConfigurationResponse>(putCORSConfigurationRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal PutLifecycleConfigurationResponse PutLifecycleConfiguration(PutLifecycleConfigurationRequest request)
        {
            var task = PutLifecycleConfigurationAsync(request);
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
        /// <para>Sets lifecycle configuration for your bucket. If a lifecycle configuration exists, it replaces it.</para>
        /// </summary>
        /// 
        /// <param name="putLifecycleConfigurationRequest">Container for the necessary parameters to execute the PutLifecycleConfiguration service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<PutLifecycleConfigurationResponse> PutLifecycleConfigurationAsync(PutLifecycleConfigurationRequest putLifecycleConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutLifecycleConfigurationRequestMarshaller();
            var unmarshaller = PutLifecycleConfigurationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PutLifecycleConfigurationRequest, PutLifecycleConfigurationResponse>(putLifecycleConfigurationRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal PutObjectResponse PutObject(PutObjectRequest request)
        {
            var task = PutObjectAsync(request);
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
        /// <para>Adds an object to a bucket.</para>
        /// </summary>
        /// 
        /// <param name="putObjectRequest">Container for the necessary parameters to execute the PutObject service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the PutObject service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<PutObjectResponse> PutObjectAsync(PutObjectRequest putObjectRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutObjectRequestMarshaller();
            var unmarshaller = PutObjectResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PutObjectRequest, PutObjectResponse>(putObjectRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal RestoreObjectResponse RestoreObject(RestoreObjectRequest request)
        {
            var task = RestoreObjectAsync(request);
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
        /// <para>Restores an archived copy of an object back into Amazon S3</para>
        /// </summary>
        /// 
        /// <param name="restoreObjectRequest">Container for the necessary parameters to execute the RestoreObject service method on AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<RestoreObjectResponse> RestoreObjectAsync(RestoreObjectRequest restoreObjectRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestoreObjectRequestMarshaller();
            var unmarshaller = RestoreObjectResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RestoreObjectRequest, RestoreObjectResponse>(restoreObjectRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal UploadPartResponse UploadPart(UploadPartRequest request)
        {
            var task = UploadPartAsync(request);
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
        /// <para>Uploads a part in a multipart upload.</para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// After you initiate a multipart upload and upload one or more parts, you must either complete or abort
        /// the multipart upload in order to stop getting charged for storage of the uploaded parts. Once you
        /// complete or abort the multipart upload, Amazon S3 will release the stored parts and stop charging you
        /// for their storage.
        /// </para>
        /// </remarks>
        /// <param name="uploadPartRequest">Container for the necessary parameters to execute the UploadPart service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the UploadPart service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<UploadPartResponse> UploadPartAsync(UploadPartRequest uploadPartRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UploadPartRequestMarshaller();
            var unmarshaller = UploadPartResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UploadPartRequest, UploadPartResponse>(uploadPartRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
    }
}

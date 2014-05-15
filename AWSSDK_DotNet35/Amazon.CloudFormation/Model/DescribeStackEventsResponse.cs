/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Returns information about the  DescribeStackEvents response and response metadata.
    /// </summary>
    public partial class DescribeStackEventsResponse : DescribeStackEventsResult
    {
        /// <summary>
        /// Gets and sets the DescribeStackEventsResult property.
        /// The output for a DescribeStackEvents action.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the DescribeStackEventsResult class are now available on the DescribeStackEventsResponse class. You should use the properties on DescribeStackEventsResponse instead of accessing them through DescribeStackEventsResult.")]
        public DescribeStackEventsResult DescribeStackEventsResult
        {
            get
            {
                return this;
            }
        }
    }
}
    

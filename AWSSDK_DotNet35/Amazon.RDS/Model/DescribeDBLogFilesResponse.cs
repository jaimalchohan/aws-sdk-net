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

/*
 * Do not modify this file. This file is generated from the rds-2014-09-01.normal.json service model.
 */

using System;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Configuration for accessing Amazon DescribeDBLogFiles service
    /// </summary>
    public partial class DescribeDBLogFilesResponse : DescribeDBLogFilesResult
    {
        /// <summary>
        /// Gets and sets the DescribeDBLogFilesResult property.
        /// Represents the output of a DescribeDBLogFiles operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the DescribeDBLogFilesResult class are now available on the DescribeDBLogFilesResponse class. You should use the properties on DescribeDBLogFilesResponse instead of accessing them through DescribeDBLogFilesResult.")]
        public DescribeDBLogFilesResult DescribeDBLogFilesResult
        {
            get
            {
                return this;
            }
        }
    }
}
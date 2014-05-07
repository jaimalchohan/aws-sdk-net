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
using System.IO;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// <para> This data type is used as a response element in the DescribeLoadBalancers action. For information about Elastic Load Balancing
    /// security groups, go to <a
    /// href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/elb-security-features.html#using-elb-security-groups" >Using
    /// Security Groups With Elastic Load Balancing</a> in the <i>Elastic Load Balancing Developer Guide</i> .
    /// </para>
    /// </summary>
    public partial class SourceSecurityGroup
    {
        
        private string ownerAlias;
        private string groupName;


        /// <summary>
        /// Owner of the source security group. Use this value for the <c>--source-group-user</c> parameter of the <c>ec2-authorize</c> command in the
        /// Amazon EC2 command line tool.
        ///  
        /// </summary>
        public string OwnerAlias
        {
            get { return this.ownerAlias; }
            set { this.ownerAlias = value; }
        }

        // Check to see if OwnerAlias property is set
        internal bool IsSetOwnerAlias()
        {
            return this.ownerAlias != null;
        }

        /// <summary>
        /// Name of the source security group. Use this value for the <c>--source-group</c> parameter of the <c>ec2-authorize</c> command in the Amazon
        /// EC2 command line tool.
        ///  
        /// </summary>
        public string GroupName
        {
            get { return this.groupName; }
            set { this.groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this.groupName != null;
        }
    }
}
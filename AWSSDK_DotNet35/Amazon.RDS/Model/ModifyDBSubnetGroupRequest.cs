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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBSubnetGroup operation.
    /// Modifies an existing DB subnet group. DB subnet groups must contain at least one
    /// subnet in at least two AZs in the region.
    /// </summary>
    public partial class ModifyDBSubnetGroupRequest : AmazonRDSRequest
    {
        private string _dBSubnetGroupDescription;
        private string _dBSubnetGroupName;
        private List<string> _subnetIds = new List<string>();

        /// <summary>
        /// Gets and sets the property DBSubnetGroupDescription. 
        /// <para>
        ///  The description for the DB subnet group. 
        /// </para>
        /// </summary>
        public string DBSubnetGroupDescription
        {
            get { return this._dBSubnetGroupDescription; }
            set { this._dBSubnetGroupDescription = value; }
        }

        // Check to see if DBSubnetGroupDescription property is set
        internal bool IsSetDBSubnetGroupDescription()
        {
            return this._dBSubnetGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        ///  The name for the DB subnet group. This value is stored as a lowercase string. 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must contain no more than 255 alphanumeric characters or hyphens. Must
        /// not be "Default".
        /// </para>
        ///  
        /// <para>
        /// Example: <code>mySubnetgroup</code>
        /// </para>
        /// </summary>
        public string DBSubnetGroupName
        {
            get { return this._dBSubnetGroupName; }
            set { this._dBSubnetGroupName = value; }
        }

        // Check to see if DBSubnetGroupName property is set
        internal bool IsSetDBSubnetGroupName()
        {
            return this._dBSubnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        ///  The EC2 subnet IDs for the DB subnet group. 
        /// </para>
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

    }
}
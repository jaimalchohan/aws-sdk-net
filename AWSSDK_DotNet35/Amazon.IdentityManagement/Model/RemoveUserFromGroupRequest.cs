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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveUserFromGroup operation.
    /// Removes the specified user from the specified group.
    /// </summary>
    public partial class RemoveUserFromGroupRequest : AmazonIdentityManagementServiceRequest
    {
        private string _groupName;
        private string _userName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RemoveUserFromGroupRequest() { }

        /// <summary>
        /// Instantiates RemoveUserFromGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="groupName">The name of the group to update.</param>
        /// <param name="userName">The name of the user to remove.</param>
        public RemoveUserFromGroupRequest(string groupName, string userName)
        {
            _groupName = groupName;
            _userName = userName;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the group to update.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user to remove.
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}
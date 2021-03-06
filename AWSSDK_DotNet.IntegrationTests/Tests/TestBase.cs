﻿using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    public class TestBase<T>
        where T : AmazonServiceClient, new()
    {
        private static T client;
        public static T Client
        {
            get
            {
                if(client == null)
                {
                    client = new T();

                    RetryUtilities.ConfigureClient(client);
                }
                return client;
            }
            set
            {
                client = value;
            }
        }

        public static void BaseClean()
        {
            if (client != null)
            {
                client.Dispose();
                client = null;
            }
        }
    }
}

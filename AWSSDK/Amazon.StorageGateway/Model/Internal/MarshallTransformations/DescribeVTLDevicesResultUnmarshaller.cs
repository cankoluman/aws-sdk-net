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
    using System.Collections.Generic;
    using System.IO;
    using Amazon.StorageGateway.Model;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// DescribeVTLDevicesResultUnmarshaller
      /// </summary>
      internal class DescribeVTLDevicesResultUnmarshaller : IUnmarshaller<DescribeVTLDevicesResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeVTLDevicesResult, JsonUnmarshallerContext>
      {
        DescribeVTLDevicesResult IUnmarshaller<DescribeVTLDevicesResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
          throw new NotImplementedException();
        }

        public DescribeVTLDevicesResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            DescribeVTLDevicesResult describeVTLDevicesResult = new DescribeVTLDevicesResult();
          describeVTLDevicesResult.VTLDevices = null;
                        
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                context.Read();
                context.Read();
              
              if (context.TestExpression("GatewayARN", targetDepth))
              {
                describeVTLDevicesResult.GatewayARN = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
              if (context.TestExpression("VTLDevices", targetDepth))
              {
                describeVTLDevicesResult.VTLDevices = new List<VTLDevice>();
                        VTLDeviceUnmarshaller unmarshaller = VTLDeviceUnmarshaller.GetInstance();
                while (context.Read())
                {
                  if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                  {
                     describeVTLDevicesResult.VTLDevices.Add(unmarshaller.Unmarshall(context));
                  }
                  else if (context.IsEndArray)
                  {
                    break;
                  }
                }
                continue;
              }
  
              if (context.TestExpression("Marker", targetDepth))
              {
                describeVTLDevicesResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                continue;
              }
  
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return describeVTLDevicesResult;
                }
            }
          

            return describeVTLDevicesResult;
        }

        private static DescribeVTLDevicesResultUnmarshaller instance;
        public static DescribeVTLDevicesResultUnmarshaller GetInstance()
        {
            if (instance == null)
                instance = new DescribeVTLDevicesResultUnmarshaller();
            return instance;
        }
    }
}
  

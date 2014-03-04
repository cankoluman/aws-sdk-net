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
    using System.Net;
    using Amazon.AWSSupport.Model;
    using Amazon.Runtime;
    using Amazon.Runtime.Internal;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// Response Unmarshaller for CreateCase operation
      /// </summary>
      internal class CreateCaseResponseUnmarshaller : JsonResponseUnmarshaller
      {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
          CreateCaseResponse response = new CreateCaseResponse();
          
          context.Read();
      
          response.CreateCaseResult = CreateCaseResultUnmarshaller.GetInstance().Unmarshall(context);
          
          return response;
        }
        
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
          ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
          
          if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerErrorException"))
          {
            InternalServerErrorException ex = new InternalServerErrorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            
            return ex;
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("CaseCreationLimitExceededException"))
          {
            CaseCreationLimitExceededException ex = new CaseCreationLimitExceededException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            
            return ex;
          }
  
          return new AmazonAWSSupportException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static CreateCaseResponseUnmarshaller instance;
        public static CreateCaseResponseUnmarshaller GetInstance()
        {
          if (instance == null)
          {
            instance = new CreateCaseResponseUnmarshaller();
          }
          return instance;
        }
  
      }
    }
  

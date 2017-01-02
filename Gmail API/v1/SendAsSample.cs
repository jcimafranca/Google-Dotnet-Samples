﻿// Copyright 2017 DAIMTO :  www.daimto.com
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by DAIMTO-Google-apis-Sample-generator 1.0.0
//     Template File Name:  Methodtemplate.tt
//     Build date: 01/02/2017 22:33:00
//     C# generater version: 1.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
  
// About 
// 
// Unoffical sample for the gmail v1 API for C#. 
// This sample is designed to be used with the Google .Net client library. (https://github.com/google/google-api-dotnet-client)
// 
// API Description: Access Gmail mailboxes including sending user email.
// API Documentation Link https://developers.google.com/gmail/api/
//
// Discovery Doc  https://www.googleapis.com/discovery/v1/apis/gmail/v1/rest
//
//------------------------------------------------------------------------------
// Installation
//
// This sample code uses the Google .Net client library 
//
// NuGet package:
//
// Location: https://www.nuget.org/packages/Google.Apis.gmail.v1/ 
// Install Command: PM>  Install-Package Google.Apis.gmail.v1
//
//------------------------------------------------------------------------------  
using Google.Apis.gmail.v1;
using Google.Apis.gmail.v1.Data;
using System;

namespace GoogleSamplecSharpSample.gmailv1.Methods
{
  
    public static class SendAsSample
    {


        /// <summary>
        /// Creates a custom "from" send-as alias. If an SMTP MSA is specified, Gmail will attempt to connect to the SMTP service to validate the configuration before creating the alias. If ownership verification is required for the alias, a message will be sent to the email address and the resource's verification status will be set to pending; otherwise, the resource will be created with verification status set to accepted. If a signature is provided, Gmail will sanitize the HTML before saving it with the alias. 
        /// Documentation https://developers.google.com/gmail/v1/reference/sendAs/create
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated gmail service.</param>  
        /// <param name="userId">User's email address. The special value "me" can be used to indicate the authenticated user.</param>
        /// <param name="body">A valid gmail v1 body.</param>
        /// <returns>SendAsResponse</returns>
        public static SendAs Create(gmailService service, string userId, SendAs body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Make the request.
                return service.SendAs.Create(body, userId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request SendAs.Create failed.", ex);
            }
        }


        /// <summary>
        /// Deletes the specified send-as alias. Revokes any verification that may have been required for using it. 
        /// Documentation https://developers.google.com/gmail/v1/reference/sendAs/delete
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated gmail service.</param>  
        /// <param name="userId">User's email address. The special value "me" can be used to indicate the authenticated user.</param>
        /// <param name="sendAsEmail">The send-as alias to be deleted.</param>
        public static void Delete(gmailService service, string userId, string sendAsEmail)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userId == null)
                    throw new ArgumentNullException(userId);
                if (sendAsEmail == null)
                    throw new ArgumentNullException(sendAsEmail);

                // Make the request.
                return service.SendAs.Delete(userId, sendAsEmail).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request SendAs.Delete failed.", ex);
            }
        }


        /// <summary>
        /// Gets the specified send-as alias. Fails with an HTTP 404 error if the specified address is not a member of the collection. 
        /// Documentation https://developers.google.com/gmail/v1/reference/sendAs/get
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated gmail service.</param>  
        /// <param name="userId">User's email address. The special value "me" can be used to indicate the authenticated user.</param>
        /// <param name="sendAsEmail">The send-as alias to be retrieved.</param>
        /// <returns>SendAsResponse</returns>
        public static SendAs Get(gmailService service, string userId, string sendAsEmail)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userId == null)
                    throw new ArgumentNullException(userId);
                if (sendAsEmail == null)
                    throw new ArgumentNullException(sendAsEmail);

                // Make the request.
                return service.SendAs.Get(userId, sendAsEmail).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request SendAs.Get failed.", ex);
            }
        }


        /// <summary>
        /// Lists the send-as aliases for the specified account. The result includes the primary send-as address associated with the account as well as any custom "from" aliases. 
        /// Documentation https://developers.google.com/gmail/v1/reference/sendAs/list
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated gmail service.</param>  
        /// <param name="userId">User's email address. The special value "me" can be used to indicate the authenticated user.</param>
        /// <returns>ListSendAsResponseResponse</returns>
        public static ListSendAsResponse List(gmailService service, string userId)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userId == null)
                    throw new ArgumentNullException(userId);

                // Make the request.
                return service.SendAs.List(userId).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request SendAs.List failed.", ex);
            }
        }


        /// <summary>
        /// Updates a send-as alias. If a signature is provided, Gmail will sanitize the HTML before saving it with the alias. This method supports patch semantics. 
        /// Documentation https://developers.google.com/gmail/v1/reference/sendAs/patch
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated gmail service.</param>  
        /// <param name="userId">User's email address. The special value "me" can be used to indicate the authenticated user.</param>
        /// <param name="sendAsEmail">The send-as alias to be updated.</param>
        /// <param name="body">A valid gmail v1 body.</param>
        /// <returns>SendAsResponse</returns>
        public static SendAs Patch(gmailService service, string userId, string sendAsEmail, SendAs body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (userId == null)
                    throw new ArgumentNullException(userId);
                if (sendAsEmail == null)
                    throw new ArgumentNullException(sendAsEmail);

                // Make the request.
                return service.SendAs.Patch(body, userId, sendAsEmail).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request SendAs.Patch failed.", ex);
            }
        }


        /// <summary>
        /// Updates a send-as alias. If a signature is provided, Gmail will sanitize the HTML before saving it with the alias. 
        /// Documentation https://developers.google.com/gmail/v1/reference/sendAs/update
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated gmail service.</param>  
        /// <param name="userId">User's email address. The special value "me" can be used to indicate the authenticated user.</param>
        /// <param name="sendAsEmail">The send-as alias to be updated.</param>
        /// <param name="body">A valid gmail v1 body.</param>
        /// <returns>SendAsResponse</returns>
        public static SendAs Update(gmailService service, string userId, string sendAsEmail, SendAs body)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (body == null)
                    throw new ArgumentNullException("body");
                if (userId == null)
                    throw new ArgumentNullException(userId);
                if (sendAsEmail == null)
                    throw new ArgumentNullException(sendAsEmail);

                // Make the request.
                return service.SendAs.Update(body, userId, sendAsEmail).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request SendAs.Update failed.", ex);
            }
        }


        /// <summary>
        /// Sends a verification email to the specified send-as alias address. The verification status must be pending. 
        /// Documentation https://developers.google.com/gmail/v1/reference/sendAs/verify
        /// Generation Note: This does not always build corectly.  Google needs to standardise things I need to figuer out which ones are wrong.
        /// </summary>
        /// <param name="service">Authenticated gmail service.</param>  
        /// <param name="userId">User's email address. The special value "me" can be used to indicate the authenticated user.</param>
        /// <param name="sendAsEmail">The send-as alias to be verified.</param>
        public static void Verify(gmailService service, string userId, string sendAsEmail)
        {
            try
            {
                // Initial validation.
                if (service == null)
                    throw new ArgumentNullException("service");
                if (userId == null)
                    throw new ArgumentNullException(userId);
                if (sendAsEmail == null)
                    throw new ArgumentNullException(sendAsEmail);

                // Make the request.
                return service.SendAs.Verify(userId, sendAsEmail).Execute();
            }
            catch (Exception ex)
            {
                throw new Exception("Request SendAs.Verify failed.", ex);
            }
        }

        
	}
		public static class SampleHelpers
    {

        /// <summary>
        /// Using reflection to apply optional parameters to the request.  
        /// 
        /// If the optonal parameters are null then we will just return the request as is.
        /// </summary>
        /// <param name="request">The request. </param>
        /// <param name="optional">The optional parameters. </param>
        /// <returns></returns>
        public static object ApplyOptionalParms(object request, object optional)
        {
            if (optional == null)
                return request;

            System.Reflection.PropertyInfo[] optionalProperties = (optional.GetType()).GetProperties();

            foreach (System.Reflection.PropertyInfo property in optionalProperties)
            {
                // Copy value from optional parms to the request.  They should have the same names and datatypes.
                System.Reflection.PropertyInfo piShared = (request.GetType()).GetProperty(property.Name);
				if (property.GetValue(optional, null) != null) // TODO Test that we do not add values for items that are null
					piShared.SetValue(request, property.GetValue(optional, null), null);
            }

            return request;
        }
    }
}
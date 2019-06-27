/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Sts.V20180813
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Sts.V20180813.Models;

   public class StsClient : AbstractClient{

       private const string endpoint = "sts.tencentcloudapi.com";
       private const string version = "2018-08-13";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public StsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public StsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 申请扮演角色
        /// </summary>
        /// <param name="req">参考<see cref="AssumeRoleRequest"/></param>
        /// <returns>参考<see cref="AssumeRoleResponse"/>实例</returns>
        public async Task<AssumeRoleResponse> AssumeRole(AssumeRoleRequest req)
        {
             JsonResponseModel<AssumeRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssumeRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssumeRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AssumeRoleWithSAML）用于根据 SAML 断言申请角色临时凭证。
        /// </summary>
        /// <param name="req">参考<see cref="AssumeRoleWithSAMLRequest"/></param>
        /// <returns>参考<see cref="AssumeRoleWithSAMLResponse"/>实例</returns>
        public async Task<AssumeRoleWithSAMLResponse> AssumeRoleWithSAML(AssumeRoleWithSAMLRequest req)
        {
             JsonResponseModel<AssumeRoleWithSAMLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssumeRoleWithSAML");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssumeRoleWithSAMLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取联合身份临时访问凭证
        /// </summary>
        /// <param name="req">参考<see cref="GetFederationTokenRequest"/></param>
        /// <returns>参考<see cref="GetFederationTokenResponse"/>实例</returns>
        public async Task<GetFederationTokenResponse> GetFederationToken(GetFederationTokenRequest req)
        {
             JsonResponseModel<GetFederationTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetFederationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFederationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

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

namespace TencentCloud.Tiems.V20190416
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tiems.V20190416.Models;

   public class TiemsClient : AbstractClient{

       private const string endpoint = "tiems.tencentcloudapi.com";
       private const string version = "2019-04-16";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public TiemsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public TiemsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建服务
        /// </summary>
        /// <param name="req">参考<see cref="CreateServiceRequest"/></param>
        /// <returns>参考<see cref="CreateServiceResponse"/>实例</returns>
        public async Task<CreateServiceResponse> CreateService(CreateServiceRequest req)
        {
             JsonResponseModel<CreateServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建服务配置
        /// </summary>
        /// <param name="req">参考<see cref="CreateServiceConfigRequest"/></param>
        /// <returns>参考<see cref="CreateServiceConfigResponse"/>实例</returns>
        public async Task<CreateServiceConfigResponse> CreateServiceConfig(CreateServiceConfigRequest req)
        {
             JsonResponseModel<CreateServiceConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateServiceConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateServiceConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除服务
        /// </summary>
        /// <param name="req">参考<see cref="DeleteServiceRequest"/></param>
        /// <returns>参考<see cref="DeleteServiceResponse"/>实例</returns>
        public async Task<DeleteServiceResponse> DeleteService(DeleteServiceRequest req)
        {
             JsonResponseModel<DeleteServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除服务配置
        /// </summary>
        /// <param name="req">参考<see cref="DeleteServiceConfigRequest"/></param>
        /// <returns>参考<see cref="DeleteServiceConfigResponse"/>实例</returns>
        public async Task<DeleteServiceConfigResponse> DeleteServiceConfig(DeleteServiceConfigRequest req)
        {
             JsonResponseModel<DeleteServiceConfigResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteServiceConfig");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteServiceConfigResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述服务运行环境
        /// </summary>
        /// <param name="req">参考<see cref="DescribeRuntimesRequest"/></param>
        /// <returns>参考<see cref="DescribeRuntimesResponse"/>实例</returns>
        public async Task<DescribeRuntimesResponse> DescribeRuntimes(DescribeRuntimesRequest req)
        {
             JsonResponseModel<DescribeRuntimesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRuntimes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRuntimesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述服务配置
        /// </summary>
        /// <param name="req">参考<see cref="DescribeServiceConfigsRequest"/></param>
        /// <returns>参考<see cref="DescribeServiceConfigsResponse"/>实例</returns>
        public async Task<DescribeServiceConfigsResponse> DescribeServiceConfigs(DescribeServiceConfigsRequest req)
        {
             JsonResponseModel<DescribeServiceConfigsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServiceConfigs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServiceConfigsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 描述服务
        /// </summary>
        /// <param name="req">参考<see cref="DescribeServicesRequest"/></param>
        /// <returns>参考<see cref="DescribeServicesResponse"/>实例</returns>
        public async Task<DescribeServicesResponse> DescribeServices(DescribeServicesRequest req)
        {
             JsonResponseModel<DescribeServicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeServices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeServicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新服务
        /// </summary>
        /// <param name="req">参考<see cref="UpdateServiceRequest"/></param>
        /// <returns>参考<see cref="UpdateServiceResponse"/>实例</returns>
        public async Task<UpdateServiceResponse> UpdateService(UpdateServiceRequest req)
        {
             JsonResponseModel<UpdateServiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateService");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateServiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

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

namespace TencentCloud.Ticm.V20181127
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ticm.V20181127.Models;

   public class TicmClient : AbstractClient{

       private const string endpoint = "ticm.tencentcloudapi.com";
       private const string version = "2018-11-27";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TicmClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TicmClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 提交完视频审核任务后，可以通过本接口来获取当前处理的进度和结果
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoTaskRequest"/></param>
        /// <returns><see cref="DescribeVideoTaskResponse"/></returns>
        public async Task<DescribeVideoTaskResponse> DescribeVideoTask(DescribeVideoTaskRequest req)
        {
             JsonResponseModel<DescribeVideoTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVideoTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交完视频审核任务后，可以通过本接口来获取当前处理的进度和结果
        /// </summary>
        /// <param name="req"><see cref="DescribeVideoTaskRequest"/></param>
        /// <returns><see cref="DescribeVideoTaskResponse"/></returns>
        public DescribeVideoTaskResponse DescribeVideoTaskSync(DescribeVideoTaskRequest req)
        {
             JsonResponseModel<DescribeVideoTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVideoTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVideoTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口提供多种维度的图像审核能力，支持色情和性感内容识别，政治人物和涉政敏感场景识别，以及暴恐人物、场景、旗帜标识等违禁内容的识别。
        /// </summary>
        /// <param name="req"><see cref="ImageModerationRequest"/></param>
        /// <returns><see cref="ImageModerationResponse"/></returns>
        public async Task<ImageModerationResponse> ImageModeration(ImageModerationRequest req)
        {
             JsonResponseModel<ImageModerationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ImageModeration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImageModerationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口提供多种维度的图像审核能力，支持色情和性感内容识别，政治人物和涉政敏感场景识别，以及暴恐人物、场景、旗帜标识等违禁内容的识别。
        /// </summary>
        /// <param name="req"><see cref="ImageModerationRequest"/></param>
        /// <returns><see cref="ImageModerationResponse"/></returns>
        public ImageModerationResponse ImageModerationSync(ImageModerationRequest req)
        {
             JsonResponseModel<ImageModerationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ImageModeration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ImageModerationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口提供多种维度的视频审核能力，支持色情和性感内容识别，政治人物和涉政敏感场景识别，以及暴恐人物、场景、旗帜标识等违禁内容的识别。
        /// </summary>
        /// <param name="req"><see cref="VideoModerationRequest"/></param>
        /// <returns><see cref="VideoModerationResponse"/></returns>
        public async Task<VideoModerationResponse> VideoModeration(VideoModerationRequest req)
        {
             JsonResponseModel<VideoModerationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VideoModeration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VideoModerationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口提供多种维度的视频审核能力，支持色情和性感内容识别，政治人物和涉政敏感场景识别，以及暴恐人物、场景、旗帜标识等违禁内容的识别。
        /// </summary>
        /// <param name="req"><see cref="VideoModerationRequest"/></param>
        /// <returns><see cref="VideoModerationResponse"/></returns>
        public VideoModerationResponse VideoModerationSync(VideoModerationRequest req)
        {
             JsonResponseModel<VideoModerationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VideoModeration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VideoModerationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}

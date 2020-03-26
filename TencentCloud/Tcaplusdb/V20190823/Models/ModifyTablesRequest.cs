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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTablesRequest : AbstractModel
    {
        
        /// <summary>
        /// 待修改表格所在集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 选中的改表IDL文件
        /// </summary>
        [JsonProperty("IdlFiles")]
        public IdlFileInfo[] IdlFiles{ get; set; }

        /// <summary>
        /// 待改表格列表
        /// </summary>
        [JsonProperty("SelectedTables")]
        public SelectedTableInfoNew[] SelectedTables{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArrayObj(map, prefix + "IdlFiles.", this.IdlFiles);
            this.SetParamArrayObj(map, prefix + "SelectedTables.", this.SelectedTables);
        }
    }
}

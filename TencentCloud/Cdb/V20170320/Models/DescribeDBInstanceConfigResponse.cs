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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBInstanceConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// 主库数据保护方式，主实例属性，可能的返回值：0-异步复制方式，1-半同步复制方式，2-强同步复制方式。
        /// </summary>
        [JsonProperty("ProtectMode")]
        public long? ProtectMode{ get; set; }

        /// <summary>
        /// 主库部署方式，主实例属性，可能的返回值：0-单可用部署，1-多可用区部署。
        /// </summary>
        [JsonProperty("DeployMode")]
        public long? DeployMode{ get; set; }

        /// <summary>
        /// 主库可用区的正式名称，如ap-shanghai-1。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 从库的配置信息。
        /// </summary>
        [JsonProperty("SlaveConfig")]
        public SlaveConfig SlaveConfig{ get; set; }

        /// <summary>
        /// ECDB第二个从库的配置信息，只有ECDB实例才有这个字段。
        /// </summary>
        [JsonProperty("BackupConfig")]
        public BackupConfig BackupConfig{ get; set; }

        /// <summary>
        /// 唯一请求ID，每次请求都会返回。定位问题时需要提供该次请求的RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProtectMode", this.ProtectMode);
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamObj(map, prefix + "SlaveConfig.", this.SlaveConfig);
            this.SetParamObj(map, prefix + "BackupConfig.", this.BackupConfig);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


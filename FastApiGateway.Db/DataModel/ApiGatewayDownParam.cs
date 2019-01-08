﻿using FastData.Core.Property;
using System;

namespace FastApiGatewayDb.DataModel
{
    /// <summary>
    /// 下游请求表
    /// </summary>
    [Table(Comments = "下游请求表")]
    public class ApiGatewayDownParam
    {
        /// <summary>
        /// key
        /// </summary>
        [Column(Comments = "接口key", DataType = "varchar2", Length = 16, IsNull = false)]
        public string Key { get; set; }
        
        /// <summary>
        /// 下游url
        /// </summary>
        [Column(Comments = "下游url", DataType = "varchar2", Length = 255, IsNull = false)]
        public string Url { get; set; }

        /// <summary>
        /// 下游名称
        /// </summary>
        [Column(Comments = "下游名称", DataType = "varchar2", Length = 128, IsNull = true)]
        public string Name { get; set; }

        /// <summary>
        /// 请求方法method
        /// </summary>
        [Column(Comments = "请求方法method", DataType = "varchar2", Length = 12, IsNull = true)]
        public string Method { get; set; }

        /// <summary>
        /// is body action
        /// </summary>
        [Column(Comments = "is body action 1=是 0=否", DataType = "number(1,0)", IsNull = true)]
        public int IsBody { get; set; }

        /// <summary>
        /// 无响应等待下次请求时间(小时单位)
        /// </summary>
        [Column(Comments = "无响应等待下次请求时间(小时单位)", DataType = "varchar2", Length = 2, IsNull = true)]
        public string WaitHour { get; set; }

        /// <summary>
        /// 协议soap,http
        /// </summary>
        [Column(Comments = "协议soap,http", DataType = "varchar2", Length = 8, IsNull = true)]
        public string Protocol { get; set; }

        /// <summary>
        /// soap method
        /// </summary>
        [Column(Comments = "soap method", DataType = "varchar2", Length = 32, IsNull = true)]
        public string SoapMethod { get; set; }
        
        /// <summary>
        /// soap param name,| 隔开 
        /// </summary>
        [Column(Comments = "soap param name", DataType = "varchar2", Length = 255, IsNull = true)]
        public string SoapParamName { get; set; }
    }
}

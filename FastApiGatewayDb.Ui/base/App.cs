﻿using System.Collections.Generic;
using System;
using FastData.Core.Context;
using FastData.Core;
using FastApiGatewayDb.DataModel;
using FastUntility.Core.Base;

namespace App
{
    public static class User
    {
        public static Dictionary<string, object> Info
        {
            get
            {
                using (var db = new DataContext(DbKey.Api))
                {
                    var dic = new Dictionary<string, object>();

                    dic.Add("api", FastRead.Query<ApiGatewayUrl>(a => a.Key != "").ToCount(db));
                    dic.Add("route", FastRead.Query<ApiGatewayDownParam>(a => a.Key != "").ToCount(db));
                    dic.Add("user", FastRead.Query<ApiGatewayUser>(a => a.AppKey != "").ToCount(db));
                    dic.Add("cache", FastRead.Query<ApiGatewayCache>(a => a.Key != "").ToCount(db));
                    dic.Add("exception", FastRead.Query<ApiGatewayWait>(a => a.Key != "".ToDecimal(0).ToStr()).ToCount(db));
                    dic.Add("day", FastRead.Query<ApiGatewayLog>(a => a.ActionTime >= DateTime.Now.ToDate("yyyy-MM-dd").ToDate()).ToCount(db));

                    return dic;
                }
            }
        }
    }

    public static class DbKey
    {
        public readonly static string Api = "ApiGateway";
    }

}

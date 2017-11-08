using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserMS.Util
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserOrderEnum
    {
        Id,
        Code,
        Name,
        Address,
        UserTypeId
    }
}
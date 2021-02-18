using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeDecor.Common
{
    public static class WebUtil
    {
        
        public static readonly int ADMIN_ROLE = 1;
        public static readonly int USER_ROLE = 3;
        public static readonly int SELLER_ROLE = 2;
        public static readonly string CURRENT_USER = "CurrentUser";
        public static readonly string CURRENT_SELLER = "CurrentSeller";
        public static readonly string MY_CART="carter";

        public static void Set<T>(this ISession session, string key, T value)
        {
            string jsonData = JsonConvert.SerializeObject(value);
            session.SetString(key, jsonData);
        }

        public static T Get<T>(this ISession session, string key)
        {
          
            string jsonData = session.GetString(key);
            if (string.IsNullOrEmpty(jsonData)) return default;
            return JsonConvert.DeserializeObject<T>(jsonData);
        }

    }
}

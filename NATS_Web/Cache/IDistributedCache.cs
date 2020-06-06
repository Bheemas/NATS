using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NATS_Web.Cache
{
    public interface IDistributedCache
    {
        byte[] Get(string key);
        void Refresh(string key);
        void Remove(string key);
        void Set(string key, byte[] value,
        DistributedCacheEntryOptions options);
    }
}

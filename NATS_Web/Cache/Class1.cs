using Alachisoft.NCache.Web.Caching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NATS_Web.Cache
{
    public class Author
    {
        private Alachisoft.NCache.Web.Caching.Cache _cache;

        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public async Task<Author> GetAuthor(int id)
        {             
             _cache = NCache.InitializeCache("CacheName");
            var cacheKey = "Key";
            Author author = null;
            if (_cache != null)
            {
                author = _cache.Get(cacheKey) as Author;
            }
            if (author == null) //Data not available in the cache
            {
                //Write code here to fetch the author
                // object from the database
                if (author != null)
                {
                    if (_cache != null)
                    {
                        _cache.Insert(cacheKey, author, null,
                         Alachisoft.NCache.Web.Caching.Cache.NoAbsoluteExpiration,
                         TimeSpan.FromMinutes(10),
                         Alachisoft.NCache.Runtime.
                         CacheItemPriority.Default);
                    }
                }
            }
            return author;
        }
    }
}

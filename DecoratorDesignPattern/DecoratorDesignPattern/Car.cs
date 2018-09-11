using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;


namespace DecoratorDesignPattern
{
    class Car : ICar
    {
        private const string CacheKey = "carPrice";
        public string Name
        {
            get { return "Audi"; }
        }
        public double Price()
        {
            return GetPrice(); //From Cache
        }

        public int GetPrice()
        {
            ObjectCache cache = MemoryCache.Default;

            if (cache.Contains(CacheKey))
                return Convert.ToInt32(cache.Get(CacheKey));
            else
            {
                int storedPrice = this.GetStoredPrice();

                // Store data in the cache
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddHours(1.0);
                cache.Add(CacheKey, storedPrice, cacheItemPolicy);

                return storedPrice;
            }
        }
        public int GetStoredPrice()
        {
            return 800000;
        }
    }
}

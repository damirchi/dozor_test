using System;
using System.Collections.Generic;

namespace GFK.Business
{
    public static class LoadUtils
    {
        public static IEnumerable<T> LoadSrollable<T>( int scrollSize, Func<int,int,IEnumerable<T>> loadRange)
        {
            var current = 0;
            
            do
            {
                var range = loadRange(current, scrollSize);
                var notEmpty = false;
                foreach (var entity in range)
                {
                    notEmpty = true;
                    yield return entity;
                }

                if (!notEmpty)
                    break;

                current += scrollSize;

            } while (true);
        }
    }
}
/*
 * Created by: 
 * Created: Wednesday, May 30, 2007
 */

using System;
using Chain.Business.Domain.Entity;
using Chain.Common.Services;
using GFK.Business.Domain.Dictionaries;

namespace GFK.Business
{
    public static class EntityUtils
    {
        public static TC Cast<TC>(this IEntity entity)
            where TC : class
        {
            if (entity == null)
                return null;
            return (TC)entity.GetSelf();
        }

		public static bool Is<TC>(this IEntity entity)
			where TC : class
		{
			if (entity == null)
				return false;
			return entity.GetSelf() is TC;
		}

        public static string TraceString(this IEntity entity)
        {
            if (entity == null)
                return "[null]";
            return "[" + entity.GetType() + "#" + entity.GetId() + "]";
        }

        public static TEnum? StatusValue<TEnum, TStatus>(TStatus statusValue)
            where TEnum : struct
            where TStatus : BaseEntity<int>
        {
            if(statusValue == null)
                return null;
            return (TEnum)(object)statusValue.Id;
        }

        public static TStatus StatusValue<TStatus, TEnum>(TEnum? enumValue)
            where TEnum : struct
            where TStatus : BaseEntity<int>
        {
            if (enumValue == null)
                return null;
            return Locator.GetService<IDictionariesManager>().GetDictionaryElement<TStatus, int>((int)(object)enumValue);
        }

    }
}
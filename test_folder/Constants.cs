using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace GFK.Business
{
    public class Constants
    {

		/// <summary>
		/// min value of DateTime type for business objects
		/// </summary>
		public static readonly DateTime DateTimeMinValue = SqlDateTime.MinValue.Value;
		
		/// <summary>
		/// max value of DateTime type for business objects
		/// </summary>
		public static readonly DateTime DateTimeMaxValue = SqlDateTime.MaxValue.Value;


		public static DateTime GetValidDateTime(DateTime v)
		{
			if (v < Constants.DateTimeMinValue) 
			    return Constants.DateTimeMinValue;
			else if (v > Constants.DateTimeMaxValue) 
			    v = Constants.DateTimeMaxValue;
			return v;			
		}        
    }
}

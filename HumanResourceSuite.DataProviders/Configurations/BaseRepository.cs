using System;
using System.Collections.Generic;
using System.Text;

namespace HumanResourceSuite.DataProviders.Configurations
{
    public class BaseRepository
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        protected int GetIntegerValue(object value)
        {
            int _value = 0;
            if (value == DBNull.Value)
            {
                _value = 0;
            }
            else
            {
                Int32.TryParse(Convert.ToString(value), out _value);
            }

            return _value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        protected string GetStringValue(object value)
        {
            string _value = string.Empty;
            if (value == DBNull.Value)
            {
                return string.Empty;
            }
            else
            {
                _value = Convert.ToString(value);
            }
            return _value;
        }
        /// <summary>
        /// Date Time Value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        protected DateTime GetDateTimeValue(object value)
        {
            DateTime _value = default(DateTime);
            if (value == DBNull.Value)
            {
                return default(DateTime);
            }
            else
            {
                DateTime.TryParse(Convert.ToString(value), out _value);
            }

            return _value;
        }

        protected bool GetBitValue(object value)
        {
            bool _value = false;
            if (value == DBNull.Value)
            {
                return false;
            }
            else
            {
                bool.TryParse(Convert.ToString(value), out _value);
            }

            return _value;
        }

    }
}

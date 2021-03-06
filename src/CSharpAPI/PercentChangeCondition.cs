﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace IBApi
{
    /**
    * @brief Used with conditional orders to place or submit an order based on a percentage change of an instrument to the last close price.
    */
    public class PercentChangeCondition : ContractCondition
    {
        
        protected override string Value
        {
            get
            {
                return ChangePercent.ToString();
            }
            set
            {
                ChangePercent = decimal.Parse(value, NumberStyles.Float, NumberFormatInfo.InvariantInfo);
            }           
        }

        public decimal ChangePercent { get; set; }
    }
}

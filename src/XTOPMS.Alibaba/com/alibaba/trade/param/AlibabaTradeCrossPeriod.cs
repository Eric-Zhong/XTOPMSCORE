using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.trade.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaTradeCrossPeriod {

       [DataMember(Order = 1)]
    private int? tapType;
    
        /**
       * @return 账期的类型,1：一个月指定日期结算一次，3：两个月指定日期结算一次，6：三个月指定日期结算一次，5：按收货时间和账期日期结算
    */
        public int? getTapType() {
               	return tapType;
            }
    
    /**
     * 设置账期的类型,1：一个月指定日期结算一次，3：两个月指定日期结算一次，6：三个月指定日期结算一次，5：按收货时间和账期日期结算     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setTapType(int tapType) {
     	         	    this.tapType = tapType;
     	        }
    
        [DataMember(Order = 2)]
    private int? tapDate;
    
        /**
       * @return 根据账期类型不同而不同，按月结算类型此值代表具体某日，按收货时间结算时此值代表结算时间周期
    */
        public int? getTapDate() {
               	return tapDate;
            }
    
    /**
     * 设置根据账期类型不同而不同，按月结算类型此值代表具体某日，按收货时间结算时此值代表结算时间周期     *
     * 参数示例：<pre>12</pre>     
             * 此参数必填
          */
    public void setTapDate(int tapDate) {
     	         	    this.tapDate = tapDate;
     	        }
    
        [DataMember(Order = 3)]
    private int? tapOverdue;
    
        /**
       * @return 逾期次数
    */
        public int? getTapOverdue() {
               	return tapOverdue;
            }
    
    /**
     * 设置逾期次数     *
     * 参数示例：<pre>0</pre>     
             * 此参数必填
          */
    public void setTapOverdue(int tapOverdue) {
     	         	    this.tapOverdue = tapOverdue;
     	        }
    
    
  }
}
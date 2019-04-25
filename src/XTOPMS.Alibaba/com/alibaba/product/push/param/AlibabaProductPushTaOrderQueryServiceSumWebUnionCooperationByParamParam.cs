using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.product.push.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductPushTaOrderQueryServiceSumWebUnionCooperationByParamParam : GatewayAPIRequest {

    public AlibabaProductPushTaOrderQueryServiceSumWebUnionCooperationByParamParam() {
        this.ApiId = new APIId("com.alibaba.product.push", "alibaba.product.push.TaOrderQueryService.sumWebUnionCooperationByParam",1);
	}
	
       [DataMember(Order = 1)]
    private string startTime;
    
        /**
       * @return 查询开始时间
    */
        public DateTime? getStartTime() {
                 if (startTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(startTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置查询开始时间     *
     * 参数示例：<pre>20180827000000000+0800</pre>     
             * 此参数必填
          */
    public void setStartTime(DateTime startTime) {
     	         	    this.startTime = DateUtil.format(startTime);
     	        }
    
        [DataMember(Order = 2)]
    private string endTime;
    
        /**
       * @return 查询结束时间
    */
        public DateTime? getEndTime() {
                 if (endTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(endTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置查询结束时间     *
     * 参数示例：<pre>20180828000000000+0800</pre>     
             * 此参数必填
          */
    public void setEndTime(DateTime endTime) {
     	         	    this.endTime = DateUtil.format(endTime);
     	        }
    
    
  }
}
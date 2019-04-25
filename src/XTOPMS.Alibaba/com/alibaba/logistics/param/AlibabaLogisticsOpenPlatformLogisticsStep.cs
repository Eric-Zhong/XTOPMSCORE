using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.logistics.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaLogisticsOpenPlatformLogisticsStep {

       [DataMember(Order = 1)]
    private string acceptTime;
    
        /**
       * @return 物流跟踪单该步骤的时间
    */
        public string getAcceptTime() {
               	return acceptTime;
            }
    
    /**
     * 设置物流跟踪单该步骤的时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAcceptTime(string acceptTime) {
     	         	    this.acceptTime = acceptTime;
     	        }
    
        [DataMember(Order = 2)]
    private string remark;
    
        /**
       * @return 备注，如：“在浙江浦江县公司进行下级地点扫描，即将发往：广东深圳公司”
    */
        public string getRemark() {
               	return remark;
            }
    
    /**
     * 设置备注，如：“在浙江浦江县公司进行下级地点扫描，即将发往：广东深圳公司”     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRemark(string remark) {
     	         	    this.remark = remark;
     	        }
    
    
  }
}
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
public class AlibabaLogisticsOpenPlatformTraceNode {

       [DataMember(Order = 1)]
    private string action;
    
        /**
       * @return 动作
    */
        public string getAction() {
               	return action;
            }
    
    /**
     * 设置动作     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAction(string action) {
     	         	    this.action = action;
     	        }
    
        [DataMember(Order = 2)]
    private string areaCode;
    
        /**
       * @return 地区编码
    */
        public string getAreaCode() {
               	return areaCode;
            }
    
    /**
     * 设置地区编码     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAreaCode(string areaCode) {
     	         	    this.areaCode = areaCode;
     	        }
    
        [DataMember(Order = 3)]
    private string encrypt;
    
        /**
       * @return 
    */
        public string getEncrypt() {
               	return encrypt;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setEncrypt(string encrypt) {
     	         	    this.encrypt = encrypt;
     	        }
    
        [DataMember(Order = 4)]
    private string acceptTime;
    
        /**
       * @return 流转节点的时间
    */
        public string getAcceptTime() {
               	return acceptTime;
            }
    
    /**
     * 设置流转节点的时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAcceptTime(string acceptTime) {
     	         	    this.acceptTime = acceptTime;
     	        }
    
        [DataMember(Order = 5)]
    private string remark;
    
        /**
       * @return 备注，如：在浙江浦江县公司进行下级地点扫描，即将发往：广东深圳公司
    */
        public string getRemark() {
               	return remark;
            }
    
    /**
     * 设置备注，如：在浙江浦江县公司进行下级地点扫描，即将发往：广东深圳公司     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRemark(string remark) {
     	         	    this.remark = remark;
     	        }
    
        [DataMember(Order = 6)]
    private string facilityType;
    
        /**
       * @return 
    */
        public string getFacilityType() {
               	return facilityType;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFacilityType(string facilityType) {
     	         	    this.facilityType = facilityType;
     	        }
    
        [DataMember(Order = 7)]
    private string facilityNo;
    
        /**
       * @return 
    */
        public string getFacilityNo() {
               	return facilityNo;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFacilityNo(string facilityNo) {
     	         	    this.facilityNo = facilityNo;
     	        }
    
        [DataMember(Order = 8)]
    private string facilityName;
    
        /**
       * @return 
    */
        public string getFacilityName() {
               	return facilityName;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFacilityName(string facilityName) {
     	         	    this.facilityName = facilityName;
     	        }
    
    
  }
}
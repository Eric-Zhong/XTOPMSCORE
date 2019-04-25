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
public class AlibabaTradeTrademode {

       [DataMember(Order = 1)]
    private string desc;
    
        /**
       * @return 
    */
        public string getDesc() {
               	return desc;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setDesc(string desc) {
     	         	    this.desc = desc;
     	        }
    
        [DataMember(Order = 2)]
    private bool? forbiddenV3;
    
        /**
       * @return 
    */
        public bool? getForbiddenV3() {
               	return forbiddenV3;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setForbiddenV3(bool forbiddenV3) {
     	         	    this.forbiddenV3 = forbiddenV3;
     	        }
    
        [DataMember(Order = 3)]
    private int? isSupportInstantPay;
    
        /**
       * @return 
    */
        public int? getIsSupportInstantPay() {
               	return isSupportInstantPay;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIsSupportInstantPay(int isSupportInstantPay) {
     	         	    this.isSupportInstantPay = isSupportInstantPay;
     	        }
    
        [DataMember(Order = 4)]
    private string name;
    
        /**
       * @return 
    */
        public string getName() {
               	return name;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setName(string name) {
     	         	    this.name = name;
     	        }
    
        [DataMember(Order = 5)]
    private int? number;
    
        /**
       * @return 
    */
        public int? getNumber() {
               	return number;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setNumber(int number) {
     	         	    this.number = number;
     	        }
    
        [DataMember(Order = 6)]
    private string processFlowId;
    
        /**
       * @return 
    */
        public string getProcessFlowId() {
               	return processFlowId;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProcessFlowId(string processFlowId) {
     	         	    this.processFlowId = processFlowId;
     	        }
    
        [DataMember(Order = 7)]
    private string processTemplateCode;
    
        /**
       * @return 
    */
        public string getProcessTemplateCode() {
               	return processTemplateCode;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProcessTemplateCode(string processTemplateCode) {
     	         	    this.processTemplateCode = processTemplateCode;
     	        }
    
        [DataMember(Order = 8)]
    private string tradeMode;
    
        /**
       * @return 
    */
        public string getTradeMode() {
               	return tradeMode;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTradeMode(string tradeMode) {
     	         	    this.tradeMode = tradeMode;
     	        }
    
        [DataMember(Order = 9)]
    private string tradeWay;
    
        /**
       * @return 
    */
        public string getTradeWay() {
               	return tradeWay;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTradeWay(string tradeWay) {
     	         	    this.tradeWay = tradeWay;
     	        }
    
        [DataMember(Order = 10)]
    private string tradeWayScene;
    
        /**
       * @return 
    */
        public string getTradeWayScene() {
               	return tradeWayScene;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTradeWayScene(string tradeWayScene) {
     	         	    this.tradeWayScene = tradeWayScene;
     	        }
    
        [DataMember(Order = 11)]
    private string type;
    
        /**
       * @return 
    */
        public string getType() {
               	return type;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setType(string type) {
     	         	    this.type = type;
     	        }
    
        [DataMember(Order = 12)]
    private string version;
    
        /**
       * @return 
    */
        public string getVersion() {
               	return version;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setVersion(string version) {
     	         	    this.version = version;
     	        }
    
        [DataMember(Order = 13)]
    private AlibabaTradeSubPayInfo[] subPayInfors;
    
        /**
       * @return 
    */
        public AlibabaTradeSubPayInfo[] getSubPayInfors() {
               	return subPayInfors;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSubPayInfors(AlibabaTradeSubPayInfo[] subPayInfors) {
     	         	    this.subPayInfors = subPayInfors;
     	        }
    
    
  }
}
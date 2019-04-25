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
public class AlibabaTradeTradeModeModel {

       [DataMember(Order = 1)]
    private bool? canModifyTradeMode;
    
        /**
       * @return 是否能够修改交易方式
    */
        public bool? getCanModifyTradeMode() {
               	return canModifyTradeMode;
            }
    
    /**
     * 设置是否能够修改交易方式     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCanModifyTradeMode(bool canModifyTradeMode) {
     	         	    this.canModifyTradeMode = canModifyTradeMode;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaTradeTrademode curSelectedTradeMode;
    
        /**
       * @return 默认选择交易模型
    */
        public AlibabaTradeTrademode getCurSelectedTradeMode() {
               	return curSelectedTradeMode;
            }
    
    /**
     * 设置默认选择交易模型     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCurSelectedTradeMode(AlibabaTradeTrademode curSelectedTradeMode) {
     	         	    this.curSelectedTradeMode = curSelectedTradeMode;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaTradeTrademode[] tradeModes;
    
        /**
       * @return 可选交易模型
    */
        public AlibabaTradeTrademode[] getTradeModes() {
               	return tradeModes;
            }
    
    /**
     * 设置可选交易模型     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTradeModes(AlibabaTradeTrademode[] tradeModes) {
     	         	    this.tradeModes = tradeModes;
     	        }
    
    
  }
}
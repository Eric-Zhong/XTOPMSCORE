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
public class AlibabaOrderPreOrderForRead {

       [DataMember(Order = 1)]
    private string appkey;
    
        /**
       * @return 创建预订单的appkey
    */
        public string getAppkey() {
               	return appkey;
            }
    
    /**
     * 设置创建预订单的appkey     *
     * 参数示例：<pre>12345</pre>     
             * 此参数必填
          */
    public void setAppkey(string appkey) {
     	         	    this.appkey = appkey;
     	        }
    
        [DataMember(Order = 2)]
    private string marketName;
    
        /**
       * @return 创建预订单时传入的市场名
    */
        public string getMarketName() {
               	return marketName;
            }
    
    /**
     * 设置创建预订单时传入的市场名     *
     * 参数示例：<pre>dxc</pre>     
             * 此参数必填
          */
    public void setMarketName(string marketName) {
     	         	    this.marketName = marketName;
     	        }
    
        [DataMember(Order = 3)]
    private bool? createPreOrderApp;
    
        /**
       * @return 预订单是否为当前查询的通过当前查询的ERP创建
    */
        public bool? getCreatePreOrderApp() {
               	return createPreOrderApp;
            }
    
    /**
     * 设置预订单是否为当前查询的通过当前查询的ERP创建     *
     * 参数示例：<pre>false</pre>     
             * 此参数必填
          */
    public void setCreatePreOrderApp(bool createPreOrderApp) {
     	         	    this.createPreOrderApp = createPreOrderApp;
     	        }
    
    
  }
}
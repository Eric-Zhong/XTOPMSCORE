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
public class AlibabaTradeCustoms {

       [DataMember(Order = 1)]
    private long? id;
    
        /**
       * @return id
    */
        public long? getId() {
               	return id;
            }
    
    /**
     * 设置id     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setId(long id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 2)]
    private string gmtCreate;
    
        /**
       * @return 创建时间
    */
        public DateTime? getGmtCreate() {
                 if (gmtCreate != null)
          {
              DateTime datetime = DateUtil.formatFromStr(gmtCreate);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置创建时间     *
     * 参数示例：<pre>20170806114526000+0800</pre>     
             * 此参数必填
          */
    public void setGmtCreate(DateTime gmtCreate) {
     	         	    this.gmtCreate = DateUtil.format(gmtCreate);
     	        }
    
        [DataMember(Order = 3)]
    private string gmtModified;
    
        /**
       * @return 修改时间
    */
        public DateTime? getGmtModified() {
                 if (gmtModified != null)
          {
              DateTime datetime = DateUtil.formatFromStr(gmtModified);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置修改时间     *
     * 参数示例：<pre>20170806114526000+0800</pre>     
             * 此参数必填
          */
    public void setGmtModified(DateTime gmtModified) {
     	         	    this.gmtModified = DateUtil.format(gmtModified);
     	        }
    
        [DataMember(Order = 4)]
    private long? buyerId;
    
        /**
       * @return 买家id
    */
        public long? getBuyerId() {
               	return buyerId;
            }
    
    /**
     * 设置买家id     *
     * 参数示例：<pre>123456</pre>     
             * 此参数必填
          */
    public void setBuyerId(long buyerId) {
     	         	    this.buyerId = buyerId;
     	        }
    
        [DataMember(Order = 5)]
    private string orderId;
    
        /**
       * @return 主订单id
    */
        public string getOrderId() {
               	return orderId;
            }
    
    /**
     * 设置主订单id     *
     * 参数示例：<pre>12312312312312</pre>     
             * 此参数必填
          */
    public void setOrderId(string orderId) {
     	         	    this.orderId = orderId;
     	        }
    
        [DataMember(Order = 6)]
    private int? type;
    
        /**
       * @return 业务数据类型,默认1：报关单
    */
        public int? getType() {
               	return type;
            }
    
    /**
     * 设置业务数据类型,默认1：报关单     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setType(int type) {
     	         	    this.type = type;
     	        }
    
        [DataMember(Order = 7)]
    private AlibabaTradeCustomsAttributesInfo[] attributes;
    
        /**
       * @return 报关信息列表
    */
        public AlibabaTradeCustomsAttributesInfo[] getAttributes() {
               	return attributes;
            }
    
    /**
     * 设置报关信息列表     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAttributes(AlibabaTradeCustomsAttributesInfo[] attributes) {
     	         	    this.attributes = attributes;
     	        }
    
    
  }
}
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
public class AlibabaOrderRateDetail {

       [DataMember(Order = 1)]
    private int? starLevel;
    
        /**
       * @return 评价星级
    */
        public int? getStarLevel() {
               	return starLevel;
            }
    
    /**
     * 设置评价星级     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setStarLevel(int starLevel) {
     	         	    this.starLevel = starLevel;
     	        }
    
        [DataMember(Order = 2)]
    private string content;
    
        /**
       * @return 评价详情
    */
        public string getContent() {
               	return content;
            }
    
    /**
     * 设置评价详情     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setContent(string content) {
     	         	    this.content = content;
     	        }
    
        [DataMember(Order = 3)]
    private string receiverNick;
    
        /**
       * @return 收到评价的用户昵称
    */
        public string getReceiverNick() {
               	return receiverNick;
            }
    
    /**
     * 设置收到评价的用户昵称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiverNick(string receiverNick) {
     	         	    this.receiverNick = receiverNick;
     	        }
    
        [DataMember(Order = 4)]
    private string posterNick;
    
        /**
       * @return 发送评价的用户昵称
    */
        public string getPosterNick() {
               	return posterNick;
            }
    
    /**
     * 设置发送评价的用户昵称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPosterNick(string posterNick) {
     	         	    this.posterNick = posterNick;
     	        }
    
        [DataMember(Order = 5)]
    private string publishTime;
    
        /**
       * @return 评价上线时间
    */
        public DateTime? getPublishTime() {
                 if (publishTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(publishTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置评价上线时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPublishTime(DateTime publishTime) {
     	         	    this.publishTime = DateUtil.format(publishTime);
     	        }
    
    
  }
}
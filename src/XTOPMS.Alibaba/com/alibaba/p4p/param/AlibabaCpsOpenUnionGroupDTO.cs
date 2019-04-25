using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.p4p.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaCpsOpenUnionGroupDTO {

       [DataMember(Order = 1)]
    private long? id;
    
        /**
       * @return 组id
    */
        public long? getId() {
               	return id;
            }
    
    /**
     * 设置组id     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setId(long id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 2)]
    private long? tkId;
    
        /**
       * @return 推客id
    */
        public long? getTkId() {
               	return tkId;
            }
    
    /**
     * 设置推客id     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setTkId(long tkId) {
     	         	    this.tkId = tkId;
     	        }
    
        [DataMember(Order = 3)]
    private string title;
    
        /**
       * @return 标题
    */
        public string getTitle() {
               	return title;
            }
    
    /**
     * 设置标题     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setTitle(string title) {
     	         	    this.title = title;
     	        }
    
        [DataMember(Order = 4)]
    private int? feedCount;
    
        /**
       * @return 组内包含offer总数
    */
        public int? getFeedCount() {
               	return feedCount;
            }
    
    /**
     * 设置组内包含offer总数     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setFeedCount(int feedCount) {
     	         	    this.feedCount = feedCount;
     	        }
    
        [DataMember(Order = 5)]
    private int? invalidFeedCount;
    
        /**
       * @return 组内包含无效offer数（不在推品池）
    */
        public int? getInvalidFeedCount() {
               	return invalidFeedCount;
            }
    
    /**
     * 设置组内包含无效offer数（不在推品池）     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setInvalidFeedCount(int invalidFeedCount) {
     	         	    this.invalidFeedCount = invalidFeedCount;
     	        }
    
        [DataMember(Order = 6)]
    private long[] invalidFeedIds;
    
        /**
       * @return 有效offer id列表
    */
        public long[] getInvalidFeedIds() {
               	return invalidFeedIds;
            }
    
    /**
     * 设置有效offer id列表     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setInvalidFeedIds(long[] invalidFeedIds) {
     	         	    this.invalidFeedIds = invalidFeedIds;
     	        }
    
        [DataMember(Order = 7)]
    private long[] validFeedIds;
    
        /**
       * @return 无效offer id列表
    */
        public long[] getValidFeedIds() {
               	return validFeedIds;
            }
    
    /**
     * 设置无效offer id列表     *
     * 参数示例：<pre> </pre>     
             * 此参数必填
          */
    public void setValidFeedIds(long[] validFeedIds) {
     	         	    this.validFeedIds = validFeedIds;
     	        }
    
    
  }
}
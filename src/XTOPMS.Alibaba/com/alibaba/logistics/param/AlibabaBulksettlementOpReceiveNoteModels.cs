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
public class AlibabaBulksettlementOpReceiveNoteModels {

       [DataMember(Order = 1)]
    private int? totalCount;
    
        /**
       * @return 
    */
        public int? getTotalCount() {
               	return totalCount;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTotalCount(int totalCount) {
     	         	    this.totalCount = totalCount;
     	        }
    
        [DataMember(Order = 2)]
    private int? realPrePageSize;
    
        /**
       * @return 
    */
        public int? getRealPrePageSize() {
               	return realPrePageSize;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setRealPrePageSize(int realPrePageSize) {
     	         	    this.realPrePageSize = realPrePageSize;
     	        }
    
        [DataMember(Order = 3)]
    private string lastStartRow;
    
        /**
       * @return 
    */
        public string getLastStartRow() {
               	return lastStartRow;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLastStartRow(string lastStartRow) {
     	         	    this.lastStartRow = lastStartRow;
     	        }
    
        [DataMember(Order = 4)]
    private AlibabaBulksettlementOpReceiveNoteModel[] modelList;
    
        /**
       * @return 收货单列表
    */
        public AlibabaBulksettlementOpReceiveNoteModel[] getModelList() {
               	return modelList;
            }
    
    /**
     * 设置收货单列表     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setModelList(AlibabaBulksettlementOpReceiveNoteModel[] modelList) {
     	         	    this.modelList = modelList;
     	        }
    
    
  }
}
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
public class AlibabaBulksettlementOpReceiveGoodsResult {

       [DataMember(Order = 1)]
    private long? toSellerFee;
    
        /**
       * @return 
    */
        public long? getToSellerFee() {
               	return toSellerFee;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setToSellerFee(long toSellerFee) {
     	         	    this.toSellerFee = toSellerFee;
     	        }
    
        [DataMember(Order = 2)]
    private bool? isFinish;
    
        /**
       * @return 
    */
        public bool? getIsFinish() {
               	return isFinish;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setIsFinish(bool isFinish) {
     	         	    this.isFinish = isFinish;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaBulksettlementOpReceiveNoteModel opReceiveNoteModel;
    
        /**
       * @return 
    */
        public AlibabaBulksettlementOpReceiveNoteModel getOpReceiveNoteModel() {
               	return opReceiveNoteModel;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOpReceiveNoteModel(AlibabaBulksettlementOpReceiveNoteModel opReceiveNoteModel) {
     	         	    this.opReceiveNoteModel = opReceiveNoteModel;
     	        }
    
        [DataMember(Order = 4)]
    private bool? modifyPriceFlag;
    
        /**
       * @return 是否修改过商品价格
    */
        public bool? getModifyPriceFlag() {
               	return modifyPriceFlag;
            }
    
    /**
     * 设置是否修改过商品价格     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setModifyPriceFlag(bool modifyPriceFlag) {
     	         	    this.modifyPriceFlag = modifyPriceFlag;
     	        }
    
    
  }
}
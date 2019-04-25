using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.product.push.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductPushTaOrderQueryServiceQueryTradeBillResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaProductPushTaTradeBillModel[] modelList;
    
        /**
       * @return 结果列表
    */
        public AlibabaProductPushTaTradeBillModel[] getModelList() {
               	return modelList;
            }
    
    /**
     * 设置结果列表     *
          
             * 此参数必填
          */
    public void setModelList(AlibabaProductPushTaTradeBillModel[] modelList) {
     	         	    this.modelList = modelList;
     	        }
    
        [DataMember(Order = 2)]
    private bool? hasLast;
    
        /**
       * @return 是否有上一页
    */
        public bool? getHasLast() {
               	return hasLast;
            }
    
    /**
     * 设置是否有上一页     *
          
             * 此参数必填
          */
    public void setHasLast(bool hasLast) {
     	         	    this.hasLast = hasLast;
     	        }
    
        [DataMember(Order = 3)]
    private bool? hasNext;
    
        /**
       * @return 是否有下一页
    */
        public bool? getHasNext() {
               	return hasNext;
            }
    
    /**
     * 设置是否有下一页     *
          
             * 此参数必填
          */
    public void setHasNext(bool hasNext) {
     	         	    this.hasNext = hasNext;
     	        }
    
        [DataMember(Order = 4)]
    private int? thisPage;
    
        /**
       * @return 当前页码，从1开始。1,2,3...
    */
        public int? getThisPage() {
               	return thisPage;
            }
    
    /**
     * 设置当前页码，从1开始。1,2,3...     *
          
             * 此参数必填
          */
    public void setThisPage(int thisPage) {
     	         	    this.thisPage = thisPage;
     	        }
    
    
  }
}
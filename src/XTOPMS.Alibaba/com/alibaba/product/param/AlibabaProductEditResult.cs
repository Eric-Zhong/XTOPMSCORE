using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.product.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaProductEditResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private long? productID;
    
        /**
       * @return 商品ID，修改成功会返回商品ID
    */
        public long? getProductID() {
               	return productID;
            }
    
    /**
     * 设置商品ID，修改成功会返回商品ID     *
          
             * 此参数必填
          */
    public void setProductID(long productID) {
     	         	    this.productID = productID;
     	        }
    
        [DataMember(Order = 2)]
    private string errorMsg;
    
        /**
       * @return 错误返回信息
    */
        public string getErrorMsg() {
               	return errorMsg;
            }
    
    /**
     * 设置错误返回信息     *
          
             * 此参数必填
          */
    public void setErrorMsg(string errorMsg) {
     	         	    this.errorMsg = errorMsg;
     	        }
    
    
  }
}
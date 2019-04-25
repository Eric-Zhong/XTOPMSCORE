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
public class AlibabaProductGetByIdListResult : GatewayAPIResponse {

       [DataMember(Order = 1)]
    private AlibabaProductProductInfo[] productList;
    
        /**
       * @return 商品列表
    */
        public AlibabaProductProductInfo[] getProductList() {
               	return productList;
            }
    
    /**
     * 设置商品列表     *
          
             * 此参数必填
          */
    public void setProductList(AlibabaProductProductInfo[] productList) {
     	         	    this.productList = productList;
     	        }
    
        [DataMember(Order = 2)]
    private bool? success;
    
        /**
       * @return 是否成功
    */
        public bool? getSuccess() {
               	return success;
            }
    
    /**
     * 设置是否成功     *
          
             * 此参数必填
          */
    public void setSuccess(bool success) {
     	         	    this.success = success;
     	        }
    
        [DataMember(Order = 3)]
    private string message;
    
        /**
       * @return 返回信息
    */
        public string getMessage() {
               	return message;
            }
    
    /**
     * 设置返回信息     *
          
             * 此参数必填
          */
    public void setMessage(string message) {
     	         	    this.message = message;
     	        }
    
    
  }
}
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
public class AlibabaOpenplatformTradeBizMakeSingleOrderGroup {

       [DataMember(Order = 1)]
    private AlibabaOpenplatformTradeBizReceiveAddressGroup receiveAddressGroup;
    
        /**
       * @return 收货地址信息
    */
        public AlibabaOpenplatformTradeBizReceiveAddressGroup getReceiveAddressGroup() {
               	return receiveAddressGroup;
            }
    
    /**
     * 设置收货地址信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setReceiveAddressGroup(AlibabaOpenplatformTradeBizReceiveAddressGroup receiveAddressGroup) {
     	         	    this.receiveAddressGroup = receiveAddressGroup;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaOpenplatformTradeBizInvoiceGroup invoiceGroup;
    
        /**
       * @return 发票信息
    */
        public AlibabaOpenplatformTradeBizInvoiceGroup getInvoiceGroup() {
               	return invoiceGroup;
            }
    
    /**
     * 设置发票信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setInvoiceGroup(AlibabaOpenplatformTradeBizInvoiceGroup invoiceGroup) {
     	         	    this.invoiceGroup = invoiceGroup;
     	        }
    
        [DataMember(Order = 3)]
    private AlibabaOpenplatformTradeBizSimpleOtherInfoGroup otherInfoGroup;
    
        /**
       * @return 其他信息
    */
        public AlibabaOpenplatformTradeBizSimpleOtherInfoGroup getOtherInfoGroup() {
               	return otherInfoGroup;
            }
    
    /**
     * 设置其他信息     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setOtherInfoGroup(AlibabaOpenplatformTradeBizSimpleOtherInfoGroup otherInfoGroup) {
     	         	    this.otherInfoGroup = otherInfoGroup;
     	        }
    
    
  }
}
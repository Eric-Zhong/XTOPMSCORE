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
public class ComAlibabaOceanOpenplatformBizLogisticsResultCainiaoSolutionInfoModel {

       [DataMember(Order = 1)]
    private string name;
    
        /**
       * @return 路线名称
    */
        public string getName() {
               	return name;
            }
    
    /**
     * 设置路线名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setName(string name) {
     	         	    this.name = name;
     	        }
    
        [DataMember(Order = 2)]
    private string solutionCode;
    
        /**
       * @return 路线方案编码，下单时需要传入
    */
        public string getSolutionCode() {
               	return solutionCode;
            }
    
    /**
     * 设置路线方案编码，下单时需要传入     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSolutionCode(string solutionCode) {
     	         	    this.solutionCode = solutionCode;
     	        }
    
        [DataMember(Order = 3)]
    private string totalFee;
    
        /**
       * @return 预估费用，单位 分
    */
        public string getTotalFee() {
               	return totalFee;
            }
    
    /**
     * 设置预估费用，单位 分     *
     * 参数示例：<pre>1200</pre>     
             * 此参数必填
          */
    public void setTotalFee(string totalFee) {
     	         	    this.totalFee = totalFee;
     	        }
    
    
  }
}
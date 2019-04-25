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
public class AlibabaLogisticsOpLogisticsCompanyModel {

       [DataMember(Order = 1)]
    private long? id;
    
        /**
       * @return 
    */
        public long? getId() {
               	return id;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setId(long id) {
     	         	    this.id = id;
     	        }
    
        [DataMember(Order = 2)]
    private string companyName;
    
        /**
       * @return 物流公司名称
    */
        public string getCompanyName() {
               	return companyName;
            }
    
    /**
     * 设置物流公司名称     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCompanyName(string companyName) {
     	         	    this.companyName = companyName;
     	        }
    
        [DataMember(Order = 3)]
    private string companyNo;
    
        /**
       * @return 物流公司编号
    */
        public string getCompanyNo() {
               	return companyNo;
            }
    
    /**
     * 设置物流公司编号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCompanyNo(string companyNo) {
     	         	    this.companyNo = companyNo;
     	        }
    
        [DataMember(Order = 4)]
    private string companyPhone;
    
        /**
       * @return 物流公司服务电话
    */
        public string getCompanyPhone() {
               	return companyPhone;
            }
    
    /**
     * 设置物流公司服务电话     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCompanyPhone(string companyPhone) {
     	         	    this.companyPhone = companyPhone;
     	        }
    
        [DataMember(Order = 5)]
    private string supportPrint;
    
        /**
       * @return 是否支持打印
    */
        public string getSupportPrint() {
               	return supportPrint;
            }
    
    /**
     * 设置是否支持打印     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSupportPrint(string supportPrint) {
     	         	    this.supportPrint = supportPrint;
     	        }
    
        [DataMember(Order = 6)]
    private string spelling;
    
        /**
       * @return 全拼
    */
        public string getSpelling() {
               	return spelling;
            }
    
    /**
     * 设置全拼     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSpelling(string spelling) {
     	         	    this.spelling = spelling;
     	        }
    
    
  }
}
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
public class AlibabaOceanOpenplatformBizLogisticsResultCainiaoCountryInfoModel {

       [DataMember(Order = 1)]
    private long? areaId;
    
        /**
       * @return 地区ID
    */
        public long? getAreaId() {
               	return areaId;
            }
    
    /**
     * 设置地区ID     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setAreaId(long areaId) {
     	         	    this.areaId = areaId;
     	        }
    
        [DataMember(Order = 2)]
    private string country;
    
        /**
       * @return 国家
    */
        public string getCountry() {
               	return country;
            }
    
    /**
     * 设置国家     *
     * 参数示例：<pre>China</pre>     
             * 此参数必填
          */
    public void setCountry(string country) {
     	         	    this.country = country;
     	        }
    
        [DataMember(Order = 3)]
    private string iso;
    
        /**
       * @return 国家编码
    */
        public string getIso() {
               	return iso;
            }
    
    /**
     * 设置国家编码     *
     * 参数示例：<pre>CN</pre>     
             * 此参数必填
          */
    public void setIso(string iso) {
     	         	    this.iso = iso;
     	        }
    
        [DataMember(Order = 4)]
    private string language;
    
        /**
       * @return 本地语言
    */
        public string getLanguage() {
               	return language;
            }
    
    /**
     * 设置本地语言     *
     * 参数示例：<pre>CN</pre>     
             * 此参数必填
          */
    public void setLanguage(string language) {
     	         	    this.language = language;
     	        }
    
        [DataMember(Order = 5)]
    private string searchName;
    
        /**
       * @return 搜索名称
    */
        public string getSearchName() {
               	return searchName;
            }
    
    /**
     * 设置搜索名称     *
     * 参数示例：<pre>中国</pre>     
             * 此参数必填
          */
    public void setSearchName(string searchName) {
     	         	    this.searchName = searchName;
     	        }
    
    
  }
}
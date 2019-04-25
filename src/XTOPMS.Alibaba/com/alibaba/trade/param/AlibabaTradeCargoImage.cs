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
public class AlibabaTradeCargoImage {

       [DataMember(Order = 1)]
    private string imageURI;
    
        /**
       * @return 
    */
        public string getImageURI() {
               	return imageURI;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setImageURI(string imageURI) {
     	         	    this.imageURI = imageURI;
     	        }
    
        [DataMember(Order = 2)]
    private string searchImageURI;
    
        /**
       * @return 
    */
        public string getSearchImageURI() {
               	return searchImageURI;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSearchImageURI(string searchImageURI) {
     	         	    this.searchImageURI = searchImageURI;
     	        }
    
        [DataMember(Order = 3)]
    private string size310x310ImageURI;
    
        /**
       * @return 
    */
        public string getSize310x310ImageURI() {
               	return size310x310ImageURI;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSize310x310ImageURI(string size310x310ImageURI) {
     	         	    this.size310x310ImageURI = size310x310ImageURI;
     	        }
    
        [DataMember(Order = 4)]
    private string summImageURI;
    
        /**
       * @return 
    */
        public string getSummImageURI() {
               	return summImageURI;
            }
    
    /**
     * 设置     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setSummImageURI(string summImageURI) {
     	         	    this.summImageURI = summImageURI;
     	        }
    
    
  }
}
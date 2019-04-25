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
public class AlibabaOceanOpenplatformBizLogisticsResultCainiaoDivisionInfoModel {

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
     * 参数示例：<pre>530000</pre>     
             * 此参数必填
          */
    public void setAreaId(long areaId) {
     	         	    this.areaId = areaId;
     	        }
    
        [DataMember(Order = 2)]
    private bool? delFlag;
    
        /**
       * @return 是否删除
    */
        public bool? getDelFlag() {
               	return delFlag;
            }
    
    /**
     * 设置是否删除     *
     * 参数示例：<pre>false</pre>     
             * 此参数必填
          */
    public void setDelFlag(bool delFlag) {
     	         	    this.delFlag = delFlag;
     	        }
    
        [DataMember(Order = 3)]
    private int? level;
    
        /**
       * @return 地区层级
    */
        public int? getLevel() {
               	return level;
            }
    
    /**
     * 设置地区层级     *
     * 参数示例：<pre>3</pre>     
             * 此参数必填
          */
    public void setLevel(int level) {
     	         	    this.level = level;
     	        }
    
        [DataMember(Order = 4)]
    private string name;
    
        /**
       * @return 地区名称
    */
        public string getName() {
               	return name;
            }
    
    /**
     * 设置地区名称     *
     * 参数示例：<pre>云南省</pre>     
             * 此参数必填
          */
    public void setName(string name) {
     	         	    this.name = name;
     	        }
    
        [DataMember(Order = 5)]
    private long? parentId;
    
        /**
       * @return 上层级地区ID
    */
        public long? getParentId() {
               	return parentId;
            }
    
    /**
     * 设置上层级地区ID     *
     * 参数示例：<pre>1</pre>     
             * 此参数必填
          */
    public void setParentId(long parentId) {
     	         	    this.parentId = parentId;
     	        }
    
        [DataMember(Order = 6)]
    private string parentName;
    
        /**
       * @return 上层级地区名称
    */
        public string getParentName() {
               	return parentName;
            }
    
    /**
     * 设置上层级地区名称     *
     * 参数示例：<pre>中国</pre>     
             * 此参数必填
          */
    public void setParentName(string parentName) {
     	         	    this.parentName = parentName;
     	        }
    
        [DataMember(Order = 7)]
    private string pinyin;
    
        /**
       * @return 地区拼音
    */
        public string getPinyin() {
               	return pinyin;
            }
    
    /**
     * 设置地区拼音     *
     * 参数示例：<pre>yun nan sheng</pre>     
             * 此参数必填
          */
    public void setPinyin(string pinyin) {
     	         	    this.pinyin = pinyin;
     	        }
    
        [DataMember(Order = 8)]
    private string postCodeList;
    
        /**
       * @return 邮编
    */
        public string getPostCodeList() {
               	return postCodeList;
            }
    
    /**
     * 设置邮编     *
     * 参数示例：<pre>[100001,100002]</pre>     
             * 此参数必填
          */
    public void setPostCodeList(string postCodeList) {
     	         	    this.postCodeList = postCodeList;
     	        }
    
    
  }
}
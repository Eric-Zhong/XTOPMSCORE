using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace com.alibaba.multimedia.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class AlibabaTaosellerVideoTaskStartParam : GatewayAPIRequest {

    public AlibabaTaosellerVideoTaskStartParam() {
        this.ApiId = new APIId("com.alibaba.multimedia", "alibaba.taoseller.video.task.start",1);
	}
	
       [DataMember(Order = 1)]
    private string taoSellerUserId;
    
        /**
       * @return 淘卖用户在淘宝的userId
    */
        public string getTaoSellerUserId() {
               	return taoSellerUserId;
            }
    
    /**
     * 设置淘卖用户在淘宝的userId     *
     * 参数示例：<pre>12345678</pre>     
             * 此参数必填
          */
    public void setTaoSellerUserId(string taoSellerUserId) {
     	         	    this.taoSellerUserId = taoSellerUserId;
     	        }
    
        [DataMember(Order = 2)]
    private AlibabaOceanOpenplatformBizVideoParamMaterialParam[] materials;
    
        /**
       * @return 素材列表
    */
        public AlibabaOceanOpenplatformBizVideoParamMaterialParam[] getMaterials() {
               	return materials;
            }
    
    /**
     * 设置素材列表     *
     * 参数示例：<pre>[]</pre>     
             * 此参数必填
          */
    public void setMaterials(AlibabaOceanOpenplatformBizVideoParamMaterialParam[] materials) {
     	         	    this.materials = materials;
     	        }
    
        [DataMember(Order = 3)]
    private ComAlibabaOceanOpenplatformBizVideoParamVideoConfigExtParam videoConfigExt;
    
        /**
       * @return 用户自定义可扩展字段
    */
        public ComAlibabaOceanOpenplatformBizVideoParamVideoConfigExtParam getVideoConfigExt() {
               	return videoConfigExt;
            }
    
    /**
     * 设置用户自定义可扩展字段     *
     * 参数示例：<pre>{}</pre>     
             * 此参数必填
          */
    public void setVideoConfigExt(ComAlibabaOceanOpenplatformBizVideoParamVideoConfigExtParam videoConfigExt) {
     	         	    this.videoConfigExt = videoConfigExt;
     	        }
    
        [DataMember(Order = 4)]
    private int? duration;
    
        /**
       * @return 生成视频的长度，单位为秒，默认值20
    */
        public int? getDuration() {
               	return duration;
            }
    
    /**
     * 设置生成视频的长度，单位为秒，默认值20     *
     * 参数示例：<pre>20</pre>     
             * 此参数必填
          */
    public void setDuration(int duration) {
     	         	    this.duration = duration;
     	        }
    
    
  }
}
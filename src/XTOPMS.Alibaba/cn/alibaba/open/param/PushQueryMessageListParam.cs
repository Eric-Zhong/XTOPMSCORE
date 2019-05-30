using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.alibaba.openapi.client;


namespace cn.alibaba.open.param
{
[DataContract(Namespace = "com.alibaba.openapi.client")]
public class PushQueryMessageListParam : GatewayAPIRequest {

    public PushQueryMessageListParam() {
        this.ApiId = new APIId("cn.alibaba.open", "push.query.messageList",1);
	}


        [DataMember(Order = 1)]
        private string createEndTime;

        /**
       * @return 下单结束时间
    */
        public DateTime? getCreateEndTime()
        {
            if (createEndTime != null)
            {
                DateTime datetime = DateUtil.formatFromStr(createEndTime);
                return datetime;
            }
            return null;
        }

        /**
         * 设置下单结束时间     *
         * 参数示例：<pre></pre>     
                 * 此参数必填
              */
        public void setCreateEndTime(DateTime createEndTime)
        {
            this.createEndTime = DateUtil.format(createEndTime);
        }

        [DataMember(Order = 2)]
        private string createStartTime;

        /**
       * @return 下单开始时间
    */
        public DateTime? getCreateStartTime()
        {
            if (createStartTime != null)
            {
                DateTime datetime = DateUtil.formatFromStr(createStartTime);
                return datetime;
            }
            return null;
        }

        /**
         * 设置下单开始时间     *
         * 参数示例：<pre></pre>     
                 * 此参数必填
              */
        public void setCreateStartTime(DateTime createStartTime)
        {
            this.createStartTime = DateUtil.format(createStartTime);
        }

        [DataMember(Order = 3)]
        private int? page;


        /**
       * @return 查询分页页码，从1开始
    */
        public int? getPage()
        {
            return page;
        }

        /**
         * 设置查询分页页码，从1开始     *
         * 参数示例：<pre></pre>     
                 * 此参数必填
              */
        public void setPage(int page)
        {
            this.page = page;
        }

        [DataMember(Order = 4)]
        private int? pageSize;

        /**
       * @return 查询的每页的数量(最高20)
    */
        public int? getPageSize()
        {
            return pageSize;
        }

        /**
         * 设置查询的每页的数量(最高20)     *
         * 参数示例：<pre></pre>     
                 * 此参数必填
              */
        public void setPageSize(int pageSize)
        {
            this.pageSize = pageSize;
        }


        [DataMember(Order = 5)]
        private string type;
        public void setType(string type) { this.type = type; }
        public string getType() { return this.type; }

        [DataMember(Order = 6)]
        private string userInfo;
        public void setUserInfo(string userInfo) { this.userInfo = userInfo; }
        public string getUserInfo() { return this.userInfo; }


    }
}
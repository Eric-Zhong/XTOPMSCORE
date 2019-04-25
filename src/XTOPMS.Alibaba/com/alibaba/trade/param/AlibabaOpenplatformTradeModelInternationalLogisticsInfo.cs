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
public class AlibabaOpenplatformTradeModelInternationalLogisticsInfo {

       [DataMember(Order = 1)]
    private string address;
    
        /**
       * @return 详细地址
    */
        public string getAddress() {
               	return address;
            }
    
    /**
     * 设置详细地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAddress(string address) {
     	         	    this.address = address;
     	        }
    
        [DataMember(Order = 2)]
    private string allDeliveredTime;
    
        /**
       * @return 完全发货时间
    */
        public DateTime? getAllDeliveredTime() {
                 if (allDeliveredTime != null)
          {
              DateTime datetime = DateUtil.formatFromStr(allDeliveredTime);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置完全发货时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAllDeliveredTime(DateTime allDeliveredTime) {
     	         	    this.allDeliveredTime = DateUtil.format(allDeliveredTime);
     	        }
    
        [DataMember(Order = 3)]
    private string alternateAddress;
    
        /**
       * @return 备用地址
    */
        public string getAlternateAddress() {
               	return alternateAddress;
            }
    
    /**
     * 设置备用地址     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setAlternateAddress(string alternateAddress) {
     	         	    this.alternateAddress = alternateAddress;
     	        }
    
        [DataMember(Order = 4)]
    private string carrier;
    
        /**
       * @return 承运商
    */
        public string getCarrier() {
               	return carrier;
            }
    
    /**
     * 设置承运商     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCarrier(string carrier) {
     	         	    this.carrier = carrier;
     	        }
    
        [DataMember(Order = 5)]
    private string city;
    
        /**
       * @return 城市
    */
        public string getCity() {
               	return city;
            }
    
    /**
     * 设置城市     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCity(string city) {
     	         	    this.city = city;
     	        }
    
        [DataMember(Order = 6)]
    private string cityCode;
    
        /**
       * @return 城市编号
    */
        public string getCityCode() {
               	return cityCode;
            }
    
    /**
     * 设置城市编号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCityCode(string cityCode) {
     	         	    this.cityCode = cityCode;
     	        }
    
        [DataMember(Order = 7)]
    private string contactPerson;
    
        /**
       * @return 联系人姓名
    */
        public string getContactPerson() {
               	return contactPerson;
            }
    
    /**
     * 设置联系人姓名     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setContactPerson(string contactPerson) {
     	         	    this.contactPerson = contactPerson;
     	        }
    
        [DataMember(Order = 8)]
    private string country;
    
        /**
       * @return 国家
    */
        public string getCountry() {
               	return country;
            }
    
    /**
     * 设置国家     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCountry(string country) {
     	         	    this.country = country;
     	        }
    
        [DataMember(Order = 9)]
    private string countryCode;
    
        /**
       * @return 国家编号
    */
        public string getCountryCode() {
               	return countryCode;
            }
    
    /**
     * 设置国家编号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setCountryCode(string countryCode) {
     	         	    this.countryCode = countryCode;
     	        }
    
        [DataMember(Order = 10)]
    private string fax;
    
        /**
       * @return 传真
    */
        public string getFax() {
               	return fax;
            }
    
    /**
     * 设置传真     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFax(string fax) {
     	         	    this.fax = fax;
     	        }
    
        [DataMember(Order = 11)]
    private string faxArea;
    
        /**
       * @return 传真地区区号
    */
        public string getFaxArea() {
               	return faxArea;
            }
    
    /**
     * 设置传真地区区号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFaxArea(string faxArea) {
     	         	    this.faxArea = faxArea;
     	        }
    
        [DataMember(Order = 12)]
    private string faxCountry;
    
        /**
       * @return 传真国家编号
    */
        public string getFaxCountry() {
               	return faxCountry;
            }
    
    /**
     * 设置传真国家编号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setFaxCountry(string faxCountry) {
     	         	    this.faxCountry = faxCountry;
     	        }
    
        [DataMember(Order = 13)]
    private decimal? insuranceFee;
    
        /**
       * @return 物流保险费
    */
        public decimal? getInsuranceFee() {
               	return insuranceFee;
            }
    
    /**
     * 设置物流保险费     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setInsuranceFee(decimal insuranceFee) {
     	         	    this.insuranceFee = insuranceFee;
     	        }
    
        [DataMember(Order = 14)]
    private string logisticsCode;
    
        /**
       * @return 委托单号
    */
        public string getLogisticsCode() {
               	return logisticsCode;
            }
    
    /**
     * 设置委托单号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLogisticsCode(string logisticsCode) {
     	         	    this.logisticsCode = logisticsCode;
     	        }
    
        [DataMember(Order = 15)]
    private decimal? logisticsFee;
    
        /**
       * @return 物流费用
    */
        public decimal? getLogisticsFee() {
               	return logisticsFee;
            }
    
    /**
     * 设置物流费用     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setLogisticsFee(decimal logisticsFee) {
     	         	    this.logisticsFee = logisticsFee;
     	        }
    
        [DataMember(Order = 16)]
    private string mobile;
    
        /**
       * @return 手机
    */
        public string getMobile() {
               	return mobile;
            }
    
    /**
     * 设置手机     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMobile(string mobile) {
     	         	    this.mobile = mobile;
     	        }
    
        [DataMember(Order = 17)]
    private string mobileArea;
    
        /**
       * @return 移动电话地区区号
    */
        public string getMobileArea() {
               	return mobileArea;
            }
    
    /**
     * 设置移动电话地区区号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMobileArea(string mobileArea) {
     	         	    this.mobileArea = mobileArea;
     	        }
    
        [DataMember(Order = 18)]
    private string mobileCountry;
    
        /**
       * @return 移动电话国家编号
    */
        public string getMobileCountry() {
               	return mobileCountry;
            }
    
    /**
     * 设置移动电话国家编号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setMobileCountry(string mobileCountry) {
     	         	    this.mobileCountry = mobileCountry;
     	        }
    
        [DataMember(Order = 19)]
    private string port;
    
        /**
       * @return 港口
    */
        public string getPort() {
               	return port;
            }
    
    /**
     * 设置港口     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPort(string port) {
     	         	    this.port = port;
     	        }
    
        [DataMember(Order = 20)]
    private string portCode;
    
        /**
       * @return 港口编号
    */
        public string getPortCode() {
               	return portCode;
            }
    
    /**
     * 设置港口编号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setPortCode(string portCode) {
     	         	    this.portCode = portCode;
     	        }
    
        [DataMember(Order = 21)]
    private string province;
    
        /**
       * @return 省份
    */
        public string getProvince() {
               	return province;
            }
    
    /**
     * 设置省份     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProvince(string province) {
     	         	    this.province = province;
     	        }
    
        [DataMember(Order = 22)]
    private string provinceCode;
    
        /**
       * @return 省份编号
    */
        public string getProvinceCode() {
               	return provinceCode;
            }
    
    /**
     * 设置省份编号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setProvinceCode(string provinceCode) {
     	         	    this.provinceCode = provinceCode;
     	        }
    
        [DataMember(Order = 23)]
    private string shipmentAbsoluteDate;
    
        /**
       * @return 绝对时间
    */
        public DateTime? getShipmentAbsoluteDate() {
                 if (shipmentAbsoluteDate != null)
          {
              DateTime datetime = DateUtil.formatFromStr(shipmentAbsoluteDate);
              return datetime;
          }
    	  return null;
    	    }
    
    /**
     * 设置绝对时间     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setShipmentAbsoluteDate(DateTime shipmentAbsoluteDate) {
     	         	    this.shipmentAbsoluteDate = DateUtil.format(shipmentAbsoluteDate);
     	        }
    
        [DataMember(Order = 24)]
    private string shipmentAbsoluteZone;
    
        /**
       * @return 买家时区
    */
        public string getShipmentAbsoluteZone() {
               	return shipmentAbsoluteZone;
            }
    
    /**
     * 设置买家时区     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setShipmentAbsoluteZone(string shipmentAbsoluteZone) {
     	         	    this.shipmentAbsoluteZone = shipmentAbsoluteZone;
     	        }
    
        [DataMember(Order = 25)]
    private string shipmentDateType;
    
        /**
       * @return 倒计时类型。absolute(绝对),relative(相对)
    */
        public string getShipmentDateType() {
               	return shipmentDateType;
            }
    
    /**
     * 设置倒计时类型。absolute(绝对),relative(相对)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setShipmentDateType(string shipmentDateType) {
     	         	    this.shipmentDateType = shipmentDateType;
     	        }
    
        [DataMember(Order = 26)]
    private string shipmentMethod;
    
        /**
       * @return 发货方式。AIR(空运),SEA(海运),EXPRESS(快递),LAND(陆运),UNKNOWN(未知)
    */
        public string getShipmentMethod() {
               	return shipmentMethod;
            }
    
    /**
     * 设置发货方式。AIR(空运),SEA(海运),EXPRESS(快递),LAND(陆运),UNKNOWN(未知)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setShipmentMethod(string shipmentMethod) {
     	         	    this.shipmentMethod = shipmentMethod;
     	        }
    
        [DataMember(Order = 27)]
    private string shipmentRelativeDuration;
    
        /**
       * @return 相对时间长度
    */
        public string getShipmentRelativeDuration() {
               	return shipmentRelativeDuration;
            }
    
    /**
     * 设置相对时间长度     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setShipmentRelativeDuration(string shipmentRelativeDuration) {
     	         	    this.shipmentRelativeDuration = shipmentRelativeDuration;
     	        }
    
        [DataMember(Order = 28)]
    private string shipmentRelativeField;
    
        /**
       * @return 相对时间单位。day(天),hour(时),second(秒)
    */
        public string getShipmentRelativeField() {
               	return shipmentRelativeField;
            }
    
    /**
     * 设置相对时间单位。day(天),hour(时),second(秒)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setShipmentRelativeField(string shipmentRelativeField) {
     	         	    this.shipmentRelativeField = shipmentRelativeField;
     	        }
    
        [DataMember(Order = 29)]
    private string shipmentRelativeStart;
    
        /**
       * @return 相对时间的开始点。pre_amount(预付款到帐),final_amount(尾款到帐)
    */
        public string getShipmentRelativeStart() {
               	return shipmentRelativeStart;
            }
    
    /**
     * 设置相对时间的开始点。pre_amount(预付款到帐),final_amount(尾款到帐)     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setShipmentRelativeStart(string shipmentRelativeStart) {
     	         	    this.shipmentRelativeStart = shipmentRelativeStart;
     	        }
    
        [DataMember(Order = 30)]
    private string telephone;
    
        /**
       * @return 电话
    */
        public string getTelephone() {
               	return telephone;
            }
    
    /**
     * 设置电话     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTelephone(string telephone) {
     	         	    this.telephone = telephone;
     	        }
    
        [DataMember(Order = 31)]
    private string telephoneArea;
    
        /**
       * @return 电话地区区号
    */
        public string getTelephoneArea() {
               	return telephoneArea;
            }
    
    /**
     * 设置电话地区区号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTelephoneArea(string telephoneArea) {
     	         	    this.telephoneArea = telephoneArea;
     	        }
    
        [DataMember(Order = 32)]
    private string telephoneCountryv;
    
        /**
       * @return 电话国家编号
    */
        public string getTelephoneCountryv() {
               	return telephoneCountryv;
            }
    
    /**
     * 设置电话国家编号     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTelephoneCountryv(string telephoneCountryv) {
     	         	    this.telephoneCountryv = telephoneCountryv;
     	        }
    
        [DataMember(Order = 33)]
    private string tradeTerm;
    
        /**
       * @return 贸易条款说明
    */
        public string getTradeTerm() {
               	return tradeTerm;
            }
    
    /**
     * 设置贸易条款说明     *
     * 参数示例：<pre></pre>     
             * 此参数必填
          */
    public void setTradeTerm(string tradeTerm) {
     	         	    this.tradeTerm = tradeTerm;
     	        }
    
    
  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Canvas_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        int GetOrder(OrderDetailes order);

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class OrderDetailes
    {
        [DataMember]
        public DateTime orderDate;

        [DataMember]
        public int amount;

        [DataMember]
        public int pattern;

        [DataMember]
        public List<Pictures> picturesList = new List<Pictures>();

        [DataMember]
        public List<Text> textsList = new List<Text>();

        [DataMember]
        public string clientID;

        [DataMember]
        public string phone;

        [DataMember]
        public string fullName;

        [DataMember]
        public string address;

        [DataMember]
        public string city;

        [DataMember]
        public int zipCode;

        [DataMember]
        public int POB;

        [DataMember]
        public int deliveryMethod;
    }

    [DataContract]
    public class Pictures
    {
        [DataMember]
        public string fileName;

        [DataMember]
        public uint fileSize;

        [DataMember]
        public byte[] fileBody;

        [DataMember]
        public float size;

        [DataMember]
        public float top;

        [DataMember]
        public float left;

        [DataMember]
        public float angle;
    }
    
    [DataContract]
    public class Text
    {
        [DataMember]
        public string textBody;

        [DataMember]
        public string fontFamily;

        [DataMember]
        public int fontSize;

        [DataMember]
        public string fontColor;

        [DataMember]
        public float top;

        [DataMember]
        public float left;

        [DataMember]
        public float angle;
    }
}

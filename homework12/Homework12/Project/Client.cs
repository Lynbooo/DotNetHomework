using System;
using System.Collections.Generic;
using System.Text;

namespace orderService
{
    public class Client
    {
        private String clientName;    //客户
        private String clientTel;     //客户电话号码
        private String clientAddress; //客户地址
        public Client() { }
        public Client(String clientName, String clientTel, String clientAddress)
        {
            ClientName = clientName;
            ClientTel = clientTel;
            ClientAddress = clientAddress;
        }
        public String ClientName
        {
            get { return clientName; }
            set
            {
                if (value == null) throw new ArgumentOutOfRangeException("invalid clientName!");
                clientName = value;
            }
        }
        public String ClientTel
        {
            get { return clientTel; }
            set
            {
                if (value == null) throw new ArgumentOutOfRangeException("invalid clientTel!");
                clientTel = value;
            }
        }
        public String ClientAddress
        {
            get { return clientAddress; }
            set
            {
                if (value == null) throw new ArgumentOutOfRangeException("invalid clientAddress!");
                clientAddress = value;
            }
        }
        public override bool Equals(object obj)
        {
            var client = obj as Client;
            return client != null &&
                ClientName == client.ClientName &&
                ClientTel == client.ClientTel &&
                ClientAddress == client.ClientAddress;
        }
        public override int GetHashCode()
        {
            var hashCode = 1505761165;
            hashCode = hashCode * -1521134295 + ClientName.GetHashCode();
            hashCode = hashCode * -1521134295 + ClientTel.GetHashCode();
            hashCode = hashCode * -1521134295 + ClientAddress.GetHashCode();
            return hashCode;
        }
        public override string ToString()
        {
            return "ClientName: " + ClientName + "\r\n"
                + "ClientTel: " + ClientTel + "\r\n"
                + "ClientAddress: " + ClientAddress;
        }
    }
}

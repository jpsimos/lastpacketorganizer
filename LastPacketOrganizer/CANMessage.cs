// Author Jacob A. Psimos

using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Script.Serialization;

namespace LastPacketOrganizer
{
	public class CANMessage : IComparable<CANMessage>
	{
		public UInt32 BusID { get; set; }
		public UInt32 ID { get; set; }
		public UInt32 Length { get; set; }
		public bool Extended { get; set; }
		public bool Remote { get; set; }
		public bool Overrun { get; set; }
		public DateTime Timestamp { get; set; }

		public byte[] Data = new byte[8];

		public CANMessage(){
			ID = 0;
			Length = 0;
			BusID = 0;
			Extended = false;
			Remote = false;
			Overrun = false;
			Timestamp = DateTime.Now;
		}

		public CANMessage(string strJson){
			fromJsonString(strJson, new JavaScriptSerializer());
		}

		public CANMessage(string strJson, JavaScriptSerializer jss){
			fromJsonString(strJson, jss);
		}

		private void fromJsonString(string strJson, JavaScriptSerializer jss){
			Dictionary<string, object> objJson = jss.Deserialize<Dictionary<string, object>>(strJson);
			BusID = Convert.ToUInt32(objJson["bus"]);
			ID = Convert.ToUInt32(objJson["id"]);
			Length = Convert.ToUInt32(objJson["len"]);
			Extended = Convert.ToBoolean(objJson["e"]);
			Remote = Convert.ToBoolean(objJson["r"]);
			Overrun = Convert.ToBoolean(objJson["o"]);
			if (objJson.ContainsKey("time"))
			{
				Timestamp = DateTime.FromBinary(Convert.ToInt64(objJson["time"]));
			}
			else
			{
				Timestamp = DateTime.Now;
			}
			for (int i = 0; i < 8; i++)
			{
				Data[i] = Convert.ToByte(((System.Collections.ArrayList)objJson["data"])[i]);
			}
		}

		public override bool Equals(object obj){
			CANMessage other = (CANMessage)obj;
			if(ID == other.ID && Length == other.Length && Extended == other.Extended && Remote == other.Remote && Overrun == other.Overrun){
				for(int i = 0; i < 8; i++){
					if (Data[i] != other.Data[i]) return false;
				}
				return true;
			}
			return false;
		}
		public override int GetHashCode(){
			byte[] hashthis = new byte[15];
			Array.Copy(Data, 0, hashthis, 0, 8);
			hashthis[8] = (byte)(ID >> 24);
			hashthis[9] = (byte)(ID >> 16);
			hashthis[10] = (byte)(ID >> 8);
			hashthis[11] = (byte)(ID & 0xFF);
			hashthis[12] = (byte)(Extended ? 1 : 0);
			hashthis[13] = (byte)(Remote ? 1 : 0);
			hashthis[14] = (byte)(Overrun ? 1 : 0);
			return (int)Utilities.CRC32(hashthis);
		}

		public int CompareTo(CANMessage other){
			return DateTime.Compare(Timestamp, other.Timestamp);
		}

		public override string ToString(){
			return "{" + string.Format("\"bus\": {0}, \"id\": {1}, \"len\": {2}, \"r\": {3}, \"e\": {4}, \"o\": {5}, \"data\": [{6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}], \"time\": {14}",
				BusID, ID, Length, Remote ? 1 : 0, Extended ? 1 : 0, Overrun ? 1 : 0, Data[0], Data[1], Data[2], Data[3], Data[4], Data[5], Data[6], Data[7], Timestamp.ToBinary()) + "}";
		}
	}
}

// Author Jacob A. Psimos

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;

namespace LastPacketOrganizer
{
	public class CANMessageContainer
	{
		protected Dictionary<string, List<CANMessage>> listMap = new Dictionary<string, List<CANMessage>>();
		public Type ExtendedType { get; protected set; }

		public CANMessageContainer(){
			ExtendedType = typeof(CANMessageContainer);
		}

		public CANMessageContainer(string strFileName)
		{
			ExtendedType = typeof(CANMessageContainer);
			Load(strFileName);
		}

		public string[] GetIDs(){
			return listMap.Keys.ToArray();
		}

		public List<CANMessage> GetList(string strMsgID){
			List<CANMessage> listCopy = new List<CANMessage>();
			if(listMap.ContainsKey(strMsgID)){
				listCopy.AddRange(listMap[strMsgID]);
			}
			return listCopy;
		}

		protected bool AddToListMap(CANMessage msg){
			string strMsgID = msg.ID.ToString(msg.Extended ? "X8" : "X3");
			if (!listMap.ContainsKey(strMsgID)){
				List<CANMessage> newList = new List<CANMessage>();
				newList.Add(msg);
				listMap.Add(strMsgID, newList);
			}else{
				listMap[strMsgID].Add(msg);
			}
			return true;
		}

		protected void RegenerateListMap(List<CANMessage> unsortedMessages){
			listMap.Clear();
			foreach(CANMessage msg in unsortedMessages){
				this.AddToListMap(msg);
			}
		}

		public virtual void Save(string strFileName){
			StreamWriter w = new StreamWriter(File.OpenWrite(strFileName));
			List<CANMessage> messages = new List<CANMessage>();
			foreach(string strMsgID in listMap.Keys){
				messages.AddRange(listMap[strMsgID]);
			}
			messages.Sort();
			foreach(CANMessage msg in messages){
				w.WriteLine(msg.ToString());
			}
			w.Close();
		}

		public virtual void Load(string strFileName){
			JavaScriptSerializer jss = new JavaScriptSerializer();
			StreamReader streamReader = new StreamReader(File.OpenRead(strFileName));
			listMap.Clear();
			while (!streamReader.EndOfStream)
			{
				CANMessage msg = new CANMessage(streamReader.ReadLine(), jss);
				this.AddToListMap(msg);
			}
			streamReader.Close();
		}
	}
}

// Author Jacob A. Psimos

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace LastPacketOrganizer
{
	public class CANMessageList : CANMessageContainer
	{
		private List<CANMessage> list = new List<CANMessage>();

		public CANMessageList(){
			ExtendedType = typeof(CANMessageList);
		}

		public CANMessageList(string readFromFile)
		{
			ExtendedType = typeof(CANMessageList);
			JavaScriptSerializer jss = new JavaScriptSerializer();
			StreamReader streamReader = new StreamReader(File.OpenRead(readFromFile));
			while (!streamReader.EndOfStream)
			{
				CANMessage msg = new CANMessage(streamReader.ReadLine(), jss);
				Add(msg);
			}
			streamReader.Close();
		}

		public void Add(CANMessage msg){
			AddToListMap(msg);
			list.Add(msg);
		}

		public bool Contains(CANMessage msg){
			return list.Contains(msg);
		}

		public void Clear(){
			listMap.Clear();
			list.Clear();
		}

		public int Count(){
			return list.Count;
		}

		public uint Intersect(CANMessageList otherList){
			uint numRemoved = 0;
			List<CANMessage> newList = new List<CANMessage>();
			foreach(CANMessage msg in list){
				if (otherList.list.Contains(msg)){
					newList.Add(msg);
				}else{
					numRemoved++;
				}
			}
			list = newList;
			RegenerateListMap(list);
			return numRemoved;
		}

		public uint Complement(CANMessageList otherList){
			uint numRemoved = 0;
			List<CANMessage> newList = new List<CANMessage>();
			foreach(CANMessage msg in list){
				if(!otherList.Contains(msg)){
					newList.Add(msg);
				}else{
					numRemoved++;
				}
			}
			list = newList;
			RegenerateListMap(list);
			return numRemoved;
		}
	}
}

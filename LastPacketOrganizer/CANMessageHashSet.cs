// Author Jacob A. Psimos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
using System.Collections;

namespace LastPacketOrganizer
{
	public class CANMessageHashSet : CANMessageContainer
	{
		private HashSet<CANMessage> hashSet = new HashSet<CANMessage>();
		public uint Duplicates { get; private set; }

		public CANMessageHashSet(){
			ExtendedType = typeof(CANMessageHashSet);
			Duplicates = 0;
		}

		public CANMessageHashSet(string readFromFile){
			Load(readFromFile);
		}

		public override void Save(string strFileName){
			StreamWriter w = new StreamWriter(File.OpenWrite(strFileName));
			foreach(CANMessage msg in hashSet){
				w.WriteLine(msg.ToString());
			}
			w.Close();
		}

		public override void Load(string strFileName)
		{
			ExtendedType = typeof(CANMessageHashSet);
			JavaScriptSerializer jss = new JavaScriptSerializer();
			StreamReader streamReader = new StreamReader(File.OpenRead(strFileName));
			while (!streamReader.EndOfStream)
			{
				CANMessage msg = new CANMessage(streamReader.ReadLine(), jss);
				if (!Add(msg)) Duplicates += 1;
			}
			streamReader.Close();
		}

		public int Count(){
			return hashSet.Count;
		}

		public void Clear(){
			listMap.Clear();
			hashSet.Clear();
			Duplicates = 0;
		}

		public bool Add(CANMessage msg){
			AddToListMap(msg);
			return hashSet.Add(msg);
		}

		public bool Contains(CANMessage msg){
			return hashSet.Contains(msg);
		}

		public uint Intersect(CANMessageHashSet other){
			uint numRemoved = 0;
			HashSet<CANMessage> newHashSet = new HashSet<CANMessage>();
			foreach(CANMessage msg in hashSet){
				if(other.hashSet.Contains(msg)){
					newHashSet.Add(msg);
				}else{
					numRemoved++;
				}
			}
			hashSet = newHashSet;
			Duplicates = 0;
			RegenerateListMap(hashSet.ToList());
			return numRemoved;
		}

		public uint Complement(CANMessageHashSet other)
		{
			uint numRemoved = 0;
			HashSet<CANMessage> newHashSet = new HashSet<CANMessage>();
			foreach (CANMessage msg in hashSet){
				if(!other.hashSet.Contains(msg)){
					newHashSet.Add(msg);
				}else{
					numRemoved++;
				}
			}
			hashSet = newHashSet;
			Duplicates = 0;
			RegenerateListMap(hashSet.ToList());
			return numRemoved;
		}
	}
}

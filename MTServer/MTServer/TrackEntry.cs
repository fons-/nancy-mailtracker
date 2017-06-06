using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTServer
{
	public struct TrackEntry
	{
		public string tag;
		public TrackInfo info;

		public TrackEntry(string tag, TrackInfo info)
		{
			this.tag = tag;
			this.info = info;
		}

		public TrackEntry(string tag, string hostAdress, DateTime dateTime)
		{
			this.tag = tag;
			info = new TrackInfo(hostAdress, dateTime);
		}

		public override string ToString()
		{
			return tag + ": " + info;
		}
	}

	public struct TrackInfo
	{
		string hostAddress;
		DateTime dateTime;

		public TrackInfo(string hostAddress, DateTime dateTime)
		{
			this.hostAddress = hostAddress;
			this.dateTime = dateTime;
		}

		public override string ToString()
		{
			return "{" + dateTime + ", " + hostAddress + "}";
		}
	}
}

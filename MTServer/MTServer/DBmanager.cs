using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTServer
{
	public static class DBmanager
	{
		private static string dbPath;
		private static LiteDatabase db;
		private static LiteCollection<TrackEntry> trackCol;
		public static void CreateOrLoad(string path)
		{
			dbPath = path;
			db = new LiteDatabase(path);

			trackCol = db.GetCollection<TrackEntry>("trackEntries");
		}

		public static void Add(TrackEntry entry)
		{
			trackCol.Insert(entry);
		}

		public static IEnumerable<TrackEntry> Get(string tag)
		{
			return trackCol.Find(x => x.tag == tag);
		}
	}
}

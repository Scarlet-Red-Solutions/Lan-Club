using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lan_Club_Toernooi.Utils
{
	public class DbUtils
	{
		/*
				public const string Insert_File = "INSERT INTO TBL_SYNCDATA(ID, SYNCPATHID, FILENAME, FILEDATE, SYNCDATE, ISSYNCED, ISWATCHED, SEASON, EPISODE, ISMISSING ) VALUES(@id, @syncpathid, @filename, @filedate, @syncdate, @issynced, @iswatched, @season, @episode, @ismissing)";
		 
		 		public static bool SyncFiles_Insert(string connString, SyncPath sp, SyncFile sf)
				{
					using (SQLiteConnection c = new SQLiteConnection(connString))
					{
						c.Open();
						using (SQLiteCommand cmd = new SQLiteCommand(Insert_File, c))
						{
							cmd.Parameters.AddWithValue(Param_FileID, sf.ID);
							cmd.Parameters.AddWithValue(Param_FilePathID, sp.ID);
							cmd.Parameters.AddWithValue(Param_FileName, sf.File.Name);
							cmd.Parameters.AddWithValue(Param_FileDate, sf.File.CreationTime);
							cmd.Parameters.AddWithValue(Param_FileSyncDate, sf.SyncDate);
							cmd.Parameters.AddWithValue(Param_FileIsSynced, sf.IsSynced);
							cmd.Parameters.AddWithValue(Param_FileIsWatched, sf.IsWatched);
							cmd.Parameters.AddWithValue(Param_FileSeason, sf.Season);
							cmd.Parameters.AddWithValue(Param_FileEpisode, sf.Episode);
							cmd.Parameters.AddWithValue(Param_FileIsMissing, sf.IsMissing);

							return cmd.ExecuteNonQuery() > 0;
						}
					}
				}
		 * 
		 * 
		 * 
		 */
	}
}

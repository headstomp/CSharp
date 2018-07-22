using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using UserInterface.Models;

namespace UserInterface.DataAccess
{
    public class SqliteConnector : IDataConnection
    {

        public static List<CodeModel> LoadProgram()
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.CnnString(GlobalConfig.db)))
            {
                var output = cnn.Query<CodeModel>("select * from Code", new DynamicParameters());
                return output.ToList();
            }
        }

 
        public CodeModel CreateProgram(CodeModel model)
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.CnnString(GlobalConfig.db)))
            {
                cnn.Execute("Insert into Code Name, Language, Github) values (@Name, @Language, @Github) ", model);

                //TODO: Get new ID 

                return model;

            }
        }

        public CodeModel DeleteProgram(CodeModel model)
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.CnnString(GlobalConfig.db)))
            {
                cnn.Execute("Delete from Code Ehere Id = @Id ", model);

                return model;

            }
        }


        // Music
        public static List<MusicModel> LoadSong()
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.CnnString("SQLite")))
            {
                var output = cnn.Query<MusicModel>("select * from Music", new DynamicParameters());
                return output.ToList();
            }
        }


        public MusicModel CreateSong(MusicModel model)
        {
            using (IDbConnection cnn = new SQLiteConnection(GlobalConfig.CnnString(GlobalConfig.db)))
            {
                cnn.Execute("Insert into Music Name, Artist, Year, Alblum, CoverArt, Rank) values (@Name, @Artist, @Year, @Alblum, @CoverArt, @ Rank) ", model);

                //TODO: Get new ID 

                return model;

            }
        }
    }
}
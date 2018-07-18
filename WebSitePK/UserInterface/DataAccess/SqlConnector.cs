using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface;
using UserInterface.Models;


namespace UserInterface.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public CodeModel CreateProgram(CodeModel model)
        {
            throw new NotImplementedException();
        }
        public MusicModel CreateSong(MusicModel model)
        {
            throw new NotImplementedException();
        }
    }
}

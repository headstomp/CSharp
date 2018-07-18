using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInterface.Models;

namespace UserInterface.DataAccess
{
    public interface IDataConnection
    {
        CodeModel CreateProgram(CodeModel model);
        MusicModel CreateSong(MusicModel model);
    }
}

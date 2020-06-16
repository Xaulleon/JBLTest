using System.Collections.Generic;
using Prueba.Models;

namespace Prueba.Data
{
    public interface ISingerRepo
    {
        Singer GetSinger(int singer_id);

    }
}
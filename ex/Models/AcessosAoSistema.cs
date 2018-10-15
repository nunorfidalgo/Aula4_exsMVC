using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ex.Models
{
    public class AcessosAoSistema
    {
        public string UserName { get; }
        public int NumTimes { get; }

        public AcessosAoSistema(string username, int num_acessos)
        {
            UserName = username;
            NumTimes = num_acessos;
        }
    }
}
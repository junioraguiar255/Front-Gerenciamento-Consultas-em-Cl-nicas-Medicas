using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysConsultas.Model
{
    public class Usuario
    {
        public string login { get; set; }
        public string senha { get; set; }
        public bool medico { get; set; }
        public bool admin { get; set; }

        public long id { get; set; }


        // Inicializando as propriedades no construtor
        public Usuario()
        {
            login = "";
            senha = "";
            admin = false;
        }
        public Usuario(string loginParam, string senhaParam, bool isAdmin)
        {
            login = loginParam;
            senha = senhaParam;
            admin = isAdmin;
        }

    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UsuarioDTO
    {
        public int cod_usuario { get; set; }
        public string senha_usuario { get; set; }
        public  string nome_usuario{ get; set; }
        public string funcao_usuario { get; set; }
    }
}

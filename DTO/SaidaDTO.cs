using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SaidaDTO
    {
        public int cod_saida { get; set; }
        public int cod_lotacao { get; set; }
        public int cor_carro { get; set; }
        public DateTime dt_saida { get; set; }
        public DateTime hs_saida { get; set; }
        public int qtd_saida { get; set; }
        public int total_saida { get; set; }
        public int cod_usuario { get; set; }
    }
}

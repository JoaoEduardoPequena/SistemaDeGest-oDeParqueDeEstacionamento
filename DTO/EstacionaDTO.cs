using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EstacionaDTO
    {
        public int  cod_estaciona { get; set; }
        public int cod_posicaoVaga { get; set; }
        public int  cod_patio { get; set; }
        public int cod_usuario { get; set; }
        public int cod_estadoVaga { get; set; }
        public int cor_carro { get; set; }
        public DateTime dt_entrada { get; set; }
        public DateTime hs_entrada { get; set; }
        public int ativo { get; set; }
        public float preco { get; set; }

    }
}

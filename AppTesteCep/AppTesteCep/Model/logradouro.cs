using System;
using System.Collections.Generic;
using System.Text;

namespace AppTesteCep.Model
{
    public class Logradouro
    {
        public string CEP { get; set; }
        public string Id_logradouro { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string Id_cidade { get; set; }
        public string UF { get; set; }
        public string Complemento { get; set; }
        public string Descricao_sem_numero { get; set; }
        public string Descricao_cidade { get; set; }    
        public string Codigo_cidade_ibge { get; set; }
        public string Descricao_bairro { get; set; }

    }
}

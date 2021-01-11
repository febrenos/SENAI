using System;
using System.Collections.Generic;

namespace ExemploWebApiBd.Domains
{
    public partial class Selecao
    {
        public Selecao()
        {
            Jogador = new HashSet<Jogador>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public byte[] Bandeira { get; set; }
        public byte[] Uniforme { get; set; }
        public string Escalacao { get; set; }

        public virtual ICollection<Jogador> Jogador { get; set; }
    }
}

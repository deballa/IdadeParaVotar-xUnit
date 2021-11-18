using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadeParaVotar
{
    public class PodeVotar
    {
        public static string Votar(int vlIdade)
        {
            string voto = "";

            if ((vlIdade < 0) || (vlIdade > 110))
                voto = "valor inválido";
            else
                if (vlIdade < 16)
                voto = "Não pode votar";
            else
                if ((vlIdade >= 16) && (vlIdade < 18))
                voto = "Voto opcional";
            else
                if (vlIdade >= 18)
                voto = "Pode votar";

            return voto;
        }

    }
}

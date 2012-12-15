using System;
using System.Text.RegularExpressions;

namespace Cifrado_Cesar
{
    public class Cifrado_Cesar : ICifrado_Cesar
    {
        private const int Constante_a = 97;
        private const int Constante_z = 122;

        public string Cifrado(string cadena, int numeroMagico) {
            if (numeroMagico < 0) 
                throw new ArgumentException("número mágico menor que 0 no permitido");
            if (numeroMagico == 0) 
                return cadena;
            
            string fraseConvertida = string.Empty;
            for (int i = 0; i < cadena.Length; i++)
            {
                if (EsLetra(cadena, i))
                {
                    if (ConvierteANumeroCaracterMasDesplazamiento(cadena, numeroMagico, i) >= Constante_a &&
                        ConvierteANumeroCaracterMasDesplazamiento(cadena, numeroMagico, i) <= Constante_z)
                    
                        fraseConvertida += 
                            Convert.ToChar(Convert.ToInt32(cadena[i]) + numeroMagico).ToString().ToLower();
                    else
                        fraseConvertida +=
                            Convert.ToChar(((Convert.ToInt32(cadena[i] + numeroMagico) - 1) - Constante_z) + Constante_a).ToString().ToLower();
                }
                else 
                    fraseConvertida += cadena[i];
            }
            return fraseConvertida;
        }

        private static int ConvierteANumeroCaracterMasDesplazamiento(string cadena, int numeroMagico, int i)
        {
            return Convert.ToInt32(char.ToLower(cadena[i]) + numeroMagico);
        }

        private static bool EsLetra(string cadena, int i)
        {
            return Regex.IsMatch(cadena[i].ToString(), "[a-zA-Z]");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

    public static class Validaciones // vamos a validar por regex
    {
        public static String camposInvalidos;
        static public void inicializarValidador()
        {
            camposInvalidos = default(string);
        }
        static public void esValido(String nombreCampo, String aValidar, RegexType regex)
        {
            if (!Regex.IsMatch(aValidar, regex.Regex()))
                camposInvalidos += "Campo inválido: " + nombreCampo + ", ya que no cumple con la restricción de: " + regex.Significado() + "\n";
        }
        public interface RegexType
        {
            String Regex();
            String Significado();
        }
        public class Letras : RegexType
        {
            public String Regex() { return @"^[a-zA-Z]+$"; }
            public String Significado() { return "solo letras"; }
        }
    }
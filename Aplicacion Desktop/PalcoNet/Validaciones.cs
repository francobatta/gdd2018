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
                camposInvalidos += "Campo inválido: " + nombreCampo + ", ya que no cumple con la restricción de:\n " + regex.Significado() + "\n";
        }
        public interface RegexType
        {
            String Regex();
            String Significado();
        }
        public class Letras : RegexType
        {
            public String Regex() { return @"^([a-zA-Z]+\s*[a-zA-Z]+)+$"; }
            public String Significado() { return "solo letras y espacios"; }
        }
        public class NumerosGuion : RegexType
        {
            public String Regex() { return @"^[0-9\-]+[\s]*$"; }
            public String Significado() { return "números sin/con guión"; }
        }
        public class Numeros : RegexType
        {
            public String Regex() { return @"^[0-9]+[\s]*$"; }
            public String Significado() { return "solo números"; }
        }
        public class NumerosLetrasGuion : RegexType
        {
            public String Regex() { return @"^([a-zA-Z0-9-]+\s*[a-zA-Z0-9-]+)+$"; }
            public String Significado() { return "números, letras, guión"; }
        }
        public class NumeroNoCreo : RegexType
        {
            public String Regex() { return @"^[1-9]+$"; }
            public String Significado() { return "número no cero"; }
        }
        public class Email : RegexType
        {
            public String Regex()
            {
                return @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            }
            public String Significado() { return "formato E-Mail"; }
        }
    }
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace WinFormsApp1 {
    class Utils {

        public static bool validarDecimal(char e) {

            char[] signoDecimal = { ',', '-' };

            if (Char.IsDigit(e) || signoDecimal.Contains(e)) {
                return false;

            } else if (Char.IsControl(e)) { //permitir teclas de control como retroceso
                return false;
            } else {
                //el resto de teclas pulsadas se desactivan
                return true;
            }
        }

        public static bool validarInt(char e) {

            if (Char.IsDigit(e)) {
                return false;
            } else if (Char.IsControl(e)) { //permitir teclas de control como retroceso
                return false;
            } else {
                //el resto de teclas pulsadas se desactivan
                return true;
            }
        }
    }
}

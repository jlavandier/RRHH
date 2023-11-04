using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Recursos_Humanos.Datos
{
    public class Validar
    {
        public static Boolean ValidarFormulario(Control objeto, ErrorProvider errorProvider) {
            Boolean HayErrores = false;
            foreach (Control item in objeto.Controls) {
                if (item is Errortxtbox) {
                    Errortxtbox obj = (Errortxtbox)item;

                    if (obj.Validar == true)
                    {
                        if (String.IsNullOrEmpty(obj.Text.Trim()))
                        {
                            errorProvider.SetError(obj,"No puede estar vacio");
                            HayErrores = true;
                        }
                    }
                    if (obj.SoloNumeros == true)
                    {
                        int cont = 0, letrasencon = 0;
                        foreach (char letra in obj.Text.Trim()){
                            if (char.IsLetter(obj.Text.Trim(), cont)) {
                                letrasencon++;
                            }
                            cont++;
                        }
                        if (letrasencon != 0) {
                            HayErrores = true;
                            errorProvider.SetError(obj, "Solo Numeros");
                        }
                        
                    }
                    
                }
            }
            return HayErrores;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Core.Numero;

namespace WcfLaboratorio.Calculadora
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MiCalculadora : IMiCalculadora
    {
        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public Numero RealizarOperacionBinaria(char elOperador, Numero elPrimerNumero, Numero elSegundoNumero, Numero Resultado)
        {
            var laReferencia = new Core.Numero.Dominio.Especificaciones.RealizarCalculo();
            Numero elResultado = laReferencia.OperadorBinario(elOperador, elPrimerNumero, elSegundoNumero, Resultado);
            return elResultado;
        }
    }
}

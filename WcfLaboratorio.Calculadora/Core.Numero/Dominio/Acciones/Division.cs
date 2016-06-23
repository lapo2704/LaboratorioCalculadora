﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Acciones
{
    public class Division
    {
        public Numero OperarDivision(Numero elPrimerNumero, Numero elSegundoNumero, Numero elResultado)
        {
            Numero resultado = null;
            Numero resultadoFinal = null;
            var validarBases = new Validaciones.ValidarBase();

            string PrimerNumero = validarBases.CambioBase10(elPrimerNumero, elPrimerNumero.laBase);
            string SegundoNumero = validarBases.CambioBase10(elSegundoNumero, elSegundoNumero.laBase);
            double elResultadoNumerico = Convert.ToDouble(PrimerNumero) / Convert.ToDouble(SegundoNumero);
            resultado = new Numero(elResultadoNumerico.ToString(), 10);
            string TercerNumero = validarBases.CambioBase10aOtras(resultado, elResultado.laBase);
            double elResultadoNumericoConvertido = Convert.ToDouble(TercerNumero);
            resultadoFinal = new Numero(elResultadoNumericoConvertido.ToString(), elResultado.laBase);
            return (resultadoFinal);

        }
    }

}

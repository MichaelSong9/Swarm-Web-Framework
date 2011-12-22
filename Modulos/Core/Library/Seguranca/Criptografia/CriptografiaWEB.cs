﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Swarm.Core.Library.Seguranca.Criptografia
{
    public class CriptografiaWEB : CriptografiaDES3
    {
        public CriptografiaWEB()
            : base()
        {
        }

        #region Constantes

        private const string PREVENCAO_MAIS = "swarmDOTswarm";

        #endregion

        #region Métodos

        public override string Criptografar(string texto)
        {
            return base.Criptografar(texto).Replace("+", PREVENCAO_MAIS);
        }

        public override string Descriptografar(string texto)
        {
            return base.Descriptografar(texto.Replace(PREVENCAO_MAIS, "+"));
        }

        #endregion
    }
}

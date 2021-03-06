﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Swarm.Utilitarios;

namespace Swarm.Core.Web.FrontController.Common
{
    public class LogoffPageFacade : PageFacade
    {
        public LogoffPageFacade(HttpContext conteudo)
            : base(conteudo)
        {
        }

        public override bool ValidarAutenticacao()
        {
            return Valor.Ativo;
        }

        public override bool ValidarPermissoes()
        {
            return Valor.Ativo;
        }

        public override string GetURI()
        {
            return UrlMap.Find(Map.Seguranca.Logoff).Url;
        }

        #region Métodos Externos

        public static bool IsTrue(int pageID)
        {
            return UrlMap.Find(Map.Seguranca.Logoff).ID == pageID;
        }

        #endregion
    }
}

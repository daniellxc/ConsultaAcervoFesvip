using Consulta.WebForm.Cenarios.Seguranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Consulta.WebForm.Cenarios
{
    public class FormPadrao:Page
    {
        public void Mensagem(string mensagem,HttpResponse response)
        {
            //ErroPage page = new ErroPage();
            ErroPage.Mensagem = mensagem;
            response.Redirect("~/Cenarios/Seguranca/ErroPage.aspx");
        }
    }
}
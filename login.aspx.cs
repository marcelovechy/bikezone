using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bikezone
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_enviar_Click(object sender, EventArgs e)
        {
            if (tb_utilizador.Text == "bike" && tb_palavraPasse.Text == "cliente@123")
            {
                Session["Utilizador"] = tb_utilizador.Text;
                Response.Redirect("loja.aspx");
            }
            else
            {
                lbl_mensagem.Visible = true;
            }
        }
    }
}
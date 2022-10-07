using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bikezone
{
    public partial class loja : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // se a var de session ñ existir manda de volta para o login
            if (Session["Utilizador"] == null)
                Response.Redirect("login.aspx");
        }

        protected void btn_enviar1_Click(object sender, EventArgs e)
        {


            Session["nome"] = tb_nome.Text;
            Session["morada"] = tb_morada.Text;
            Session["email"] = tb_email.Text;
            Session["codigoPostal"] = tb_codigoPostal.Text;
            Session["dataNascimento"] = tb_data.Text;
            Session["genero"] = cbl_genero.Text;
            Session["tipoArtigo"] = ddl_tipoArtigo.SelectedItem.Text;
            Session["marca"] = ddl_marca.SelectedItem.Text;
            Session["bike"] = ddl_bike.SelectedItem.Text;

            Session["artigos"] += "Tipo: " + Session["tipoArtigo"] + ", marca: " + Session["marca"] + ", modelo: " + Session["bike"];

            Response.Redirect("final.aspx");

            Session.Clear();
            Session.Abandon();

        }

        protected void cbl_genero_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stop = 0;

            for (int i = 0; i < cbl_genero.Items.Count; i++)
            {

                if (cbl_genero.Items[i].Selected)
                {

                    Session["genero"] = cbl_genero.Text;
                    stop = 1;
                    break;
                } 

            }
        }

        protected void dll_tipoArtigo_SelectedIndexChanged(object sender, EventArgs e)
        {

            // limpar a memória
            
            ddl_marca.Items.Clear();

            if (ddl_tipoArtigo.SelectedItem.Text == "BTT")
            {
                ddl_marca.Items.Add("BTT Z");
                ddl_marca.Items.Add("BTT Y");

                
            }
            else if (ddl_tipoArtigo.SelectedItem.Text == "BMX")
            {
                ddl_marca.Items.Add("BMX Y");
                ddl_marca.Items.Add("BMX Z");

                
            }
            else if (ddl_tipoArtigo.SelectedItem.Text == "Elétricas")
            {
                ddl_marca.Items.Add("Elétricas Y");
                ddl_marca.Items.Add("Elétricas Z");

                
            }
            else if (ddl_tipoArtigo.SelectedItem.Text == "Trotinetes")
            {
                ddl_marca.Items.Add("Trotinetes Y");
                ddl_marca.Items.Add("Trotinetes Z");

                
            }


        }

        protected void ddl_marca_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            ddl_bike.Items.Clear();

            if (ddl_marca.SelectedItem.Text == "BTT Y")
            {
                ddl_bike.Items.Add("BTT Y AZUL");
                ddl_bike.Items.Add("BTT Y PRETO");
            }

            else if (ddl_marca.SelectedItem.Text == "BTT Z")
            {
                ddl_bike.Items.Add("BTT Z AZUL");
                ddl_bike.Items.Add("BTT Z AZUL");
            }


            else if (ddl_marca.SelectedItem.Text == "BMX Y")
            {
                ddl_bike.Items.Add("BMX Y AZUL");
                ddl_bike.Items.Add("BMX Y PRETO");
            }
            else if (ddl_marca.SelectedItem.Text == "BMX Z")
            {
                ddl_bike.Items.Add("BMX Z AZUL");
                ddl_bike.Items.Add("BMX Z PRETO");
            }
            else if (ddl_marca.SelectedItem.Text == "Elétricas Y")
            {
                ddl_bike.Items.Add("Elétricas Y AZUL");
                ddl_bike.Items.Add("Elétricas Y PRETO");
            }
            else if (ddl_marca.SelectedItem.Text == "Elétricas Z")
            {
                ddl_bike.Items.Add("Elétricas Z AZUL");
                ddl_bike.Items.Add("Elétricas Z PRETO");
            }
            else if (ddl_marca.SelectedItem.Text == "Trotinetes Y")
            {
                ddl_bike.Items.Add("Trotinetes Y AZUL");
                ddl_bike.Items.Add("Trotinetes Y PRETO");
            }
            else if (ddl_marca.SelectedItem.Text == "Trotinetes Z")
            {
                ddl_bike.Items.Add("Trotinetes Z AZUL");
                ddl_bike.Items.Add("Trotinetes Z PRETO");
            }
        }
    }
}
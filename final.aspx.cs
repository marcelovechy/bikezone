using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bikezone
{
    public partial class final : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // se a var de session ñ existir manda de volta para o login
            if (Session["utilizador"] == null)

                Response.Redirect("login.aspx");

            lbl_nome.Text = Session["nome"].ToString();
            lbl_morada.Text = Session["morada"].ToString();
            lbl_email.Text = Session["email"].ToString();
            lbl_codigoPostal.Text = Session["codigoPostal"].ToString();
            lbl_dataNascimento.Text = Session["dataNascimento"].ToString();
            lbl_genero.Text = Session["genero"].ToString();

            lbl_produtos.Text = Session["artigos"].ToString();
        }

        protected void btn_pdf_Click(object sender, EventArgs e)
        {
            string caminho = ConfigurationSettings.AppSettings.Get("caminho");

            string caminhoPDFS = ConfigurationSettings.AppSettings.Get("caminhoPDFS");

            string pdfTemplate = caminhoPDFS + "template\\templateBikezone.pdf";

            string nomePdf = DateTime.Now.ToString().Replace("/", "").Replace(" ", "").Replace(":", "") + ".pdf";

            string novoFicheiro = caminhoPDFS + nomePdf;

            PdfReader pdfreader = new PdfReader(pdfTemplate);

            PdfStamper pdfstamper = new PdfStamper(pdfreader, new FileStream(novoFicheiro, FileMode.Create));



            AcroFields pdfFormFields = pdfstamper.AcroFields;



            pdfFormFields.SetField("nome", lbl_nome.Text);
            pdfFormFields.SetField("morada", lbl_morada.Text);
            pdfFormFields.SetField("email", lbl_email.Text);
            pdfFormFields.SetField("codigoPostal", lbl_codigoPostal.Text);
            pdfFormFields.SetField("dataNasc", lbl_dataNascimento.Text);


            if (lbl_genero.Text == "feminino")
            {

                pdfFormFields.SetField("feminino", lbl_genero.Text);
            }
            else
            {
                pdfFormFields.SetField("masculino", lbl_genero.Text);
            }

            pdfFormFields.SetField("artigos", lbl_produtos.Text);



            pdfstamper.Close();
            Response.Redirect(caminho + "/PDFS/" + caminhoPDFS);
        }

        protected void btn_pdfemail_Click(object sender, EventArgs e)
        {
            // fazemos a busca do caminho e do url no web_Config, facilitando alterações futuras por parte do cliente
            string caminho = ConfigurationSettings.AppSettings.Get("PathFicheirosPDFS");
            string urlsite = ConfigurationSettings.AppSettings.Get("SiteURL");





            // apontamos pro template
            string pdfTemplate = caminho + "template\\templateBikezone.pdf";
            // teste para verificar se ele esta a fazer o caminho
            //Response.Write(pdfTemplate);
            // copiar o caminho e colar no browser





            // nome do ficheiro do PDF que vai ser gerado
            string nomePDF = DateTime.Now.ToString().Replace(":", "").Replace
                ("/", "").Replace(" ", "") + ".pdf";


            string novoFicheiro = caminho + nomePDF;


            // ver o pdf que está no template
            PdfReader pdfreader = new PdfReader(pdfTemplate);



            // criar um novo pdf com base no antigo template
            PdfStamper pdfstamper = new PdfStamper(pdfreader, new FileStream
                (novoFicheiro, FileMode.Create));



            // escrever nos campos do PDF
            AcroFields campos = pdfstamper.AcroFields;
            campos.SetField("nome", lbl_nome.Text);
            campos.SetField("morada", lbl_morada.Text);
            campos.SetField("email", lbl_email.Text);
            campos.SetField("codigoPostal", lbl_codigoPostal.Text);
            campos.SetField("dataNascimento", lbl_dataNascimento.Text);
            campos.SetField("genero", lbl_genero.Text);
            campos.SetField("artigos", lbl_produtos.Text);


            pdfstamper.Close();


            // agr redirecionar para o ficheiro mostrar na tela
            //Response.Redirect(urlsite + "/PDFS/" + nomePDF);
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient servidor = new SmtpClient();


                mail.From = new MailAddress("Marcelo.simiao.t0122032@edu.atec.pt");
                mail.To.Add(new MailAddress(lbl_email.Text));
                mail.Subject = "Socio da loja";

                // para dizer que é html
                mail.IsBodyHtml = true;
                mail.Body = "Obrigado por ser socio";


                System.Net.Mail.Attachment anexo;


                anexo = new System.Net.Mail.Attachment(caminho + nomePDF);

                mail.Attachments.Add(anexo);

                servidor.Host = "smtp.office365.com";
                servidor.Port = 587;

                servidor.Credentials = new NetworkCredential("Marcelo.simiao.t0122032@edu.atec.pt",
                      "Am190513@");
                servidor.EnableSsl = true;
                servidor.Send(mail);


                lbl_mensagem.Text = "Enviado com sucesso.";

            }
            catch (Exception ex)
            {
                lbl_mensagem.Text = ex.Message;
            }
        }

        protected void btn_excel_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.AddHeader("Content-Disposition", "attachment; filename=excel.xls");

            Response.Cache.SetCacheability(HttpCacheability.NoCache);



            Response.ContentType = "application/vnd.ms-excel";
            Response.BinaryWrite(System.Text.Encoding.UTF8.GetPreamble());



            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);



            htw.Write("<table><tr><td>Nome:</td><td>" + lbl_nome.Text + "</td></tr><td>Morada:</td><td>" + lbl_morada.Text + "</td></tr><td>Email:</td><td>" + lbl_email.Text + "</td></tr><td>Código postal:</td><td>" + lbl_codigoPostal.Text + "</td></tr><td>Data de Nascimento:</td><td>" + lbl_dataNascimento.Text + "</td></tr><td>Genero:</td><td>" + lbl_genero.Text + "</td></tr><td>Artigos:</td><td>" + lbl_produtos.Text + "</td></tr></table>");



            Response.Write(sw.ToString());
            Response.End();
        }
    }
}
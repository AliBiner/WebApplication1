using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Tasarim : System.Web.UI.MasterPage
    {
        FinalEntities fe = new FinalEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var a = fe.Kullanicis.Where(x => x.Email == txtEmail.Text && x.Sifre == txtSifre.Text).FirstOrDefault();
            if (a != null)
            {
                lblGiris.Text = "Giriş Başarılı.";
                lblGiris.Visible = true;
            }
            else
            {
                lblGiris.Text = "Giriş İşlemi Başarısız.";
                lblGiris.Visible = true;
            }
        }

        protected void btnSignin_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignIn.aspx");
        }
    }
}
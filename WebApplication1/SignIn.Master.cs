using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SignIn : System.Web.UI.MasterPage
    {
        FinalEntities fe = new FinalEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignin_Click(object sender, EventArgs e)
        {
            Kullanici k = new Kullanici();
            k.Email = txtEmail.Text;
            k.Sifre = txtSifre.Text;
            var a = fe.Kullanicis.Where(x => x.Email == txtEmail.Text && x.Sifre == txtSifre.Text).FirstOrDefault();
            if (a != null)
            {

            }
            else {
                fe.Kullanicis.Add(k);
                fe.SaveChanges();
            }


            FileUpload1.SaveAs(Server.MapPath("/Dosyalar/" + FileUpload1.FileName));
            Image1.ImageUrl = "/Dosyalar/" + FileUpload1.FileName;
        }
    }
}
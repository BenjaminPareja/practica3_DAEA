using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SchoolBLL;
using SchoolEntities;
namespace SchoolWEB
{
    public partial class CreatePerson : System.Web.UI.Page
    {
        CPersonBLL personB = new CPersonBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            CPerson per = new CPerson();
            per.PersonID = Convert.ToInt32(txtID.Text);
            per.FirstName = txtFirst.Text;
            per.LastName = txtLast.Text;
            per.HireDate = DateTime.Now;
            per.EnrollmentDate = DateTime.Now;

            personB.InsertarPersona(per);
            //Response.Redirect("Default.aspx");
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
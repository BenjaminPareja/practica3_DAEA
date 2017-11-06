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
    public partial class UpdatePerson : System.Web.UI.Page
    {
        CPersonBLL personB = new CPersonBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CPerson per = personB.MostrarPersona((int)Session["PersonID"]);
                txtID.Text = per.PersonID.ToString();
                txtFirst.Text = per.FirstName;
                txtLast.Text = per.LastName;
                txtHire.Text = Convert.ToString(per.HireDate);
                txtEnrollment.Text = Convert.ToString(per.EnrollmentDate);
            }
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            CPerson per = new CPerson();
            per.PersonID = Convert.ToInt32(txtID.Text);
            per.FirstName = txtFirst.Text;
            per.LastName = txtLast.Text;
            per.HireDate = DateTime.Now;
            per.EnrollmentDate = DateTime.Now;

            personB.ModificarPersona(per);
            Response.Redirect("Default.aspx");
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
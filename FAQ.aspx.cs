using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SambhavRestaurant
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // You can perform form validation or processing here.
            string name = txtName.Text;
            string email = txtEmail.Text;
            string message = txtMessage.Text;

            // Send the email or store the contact request in the database
            // For now, let's just output a success message
            Response.Write("<script>alert('Thank you for contacting us, we will get back to you soon!');</script>");

            // Reset the form fields
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtMessage.Text = string.Empty;
        }
    }
}
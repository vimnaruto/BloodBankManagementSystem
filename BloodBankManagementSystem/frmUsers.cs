using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            // add functionality to close this
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Save();
        }

        // defactoring methods 
        
        private void Save() // to save user data database
        {

            try
            {
                var userdata = new UserDataAccess();// create object userdata
               if( userdata.SaveUser(txtUserName.Text, txtEmail.Text, txtPassword.Text, txtFullName.Text, txtContact.Text, txtAddress.Text)) 
                
                {

                    MessageBox.Show("User saved sueccessful");

                }

                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
    
            

           

        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            // Write the code to upload the of the user
            //open file dialog box to select image
            OpenFileDialog open = new OpenFileDialog();

            // filter the file type only allow image file type
            open.Filter = "Image files (*.jpg;*.jpeg;*.png;*.gif;)| *.jpg; *.jpeg; *.png; *.gif;";

            // check if the file is selected or not
            if (open.ShowDialog() == DialogResult.OK) 
            
            {
                //check if the file exist or not
                if (open.CheckFileExists) 
                {
                    //display the selected file on picture box
                    pictureBoxProfilePicture.Image = new Bitmap(open.FileName);
                }
            
            }
        }
    }
}

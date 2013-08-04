using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace eProjectSem3Team5
{
    public partial class UploadPhoto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            StartUpLoad();
        }
        private void StartUpLoad()
        {
            //get the file name of the posted image
            string imgName = FileUpload1.FileName;
            //sets the image path
            string imgPath = "ImageStorage/" + imgName;
            //get the size in bytes that

            int imgSize = FileUpload1.PostedFile.ContentLength;

            //validates the posted file before saving
            if (FileUpload1.PostedFile != null && FileUpload1.PostedFile.FileName != "")
            {
                // 10240 KB means 10MB, You can change the value based on your requirement
                if (FileUpload1.PostedFile.ContentLength > 999999)
                {
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('File is too big.')", true);
                }
                else
                {
                    //then save it to the Folder
                    FileUpload1.SaveAs(Server.MapPath(imgPath));
                    Image1.ImageUrl = "~/" + imgPath;
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Image saved!')", true);
                    try
                    {
                        string sConnectionString = "Data Source=HAIKD-PC\\SQL2008;Initial Catalog=EprojectSem3Team5;User ID=sa;Password=123456";
                        SqlConnection connect = new SqlConnection(sConnectionString);
                        connect.Open();
                        SqlCommand command = new SqlCommand("sp_InsertPicture", connect);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
                        command.Parameters.AddWithValue("@Picture", imgPath);
                        command.ExecuteNonQuery();
                        Response.Write("Insert successfully");
                    }
                    catch (Exception)
                    {

                        Response.Write("NOT successfully");
                    }
                }
            }
        }
    }
}
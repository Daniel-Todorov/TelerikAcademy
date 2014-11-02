using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.ZipUploadingInDb
{
    public partial class Uploader : System.Web.UI.Page
    {
        private FileUploadsContext context;

        public Uploader()
        {
            this.context = new FileUploadsContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonUploadFile_Click(object sender, EventArgs e)
        {
            this.LabelResult.Text = string.Empty;

            if (!this.UploadedFile.HasFile)
            {
                this.LabelResult.Text = "No file selected!";
                this.LabelResult.ForeColor = System.Drawing.Color.Red;

                return;
            }

            if (!this.UploadedFile.PostedFile.FileName.EndsWith(".zip"))
            {
                this.LabelResult.Text = "Only .zip files can be uploaded!";
                this.LabelResult.ForeColor = System.Drawing.Color.Red;

                return;
            }

            Response.Expires = -1;
            try
            {
                HttpPostedFile file = this.UploadedFile.PostedFile;
                ZipFile zipFile = ZipFile.Read(file.InputStream);

                foreach (var zipEntry in zipFile.Entries)
                {
                    if (zipEntry.FileName.EndsWith(".txt"))
                    {
                        MemoryStream memoryStream = new MemoryStream();
                        zipEntry.Extract(memoryStream);

                        memoryStream.Position = 0;
                        StreamReader reader = new StreamReader(memoryStream);

                        this.context.Files.Add(new File()
                        {
                            FileContent = reader.ReadToEnd(),
                            FileName = zipEntry.FileName
                        });
                    }
                    else
                    {
                        this.LabelResult.Text += zipEntry.FileName + "is not .txt file and is not added to database!" + Environment.NewLine;
                        this.LabelResult.ForeColor = System.Drawing.Color.Red;
                    }
                }

                this.context.SaveChanges();

                this.LabelResult.Text = "Text files in the zip are uploaded successfully. Check in your database!";
                this.LabelResult.ForeColor = System.Drawing.Color.Green;

                return;
            }
            catch (Exception ex)
            {
                this.LabelResult.Text = "An error occured while uploading. Please, contact your administrator!";
                this.LabelResult.ForeColor = System.Drawing.Color.Red;

                return;
            }
        }
    }
}
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppWritesToAzureTables_WebRole
{
    public partial class _Default : Page
    {
        CloudStorageAccount account = new CloudStorageAccount(
            new StorageCredentials("gdbcindystorage",
                "0cMLyvmd8dk3HxbkhQewvxeg5AxCVsEX4ft1qcxu9grNR0Zkx7zR0YZmqMpWvLfTyFKkYdaNbjuZFPaXVUHxyA=="), true);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdAddSignIn_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            string email = txtEmail.Text;
            string twitter = txtTwitter.Text;
            AddNewSignIn(name, email, twitter);

        }
        public void AddNewSignIn(string name, string email, string twitter)
        {
            // You could use local development storage 
            //   account = CloudStorageAccount.DevelopmentStorageAccount; 
            // Create the table client. 
            CloudTableClient tableClient = account.CreateCloudTableClient();

            // Create the table if it doesn't exist. 
            CloudTable table = tableClient.GetTableReference("signins");
            table.CreateIfNotExistsAsync();
            SignInEntity siEntity = new SignInEntity(name);
            siEntity.Twitter = twitter;
            siEntity.Email = email;

            // Create the TableOperation that inserts the customer entity. 
            TableOperation insertOperation = TableOperation.Insert(siEntity);

            // Execute the insert operation. 
            table.Execute(insertOperation);

            lblMessage.Text = "Thanks for signing in!";
        }
        public class SignInEntity : TableEntity
        {
            public SignInEntity(string name)
            {
                this.PartitionKey = "sat0616";
                this.RowKey = name;
            }
            public SignInEntity() { }
            public string Email { get; set; }
            public string Twitter { get; set; }
        }


    }
}
using System;
using System.Net;
using System.Security.Policy;
using System.Windows.Forms;
namespace DSEDL
{
    public partial class DefaultWindow : Form
    {
        public DefaultWindow()
        {
            InitializeComponent();
        }

        private void DefaultWindow_Load(object sender, EventArgs e)
        {
            // clean the textBox for location
            
        }


        private async void button2_Click(object sender, EventArgs e)
        {
            
            string id = textBox1.Text; // get the id of the emoji / sticker 
            locationBrowse.ShowDialog();
            string folder = locationBrowse.SelectedPath;
            string location = folder + "\\" + id + ".png";
            if (radioButton1.Checked) // emoji download
            {
                string link = "https://cdn.discordapp.com/emojis/" + id + ".png";
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        byte[] fileBytes = await client.GetByteArrayAsync(link);
                        await File.WriteAllBytesAsync(location, fileBytes);
                        MessageBox.Show("Successful.");
                    } catch
                    {
                        MessageBox.Show("Failed.");
                    }
                }
            }
            if (radioButton2.Checked) // sticker download
            {
                string link = "https://cdn.discordapp.com/stickers/" + id + ".png";
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        byte[] fileBytes = await client.GetByteArrayAsync(link);
                        await File.WriteAllBytesAsync(location, fileBytes);
                        MessageBox.Show("Successful.");
                    }
                    catch
                    {
                        MessageBox.Show("Failed.");
                    }
                }
            }

        }
    }
}

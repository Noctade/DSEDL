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
            textBox2.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            locationBrowse.ShowDialog();
            textBox2.Text = locationBrowse.SelectedPath;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string folder = textBox2.Text;
            if (string.IsNullOrEmpty(folder))
            {
                if (locationBrowse.ShowDialog() == DialogResult.OK)
                {
                    folder = locationBrowse.SelectedPath;
                    textBox2.Text = folder;
                }
                
            }
            string location = folder + "\\" + id + ".png";
            if (radioButton1.Checked)
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
            if (radioButton2.Checked)
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

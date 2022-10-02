using System.IO;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arquivos = Directory.GetFiles(@"C:\Users\marcu\Downloads\Wallpapers", "*.jpg", SearchOption.AllDirectories);
            imagemlistBox1.Items.AddRange(arquivos);
        }

        private void imagemlistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = imagemlistBox1.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void adicionarbutton1_Click(object sender, EventArgs e)
        {
            favoritoslistBox1.Items.Add(imagemlistBox1.Text);
        }

        private void favoritoslistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = favoritoslistBox1.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}
using Refit;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteApiRefit
{
    public partial class Form1 : Form
    {
        private const string HostUrl = "https://api.github.com";

        public Form1()
        {
            InitializeComponent();

        }
        

        private async void Buscar_Click(object sender, EventArgs e)
        {
            picUser.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            lblNome.Visible = false;
            lblLocal.Visible = false;
            lblLink.Visible = false;
            circProgress.Visible = true;
            string login = txtUser.Text;
            var user = await GetDados(login);
            circProgress.Visible = false;

            if (user != null)
            {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                picUser.Visible = true;
                lblNome.Visible = true;
                lblLocal.Visible = true;
                lblLink.Visible = true;
                picUser.Load(user.Avatar);
                lblNome.Text = user.Name;
                lblLink.Text = user.Link;
                lblLocal.Text = user.Local;
            }
        }

        static async Task<UserResponse> GetDados(string login)
        {
            try
            {
                var userClient = RestService.For<IUserAPI>(HostUrl);
                var resp = await userClient.GetUser(login);
                //MessageBox.Show(null, $"Nome: {resp.Name}\nAvatar: {resp.Avatar}\nLink: {resp.Link}\nLocal: {resp.Local}","Dados");
                return resp;
            }
            catch (Exception)
            {
                //MessageBox.Show(null,"Erro: " + e.Message, "Erro");
                MessageBox.Show(null,"Usuário não encontrado! Tente outro.","Não encontrado!");
                return null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picUser.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }
    }
}

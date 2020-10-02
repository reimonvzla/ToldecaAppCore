namespace ToldecaAppCore
{
    using System.Net;
    using System.Windows.Forms;
    using Newtonsoft.Json;
    using Entidades;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using var client = new WebClient();
            string response = client.DownloadString("http://localhost:9778/api/ArticuloProfit/GetArticulo?Emp=demo&CodArticulo=0101002");
            var dataObj = JsonConvert.DeserializeObject<Articulo>(response);
        }

    }
}

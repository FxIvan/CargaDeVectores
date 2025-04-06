using System.Drawing;
using System.Windows.Forms;

namespace CargaDeVectores
{
    public partial class frmCargaDeVectores : Form
    {
        public frmCargaDeVectores()
        {
            InitializeComponent();
        }

        private void frmCargaDeVectores_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            // https://learn.microsoft.com/es-es/dotnet/csharp/tour-of-csharp/tutorials/list-collection
            List<string> vector = new List<string>();

            vector.Add(txtItem.Text.ToString());
            //
            for (int i = 0; i < vector.Count; i++)
            {
                lstUno.Items.Add(vector[i]);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

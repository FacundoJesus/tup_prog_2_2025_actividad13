using Ejercicio1_Models;
using System.Transactions;
namespace Ejercicio2_DesktopApp;

public partial class Form1 : Form
{
    int camionElegido;
    Sistema sistema = new Sistema();
    public Form1()
    {
        InitializeComponent();
    }

    private void MostrarListaZonas()
    {
        listBox1.Items.Clear();
        listBox2.Items.Clear();
        listBox3.Items.Clear();




    }

    private void VerCarga()
    {
        listBox4.Items.Clear();
        if (camionElegido > -1)
        {
            listBox4.Items.AddRange(sistema.VerCargaCamion(camionElegido));
        }
    }


    private void btnImportarPaquetesPedidos_Click(object sender, EventArgs e)
    {
        openFileDialog1.Filter = "(csv)|*.csv|(txt)|*.txt";
        openFileDialog1.Title = "IMPORTACION DE PAQUETES";
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            FileStream fs = null;
            try
            {
                string path = openFileDialog1.FileName;
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                sistema.Descargar(fs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al importar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (fs.Close != null) fs.Close();
            }
        }
    }

    private void btnRetirar_Click(object sender, EventArgs e)
    {
        if (camionElegido != -1)
        {

        }
    }

    private void btnExportar_Click(object sender, EventArgs e)
    {
        FileStream fs = null;
        try
        {
            string path = $"{camionElegido.ToString("000")}carga.csv";
            fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            sistema.RetirarCamion(fs, camionElegido);
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error en la exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            if(fs != null) fs.Close();
        }
        
    }
}

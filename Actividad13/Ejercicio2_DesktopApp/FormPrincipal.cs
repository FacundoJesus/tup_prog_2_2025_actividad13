using Ejercicio1_Models;
using System.Runtime.Serialization.Formatters.Binary;
using System.Transactions;
namespace Ejercicio2_DesktopApp;

public partial class FormPrincipal : Form
{
    int camionElegido = -1;

    Sistema sistema = new Sistema();

    public FormPrincipal() { InitializeComponent(); }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
        /*
        FileStream fs = null;
        try
        {
            fs = new FileStream("datos.bin",FileMode.Open,FileAccess.Read);
            #pragma warning disable SYSLIB0011
            BinaryFormatter bf = new BinaryFormatter();
            sistema = bf.Deserialize(fs) as Sistema;
            #pragma warning restore SYSLIB0011
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message,"Error al Deserializar",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        finally
        {
            if (fs != null) fs.Close();
        }
        */
        foreach (string camion in sistema.CamionesCargados())
        {
            cmbCamiones.Items.Add(camion);
        }
    }

    #region Metodos del Formulario
    private void MostrarListaZonas()
    {
        listBox1.Items.Clear();
        listBox2.Items.Clear();
        listBox3.Items.Clear();

        foreach (Paquete paquete in sistema.ListaPaquetes)
        {
            switch (paquete.ZonaDestino)
            {
                case "1":
                    listBox1.Items.Add(paquete);
                    break;
                case "2":
                    listBox2.Items.Add(paquete);
                    break;
                case "3":
                    listBox3.Items.Add(paquete);
                    break;
                default:
                    break;
            }
        }
    }

    private void VerCarga()
    {
        lsbCarga.Items.Clear();
        if (camionElegido > -1)
        {
            foreach (string paquete in sistema.VerCargaCamion(camionElegido))
            {
                lsbCarga.Items.Add(paquete);
            }
            //lsbCarga.Items.AddRange(sistema.VerCargaCamion(camionElegido));
        }
    }
    #endregion

    private void btnImportarPaquetesPedidos_Click(object sender, EventArgs e)
    {
        openFileDialog1.Filter = "(csv)|*.csv|(txt)|*.txt";
        openFileDialog1.Title = "IMPORTACION DE PAQUETES";
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            FileStream fs = null;
            string path = openFileDialog1.FileName;
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                sistema.Descargar(fs);

                MostrarListaZonas();
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
    private void btnEnviar_Click(object sender, EventArgs e)
    {
        FileStream fs = null;
        try
        {
            string path = $"{camionElegido.ToString("000")}carga.csv";

            fs = new FileStream(path, FileMode.Create, FileAccess.Write);

            sistema.RetirarCamion(fs, camionElegido);

            MessageBox.Show("Camion con paquetes exportados!");
            lsbCarga.Items.Clear();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error en la exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            if (fs != null) fs.Close();
        }
    }


    private void btnIniciar_Click(object sender, EventArgs e)
    {
        camionElegido = cmbCamiones.SelectedIndex;
        MessageBox.Show("Camion Iniciado!");
        VerCarga();

        double pesoInicio = 0;
        tbKg.Text = pesoInicio.ToString("0.00");
    }

    private void btnAgregarPaquete_Click(object sender, EventArgs e)
    {
        Paquete paquete = null;
        try
        {
            if (listBox3.Items.Count > 0) {
                paquete = listBox3.Items[0] as Paquete;
            }
            else
            if (listBox2.Items.Count > 0)
            {
                paquete = listBox2.Items[0] as Paquete;
            }
            else
            if (listBox1.Items.Count > 0)
            {
                paquete = listBox1.Items[0] as Paquete;
            }

            if (camionElegido > -1) {

                double pesoActual = sistema.CargarPaquete(camionElegido,paquete);

                tbKg.Text = pesoActual.ToString("0.00");

                MostrarListaZonas();
                VerCarga();
                MessageBox.Show("Paquete Agregado!");
            }
            else
            {
                MessageBox.Show("No hay Paquetes para agregar o Debes Iniciar un Camion");
            }
        }
        catch(NullReferenceException ex)
        {
            MessageBox.Show(ex.Message, "Paquete Nulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message, "Otro tipo de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        } 

    }
    private void btnRetirar_Click(object sender, EventArgs e)
    {
        if (camionElegido > -1)
        {
            double pesoActual = sistema.RetirarPaquete(camionElegido);

            MostrarListaZonas();
            VerCarga();

            tbKg.Text = pesoActual.ToString("0.00");

            MessageBox.Show("Paquete Retirado!");
        }
        else
        {
            MessageBox.Show("No hay paquetes para retirar o Debes iniciar un camion!");
        }
    }


    private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
    {
        /*
        FileStream fs = null;
        try
        {
            fs = new FileStream("datos.bin",FileMode.Create,FileAccess.Write);
            #pragma warning disable SYSLIB0011
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, sistema);
            #pragma warning restore SYSLIB0011
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message,"Error al Serializar",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        finally
        {
            if (fs != null) fs.Close();
        }
        */
    }
}

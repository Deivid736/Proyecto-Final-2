using AsistenteTramitesJutiapa;

namespace Proyecto_Final_2
{
    public partial class Form1 : Form
    {
        private readonly IAService iaService = new IAService();
        private readonly BDService bdService = new BDService();

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            string pregunta = txtPregunta.Text.Trim();

            if (string.IsNullOrWhiteSpace(pregunta))
            {
                rtbConversacion.AppendText("🤖: Por favor, escribe una pregunta.\n");
                return;
            }

            rtbConversacion.Clear();
            rtbConversacion.AppendText("🧑: " + pregunta + "\n");

            if (bdService.EsSobreTramites(pregunta))
            {
                string respuestaIA = await iaService.ObtenerRespuestaIA(pregunta);
                bdService.GuardarConversacion(pregunta, respuestaIA);
                rtbConversacion.AppendText("🤖: " + respuestaIA + "\n");
            }
            else
            {
                rtbConversacion.AppendText("🤖: Solo puedo responder preguntas sobre trámites en Jutiapa, Guatemala.\n");
            }

            txtPregunta.Clear();
            txtPregunta.Focus();

            rtbConversacion.SelectionStart = rtbConversacion.Text.Length;
            rtbConversacion.ScrollToCaret();
        }

        private async void lstPreguntasFrecuentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPreguntasFrecuentes.SelectedItem != null)
            {
                string pregunta = lstPreguntasFrecuentes.SelectedItem.ToString();
                txtPregunta.Text = pregunta;

                rtbConversacion.Clear();
                rtbConversacion.AppendText("🧑: " + pregunta + "\n");

                if (bdService.EsSobreTramites(pregunta))
                {
                    string respuestaIA = await iaService.ObtenerRespuestaIA(pregunta);
                    bdService.GuardarConversacion(pregunta, respuestaIA);
                    rtbConversacion.AppendText("🤖: " + respuestaIA + "\n");
                }
                else
                {
                    rtbConversacion.AppendText("🤖: Solo puedo responder preguntas sobre trámites en Jutiapa, Guatemala.\n");
                }

                lstPreguntasFrecuentes.ClearSelected();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstPreguntasFrecuentes.Items.Add("¿Cómo sacar mi DPI?");
            lstPreguntasFrecuentes.Items.Add("¿Qué documentos necesito para un pasaporte?");
            lstPreguntasFrecuentes.Items.Add("¿Dónde puedo solicitar una partida de nacimiento?");
            lstPreguntasFrecuentes.Items.Add("¿Cómo renovar mi licencia de conducir?");
            lstPreguntasFrecuentes.Items.Add("¿Qué es RENAP y para qué sirve?");
            lstPreguntasFrecuentes.Items.Add("¿Dónde puedo pagar el IUSI en Jutiapa?");
            lstPreguntasFrecuentes.Items.Add("¿Cómo puedo solicitar una certificación de nacimiento?");
            lstPreguntasFrecuentes.Items.Add("¿Qué se necesita para inscribir un matrimonio en RENAP?");
            lstPreguntasFrecuentes.Items.Add("¿Dónde se tramita el antecedente penal en Jutiapa?");
            lstPreguntasFrecuentes.Items.Add("¿Qué requisitos hay para sacar una licencia de conducir?");
            lstPreguntasFrecuentes.Items.Add("¿Cómo puedo hacer cita en la SAT en Jutiapa?");
            lstPreguntasFrecuentes.Items.Add("¿Qué trámites puedo hacer en el Registro Civil?");
            lstPreguntasFrecuentes.Items.Add("¿Dónde está la oficina del RENAP en Jutiapa?");
            lstPreguntasFrecuentes.Items.Add("¿Cómo se obtiene una certificación de defunción?");
            lstPreguntasFrecuentes.Items.Add("¿Dónde puedo renovar mi pasaporte?");
            lstPreguntasFrecuentes.Items.Add("¿Qué trámites puedo realizar en la Municipalidad de Jutiapa?");
            lstPreguntasFrecuentes.Items.Add("¿Dónde sacar tarjeta de salud en Jutiapa?");
            lstPreguntasFrecuentes.Items.Add("¿Qué documentos se necesitan para sacar NIT?");
            lstPreguntasFrecuentes.Items.Add("¿Cómo reporto un cambio de domicilio en RENAP?");
            lstPreguntasFrecuentes.Items.Add("¿Dónde puedo solicitar una reposición de DPI?");
            lstPreguntasFrecuentes.Items.Add("¿Dónde puedo tramitar antecedentes policíacos?");

            lstLugaresTramite.Items.Add("RENAP Jutiapa");
            lstLugaresTramite.Items.Add("SAT Jutiapa");
            lstLugaresTramite.Items.Add("Registro Civil Jutiapa");
            lstLugaresTramite.Items.Add("Municipalidad de Jutiapa");

            webViewMapa.Visible = false;
            btnCerrarMapa.Visible = false;
        }

        private void lstLugaresTramite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLugaresTramite.SelectedItem != null)
            {
                string lugar = lstLugaresTramite.SelectedItem.ToString();
                string url = ObtenerURLMapa(lugar);
                webViewMapa.Source = new Uri(url);

                webViewMapa.Visible = true;
                btnCerrarMapa.Visible = true;
            }
        }

        private string ObtenerURLMapa(string lugar)
        {
            switch (lugar)
            {
                case "RENAP Jutiapa":
                    return "https://www.google.com/maps?q=RENAP+Jutiapa+Guatemala";
                case "SAT Jutiapa":
                    return "https://www.google.com/maps?q=SAT+Jutiapa+Guatemala";
                case "Registro Civil Jutiapa":
                    return "https://www.google.com/maps?q=registro+civil+Jutiapa+Guatemala";
                case "Municipalidad de Jutiapa":
                    return "https://www.google.com/maps?q=municipalidad+de+Jutiapa+Guatemala";
                default:
                    return "https://www.google.com/maps";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webViewMapa.Visible = false;
            btnCerrarMapa.Visible = false;
            lstLugaresTramite.ClearSelected();
        }
    }
}

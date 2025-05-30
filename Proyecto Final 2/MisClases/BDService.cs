using System.Data.SqlClient;

namespace AsistenteTramitesJutiapa
{
    public class BDService
    {
        private readonly string conexion = "Server=DEIVIDGR\\SQLEXPRESS;Database=TramitesJutiapa;Trusted_Connection=True;";

        public void GuardarConversacion(string pregunta, string respuesta)
        {
            using (var connection = new SqlConnection(conexion))
            {
                var command = new SqlCommand("INSERT INTO HistorialConversaciones (PreguntaUsuario, RespuestaIA) VALUES (@p, @r)", connection);
                command.Parameters.AddWithValue("@p", pregunta);
                command.Parameters.AddWithValue("@r", respuesta);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public bool EsSobreTramites(string pregunta)
        {
            string[] palabrasClave = { "tramite", "trámite", "dpi", "pasaporte", "licencia", "certificado", "certificación", "registro", "partida", "nacimiento", "defunción", "cedula", "permiso", "renap", "iusi", "sat", "nit", "municipalidad", "salud", "antecedente", "penal", "policíaco", "matrimonio", "divorcio", "cita", "reposicion", "domicilio", "inscribir", "inscripción", "renovar" };
            pregunta = pregunta.ToLower();

            foreach (var palabra in palabrasClave)
            {
                if (pregunta.Contains(palabra))
                    return true;
            }
            return false;
        }
    }
}

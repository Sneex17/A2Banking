namespace CNegocio
{
    /// <summary>
    /// Clase sellada que implementa el patrón <b>Singleton</b> para el sistema de registro de eventos.
    /// Garantiza una única instancia compartida en toda la aplicación.
    /// </summary>
    /// <remarks>
    /// Al ser <c>sealed</c>, esta clase no puede heredarse, lo que refuerza
    /// la integridad del patrón Singleton.
    /// </remarks>
    public sealed partial class Logger
    {
        /// <summary>
        /// Clase interna responsable del registro físico de eventos operacionales
        /// en archivos de texto organizados por fecha.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Los archivos de log se generan diariamente con el formato
        /// <c>log_yyyyMMdd.txt</c> en la ruta configurada.
        /// </para>
        /// <para>
        /// Esta clase no lanza excepciones hacia el llamador; cualquier error
        /// interno se suprime para no interrumpir el flujo de la aplicación.
        /// </para>
        /// </remarks>
        /// <example>
        /// Uso directo (interno):
        /// <code>
        /// LogsOperacional.RegistrarLogs("Inicio de sesión exitoso.");
        /// </code>
        /// Uso recomendado a través del Singleton:
        /// <code>
        /// Logger.Instance.Log("Operación completada.");
        /// </code>
        /// </example>
        public class LogsOperacional
        {
            /// <summary>
            /// Ruta absoluta del directorio donde se almacenan los archivos de log.
            /// </summary>
            /// <value>
            /// Directorio local del usuario actual dentro de OneDrive/Documentos/A2Banking/Logs.
            /// Si el directorio no existe, se crea automáticamente en tiempo de ejecución.
            /// </value>
            private static readonly string ruta =
                @"C:\Users\xrami\OneDrive\Documentos\A2Banking\Logs";
            /// <summary>
            /// Registra un mensaje en el archivo de log correspondiente a la fecha actual.
            /// </summary>
            /// <param name="mensaje">
            /// Texto descriptivo del evento a registrar. Se recomienda incluir
            /// contexto suficiente para facilitar el diagnóstico posterior.
            /// </param>
            /// <remarks>
            /// <para>
            /// Cada entrada se escribe con el siguiente formato de línea:
            /// <c>[yyyy-MM-dd HH:mm:ss] mensaje</c>
            /// </para>
            /// <para>
            /// El archivo de destino sigue el patrón <c>log_yyyyMMdd.txt</c>,
            /// rotando automáticamente cada día.
            /// </para>
            /// <para>
            /// <b>Comportamiento ante errores:</b> cualquier excepción generada
            /// durante la escritura (permisos, disco lleno, ruta inválida) es
            /// capturada y descartada silenciosamente para no afectar al proceso principal.
            /// </para>
            /// </remarks>
            /// <example>
            /// <code>
            /// // Registrar un evento informativo
            /// LogsOperacional.RegistrarLogs("Usuario admin inició sesión.");
            ///
            /// // Registrar un error capturado
            /// try
            /// {
            ///     // operación riesgosa...
            /// }
            /// catch (Exception ex)
            /// {
            ///     LogsOperacional.RegistrarLogs($"Error: {ex.Message}");
            /// }
            /// </code>
            /// </example>
            public static void RegistrarLogs(string mensaje)
            {
                try
                {
                    if (!Directory.Exists(ruta))
                        Directory.CreateDirectory(ruta);
                    string archivo = Path.Combine(ruta, $"log_{DateTime.Today:yyyyMMdd}.txt");
                    string linea = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {mensaje}";
                    File.AppendAllText(archivo, linea + Environment.NewLine);
                }
                catch
                {
                    //Los Logs no retornan excepciones
                }
            }
        }
    }
}

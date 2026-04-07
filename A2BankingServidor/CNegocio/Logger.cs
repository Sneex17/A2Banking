namespace CNegocio
{
    /// <summary>
    /// Proveedor centralizado de registro de eventos para la aplicación <b>A2Banking</b>.
    /// Implementa el patrón de diseño <b>Singleton</b> con seguridad en hilos (<i>thread-safe</i>)
    /// mediante la técnica <i>double-check locking</i>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Al declararse como <c>sealed</c> y <c>partial</c>:
    /// <list type="bullet">
    ///   <item><description><c>sealed</c> — impide la herencia, protegiendo la unicidad de la instancia.</description></item>
    ///   <item><description><c>partial</c> — permite distribuir la implementación en múltiples archivos
    ///   (p. ej. <c>Logger.cs</c> y <c>Logger.LogsOperacional.cs</c>).</description></item>
    /// </list>
    /// </para>
    /// <para>
    /// <b>Patrón utilizado:</b> Singleton con <i>double-check locking</i>.<br/>
    /// Garantiza que solo exista <b>una instancia</b> de <c>Logger</c>
    /// durante todo el ciclo de vida de la aplicación, incluso bajo concurrencia.
    /// </para>
    /// </remarks>
    /// <example>
    /// Registro de un evento informativo:
    /// <code>
    /// Logger.Instance.Log("Transferencia completada. Monto: $5,000.00");
    /// </code>
    /// Registro de un error capturado:
    /// <code>
    /// catch (Exception ex)
    /// {
    ///     Logger.Instance.Log($"[ERROR] {ex.GetType().Name}: {ex.Message}");
    /// }
    /// </code>
    /// </example>
    public sealed partial class Logger
    {
        /// <summary>
        /// Referencia estática a la única instancia de <see cref="Logger"/>.
        /// Se inicializa de forma diferida (<i>lazy</i>) la primera vez que se accede
        /// a <see cref="Instance"/>.
        /// </summary>
        private static Logger _instance;
        /// <summary>
        /// Objeto de sincronización utilizado por el bloque <c>lock</c>
        /// para garantizar la seguridad en entornos multi-hilo.
        /// </summary>
        /// <remarks>
        /// Se declara <c>readonly</c> para que la referencia al objeto
        /// no pueda reasignarse accidentalmente después de su inicialización.
        /// </remarks>
        private static readonly object _lock = new object();
        /// <summary>
        /// Constructor privado que impide la instanciación externa de <see cref="Logger"/>.
        /// </summary>
        /// <remarks>
        /// La única vía para obtener una instancia es a través de la propiedad
        /// <see cref="Instance"/>. Cualquier intento de usar <c>new Logger()</c>
        /// desde fuera de la clase generará un error de compilación.
        /// </remarks>
        private Logger() { }
        /// <summary>
        /// Punto de acceso global a la única instancia de <see cref="Logger"/>.
        /// </summary>
        /// <value>
        /// Instancia única y compartida de <see cref="Logger"/> válida
        /// durante todo el ciclo de vida de la aplicación.
        /// </value>
        /// <remarks>
        /// <para>
        /// Implementa <i>double-check locking</i> para optimizar el rendimiento:
        /// <list type="number">
        ///   <item><description>Primera verificación sin <c>lock</c>: evita el costo de sincronización
        ///   cuando la instancia ya fue creada (caso más frecuente).</description></item>
        ///   <item><description>Bloque <c>lock</c>: garantiza acceso exclusivo durante la creación inicial.</description></item>
        ///   <item><description>Segunda verificación dentro del <c>lock</c>: previene que dos hilos
        ///   creen instancias simultáneamente si ambos superaron la primera verificación.</description></item>
        /// </list>
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// // Desde cualquier capa de la aplicación:
        /// var logger = Logger.Instance;
        /// logger.Log("Acceso autorizado.");
        ///
        /// // O directamente en una línea:
        /// Logger.Instance.Log("Sesión cerrada.");
        /// </code>
        /// </example>
        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new Logger();
                    }
                }
                return _instance;
            }
        }
        /// <summary>
        /// Registra un mensaje de evento delegando la escritura física
        /// a <see cref="LogsOperacional.RegistrarLogs"/>.
        /// </summary>
        /// <param name="mensaje">
        /// Texto del evento a registrar. Se recomienda incluir nivel de severidad,
        /// módulo de origen y descripción clara del evento. Ejemplos:
        /// <list type="bullet">
        ///   <item><description><c>"[INFO] Inicio de sesión: usuario admin."</c></description></item>
        ///   <item><description><c>"[ERROR] Timeout al conectar con la base de datos."</c></description></item>
        ///   <item><description><c>"[WARN] Saldo insuficiente en cuenta #00123."</c></description></item>
        /// </list>
        /// </param>
        /// <remarks>
        /// <para>
        /// Este método actúa como <b>fachada</b> (<i>Facade</i>) sobre <see cref="LogsOperacional"/>:
        /// centraliza el acceso al sistema de logs sin exponer los detalles
        /// de escritura a disco al resto de la aplicación.
        /// </para>
        /// <para>
        /// <b>Seguridad ante fallos:</b> los errores de escritura son manejados
        /// internamente por <see cref="LogsOperacional.RegistrarLogs"/> y nunca
        /// se propagan al código llamador.
        /// </para>
        /// </remarks>
        /// <example>
        /// <code>
        /// // Evento informativo
        /// Logger.Instance.Log("[INFO] Transferencia #TRX-8821 procesada correctamente.");
        ///
        /// // Evento de error
        /// Logger.Instance.Log($"[ERROR] Fallo en validación: {ex.Message}");
        ///
        /// // Evento de advertencia
        /// Logger.Instance.Log("[WARN] Intento de acceso con credenciales inválidas.");
        /// </code>
        /// </example>
        public void Log(string mensaje)
        {
            // Delega el trabajo físico a la clase ya existente
            LogsOperacional.RegistrarLogs(mensaje);
        }
    }
}

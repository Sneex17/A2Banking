using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPresentacion.Plantillas;
using CEntidades.BuilderPattern;
using CEntidades.StatePattern;
using CEntidades;
using CNegocio;

namespace CPresentacion.ViewsUI.UserControls
{
    /// <summary>
    /// Control de usuario para la gestión de cuentas bancarias.
    /// Permite crear, actualizar, cambiar el estado y consultar cuentas.
    /// Hereda de <see cref="ucPlantilla"/> como plantilla base de presentación.
    /// </summary>
    public partial class ucCuentas : ucPlantilla
    {
        /// <summary>
        /// Inicializa el control <see cref="ucCuentas"/> y carga los datos de cuentas
        /// desde la capa de negocio al iniciar el componente.
        /// </summary>
        public ucCuentas()
        {
            InitializeComponent();
            CargarDatos();
        }
        /// <summary>
        /// Carga la lista de cuentas bancarias en el <c>DataGridView</c> (viewDatos)
        /// y suscribe el evento de doble clic para seleccionar registros.
        /// </summary>
        private void CargarDatos()
        {
            viewDatos.DataSource = LogicaNegocio.ListaCuentas();
            viewDatos.CellDoubleClick += viewData_CellDoubleClick;
        }
        /// <summary>
        /// Limpia el contenido de todos los campos de texto del formulario,
        /// dejándolos en su estado inicial (cadena vacía).
        /// </summary>
        private void LimpiarTexbox()
        {
            textbIdCuenta.Text = string.Empty;
            textbNumeroCuenta.Text = string.Empty;
            textbIdTitular.Text = string.Empty;
            textbNombreTitular.Text = string.Empty;
            textbEstadoCuenta.Text = string.Empty;
            textbCodigoPin.Text = string.Empty;
            textbHuella.Text = string.Empty;
        }
        /// <summary>
        /// Ejecuta las validaciones de negocio sobre el objeto <see cref="Cuenta"/> recibido.
        /// Si la validación falla, lanza una excepción con los mensajes de error correspondientes.
        /// </summary>
        /// <param name="cuenta">
        ///   Objeto <see cref="Cuenta"/> que será validado mediante <see cref="ValidacionCuenta"/>.
        /// </param>
        /// <exception cref="ControlExcepciones">
        ///   Se lanza cuando uno o más campos del objeto no cumplen las reglas de validación.
        /// </exception>
        private void validaciones(Cuenta cuenta)
        {
            var validacion = new ValidacionCuenta();
            var resultado = validacion.Validate(cuenta);

            if (!resultado.IsValid)
            {
                string mensaje = string.Join("\n", resultado.Errors.Select(M => M.ErrorMessage));
                throw new ControlExcepciones(mensaje);
            }
        }
        /// <summary>
        /// Ajusta la interfaz visual del botón Guardar y la visibilidad de controles
        /// según si se está creando una nueva cuenta (ID vacío) o actualizando una existente.
        /// </summary>
        /// <param name="id">
        ///   Identificador de la cuenta. Si es nulo o vacío, se configura el modo <c>Crear</c>;
        ///   de lo contrario, se configura el modo <c>Actualizar</c>.
        /// </param>
        private void CambioOperacion(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                BuGuardar.ColorBackground = Color.Green;
                BuGuardar.TextButton = "Crear";
                GroupBoxEstados.Visible = false;
                BuAplicar.Visible = false;
            }
            else
            {
                BuGuardar.ColorBackground = Color.DodgerBlue;
                BuGuardar.TextButton = "Actualizar";
                GroupBoxEstados.Visible = true;
                BuAplicar.Visible = true;
            }
        }
        /// <summary>
        /// Selecciona el radio button correspondiente al estado de la cuenta recibido.
        /// Los estados soportados son: <c>Activa</c> e <c>Inactiva</c>.
        /// </summary>
        /// <param name="estado">
        ///   Cadena que representa el estado actual de la cuenta (ej. "Activa", "Inactiva").
        /// </param>
        private void EstadosCuentas(string estado)
        {
            switch (estado)
            {
                case "Activa":
                    {
                        rbActiva.Checked = true;
                    }
                    break;
                case "Inactiva":
                    {
                        rbInactiva.Checked = true;
                    }
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Aplica una transición de estado sobre un objeto <see cref="CuentaEstado"/>
        /// usando el patrón State, delegando el cambio a la implementación de <see cref="ICuentaEstados"/>.
        /// </summary>
        /// <param name="newEstado">
        ///   Instancia de <see cref="CuentaEstado"/> sobre la que se aplicará la transición.
        /// </param>
        /// <param name="estados">
        ///   Implementación concreta del estado destino (ej. <see cref="EstadoActiva"/>,
        ///   <see cref="EstadoInactiva"/>, <see cref="EstadoCancelada"/>).
        /// </param>
        /// <returns>
        ///   El mismo objeto <see cref="CuentaEstado"/> con el estado actualizado.
        /// </returns>
        private CuentaEstado CambioEstado(CuentaEstado newEstado, ICuentaEstados estados)
        {
            newEstado.CambiarEstado(estados);
            return newEstado;
        }
        /// <summary>
        /// Maneja el evento de doble clic sobre una celda del <c>DataGridView</c>.
        /// Carga los datos de la fila seleccionada en los campos de texto, siempre
        /// que el estado de la cuenta no sea <c>Cancelada</c>.
        /// </summary>
        /// <param name="sender">El <see cref="DataGridView"/> que originó el evento.</param>
        /// <param name="e">Argumentos del evento que contienen el índice de fila y columna clicada.</param>
        private void viewData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (viewDatos.Rows[e.RowIndex].Cells["Estado"].Value.ToString() == "Cancelada")
                    {
                        throw new ControlExcepciones("La cuenta esta cancelada");
                    }

                    textbIdCuenta.Text = viewDatos.Rows[e.RowIndex].Cells["CuentaId"].Value.ToString();
                    textbNumeroCuenta.Text = viewDatos.Rows[e.RowIndex].Cells["NumeroCuenta"].Value.ToString();
                    textbIdTitular.Text = viewDatos.Rows[e.RowIndex].Cells["TitularId"].Value.ToString();
                    textbNombreTitular.Text = viewDatos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                    textbEstadoCuenta.Text = viewDatos.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
                    textbCodigoPin.Text = viewDatos.Rows[e.RowIndex].Cells["CodigoPin"].Value.ToString();
                }
                CambioOperacion(textbIdCuenta.Text);
                EstadosCuentas(textbEstadoCuenta.Text);
            }
            catch (ControlExcepciones errore)
            {
                MessageBox.Show($"{errore.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception errore)
            {
                MessageBox.Show($"{errore.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Maneja el evento de clic del botón <c>BuCapturarHuella</c>.
        /// Abre el diálogo <see cref="fmCapturarHuella"/> y, si se obtuvo una plantilla
        /// biométrica válida en Base64, la asigna al campo de texto correspondiente.
        /// </summary>
        /// <param name="sender">El botón que originó el evento.</param>
        /// <param name="e">Argumentos estándar del evento de clic.</param>
        private void BuCapturarHuella_Click(object sender, EventArgs e)
        {
            fmCapturarHuella capturarHuella = new fmCapturarHuella();
            capturarHuella.ShowDialog();

            if (!string.IsNullOrEmpty(capturarHuella.TemplateBase64))
                textbHuella.Text = capturarHuella.TemplateBase64;
        }
        /// <summary>
        /// Actualiza los datos de una cuenta existente usando el patrón Builder.
        /// Si el campo de huella está vacío, solo actualiza el PIN; si contiene datos biométricos,
        /// también actualiza la huella dactilar.
        /// </summary>
        /// <param name="cuentaBuilder">
        ///   Instancia de <see cref="ICuentaBuilder"/> utilizada para construir
        ///   el objeto <see cref="Cuenta"/> con los datos del formulario.
        /// </param>
        private void ActualizarCuenta(ICuentaBuilder cuentaBuilder)
        {
            
            if (string.IsNullOrWhiteSpace(textbHuella.Text))
            {
                Cuenta cuenta = cuentaBuilder
                    .conCuentaId(Convert.ToInt32(textbIdCuenta.Text))
                    .conNumeroCuenta(Convert.ToInt32(textbNumeroCuenta.Text))
                    .conCodigoPin(Convert.ToInt32(textbCodigoPin.Text))
                    .Builder();

                LogicaNegocio.ActualizarPin(cuenta);
            }
            else
            {
                Cuenta cuenta = cuentaBuilder
                    .conCuentaId(Convert.ToInt32(textbIdCuenta.Text))
                    .conNumeroCuenta(Convert.ToInt32(textbNumeroCuenta.Text))
                    .conCodigoPin(Convert.ToInt32(textbCodigoPin.Text))
                    .conCodigoHuella(Convert.FromBase64String(textbHuella.Text))
                    .Builder();

                LogicaNegocio.ActualizarHuella(cuenta);
            }

        }
        /// <summary>
        /// Maneja el evento de clic del botón <c>BuGuardar</c>.
        /// Determina si la operación es una <b>creación</b> o una <b>actualización</b>
        /// según si el campo ID de cuenta está vacío, y ejecuta la lógica correspondiente.
        /// </summary>
        /// <remarks>
        /// En modo creación, construye un objeto <see cref="Cuenta"/> completo usando el
        /// patrón Builder, valida los datos y los persiste mediante <see cref="LogicaNegocio.CrearCuentas"/>.
        /// En modo actualización, delega en <see cref="ActualizarCuenta"/>.
        /// </remarks>
        /// <param name="sender">El botón que originó el evento.</param>
        /// <param name="e">Argumentos estándar del evento de clic.</param>
        /// <exception cref="ControlExcepciones">Error de validación de negocio.</exception>
        /// <exception cref="Exception">Cualquier otro error inesperado durante la operación.</exception>
        private void BuGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textbIdCuenta.Text))
                {
                    var titular = new Titular()
                    {
                        TitularId = Convert.ToInt32(textbIdTitular.Text),
                        Nombre = textbNombreTitular.Text,
                    };

                    var banco = new Banco()
                    {
                        BancoId = 1,
                        Nombre = "A2 Banking"
                    };

                    var huella = Convert.FromBase64String(textbHuella.Text);

                    var estado = new CuentaEstado();
                    ICuentaBuilder cuentaBuilder = new CuentaBuilder();
                    Cuenta cuenta = cuentaBuilder
                        .conTitular(titular)
                        .conBanco(banco)
                        .conBalance(5000)
                        .conNumeroCuenta(Convert.ToInt32(textbNumeroCuenta.Text))
                        .conFechaCreacion(DateTime.Today)
                        .conEstado(estado)
                        .conCodigoPin(Convert.ToInt32(textbCodigoPin.Text))
                        .conCodigoHuella(Convert.FromBase64String(textbHuella.Text))
                        .Builder();
                    //textbCodigoPin.Text = "0x" + BitConverter.ToString(huella).Replace("-", "");

                    validaciones(cuenta);

                    var mensaje = MessageBox.Show($"Desea crearle una cuenta al cliente {textbNombreTitular.Text}?",
                    "Creación de cuenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mensaje == DialogResult.Yes)
                    {
                        LogicaNegocio.CrearCuentas(cuenta);

                        MessageBox.Show($"Cuenta: {textbNumeroCuenta.Text} creada con exito!",
                            "Creación de cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarTexbox();
                        CambioOperacion(textbIdCuenta.Text);
                        CargarDatos();
                    }
                }
                else
                {
                    var mensaje = MessageBox.Show($"Desea actualizar los datos de la cuenta {textbNumeroCuenta.Text}?",
                    "Actualización de cuenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (mensaje == DialogResult.Yes)
                    {
                        ICuentaBuilder cuentaBuilder = new CuentaBuilder();
                        ActualizarCuenta(cuentaBuilder);

                        MessageBox.Show($"Datos de la cuenta: {textbNumeroCuenta.Text} actualizados con exito!",
                            "Actualización de cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarTexbox();
                        CambioOperacion(textbIdCuenta.Text);
                        CargarDatos();
                    }
                }
            }
            catch (ControlExcepciones errore)
            {
                MessageBox.Show($"{errore.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception errore)
            {
                MessageBox.Show($"{errore.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Maneja el evento de clic del botón <c>BuAplicar</c>.
        /// Aplica el cambio de estado seleccionado (Activa, Inactiva o Cancelada)
        /// a la cuenta mostrada en el formulario, previa confirmación del usuario.
        /// </summary>
        /// <remarks>
        /// Utiliza el patrón State a través de <see cref="CambioEstado"/> para determinar
        /// la transición correcta, y el patrón Builder para construir el objeto <see cref="Cuenta"/>.
        /// </remarks>
        /// <param name="sender">El botón que originó el evento.</param>
        /// <param name="e">Argumentos estándar del evento de clic.</param>
        /// <exception cref="ControlExcepciones">Error controlado de negocio.</exception>
        /// <exception cref="Exception">Cualquier otro error inesperado.</exception>
        private void BuAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                var estado = new CuentaEstado();
                if (rbActiva.Checked == true)
                {
                    estado = CambioEstado(estado, new EstadoActiva());
                }
                else if (rbInactiva.Checked == true)
                {
                    estado = CambioEstado(estado, new EstadoInactiva());
                }
                else
                {
                    estado = CambioEstado(estado, new EstadoCancelada());
                }
                ICuentaBuilder cuentaBuilder = new CuentaBuilder();
                Cuenta cuenta = cuentaBuilder
                    .conNumeroCuenta(Convert.ToInt32(textbNumeroCuenta.Text))
                    .conEstado(estado)
                    .Builder();

                var mensaje = MessageBox.Show($"Desea cambiar el estado de la cuenta: {textbNumeroCuenta.Text} a  {cuenta.Estado.cuentaEstado.Nombre}?",
                    "Cambio de estado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensaje == DialogResult.Yes)
                {
                    LogicaNegocio.ActualizarEstado(cuenta);

                    MessageBox.Show($"Estado de la cuenta: {textbNumeroCuenta.Text} actualizado con exito!",
                        "Cambio de estado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarTexbox();
                    CambioOperacion(textbIdCuenta.Text);
                    CargarDatos();
                }
            }
            catch (ControlExcepciones errore)
            {
                MessageBox.Show($"{errore.Message}", "Error en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception errore)
            {
                MessageBox.Show($"{errore.Message}", "Error en la operación", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        /// <summary>
        /// Maneja el evento de clic del botón <c>BuBuscarPersonas</c>.
        /// Abre el diálogo <see cref="fmTitulares"/> para seleccionar un titular,
        /// carga su ID y nombre en el formulario, y genera automáticamente un número de cuenta.
        /// </summary>
        /// <param name="sender">El botón que originó el evento.</param>
        /// <param name="e">Argumentos estándar del evento de clic.</param>
        private void BuBuscarPersonas_Click(object sender, EventArgs e)
        {
            fmTitulares titulares = new fmTitulares();
            titulares.SeleccionarTitular += (titular) =>
            {
                textbIdTitular.Text = titular.TitularId.ToString();
                textbNombreTitular.Text = titular.Nombre.ToString();
            };
            titulares.ShowDialog();

            var estado = new CuentaEstado();
            textbEstadoCuenta.Text = estado.cuentaEstado.Nombre;
            textbNumeroCuenta.Text = LogicaNegocio.GeneralNumeroCuenta();
        }
        /// <summary>
        /// Maneja el evento de clic del botón <c>BuLimpiar</c>.
        /// Limpia todos los campos del formulario y restablece el modo de operación a <c>Crear</c>.
        /// </summary>
        /// <param name="sender">El botón que originó el evento.</param>
        /// <param name="e">Argumentos estándar del evento de clic.</param>
        private void BuLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTexbox();
            CambioOperacion(textbIdCuenta.Text);
        }
        /// <summary>
        /// Maneja el evento de clic del botón <c>BuCapturarPIN</c>.
        /// Abre el diálogo <see cref="fmCodigoPin"/> para capturar el código PIN
        /// y lo asigna al campo de texto <c>textbCodigoPin</c>.
        /// </summary>
        /// <param name="sender">El botón que originó el evento.</param>
        /// <param name="e">Argumentos estándar del evento de clic.</param>
        private void BuCapturarPIN_Click(object sender, EventArgs e)
        {
            fmCodigoPin codigoPin = new fmCodigoPin();
            codigoPin.ShowDialog();

            textbCodigoPin.Text = fmCodigoPin.CodigoPIN;
        }   
    }
}

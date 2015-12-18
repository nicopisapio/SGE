using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Entities
{
    public static class Mensaje
    {

        //Validaciones
        public static int IngreseValorNumerico = 15000;
        public static int AlturaDistintaCero = 15001;
        public static int AlturaValorNumerico = 15002;
        public static int DUDistintaCero = 15003;
        public static int DUValorNumerico = 15004;
        public static int ValorMayorCero = 15005;
        public static int ConsultaSinDatos = 15006;
        public static int MontoPagoMayorTotal = 15007;
        public static int FechaHastaMayorFechaDesde = 15008;
        public static int PersonasMenorMinimo = 15009;
        public static int DuracionMinima = 15010;
        public static int DuracionMaxima = 15011;

        //FABMCargo
        public static int ABMCargoTitulo = 1;
        public static int EliminarCargo = 10000;
        public static int EliminacionCargoSatisfactoria = 10001;
        public static int CreacionCargoSatisfactoria = 10002;
        public static int ModificacionCargoSatisfactoria = 10003;

        //FABMEmpleado
        public static int ABMEmpleadoTitulo = 10;
        public static int EliminarEmpleado = 10010;
        public static int EliminacionEmpleadoSatisfactoria = 10011;
        public static int CreacionEmpleadoSatisfactoria = 10012;
        public static int ModificacionEmpleadoSatisfactoria = 10013;
        public static int CreacionEmpleadoInconclusa = 10014;
        public static int CompletarTodosDatosEmpleado = 10015;

        //FABMEvento
        public static int ABMEventoTitulo = 29;
        public static int EliminarEvento = 10020;
        public static int EliminacionEventoSatisfactoria = 10021;
        public static int CreacionEventoSatisfactoria = 10022;
        public static int ModificacionEventoSatisfactoria = 10023;

        //FABMIdioma
        public static int ABMIdiomaTitulo = 42;
        public static int CreacionIdiomaSatisfactoria = 10030;
        public static int IngresarNombreIdioma = 10031;

        //FABMServicio
        public static int ABMServicioTitulo = 48;
        public static int EliminarServicio = 10040;
        public static int EliminacionServicioSatisfactoria = 10041;
        public static int CreacionServicioSatisfactoria = 10042;
        public static int ModificacionServicioSatisfactoria = 10043;

        //FABMUsuario
        public static int ABMUsuarioTitulo = 57;
        public static int EliminarUsuario = 10050;
        public static int EliminacionUsuarioSatisfactoria = 10051;
        public static int CreacionUsuarioSatisfactoria = 10052;
        public static int ModificacionUsuarioSatisfactoria = 10053;

        //FAgregarExcedente
        public static int FAgregarExcedenteTitulo = 68;
        public static int AgregacionExcedenteSatisfactoria = 10060;
        public static int CreacionExcedenteSatisfactoria = 10061;

        //FAltaCliente
        public static int FAltaClienteTitulo = 82;
        public static int AltaClienteSatisfactoria = 10070;
        public static int AltaClienteFallida = 10071;
        public static int CompletarDatosCliente = 10072;

        //FBitacora
        public static int FBitacoraTitulo = 96;

        //FCotizacionEvento
        public static int FCotizacionEvento = 103;
        public static int ReservaInexistente = 10080;
        public static int CreacionCotizacionSatisfactoria = 10081;

        //FDetalleEvento
        public static int FDetalleEventoTitulo = 136;

        //FDetalleHorasMensuales
        public static int FDetalleHorasMensualesTitulo = 158;

        //FDetalleHorasSemanales
        public static int FDetalleHorasSemanalesTitulo = 163;

        //FIdioma
        public static int FIdiomaTitulo = 169;
        public static int IdiomaConfiguradoCorrectamente = 10090;

        //FModificacionEvento
        public static int FModificacionEventoTitulo = 172;
        public static int AgregarTiempoFallida = 10100;
        public static int CotizacionExitosa = 10101;

        //FPermiso
        public static int FPermisoTitulo = 203;
        public static int CreacionPermisoExitosa = 10110;
        public static int EliminacionPermisoExitosa = 10111;

        //FPrincipal 
        public static int FPrincipalTitulo = 212;
        public static int AplicacionBloqueada = 10120;
        public static int DeseaRealizarBackup = 10121;
        public static int BackupSatisfactorio = 10122;
        public static int SeleccionarArchivoRestore = 10123;
        public static int RestoreSatisfactorio = 10124;

        //FReasignarEmpleado
        public static int FReasignarEmpleadoTitulo = 243;

        //FReserva
        public static int FReservaTitulo = 250;
        public static int CreacionReservaSatisfactoria = 10130;
        public static int DeseaCotizarReserva = 10131;
        public static int ReservaExistenteMismoHorario = 10132;
        public static int CreacionReservaFallida = 10133;
        public static int SeleccionarCliente = 10134;


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE_Entities
{
    public static class MensajeError
    {

        //Login
        public static int AplicacionBloqueada = 5000;
        public static int IntegridadCorrupta = 5001;
        public static int LoginFallido = 5002;

        //ABM Permisos
        public static int ConsultaPermisosFallida = 5010;
        public static int AltaPermisoFallida = 5011;
        public static int BajaPermisoFallida = 5012;
        public static int ModificacionPermisoFallida = 5013;

        //ABM Cargos
        public static int ConsultaCargosFallida = 5000;
        public static int BajaCargoFallida = 5001;
        public static int AltaCargoFallida = 5002;
        public static int ModificacionCargoFallida = 5003;
        
        //ABM Empleados
        public static int ConsultaEmpleadosFallida = 5010;
        public static int BajaEmpleadoFallida = 5011;
        public static int AltaEmpleadoFallida = 5012;
        public static int ModificacionEmpleadoFallida = 5013;

        //ABM Eventos
        public static int ConsultaEventosFallida = 5020;
        public static int BajaEventoFallida = 5021;
        public static int AltaEventoFallida = 5022;
        public static int ModificacionEventoFallida = 5023;

        //ABM Idioma
        public static int NuevoIdiomaFallido = 5030;
        public static int ConsultaCulturasFallidas = 5031;
        public static int ConsultaIdiomasFallida = 5032;
        public static int CambioIdiomaFallido = 5033;

        //ABM Servicios
        public static int ConsultaServiciosFallida = 5040;
        public static int BajaServicioFallida = 5041;
        public static int AltaServicioFallida = 5042;
        public static int ModificacionServicioFallida = 5043;

        //ABM Usuario
        public static int ConsultaUsuariosFallida = 5050;
        public static int AltaUsuarioFallida = 5051;
        public static int ModificacionUsuarioFallida = 5052;
        public static int BajaUsuarioFallida = 5053;

        //Agregar Excedentes
        public static int AltaExcedenteFallida = 5060;

        //Clientes
        public static int AltaClienteFallida = 5070;
        public static int ConsultaClientesFallida = 5071;

        //Bitacora
        public static int ConsultaBitacoraFallida = 5080;

        //Reserva
        public static int ConsultaReservasFallida = 5090;
        public static int CalcularCostoReservaFallido = 5091;
        public static int ModificacionReservaFallida = 5092;
        public static int AltaReservaFallida = 5093;

        //DetalleHora
        public static int ConsultaHorasMensualesFallida = 6000;
        public static int ConsultaHorasSemanalesFallida = 6001;

        //Principal
        public static int TraduccionFallida = 6010;
        public static int RestoreFallido = 6011;
        public static int BackupFallido = 6012;

        //Reasignar Empleados
        public static int AgregaEmpleadoFallida = 6020;
        public static int QuitaEmpleadoFallida = 6021;

    }
}

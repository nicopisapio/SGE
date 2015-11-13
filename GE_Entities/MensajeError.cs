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
        public static int ConsultaCargosFallida = 5020;
        public static int BajaCargoFallida = 5021;
        public static int AltaCargoFallida = 5022;
        public static int ModificacionCargoFallida = 5023;
        
        //ABM Empleados
        public static int ConsultaEmpleadosFallida = 5030;
        public static int BajaEmpleadoFallida = 5031;
        public static int AltaEmpleadoFallida = 5032;
        public static int ModificacionEmpleadoFallida = 5033;

        //ABM Eventos
        public static int ConsultaEventosFallida = 5040;
        public static int BajaEventoFallida = 5041;
        public static int AltaEventoFallida = 5042;
        public static int ModificacionEventoFallida = 5043;

        //ABM Idioma
        public static int NuevoIdiomaFallido = 5050;
        public static int ConsultaCulturasFallidas = 5051;
        public static int ConsultaIdiomasFallida = 5052;
        public static int CambioIdiomaFallido = 5053;

        //ABM Servicios
        public static int ConsultaServiciosFallida = 5060;
        public static int BajaServicioFallida = 5061;
        public static int AltaServicioFallida = 5062;
        public static int ModificacionServicioFallida = 5063;

        //ABM Usuario
        public static int ConsultaUsuariosFallida = 5070;
        public static int AltaUsuarioFallida = 5071;
        public static int ModificacionUsuarioFallida = 5072;
        public static int BajaUsuarioFallida = 5073;

        //Agregar Excedentes
        public static int AltaExcedenteFallida = 5080;

        //Clientes
        public static int AltaClienteFallida = 5090;
        public static int ConsultaClientesFallida = 5091;

        //Bitacora
        public static int ConsultaBitacoraFallida = 6000;

        //Reserva
        public static int ConsultaReservasFallida = 6010;
        public static int CalcularCostoReservaFallido = 6011;
        public static int ModificacionReservaFallida = 6012;
        public static int AltaReservaFallida = 6013;

        //DetalleHora
        public static int ConsultaHorasMensualesFallida = 6020;
        public static int ConsultaHorasSemanalesFallida = 6021;

        //Principal
        public static int TraduccionFallida = 6030;
        public static int RestoreFallido = 6031;
        public static int BackupFallido = 6032;

        //Reasignar Empleados
        public static int AgregaEmpleadoFallida = 6040;
        public static int QuitaEmpleadoFallida = 6041;

    }
}

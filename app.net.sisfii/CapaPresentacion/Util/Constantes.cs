namespace CapaPresentacion.Constantes
{
    public class Constantes
    {


        public const string APP_ORIGEN = "WCFPPTOWEB";
        public const string ERROR_LOG = "############ ERROR ##########";

        public const string  CTE_ALCE = "ALCE";
        public const string  CTE_DOBLEZ = "DOBLEZ";
        public const string  CTE_CORTEREFILADO = "CORTEREFILADO";
        public const string  CTE_TINTA = "TINTA";
        public const string  CTE_ENCOLADO = "ENCOLADO";
        public const string  CTE_MOVILIDAD = "MOVILIDAD";
        public const string  CTE_MANEJOARCHIVO = "MANEJOARCHIVO";
        public const string  CTE_BESTCOLOR = "BESTCOLOR";
        public const string  CTE_CIF = "CIF";


        public const string TODOS_CRS = "*";
        public const string TODOS_BODEGASS = "*";

        public const int TIEMPO_ESPERA_DEFECTO = 3600000;   //1 hora
        public const int TIEMPO_REINICIO_DEFECTO = 300000;  //5 minutos
        public const int TIEMPO_REINICIO_DEFECTO2 = 1000;  //

        public static class KeyBD
        {
            public const string DBTECNICA = "dbtecnica";
            public const string SIFCO = "sifco";
            public const string GIS = "gis";
            public const string XNEAR = "xnear";

            public const string DBTECNICA1 = "dbtecnica1";
            public const string SIFCO1 = "sifco1";
            public const string GIS1 = "gis1";
            public const string XNEAR1 = "xnear1";

            public const string DBTECNICA2 = "dbtecnica1";
            public const string SIFCO2 = "sifco1";
            public const string GIS2 = "gis1";
            public const string XNEAR2 = "xnear1";

        }

        public static class Empresa
        {
            public const string LUZDELSUR = "7";
            public const string TECSUR = "2";
            public const string LOSANDES = "24";
            public const string GCI = "31";
            public const string EDK = "10";

        }


        public static class NroEmpresa
        {
            public const int LUZDELSUR = 7;
            public const int TECSUR = 2;
            public const int LOSANDES = 24;
            public const int GCI = 31;
            public const int EDK = 10;

        }

        public static class EtapaEjecProceso
        {
            public const string INI = "I";
            public const string FIN = "F";
        }

        public static class EstadoEjecProceso
        {
            public const string INICIO = "I";
            public const string EJECUCION = "E";
            public const string PROCESADO = "P";
            public const string ANULADO = "N";
        }

        public static class Ruc
        {
            public const string LUZDELSUR = "20331898008";
            public const string TECSUR = "20206018411";
        }

        public static class ProcesosOCService
        {
            public const string REPORTE_OCI = "01";
            public const string REPORTE_ENTREGAOC = "02";/*MS019957_20180607_OMZ*/
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxeleratorGabooster
{
    class cls_configurator
    {
        string str_mode     = "";
        string str_controis = "";

        public string get_str_controls()
        {
            return str_controis;
        }

        public string get_str_mode()
        {
            return str_mode;
        }

        public void set_config_0()
        {
            str_mode = "0_Config_CaptureClient";
            str_controis = "0: Capture, M: Procesar_Imagen";
        }

        public void set_config_1()
        {
            str_mode = "1_Config_TestClient";
            str_controis = "0: LoadResize, M: Seek_MostS";
        }

        public void set_config_2()
        {
            str_mode = "2_Config_TestCoordinates";
            str_controis = "0: Cargar Puntos, 1: Cargar Otros Datos";
        }

        public bool get_bln_isClientState0()
        {
            return "0_Config_CaptureClient" == str_mode;
        }

        public bool get_bln_isClientState1()
        {
            return "1_Config_TestClient" == str_mode;

        }

        public bool get_bln_isClientState2()
        {
            return "2_Config_TestCoordinates" == str_mode;
        }

    }
}

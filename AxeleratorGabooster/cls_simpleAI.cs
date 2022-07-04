using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxeleratorGabooster
{
    class cls_simpleAI
    {

        bool bln_continue = false;
        int int_status = -1;
        int int_percentage = 0;
        int int_seconds = 0;
        public string str_info = "";

        cls_coordenatesHandler  obj_coordenatesHandler;
        cls_imageHandler        obj_imageHandler;

        public void set_references(cls_coordenatesHandler obj_newCoordenatesHandler, cls_imageHandler obj_newImageHandler)
        {
            obj_coordenatesHandler  = obj_newCoordenatesHandler;
            obj_imageHandler        = obj_newImageHandler;
        }

        public bool get_bln_continue()
        {
            return bln_continue;
        }
        public string funget_str_complete_analisis()
        {
            return funget_str_status() + "," + int_percentage.ToString() + "," + int_seconds.ToString();
        }
            public string funget_str_status()
        {
            if (int_status == -1)
            {
                return "Ninguno";
            }

            if (int_status == 0)
            {
                return "0_lobby";
            }

            if (int_status == 1)
            {
                return "1_find";
            }
            if (int_status == 2)
            {
                return "2_champ";
            }
            if (int_status == 3)
            {
                return "3_loading";
            }

            if (int_status == 4)
            {
                return "4_inGame1";

            }

            if (int_status == 5)
            {
                return "5_inGame2";

            }
            if (int_status == 6)
            {
                return "6_honor";
            }
            if (int_status == 7)
            {
                return "7_ownStats";
            }
            if (int_status == 8)
            {
                return "8_lvlup";
            }
            if (int_status == 9)
            {
                return "9_matchStats";
            }
            if (int_status == 10)
            {
                return "10_lobby";
            }
            return "Ninguno";
        }

        public void start_work()
        {
            obj_imageHandler.fun_void_stagePreparation();
            bln_continue = true;

            while (bln_continue)
            {
                //MessageBox.Show("Viviendo");
                str_info = "trabajando";
                int[] intA3_state_percentage_seconds = obj_imageHandler.fun_detectClientState();
                int_status = intA3_state_percentage_seconds[0];
                int_percentage = intA3_state_percentage_seconds[1];
                int_seconds = intA3_state_percentage_seconds[2];

                if (int_status == 0)
                {
                    obj_imageHandler.fun_btm_captureClientAndResize_ExternalSave("0_lobby");
                }

                if (int_status == 1)
                {
                    obj_imageHandler.fun_btm_captureClientAndResize_ExternalSave("1_find");

                }

                if (int_status == 2)
                {
                    obj_imageHandler.fun_btm_captureClientAndResize_ExternalSave("2_champS");

                }

                if (int_status == 3)
                {
                    obj_imageHandler.fun_btm_captureClientAndResize_ExternalSave("3_loadingS");

                }

                if (int_status == 4)
                {
                    obj_imageHandler.fun_btm_captureClientAndResize_ExternalSave("4_inGame1");
                }
                if (int_status == 5)
                {
                    obj_imageHandler.fun_btm_captureClientAndResize_ExternalSave("5_inGame2");

                }
                if (int_status == 6)
                {
                    obj_imageHandler.fun_btm_captureClientAndResize_ExternalSave("6_honor");

                }
                if (int_status == 7)
                {
                    obj_imageHandler.fun_btm_captureClientAndResize_ExternalSave("7_ownStats");
                }
                if (int_status == 8)
                {
                    obj_imageHandler.fun_btm_captureClientAndResize_ExternalSave("8_lvlup");
                }
                if (int_status == 9)
                {
                    obj_imageHandler.fun_btm_captureClientAndResize_ExternalSave("9_matchStats");
                }
                if (int_status == 10)
                {
                    obj_imageHandler.fun_btm_captureClientAndResize_ExternalSave("10_lobby");
                }
            }
        }
        public void start_life()
        {
            Thread thr_life = new Thread(start_work);
            thr_life.Start();
        }
    }
}

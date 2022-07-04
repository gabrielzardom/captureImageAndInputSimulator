using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;

namespace AxeleratorGabooster
{
    public partial class frm_Main : Form
    {
        int int_capture = 0;

        cls_configurator        configurator    = new cls_configurator();
        cls_coordenatesHandler  coordinates     = new cls_coordenatesHandler();
        cls_imageHandler        imageHandler    = new cls_imageHandler();
        cls_simpleAI            simpleAI = new cls_simpleAI();
        public frm_Main()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            imageHandler.set_coordenateeHandler(coordinates);
            coordinates.file_loadPointData();
            coordinates.file_loadImagetData();
            configurator.set_config_0();
            tmr_configurator.Start();
        }



        private void btn_ai_Click(object sender, EventArgs e)
        {
            imageHandler.set_coordenateeHandler(coordinates);
            coordinates.file_loadPointData();
            coordinates.file_loadImagetData();
            imageHandler.load_reizedFiles();
            simpleAI.set_references(coordinates, imageHandler);
            tmr_ai.Start();
            simpleAI.start_life();
        }

        private void tmr_configurator_Tick(object sender, EventArgs e)
        {
            lbl_str_mode.Text = configurator.get_str_mode();
            lbl_str_controls.Text = configurator.get_str_controls();

            coordinates.set_autoActualizeMousePositions();
            lbl_int_x.Text = coordinates.get_pnt_mouse().X.ToString();
            lbl_int_y.Text = coordinates.get_pnt_mouse().Y.ToString();


            if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.D0) & KeyStates.Down) > 0)
            {
         
                if (configurator.get_bln_isClientState0())
                {
                    imageHandler.fun_btm_captureClient_ExternalSave("E0" + int_capture.ToString());
                    int_capture++;
                }

                if (configurator.get_bln_isClientState1())
                {
                    imageHandler.load_reizedFiles();

                }

            }

            if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.D1) & KeyStates.Down) > 0)
            {
                if (configurator.get_bln_isClientState0())
                {
                    imageHandler.fun_btm_captureClient_ExternalSave("E4");
                }
            }

            if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.D2) & KeyStates.Down) > 0)
            {
                if (configurator.get_bln_isClientState1())
                {
                    imageHandler.load_reizedFiles();
                    lbl_info.Text = imageHandler.fun_str_mostSimilarInRange(4, 10);
                }
            }

            if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.D3) & KeyStates.Down) > 0)
            {

            }

            if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.D4) & KeyStates.Down) > 0)
            {

            }

            if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.D5) & KeyStates.Down) > 0)
            {

            }

            if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.D6) & KeyStates.Down) > 0)
            {

            }

            if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.D7) & KeyStates.Down) > 0)
            {

            }

            if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.D8) & KeyStates.Down) > 0)
            {

            }

            if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.D9) & KeyStates.Down) > 0)
            {

            }

            if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.J) & KeyStates.Down) > 0)
            {
                if (configurator.get_bln_isClientState1())
                {
                    imageHandler.load_reizedFiles();
                    lbl_info.Text = imageHandler.fun_str_mostSimilarInRange(0, 4);
                }
            }

            if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.K) & KeyStates.Down) > 0)
            {

            }

            if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.L) & KeyStates.Down) > 0)
            {
                tmr_configurator.Stop();
                lbl_str_mode.Text = "Mode.";
                lbl_str_controls.Text = "Controls.";
            }

            if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.M) & KeyStates.Down) > 0)
            {
                if (configurator.get_bln_isClientState0())
                {
                    imageHandler.file_resizeImageFiles();
                }

                if (configurator.get_bln_isClientState1())
                {
                    imageHandler.load_reizedFiles();
                    lbl_info.Text = imageHandler.fun_str_most_similar();
                }
            }

            if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.N) & KeyStates.Down) > 0)
            {
                if (configurator.get_bln_isClientState1())
                {
                    imageHandler.load_reizedFiles();
                    MessageBox.Show(imageHandler.asmd_findPosOFElement("4_inGame_1_resized").ToString());
                }
            }

            if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.F1) & KeyStates.Down) > 0)
            {
                configurator.set_config_0();
            }

            if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.F2) & KeyStates.Down) > 0)
            {
                configurator.set_config_1();
            }

            if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.F3) & KeyStates.Down) > 0)
            {
                configurator.set_config_2();
            }

        }

        private void tmr_ai_Tick(object sender, EventArgs e)
        {
            lbl_str_mode.Text = simpleAI.funget_str_complete_analisis();
            lbl_info.Text = simpleAI.str_info;
            coordinates.set_autoActualizeMousePositions();
            lbl_int_x.Text = coordinates.get_pnt_mouse().X.ToString();
            lbl_int_y.Text = coordinates.get_pnt_mouse().Y.ToString();

        }
    }
}

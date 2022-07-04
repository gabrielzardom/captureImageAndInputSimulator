using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxeleratorGabooster
{
    class cls_imageHandler
    {
        cls_coordenatesHandler obj_coordenatesHandler;
        Bitmap btm_clientArea;

        List<string> strL_fileNamesList;
        List<Bitmap> btmL_bitmapList;

        int int_min = 0;
        int int_max = 0;

        int int_stage               = 0;
        int int_loadingScreenPos    = 0;
        int int_inGame1Pos          = 0;
        int int_honorPos            = 0;


        public void set_coordenateeHandler(cls_coordenatesHandler obj_newCoordenatesHandler)
        {
            obj_coordenatesHandler = obj_newCoordenatesHandler;
        }

        public Bitmap fun_btm_capture_fractionOfScreen(int int_orgX, int int_orgY, int int_imageW, int int_imageH)
        {
            Bitmap btm_temp = new Bitmap(int_imageW, int_imageH);
            using (Graphics g = Graphics.FromImage(btm_temp))
            {
                g.CopyFromScreen(int_orgX, int_orgY, 0, 0, btm_temp.Size);
            }

            return btm_temp;

        }

        public Bitmap fun_btm_resize_screenShot(int int_newImageW, int int_newImageH, Bitmap btm_image)
        {
            Brush bsh_brush = new SolidBrush(Color.Black);

            Bitmap btm_bitmap = new Bitmap(int_newImageW, int_newImageH);
            Graphics gph_graph = Graphics.FromImage(btm_bitmap);


            gph_graph.FillRectangle(bsh_brush, new RectangleF(0, 0, int_newImageW, int_newImageH));
            gph_graph.DrawImage(btm_image, 0, 0, int_newImageW, int_newImageH);

            return btm_bitmap;
        }


        public bool fun_bln_inRange(int int_1, int int_2, int int_tolerance)
        {
            return (int_2 - 10 <= int_1) && (int_1 <= int_2 + 10);
        }

        public bool fun_bln_compare_pixels(Bitmap btm_image1, Bitmap btm_image2, int int_x, int int_y, int int_tolerance)
        {
            return (
                fun_bln_inRange(btm_image1.GetPixel(int_x, int_y).R, btm_image2.GetPixel(int_x, int_y).R, int_tolerance) &&
                fun_bln_inRange(btm_image1.GetPixel(int_x, int_y).G, btm_image2.GetPixel(int_x, int_y).G, int_tolerance) &&
                fun_bln_inRange(btm_image1.GetPixel(int_x, int_y).B, btm_image2.GetPixel(int_x, int_y).B, int_tolerance)
                );
        }
        public int fun_int_compare(Bitmap btm_image1, Bitmap btm_image2, int int_tolerance)
        {
            int int_toleratedPixels = 0;

            for (int int_x = 0; int_x < btm_image1.Width; int_x++)
            {
                for (int int_y = 0; int_y < btm_image1.Height; int_y++)
                {
                    //MessageBox.Show((btm_image1.GetPixel(int_x, int_y).R + btm_image1.GetPixel(int_x, int_y).B + btm_image1.GetPixel(int_x, int_y).G).ToString());
                    //MessageBox.Show((btm_image2.GetPixel(int_x, int_y).R + btm_image2.GetPixel(int_x, int_y).B + btm_image2.GetPixel(int_x, int_y).G).ToString());

                    if (fun_bln_compare_pixels(btm_image1, btm_image2, int_x, int_y, int_tolerance))
                    {
                        //MessageBox.Show("Tolerado");
                        int_toleratedPixels++;
                        //MessageBox.Show(int_toleratedPixels.ToString());
                    }
                }
            }
            //MessageBox.Show((btm_image1.Width * btm_image1.Height).ToString() + " Total");
            //MessageBox.Show(int_toleratedPixels.ToString() + " Tolerados");

            return (int)((100 / (float)(btm_image1.Width * btm_image1.Height)) * (float)int_toleratedPixels);
        }

        public void file_saveImage(Bitmap btm_image, string str_name)
        {
            try
            {
                var uniqueFileName = "C:\\temp\\" + str_name + ".Jpg";
                btm_image.Save(uniqueFileName, ImageFormat.Jpeg);
            }
            catch
            {
                MessageBox.Show("No se pudo guardar imagen.");
            }

        }

        public void fun_btm_captureClientAndResize_Internal()
        {
            btm_clientArea = fun_btm_capture_fractionOfScreen(obj_coordenatesHandler.get_pnt_clientO().X, obj_coordenatesHandler.get_pnt_clientO().Y,
            obj_coordenatesHandler.get_widthClient(), obj_coordenatesHandler.get_heighthClient());

            btm_clientArea = fun_btm_resize_screenShot(obj_coordenatesHandler.get_pnt_resizeR().X, obj_coordenatesHandler.get_pnt_resizeR().Y, btm_clientArea);
        }

        public void fun_btm_captureClientAndResize_ExternalSave(string str_name)
        {
            btm_clientArea = fun_btm_capture_fractionOfScreen(obj_coordenatesHandler.get_pnt_clientO().X, obj_coordenatesHandler.get_pnt_clientO().Y,
            obj_coordenatesHandler.get_widthClient(), obj_coordenatesHandler.get_heighthClient());

            btm_clientArea = fun_btm_resize_screenShot(obj_coordenatesHandler.get_pnt_resizeR().X, obj_coordenatesHandler.get_pnt_resizeR().Y, btm_clientArea);

            file_saveImage(btm_clientArea, str_name);
        }

        public void fun_btm_captureClient_ExternalSave(string str_name)
        {
            btm_clientArea = fun_btm_capture_fractionOfScreen(obj_coordenatesHandler.get_pnt_clientO().X, obj_coordenatesHandler.get_pnt_clientO().Y,
            obj_coordenatesHandler.get_widthClient(), obj_coordenatesHandler.get_heighthClient());

            file_saveImage(btm_clientArea, str_name);
        }

        public void file_resizeImageFiles()
        {
            List<string> str_list = new List<string>();

            str_list.Add("lobby");
            str_list.Add("find");
            str_list.Add("champs");
            str_list.Add("loading");
            str_list.Add("inGame1");
            str_list.Add("inGame2");
            str_list.Add("honor");
            str_list.Add("ownStats");
            str_list.Add("level");
            str_list.Add("matchStats");
            str_list.Add("lobby");

            for (int int_i = 0; int_i < str_list.Count; int_i++)
            {
                
                Bitmap btm_temporal = new Bitmap("C:\\temp\\" + str_list[int_i] + ".Jpg");
                btm_temporal = fun_btm_resize_screenShot(obj_coordenatesHandler.get_pnt_resizeR().X, obj_coordenatesHandler.get_pnt_resizeR().Y, btm_temporal);
                file_saveImage(btm_temporal,str_list[int_i] + "_resized");
            }

        }

        public string fun_str_most_similar()
        {
            fun_btm_captureClientAndResize_Internal();
            int masParecidoNumero = 0;
            string masParecido = "Ninguno";
            int int_parentezcoPercentage = 0;
            int int_aux = 0; 

            for (int int_i = 0; int_i < btmL_bitmapList.Count; int_i++)
            {
                int_parentezcoPercentage = fun_int_compare(btm_clientArea, btmL_bitmapList[int_i], 10);
                if (int_aux < int_parentezcoPercentage)
                {
                    int_aux = int_parentezcoPercentage;
                    masParecido = strL_fileNamesList[int_i];
                    masParecidoNumero = int_i;
                }
            }

            file_saveImage(btm_clientArea, "cliente_en_elmomento");
            file_saveImage(btmL_bitmapList[masParecidoNumero],"comparado");

            return masParecido + "," + int_aux.ToString();
        }

        public void load_reizedFiles()
        {
            strL_fileNamesList = new List<string>();
            btmL_bitmapList = new List<Bitmap>();

            strL_fileNamesList.Add("lobby_resized");
            strL_fileNamesList.Add("find_resized");
            strL_fileNamesList.Add("champs_resized");
            strL_fileNamesList.Add("loading_resized");
            strL_fileNamesList.Add("inGame1_resized");
            strL_fileNamesList.Add("inGame2_resized");
            strL_fileNamesList.Add("honor_resized");
            strL_fileNamesList.Add("ownStats_resized");
            strL_fileNamesList.Add("level_resized");
            strL_fileNamesList.Add("matchStats_resized");
            strL_fileNamesList.Add("lobby_resized");


            for (int int_i = 0; int_i < strL_fileNamesList.Count; int_i++)
            {
                btmL_bitmapList.Add(new Bitmap("C:\\temp\\" + strL_fileNamesList[int_i] + ".Jpg"));
            }

        }

        public int asmd_findPosOFElement(string str_search)
        {
            for (int int_i = 0; int_i < strL_fileNamesList.Count; int_i++)
            {
                if (strL_fileNamesList[int_i] == str_search)
                {
                    return int_i;
                }
            }
            return -1;
        }

        public string fun_str_mostSimilarInRange(int int_min, int int_max)
        {
            fun_btm_captureClientAndResize_Internal();
            int masParecidoNumero = -1;
            string masParecido = "Ninguno";
            int int_parentezcoPercentage = 0;
            int int_aux = 0;
            DateTime beforeProcess = DateTime.Now;

            for (int int_i = int_min; int_i < int_max + 1; int_i++)
            {
                int_parentezcoPercentage = fun_int_compare(btm_clientArea, btmL_bitmapList[int_i], 5);
                //MessageBox.Show("Comparando: " + strL_fileNamesList[int_i] + " " + int_parentezcoPercentage.ToString());
                if (int_aux < int_parentezcoPercentage)
                {
                    int_aux = int_parentezcoPercentage;
                    masParecido = strL_fileNamesList[int_i];
                    masParecidoNumero = int_i;
                }
            }

            if (masParecidoNumero != -1)
            {
                file_saveImage(btm_clientArea, "cliente_en_elmomento");
                file_saveImage(btmL_bitmapList[masParecidoNumero], "comparado");
            }

            DateTime afterProcess = DateTime.Now;
            var diffInSeconds = (afterProcess - beforeProcess).TotalSeconds;

            return masParecido + "," + int_aux.ToString() + "," + diffInSeconds.ToString();
        }

        public int[] fun_intA_mostSimilarInRange(int int_min, int int_max)
        {
            fun_btm_captureClientAndResize_Internal();
            int masParecidoNumero = -1;
            string masParecido = "Ninguno";
            int int_parentezcoPercentage = 0;
            int int_aux = 0;
            DateTime beforeProcess = DateTime.Now;

            for (int int_i = int_min; int_i < int_max + 1; int_i++)
            {
                int_parentezcoPercentage = fun_int_compare(btm_clientArea, btmL_bitmapList[int_i], 5);
                //MessageBox.Show("Comparando: " + strL_fileNamesList[int_i] + " " + int_parentezcoPercentage.ToString());
                if (int_aux < int_parentezcoPercentage)
                {
                    int_aux = int_parentezcoPercentage;
                    masParecido = strL_fileNamesList[int_i];
                    masParecidoNumero = int_i;
                }
            }

            /*
            if (masParecidoNumero != -1)
            {
                file_saveImage(btm_clientArea, "cliente_en_elmomento");
                file_saveImage(btmL_bitmapList[masParecidoNumero], "comparado");
            }
            */

            DateTime afterProcess = DateTime.Now;
            var diffInSeconds = (afterProcess - beforeProcess).TotalSeconds;

            int[] args = new int[3];
            args[0] = masParecidoNumero;
            args[1] = int_aux;
            args[2] = (int)diffInSeconds;

            return args;
        }

        public void fun_void_stagePreparation()
        {
            int_loadingScreenPos = asmd_findPosOFElement("loading_resized");
            int_inGame1Pos = asmd_findPosOFElement("inGame1_resized");
            int_honorPos   = asmd_findPosOFElement("honor_resized");

            int_stage   = 1;
            int_min     = 0;
            int_max     = int_inGame1Pos;

            return;
        }

        public int[] fun_detectClientState()
        {
            int[] intA3_clientState_similarityPercentage_secondsOfWork = fun_intA_mostSimilarInRange(int_min, int_max);

            if (int_stage == 1)
            {
                if (intA3_clientState_similarityPercentage_secondsOfWork[0] == int_loadingScreenPos)
                {
                    int_min = int_loadingScreenPos;
                }

                if (intA3_clientState_similarityPercentage_secondsOfWork[0] == int_max)
                {
                    int_min = int_inGame1Pos;
                    int_max = btmL_bitmapList.Count - 1;
                    int_stage = 2;
                }
            }

            if (int_stage == 2)
            {
                if (intA3_clientState_similarityPercentage_secondsOfWork[0] >= int_honorPos)
                {
                    int_min = int_honorPos;
                }

                if (intA3_clientState_similarityPercentage_secondsOfWork[0] == btmL_bitmapList.Count-1)
                {
                    int_min = 0;
                    int_max = int_inGame1Pos;
                    int_stage = 1;
                }
            }

            return intA3_clientState_similarityPercentage_secondsOfWork;
        }

    }
}

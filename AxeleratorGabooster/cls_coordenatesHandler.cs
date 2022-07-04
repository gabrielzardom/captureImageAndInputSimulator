using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Text.RegularExpressions;

namespace AxeleratorGabooster
{
    class cls_coordenatesHandler
    {
        Point pnt_mouse = new Point();

        Point pnt_champCenter;
        Point pnt_searchMatch;
        Point pnt_acceptMatch;

        
        Point pnt_champ1;
        Point pnt_champ2;
        Point pnt_champ3;
        Point pnt_champ4;
        Point pnt_champ5;

        Point pnt_selectChamp;
        Point pnt_itemCenter;

        Point pnt_continue;
        Point pnt_playAgain;

        Point pnt_top;
        Point pnt_mid;
        Point pnt_bot;

        Point pnt_resizeR;
        Point pnt_screenR;

        Point pnt_clientO;
        Point pnt_clientD;

        Point pnt_levelUp;

        public void set_autoActualizeMousePositions()
        {
            pnt_mouse.X = System.Windows.Forms.Cursor.Position.X;
            pnt_mouse.Y = System.Windows.Forms.Cursor.Position.Y;
        }

        public Point get_pnt_mouse()
        {
            return pnt_mouse;
        }
        public void file_loadPointData()
        {

            int int_counter = 0;

            foreach (string line in System.IO.File.ReadLines("C:\\temp\\coordenates.txt"))
            {

                string[] words = line.Split(',');
                words[0] = Regex.Replace(words[0], "[^0-9.]", "");
                words[1] = Regex.Replace(words[1], "[^0-9.]", "");

                if(int_counter == 0)
                {
                    pnt_searchMatch.X = int.Parse(words[0]);
                    pnt_searchMatch.Y = int.Parse(words[1]);
                }
                if (int_counter == 1)
                {
                    pnt_acceptMatch.X = int.Parse(words[0]);
                    pnt_acceptMatch.Y = int.Parse(words[1]);
                }
                if (int_counter == 2)
                {
                    pnt_champ1.X = int.Parse(words[0]);
                    pnt_champ1.Y = int.Parse(words[1]);
                }
                if (int_counter == 3)
                {
                    pnt_champ2.X = int.Parse(words[0]);
                    pnt_champ2.Y = int.Parse(words[1]);
                }
                if (int_counter == 4)
                {
                    pnt_champ3.X = int.Parse(words[0]);
                    pnt_champ3.Y = int.Parse(words[1]);
                }
                if (int_counter == 5)
                {
                    pnt_champ4.X = int.Parse(words[0]);
                    pnt_champ4.Y = int.Parse(words[1]);
                }
                if (int_counter == 6)
                {
                    pnt_champ5.X = int.Parse(words[0]);
                    pnt_champ5.Y = int.Parse(words[1]);
                }
                if (int_counter == 7)
                {
                    pnt_selectChamp.X = int.Parse(words[0]);
                    pnt_selectChamp.Y = int.Parse(words[1]);
                }
                if (int_counter == 8)
                {
                    pnt_champCenter.X = int.Parse(words[0]);
                    pnt_champCenter.Y = int.Parse(words[1]);
                }
                if (int_counter == 9)
                {
                    pnt_itemCenter.X = int.Parse(words[0]);
                    pnt_itemCenter.Y = int.Parse(words[1]);
                }
                if (int_counter == 10)
                {
                    pnt_top.X = int.Parse(words[0]);
                    pnt_top.Y = int.Parse(words[1]);
                }
                if (int_counter == 11)
                {
                    pnt_mid.X = int.Parse(words[0]);
                    pnt_mid.Y = int.Parse(words[1]);
                }
                if (int_counter == 12)
                {
                    pnt_bot.X = int.Parse(words[0]);
                    pnt_bot.Y = int.Parse(words[1]);
                }
                if (int_counter == 13)
                {
                    pnt_continue.X = int.Parse(words[0]);
                    pnt_continue.Y = int.Parse(words[1]);
                }
                if (int_counter == 14)
                {
                    pnt_playAgain.X = int.Parse(words[0]);
                    pnt_playAgain.Y = int.Parse(words[1]);
                }

                if (int_counter == 15)
                {
                    pnt_levelUp.X = int.Parse(words[0]);
                    pnt_levelUp.Y = int.Parse(words[1]);
                }
                int_counter++;

            }

        }

        public void file_loadImagetData()
        {
            int int_counter = 0;

            foreach (string line in System.IO.File.ReadLines("C:\\temp\\config.txt"))
            {

                string[] words = line.Split(',');
                words[0] = Regex.Replace(words[0], "[^0-9.]", "");
                words[1] = Regex.Replace(words[1], "[^0-9.]", "");

                if (int_counter == 0)
                {
                    pnt_screenR.X = int.Parse(words[0]);
                    pnt_screenR.Y = int.Parse(words[1]);
                }
                if (int_counter == 1)
                {
                    pnt_resizeR.X = int.Parse(words[0]);
                    pnt_resizeR.Y = int.Parse(words[1]);
                }
                if (int_counter == 2)
                {
                    pnt_clientO.X = int.Parse(words[0]);
                    pnt_clientO.Y = int.Parse(words[1]);
                }
                if (int_counter == 3)
                {
                    pnt_clientD.X = int.Parse(words[0]);
                    pnt_clientD.Y = int.Parse(words[1]);
                }
                int_counter++;

            }
        }

        public Point get_pnt_clientO()
        {
            return pnt_clientO;
        }

        public Point get_pnt_clientD()
        {
            return pnt_clientD;
        }

        public int get_widthClient()
        {
            return pnt_clientD.X - pnt_clientO.X;
        }

        public int get_heighthClient()
        {
            return pnt_clientD.Y - pnt_clientO.Y;
        }

        public Point get_pnt_resizeR()
        {
            return pnt_resizeR;
        }

    }
}

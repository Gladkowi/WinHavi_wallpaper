using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Microsoft.Win32;
using System.Runtime.InteropServices;


namespace lol
{
    public partial class Form1 : Form
    {
        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo
            (int uAction, int uParam, string lpvParam, int fuWinIni);

        public static void SetWallpaper(string path, string style, string title)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
            key.SetValue("WallpaperStyle", style);
            key.SetValue("TileWallpaper", title);
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }
        
        public Form1()
        {
            
               InitializeComponent();
            //FolderBrowserDialog FBD = new FolderBrowserDialog();
            //if (FBD.ShowDialog() == DialogResult.OK)
            //{
            //    MessageBox.Show(FBD.SelectedPath);
            //}
            switch (System.DateTime.Now.Hour)
            {
                case 8:
                    if (System.DateTime.Now.Minute < 30) { SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\1.png", "10", "0"); }
                    else { SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\2.png", "10", "0"); }
                    break;
                case 9:
                    if (System.DateTime.Now.Minute < 30) { SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\3.png", "10", "0"); }
                    else { SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\4.png", "10", "0"); }
                    break;
                case 10:
                    if (System.DateTime.Now.Minute < 30) { SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\5.png", "10", "0"); }
                    else { SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\6.png", "10", "0"); }
                    break;
                case 11:
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\7.png", "10", "0");
                    break;
                case 12:
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\7.png", "10", "0");
                    break;
                case 13:
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\7.png", "10", "0");
                    break;
                case 14:
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\7.png", "10", "0");
                    break;
                case 15:
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\7.png", "10", "0");
                    break;
                case 16:
                    if (System.DateTime.Now.Minute < 30) { SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\8.png", "10", "0"); }
                    else { SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\9.png", "10", "0"); }
                    break;
                case 17:
                    if (System.DateTime.Now.Minute < 30) { SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\10.png", "10", "0"); }
                    else { SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\11.png", "10", "0"); }
                    break;
                case 18:
                    if (System.DateTime.Now.Minute < 30) { SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\12.png", "10", "0"); }
                    else { SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\13.png", "10", "0"); }
                    break;
                case 19:
                    if (System.DateTime.Now.Minute < 30) { SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\14.png", "10", "0"); }
                    else { SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\15.png", "10", "0"); }
                    break;
                case 20:
                    if (System.DateTime.Now.Minute < 30) { SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\16.png", "10", "0"); }
                    break;
            }
            while (true)
            {
                
                if (8 == System.DateTime.Now.Hour && 30 > System.DateTime.Now.Minute)
                {
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\1.png", "10", "0");
                }
                if (8 == System.DateTime.Now.Hour && 30 <= System.DateTime.Now.Minute)
                {
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\2.png", "10", "0");
                }
                if (9 == System.DateTime.Now.Hour && 30 > System.DateTime.Now.Minute)
                {
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\3.png", "10", "0");
                }
                if (9 == System.DateTime.Now.Hour && 30 <= System.DateTime.Now.Minute)
                {
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\4.png", "10", "0");
                }
                if (10 == System.DateTime.Now.Hour && 30 > System.DateTime.Now.Minute)
                {
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\5.png", "10", "0");
                }
                if (10 == System.DateTime.Now.Hour && 30 <= System.DateTime.Now.Minute)
                {
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\6.png", "10", "0");
                }
                if (11 == System.DateTime.Now.Hour && 30 > System.DateTime.Now.Minute)
                {
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\7.png", "10", "0");
                }
                if (16 == System.DateTime.Now.Hour && 30 > System.DateTime.Now.Minute)
                {
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\8.png", "10", "0");
                }
                if (16 == System.DateTime.Now.Hour && 30 <= System.DateTime.Now.Minute)
                {
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\9.png", "10", "0");
                }
                if (17 == System.DateTime.Now.Hour && 30 > System.DateTime.Now.Minute)
                {
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\10.png", "10", "0");
                }
                if (17 == System.DateTime.Now.Hour && 30 <= System.DateTime.Now.Minute)
                {
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\11.png", "10", "0");
                }
                if (18 == System.DateTime.Now.Hour && 30 > System.DateTime.Now.Minute)
                {
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\12.png", "10", "0");
                }
                if (18 == System.DateTime.Now.Hour && 30 <= System.DateTime.Now.Minute)
                {
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\13.png", "10", "0");
                }
                if (19 == System.DateTime.Now.Hour && 30 <= System.DateTime.Now.Minute)
                {
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\14.png", "10", "0");
                }
                if (19 == System.DateTime.Now.Hour && 30 > System.DateTime.Now.Minute)
                {
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\15.png", "10", "0");
                }
                if (20 == System.DateTime.Now.Hour && 30 <= System.DateTime.Now.Minute)
                {
                    SetWallpaper("C:\\Wallpapers\\mojave_dynamic\\16.png", "10", "0");
                }
                System.Threading.Thread.Sleep(60000);//jeden 5 sec
            }
        }
    }
}


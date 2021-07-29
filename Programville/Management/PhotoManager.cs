using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Programville
{
    static class PhotoManager
    {
        public static Image LoadImage(string path)
        {
            return Image.FromFile(Application.StartupPath + path);
        }

        public static string SaveImage(Image img, string folder, int id)
        {
            string path = String.Format(@"\Content\{0}\", folder) + String.Format("{0}-{1}.png", id.ToString(), DateTime.Now.ToString());
            path = path.Replace('/', '-');
            path = path.Replace(' ', '-');
            path = path.Replace(':', '-');
            img.Save(Application.StartupPath + path, System.Drawing.Imaging.ImageFormat.Png);

            return path;

        }
    }
}

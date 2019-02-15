using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Datos;
using CreativaSL.Dll.ViajesItzaa.Global;


namespace CreativaSL.Dll.ViajesItzaa.Negocio
{
    public class Comun_Negocio
    {
        #region Métodos Auxiliares

        public static void AddExcFileTxt(Exception ex, string funcion)
        {
            try
            {
                string mydocpath = Comun.UrlTxtLog;

                if (File.Exists(mydocpath))
                {
                    using (StreamWriter outputFile = new StreamWriter(mydocpath, true))
                    {
                        outputFile.WriteLine(ex.HResult + " - " + DateTime.Now + " - " + funcion + " - " + ex.Message);
                    }
                }
                else
                {
                    using (StreamWriter outputFile = new StreamWriter(mydocpath))
                    {
                        outputFile.WriteLine(ex.HResult + " - " + DateTime.Now + " - " + funcion + " - " + ex.Message);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        public static System.Drawing.Image ResizeImage(System.Drawing.Image srcImage, int newWidth, int newHeight, ImageFormat Formato)
        {
            try
            {
                using (Bitmap imagenBitmap =
                   new Bitmap(newWidth, newHeight, PixelFormat.Format32bppRgb))
                {
                    imagenBitmap.SetResolution(
                       Convert.ToInt32(srcImage.HorizontalResolution),
                       Convert.ToInt32(srcImage.HorizontalResolution));

                    using (Graphics imagenGraphics =
                            Graphics.FromImage(imagenBitmap))
                    {
                        imagenGraphics.SmoothingMode =
                           SmoothingMode.AntiAlias;
                        imagenGraphics.InterpolationMode =
                           InterpolationMode.HighQualityBicubic;
                        imagenGraphics.PixelOffsetMode =
                           PixelOffsetMode.HighQuality;
                        imagenGraphics.DrawImage(srcImage,
                           new Rectangle(0, 0, newWidth, newHeight),
                           new Rectangle(0, 0, srcImage.Width, srcImage.Height),
                           GraphicsUnit.Pixel);
                        MemoryStream imagenMemoryStream = new MemoryStream();
                        imagenBitmap.Save(imagenMemoryStream, Formato);
                        srcImage = System.Drawing.Image.FromStream(imagenMemoryStream);
                    }
                }
                return srcImage;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        #endregion

        public void ObtenerSucursal(string conexion)
        {
            try
            {
                Comun_Datos cm = new Comun_Datos();
                cm.ObtenerConfiguracion(conexion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

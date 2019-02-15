using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Negocio;
using System.Data;
using EASendMail;
using System.Net;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop.ClasesAux
{
    public class EnvioCorreo
    {

        static string _dominio = Comun.Dominio;

        public static string GenerarHtmlCancelacion1(Solicitud Datos)
        {
            try
            {
                string dominio = _dominio;
                string html = "";
                string Estatus = Datos.EstatusSolicitud;
                string MotivoCancelacion = Datos.MotivoCancelacion;
                string Producto = Datos.NombreProducto;
                string Total = string.Format("{0:c}", Datos.Pago != null ? Datos.Pago.MontoTotal : 0);
                string Correo = Datos.Cliente != null ? Datos.Cliente.CorreoElectronico : string.Empty;
                string Cliente = Datos.Cliente != null ? Datos.Cliente.Nombre : string.Empty;
                string MontoPenalizacion = string.Format("{0:c}", Datos.MontoPenalizacion);
                string _facebook = Comun.UrlFacebook;
                string _twitter = Comun.UrlTwitter;
                string _googleplus = Comun.UrlGoogle;
                string correoItzaa = Comun.CorreoEmpresa;
                string telefono = Comun.Telefono2;
                html = @"<html>
            <head>
            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
            <title></title>
            <style type=""text/css"">
            div, p, a, li, td { -webkit-text-size-adjust:none; }
            .ReadMsgBody
            {width: 100%; background-color: #ffffff;}
            .ExternalClass
            {width: 100%; background-color: #ffffff;}
            body
            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
            html
            {width: 100%; }
            img 
            {border:0px; outline:none; text-decoration:none; display:block; }
            a
            {text-decoration: none; line-height: 30px; color: #ffffff;}
            a span
            {text-decoration:none; color: #ffffff;}
            h1 
            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
            h2 
            {font-size: 18px; margin: 10px 0 10px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:none;}
            h3 
            {font-size: 12px; margin: 5px 0 5px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
            @media only screen and (max-width: 900px) 
            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
            @media only screen and (max-width: 640px)
            { body{ width:auto!important; }
            .BoxWrap { width:440px !important;}
            .RespoHideMedium { display:none !important; } 
            .RespoShowMedium { display:block !important; } 
            .RespoCenterMedium { text-align:center !important; }
            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
            }
            @media only screen and (max-width: 479px)
            {
            body{width:auto!important;}
            .BoxWrap { width:280px !important;}
            .RespoHideSmall { display:none !important; }
            .RespoCenterSmall { text-align:center !important; }
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
            }
            .Bg_Color
            {
             background-color: #fefefe;
            }
            .BgImageAltColor
            {
            background-color: #2B9EB6;
            }
            .Preheader_Color
            {
            background-color: #8CBE3F;
            }
            .Content_Color
            {
             /*@editable*/ background-color: #ffffff;
            }
            .Color01_B
            {
             /*@editable background-color: #CE0000;*/
            }
            .Color01_D
            {
             /*@editable background-color: #000000;*/
            }
            .Color02_B
            {
             /*@editable*/ background-color: #E7E7EF;
            } 
            </style>
            </head>
            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td class=""RespoHideSmall"" width=""100%"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
            <tbody>
            <tr>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td class=""BgImageAltColor"" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;color: #ffffff;font-size: 28px;margin: 10px 0 10px 0;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">AGENCIA DE VIAJES <br> <br>Tu Agencia</h2>
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">¡ESCAPA, SÓLO ELIGE EL MOMENTO!</h3>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class="""" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h1 style=""text-transform: uppercase;text-align: center;color: #ffffff;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;line-height: 40px;""><a href=""#"" style=""color: #ffffff;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;font-style: italic;"">Gracias por elegirnos<br></a></h1>
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">Registro Nacional de Turismo No. XXXXXXXXXXX</h3>
            <p style=""text-align: justify;color: #fff;font-size: 17px;margin: 5px 0 5px 0;font-weight: normal;line-height: 18px; font-style:italic;"">Somos empresa 100 % mexicana ubicada en la capital del estado de Chiapas, Tuxtla Gutiérrez.  Nuestro  objetivo principal es:  la total  satisfacción de nuestros clientes, brindándoles servicios de calidad. En unidades en óptimas condiciones;  nuestro personal, operadores y guías están altamente calificados para hacer de su viaje una experiencia inolvidable.</p>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class="""" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style="""">
            <table class=""ecxColor02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"" width=""100%"">
            <tbody>
            <tr>
            <td style="""">
            <h1 style=""text-align:center;text-transform:none;font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;line-height:40px;"">
            <a href=""#"" style=""text-transform:none;text-decoration:none;color:#151516;line-height:30px;"">Cancelación de Solicitud</a></h1>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>

            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;""> 
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table width=""600"" class=""BoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" border=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td class=""RespoImage_70ToOneW"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
			<img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""RespoImage_70ToOne"" alt="""" style=""width: 185px; height: 130px; display: block; border: 0px none; outline: medium none; text-decoration: none;"" border=""0"" height=""100"" width=""185""></a>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
            <tbody>
            <tr>
            <td class=""Color01_B"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Mis datos</span></a></h3>
            </td>
            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <a href=""" + dominio + @"/MiCuenta"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""391"" align=""left"" cellpadding=""30"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""331"" style=""-webkit-text-size-adjust: none;"">
            <h1 style=""text-transform: uppercase;font-size: 15px;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + Correo + @"</h1>
            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Usuario: " + Cliente + @"</h3>
            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Contraseña: *****</h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Detalles</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""20"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>

           <tr>
            <td style=""width:50%"">
            <h2 style=""text-align:center;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
            Motivo</h2>
            </td>
            <td style=""width:50%"">
            <h2 style=""text-align:center;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
            " + Estatus + @"</h2>
            </td>
            </tr>

            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>

            <tr>
            <td style=""width:100%"">
            <p style=""text-align:justify;font-size:16px;color:#000;font-weight:normal;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
            " + MotivoCancelacion + @" </p>
            </td>
            </tr>

            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style="""">
            <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            Paquete o Servicio:</h3>
            </td>
            <td style="""">
            <h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
            " + Producto + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style="""">
            <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            Monto del paquete o servicio</h3>
            </td>
            <td style="""">
            <h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
            " + Total + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style="""">
            <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            Monto de penalización</h3>
            </td>
            <td style="""">
            <h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
            " + MontoPenalizacion + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td class=""ecxColor01_B"" style="""" bgcolor=""#2B9EB6"">
            <h3 style=""text-align:center;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            <a href="""" style=""text-decoration:none;line-height:30px;color:#ffffff;"" target=""_blank""><span style=""text-decoration:none;color:#ffffff;"">Nos ponemos a sus órdenes en el momento que desee volver a contactar con alguno de nuestros servicios. Recuerde visitar <a href=""" + dominio + @""" style=""text-decoration:none;line-height:30px;color:#ffffff;"" target=""_blank""><span style=""text-decoration:none;color:#ffffff;"">www.viajesitzaa.com<a> y encontrar novedades de viaje.</span></a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""30"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="" bgcolor=""#fff"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 22px;color: #8CBE3F;font-weight: bold;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif; font-style:italic;"">¡¡Esperamos contar con su preferencia!!</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""40"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. " + telefono + @"<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Chiapas</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Yucatan</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">QuintanaRoo</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Tour</a><br><a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Transportación</a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""10""></td>
            </tr>
            <tr>
            <td style=""text-align: center;"">
            <h3 style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            <a href=""#"" style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">Términos y Condiciones de Servicio</a></h3>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""20""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @""" style=""text-decoration: none;color: #151516;-webkit-text-size-adjust: none;line-height: 30px;"">Tu Agencia</a></h3>
            </td>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
            <tbody>
            <tr>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </body>
            </html>";
                return html;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GenerarHtmlOrdenPago1(Solicitud Datos)
        {
            try
            {
                string dominio = _dominio;
                string html = "";
                string linkPago = Datos.OrdenPago != null ? Datos.OrdenPago.LinkPago : string.Empty;
                string Total = string.Format("{0:c}", Datos.OrdenPago != null ? Datos.OrdenPago.Pago : 0);
                string NombreOrdenPago = Datos.OrdenPago != null ? Datos.OrdenPago.NombrePago : string.Empty;
                string Descripcion = Datos.OrdenPago != null ? Datos.OrdenPago.DescripcionPago : string.Empty;
                string Correo = Datos.Cliente != null ? Datos.Cliente.CorreoElectronico : string.Empty;
                string Cliente = Datos.Cliente != null ? Datos.Cliente.Nombre : string.Empty;
                string _facebook = Comun.UrlFacebook;
                string _twitter = Comun.UrlTwitter;
                string _googleplus = Comun.UrlGoogle;
                string correoItzaa = Comun.CorreoEmpresa;
                string telefono = Comun.Telefono2;
                html = @"
<html><head></head><body><br><div><br><title></title>
<style></style>
<table class=""ecxBg_Color"" align=""center"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td class=""ecxPreheader_Color"" style="""" bgcolor=""#f3f3f3"" valign=""top"">
<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
<tbody>
<tr>
<td style="""" height=""20""></td>
</tr>
<tr>
<td style="""">
<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""" align=""center"" width=""191""><a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" style=""width:191px;height:50px;max-width:191px;max-height:50px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""191"" height=""50"">
</a></td>
<td class=""ecxRespoHideSmall"" style="""" width=""100%""></td>
</tr>
</tbody>
</table>
</td>
<td class=""ecxRespoHideSmall"" style="""" width=""150"">
<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<table align=""right"" cellpadding=""0"" cellspacing=""0"">
<tbody>
<tr>
<td style="""" align=""right"" width=""50""><a href=""" + _facebook + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
</a></td>
<td style="""" align=""right"" width=""50""><a href=""" + _twitter + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
</a></td>
<td style="""" align=""right"" width=""50""><a href=""" + _googleplus + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
</a></td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td style="""" height=""20""></td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td class=""ecxBgImageAltColor"" style="""" bgcolor=""#2B9EB6"">
<table style=""clear:both;"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<table align=""center"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""" valign=""top"">
<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
<tbody>
<tr>
<td style="""" width=""100%"" height=""20""></td>
</tr>
<tr>
<td style="""">
<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<h2 style=""text-align:center;color:#ffffff;font-size:18px;font-weight:normal;line-height:22px;text-decoration:none;text-transform:none;font-family:Helvetica, Arial, sans-serif;"">
Operadora Turistica - Viajes Itzaa</h2>
</td>
</tr>
<tr>
<td style="""" width=""100%"" height=""20""></td>
</tr>
<tr>
<td class="""" style="""" bgcolor=""#8CBE3F"" width=""100%"" height=""1"">
</td>
</tr>
<tr>
<td style="""" width=""100%"" height=""10""></td>
</tr>
<tr>
<td style=""-webkit-text-size-adjust: none;"">
<h1 style=""text-transform: uppercase;text-align: center;color: #ffffff;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;line-height: 40px;""><a href=""#"" style=""color: #ffffff;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;font-style: italic;"">Gracias por elegirnos<br></a></h1>
<h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">Registro Nacional de Turismo No. XXXXXXXXXXX</h3>
<p style=""text-align: justify;color: #fff;font-size: 17px;margin: 5px 0 5px 0;font-weight: normal;line-height: 18px; font-style:italic;"">Somos empresa 100 % mexicana ubicada en la capital del estado de Chiapas, Tuxtla Gutiérrez.  Nuestro  objetivo principal es:  la total  satisfacción de nuestros clientes, brindándoles servicios de calidad. En unidades en óptimas condiciones;  nuestro personal, operadores y guías están altamente calificados para hacer de su viaje una experiencia inolvidable.</p>
</td>
</tr>
<tr>
<td style="""" width=""100%"" height=""20""></td>
</tr>
<tr>
<td class="""" style="""" bgcolor=""#8CBE3F"" width=""100%"" height=""1"">
</td>
</tr>
<tr>
<td style="""" width=""100%"" height=""20""></td>
</tr>
<tr>
<td style="""">
<table class=""ecxColor02_B"" bgcolor=""#fff"" cellpadding=""5"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<h1 style=""text-align:center;text-transform:none;font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;line-height:40px;"">
<a href=""#"" style=""text-transform:none;text-decoration:none;color:#151516;line-height:30px;"">Orden de Pago Paypal</a></h1>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td style="""" valign=""top"" height=""40"">&nbsp; </td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td style="""" valign=""top"">
<table class=""ecxBoxWrap"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""600"">
<tbody>
<tr>
<td style="""">
<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""" width=""100%"" height=""20""></td>
</tr>
</tbody>
</table>
<table class=""ecxContent_Color"" bgcolor=""#ffffff"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
<tbody>
<tr>
<td class=""ecxRespoImage_70ToOneW"" style=""""><a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""ecxRespoImage_70ToOne"" alt="""" style=""width:185px;height:130px;display:block;border:0px none;text-decoration:none;"" border=""0"" width=""185"" height=""100""></a>
</td>
</tr>
<tr>
<td style="""">
<table cellpadding=""7"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td class=""ecxColor01_B"" style="""" bgcolor=""#8CBE3F"">
<h3 style=""text-align:center;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
<a href=""" + dominio + @"/MiCuenta"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><span style=""text-decoration:none;color:#ffffff;"">Mis datos</span></a></h3>
</td>
<td class=""ecxColor01_D"" style="""" align=""center"" bgcolor=""#2B9EB6"" width=""50"">
<a href=""" + dominio + @"/MiCuenta"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" style=""width:32px;height:32px;max-width:32px;max-height:32px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""32"" height=""32"">
</a></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table class=""ecxBoxWrap"" align=""left"" cellpadding=""30"" cellspacing=""0"" width=""391"">
<tbody>
<tr>
<td style="""" width=""331"">
<h1 style=""text-transform:none;font-size:15px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;text-align:left;line-height:40px;"">
" + Cliente + @"</h1>
<h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
Usuario: " + Correo + @"</h3>
<h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
Contraseña: *****</h3>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>

<tr>
<td style="""" valign=""top"">
<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
<tbody>
<tr>
<td style="""">
<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""600"">
<tbody>
<tr>
<td style="""" width=""100%"" height=""20""></td>
</tr>
<tr>
<td style="""">
<table class=""ecxPreheader_Color"" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<h2 style=""text-align:center;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;text-transform:none;font-family:Helvetica, Arial, sans-serif;"">
Detalle de la orden de pago</h2>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td style="""">
<table class=""ecxPreheader_Color"" bgcolor=""#8CBE3F"" cellpadding=""20"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
NOMBRE DEL PAGO:</h3>
</td>
<td style="""">
<h2 style=""text-align:right;text-transform:none;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
" + NombreOrdenPago + @"</h2>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td style="""" width=""100%"" height=""2""></td>
</tr>
<tr>
<td style="""">
<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
DESCRIPCIÓN:</h3>
</td>
<td style="""">
<h2 style=""text-align:right;text-transform:none;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
" + Descripcion + @"</h2>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td style="""" width=""100%"" height=""2""></td>
</tr>

<tr>
<td style="""">
<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
MONTO:</h3>
</td>
<td style="""">
<h2 style=""text-align:right;text-transform:none;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
" + Total + @"</h2>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td style="""" width=""100%"" height=""2""></td>
</tr>

<tr>
<td style="""">
<table class=""ecxColor01_D"" bgcolor=""#042761"" cellpadding=""5"" cellspacing=""0"" width=""30%"" style=""margin-left: 70%;"">
<tbody>
<tr>
<td style="""">
<h3 style=""text-align:center;font-size:12px;color:#808185;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
<a href=""" + linkPago + @""" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><span style=""text-decoration:none;color:#ffffff;"">Pagar</span></a></h3>
</td>
</tr>
</tbody>
</table>
</td>
</tr>

</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td style="""" width=""100%"" height=""60""></td>
</tr>

<tr>
<td valign=""top"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
<table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
<tbody>
<tr>
<td style=""-webkit-text-size-adjust: none;"">
<table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
<tbody>
<tr>
<td style=""-webkit-text-size-adjust: none;"">
<table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
<tbody>
<tr>
<td style=""-webkit-text-size-adjust: none;"">
<h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
<h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. " + telefono + @"<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
<tbody>
<tr>
<td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
<p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
<tbody>
<tr>
<td style="""">
<table class=""ecxColor01_D"" bgcolor=""#2B9EB6"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:none;font-family:Helvetica, Arial, sans-serif;"">
Paquetes:</h2>
<h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
<a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Chiapas</a><br>
<a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Yucatan</a><br>
<a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">QuintanaRoo</a></h3>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
<tbody>
<tr>
<td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
<p style=""padding-left:20px;"">&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<table class=""ecxBoxWrap"" align=""right"" cellpadding=""0"" cellspacing=""0"" width=""184"">
<tbody>
<tr>
<td style="""">
<table class=""ecxColor01_D"" bgcolor=""#2B9EB6"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:none;font-family:Helvetica, Arial, sans-serif;"">
Servicios:</h2>
<h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
<a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Tour</a><br>
<a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Transportación</a>
</h3>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td style="" width=""100%"" height=""10""></td>
</tr>
<tr>
<td style=""text-align: center;"">
<h3 style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
<a href=""#"" style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">Términos y Condiciones de Servicio</a></h3>
</td>
</tr>
<tr>
<td style="" width=""100%"" height=""20""></td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td class=""ecxPreheader_Color"" style="""" bgcolor=""#f3f3f3"" valign=""top"">
<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
<tbody>
<tr>
<td style="""" height=""20""></td>
</tr>
<tr>
<td style="""">
<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
<a href=""#"" style=""text-decoration:none;color:#151516;text-transform:capitalize;line-height:30px;"">Tu Agencia</a></h3>
</td>
<td class=""ecxRespoHideSmall"" style="""" width=""150"">
<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<table align=""right"" cellpadding=""0"" cellspacing=""0"">
<tbody>
<tr>
<td style="""" align=""right"" width=""50""><a href=""" + _facebook + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
</a></td>
<td style="""" align=""right"" width=""50""><a href=""" + _twitter + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
</a></td>
<td style="""" align=""right"" width=""50""><a href=""" + _googleplus + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
</a></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td style="""" height=""20""></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table></div></body></html>
                    ";
                return html;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GenerarHtmlConfirmacionCompra1(Solicitud Datos)
        {
            try
            {
                string dominio = _dominio;
                string textoAuxiliar = string.Empty;
                string correoCliente = Datos.Cliente != null ? Datos.Cliente.CorreoElectronico : string.Empty;
                string Cliente = Datos.Cliente != null ? Datos.Cliente.Nombre : string.Empty;
                string nombrePaquete = Datos.NombreProducto;
                string Folio = Datos.Folio;
                string FechaLimInicial = Datos.FechaLimPagoInicial.ToShortDateString();
                string FechaLimFinal = Datos.FechaLimPagoFinal.ToShortDateString();
                string _facebook = Comun.UrlFacebook;
                string _twitter = Comun.UrlTwitter;
                string _googleplus = Comun.UrlGoogle;
                string correoItzaa = Comun.CorreoEmpresa;
                string telefono = Comun.Telefono2;
                string MontoTotal = string.Format("{0:c}", Datos.MontoPagado);
                string MontoInicial = string.Format("{0:c}", Datos.MontoInicial);
                string MotivoMontoInicial = Datos.MotivoMontoInicial;
                string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
                string AnticipoResto = string.Format("{0:F2}", 100 - Comun.PorcentajeAnticipo);
                string MontoAnticipo = string.Format("{0:c}", Datos.MontoAnticipo);
                string MontoFinal = string.Format("{0:c}", Datos.MontoFinal);
                string txtAnticipoPagado = "Cubierto por monto Inicial";
                string txtFinalPagado = "Cubierto por monto Inicial";
                string txtFechaIniPagado = "No aplica";
                string txtFechaFinPagado = "No aplica";
                if (Datos.MontoInicial > 0)
                {
                    if (Datos.MontoInicial >= Datos.MontoPagado)
                    {
                        MontoAnticipo = txtAnticipoPagado;
                        MontoFinal = txtFinalPagado;
                        FechaLimInicial = txtFechaIniPagado;
                        FechaLimFinal = txtFechaFinPagado;
                    }
                    else
                    {
                        if (Datos.MontoInicial >= Datos.MontoAnticipo)
                        {
                            decimal Diferencia = Datos.MontoInicial - Datos.MontoAnticipo;
                            MontoAnticipo = txtAnticipoPagado;
                            FechaLimInicial = txtFechaIniPagado;
                            MontoFinal = string.Format("{0:c}", Datos.MontoFinal - Diferencia);
                        }
                        else
                        {
                            MontoAnticipo = string.Format("{0:c}", Datos.MontoAnticipo - Datos.MontoInicial);
                        }
                    }
                }
                string html = @"

<html><head></head><body><br><div><br>
<title></title>
<table class=""ecxBg_Color"" align=""center"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td class=""ecxPreheader_Color"" style="""" bgcolor=""#f3f3f3"" valign=""top"">
<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
<tbody>
<tr>
<td style="""" height=""20""></td>
</tr>
<tr>
<td style="""">
<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""" align=""center"" width=""191""><a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" style=""width:191px;height:50px;max-width:191px;max-height:50px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""191"" height=""50"">
</a></td>
<td class=""ecxRespoHideSmall"" style="""" width=""100%""></td>
</tr>
</tbody>
</table>
</td>
<td class=""ecxRespoHideSmall"" style="""" width=""150"">
<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<table align=""right"" cellpadding=""0"" cellspacing=""0"">
<tbody>
<tr>
<td style="""" align=""right"" width=""50""><a href=""" + _facebook + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
</a></td>
<td style="""" align=""right"" width=""50""><a href=""" + _twitter + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
</a></td>
<td style="""" align=""right"" width=""50""><a href=""" + _googleplus + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
</a></td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td style="""" height=""20""></td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td class=""ecxBgImageAltColor"" style="""" bgcolor=""#2B9EB6"">
<table style=""clear:both;"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<table align=""center"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""" valign=""top"">
<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
<tbody>
<tr>
<td style="""" width=""100%"" height=""20""></td>
</tr>
<tr>
<td style="""">
<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<h2 style=""text-align:center;color:#ffffff;font-size:18px;font-weight:normal;line-height:22px;text-decoration:none;text-transform:none;font-family:Helvetica, Arial, sans-serif;"">
Operadora Turistica - ViajesItzaa</h2>
</td>
</tr>
<tr>
<td style="""" width=""100%"" height=""20""></td>
</tr>
<tr>
<td class="""" style="""" bgcolor=""#8CBE3F"" width=""100%"" height=""1"">
</td>
</tr>
<tr>
<td style="""" width=""100%"" height=""10""></td>
</tr>
<tr>
<td style=""-webkit-text-size-adjust: none;"">
<h1 style=""text-transform: uppercase;text-align: center;color: #ffffff;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;line-height: 40px;""><a href=""#"" style=""color: #ffffff;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;font-style: italic;"">Gracias por elegirnos<br></a></h1>
<h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">Registro Nacional de Turismo No. XXXXXXXXXXX</h3>
<p style=""text-align: justify;color: #fff;font-size: 17px;margin: 5px 0 5px 0;font-weight: normal;line-height: 18px; font-style:italic;"">Somos empresa 100 % mexicana ubicada en la capital del estado de Chiapas, Tuxtla Gutiérrez.  Nuestro  objetivo principal es:  la total  satisfacción de nuestros clientes, brindándoles servicios de calidad. En unidades en óptimas condiciones;  nuestro personal, operadores y guías están altamente calificados para hacer de su viaje una experiencia inolvidable.</p>
</td>
</tr>
<tr>
<td style="""" width=""100%"" height=""20""></td>
</tr>
<tr>
<td class="""" style="""" bgcolor=""#8CBE3F"" width=""100%"" height=""1"">
</td>
</tr>
<tr>
<td style="""" width=""100%"" height=""20""></td>
</tr>

</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td style="""" valign=""top"" height=""40"">&nbsp; </td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td style="""" valign=""top"">
<table class=""ecxBoxWrap"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""600"">
<tbody>
<tr>
<td style="""">
<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""" width=""100%"" height=""20""></td>
</tr>
</tbody>
</table>
<table class=""ecxContent_Color"" bgcolor=""#ffffff"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
<tbody>
<tr>
<td class=""ecxRespoImage_70ToOneW"" style=""""><a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""ecxRespoImage_70ToOne"" alt="""" style=""width:185px;height:130px;display:block;border:0px none;text-decoration:none;"" border=""0"" width=""185"" height=""100""></a>
</td>
</tr>
<tr>
<td style="""">
<table cellpadding=""7"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td class=""ecxColor01_B"" style="""" bgcolor=""#8CBE3F"">
<h3 style=""text-align:center;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
<a href=""" + dominio + @"/MiCuenta"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><span style=""text-decoration:none;color:#ffffff;"">Mis datos</span></a></h3>
</td>
<td class=""ecxColor01_D"" style="""" align=""center"" bgcolor=""#2B9EB6"" width=""50"">
<a href=""" + dominio + @"/MiCuenta"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" style=""width:32px;height:32px;max-width:32px;max-height:32px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""32"" height=""32"">
</a></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table class=""ecxBoxWrap"" align=""left"" cellpadding=""30"" cellspacing=""0"" width=""391"">
<tbody>
<tr>
<td style="""" width=""331"">
<h1 style=""text-transform:none;font-size:15px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;text-align:left;line-height:40px;"">
" + Cliente + @"</h1>
<h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
Usuario: " + correoCliente + @"</h3>
<h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
Contraseña: *****</h3>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>

<tr>
<td style="""" valign=""top"">
<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
<tbody>
<tr>
<td style="""">
<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""600"">
<tbody>
<tr>
<td style="""" width=""100%"" height=""20""></td>
</tr>

<tr>
<td style="""">
<table class=""ecxPreheader_Color"" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<h2 style=""text-align:center;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;text-transform:none;font-family:Helvetica, Arial, sans-serif;"">
CONFIRMACIÓN DE COMPRA</h2>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td style="""">
<table class=""ecxPreheader_Color"" bgcolor=""#8CBE3F"" cellpadding=""20"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td class=""ecxRespoImage_OneToOneW"" style=""""><img class=""ecxRespoImage_OneToOne"" src=""" + dominio + @"/Imagenes/FormasPago/FormasPago.png"" alt="""" style=""width:530px;height:401px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""401"" height=""401"">
</td>
</tr>
</tbody>
</table>
</td>
</tr>

<tr>
<td style="""" width=""100%"" height=""2""></td>
</tr>

<tr>
<td style="""">
<table class=""ecxPreheader_Color"" bgcolor=""#8CBE3F"" cellpadding=""20"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
Pago Inicial</h3>
</td>
<td style="""">
<h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
" + MontoAnticipo + @"</h2>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td style="""" width=""100%"" height=""2""></td>
</tr>
<tr>
<td style="""">
<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
Fecha Límite de Pago Inicial</h3>
</td>
<td style="""">
<h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
" + FechaLimInicial + @"</h2>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td style="""" width=""100%"" height=""2""></td>
</tr>
<tr>
<td style="""">
<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
Pago Final</h3>
</td>
<td style="""">
<h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
" + MontoFinal + @"</h2>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td style="""" width=""100%"" height=""2""></td>
</tr>
<tr>
<td style="""">
<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
Fecha Límite de Pago Final</h3>
</td>
<td style="""">
<h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
" + FechaLimFinal + @"</h2>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td style="""" width=""100%"" height=""2""></td>
</tr>";

                if (!string.IsNullOrEmpty(textoAuxiliar))
                {
                    html = html + @"
                    <tr>
                    <td style="""">
                    <table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
                    <tbody>
                    <tr>
                    <td style="""">
                    <h2 style=""text-align:left;font-size:14px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
                    " + textoAuxiliar + @"</h2>
                    </td>
                    </tr>
                    </tbody>
                    </table>
                    </td>
                    </tr>";
                }
                html = html + @"
<tr>
<td style="""" width=""100%"" height=""2""></td>
</tr>
<tr>
<td style="""">
<h2 style=""font-size:18px;color:#000;text-align:right;font-weight:normal;line-height:22px;text-decoration:none;text-transform:none;font-family:Helvetica, Arial, sans-serif;"">
Monto Total</h2>
<h1 style=""font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;text-align:right;line-height:40px;"">
" + MontoTotal + @"</h1>
</td>
</tr>
<tr>
<td width=""100%"" height=""60"" style=""-webkit-text-size-adjust: none;""></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="" bgcolor=""#fff"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 10px;color: #000;font-weight: bold;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">La transportación que le brindamos es privada no se añade a ningún grupo y contamos con salidas diarias.</h2>
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 10px;color: #000;font-weight: bold;line-height: 18px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Para poder reservar con tu agencia, se realiza un depósito o transferencia bancaria del " + Anticipo + @"% del monto total del servicio y el otro " + AnticipoResto + @"% se liquida al llegar a Tuxtla Gutiérrez. </h2>
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 14px;color: #000;font-weight: bold;line-height: 18px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">EN BREVE UN AGENTE DE VENTAS SE COMUNICARÁ CON USTED PARA EXPLICARLE CON MAYOR DETALLE NUESTROS SERVICIOS.</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""40"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
<tr>
<td class=""ecxColor01_D"" style="""" bgcolor=""#2B9EB6"" valign=""top"">
<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
<tbody>
<tr>
<td style="""">
<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
<tbody>
<tr>
<td style="""">
<table class=""ecxColor01_D"" bgcolor=""#2B9EB6"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:none;font-family:Helvetica, Arial, sans-serif;"">
Datos de contacto:</h2>
<h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
Tel. " + telefono + @"<br>
<a href=""#"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"">Email. " + correoItzaa + @"</a></h3>


</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
<tbody>
<tr>
<td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
<p style=""padding-left:20px;"">&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
<tbody>
<tr>
<td style="""">
<table class=""ecxColor01_D"" bgcolor=""#2B9EB6"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style=""-webkit-text-size-adjust: none;"">
<h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
<h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Chiapas</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Yucatan</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">QuintanaRoo</a></h3>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
<tbody>
<tr>
<td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
<p style=""padding-left:20px;"">&nbsp;</p>
</td>
</tr>
</tbody>
</table>
<table class=""ecxBoxWrap"" align=""right"" cellpadding=""0"" cellspacing=""0"" width=""184"">
<tbody>
<tr>
<td style="""">
<table class=""ecxColor01_D"" bgcolor=""#2B9EB6"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style=""-webkit-text-size-adjust: none;"">
<h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
<h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Tour</a><br><a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Transportación</a>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td style="" width=""100%"" height=""10""></td>
</tr>
<tr>
<td style=""text-align: center;"">
<h3 style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
<a href=""#"" style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">Términos y Condiciones de Servicio</a></h3>
</td>
</tr>
<tr>
<td style="" width=""100%"" height=""20""></td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td class=""ecxPreheader_Color"" style="""" bgcolor=""#f3f3f3"" valign=""top"">
<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
<tbody>
<tr>
<td style="""" height=""20""></td>
</tr>
<tr>
<td style="""">
<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
<a href=""" + dominio + @""" style=""text-decoration:none;color:#151516;text-transform:capitalize;line-height:30px;"">Tu Agencia</a></h3>
</td>
<td class=""ecxRespoHideSmall"" style="""" width=""150"">
<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
<tbody>
<tr>
<td style="""">
<table align=""right"" cellpadding=""0"" cellspacing=""0"">
<tbody>
<tr>
<td style="""" align=""right"" width=""50""><a href=""" + _facebook + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
</a></td>
<td style="""" align=""right"" width=""50""><a href=""" + _twitter + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
</a></td>
<td style="""" align=""right"" width=""50""><a href=""" + _googleplus + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
</a></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
<tr>
<td style="""" height=""20""></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table></div></body></html>

                ";
                return html;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GenerarHtmlConfirmacionPago1(Solicitud Datos)
        {
            try
            {
                string dominio = _dominio;
                string correoCliente = Datos.Cliente != null ? Datos.Cliente.CorreoElectronico : string.Empty;
                string Cliente = Datos.Cliente != null ? Datos.Cliente.Nombre : string.Empty;
                string fechaPago = Datos.Pago != null ? Datos.Pago.FechaPago.ToShortDateString() : string.Empty;
                string monto = string.Format("{0:c}", Datos.Pago != null ? Datos.Pago.MontoPagado : 0);
                string nombrePaquete = Datos.NombreProducto;

                string _facebook = Comun.UrlFacebook;
                string _twitter = Comun.UrlTwitter;
                string _googleplus = Comun.UrlGoogle;
                string correoItzaa = Comun.CorreoEmpresa;
                string telefono = Comun.Telefono2;

                string html = @"
                <html>
                <head>
                <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
                <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
                <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
                </head>
                <body><br><div><br>
                <title></title>
                <style></style>
                <table class=""ecxBg_Color"" align=""center"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td class=""ecxPreheader_Color"" style="""" bgcolor=""#f3f3f3"" valign=""top"">
                <table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
                <tbody>
                <tr>
                <td style="""" height=""20""></td>
                </tr>
                <tr>
                <td style="""">
                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""" align=""center"" width=""191""><a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" style=""width:191px;height:50px;max-width:191px;max-height:50px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""191"" height=""50"">
                </a></td>
                <td class=""ecxRespoHideSmall"" style="""" width=""100%""></td>
                </tr>
                </tbody>
                </table>
                </td>
                <td class=""ecxRespoHideSmall"" style="""" width=""150"">
                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <table align=""right"" cellpadding=""0"" cellspacing=""0"">
                <tbody>
                <tr>
                <td style="""" align=""right"" width=""50""><a href=""" + _facebook + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
                </a></td>
                <td style="""" align=""right"" width=""50""><a href=""" + _twitter + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
                </a></td>
                <td style="""" align=""right"" width=""50""><a href=""" + _googleplus + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
                </a></td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td style="""" height=""20""></td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td class=""ecxBgImageAltColor"" style="""" bgcolor=""#2B9EB6"">
                <table style=""clear:both;"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <table align=""center"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""" valign=""top"">
                <table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
                <tbody>
                <tr>
                <td style="""" width=""100%"" height=""20""></td>
                </tr>
                <tr>
                <td style="""">
                <table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <h2 style=""text-align: center;color: #ffffff;font-size: 28px;margin: 10px 0 10px 0;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">AGENCIA DE VIAJES <br> <br>Tu Agencia</h2>
                <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">¡ESCAPA, SÓLO ELIGE EL MOMENTO!</h3>
                </td>
                </tr>
                <tr>
                <td style="""" width=""100%"" height=""20""></td>
                </tr>
                <tr>
                <td class="""" style="""" bgcolor=""#8CBE3F"" width=""100%"" height=""1"">
                </td>
                </tr>
                <tr>
                <td style="""" width=""100%"" height=""10""></td>
                </tr>
                <tr>
                <td style=""-webkit-text-size-adjust: none;"">
                <h1 style=""text-transform: uppercase;text-align: center;color: #ffffff;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;line-height: 40px;""><a href=""#"" style=""color: #ffffff;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;font-style: italic;"">Gracias por elegirnos<br></a></h1>
                <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">Registro Nacional de Turismo No. XXXXXXXXXXX</h3>
                <p style=""text-align: justify;color: #fff;font-size: 17px;margin: 5px 0 5px 0;font-weight: normal;line-height: 18px; font-style:italic;"">Somos empresa 100 % mexicana ubicada en la capital del estado de Chiapas, Tuxtla Gutiérrez.  Nuestro  objetivo principal es:  la total  satisfacción de nuestros clientes, brindándoles servicios de calidad. En unidades en óptimas condiciones;  nuestro personal, operadores y guías están altamente calificados para hacer de su viaje una experiencia inolvidable.</p>
                </td>
                </tr>
                <tr>
                <td style="""" width=""100%"" height=""20""></td>
                </tr>
                <tr>
                <td class="""" style="""" bgcolor=""#8CBE3F"" width=""100%"" height=""1"">
                </td>
                </tr>
                <tr>
                <td style="""" width=""100%"" height=""20""></td>
                </tr>
                <tr>
                <td style="""">
                <table class=""ecxColor02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <h1 style=""text-align:center;text-transform:none;font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;line-height:40px;"">
                <a href=""#"" style=""text-transform:none;text-decoration:none;color:#151516;line-height:30px;"">Agradecemos la realización de su pago.</a></h1>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>.
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td style="""" valign=""top"" height=""40"">&nbsp; </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td style="""" valign=""top"">
                <table class=""ecxBoxWrap"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""600"">
                <tbody>
                <tr>
                <td style="""">
                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""" width=""100%"" height=""20""></td>
                </tr>
                </tbody>
                </table>
                <table class=""ecxContent_Color"" bgcolor=""#ffffff"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
                <tbody>
                <tr>
                <td class=""ecxRespoImage_70ToOneW"" style=""""><a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""ecxRespoImage_70ToOne"" alt="""" style=""width:185px;height:130px;display:block;border:0px none;text-decoration:none;"" border=""0"" width=""185"" height=""100""></a>
                </td>
                </tr>
                <tr>
                <td style="""">
                <table cellpadding=""7"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td class=""ecxColor01_B"" style="""" bgcolor=""#8CBE3F"">
                <h3 style=""text-align:center;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
                <a href=""" + dominio + @"/MiCuenta"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><span style=""text-decoration:none;color:#ffffff;"">Mis datos</span></a></h3>
                </td>
                <td class=""ecxColor01_D"" style="""" align=""center"" bgcolor=""#2B9EB6"" width=""50"">
                <a href=""" + dominio + @"/MiCuenta"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" style=""width:32px;height:32px;max-width:32px;max-height:32px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""32"" height=""32"">
                </a></td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                </tbody>
                </table>
                <table class=""ecxBoxWrap"" align=""left"" cellpadding=""30"" cellspacing=""0"" width=""391"">
                <tbody>
                <tr>
                <td style="""" width=""331"">
                <h1 style=""text-transform:none;font-size:15px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;text-align:left;line-height:40px;"">
                " + Cliente + @"</h1>
                <h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
                Usuario: " + correoCliente + @"</h3>
                <h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
                Contraseña: *****</h3>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>

                <tr>
                <td style="""" valign=""top"">
                <table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
                <tbody>
                <tr>
                <td style="""">
                <table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""600"">
                <tbody>
                <tr>
                <td style="""" width=""100%"" height=""20""></td>
                </tr>
                <tr>
                <td style="""">
                <table class=""ecxPreheader_Color"" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <h2 style=""text-align:center;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;text-transform:none;font-family:Helvetica, Arial, sans-serif;"">
                Detalles de la compra</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td style="""">
                <table class=""ecxPreheader_Color"" bgcolor=""#8CBE3F"" cellpadding=""20"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
                Paquete o Servicio:</h3>
                </td>
                <td style="""">
                <h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
                " + nombrePaquete + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td style="""" width=""100%"" height=""2""></td>
                </tr>
                <tr>
                <td style="""">
                <table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
                Fecha de aprobación del pago:</h3>
                </td>
                <td style="""">
                <h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
                " + fechaPago + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td style="""" width=""100%"" height=""2""></td>
                </tr>
                <tr>
                <td style="""">
                <table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
                Monto del pago:</h3>
                </td>
                <td style="""">
                <h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
                " + monto + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td style="""" width=""100%"" height=""2""></td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td style="""" width=""100%"" height=""60""></td>
                </tr>
                <tr>
                <td class=""ecxColor01_D"" style="""" bgcolor=""#2B9EB6"" valign=""top"">
                <table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
                <tbody>
                <tr>
                <td style="""">
                <table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
                <tbody>
                <tr>
                <td style="""">
                <table class=""ecxColor01_D"" bgcolor=""#2B9EB6"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:none;font-family:Helvetica, Arial, sans-serif;"">
                Datos de contacto:</h2>
                <h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
                Tel. " + telefono + @"<br>
                <a href=""#"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"">Email. " + correoItzaa + @"</a></h3>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                </tbody>
                </table>
                <table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
                <tbody>
                <tr>
                <td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
                <p style=""padding-left:20px;"">&nbsp;</p>
                </td>
                </tr>
                </tbody>
                </table>
                <table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
                <tbody>
                <tr>
                <td style="""">
                <table class=""ecxColor01_D"" bgcolor=""#2B9EB6"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:none;font-family:Helvetica, Arial, sans-serif;"">
                Paquetes:</h2>
                <h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
                <a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Chiapas</a><br>
                <a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Yucatan</a><br>
                <a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">QuintanaRoo</a></h3>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                </tbody>
                </table>
                <table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
                <tbody>
                <tr>
                <td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
                <p style=""padding-left:20px;"">&nbsp;</p>
                </td>
                </tr>
                </tbody>
                </table>
                <table class=""ecxBoxWrap"" align=""right"" cellpadding=""0"" cellspacing=""0"" width=""184"">
                <tbody>
                <tr>
                <td style="""">
                <table class=""ecxColor01_D"" bgcolor=""#2B9EB6"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:none;font-family:Helvetica, Arial, sans-serif;"">
                Servicios:</h2>
                <h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
                <a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Tour</a><br>
                <a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Transportación</a>
                </h3>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td style="" width=""100%"" height=""10""></td>
                </tr>
                <tr>
                <td style=""text-align: center;"">
                <h3 style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
                <a href=""#"" style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">Términos y Condiciones de Servicio</a></h3>
                </td>
                </tr>
                <tr>
                <td style="" width=""100%"" height=""20""></td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td class=""ecxPreheader_Color"" style="""" bgcolor=""#f3f3f3"" valign=""top"">
                <table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
                <tbody>
                <tr>
                <td style="""" height=""20""></td>
                </tr>
                <tr>
                <td style="""">
                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
                <a href=""" + dominio + @""" style=""text-decoration:none;color:#151516;text-transform:capitalize;line-height:30px;"">Tu Agencia</a></h3>
                </td>
                <td class=""ecxRespoHideSmall"" style="""" width=""150"">
                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <table align=""right"" cellpadding=""0"" cellspacing=""0"">
                <tbody>
                <tr>
                <td style="""" align=""right"" width=""50""><a href=""" + _facebook + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
                </a></td>
                <td style="""" align=""right"" width=""50""><a href=""" + _twitter + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
                </a></td>
                <td style="""" align=""right"" width=""50""><a href=""" + _googleplus + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
                </a></td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td style="""" height=""20""></td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                </tbody>
                </table></div></body></html>
                ";

                return html;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool EnviarCorreo(string De, string Contraseña, string Para, string Asunto, string Mensaje, bool banArchivo, string Archivo, bool Html, string Host, int Port, bool Ssl)
        {
            try
            {

                //GMAIL
                //Habilitar las siguientes opciones en correo de gmail
                //https://www.google.com/settings/security/lesssecureapps
                //https://accounts.google.com/DisplayUnlockCaptcha
                //HOTMAIL
                //Enviara las primeras veces despues nos llegara un correo para reconocer el inicio de sesion 
                //ya que depende del servidor donde esta alojado y se tiene que reconocer el inicio de sesion   
                //Para = "lackke.141727@gmail.com";
                System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();
                mailMessage.From = new System.Net.Mail.MailAddress(De);
                mailMessage.To.Add(Para);
                mailMessage.Subject = Asunto;
                if (banArchivo)
                    mailMessage.Attachments.Add(new System.Net.Mail.Attachment(Archivo));
                mailMessage.Body = Mensaje;
                mailMessage.IsBodyHtml = Html;
                System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient(Host);
                smtpClient.Port = Port;
                smtpClient.EnableSsl = Ssl;
                smtpClient.Credentials = new NetworkCredential(De, Contraseña);
                smtpClient.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "EnvioCorreo.EnviarCorreo");
                return false;
            }
        }

        public static bool EnviarCorreoArchivo(string De, string Contraseña, string Para, string Asunto, string Mensaje, bool banArchivo, string Archivo, bool Html, string Host, int Port, bool Ssl)
        {
            try
            {

                //GMAIL
                //Habilitar las siguientes opciones en correo de gmail
                //https://www.google.com/settings/security/lesssecureapps
                //https://accounts.google.com/DisplayUnlockCaptcha
                //HOTMAIL
                //Enviara las primeras veces despues nos llegara un correo para reconocer el inicio de sesion 
                //ya que depende del servidor donde esta alojado y se tiene que reconocer el inicio de sesion   
                //Para = "lackke.141727@gmail.com";
                System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();
                mailMessage.From = new System.Net.Mail.MailAddress(De);
                mailMessage.To.Add(Para);
                mailMessage.Subject = Asunto;
                if (banArchivo)
                    mailMessage.Attachments.Add(new System.Net.Mail.Attachment(Archivo));
                mailMessage.Body = Mensaje;
                mailMessage.IsBodyHtml = Html;
                System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient(Host);
                smtpClient.Port = Port;
                smtpClient.EnableSsl = Ssl;
                smtpClient.Credentials = new NetworkCredential(De, Contraseña);
                smtpClient.Send(mailMessage);
                mailMessage.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "EnvioCorreo.EnviarCorreo");
                return false;
            }
        }

       
        #region Correos Anteriores Carlos
        public static string GenerarHtmlPaqueteCotizado1(Solicitud datos)
        {
            string _facebook = Comun.UrlFacebook;
            string _twitter = Comun.UrlTwitter;
            string _googleplus = Comun.UrlGoogle;
            string correoItzaa = Comun.CorreoEmpresa;
            string telefono = Comun.Telefono2;
            string pass = datos.Cliente != null ? (string.IsNullOrEmpty(datos.Cliente.Password) ? "*****" : datos.Cliente.Password) : "*****";
            string Monto = string.Format("{0:c}", datos.Cotizacion != null ? datos.Cotizacion.Subtotal : 0);
            string Comentarios = datos.Cotizacion != null ? datos.Cotizacion.Comentarios : string.Empty;
            string FechaLlegada = datos.FechaLlegada.ToShortDateString() + " " + datos.HoraLlegada;
            string FechaSalida = datos.FechaSalida.ToShortDateString() + " " + datos.HoraSalida;
            string CorreoCliente = datos.Cliente != null ? datos.Cliente.CorreoElectronico : string.Empty;
            string NombreCliente = datos.Cliente != null ? datos.Cliente.Nombre : string.Empty;
            string NumPersonas = datos.NumTotalPersonas.ToString();
            string dominio = _dominio;
            string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
            string AnticipoResto = string.Format("{0:F2}", 100 - Comun.PorcentajeAnticipo);
            string numeroEstrellas = "";
            for (int j = 0; j < Convert.ToInt32(datos.CategoriaHotel.ToString()); j++)
            {
                numeroEstrellas += "*";
            }
            string html = @"<html>
            <head>
            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
            <title></title>
            <style type=""text/css"">
            div, p, a, li, td { -webkit-text-size-adjust:none; }
            .ReadMsgBody
            {width: 100%; background-color: #ffffff;}
            .ExternalClass
            {width: 100%; background-color: #ffffff;}
            body
            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
            html
            {width: 100%; }
            img 
            {border:0px; outline:none; text-decoration:none; display:block; }
            a
            {text-decoration: none;  line-height: 30px; color: #ffffff;}
            a span
            {text-decoration:none; color: #ffffff;}
            h1 
            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
            h2 
            {font-size: 18px; margin: 10px 0 10px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:none;}
            h3 
            {font-size: 12px; margin: 5px 0 5px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
            @media only screen and (max-width: 900px) 
            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
            @media only screen and (max-width: 640px)
            { body{ width:auto!important; }
            .BoxWrap { width:440px !important;}
            .RespoHideMedium { display:none !important; } 
            .RespoShowMedium { display:block !important; } 
            .RespoCenterMedium { text-align:center !important; }
            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
            }
            @media only screen and (max-width: 479px)
            {
            body{width:auto!important;}
            .BoxWrap { width:280px !important;}
            .RespoHideSmall { display:none !important; }
            .RespoCenterSmall { text-align:center !important; }
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
            }
            .Bg_Color
            {
             background-color: #fefefe;
            }
            .BgImageAltColor
            {
            background-color: #2B9EB6;
            }
            .Preheader_Color
            {
            background-color: #8CBE3F;
            }
            .Content_Color
            {
             /*@editable*/ background-color: #ffffff;
            }
            .Color01_B
            {
             /*@editable background-color: #CE0000;*/
            }
            .Color01_D
            {
             /*@editable background-color: #000000;*/
            }
            .Color02_B
            {
             /*@editable*/ background-color: #E7E7EF;
            } 
            </style>
            </head>
            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td class=""RespoHideSmall"" width=""100%"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
            <tbody>
            <tr>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td class=""BgImageAltColor"" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;color: #ffffff;font-size: 28px;margin: 10px 0 10px 0;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">AGENCIA DE VIAJES <br> <br>Tu Agencia</h2>
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">¡ESCAPA, SÓLO ELIGE EL MOMENTO!</h3>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class="""" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h1 style=""text-transform: uppercase;text-align: center;color: #ffffff;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;line-height: 40px;""><a href=""#"" style=""color: #ffffff;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;font-style: italic;"">Gracias por elegirnos<br></a></h1>
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">Registro Nacional de Turismo No. XXXXXXXXXXX</h3>
            <p style=""text-align: justify;color: #fff;font-size: 17px;margin: 5px 0 5px 0;font-weight: normal;line-height: 18px; font-style:italic;"">Somos empresa 100 % mexicana ubicada en la capital del estado de Chiapas, Tuxtla Gutiérrez.  Nuestro  objetivo principal es:  la total  satisfacción de nuestros clientes, brindándoles servicios de calidad. En unidades en óptimas condiciones;  nuestro personal, operadores y guías están altamente calificados para hacer de su viaje una experiencia inolvidable.</p>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class="""" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";

            if (!string.IsNullOrEmpty(Comentarios))
            {
                html = html + @"
                <tr>
                    <td style=""-webkit-text-size-adjust: none;"">
                        <table width=""100%"" class="""" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"">
                            <tbody>
                                <tr>
                                    <td style=""-webkit-text-size-adjust: none; line-height: 9px; text-transform: uppercase; margin-top: 5px;"">
                                    <font color=""#000000"" face=""Microsoft Sans Serif"" size=""2"">
                                        " + Comentarios + @"
                                    </font>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                     </td>
                </tr>";
            }

            html = html + @"
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;""> 
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table width=""600"" class=""BoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" border=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td class=""RespoImage_70ToOneW"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
			<img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""RespoImage_70ToOne"" alt="""" style=""width: 185px; height: 130px; display: block; border: 0px none; outline: medium none; text-decoration: none;"" border=""0"" height=""100"" width=""185""></a>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
            <tbody>
            <tr>
            <td class=""Color01_B"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Mis datos</span></a></h3>
            </td>
            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <a href=""" + dominio + @"/MiCuenta"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""391"" align=""left"" cellpadding=""30"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""331"" style=""-webkit-text-size-adjust: none;"">
            <h1 style=""text-transform: uppercase;font-size: 15px;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + NombreCliente + @"</h1>
            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Usuario: " + CorreoCliente + @"</h3>
            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Contraseña: " + pass + @"</h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""401"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td class=""RespoImage_OneToOneW"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img class=""RespoImage_OneToOne"" width=""401"" height=""401"" src="" " + dominio + @"" + datos.ImgProducto.Replace("~", "") + @" "" alt="""" border=""0"" style=""width: 401px;height: 401px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">" + datos.NombreProducto + @"</h2>
            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumDias.ToString() + @" días</h1>
            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumNoches.ToString() + @" noches</h1>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Color01_D"" bgcolor=""#2B9EB6"" cellpadding=""5"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/DetallePaquete/?id=" + datos.IDProducto + @"&id_seccion=" + datos.IDSeccion + @""" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Ver paquete</span></a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Detalles cotización del paquete</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""20"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Llegada:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaLlegada + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Salida:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaSalida + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Categoria de Hotel:</h3>
            </td> 
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align:right;text-transform:capitalize;font-size: 39px;color: #F7E82F;font-weight: 800;line-height: 0px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;margin-top: 15px;margin-bottom: 0px;"">" + numeroEstrellas + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Numero de personas:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + NumPersonas + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">HABITACIONES</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Adultos</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 4-11</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 0-4</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Camas</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Tipo de Habitación</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";

            foreach (Habitacion datosHab in datos.ListaHabitaciones)
            {
                string numAdultos = datosHab.NumAdultos.ToString();
                string numMenores4 = datosHab.NumMenores4.ToString();
                string numMenores11 = datosHab.NumMenores11.ToString();
                string numCamas = datosHab.NumCamas.ToString();
                string TipoHabitacion = datosHab.TipoHabitacion;

                html = html + @"<tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numAdultos + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores11 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores4 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numCamas + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + TipoHabitacion + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
                </tr>";
            }

            html = html + @"
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">COSTOS</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Tipo de Habitación</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Adulto</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Niños 4-11</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Niños 0-4</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo de Habitación</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";

            foreach (Habitacion datosHab in datos.ListaHabitaciones)
            {
                string TipoHabitacion = datosHab.TipoHabitacion;
                string costoAdulto = datosHab.CostoAdulto <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoAdulto);
                string costoMenor4 = datosHab.CostoMenor4 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor4);
                string costoMenor11 = datosHab.CostoMenor11 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor11);
                string subtotal = string.Format("{0:c}", datosHab.Subtotal);

                html = html + @"<tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + TipoHabitacion + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoAdulto + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoMenor11 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoMenor4 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + subtotal + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
                </tr>";
            }


            html = html + @"<tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">ITINERARIO</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Orden</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:80%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Lugar</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";

            foreach (LugarTuristico datosLugar in datos.ListaItinerario)
            {
                string Orden = datosLugar.Orden.ToString();
                string Lugar = datosLugar.Lugar;
                html = html + @"
                <tr>
                <td style=""-webkit-text-size-adjust: none; "">
                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none; width:20%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + Orden + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:80%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + Lugar + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>";
            }

            html = html + @"            
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Precio</h2>
            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">" + Monto + @"</h1>
            </td>
            </tr>";

            html = html + @"
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""30"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="" bgcolor=""#fff"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 10px;color: #000;font-weight: bold;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">La transportación que le brindamos es privada no se añade a ningún grupo y contamos con salidas diarias.</h2>
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 10px;color: #000;font-weight: bold;line-height: 18px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Para poder reservar con tu agencia, se realiza un depósito o transferencia bancaria del " + Anticipo + @"% del monto total del servicio y el otro " + AnticipoResto + @"% se liquida al llegar a Tuxtla Gutiérrez. </h2>
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 14px;color: #000;font-weight: bold;line-height: 18px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">EN BREVE UN AGENTE DE VENTAS SE COMUNICARÁ CON USTED PARA EXPLICARLE CON MAYOR DETALLE NUESTROS SERVICIOS.</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""40"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. " + telefono + @"<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Chiapas</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Yucatan</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">QuintanaRoo</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Tour</a><br><a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Transportación</a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""10""></td>
            </tr>
            <tr>
            <td style=""text-align: center;"">
            <h3 style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            <a href=""#"" style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">Términos y Condiciones de Servicio</a></h3>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""20""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @""" style=""text-decoration: none;color: #151516;-webkit-text-size-adjust: none;line-height: 30px;"">Tu Agencia</a></h3>
            </td>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
            <tbody>
            <tr>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </body>
            </html>
            ";
            return html;
        }
        public static string GenerarHtmlPaqueteVipCotizado1(Solicitud datos)
        {
            string _facebook = Comun.UrlFacebook;
            string _twitter = Comun.UrlTwitter;
            string _googleplus = Comun.UrlGoogle;
            string correoItzaa = Comun.CorreoEmpresa;
            string telefono = Comun.Telefono2;
            string pass = datos.Cliente != null ? (string.IsNullOrEmpty(datos.Cliente.Password) ? "*****" : datos.Cliente.Password) : "*****";
            string Monto = string.Format("{0:c}", datos.Cotizacion != null ? datos.Cotizacion.Subtotal : 0);
            string Comentarios = datos.Cotizacion != null ? datos.Cotizacion.Comentarios : string.Empty;
            string FechaLlegada = datos.FechaLlegada.ToShortDateString() + " " + datos.HoraLlegada;
            string FechaSalida = datos.FechaSalida.ToShortDateString() + " " + datos.HoraSalida;
            string CorreoCliente = datos.Cliente != null ? datos.Cliente.CorreoElectronico : string.Empty;
            string NombreCliente = datos.Cliente != null ? datos.Cliente.Nombre : string.Empty;
            string NumPersonas = datos.NumTotalPersonas.ToString();
            string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
            string AnticipoResto = string.Format("{0:F2}", 100 - Comun.PorcentajeAnticipo);
            string dominio = _dominio;
            string numeroEstrellas = "";
            for (int j = 0; j < Convert.ToInt32(datos.CategoriaHotel.ToString()); j++)
            {
                numeroEstrellas += "*";
            }

            string html = @"<html>
            <head>
            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
            <title></title>
            <style type=""text/css"">
            div, p, a, li, td { -webkit-text-size-adjust:none; }
            .ReadMsgBody
            {width: 100%; background-color: #ffffff;}
            .ExternalClass
            {width: 100%; background-color: #ffffff;}
            body
            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
            html
            {width: 100%; }
            img 
            {border:0px; outline:none; text-decoration:none; display:block; }
            a
            {text-decoration: none;  line-height: 30px; color: #ffffff;}
            a span
            {text-decoration:none; color: #ffffff;}
            h1 
            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
            h2 
            {font-size: 18px; margin: 10px 0 10px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:none;}
            h3 
            {font-size: 12px; margin: 5px 0 5px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
            @media only screen and (max-width: 900px) 
            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
            @media only screen and (max-width: 640px)
            { body{ width:auto!important; }
            .BoxWrap { width:440px !important;}
            .RespoHideMedium { display:none !important; } 
            .RespoShowMedium { display:block !important; } 
            .RespoCenterMedium { text-align:center !important; }
            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
            }
            @media only screen and (max-width: 479px)
            {
            body{width:auto!important;}
            .BoxWrap { width:280px !important;}
            .RespoHideSmall { display:none !important; }
            .RespoCenterSmall { text-align:center !important; }
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
            }
            .Bg_Color
            {
             background-color: #fefefe;
            }
            .BgImageAltColor
            {
            background-color: #2B9EB6;
            }
            .Preheader_Color
            {
            background-color: #8CBE3F;
            }
            .Content_Color
            {
             /*@editable*/ background-color: #ffffff;
            }
            .Color01_B
            {
             /*@editable background-color: #CE0000;*/
            }
            .Color01_D
            {
             /*@editable background-color: #000000;*/
            }
            .Color02_B
            {
             /*@editable*/ background-color: #E7E7EF;
            } 
            </style>
            </head>
            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td class=""RespoHideSmall"" width=""100%"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
            <tbody>
            <tr>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td class=""BgImageAltColor"" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;color: #ffffff;font-size: 28px;margin: 10px 0 10px 0;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">AGENCIA DE VIAJES <br> <br>Tu Agencia</h2>
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">¡ESCAPA, SÓLO ELIGE EL MOMENTO!</h3>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class="""" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h1 style=""text-transform: uppercase;text-align: center;color: #ffffff;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;line-height: 40px;""><a href=""#"" style=""color: #ffffff;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;font-style: italic;"">Gracias por elegirnos<br></a></h1>
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">Registro Nacional de Turismo No. XXXXXXXXXXX</h3>
            <p style=""text-align: justify;color: #fff;font-size: 17px;margin: 5px 0 5px 0;font-weight: normal;line-height: 18px; font-style:italic;"">Somos empresa 100 % mexicana ubicada en la capital del estado de Chiapas, Tuxtla Gutiérrez.  Nuestro  objetivo principal es:  la total  satisfacción de nuestros clientes, brindándoles servicios de calidad. En unidades en óptimas condiciones;  nuestro personal, operadores y guías están altamente calificados para hacer de su viaje una experiencia inolvidable.</p>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class="""" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";

            if (!string.IsNullOrEmpty(Comentarios))
            {
                html = html + @"
                <tr>
                    <td style=""-webkit-text-size-adjust: none;"">
                        <table width=""100%"" class="""" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"">
                            <tbody>
                                <tr>
                                    <td style=""-webkit-text-size-adjust: none; line-height: 9px; text-transform: uppercase; margin-top: 5px;"">
                                    <font color=""#000000"" face=""Microsoft Sans Serif"" size=""2"">
                                        " + Comentarios + @"
                                    </font>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                     </td>
                </tr>";
            }

            html = html + @"
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;""> 
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table width=""600"" class=""BoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" border=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td class=""RespoImage_70ToOneW"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
			<img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""RespoImage_70ToOne"" alt="""" style=""width: 185px; height: 130px; display: block; border: 0px none; outline: medium none; text-decoration: none;"" border=""0"" height=""100"" width=""185""></a>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
            <tbody>
            <tr>
            <td class=""Color01_B"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Mis datos</span></a></h3>
            </td>
            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <a href=""" + dominio + @"/MiCuenta"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""391"" align=""left"" cellpadding=""30"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""331"" style=""-webkit-text-size-adjust: none;"">
            <h1 style=""text-transform: uppercase;font-size: 15px;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + NombreCliente + @"</h1>
            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Usuario: " + CorreoCliente + @"</h3>
            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Contraseña: " + pass + @"</h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""401"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td class=""RespoImage_OneToOneW"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img class=""RespoImage_OneToOne"" width=""401"" height=""401"" src="" " + dominio + @"" + datos.ImgProducto.Replace("~", "") + @" "" alt="""" border=""0"" style=""width: 401px;height: 401px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">" + datos.NombreProducto + @"</h2>
            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumDias.ToString() + @" días</h1>
            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumNoches.ToString() + @" noches</h1>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Detalles cotización del paquete vip</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""20"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Llegada:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaLlegada + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Salida:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaSalida + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Categoria de Hotel:</h3>
            </td> 
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align:right;text-transform:capitalize;font-size: 39px;color: #F7E82F;font-weight: 800;line-height: 0px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;margin-top: 15px;margin-bottom: 0px;"">" + numeroEstrellas + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Numero de personas:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + NumPersonas + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">HABITACIONES</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Adultos</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 4-11</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 0-4</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Camas</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Tipo de Habitación</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";

            foreach (Habitacion datosHab in datos.ListaHabitaciones)
            {
                string numAdultos = datosHab.NumAdultos.ToString();
                string numMenores4 = datosHab.NumMenores4.ToString();
                string numMenores11 = datosHab.NumMenores11.ToString();
                string numCamas = datosHab.NumCamas.ToString();
                string TipoHabitacion = datosHab.TipoHabitacion;

                html = html + @"<tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numAdultos + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores11 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores4 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numCamas + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + TipoHabitacion + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
                </tr>";
            }



            html = html + @"
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">COSTOS</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Tipo de Habitación</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Adulto</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Niños 4-11</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Niños 0-4</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo de Habitación</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";

            foreach (Habitacion datosHab in datos.ListaHabitaciones)
            {
                string TipoHabitacion = datosHab.TipoHabitacion;
                string costoAdulto = datosHab.CostoAdulto <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoAdulto);
                string costoMenor4 = datosHab.CostoMenor4 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor4);
                string costoMenor11 = datosHab.CostoMenor11 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor11);
                string subtotal = string.Format("{0:c}", datosHab.Subtotal);

                html = html + @"<tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + TipoHabitacion + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoAdulto + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoMenor11 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoMenor4 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + subtotal + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
                </tr>";
            }


            html = html + @"<tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">ITINERARIO</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Orden</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:80%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Lugar</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";

            foreach (LugarTuristico datosLugar in datos.ListaItinerario)
            {
                string Orden = datosLugar.Orden.ToString();
                string Lugar = datosLugar.Lugar;
                html = html + @"
                <tr>
                <td style=""-webkit-text-size-adjust: none; "">
                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none; width:20%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + Orden + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:80%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + Lugar + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>";
            }

            html = html + @"            
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Precio</h2>
            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">" + Monto + @"</h1>
            </td>
            </tr>";

            html = html + @"
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""30"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="" bgcolor=""#fff"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 10px;color: #000;font-weight: bold;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">La transportación que le brindamos es privada no se añade a ningún grupo y contamos con salidas diarias.</h2>
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 10px;color: #000;font-weight: bold;line-height: 18px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Para poder reservar con tu agencia, se realiza un depósito o transferencia bancaria del " + Anticipo + @"% del monto total del servicio y el otro " + AnticipoResto + @"% se liquida al llegar a Tuxtla Gutiérrez. </h2>
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 14px;color: #000;font-weight: bold;line-height: 18px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">EN BREVE UN AGENTE DE VENTAS SE COMUNICARÁ CON USTED PARA EXPLICARLE CON MAYOR DETALLE NUESTROS SERVICIOS.</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""40"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. " + telefono + @"<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Chiapas</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Yucatan</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">QuintanaRoo</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Tour</a><br><a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Transportación</a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""10""></td>
            </tr>
            <tr>
            <td style=""text-align: center;"">
            <h3 style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            <a href=""#"" style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">Términos y Condiciones de Servicio</a></h3>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""20""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @""" style=""text-decoration: none;color: #151516;-webkit-text-size-adjust: none;line-height: 30px;"">Tu Agencia</a></h3>
            </td>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
            <tbody>
            <tr>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </body>
            </html>
            ";
            return html;
        }
        public static string GenerarHtmlToursCotizado1(Solicitud datos)
        {
            string _facebook = Comun.UrlFacebook;
            string _twitter = Comun.UrlTwitter;
            string _googleplus = Comun.UrlGoogle;
            string correoItzaa = Comun.CorreoEmpresa;
            string telefono = Comun.Telefono2;
            string pass = datos.Cliente != null ? (string.IsNullOrEmpty(datos.Cliente.Password) ? "*****" : datos.Cliente.Password) : "*****";
            string Monto = string.Format("{0:c}", datos.Cotizacion != null ? datos.Cotizacion.Subtotal : 0);
            string Comentarios = datos.Cotizacion != null ? datos.Cotizacion.Comentarios : string.Empty;
            string FechaLlegada = datos.FechaLlegada.ToShortDateString() + " " + datos.HoraLlegada;
            string FechaSalida = datos.FechaSalida.ToShortDateString() + " " + datos.HoraSalida;
            string CorreoCliente = datos.Cliente != null ? datos.Cliente.CorreoElectronico : string.Empty;
            string NombreCliente = datos.Cliente != null ? datos.Cliente.Nombre : string.Empty;
            string NumPersonas = datos.NumTotalPersonas.ToString();
            string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
            string AnticipoResto = string.Format("{0:F2}", 100 - Comun.PorcentajeAnticipo);
            string dominio = _dominio;
            string numeroEstrellas = "";
            for (int j = 0; j < Convert.ToInt32(datos.CategoriaHotel.ToString()); j++)
            {
                numeroEstrellas += "*";
            }

            string html = @"<html>
            <head>
            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
            <title></title>
            <style type=""text/css"">
            div, p, a, li, td { -webkit-text-size-adjust:none; }
            .ReadMsgBody
            {width: 100%; background-color: #ffffff;}
            .ExternalClass
            {width: 100%; background-color: #ffffff;}
            body
            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
            html
            {width: 100%; }
            img 
            {border:0px; outline:none; text-decoration:none; display:block; }
            a
            {text-decoration: none;  line-height: 30px; color: #ffffff;}
            a span
            {text-decoration:none; color: #ffffff;}
            h1 
            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
            h2 
            {font-size: 18px; margin: 10px 0 10px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:none;}
            h3 
            {font-size: 12px; margin: 5px 0 5px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
            @media only screen and (max-width: 900px) 
            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
            @media only screen and (max-width: 640px)
            { body{ width:auto!important; }
            .BoxWrap { width:440px !important;}
            .RespoHideMedium { display:none !important; } 
            .RespoShowMedium { display:block !important; } 
            .RespoCenterMedium { text-align:center !important; }
            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
            }
            @media only screen and (max-width: 479px)
            {
            body{width:auto!important;}
            .BoxWrap { width:280px !important;}
            .RespoHideSmall { display:none !important; }
            .RespoCenterSmall { text-align:center !important; }
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
            }
            .Bg_Color
            {
             background-color: #fefefe;
            }
            .BgImageAltColor
            {
            background-color: #2B9EB6;
            }
            .Preheader_Color
            {
            background-color: #f3f3f3;
            }
            .Content_Color
            {
             /*@editable*/ background-color: #ffffff;
            }
            .Color01_B
            {
             /*@editable background-color: #CE0000;*/
            }
            .Color01_D
            {
             /*@editable background-color: #000000;*/
            }
            .Color02_B
            {
             /*@editable*/ background-color: #E7E7EF;
            } 
            </style>
            </head>
            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td class=""RespoHideSmall"" width=""100%"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
            <tbody>
            <tr>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td class=""BgImageAltColor"" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;color: #ffffff;font-size: 18px;margin: 10px 0 10px 0;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Operadora Turistica - Viajes Itzaa</h2>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class=""Bg_Color"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h1 style=""text-transform: uppercase;text-align: center;color: #ffffff;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;line-height: 40px;""><a href=""#"" style=""color: #ffffff;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;font-style: italic;"">Gracias por elegirnos<br></a></h1>
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">Registro Nacional de Turismo No. XXXXXXXXXXX</h3>
            <p style=""text-align: justify;color: #fff;font-size: 17px;margin: 5px 0 5px 0;font-weight: normal;line-height: 18px; font-style:italic;"">Somos empresa 100 % mexicana ubicada en la capital del estado de Chiapas, Tuxtla Gutiérrez.  Nuestro  objetivo principal es:  la total  satisfacción de nuestros clientes, brindándoles servicios de calidad. En unidades en óptimas condiciones;  nuestro personal, operadores y guías están altamente calificados para hacer de su viaje una experiencia inolvidable.</p>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class=""Bg_Color"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";

            if (!string.IsNullOrEmpty(Comentarios))
            {
                html = html + @"
                <tr>
                    <td style=""-webkit-text-size-adjust: none;"">
                        <table width=""100%"" class=""Color02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"">
                            <tbody>
                                <tr>
                                    <td style=""-webkit-text-size-adjust: none; line-height: 9px; text-transform: uppercase; margin-top: 5px;"">
                                    <font color=""#000000"" face=""Microsoft Sans Serif"" size=""2"">
                                        " + Comentarios + @"
                                    </font>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                     </td>
                </tr>";
            }

            html = html + @"
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;"">
            &nbsp; 
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table width=""600"" class=""BoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" border=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td class=""RespoImage_70ToOneW"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
			<img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""RespoImage_70ToOne"" alt="""" style=""width: 185px; height: 130px; display: block; border: 0px none; outline: medium none; text-decoration: none;"" border=""0"" height=""100"" width=""185""></a>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
            <tbody>
            <tr>
            <td class=""Color01_B"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Mis datos</span></a></h3>
            </td>
            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <a href=""" + dominio + @"/MiCuenta"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""391"" align=""left"" cellpadding=""30"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""331"" style=""-webkit-text-size-adjust: none;"">
            <h1 style=""text-transform: uppercase;font-size: 15px;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + NombreCliente + @"</h1>
            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Usuario: " + CorreoCliente + @"</h3>
            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Contraseña: " + pass + @"</h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""401"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td class=""RespoImage_OneToOneW"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img class=""RespoImage_OneToOne"" width=""401"" height=""401"" src="" " + dominio + @"" + datos.ImgProducto.Replace("~", "") + @" "" alt="""" border=""0"" style=""width: 401px;height: 401px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">" + datos.NombreProducto + @"</h2>
            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumDias.ToString() + @" días</h1>
            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumNoches.ToString() + @" noches</h1>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""5"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/DetalleTour/?id=" + datos.IDProducto + @"&id_seccion=" + datos.IDSeccion + @" "" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Ver tour</span></a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Detalles cotización del tour</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""20"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Llegada:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaLlegada + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Salida:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaSalida + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Numero de personas:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + NumPersonas + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">";

            html = html + @"
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">PERSONAS</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Adultos</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 4-11</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 0-4</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Total Personas</h2>
            </td>            
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";

            foreach (Habitacion datosHab in datos.ListaHabitaciones)
            {
                string numAdultos = datosHab.NumAdultos.ToString();
                string numMenores4 = datosHab.NumMenores4.ToString();
                string numMenores11 = datosHab.NumMenores11.ToString();
                string totalPersonas = (datosHab.NumAdultos + datosHab.NumMenores11 + datosHab.NumMenores4).ToString();
                html = html + @"
                <tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numAdultos + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores11 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores4 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + totalPersonas + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
                </tr>";
            }

            html = html + @"
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">COSTOS</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Adulto</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Niños 4-11</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Niños 0-4</h2>
            </td>            
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";

            foreach (Habitacion datosHab in datos.ListaHabitaciones)
            {
                string costoAdulto = datosHab.CostoAdulto <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoAdulto);
                string costoMenor4 = datosHab.CostoMenor4 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor4);
                string costoMenor11 = datosHab.CostoMenor11 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor11);
                html = html + @"
                <tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoAdulto + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoMenor11 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoMenor4 + @"</h2>
                </td>            
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
                </tr>";
            }

            html = html + @"<tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">ITINERARIO</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Orden</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:80%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Lugar</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";

            foreach (LugarTuristico datosLugar in datos.ListaItinerario)
            {
                string Orden = datosLugar.Orden.ToString();
                string Lugar = datosLugar.Lugar;

                html = html + @"
                <tr>
                <td style=""-webkit-text-size-adjust: none;"">
                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none; width:20%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + Orden + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:80%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + Lugar + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
                </tr>";
            }

            html = html + @"<tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Precio</h2>
            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">" + Monto + @"</h1>
            </td>
            </tr>";

            html = html + @"
            
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="" bgcolor=""#fff"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 10px;color: #000;font-weight: bold;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">La transportación que le brindamos es privada no se añade a ningún grupo y contamos con salidas diarias.</h2>
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 10px;color: #000;font-weight: bold;line-height: 18px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Para poder reservar con tu agencia, se realiza un depósito o transferencia bancaria del " + Anticipo + @"% del monto total del servicio y el otro " + AnticipoResto + @"% se liquida al llegar a Tuxtla Gutiérrez. </h2>
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 14px;color: #000;font-weight: bold;line-height: 18px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">EN BREVE UN AGENTE DE VENTAS SE COMUNICARÁ CON USTED PARA EXPLICARLE CON MAYOR DETALLE NUESTROS SERVICIOS.</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""40"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td valign=""top"" class=""Color01_D"" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""Color01_D"" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. " + telefono + @"<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""Color01_D"" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Chiapas</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Yucatan</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">QuintanaRoo</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""Color01_D"" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Tour</a><br><a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Transportación</a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""10""></td>
            </tr>
            <tr>
            <td style=""text-align: center;"">
            <h3 style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            <a href=""#"" style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">Términos y Condiciones de Servicio</a></h3>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""20""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @""" style=""text-decoration: none;color: #151516;-webkit-text-size-adjust: none;line-height: 30px;"">Tu Agencia</a></h3>
            </td>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
            <tbody>
            <tr>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </body>
            </html>
            ";
            return html;
        }
        public static string GenerarHtmlHotelesCotizado1(Solicitud datos)
        {
            string _facebook = Comun.UrlFacebook;
            string _twitter = Comun.UrlTwitter;
            string _googleplus = Comun.UrlGoogle;
            string correoItzaa = Comun.CorreoEmpresa;
            string telefono = Comun.Telefono2;
            string pass = datos.Cliente != null ? (string.IsNullOrEmpty(datos.Cliente.Password) ? "*****" : datos.Cliente.Password) : "*****";
            string Monto = string.Format("{0:c}", datos.Cotizacion != null ? datos.Cotizacion.Subtotal : 0);
            string Comentarios = datos.Cotizacion != null ? datos.Cotizacion.Comentarios : string.Empty;
            string FechaLlegada = datos.FechaLlegada.ToShortDateString() + " " + datos.HoraLlegada;
            string FechaSalida = datos.FechaSalida.ToShortDateString() + " " + datos.HoraSalida;
            string CorreoCliente = datos.Cliente != null ? datos.Cliente.CorreoElectronico : string.Empty;
            string NombreCliente = datos.Cliente != null ? datos.Cliente.Nombre : string.Empty;
            string NumPersonas = datos.NumTotalPersonas.ToString();
            string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
            string AnticipoResto = string.Format("{0:F2}", 100 - Comun.PorcentajeAnticipo);
            string dominio = _dominio;
            string numeroEstrellas = "";
            for (int j = 0; j < Convert.ToInt32(datos.CategoriaHotel.ToString()); j++)
            {
                numeroEstrellas += "*";
            }
            string html = @"<html>
            <head>
            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
            <title></title>
            <style type=""text/css"">
            div, p, a, li, td { -webkit-text-size-adjust:none; }
            .ReadMsgBody
            {width: 100%; background-color: #ffffff;}
            .ExternalClass
            {width: 100%; background-color: #ffffff;}
            body
            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
            html
            {width: 100%; }
            img 
            {border:0px; outline:none; text-decoration:none; display:block; }
            a
            {text-decoration: none;  line-height: 30px; color: #ffffff;}
            a span
            {text-decoration:none; color: #ffffff;}
            h1 
            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
            h2 
            {font-size: 18px; margin: 10px 0 10px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:none;}
            h3 
            {font-size: 12px; margin: 5px 0 5px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
            @media only screen and (max-width: 900px) 
            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
            @media only screen and (max-width: 640px)
            { body{ width:auto!important; }
            .BoxWrap { width:440px !important;}
            .RespoHideMedium { display:none !important; } 
            .RespoShowMedium { display:block !important; } 
            .RespoCenterMedium { text-align:center !important; }
            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
            }
            @media only screen and (max-width: 479px)
            {
            body{width:auto!important;}
            .BoxWrap { width:280px !important;}
            .RespoHideSmall { display:none !important; }
            .RespoCenterSmall { text-align:center !important; }
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
            }
            .Bg_Color
            {
             background-color: #fefefe;
            }
            .BgImageAltColor
            {
            background-color: #2B9EB6;
            }
            .Preheader_Color
            {
            background-color: #8CBE3F;
            }
            .Content_Color
            {
             /*@editable*/ background-color: #ffffff;
            }
            .Color01_B
            {
             /*@editable background-color: #CE0000;*/
            }
            .Color01_D
            {
             /*@editable background-color: #000000;*/
            }
            .Color02_B
            {
             /*@editable*/ background-color: #E7E7EF;
            } 
            </style>
            </head>
            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td class=""RespoHideSmall"" width=""100%"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
            <tbody>
            <tr>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td class=""BgImageAltColor"" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;color: #ffffff;font-size: 28px;margin: 10px 0 10px 0;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">AGENCIA DE VIAJES <br> <br>Tu Agencia</h2>
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">¡ESCAPA, SÓLO ELIGE EL MOMENTO!</h3>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class="""" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h1 style=""text-transform: uppercase;text-align: center;color: #ffffff;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;line-height: 40px;""><a href=""#"" style=""color: #ffffff;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;font-style: italic;"">Gracias por elegirnos<br></a></h1>
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">Registro Nacional de Turismo No. XXXXXXXXXXX</h3>
            <p style=""text-align: justify;color: #fff;font-size: 17px;margin: 5px 0 5px 0;font-weight: normal;line-height: 18px; font-style:italic;"">Somos empresa 100 % mexicana ubicada en la capital del estado de Chiapas, Tuxtla Gutiérrez.  Nuestro  objetivo principal es:  la total  satisfacción de nuestros clientes, brindándoles servicios de calidad. En unidades en óptimas condiciones;  nuestro personal, operadores y guías están altamente calificados para hacer de su viaje una experiencia inolvidable.</p>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class="""" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";

            if (!string.IsNullOrEmpty(Comentarios))
            {
                html = html + @"
                <tr>
                    <td style=""-webkit-text-size-adjust: none;"">
                        <table width=""100%"" class="""" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"">
                            <tbody>
                                <tr>
                                    <td style=""-webkit-text-size-adjust: none; line-height: 9px; text-transform: uppercase; margin-top: 5px;"">
                                    <font color=""#000000"" face=""Microsoft Sans Serif"" size=""2"">
                                        " + Comentarios + @"
                                    </font>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                     </td>
                </tr>";
            }

            html = html + @"
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;""> 
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table width=""600"" class=""BoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" border=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td class=""RespoImage_70ToOneW"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
			<img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""RespoImage_70ToOne"" alt="""" style=""width: 185px; height: 130px; display: block; border: 0px none; outline: medium none; text-decoration: none;"" border=""0"" height=""100"" width=""185""></a>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
            <tbody>
            <tr>
            <td class=""Color01_B"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Mis datos</span></a></h3>
            </td>
            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <a href=""" + dominio + @"/MiCuenta"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""391"" align=""left"" cellpadding=""30"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""331"" style=""-webkit-text-size-adjust: none;"">
            <h1 style=""text-transform: uppercase;font-size: 15px;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + NombreCliente + @"</h1>
            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Usuario: " + CorreoCliente + @"</h3>
            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Contraseña: " + pass + @"</h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""401"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td class=""RespoImage_OneToOneW"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img class=""RespoImage_OneToOne"" width=""401"" height=""401"" src="" " + dominio + @"" + datos.ImgProducto.Replace("~", "") + @" "" alt="""" border=""0"" style=""width: 401px;height: 401px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">" + datos.NombreProducto + @"</h2>
            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumDias.ToString() + @" días</h1>
            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumNoches.ToString() + @" noches</h1>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Detalles cotización del hotel</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""20"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Llegada:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaLlegada + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Salida:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaSalida + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Categoria de Hotel:</h3>
            </td> 
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align:right;text-transform:capitalize;font-size: 39px;color: #F7E82F;font-weight: 800;line-height: 0px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;margin-top: 15px;margin-bottom: 0px;"">" + numeroEstrellas + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Numero de personas:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + NumPersonas + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">HABITACIONES</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Adultos</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 4-11</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 0-4</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Camas</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Tipo de Habitación</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";

            foreach (Habitacion datosHab in datos.ListaHabitaciones)
            {
                string numAdultos = datosHab.NumAdultos.ToString();
                string numMenores4 = datosHab.NumMenores4.ToString();
                string numMenores11 = datosHab.NumMenores11.ToString();
                string numCamas = datosHab.NumCamas.ToString();
                string TipoHabitacion = datosHab.TipoHabitacion;
                html = html + @"<tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numAdultos + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores11 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores4 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numCamas + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + TipoHabitacion + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
                </tr>";
            }



            html = html + @"
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">COSTOS</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Tipo de Habitación</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Adulto</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Niños 4-11</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Niños 0-4</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo de Habitación</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";

            foreach (Habitacion datosHab in datos.ListaHabitaciones)
            {
                string TipoHabitacion = datosHab.TipoHabitacion;
                string costoAdulto = datosHab.CostoAdulto <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoAdulto);
                string costoMenor4 = datosHab.CostoMenor4 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor4);
                string costoMenor11 = datosHab.CostoMenor11 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor11);
                string subtotal = string.Format("{0:c}", datosHab.Subtotal);

                html = html + @"<tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + TipoHabitacion + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoAdulto + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoMenor11 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoMenor4 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + subtotal + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
                </tr>";
            }

            html = html + @"            
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Precio</h2>
            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">" + Monto + @"</h1>
            </td>
            </tr>";

            html = html + @"
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""30"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="" bgcolor=""#fff"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 10px;color: #000;font-weight: bold;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">La transportación que le brindamos es privada no se añade a ningún grupo y contamos con salidas diarias.</h2>
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 10px;color: #000;font-weight: bold;line-height: 18px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Para poder reservar con tu agencia, se realiza un depósito o transferencia bancaria del " + Anticipo + @"% del monto total del servicio y el otro " + AnticipoResto + @"% se liquida al llegar a Tuxtla Gutiérrez. </h2>
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 14px;color: #000;font-weight: bold;line-height: 18px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">EN BREVE UN AGENTE DE VENTAS SE COMUNICARÁ CON USTED PARA EXPLICARLE CON MAYOR DETALLE NUESTROS SERVICIOS.</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""40"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. " + telefono + @"<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Chiapas</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Yucatan</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">QuintanaRoo</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Tour</a><br><a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Transportación</a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""10""></td>
            </tr>
            <tr>
            <td style=""text-align: center;"">
            <h3 style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            <a href=""#"" style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">Términos y Condiciones de Servicio</a></h3>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""20""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @""" style=""text-decoration: none;color: #151516;-webkit-text-size-adjust: none;line-height: 30px;"">Tu Agencia</a></h3>
            </td>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
            <tbody>
            <tr>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </body>
            </html>
            ";
            return html;
        }
        public static string GenerarHtmlTransportacionCotizado1(Solicitud datos)
        {
            string _facebook = Comun.UrlFacebook;
            string _twitter = Comun.UrlTwitter;
            string _googleplus = Comun.UrlGoogle;
            string correoItzaa = Comun.CorreoEmpresa;
            string telefono = Comun.Telefono2;
            string pass = datos.Cliente != null ? (string.IsNullOrEmpty(datos.Cliente.Password) ? "*****" : datos.Cliente.Password) : "*****";
            string Monto = string.Format("{0:c}", datos.Cotizacion != null ? datos.Cotizacion.Subtotal : 0);
            string Comentarios = datos.Cotizacion != null ? datos.Cotizacion.Comentarios : string.Empty;
            string FechaLlegada = datos.FechaLlegada.ToShortDateString() + " " + datos.HoraLlegada;
            string FechaSalida = datos.FechaSalida.ToShortDateString() + " " + datos.HoraSalida;
            string CorreoCliente = datos.Cliente != null ? datos.Cliente.CorreoElectronico : string.Empty;
            string NombreCliente = datos.Cliente != null ? datos.Cliente.Nombre : string.Empty;
            string NumPersonas = datos.NumTotalPersonas.ToString();
            string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
            string AnticipoResto = string.Format("{0:F2}", 100 - Comun.PorcentajeAnticipo);
            string dominio = _dominio;

            string html = @"<html>
            <head>
            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
            <title></title>
            <style type=""text/css"">
            div, p, a, li, td { -webkit-text-size-adjust:none; }
            .ReadMsgBody
            {width: 100%; background-color: #ffffff;}
            .ExternalClass
            {width: 100%; background-color: #ffffff;}
            body
            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
            html
            {width: 100%; }
            img 
            {border:0px; outline:none; text-decoration:none; display:block; }
            a
            {text-decoration: none;  line-height: 30px; color: #ffffff;}
            a span
            {text-decoration:none; color: #ffffff;}
            h1 
            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
            h2 
            {font-size: 18px; margin: 10px 0 10px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:none;}
            h3 
            {font-size: 12px; margin: 5px 0 5px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
            @media only screen and (max-width: 900px) 
            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
            @media only screen and (max-width: 640px)
            { body{ width:auto!important; }
            .BoxWrap { width:440px !important;}
            .RespoHideMedium { display:none !important; } 
            .RespoShowMedium { display:block !important; } 
            .RespoCenterMedium { text-align:center !important; }
            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
            }
            @media only screen and (max-width: 479px)
            {
            body{width:auto!important;}
            .BoxWrap { width:280px !important;}
            .RespoHideSmall { display:none !important; }
            .RespoCenterSmall { text-align:center !important; }
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
            }
            .Bg_Color
            {
             background-color: #fefefe;
            }
            .BgImageAltColor
            {
            background-color: #2B9EB6;
            }
            .Preheader_Color
            {
            background-color: #f3f3f3;
            }
            .Content_Color
            {
             /*@editable*/ background-color: #ffffff;
            }
            .Color01_B
            {
             /*@editable background-color: #CE0000;*/
            }
            .Color01_D
            {
             /*@editable background-color: #000000;*/
            }
            .Color02_B
            {
             /*@editable*/ background-color: #E7E7EF;
            } 
            </style>
            </head>
            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td class=""RespoHideSmall"" width=""100%"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
            <tbody>
            <tr>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;color: #ffffff;font-size: 18px;margin: 10px 0 10px 0;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Operadora Turistica - Viajes Itzaa</h2>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class="""" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h1 style=""text-transform: uppercase;text-align: center;color: #ffffff;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;line-height: 40px;""><a href=""#"" style=""color: #ffffff;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;font-style: italic;"">Gracias por elegirnos<br></a></h1>
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">Registro Nacional de Turismo No. XXXXXXXXXXX</h3>
            <p style=""text-align: justify;color: #fff;font-size: 17px;margin: 5px 0 5px 0;font-weight: normal;line-height: 18px; font-style:italic;"">Somos empresa 100 % mexicana ubicada en la capital del estado de Chiapas, Tuxtla Gutiérrez.  Nuestro  objetivo principal es:  la total  satisfacción de nuestros clientes, brindándoles servicios de calidad. En unidades en óptimas condiciones;  nuestro personal, operadores y guías están altamente calificados para hacer de su viaje una experiencia inolvidable.</p>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class="""" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";

            if (!string.IsNullOrEmpty(Comentarios))
            {
                html = html + @"
                <tr>
                    <td style=""-webkit-text-size-adjust: none;"">
                        <table width=""100%"" class=""Color02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"">
                            <tbody>
                                <tr>
                                    <td style=""-webkit-text-size-adjust: none; line-height: 9px; text-transform: uppercase; margin-top: 5px;"">
                                    <font color=""#000000"" face=""Microsoft Sans Serif"" size=""2"">
                                        " + Comentarios + @"
                                    </font>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                     </td>
                </tr>";
            }

            html = html + @"
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;"">
            &nbsp; 
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table width=""600"" class=""BoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" border=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td class=""RespoImage_70ToOneW"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
			<img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""RespoImage_70ToOne"" alt="""" style=""width: 185px; height: 130px; display: block; border: 0px none; outline: medium none; text-decoration: none;"" border=""0"" height=""100"" width=""185""></a>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
            <tbody>
            <tr>
            <td class=""Color01_B"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Mis datos</span></a></h3>
            </td>
            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <a href=""" + dominio + @"/MiCuenta"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""391"" align=""left"" cellpadding=""30"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""331"" style=""-webkit-text-size-adjust: none;"">
            <h1 style=""text-transform: uppercase;font-size: 15px;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + NombreCliente + @"</h1>
            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Usuario: " + CorreoCliente + @"</h3>
            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Contraseña: " + pass + @"</h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""401"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td class=""RespoImage_OneToOneW"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img class=""RespoImage_OneToOne"" width=""401"" height=""401"" src="" " + dominio + @"" + datos.ImgProducto.Replace("~", "") + @" "" alt="""" border=""0"" style=""width: 401px;height: 401px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">" + datos.NombreProducto + @"</h2>
            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumDias.ToString() + @" días</h1>
            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumNoches.ToString() + @" noches</h1>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Detalles cotización de la transportación</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""20"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Llegada:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaLlegada + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Salida:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaSalida + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Numero de personas:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + NumPersonas + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">";

            html = html + @"<tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Precio</h2>
            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">" + Monto + @"</h1>
            </td>
            </tr>";
            html = html + @"
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="" bgcolor=""#fff"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 10px;color: #000;font-weight: bold;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">La transportación que le brindamos es privada no se añade a ningún grupo y contamos con salidas diarias.</h2>
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 10px;color: #000;font-weight: bold;line-height: 18px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Para poder reservar con tu agencia, se realiza un depósito o transferencia bancaria del " + Anticipo + @"% del monto total del servicio y el otro " + AnticipoResto + @"% se liquida al llegar a Tuxtla Gutiérrez. </h2>
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 14px;color: #000;font-weight: bold;line-height: 18px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">EN BREVE UN AGENTE DE VENTAS SE COMUNICARÁ CON USTED PARA EXPLICARLE CON MAYOR DETALLE NUESTROS SERVICIOS.</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""40"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. " + telefono + @"<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Chiapas</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Yucatan</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">QuintanaRoo</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Tour</a><br><a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Transportación</a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""10""></td>
            </tr>
            <tr>
            <td style=""text-align: center;"">
            <h3 style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            <a href=""#"" style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">Términos y Condiciones de Servicio</a></h3>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""20""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""text-decoration: none;color: #151516;-webkit-text-size-adjust: none;line-height: 30px;"">Tu Agencia</a></h3>
            </td>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
            <tbody>
            <tr>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </body>
            </html>
            ";
            return html;

        }
        #endregion

        #region Html Paquetes
        public static string GenerarHtmlPaqueteCotizado(Solicitud datos)
        {
            string _facebook = Comun.UrlFacebook;
            string _twitter = Comun.UrlTwitter;
            string _googleplus = Comun.UrlGoogle;
            string correoItzaa = Comun.CorreoEmpresa;
            string telefono = Comun.Telefono2;
            string _youtube = Comun.UrlYoutube;
            string _instagram = Comun.UrlInstagram;
            string _ResgistroNacional = Comun.RegistroNacional;
            string dominio = _dominio;

            // Remainder of string starting at c.
            string pass = datos.Cliente != null ? (string.IsNullOrEmpty(datos.Cliente.Password) ? "*****" : datos.Cliente.Password) : "*****";
            //string Monto = datos.Cotizacion != null ? Convert.ToString(datos.Cotizacion.Subtotal).ToString() : Convert.ToString(0);
            string Monto = string.Format("{0:c}", datos.Cotizacion != null ? datos.Cotizacion.Subtotal : 0);
            string Comentarios = datos.Cotizacion != null ? datos.Cotizacion.Comentarios : string.Empty;
            string FechaLlegada = datos.FechaLlegada.ToShortDateString() + " " + datos.HoraLlegada;
            string FechaSalida = datos.FechaSalida.ToShortDateString() + " " + datos.HoraSalida;
            string CorreoCliente = datos.Cliente != null ? datos.Cliente.CorreoElectronico : string.Empty;
            string NombreCliente = datos.Cliente != null ? datos.Cliente.Nombre : string.Empty;
            string NumPersonas = datos.NumTotalPersonas.ToString();
            string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
            string AnticipoResto = string.Format("{0:F2}", 100 - Comun.PorcentajeAnticipo);
            string numeroEstrellas = "";
            for (int j = 0; j < Convert.ToInt32(datos.CategoriaHotel.ToString()); j++)
            {
                numeroEstrellas += "*";
            }
            string html = @"<html>
            <head>
            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
            <title></title>
            <style type=""text/css"">
            div, p, a, li, td { -webkit-text-size-adjust:none; }
            .ReadMsgBody
            {width: 100%; background-color: #ffffff;}
            .ExternalClass
            {width: 100%; background-color: #ffffff;}
            body
            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
            html
            {width: 100%; }
            img 
            {border:0px; outline:none; text-decoration:none; display:block; }
            a
            {text-decoration: none;  line-height: 30px; color: #ffffff;}
            a span
            {text-decoration:none; color: #ffffff;}
            h1 
            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
            h2 
            {font-size: 18px; margin: 10px 0 10px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:none;}
            h3 
            {font-size: 12px; margin: 5px 0 5px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
            @media only screen and (max-width: 900px) 
            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
            @media only screen and (max-width: 640px)
            { body{ width:auto!important; }
            .BoxWrap { width:440px !important;}
            .RespoHideMedium { display:none !important; } 
            .RespoShowMedium { display:block !important; } 
            .RespoCenterMedium { text-align:center !important; }
            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
            }
            @media only screen and (max-width: 479px)
            {
            body{width:auto!important;}
            .BoxWrap { width:280px !important;}
            .RespoHideSmall { display:none !important; }
            .RespoCenterSmall { text-align:center !important; }
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
            }
            .Bg_Color
            {
             background-color: #fefefe;
            }
            .BgImageAltColor
            {
            background-color: #000000;
            }
            .Preheader_Color
            {
            background-color: #f3f3f3;
            }
            .Content_Color
            {
             /*@editable*/ background-color: #ffffff;
            }
            .Color01_B
            {
             /*@editable*/ background-color: #CE0000;
            }
            .Color01_D
            {
             /*@editable*/ background-color: #000000;
            }
            .Color02_B
            {
             /*@editable*/ background-color: #fff;
            } 
            </style>
            </head>
            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/Pagina/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">¡Gracias por contactarnos!</h3>
            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">" + datos.Cliente.Nombre +@"</h3>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
          


            <tr>
            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Presentamos Cotización Solicitada</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""20"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Nombre del Paquete</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + datos.NombreProducto + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tiempo de Recorrido</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + datos.NumDias + @" Días y "+datos.NumNoches+ @" Noches</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
<tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Más información</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;""><a href=""" + dominio + @"paquetes/detallepaquete/" + datos.NombrePagina + @""" style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #ff0000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">CLICK AQUÍ</a></h2>
                
            </td>
            </tr>

            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>


            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">DATOS</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""20"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de llegada:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaLlegada + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de retorno:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaSalida + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Categoría de hotel:</h3>
            </td> 
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 39px;margin: 10px 0px 0px 0px;color: #F7E82F;font-weight: 800;line-height: 0px;text-decoration: none;font-family: Helvetica, Arial, sans-serif; margin-top: 15px;"">" + numeroEstrellas + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Número de personas:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + NumPersonas + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">NÚMERO DE PERSONAS</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>          
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Adultos</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 3-10</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 0-2</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Camas</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Tipo de Habitación</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";
            foreach (Habitacion datosHab in datos.ListaHabitaciones)
            {
                string numAdultos = datosHab.NumAdultos.ToString();
                string numMenores4 = datosHab.NumMenores4.ToString();
                string numMenores11 = datosHab.NumMenores11.ToString();
                string numCamas = datosHab.NumCamas.ToString();
                string TipoHabitacion = datosHab.TipoHabitacion;
                html = html + @"<tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numAdultos + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores11 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores4 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numCamas + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + TipoHabitacion + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
                </tr>";
            }

            html = html + @"<tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">DESGLOSE DE LA COTIZACIÓN</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>          
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Tipo de Habitación</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo por Adulto</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo por Niños 3-10</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo por Niños 0-2</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo subtotal</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";
            foreach (Habitacion datosHab in datos.ListaHabitaciones)
            {
                string TipoHabitacion = datosHab.TipoHabitacion;
                string costoAdulto = datosHab.CostoAdulto <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoAdulto);
                string costoMenor4 = datosHab.CostoMenor4 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor4);
                string costoMenor11 = datosHab.CostoMenor11 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor11);
                string subtotal = string.Format("{0:c}", datosHab.Subtotal);

                html = html + @"<tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + TipoHabitacion + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoAdulto + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoMenor11 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoMenor4 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + subtotal + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
                </tr>";
            }

            html = html + @"<tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Itinerario</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>      
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Orden</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:80%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Lugar</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";
            foreach (LugarTuristico datosLugar in datos.ListaItinerario)
            {
                string Orden = datosLugar.Orden.ToString();
                string Lugar = datosLugar.Lugar;
                html = html + @"<tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + Orden + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:78%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + Lugar + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
                </tr>";
            }
            if (datos.Cotizacion.Subtotal == 0)
            {
                html = html + @"<tr>
                                <td style=""-webkit-text-size-adjust: none;"">
                                    <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;""></h2>
                                    <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 14px;color: #000;font-weight: bold;line-height: 18px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Su cotización no pudo ser generada automáticamente. Uno de nuestros ejecutivos lo contactará para proporcionarle la información solicitada.</h2>
                                </td>
                            </tr>";
              
            }
            else
           {
               html = html + @"<tr>
                            <td style=""-webkit-text-size-adjust: none;"">
                            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Precio total normal</h2>
                            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">" + Monto + @"</h1>
                            <h2 style=""font-size: 20px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">Descuento en pago de contado: " + string.Format("{0:c}", (datos.Cotizacion.Subtotal - (datos.Cotizacion.Subtotal * Convert.ToDecimal(0.10)))) + @"</h2>
                            <h2 style=""font-size: 20px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">Pagos diferidos a 6 mensualidades de: " + string.Format("{0:c}", (datos.Cotizacion.Subtotal / 6)) + @"</h2>
                            </td>
                            </tr>";
              
           }
            html = html + @"
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>";
             if (!string.IsNullOrEmpty(Comentarios))
            {
                html = html + @"<tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">OBSERVACIONES</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
                <td style=""-webkit-text-size-adjust: none;"">
                    <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""20"" cellspacing=""0"">
                        <tbody>
                            <tr>
                                <td style=""-webkit-text-size-adjust: none;"">
                                    <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
                                        <tbody>
                                            <tr>
                                               <td style=""-webkit-text-size-adjust: none;"">
                                                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                                                    <tbody>
                                                        <tr>
                                                            <td style=""-webkit-text-size-adjust: none;"">
                                                            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + Comentarios + @"</h2>
                                                            </td>
                                                        <tr>
                                                     </tbody>
                                                </table>
                                              </td>
                                           <tr>
                                       </tbody>
                                        <tr>
                                            <td style=""-webkit-text-size-adjust: none;"">
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
            </tr>";
            }

	        html = html + @"<tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;"">
</td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="" bgcolor=""#fff"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
              <h2 style=""text - align:center; margin: 20px 0 0 0; font - size:14px; color:#000; font-weight:bold; line-height:22px; text-decoration:none; text-transform:none; font-family:Helvetica,Arial,sans-serif"">Aceptamos pagos con tarjeta de crédito vía PayPal, depósito en efectivo o transferencia bancaria. En breve, uno de nuestros asesores se contactará con usted para explicarle a mayor detalle nuestros servicios.</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""40"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. " + telefono + @"<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes Populares:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">
                ";
            foreach (Paquete datosPa in datos.ListaPaquete)
                {   
                     string NombrePagina = datosPa.NombrePagina;
                     string NombrePaquete = datosPa.NombrePaquete;

                     html = html + @" <a href=""" + dominio + @"paquetes/detallepaquete/" + NombrePagina + @""" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 20px;color: #ffffff;"">" + NombrePaquete + @"</a>
                    <br>";
                }
                 html = html + @" </h3>   
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Redes Sociales:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">
            <a href=""" + _facebook + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/642/PNG/512/facebook_icon-icons.com_59205.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _twitter + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/838/PNG/512/circle-twitter_icon-icons.com_66835.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _instagram + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://images.vexels.com/media/users/3/137380/isolated/preview/1b2ca367caa7eff8b45c09ec09b44c16-instagram-icon-logo-by-vexels.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _youtube + @""" style=""float:left;border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""http://icons.iconarchive.com/icons/igh0zt/ios7-style-metro-ui/256/MetroUI-YouTube-Alt-icon.png"" alt ="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _googleplus + @""" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/838/PNG/512/circle-google-plus_icon-icons.com_66818.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </h3>
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>            
            <tr>
            <td style="" width=""100%"" height=""10""></td>
            </tr>
            <tr>
            <td>
            <h3 style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            <a style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"" href=""" + dominio + @"/TerminosYCondiciones/"""">Términos y Condiciones de Servicio</a></h3>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""20"">
            <br/>
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;line-height: 18px; font-style:italic;"">Registro Nacional de Turismo No. " + _ResgistroNacional + @"</h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            </tr>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </body>
            </html>
            ";
            return html;
        }
        #endregion
        #region Html Paquetes Vip
        public static string GenerarHtmlPaqueteVipCotizado(Solicitud datos)
        {
            string _facebook = Comun.UrlFacebook;
            string _twitter = Comun.UrlTwitter;
            string _googleplus = Comun.UrlGoogle;
            string correoItzaa = Comun.CorreoEmpresa;
            string telefono = Comun.Telefono2;
            string _youtube = Comun.UrlYoutube;
            string _instagram = Comun.UrlInstagram;
            string _RegistroNacional = Comun.RegistroNacional;
            string pass = datos.Cliente != null ? (string.IsNullOrEmpty(datos.Cliente.Password) ? "*****" : datos.Cliente.Password) : "*****";
            string Monto = string.Format("{0:c}", datos.Cotizacion != null ? datos.Cotizacion.Subtotal : 0);
            string Comentarios = datos.Cotizacion != null ? datos.Cotizacion.Comentarios : string.Empty;
            string FechaLlegada = datos.FechaLlegada.ToShortDateString() + " " + datos.HoraLlegada;
            string FechaSalida = datos.FechaSalida.ToShortDateString() + " " + datos.HoraSalida;
            string CorreoCliente = datos.Cliente != null ? datos.Cliente.CorreoElectronico : string.Empty;
            string NombreCliente = datos.Cliente != null ? datos.Cliente.Nombre : string.Empty;
            string NumPersonas = datos.NumTotalPersonas.ToString();
            string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
            string AnticipoResto = string.Format("{0:F2}", 100 - Comun.PorcentajeAnticipo);
            string dominio = _dominio;
            string numeroEstrellas = "";
            for (int j = 0; j < Convert.ToInt32(datos.CategoriaHotel.ToString()); j++)
            {
                numeroEstrellas += "*";
            }

            string html = @"<html>
            <head>
            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
            <title></title>
            <style type=""text/css"">
            div, p, a, li, td { -webkit-text-size-adjust:none; }
            .ReadMsgBody
            {width: 100%; background-color: #ffffff;}
            .ExternalClass
            {width: 100%; background-color: #ffffff;}
            body
            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
            html
            {width: 100%; }
            img 
            {border:0px; outline:none; text-decoration:none; display:block; }
            a
            {text-decoration: none;  line-height: 30px; color: #ffffff;}
            a span
            {text-decoration:none; color: #ffffff;}
            h1 
            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
            h2 
            {font-size: 18px; margin: 10px 0 10px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:none;}
            h3 
            {font-size: 12px; margin: 5px 0 5px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
            @media only screen and (max-width: 900px) 
            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
            @media only screen and (max-width: 640px)
            { body{ width:auto!important; }
            .BoxWrap { width:440px !important;}
            .RespoHideMedium { display:none !important; } 
            .RespoShowMedium { display:block !important; } 
            .RespoCenterMedium { text-align:center !important; }
            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
            }
            @media only screen and (max-width: 479px)
            {
            body{width:auto!important;}
            .BoxWrap { width:280px !important;}
            .RespoHideSmall { display:none !important; }
            .RespoCenterSmall { text-align:center !important; }
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
            }
            .Bg_Color
            {
             background-color: #fefefe;
            }
            .BgImageAltColor
            {
            background-color: #000000;
            }
            .Preheader_Color
            {
            background-color: #f3f3f3;
            }
            .Content_Color
            {
             /*@editable*/ background-color: #ffffff;
            }
            .Color01_B
            {
             /*@editable*/ background-color: #CE0000;
            }
            .Color01_D
            {
             /*@editable*/ background-color: #000000;
            }
            .Color02_B
            {
             /*@editable*/ background-color: #fff;
            } 
            </style>
            </head>
            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/Pagina/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
<h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">¡Gracias por contactarnos!</h3>
            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">"+datos.Cliente.Nombre+@"</h3>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            


            <tr>
            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Presentamos Cotización Solicitada</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""20"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Nombre del Paquete</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + datos.NombreProducto + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tiempo de Recorrido</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + datos.NumDias + @" Días y " + datos.NumNoches + @" Noches</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>


            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">DATOS</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""20"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de llegada:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaLlegada + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de retorno:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaSalida + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Categoría de Hotel:</h3>
            </td> 
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 39px;margin: 10px 0px 0px 0px;color: #F7E82F;font-weight: 800;line-height: 0px;text-decoration: none;font-family: Helvetica, Arial, sans-serif; margin-top: 15px;"">" + numeroEstrellas + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Número de personas:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + NumPersonas + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>

            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">NÚMERO DE PERSONAS</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Adultos</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 3-10</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 0-2</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Camas</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Tipo de Habitación</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";

            foreach (Habitacion datosHab in datos.ListaHabitaciones)
            {
                string numAdultos = datosHab.NumAdultos.ToString();
                string numMenores4 = datosHab.NumMenores4.ToString();
                string numMenores11 = datosHab.NumMenores11.ToString();
                string numCamas = datosHab.NumCamas.ToString();
                string TipoHabitacion = datosHab.TipoHabitacion;
                html = html + @"<tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numAdultos + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores11 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores4 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numCamas + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + TipoHabitacion + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
                </tr>";
            }

            html = html + @"<tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">DESGLOSE DE LA COTIZACIÓN</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>          
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Tipo de Habitación</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo por Adultos</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo por Niños 3-10</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo por Niños 0-2</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo subtotal</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";
            foreach (Habitacion datosHab in datos.ListaHabitaciones)
            {
                string TipoHabitacion = datosHab.TipoHabitacion;
                string costoAdulto = datosHab.CostoAdulto <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoAdulto);
                string costoMenor4 = datosHab.CostoMenor4 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor4);
                string costoMenor11 = datosHab.CostoMenor11 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor11);
                string subtotal = string.Format("{0:c}", datosHab.Subtotal);

                html = html + @"<tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + TipoHabitacion + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoAdulto + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoMenor11 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoMenor4 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + subtotal + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
                </tr>";
            }

            html = html + @"<tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Itinerario</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>      
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Orden</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:80%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Lugar</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";
            foreach (LugarTuristico datosLugar in datos.ListaItinerario)
            {
                string Orden = datosLugar.Orden.ToString();
                string Lugar = datosLugar.Lugar;
                html = html + @"<tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + Orden + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:78%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + Lugar + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
                </tr>";
            }
            if (datos.Cotizacion.Subtotal == 0)
            {
                html = html + @"<tr>
                                <td style=""-webkit-text-size-adjust: none;"">
                                    <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;""></h2>
                                    <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 14px;color: #000;font-weight: bold;line-height: 18px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Su cotización no pudo ser generada automáticamente. Uno de nuestros ejecutivos lo contactará para proporcionarle la información solicitada.</h2>
                                </td>
                            </tr>";

            }
            else
            {
                html = html + @"<tr>
                            <td style=""-webkit-text-size-adjust: none;"">
                            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Precio total normal</h2>
                            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">" + Monto + @"</h1>
                            <h2 style=""font-size: 20px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">Descuento en pago de contado: " + string.Format("{0:c}", (datos.Cotizacion.Subtotal - (datos.Cotizacion.Subtotal * Convert.ToDecimal(0.10)))) + @"</h2>
                            <h2 style=""font-size: 20px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">Pagos diferidos a 6 mensualidades de: " + string.Format("{0:c}", (datos.Cotizacion.Subtotal / 6)) + @"</h2>
                            </td>
                            </tr>";

            }
            html = html + @"
            
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>";
            if (!string.IsNullOrEmpty(Comentarios))
            {
                html = html + @"<tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">OBSERVACIONES</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
                <td style=""-webkit-text-size-adjust: none;"">
                    <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""20"" cellspacing=""0"">
                        <tbody>
                            <tr>
                                <td style=""-webkit-text-size-adjust: none;"">
                                    <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
                                        <tbody>
                                            <tr>
                                               <td style=""-webkit-text-size-adjust: none;"">
                                                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                                                    <tbody>
                                                        <tr>
                                                            <td style=""-webkit-text-size-adjust: none;"">
                                                            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + Comentarios + @"</h2>
                                                            </td>
                                                        <tr>
                                                     </tbody>
                                                </table>
                                              </td>
                                           <tr>
                                       </tbody>
                                        <tr>
                                            <td style=""-webkit-text-size-adjust: none;"">
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
            </tr>";
            }

            html = html + @"
	        <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="" bgcolor=""#fff"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
              <h2 style=""text - align:center; margin: 20px 0 0 0; font - size:14px; color:#000; font-weight:bold; line-height:22px; text-decoration:none; text-transform:none; font-family:Helvetica,Arial,sans-serif"">Aceptamos pagos con tarjeta de crédito vía PayPal, depósito en efectivo o transferencia bancaria. En breve, uno de nuestros asesores se contactará con usted para explicarle a mayor detalle nuestros servicios.</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            </tr>
            <tr>
            <td width=""100%"" height=""60"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. " + telefono + @"<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">
             ";
            foreach (Paquete datosPa in datos.ListaPaquete)
            {
                string NombrePagina = datosPa.NombrePagina;
                string NombrePaquete = datosPa.NombrePaquete;

                html = html + @" <a href=""" + dominio + @"paquetes/detallepaquete/" + NombrePagina + @""" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 20px;color: #ffffff;"">" + NombrePaquete + @"</a>
                    <br>";
            }
            html = html + @"
            </h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">
             <a href=""" + _facebook + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/642/PNG/512/facebook_icon-icons.com_59205.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _twitter + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/838/PNG/512/circle-twitter_icon-icons.com_66835.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _instagram + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://images.vexels.com/media/users/3/137380/isolated/preview/1b2ca367caa7eff8b45c09ec09b44c16-instagram-icon-logo-by-vexels.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _youtube + @""" style=""float:left;border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""http://icons.iconarchive.com/icons/igh0zt/ios7-style-metro-ui/256/MetroUI-YouTube-Alt-icon.png"" alt ="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _googleplus + @""" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/838/PNG/512/circle-google-plus_icon-icons.com_66818.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""10""></td>
            </tr>
            <tr>
            <td>
            <h3 style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            <a style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"" href=""" + dominio + @"/TerminosYCondiciones/"""">Términos y Condiciones de Servicio</a></h3>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""20"">
            <br/>
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;line-height: 18px; font-style:italic;"">Registro Nacional de Turismo No. " + _RegistroNacional + @"</h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
           <table cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </body>
            </html>
            ";
            return html;
        }
        #endregion
        #region Html Tours
        public static string GenerarHtmlToursCotizado(Solicitud datos)
        {
            string _facebook = Comun.UrlFacebook;
            string _twitter = Comun.UrlTwitter;
            string _googleplus = Comun.UrlGoogle;
            string correoItzaa = Comun.CorreoEmpresa;
            string telefono = Comun.Telefono2;
            string _youtube = Comun.UrlYoutube;
            string _instagram = Comun.UrlInstagram;
            string _ResgistroNacional = Comun.RegistroNacional;
            string pass = datos.Cliente != null ? (string.IsNullOrEmpty(datos.Cliente.Password) ? "*****" : datos.Cliente.Password) : "*****";
            string Monto = string.Format("{0:c}", datos.Cotizacion != null ? datos.Cotizacion.Subtotal : 0);
            string Comentarios = datos.Cotizacion != null ? datos.Cotizacion.Comentarios : string.Empty;
            string FechaLlegada = datos.FechaLlegada.ToShortDateString() + " " + datos.HoraLlegada;
            string FechaSalida = datos.FechaSalida.ToShortDateString() + " " + datos.HoraSalida;
            string CorreoCliente = datos.Cliente != null ? datos.Cliente.CorreoElectronico : string.Empty;
            string NombreCliente = datos.Cliente != null ? datos.Cliente.Nombre : string.Empty;
            string NumPersonas = datos.NumTotalPersonas.ToString();
            string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
            string AnticipoResto = string.Format("{0:F2}", 100 - Comun.PorcentajeAnticipo);
            string dominio = _dominio;
            string numeroEstrellas = "";
            for (int j = 0; j < Convert.ToInt32(datos.CategoriaHotel.ToString()); j++)
            {
                numeroEstrellas += "*";
            }
            string html = @"<html>
            <head>
            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
            <title></title>
            <style type=""text/css"">
            div, p, a, li, td { -webkit-text-size-adjust:none; }
            .ReadMsgBody
            {width: 100%; background-color: #ffffff;}
            .ExternalClass
            {width: 100%; background-color: #ffffff;}
            body
            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
            html
            {width: 100%; }
            img 
            {border:0px; outline:none; text-decoration:none; display:block; }
            a
            {text-decoration: none;  line-height: 30px; color: #ffffff;}
            a span
            {text-decoration:none; color: #ffffff;}
            h1 
            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
            h2 
            {font-size: 18px; margin: 10px 0 10px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:none;}
            h3 
            {font-size: 12px; margin: 5px 0 5px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
            @media only screen and (max-width: 900px) 
            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
            @media only screen and (max-width: 640px)
            { body{ width:auto!important; }
            .BoxWrap { width:440px !important;}
            .RespoHideMedium { display:none !important; } 
            .RespoShowMedium { display:block !important; } 
            .RespoCenterMedium { text-align:center !important; }
            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
            }
            @media only screen and (max-width: 479px)
            {
            body{width:auto!important;}
            .BoxWrap { width:280px !important;}
            .RespoHideSmall { display:none !important; }
            .RespoCenterSmall { text-align:center !important; }
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
            }
            .Bg_Color
            {
             background-color: #fefefe;
            }
            .BgImageAltColor
            {
            background-color: #000000;
            }
            .Preheader_Color
            {
            background-color: #f3f3f3;
            }
            .Content_Color
            {
             /*@editable*/ background-color: #ffffff;
            }
            .Color01_B
            {
             /*@editable*/ background-color: #CE0000;
            }
            .Color01_D
            {
             /*@editable*/ background-color: #000000;
            }
            .Color02_B
            {
             /*@editable*/ background-color: #fff;
            } 
            </style>
            </head>
            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/Pagina/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">¡Gracias por contactarnos!</h3>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">" + datos.Cliente.Nombre + @"</h3>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">

  <tr>
            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Presentamos Cotización Solicitada</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""20"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Nombre del tours</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + datos.NombreProducto + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tiempo de Recorrido</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + datos.NumDias + @" Días y " + datos.NumNoches + @" Noches</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Más información</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;""><a href=""" + dominio + @"tours/detalletour/" + datos.NombrePagina + @""" style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #ff0000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">CLICK AQUÍ</a></h2>
                
            </td>
            </tr>

            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>

            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">DATOS</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""20"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de llegada:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaLlegada + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de retorno:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaSalida + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Numero de personas:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + NumPersonas + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">";
            if (datos.Cotizacion.Subtotal == 0)
            {
                html = html + @"<tr>
                                <td style=""-webkit-text-size-adjust: none;"">
                                    <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;""></h2>
                                    <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 14px;color: #000;font-weight: bold;line-height: 18px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Su cotización no pudo ser generada automáticamente. Uno de nuestros ejecutivos lo contactará para proporcionarle la información solicitada.</h2>
                                </td>
                            </tr>";

            }
            else
            {
                html = html + @"<tr>
                            <td style=""-webkit-text-size-adjust: none;"">
                            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Precio total normal</h2>
                            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">" + Monto + @"</h1>
                            </td>
                            </tr>";

            }
            html = html + @"
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>";
            if (!string.IsNullOrEmpty(Comentarios))
            {
                html = html + @"<tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">OBSERVACIONES</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
                <td style=""-webkit-text-size-adjust: none;"">
                    <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""20"" cellspacing=""0"">
                        <tbody>
                            <tr>
                                <td style=""-webkit-text-size-adjust: none;"">
                                    <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
                                        <tbody>
                                            <tr>
                                               <td style=""-webkit-text-size-adjust: none;"">
                                                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                                                    <tbody>
                                                        <tr>
                                                            <td style=""-webkit-text-size-adjust: none;"">
                                                            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + Comentarios + @"</h2>
                                                            </td>
                                                        <tr>
                                                     </tbody>
                                                </table>
                                              </td>
                                           <tr>
                                       </tbody>
                                        <tr>
                                            <td style=""-webkit-text-size-adjust: none;"">
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
            </tr>";
            }
            html = html + @"
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="" bgcolor=""#fff"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
              <h2 style=""text - align:center; margin: 20px 0 0 0; font - size:14px; color:#000; font-weight:bold; line-height:22px; text-decoration:none; text-transform:none; font-family:Helvetica,Arial,sans-serif"">Aceptamos pagos con tarjeta de crédito vía PayPal, depósito en efectivo o transferencia bancaria. En breve, uno de nuestros asesores se contactará con usted para explicarle a mayor detalle nuestros servicios.</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""40"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. " + telefono + @"<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">
            ";
            foreach (Paquete datosPa in datos.ListaPaquete)
            {
                string NombrePagina = datosPa.NombrePagina;
                string NombrePaquete = datosPa.NombrePaquete;

                html = html + @" <a href=""" + dominio + @"paquetes/detallepaquete/" + NombrePagina + @""" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 20px;color: #ffffff;"">" + NombrePaquete + @"</a>
                    <br>";
            }
            html = html + @"
            </h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">
           <a href=""" + _facebook + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/642/PNG/512/facebook_icon-icons.com_59205.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _twitter + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/838/PNG/512/circle-twitter_icon-icons.com_66835.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _instagram + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://images.vexels.com/media/users/3/137380/isolated/preview/1b2ca367caa7eff8b45c09ec09b44c16-instagram-icon-logo-by-vexels.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _youtube + @""" style=""float:left;border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""http://icons.iconarchive.com/icons/igh0zt/ios7-style-metro-ui/256/MetroUI-YouTube-Alt-icon.png"" alt ="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _googleplus + @""" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/838/PNG/512/circle-google-plus_icon-icons.com_66818.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""10""></td>
            </tr>
            <tr>
            <td>
            <h3 style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            <a style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"" href=""" + dominio + @"/TerminosYCondiciones/"""">Términos y Condiciones de Servicio</a></h3>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""20"">
            <br/>
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;line-height: 18px; font-style:italic;"">Registro Nacional de Turismo No. "+ _ResgistroNacional +@"</h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </body>
            </html>
            ";
            return html;
        }
        #endregion
        #region Html Hoteles
        public static string GenerarHtmlHotelesCotizado(Solicitud datos)
        {
            string _facebook = Comun.UrlFacebook;
            string _twitter = Comun.UrlTwitter;
            string _googleplus = Comun.UrlGoogle;
            string correoItzaa = Comun.CorreoEmpresa;
            string telefono = Comun.Telefono2;
            string _youtube = Comun.UrlYoutube;
            string _instagram = Comun.UrlInstagram;
            string pass = datos.Cliente != null ? (string.IsNullOrEmpty(datos.Cliente.Password) ? "*****" : datos.Cliente.Password) : "*****";
            string Monto = string.Format("{0:c}", datos.Cotizacion != null ? datos.Cotizacion.Subtotal : 0);
            string Comentarios = datos.Cotizacion != null ? datos.Cotizacion.Comentarios : string.Empty;
            string FechaLlegada = datos.FechaLlegada.ToShortDateString() + " " + datos.HoraLlegada;
            string FechaSalida = datos.FechaSalida.ToShortDateString() + " " + datos.HoraSalida;
            string CorreoCliente = datos.Cliente != null ? datos.Cliente.CorreoElectronico : string.Empty;
            string NombreCliente = datos.Cliente != null ? datos.Cliente.Nombre : string.Empty;
            string NumPersonas = datos.NumTotalPersonas.ToString();
            string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
            string AnticipoResto = string.Format("{0:F2}", 100 - Comun.PorcentajeAnticipo);
            string dominio = _dominio;
            string numeroEstrellas = "";
            for (int j = 0; j < Convert.ToInt32(datos.CategoriaHotel.ToString()); j++)
            {
                numeroEstrellas += "*";
            }
            string html = @"<html>
            <head>
            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
            <title></title>
            <style type=""text/css"">
            div, p, a, li, td { -webkit-text-size-adjust:none; }
            .ReadMsgBody
            {width: 100%; background-color: #ffffff;}
            .ExternalClass
            {width: 100%; background-color: #ffffff;}
            body
            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
            html
            {width: 100%; }
            img 
            {border:0px; outline:none; text-decoration:none; display:block; }
            a
            {text-decoration: none;  line-height: 30px; color: #ffffff;}
            a span
            {text-decoration:none; color: #ffffff;}
            h1 
            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
            h2 
            {font-size: 18px; margin: 10px 0 10px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:none;}
            h3 
            {font-size: 12px; margin: 5px 0 5px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
            @media only screen and (max-width: 900px) 
            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
            @media only screen and (max-width: 640px)
            { body{ width:auto!important; }
            .BoxWrap { width:440px !important;}
            .RespoHideMedium { display:none !important; } 
            .RespoShowMedium { display:block !important; } 
            .RespoCenterMedium { text-align:center !important; }
            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
            }
            @media only screen and (max-width: 479px)
            {
            body{width:auto!important;}
            .BoxWrap { width:280px !important;}
            .RespoHideSmall { display:none !important; }
            .RespoCenterSmall { text-align:center !important; }
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
            }
            .Bg_Color
            {
             background-color: #fefefe;
            }
            .BgImageAltColor
            {
            background-color: #000000;
            }
            .Preheader_Color
            {
            background-color: #f3f3f3;
            }
            .Content_Color
            {
             /*@editable*/ background-color: #ffffff;
            }
            .Color01_B
            {
             /*@editable*/ background-color: #CE0000;
            }
            .Color01_D
            {
             /*@editable*/ background-color: #000000;
            }
            .Color02_B
            {
             /*@editable*/ background-color: #fff;
            } 
            </style>
            </head>
            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">¡Gracias por su preferencia!</h3>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Color02_B"" bgcolor=""#f3f3f3"" cellpadding=""5"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;line-height: 18px; font-style:italic;"">Registro Nacional de Turismo No. XXXXXXXXXXX</h3>
            <p style=""text-align: center;color: #444;font-size: 17px;margin: 5px 0 5px 0;font-weight: normal;line-height: 18px; font-style:italic; font-family: Helvetica, Arial, sans-serif;"">Somos empresa 100 % mexicana ubicada en la capital del estado de Chiapas, Tuxtla Gutiérrez.  Nuestro  objetivo principal es:  la total  satisfacción de nuestros clientes, brindándoles servicios de calidad. En unidades en óptimas condiciones;  nuestro personal, operadores y guías están altamente calificados para hacer de su viaje una experiencia inolvidable. </p>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;"">
            &nbsp; 
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">DATOS</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""20"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de llegada:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaLlegada + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Salida:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaSalida + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Categoria de Hotel:</h3>
            </td> 
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 39px;margin: 10px 0px 0px 0px;color: #F7E82F;font-weight: 800;line-height: 0px;text-decoration: none;font-family: Helvetica, Arial, sans-serif; margin-top: 15px;"">" + numeroEstrellas + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Numero de personas:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + NumPersonas + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>

            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">NÚMERO DE PERSONAS</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Adultos</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 5-11</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 0-4</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Camas</h2>
            </td>
            <td style=""-webkit-text-size-adjust: none; width:20%"">
            <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Tipo de Habitación</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>";

            foreach (Habitacion datosHab in datos.ListaHabitaciones)
            {
                string numAdultos = datosHab.NumAdultos.ToString();
                string numMenores4 = datosHab.NumMenores4.ToString();
                string numMenores11 = datosHab.NumMenores11.ToString();
                string numCamas = datosHab.NumCamas.ToString();
                string TipoHabitacion = datosHab.TipoHabitacion;
                html = html + @"<tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numAdultos + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores11 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores4 + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numCamas + @"</h2>
                </td>
                <td style=""-webkit-text-size-adjust: none; width:18%"">
                <h2 style=""text-align: center;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + TipoHabitacion + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
                </tr>";
            }

            //if (Convert.ToSingle(datosGenerales.Rows[0]["precio"]) > 0.0)
            //{
                html = html + @"<tr>
                <td style=""-webkit-text-size-adjust: none;"">
                <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Precio</h2>
                <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">" + Monto + @"</h1>
                </td>
                </tr>";
//            }
//            else
//            {
//                html = html + @"<tr>
//                  <td style=""-webkit-text-size-adjust: none;"">
//                      <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;""></h2>
//                      <h1 style=""font-size: 22px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">En un maximo de 48 hrs. le haremos llegar la cotizaciòn</h1>   
//                  </td>
//                </tr>";
//            }

            html = html + @"
            
            
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="" bgcolor=""#fff"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 10px;color: #000;font-weight: bold;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">La transportación que le brindamos es privada no se añade a ningún grupo y contamos con salidas diarias.</h2>
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 10px;color: #000;font-weight: bold;line-height: 18px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Para poder reservar con tu agencia, se realiza un depósito o transferencia bancaria del " + Anticipo + @"% del monto total del servicio y el otro " + AnticipoResto + @"% se liquida al llegar a Tuxtla Gutiérrez. </h2>
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 14px;color: #000;font-weight: bold;line-height: 18px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">EN BREVE UN AGENTE DE VENTAS SE COMUNICARÁ CON USTED PARA EXPLICARLE CON MAYOR DETALLE NUESTROS SERVICIOS.</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""60"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. " + telefono + @"<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes Populares</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">
            ";
            foreach (Paquete datosPa in datos.ListaPaquete)
            {
                string NombrePagina = datosPa.NombrePagina;
                string NombrePaquete = datosPa.NombrePaquete;

                html = html + @" <a href=""" + dominio + @"paquetes/detallepaquete/" + NombrePagina + @""" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">" + NombrePaquete + @"</a>
                    <br>";
            }
            html = html + @"
            </h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Redes Sociales:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">
            <a href=""" + _facebook + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/642/PNG/512/facebook_icon-icons.com_59205.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _twitter + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/838/PNG/512/circle-twitter_icon-icons.com_66835.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _instagram + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://images.vexels.com/media/users/3/137380/isolated/preview/1b2ca367caa7eff8b45c09ec09b44c16-instagram-icon-logo-by-vexels.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _youtube + @""" style=""float:left;border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""http://icons.iconarchive.com/icons/igh0zt/ios7-style-metro-ui/256/MetroUI-YouTube-Alt-icon.png"" alt ="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _googleplus + @""" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/838/PNG/512/circle-google-plus_icon-icons.com_66818.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""10""></td>
            </tr>
            <tr>
            <td>
            <h3 style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            <a style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"" href=""" + dominio + @"/TerminosYCondiciones/"""">Términos y Condiciones de Servicio</a></h3>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""20""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </body>
            </html>
            ";
            return html;
        }
        #endregion
        #region Html Transportacion
        public static string GenerarHtmlTransportacionCotizado(Solicitud datos)
        {
            string _facebook = Comun.UrlFacebook;
            string _twitter = Comun.UrlTwitter;
            string _googleplus = Comun.UrlGoogle;
            string correoItzaa = Comun.CorreoEmpresa;
            string telefono = Comun.Telefono2;
            string _youtube = Comun.UrlYoutube;
            string _instagram = Comun.UrlInstagram;
            string _RegistroNacional = Comun.RegistroNacional;
            string pass = datos.Cliente != null ? (string.IsNullOrEmpty(datos.Cliente.Password) ? "*****" : datos.Cliente.Password) : "*****";
            string Monto = string.Format("{0:c}", datos.Cotizacion != null ? datos.Cotizacion.Subtotal : 0);
            string Comentarios = datos.Cotizacion != null ? datos.Cotizacion.Comentarios : string.Empty;
            string FechaLlegada = datos.FechaLlegada.ToShortDateString() + " " + datos.HoraLlegada;
            string FechaSalida = datos.FechaSalida.ToShortDateString() + " " + datos.HoraSalida;
            string CorreoCliente = datos.Cliente != null ? datos.Cliente.CorreoElectronico : string.Empty;
            string NombreCliente = datos.Cliente != null ? datos.Cliente.Nombre : string.Empty;
            string NumPersonas = datos.NumTotalPersonas.ToString();
            string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
            string AnticipoResto = string.Format("{0:F2}", 100 - Comun.PorcentajeAnticipo);
            string dominio = _dominio;
            string html = @"<html>
            <head>
            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
            <title></title>
            <style type=""text/css"">
            div, p, a, li, td { -webkit-text-size-adjust:none; }
            .ReadMsgBody
            {width: 100%; background-color: #ffffff;}
            .ExternalClass
            {width: 100%; background-color: #ffffff;}
            body
            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
            html
            {width: 100%; }
            img 
            {border:0px; outline:none; text-decoration:none; display:block; }
            a
            {text-decoration: none;  line-height: 30px; color: #ffffff;}
            a span
            {text-decoration:none; color: #ffffff;}
            h1 
            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
            h2 
            {font-size: 18px; margin: 10px 0 10px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:none;}
            h3 
            {font-size: 12px; margin: 5px 0 5px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
            @media only screen and (max-width: 900px) 
            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
            @media only screen and (max-width: 640px)
            { body{ width:auto!important; }
            .BoxWrap { width:440px !important;}
            .RespoHideMedium { display:none !important; } 
            .RespoShowMedium { display:block !important; } 
            .RespoCenterMedium { text-align:center !important; }
            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
            }
            @media only screen and (max-width: 479px)
            {
            body{width:auto!important;}
            .BoxWrap { width:280px !important;}
            .RespoHideSmall { display:none !important; }
            .RespoCenterSmall { text-align:center !important; }
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
            }
            .Bg_Color
            {
             background-color: #fefefe;
            }
            .BgImageAltColor
            {
            background-color: #000000;
            }
            .Preheader_Color
            {
            background-color: #f3f3f3;
            }
            .Content_Color
            {
             /*@editable*/ background-color: #ffffff;
            }
            .Color01_B
            {
             /*@editable*/ background-color: #CE0000;
            }
            .Color01_D
            {
             /*@editable*/ background-color: #000000;
            }
            .Color02_B
            {
             /*@editable*/ background-color: #fff;
            } 
            </style>
            </head>
            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/Pagina/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">¡Gracias por contactarnos!</h3>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">"+ datos.Cliente.Nombre + @"</h3>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">

            <table width=""100%"" class=""Color02_B"" bgcolor=""#f3f3f3"" cellpadding=""5"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;"">
            &nbsp; 
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>



            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">PRESENTAMOS COTIZACIÓN SOLICITADA</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
                <td style=""-webkit-text-size-adjust: none;"">
                    <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""20"" cellspacing=""0"">
                        <tbody>
                            <tr>
                                <td style=""-webkit-text-size-adjust: none;"">
                                    <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
                                        <tbody>
                                            <tr>
                                                <td style=""-webkit-text-size-adjust: none;"">
                                                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                                                    <tbody>
                                                        <tr>
                                                            <td style=""-webkit-text-size-adjust: none;"">
                                                            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Nombre del servicio</h3>
                                                            </td>
                                                            <td style=""-webkit-text-size-adjust: none;"">
                                                            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + datos.NombreProducto + @"</h2>
                                                             </td>
                                                        <tr>
                                                     </tbody>
                                                   </table>
                                                    </td>
                                               <tr>
                                     </tbody>
                                         <tr>
                                    <td style=""-webkit-text-size-adjust: none;"">
                                    </td>
                                    </tr>
                                    </table>
                                    <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
                                        <tbody>
                                            <tr>
                                                <td style=""-webkit-text-size-adjust: none;"">
                                                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                                                    <tbody>
                                                        <tr>
                                                            <td style=""-webkit-text-size-adjust: none;"">
                                                            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Duración de servicio</h3>
                                                            </td>
                                                            <td style=""-webkit-text-size-adjust: none;"">
                                                            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">"+ datos.NumDias +@" días y " + datos.NumNoches + @" noche</h2>
                                                             </td>
                                                        <tr>
                                                     </tbody>
                                                   </table>
                                                    </td>
                                               <tr>
                                     </tbody>
                                    <tr>
                                    <td style=""-webkit-text-size-adjust: none;"">
                                    </td>
                                    </tr>
                                    </table>
                                    <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
                                        <tbody>
                                            <tr>
                                                <td style=""-webkit-text-size-adjust: none;"">
                                                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                                                    <tbody>
                                                        <tr>
                                                            <td style=""-webkit-text-size-adjust: none;"">
                                                            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Información del servicio</h3>
                                                            </td>
                                                            <td style=""-webkit-text-size-adjust: none;"">
                                                            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;""><a href=" + dominio + @"transportacion/detalleAuto/" + datos.NombrePagina + @" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color:red;"">CLICK AQUÍ</a></h2>
                                                             </td>
                                                        <tr>
                                                     </tbody>
                                                   </table>
                                                    </td>
                                               <tr>
                                     </tbody>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
            </tr>


            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">DATOS</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""20"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de llegada:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaLlegada + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Salida:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaSalida + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Numero de personas:</h3>
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + NumPersonas + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">";
            if (datos.Cotizacion.Subtotal == 0)
            {
                html = html + @"<tr>
                                <td style=""-webkit-text-size-adjust: none;"">
                                    <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;""></h2>
                                    <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 14px;color: #000;font-weight: bold;line-height: 18px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Su cotización no pudo ser generada automáticamente. Uno de nuestros ejecutivos lo contactará para proporcionarle la información solicitada.</h2>
                                </td>
                            </tr>";
              
            }
            else
           {
               html = html + @"<tr>
                            <td style=""-webkit-text-size-adjust: none;"">
                            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Precio total normal</h2>
                            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">" + Monto + @"</h1>
                            </td>
                            </tr>";
              
           }
            html = html + @"
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            ";
            if (!string.IsNullOrEmpty(Comentarios))
            {
                html = html + @"<tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">OBSERVACIONES</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
                <td style=""-webkit-text-size-adjust: none;"">
                    <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""20"" cellspacing=""0"">
                        <tbody>
                            <tr>
                                <td style=""-webkit-text-size-adjust: none;"">
                                    <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
                                        <tbody>
                                            <tr>
                                               <td style=""-webkit-text-size-adjust: none;"">
                                                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
                                                    <tbody>
                                                        <tr>
                                                            <td style=""-webkit-text-size-adjust: none;"">
                                                            <h2 style=""text-align: right;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + Comentarios + @"</h2>
                                                            </td>
                                                        <tr>
                                                     </tbody>
                                                </table>
                                              </td>
                                           <tr>
                                       </tbody>
                                        <tr>
                                            <td style=""-webkit-text-size-adjust: none;"">
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
            </tr>";
            }

            html = html + @"
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="" bgcolor=""#fff"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""40"" style=""-webkit-text-size-adjust: none;"">
              <h2 style=""text - align:center; margin: 20px 0 0 0; font - size:14px; color:#000; font-weight:bold; line-height:22px; text-decoration:none; text-transform:none; font-family:Helvetica,Arial,sans-serif"">Aceptamos pagos con tarjeta de crédito vía PayPal, depósito en efectivo o transferencia bancaria. En breve, uno de nuestros asesores se contactará con usted para explicarle a mayor detalle nuestros servicios.</h2>
            </td>
            </tr>
            
            <tr>
            <td width=""100%"" height=""60"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            
            <tr>
            <td valign=""top"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. " + telefono + @"<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">
             ";
            foreach (Paquete datosPa in datos.ListaPaquete)
            {
                string NombrePagina = datosPa.NombrePagina;
                string NombrePaquete = datosPa.NombrePaquete;

                html = html + @" <a href=""" + dominio + @"paquetes/detallepaquete/" + NombrePagina + @""" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 20px;color: #ffffff;"">" + NombrePaquete + @"</a>
                    <br>";
            }
            html = html + @"
            </h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">
            <a href=""" + _facebook + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/642/PNG/512/facebook_icon-icons.com_59205.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _twitter + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/838/PNG/512/circle-twitter_icon-icons.com_66835.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _instagram + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://images.vexels.com/media/users/3/137380/isolated/preview/1b2ca367caa7eff8b45c09ec09b44c16-instagram-icon-logo-by-vexels.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _youtube + @""" style=""float:left;border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""http://icons.iconarchive.com/icons/igh0zt/ios7-style-metro-ui/256/MetroUI-YouTube-Alt-icon.png"" alt ="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _googleplus + @""" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/838/PNG/512/circle-google-plus_icon-icons.com_66818.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""10""></td>
            </tr>
            <tr>
            <td>
            <h3 style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            <a style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"" href=""" + dominio + @"/TerminosYCondiciones/"""">Términos y Condiciones de Servicio</a></h3>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""20"">
            <br/>
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;line-height: 18px; font-style:italic;"">Registro Nacional de Turismo No. "+_RegistroNacional+@"</h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            </td>
            <td style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </body>
            </html>
            ";
            return html;

        }
        #endregion

        public static string GenerarHtmlCancelacion(Solicitud Datos)
        {
            try
            {
                string dominio = _dominio;
                string html = "";
                string Estatus = Datos.EstatusSolicitud;
                string MotivoCancelacion = Datos.MotivoCancelacion;
                string Producto = Datos.NombreProducto;
                string Total = string.Format("{0:c}", Datos.Pago != null ? Datos.Pago.MontoTotal : 0);
                string Correo = Datos.Cliente != null ? Datos.Cliente.CorreoElectronico : string.Empty;
                string Cliente = Datos.Cliente != null ? Datos.Cliente.Nombre : string.Empty;
                string MontoPenalizacion = string.Format("{0:c}", Datos.MontoPenalizacion);
                string _facebook = Comun.UrlFacebook;
                string _twitter = Comun.UrlTwitter;
                string _googleplus = Comun.UrlGoogle;
                string correoItzaa = Comun.CorreoEmpresa;
                string telefono = Comun.Telefono2;
                string _youtube = Comun.UrlYoutube;
                string _instagram = Comun.UrlInstagram;
                string _RegistroNacional = Comun.RegistroNacional;
                html = @"<html>
            <head>
            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
            <title></title>
            <style type=""text/css"">
            div, p, a, li, td { -webkit-text-size-adjust:none; }
            .ReadMsgBody
            {width: 100%; background-color: #ffffff;}
            .ExternalClass
            {width: 100%; background-color: #ffffff;}
            body
            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
            html
            {width: 100%; }
            img 
            {border:0px; outline:none; text-decoration:none; display:block; }
            a
            {text-decoration: none;  line-height: 30px; color: #ffffff;}
            a span
            {text-decoration:none; color: #ffffff;}
            h1 
            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
            h2 
            {font-size: 18px; margin: 10px 0 10px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:none;}
            h3 
            {font-size: 12px; margin: 5px 0 5px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
            @media only screen and (max-width: 900px) 
            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
            @media only screen and (max-width: 640px)
            { body{ width:auto!important; }
            .BoxWrap { width:440px !important;}
            .RespoHideMedium { display:none !important; } 
            .RespoShowMedium { display:block !important; } 
            .RespoCenterMedium { text-align:center !important; }
            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
            }
            @media only screen and (max-width: 479px)
            {
            body{width:auto!important;}
            .BoxWrap { width:280px !important;}
            .RespoHideSmall { display:none !important; }
            .RespoCenterSmall { text-align:center !important; }
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
            }
            .Bg_Color
            {
             background-color: #fefefe;
            }
            .BgImageAltColor
            {
            background-color: #000000;
            }
            .Preheader_Color
            {
            background-color: #f3f3f3;
            }
            .Content_Color
            {
             /*@editable*/ background-color: #ffffff;
            }
            .Color01_B
            {
             /*@editable*/ background-color: #CE0000;
            }
            .Color01_D
            {
             /*@editable*/ background-color: #000000;
            }
            .Color02_B
            {
             /*@editable*/ background-color: #fff;
            } 
            </style>
            </head>
            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/Pagina/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">¡Gracias por contactarnos!</h3>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">"+ Cliente +@"</h3>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Color02_B"" bgcolor=""#f3f3f3"" cellpadding=""5"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            <tr>
            <td style="""">
            <table class=""ecxColor02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"" width=""100%"">
            <tbody>
            <tr>
            <td style="""">
            <h1 style=""text-align:center;text-transform:none;font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;line-height:40px;"">
            <a href=""#"" style=""text-transform:none;text-decoration:none;color:#151516;line-height:30px;"">Cancelación de Solicitud</a></h1>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;""> 
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
           </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Detalles</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""20"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>

           <tr>
            <td style=""width:50%"">
            <h2 style=""text-align:center;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
            Motivo</h2>
            </td>
            <td style=""width:50%"">
            <h2 style=""text-align:center;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
            " + Estatus + @"</h2>
            </td>
            </tr>

            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>

            <tr>
            <td style=""width:100%"">
            <p style=""text-align:justify;font-size:16px;color:#000;font-weight:normal;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
            " + MotivoCancelacion + @" </p>
            </td>
            </tr>

            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style="""">
            <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            Paquete o Servicio:</h3>
            </td>
            <td style="""">
            <h2 style=""text-align:right;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
            " + Producto + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style="""">
            <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            Monto del paquete o servicio</h3>
            </td>
            <td style="""">
            <h2 style=""text-align:right;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
            " + Total + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style="""">
            <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            Monto de penalización</h3>
            </td>
            <td style="""">
            <h2 style=""text-align:right;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
            " + MontoPenalizacion + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td class=""ecxColor01_B"" style="""" bgcolor=""#2B9EB6"">
            <h3 style=""text-align:center;font-size:12px;color:#fff;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            Nos ponemos a sus órdenes en el momento que desee volver a contactar nuestros servicios. Lo invitamos a visitar nuevamente nuestra página web <a href=" + dominio + @" style=""text-decoration:none;line-height:30px;color:#000;"" target=""_blank"">www.viajeporchiapas.com</a> donde encontrará novedades para su próximo viaje.</h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""30"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="" bgcolor=""#fff"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 22px;color: #070707;font-weight: bold;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif; font-style:italic;"">¡Esperamos contar con su preferencia!</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""40"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. " + telefono + @"<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes Pulares:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">
             ";
                foreach (DataRow datosCan in Datos.TablaPaquetes.Rows)
                {
                    string NombrePagina = datosCan["NombrePagina"].ToString();
                    string NombrePaquete = datosCan["NombrePaquete"].ToString();

                    html = html + @" <a href=""" + dominio + @"paquetes/detallepaquete/" + NombrePagina + @""" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 0px;color: #ffffff;"">" + NombrePaquete + @"</a>
                    <br>";
                }
                html = html + @"
            </h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Redes Sociales:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">
            <a href=""" + _facebook + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/642/PNG/512/facebook_icon-icons.com_59205.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _twitter + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/838/PNG/512/circle-twitter_icon-icons.com_66835.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _instagram + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://images.vexels.com/media/users/3/137380/isolated/preview/1b2ca367caa7eff8b45c09ec09b44c16-instagram-icon-logo-by-vexels.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _youtube + @""" style=""float:left;border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""http://icons.iconarchive.com/icons/igh0zt/ios7-style-metro-ui/256/MetroUI-YouTube-Alt-icon.png"" alt ="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _googleplus + @""" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/838/PNG/512/circle-google-plus_icon-icons.com_66818.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""10""></td>
            </tr>
            <tr>
            <td style=""text-align: center;"">
            <h3 style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            <a style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"" href=""" + dominio + @"/TerminosYCondiciones/"""">Términos y Condiciones de Servicio</a></h3>
           </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""20"">
            <br/>
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;line-height: 18px; font-style:italic;"">Registro Nacional de Turismo No. "+ _RegistroNacional +@"</h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </body>
            </html>";
                return html;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GenerarHtmlOrdenPago(Solicitud Datos)
        {
            try
            {
                string dominio = _dominio;
                string html = "";
                string linkPago = Datos.OrdenPago != null ? Datos.OrdenPago.LinkPago : string.Empty;
                string Total = string.Format("{0:c}", Datos.OrdenPago != null ? Datos.OrdenPago.Pago : 0);
                string NombreOrdenPago = Datos.OrdenPago != null ? Datos.OrdenPago.NombrePago : string.Empty;
                string Descripcion = Datos.OrdenPago != null ? Datos.OrdenPago.DescripcionPago : string.Empty;
                string Correo = Datos.Cliente != null ? Datos.Cliente.CorreoElectronico : string.Empty;
                string Cliente = Datos.Cliente != null ? Datos.Cliente.Nombre : string.Empty;
                string _facebook = Comun.UrlFacebook;
                string _twitter = Comun.UrlTwitter;
                string _googleplus = Comun.UrlGoogle;
                string correoItzaa = Comun.CorreoEmpresa;
                string telefono = Comun.Telefono2;
                string _youtube = Comun.UrlYoutube;
                string _instagram = Comun.UrlInstagram;
                string _RegistroNacional = Comun.RegistroNacional;
                html = @"
            <html><head></head><body><br><div><br>
            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
            <title></title>
            <style type=""text/css"">
            div, p, a, li, td { -webkit-text-size-adjust:none; }
            .ReadMsgBody
            {width: 100%; background-color: #ffffff;}
            .ExternalClass
            {width: 100%; background-color: #ffffff;}
            body
            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
            html
            {width: 100%; }
            img 
            {border:0px; outline:none; text-decoration:none; display:block; }
            a
            {text-decoration: none;  line-height: 30px; color: #ffffff;}
            a span
            {text-decoration:none; color: #ffffff;}
            h1 
            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
            h2 
            {font-size: 18px; margin: 10px 0 10px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:none;}
            h3 
            {font-size: 12px; margin: 5px 0 5px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
            @media only screen and (max-width: 900px) 
            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
            @media only screen and (max-width: 640px)
            { body{ width:auto!important; }
            .BoxWrap { width:440px !important;}
            .RespoHideMedium { display:none !important; } 
            .RespoShowMedium { display:block !important; } 
            .RespoCenterMedium { text-align:center !important; }
            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
            }
            @media only screen and (max-width: 479px)
            {
            body{width:auto!important;}
            .BoxWrap { width:280px !important;}
            .RespoHideSmall { display:none !important; }
            .RespoCenterSmall { text-align:center !important; }
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
            }
            .Bg_Color
            {
             background-color: #fefefe;
            }
            .BgImageAltColor
            {
            background-color: #000000;
            }
            .Preheader_Color
            {
            background-color: #f3f3f3;
            }
            .Content_Color
            {
             /*@editable*/ background-color: #ffffff;
            }
            .Color01_B
            {
             /*@editable*/ background-color: #CE0000;
            }
            .Color01_D
            {
             /*@editable*/ background-color: #000000;
            }
            .Color02_B
            {
             /*@editable*/ background-color: #fff;
            } 
            </style>
            </head>
            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/Pagina/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;"">
<h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">¡Gracias por contactarnos!</h3>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">"+ Datos.Cliente.Nombre + @"</h3>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Color02_B"" bgcolor=""#f3f3f3"" cellpadding=""5"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            <tr>
            <td style="""">
            <table class=""ecxColor02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"" width=""100%"">
            <tbody>
            <tr>
            <td style="""">
            <h1 style=""text-align:center;text-transform:none;font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;line-height:40px;"">
            <a href=""#"" style=""text-transform:none;text-decoration:none;color:#151516;line-height:30px;"">Orden de Pago Paypal</a></h1>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style="""" valign=""top"" height=""40"">&nbsp; </td>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
           </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align:center;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;text-transform:none;font-family:Helvetica, Arial, sans-serif;"">
            Detalle de la orden de pago</h2>
             </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""20"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>

           <tr>
            <td style=""width:50%"">
            <h2 style=""text-align:center;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
            Motivo</h2>
            </td>
            <td style=""width:50%"">
            <h2 style=""text-align:right;text-transform:none;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
            " + NombreOrdenPago + @"</h2>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""width:40%"">
            <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            DESCRIPCIÓN:</h3>
            </td>
            <td style=""width:100%"">
            <h2 style=""text-align:right;text-transform:none;font-size:15px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
            " + Descripcion + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"" width=""100%"" height=""2""></td>
            </tr>

            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
            <tbody>
            <tr>
            <td style=""width:100%"">
            <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            MONTO:</h3>
            </td>
            <td style=""width:100%"">
            <h2 style=""text-align:right;text-transform:none;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
            " + Total + @"</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"" width=""100%"" height=""2""></td>
            </tr>

            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""ecxColor01_D"" bgcolor=""#042761"" cellpadding=""5"" cellspacing=""0"" width=""30%"" style=""margin-left: 70%;"">
            <tbody>
            <tr>
            <td style=""width:100%"">
            <h3 style=""text-align:center;font-size:12px;color:#808185;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            <a href=""" + linkPago + @""" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><span style=""text-decoration:none;color:#ffffff;"">Pagar</span></a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
            <td class=""ecxColor01_B"" style="""" bgcolor=""#2B9EB6"">
            <h3 style=""text-align:center;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            <a href="""" style=""text-decoration:none;line-height:30px;color:#ffffff;"" target=""_blank""><span style=""text-decoration:none;color:#ffffff;"">¡Gracias por su preferencia! Agradecemos que, una vez generado el cargo, se contacte con nuestros asesores de viaje para proporcionarle la información necesaria sobre su reservación e itinerario de viaje. Quedamos a sus órdenes para cualquier duda o aclaración.</span></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""30"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="" bgcolor=""#fff"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 22px;color: #070707;font-weight: bold;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif; font-style:italic;"">¡Esperamos contar con su preferencia!</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""40"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td valign=""top"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. " + telefono + @"<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes Populares:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">
              ";
                foreach (DataRow datosOrdenP in Datos.TablaPaquetes.Rows)
                {
                    string NombrePagina = datosOrdenP["NombrePagina"].ToString();
                    string NombrePaquete = datosOrdenP["NombrePaquete"].ToString();

                    html = html + @" <a href=""" + dominio + @"paquetes/detallepaquete/" + NombrePagina + @""" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 20px;color: #ffffff;"">" + NombrePaquete + @"</a>
                    <br>";
                }
                html = html + @"
            </h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
            <tbody>
            <tr>
            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class="""" bgcolor=""#2B9EB6"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Redes Sociales:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">
             <a href=""" + _facebook + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/642/PNG/512/facebook_icon-icons.com_59205.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _twitter + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/838/PNG/512/circle-twitter_icon-icons.com_66835.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _instagram + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://images.vexels.com/media/users/3/137380/isolated/preview/1b2ca367caa7eff8b45c09ec09b44c16-instagram-icon-logo-by-vexels.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _youtube + @""" style=""float:left;border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""http://icons.iconarchive.com/icons/igh0zt/ios7-style-metro-ui/256/MetroUI-YouTube-Alt-icon.png"" alt ="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _googleplus + @""" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/838/PNG/512/circle-google-plus_icon-icons.com_66818.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""10""></td>
            </tr>
            <tr>
            <td style=""text-align: center;"">
            <h3 style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            <a style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"" href=""" + dominio + @"/TerminosYCondiciones/"""">Términos y Condiciones de Servicio</a></h3>
           </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""20"">
            <br/>
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;line-height: 18px; font-style:italic;"">Registro Nacional de Turismo No. "+ _RegistroNacional +@"</h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </body>
            </html>";
                return html;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GenerarHtmlConfirmacionCompra(Solicitud Datos)
        {
            try
            {
                string dominio = _dominio;
                string textoAuxiliar = string.Empty;
                string correoCliente = Datos.Cliente != null ? Datos.Cliente.CorreoElectronico : string.Empty;
                string Cliente = Datos.Cliente != null ? Datos.Cliente.Nombre : string.Empty;
                string nombrePaquete = Datos.NombreProducto;
                string Folio = Datos.Folio;
                string FechaLimInicial = Datos.FechaLimPagoInicial.ToShortDateString();
                string FechaLimFinal = Datos.FechaLimPagoFinal.ToShortDateString();
                string _facebook = Comun.UrlFacebook;
                string _twitter = Comun.UrlTwitter;
                string _googleplus = Comun.UrlGoogle;
                string correoItzaa = Comun.CorreoEmpresa;
                string telefono = Comun.Telefono2;
                string _youtube = Comun.UrlYoutube;
                string _instagram = Comun.UrlInstagram;
                string _RegistroNacional = Comun.RegistroNacional;
                string MontoTotal = string.Format("{0:c}", Datos.MontoPagado);
                string MontoInicial = string.Format("{0:c}", Datos.MontoInicial);
                string MotivoMontoInicial = Datos.MotivoMontoInicial;
                string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
                string AnticipoResto = string.Format("{0:F2}", 100 - Comun.PorcentajeAnticipo);
                string MontoAnticipo = string.Format("{0:c}", Datos.MontoAnticipo);
                string MontoFinal = string.Format("{0:c}", Datos.MontoFinal);
                string txtAnticipoPagado = "Cubierto por monto Inicial";
                string txtFinalPagado = "Cubierto por monto Inicial";
                string txtFechaIniPagado = "No aplica";
                string txtFechaFinPagado = "No aplica";
                if (Datos.MontoInicial > 0)
                {
                    if (Datos.MontoInicial >= Datos.MontoPagado)
                    {
                        MontoAnticipo = txtAnticipoPagado;
                        MontoFinal = txtFinalPagado;
                        FechaLimInicial = txtFechaIniPagado;
                        FechaLimFinal = txtFechaFinPagado;
                    }
                    else
                    {
                        if (Datos.MontoInicial >= Datos.MontoAnticipo)
                        {
                            decimal Diferencia = Datos.MontoInicial - Datos.MontoAnticipo;
                            MontoAnticipo = txtAnticipoPagado;
                            FechaLimInicial = txtFechaIniPagado;
                            MontoFinal = string.Format("{0:c}", Datos.MontoFinal - Diferencia);
                        }
                        else
                        {
                            MontoAnticipo = string.Format("{0:c}", Datos.MontoAnticipo - Datos.MontoInicial);
                        }
                    }
                }
                string html = @"

<html><head></head><body><br><div><br>

            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
            <title></title>
            <style type=""text/css"">
            div, p, a, li, td { -webkit-text-size-adjust:none; }
            .ReadMsgBody
            {width: 100%; background-color: #ffffff;}
            .ExternalClass
            {width: 100%; background-color: #ffffff;}
            body
            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
            html
            {width: 100%; }
            img 
            {border:0px; outline:none; text-decoration:none; display:block; }
            a
            {text-decoration: none;  line-height: 30px; color: #ffffff;}
            a span
            {text-decoration:none; color: #ffffff;}
            h1 
            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
            h2 
            {font-size: 18px; margin: 10px 0 10px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:none;}
            h3 
            {font-size: 12px; margin: 5px 0 5px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
            @media only screen and (max-width: 900px) 
            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
            @media only screen and (max-width: 640px)
            { body{ width:auto!important; }
            .BoxWrap { width:440px !important;}
            .RespoHideMedium { display:none !important; } 
            .RespoShowMedium { display:block !important; } 
            .RespoCenterMedium { text-align:center !important; }
            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
            }
            @media only screen and (max-width: 479px)
            {
            body{width:auto!important;}
            .BoxWrap { width:280px !important;}
            .RespoHideSmall { display:none !important; }
            .RespoCenterSmall { text-align:center !important; }
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
            }
            .Bg_Color
            {
             background-color: #fefefe;
            }
            .BgImageAltColor
            {
            background-color: #000000;
            }
            .Preheader_Color
            {
            background-color: #f3f3f3;
            }
            .Content_Color
            {
             /*@editable*/ background-color: #ffffff;
            }
            .Color01_B
            {
             /*@editable*/ background-color: #CE0000;
            }
            .Color01_D
            {
             /*@editable*/ background-color: #000000;
            }
            .Color02_B
            {
             /*@editable*/ background-color: #fff;
            } 
            </style>
            </head>
            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/Pagina/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">¡Gracias por contactarnos!</h3>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">" + Cliente + @"</h3>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Color02_B"" bgcolor=""#f3f3f3"" cellpadding=""5"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            <tr>
            <td style="""">
            <table class=""ecxColor02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"" width=""100%"">
            <tbody>
            <tr>
            <td style="""">
            <h1 style=""text-align:center;text-transform:none;font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;line-height:40px;"">
            <a href=""#"" style=""text-transform:none;text-decoration:none;color:#151516;line-height:30px;"">CONFIRMACIÓN DE COMPRA</a></h1>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style="""" valign=""top"" height=""40"">&nbsp; </td>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
           </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align:center;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;text-transform:none;font-family:Helvetica, Arial, sans-serif;"">
            CONFIRMACIÓN DE COMPRA</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""20"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
            <tbody>
            <tr>
              <h2 style=""text - align:center; margin: 20px 0 0 0; font - size:14px; color:#000; font-weight:bold; line-height:22px; text-decoration:none; text-transform:none; font-family:Helvetica,Arial,sans-serif"">Aceptamos pagos con tarjeta de crédito vía PayPal, depósito en efectivo o transferencia bancaria.</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"" width=""100%"" height=""2""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""ecxPreheader_Color"" bgcolor=""#2B9EB6"" cellpadding=""20"" cellspacing=""0"" width=""100%"">
            <tbody>
            <tr>
                <td style=""-webkit-text-size-adjust: none;"">
                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none;"">
                <table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none;"">
                <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
                Pago Inicial</h3>
                </td>
                <td style=""-webkit-text-size-adjust: none;"">
                <h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
                " + MontoAnticipo + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td style=""-webkit-text-size-adjust: none;"" width=""100%"" height=""2""></td>
                </tr>
                <tr>
                <td style=""-webkit-text-size-adjust: none;"">
                <table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none;"">
                <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
                Fecha Límite de Pago Inicial</h3>
                </td>
                <td style=""-webkit-text-size-adjust: none;"">
                <h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
                " + FechaLimInicial + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td style=""-webkit-text-size-adjust: none;"" width=""100%"" height=""2""></td>
                </tr>
                <tr>
                <td style=""-webkit-text-size-adjust: none;"">
                <table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none;"">
                <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
                Pago Final</h3>
                </td>
                <td style=""-webkit-text-size-adjust: none;"">
                <h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
                " + MontoFinal + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td style=""-webkit-text-size-adjust: none;"" width=""100%"" height=""2""></td>
                </tr>
                <tr>
                <td style=""-webkit-text-size-adjust: none;"">
                <table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style=""-webkit-text-size-adjust: none;"">
                <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
                Fecha Límite de Pago Final</h3>
                </td>
                <td style=""-webkit-text-size-adjust: none;"">
                <h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
                " + FechaLimFinal + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td style=""-webkit-text-size-adjust: none;"" width=""100%"" height=""2""></td>
                </tr>";
                if (!string.IsNullOrEmpty(textoAuxiliar))
                {
                    html = html + @"
                    <tr>
                    <td style="""">
                    <table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
                    <tbody>
                    <tr>
                    <td style="""">
                    <h2 style=""text-align:left;font-size:14px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
                    " + textoAuxiliar + @"</h2>
                    </td>
                    </tr>
                    </tbody>
                    </table>
                    </td>
                    </tr>";
                }
                html = html + @"
            <tr>
            <td style=""-webkit-text-size-adjust: none;"" width=""100%"" height=""2""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size:18px;color:#000;text-align:right;font-weight:normal;line-height:22px;text-decoration:none;text-transform:none;font-family:Helvetica, Arial, sans-serif;"">
            Monto Total</h2>
            <h1 style=""font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;text-align:right;line-height:40px;"">
            " + MontoTotal + @"</h1>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""60"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="" bgcolor=""#fff"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 22px;color: #070707;font-weight: bold;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif; font-style:italic;"">¡Esperamos contar con su preferencia!</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""40"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td class=""ecxColor01_D"" style="""" bgcolor=""#2B9EB6"" valign=""top"">
            <table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
            <tbody>
            <tr>
            <td style="""">
            <table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
            <tbody>
            <tr>
            <td style="""">
            <table class=""ecxColor01_D"" bgcolor=""#2B9EB6"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
            <tbody>
            <tr>
            <td style="""">
            <h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:none;font-family:Helvetica, Arial, sans-serif;"">
            Datos de contacto:</h2>
            <h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            Tel. " + telefono + @"<br>
            <a href=""#"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"">Email. " + correoItzaa + @"</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
            <tbody>
            <tr>
            <td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
            <p style=""padding-left:20px;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
            <tbody>
            <tr>
            <td style="""">
            <table class=""ecxColor01_D"" bgcolor=""#2B9EB6"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes Populares:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">
             ";
                foreach (DataRow datosCanfPago in Datos.TablaPaquetes.Rows)
                {
                    string NombrePagina = datosCanfPago["NombrePagina"].ToString();
                    string NombrePaquete = datosCanfPago["NombrePaquete"].ToString();

                    html = html + @" <a href=""" + dominio + @"paquetes/detallepaquete/" + NombrePagina + @""" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 20px;color: #ffffff;"">" + NombrePaquete + @"</a>
                    <br>";
                }
                html = html + @"
            </h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
            <tbody>
            <tr>
            <td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
            <p style=""padding-left:20px;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""ecxBoxWrap"" align=""right"" cellpadding=""0"" cellspacing=""0"" width=""184"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""ecxColor01_D"" bgcolor=""#2B9EB6"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Redes Sociales</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">
            <a href=""" + _facebook + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/642/PNG/512/facebook_icon-icons.com_59205.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _twitter + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/838/PNG/512/circle-twitter_icon-icons.com_66835.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _instagram + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://images.vexels.com/media/users/3/137380/isolated/preview/1b2ca367caa7eff8b45c09ec09b44c16-instagram-icon-logo-by-vexels.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _youtube + @""" style=""float:left;border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""http://icons.iconarchive.com/icons/igh0zt/ios7-style-metro-ui/256/MetroUI-YouTube-Alt-icon.png"" alt ="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _googleplus + @""" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/838/PNG/512/circle-google-plus_icon-icons.com_66818.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""10""></td>
            </tr>
            <tr>
            <td style=""text-align: center;"">
            <h3 style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            <a style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"" href=""" + dominio + @"/TerminosYCondiciones/"""">Términos y Condiciones de Servicio</a></h3>
           </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""20"">
            <br/>
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;line-height: 18px; font-style:italic;"">Registro Nacional de Turismo No. "+ _RegistroNacional + @"</h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </body>
            </html>";
                return html;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GenerarHtmlConfirmacionPago(Solicitud Datos)
        {
            try
            {
                string dominio = _dominio;
                string correoCliente = Datos.Cliente != null ? Datos.Cliente.CorreoElectronico : string.Empty;
                string Cliente = Datos.Cliente != null ? Datos.Cliente.Nombre : string.Empty;
                string fechaPago = Datos.Pago != null ? Datos.Pago.FechaPago.ToShortDateString() : string.Empty;
                string monto = string.Format("{0:c}", Datos.Pago != null ? Datos.Pago.MontoPagado : 0);
                string nombrePaquete = Datos.NombreProducto;

                string _facebook = Comun.UrlFacebook;
                string _twitter = Comun.UrlTwitter;
                string _googleplus = Comun.UrlGoogle;
                string correoItzaa = Comun.CorreoEmpresa;
                string telefono = Comun.Telefono2;
                string _youtube = Comun.UrlYoutube;
                string _instagram = Comun.UrlInstagram;
                string _RegistroNacional = Comun.RegistroNacional;

                string html = @"
                <html>
                <head>
               <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
            <title></title>
            <style type=""text/css"">
            div, p, a, li, td { -webkit-text-size-adjust:none; }
            .ReadMsgBody
            {width: 100%; background-color: #ffffff;}
            .ExternalClass
            {width: 100%; background-color: #ffffff;}
            body
            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
            html
            {width: 100%; }
            img 
            {border:0px; outline:none; text-decoration:none; display:block; }
            a
            {text-decoration: none;  line-height: 30px; color: #ffffff;}
            a span
            {text-decoration:none; color: #ffffff;}
            h1 
            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
            h2 
            {font-size: 18px; margin: 10px 0 10px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:none;}
            h3 
            {font-size: 12px; margin: 5px 0 5px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
            @media only screen and (max-width: 900px) 
            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
            @media only screen and (max-width: 640px)
            { body{ width:auto!important; }
            .BoxWrap { width:440px !important;}
            .RespoHideMedium { display:none !important; } 
            .RespoShowMedium { display:block !important; } 
            .RespoCenterMedium { text-align:center !important; }
            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
            }
            @media only screen and (max-width: 479px)
            {
            body{width:auto!important;}
            .BoxWrap { width:280px !important;}
            .RespoHideSmall { display:none !important; }
            .RespoCenterSmall { text-align:center !important; }
            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
            }
            .Bg_Color
            {
             background-color: #fefefe;
            }
            .BgImageAltColor
            {
            background-color: #000000;
            }
            .Preheader_Color
            {
            background-color: #f3f3f3;
            }
            .Content_Color
            {
             /*@editable*/ background-color: #ffffff;
            }
            .Color01_B
            {
             /*@editable*/ background-color: #CE0000;
            }
            .Color01_D
            {
             /*@editable*/ background-color: #000000;
            }
            .Color02_B
            {
             /*@editable*/ background-color: #fff;
            } 
            </style>
            </head>
            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/Pagina/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;"">
             <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">¡Gracias por contactarnos!</h3>
            </td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px; font-style:italic;"">" + Cliente + @"</h3>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class="""" bgcolor=""#2B9EB6"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class=""Color02_B"" bgcolor=""#f3f3f3"" cellpadding=""5"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""1"" class="""" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style="""">
            <table class=""ecxColor02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"" width=""100%"">
            <tbody>
            <tr>
            <td style="""">
                <h1 style=""text-align:center;text-transform:none;font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;line-height:40px;"">
                <a href=""#"" style=""text-transform:none;text-decoration:none;color:#151516;line-height:30px;"">Agradecemos la realización de su pago.</a></h1>
                 </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style="""" valign=""top"" height=""40"">&nbsp; </td>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
           </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="""" bgcolor=""#2B9EB6"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
                <h2 style=""text-align:center;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;text-transform:none;font-family:Helvetica, Arial, sans-serif;"">
                Detalles de la compra</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td style="""">
                <table class=""ecxPreheader_Color"" bgcolor=""#2B9EB6"" cellpadding=""20"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
                Paquete o Servicio:</h3>
                </td>
                <td style="""">
                <h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
                " + nombrePaquete + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td style="""" width=""100%"" height=""2""></td>
                </tr>
                <tr>
                <td style="""">
                <table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
                Fecha de aprobación del pago:</h3>
                </td>
                <td style="""">
                <h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
                " + fechaPago + @"</h2>
                </td>
                </tr>
                </tbody>
                </table>
                </td>
                </tr>
                <tr>
                <td style="""" width=""100%"" height=""2""></td>
                </tr>
                <tr>
                <td style="""">
                <table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
                <tbody>
                <tr>
                <td style="""">
                <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
                Monto del pago:</h3>
                </td>
                <td style="""">
                <h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
                " + monto + @"</h2>
                </td>
            </tr>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" class="" bgcolor=""#fff"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 22px;color: #070707;font-weight: bold;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif; font-style:italic;"">¡Esperamos contar con su preferencia!</h2>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td width=""100%"" height=""40"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td class=""ecxColor01_D"" style="""" bgcolor=""#2B9EB6"" valign=""top"">
            <table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
            <tbody>
            <tr>
            <td style="""">
            <table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
            <tbody>
            <tr>
            <td style="""">
            <table class=""ecxColor01_D"" bgcolor=""#2B9EB6"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
            <tbody>
            <tr>
            <td style="""">
            <h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:none;font-family:Helvetica, Arial, sans-serif;"">
            Datos de contacto:</h2>
            <h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            Tel. " + telefono + @"<br>
            <a href=""#"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"">Email. " + correoItzaa + @"</a></h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
            <tbody>
            <tr>
            <td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
            <p style=""padding-left:20px;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
            <tbody>
            <tr>
            <td style="""">
            <table class=""ecxColor01_D"" bgcolor=""#2B9EB6"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes Populares:</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">
            ";
                foreach (DataRow datosCanfirPago in Datos.TablaPaquetes.Rows)
                {
                    string NombrePagina = datosCanfirPago["NombrePagina"].ToString();
                    string NombrePaquete = datosCanfirPago["NombrePaquete"].ToString();

                    html = html + @" <a href=""" + dominio + @"paquetes/detallepaquete/" + NombrePagina + @""" style=""-webkit-text-size-adjust: none;text-decoration: none;line-height: 20px;color: #ffffff;"">" + NombrePaquete + @"</a>
                    <br>";
                }
                html = html + @"
            </h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
            <tbody>
            <tr>
            <td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
            <p style=""padding-left:20px;"">&nbsp;</p>
            </td>
            </tr>
            </tbody>
            </table>
            <table class=""ecxBoxWrap"" align=""right"" cellpadding=""0"" cellspacing=""0"" width=""184"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table class=""ecxColor01_D"" bgcolor=""#2B9EB6"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Redes Sociales</h2>
            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">
             <a href=""" + _facebook + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/642/PNG/512/facebook_icon-icons.com_59205.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _twitter + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/838/PNG/512/circle-twitter_icon-icons.com_66835.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _instagram + @""" style="" float: left; border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://images.vexels.com/media/users/3/137380/isolated/preview/1b2ca367caa7eff8b45c09ec09b44c16-instagram-icon-logo-by-vexels.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _youtube + @""" style=""float:left;border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""http://icons.iconarchive.com/icons/igh0zt/ios7-style-metro-ui/256/MetroUI-YouTube-Alt-icon.png"" alt ="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            <a href=""" + _googleplus + @""" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;line-height: 30px;color: #ffffff;"">
            <img width=""35"" height=""35"" src=""https://icon-icons.com/icons2/838/PNG/512/circle-google-plus_icon-icons.com_66818.png"" alt="""" border=""0"" style=""width: 35px;height: 35px;max-width: 35px;max-height: 35px;display: block;border: 0px;outline: none;text-decoration: none;"">
            </a>
            </h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""10""></td>
            </tr>
            <tr>
            <td style=""text-align: center;"">
            <h3 style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
            <a style=""text-align:center;color:#fff;font-size:18px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"" href=""" + dominio + @"/TerminosYCondiciones/"""">Términos y Condiciones de Servicio</a></h3>
           </td>
            </tr>
            <tr>
            <td style="" width=""100%"" height=""20"">
            <br/>
            <h3 style=""text-align: center;color: #8CBE3F;font-size: 22px;margin: 5px 0 5px 0;font-weight: normal;line-height: 18px; font-style:italic;"">Registro Nacional de Turismo No. " + _RegistroNacional + @"</h3>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
            <tbody>
            <tr>
            <td style=""-webkit-text-size-adjust: none;"">
            <table cellpadding=""0"" cellspacing=""0"" align=""center"">
            <tbody>
            <tr>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            <td width=""50"" align=""center"" style=""-webkit-text-size-adjust: none;"">
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            <tr>
            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
            </tr>
            </tbody>
            </table>
            </td>
            </tr>
            </tbody>
            </table>
            </body>
            </html>";

                return html;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

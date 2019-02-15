using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Negocio;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop.ClasesAux
{
    class Class1
    {
        public void GenerarCorreo(Solicitud datos)
        {
            foreach (Habitacion datosHab in datos.ListaHabitaciones)
            {
                string numAdultos = datosHab.NumAdultos.ToString();
                string numMenores4 = datosHab.NumMenores4.ToString();
                string numMenores11 = datosHab.NumMenores11.ToString();
                string numCamas = datosHab.NumCamas.ToString();
                string TipoHabitacion = datosHab.TipoHabitacion;
            }

            foreach (Habitacion datosHab in datos.ListaHabitaciones)
            {
                string TipoHabitacion = datosHab.TipoHabitacion;
                string costoAdulto = datosHab.CostoAdulto <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoAdulto);
                string costoMenor4 = datosHab.CostoMenor4 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor4);
                string costoMenor11 = datosHab.CostoMenor11 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor11);
                string subtotal = string.Format("{0:c}", datosHab.Subtotal);
            }
            foreach (LugarTuristico datosLugar in datos.ListaItinerario)
            {
                string Orden = datosLugar.Orden.ToString();
                string Lugar = datosLugar.Lugar;
            }
        }
    }
}

//        static string _dominio = Comun.Dominio;        

//        public static string GenerarHtmlCancelacion(Solicitud Datos)
//        {
//            try
//            {
//                string dominio = _dominio;
//                string html = "";
//                string Estatus = Datos.EstatusSolicitud;
//                string MotivoCancelacion = Datos.MotivoCancelacion;
//                string Producto = Datos.NombreProducto;
//                string Total = string.Format("{0:c}", Datos.Pago != null ? Datos.Pago.MontoTotal : 0);
//                string Correo = Datos.Cliente != null ? Datos.Cliente.CorreoElectronico : string.Empty;
//                string Cliente = Datos.Cliente != null ? Datos.Cliente.Nombre : string.Empty;
//                string MontoPenalizacion = string.Format("{0:c}", Datos.MontoPenalizacion);
//                string _facebook = Comun.UrlFacebook;
//                string _twitter = Comun.UrlTwitter;
//                string _googleplus = Comun.UrlGoogle;
//                string correoItzaa = Comun.CorreoEmpresa;
//                string telefono = Comun.Telefono;
//                html = @"<html><head></head><body><br><div><br>
//<title></title>
//
//<table class=""ecxBg_Color"" align=""center"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td class=""ecxPreheader_Color"" style="""" bgcolor=""#f3f3f3"" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""" align=""center"" width=""191""><a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" style=""width:191px;height:50px;max-width:191px;max-height:50px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""191"" height=""50"">
//</a></td>
//<td class=""ecxRespoHideSmall"" style="""" width=""100%""></td>
//</tr>
//</tbody>
//</table>
//</td>
//<td class=""ecxRespoHideSmall"" style="""" width=""150"">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table align=""right"" cellpadding=""0"" cellspacing=""0"">
//<tbody>
//<tr>
//<td style="""" align=""right"" width=""50""><a href=""" + _facebook + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//<td style="""" align=""right"" width=""50""><a href=""" + _twitter + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//<td style="""" align=""right"" width=""50""><a href=""" + _googleplus + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" height=""20""></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td class=""ecxBgImageAltColor"" style="""" bgcolor=""#3A5490"">
//<table style=""clear:both;"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table align=""center"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h2 style=""text-align:center;color:#ffffff;font-size:18px;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Operadora Turistica - ViajesItzaa</h2>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td class=""ecxBg_Color"" style="""" bgcolor=""#8CBE3F"" width=""100%"" height=""1"">
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""10""></td>
//</tr>
//<tr>
//<td style="""">
//<h1 style=""text-transform:uppercase;text-align:center;color:#ffffff;font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;line-height:40px;"">
//<a href=""#"" style=""color:#ffffff;text-decoration:none;text-transform:capitalize;line-height:30px; font-style: italic;"">Gracias por elegirnos<br>
//</a></h1>
//<h3 style=""text-align:center;color:#c7c7c7;font-size:18px;font-weight:bold;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//La mejor experiencia para su viaje</h3>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td class=""ecxBg_Color"" style="""" bgcolor=""#8CBE3F"" width=""100%"" height=""1"">
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxColor02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h1 style=""text-align:center;text-transform:uppercase;font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;line-height:40px;"">
//<a href=""#"" style=""text-transform:uppercase;text-decoration:none;color:#151516;line-height:30px;"">Cancelación de Solicitud</a></h1>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>.
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" valign=""top"" height=""40"">&nbsp; </td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxContent_Color"" bgcolor=""#ffffff"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//
//<td style="""">
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//<tbody>
//<tr>
//<td class=""ecxRespoImage_70ToOneW"" style=""""><a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""ecxRespoImage_70ToOne"" alt="""" style=""width:185px;height:130px;display:block;border:0px none;text-decoration:none;"" border=""0"" width=""185"" height=""100""></a>
//</td>
//</tr>
//<tr>
//<td style="""">
//<table cellpadding=""7"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td class=""ecxColor01_B"" style="""" bgcolor=""#8CBE3F"">
//<h3 style=""text-align:center;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href=""" + dominio + @"/MiCuenta"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><span style=""text-decoration:none;color:#ffffff;"">Mis datos</span></a></h3>
//</td>
//<td class=""ecxColor01_D"" style="""" align=""center"" bgcolor=""#3A5490"" width=""50"">
//<a href=""" + dominio + @"/MiCuenta"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" style=""width:32px;height:32px;max-width:32px;max-height:32px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""32"" height=""32"">
//</a></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""30"" cellspacing=""0"" width=""391"">
//<tbody>
//<tr>
//<td style="""" width=""331"">
//<h1 style=""text-transform:uppercase;font-size:15px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;text-align:left;line-height:40px;"">
//" + Cliente + @"</h1>
//<h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Usuario: "+ Correo + @"</h3>
//<h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Contraseña: *****</h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//
//<tr>
//<td style="""" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxPreheader_Color"" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h2 style=""text-align:center;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Detalles</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxPreheader_Color"" bgcolor=""#8CBE3F"" cellpadding=""20"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//
//<tr>
//<td style="""">
//<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style=""width:50%"">
//<h2 style=""text-align:center;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//Motivo</h2>
//</td>
//<td style=""width:50%"">
//<h2 style=""text-align:center;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//" + Estatus + @"</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style=""width:100%"">
//<p style=""text-align:justify;font-size:16px;color:#000;font-weight:normal;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//" + MotivoCancelacion + @" </p>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//
//<tr>
//<td style="""">
//<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Paquete o Servicio:</h3>
//</td>
//<td style="""">
//<h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//" + Producto + @"</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Monto del paquete o servicio</h3>
//</td>
//<td style="""">
//<h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//" + Total + @"</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//
//<tr>
//<td style="""">
//<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Monto de penalización</h3>
//</td>
//<td style="""">
//<h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//" + MontoPenalizacion + @"</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//
//<tr>
//<td style="""">
//<table cellpadding=""7"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td class=""ecxColor01_B"" style="""" bgcolor=""#3A5490"">
//<h3 style=""text-align:center;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href=""https://"" style=""text-decoration:none;line-height:30px;color:#ffffff;"" target=""_blank""><span style=""text-decoration:none;color:#ffffff;"">Nos ponemos a sus &oacuterdenes en el momento que desee volver a contar con alguno de nuestros servicios. Recuerde visitar www.viajesitzaa.com y encontrar novedades de viaje.</span></a></h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//
//
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""60""></td>
//</tr>
//<tr>
//<td class=""ecxColor01_D"" style="""" bgcolor=""#3A5490"" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxColor01_D"" bgcolor=""#3A5490"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="">
//<h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
//<h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. " + telefono + @"<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
//<tbody>
//<tr>
//<td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
//<p style=""padding-left:20px;"">&nbsp;</p>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxColor01_D"" bgcolor=""#3A5490"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style=""-webkit-text-size-adjust: none;"">
//<h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
//<h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Chiapas</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Yucatan</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">QuintanaRoo</a></h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
//<tbody>
//<tr>
//<td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
//<p style=""padding-left:20px;"">&nbsp;</p>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxBoxWrap"" align=""right"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxColor01_D"" bgcolor=""#3A5490"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style=""-webkit-text-size-adjust: none;"">
//<h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
//<h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Tour</a><br><a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Transportación</a>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td class=""ecxPreheader_Color"" style="""" bgcolor=""#f3f3f3"" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href=""" + dominio + @""" style=""text-decoration:none;color:#151516;text-transform:capitalize;line-height:30px;"">Operadora Turística Itzaa</a></h3>
//</td>
//<td class=""ecxRespoHideSmall"" style="""" width=""150"">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table align=""right"" cellpadding=""0"" cellspacing=""0"">
//<tbody>
//<tr>
//<td style="""" align=""right"" width=""50""><a href=""" + _facebook + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//<td style="""" align=""right"" width=""50""><a href=""" + _twitter + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//<td style="""" align=""right"" width=""50""><a href=""" + _googleplus + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" height=""20""></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table></div></body></html>";
//                return html;
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }

//        public static string GenerarHtmlOrdenPago(Solicitud Datos)
//        {
//            try
//            {
//                string dominio = _dominio;
//                string html = "";
//                string linkPago = Datos.OrdenPago != null ? Datos.OrdenPago.LinkPago : string.Empty;
//                string Total = string.Format("{0:c}", Datos.OrdenPago != null ? Datos.OrdenPago.Pago : 0);
//                string NombreOrdenPago = Datos.OrdenPago != null ? Datos.OrdenPago.NombrePago : string.Empty;
//                string Descripcion = Datos.OrdenPago != null ? Datos.OrdenPago.DescripcionPago : string.Empty;
//                string Correo = Datos.Cliente != null ? Datos.Cliente.CorreoElectronico : string.Empty;
//                string Cliente = Datos.Cliente != null ? Datos.Cliente.Nombre : string.Empty;
//                string _facebook = Comun.UrlFacebook;
//                string _twitter = Comun.UrlTwitter;
//                string _googleplus = Comun.UrlGoogle;
//                string correoItzaa = Comun.CorreoEmpresa;
//                string telefono = Comun.Telefono;
//                html = @"
//<html><head></head><body><br><div><br><title></title>
//<style></style>
//<table class=""ecxBg_Color"" align=""center"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td class=""ecxPreheader_Color"" style="""" bgcolor=""#f3f3f3"" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""" align=""center"" width=""191""><a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" style=""width:191px;height:50px;max-width:191px;max-height:50px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""191"" height=""50"">
//</a></td>
//<td class=""ecxRespoHideSmall"" style="""" width=""100%""></td>
//</tr>
//</tbody>
//</table>
//</td>
//<td class=""ecxRespoHideSmall"" style="""" width=""150"">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table align=""right"" cellpadding=""0"" cellspacing=""0"">
//<tbody>
//<tr>
//<td style="""" align=""right"" width=""50""><a href=""" + _facebook + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//<td style="""" align=""right"" width=""50""><a href=""" + _twitter + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//<td style="""" align=""right"" width=""50""><a href=""" + _googleplus + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" height=""20""></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td class=""ecxBgImageAltColor"" style="""" bgcolor=""#3A5490"">
//<table style=""clear:both;"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table align=""center"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h2 style=""text-align:center;color:#ffffff;font-size:18px;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Operadora Turistica - Viajes Itzaa</h2>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td class="""" style="""" bgcolor=""#8CBE3F"" width=""100%"" height=""1"">
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""10""></td>
//</tr>
//<tr>
//<td style="""">
//<h1 style=""text-transform:uppercase;text-align:center;color:#ffffff;font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;line-height:40px;"">
//<a href=""#"" style=""color:#ffffff;text-decoration:none;text-transform:capitalize;line-height:30px;"">Gracias por elegirnos<br>
//</a></h1>
//<h3 style=""text-align:center;color:#c7c7c7;font-size:18px;font-weight:bold;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//La mejor experiencia para su viaje</h3>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td class="""" style="""" bgcolor=""#8CBE3F"" width=""100%"" height=""1"">
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxColor02_B"" bgcolor=""#fff"" cellpadding=""5"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h1 style=""text-align:center;text-transform:uppercase;font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;line-height:40px;"">
//<a href=""#"" style=""text-transform:uppercase;text-decoration:none;color:#151516;line-height:30px;"">Orden de Pago Paypal</a></h1>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" valign=""top"" height=""40"">&nbsp; </td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxContent_Color"" bgcolor=""#ffffff"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//<tbody>
//<tr>
//<td class=""ecxRespoImage_70ToOneW"" style=""""><a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""ecxRespoImage_70ToOne"" alt="""" style=""width:185px;height:130px;display:block;border:0px none;text-decoration:none;"" border=""0"" width=""185"" height=""100""></a>
//</td>
//</tr>
//<tr>
//<td style="""">
//<table cellpadding=""7"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td class=""ecxColor01_B"" style="""" bgcolor=""#8CBE3F"">
//<h3 style=""text-align:center;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href=""" + dominio + @"/MiCuenta"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><span style=""text-decoration:none;color:#ffffff;"">Mis datos</span></a></h3>
//</td>
//<td class=""ecxColor01_D"" style="""" align=""center"" bgcolor=""#3A5490"" width=""50"">
//<a href=""" + dominio + @"/MiCuenta"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" style=""width:32px;height:32px;max-width:32px;max-height:32px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""32"" height=""32"">
//</a></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""30"" cellspacing=""0"" width=""391"">
//<tbody>
//<tr>
//<td style="""" width=""331"">
//<h1 style=""text-transform:uppercase;font-size:15px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;text-align:left;line-height:40px;"">
//" + Cliente + @"</h1>
//<h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Usuario: " + Correo + @"</h3>
//<h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Contraseña: *****</h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//
//<tr>
//<td style="""" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxPreheader_Color"" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h2 style=""text-align:center;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Detalle de la orden de pago</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxPreheader_Color"" bgcolor=""#8CBE3F"" cellpadding=""20"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//NOMBRE DEL PAGO:</h3>
//</td>
//<td style="""">
//<h2 style=""text-align:right;text-transform:uppercase;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//" + NombreOrdenPago + @"</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//DESCRIPCIÓN:</h3>
//</td>
//<td style="""">
//<h2 style=""text-align:right;text-transform:uppercase;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//" + Descripcion + @"</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//
//<tr>
//<td style="""">
//<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//MONTO:</h3>
//</td>
//<td style="""">
//<h2 style=""text-align:right;text-transform:uppercase;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//" + Total + @"</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//
//<tr>
//<td style="""">
//<table class=""ecxColor01_D"" bgcolor=""#042761"" cellpadding=""5"" cellspacing=""0"" width=""30%"" style=""margin-left: 70%;"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""text-align:center;font-size:12px;color:#808185;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href=""" + linkPago + @""" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><span style=""text-decoration:none;color:#ffffff;"">Pagar</span></a></h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""60""></td>
//</tr>
//<tr>
//<td style="""">
//<table cellpadding=""7"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td class=""ecxColor01_B"" style="""" bgcolor=""#3A5490"">
//<h3 style=""text-align:center;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href=""https://"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank""><span style=""text-decoration:none;color:#ffffff;"">Políticas y condiciones del servicio</span></a></h3>
//</td>
//<td class=""ecxColor01_D"" style="""" align=""center"" bgcolor=""#8CBE3F"" width=""50"">
//<a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/details.png"" alt="""" style=""width:32px;height:32px;max-width:32px;max-height:32px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""32"" height=""32"">
//</a></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""60""></td>
//</tr>
//<tr>
//<td class=""ecxColor01_D"" style="""" bgcolor=""#3A5490"" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpaddi3A5490ng=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxColor01_D"" bgcolor=""#3A5490"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Datos de contacto:</h2>
//<h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Tel. " + telefono + @"<br>
//<a href=""#"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"">Email. " + correoItzaa + @"</a></h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
//<tbody>
//<tr>
//<td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
//<p style=""padding-left:20px;"">&nbsp;</p>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxColor01_D"" bgcolor=""#3A5490"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Paquetes:</h2>
//<h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Chiapas</a><br>
//<a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Yucatan</a><br>
//<a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">QuintanaRoo</a></h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
//<tbody>
//<tr>
//<td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
//<p style=""padding-left:20px;"">&nbsp;</p>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxBoxWrap"" align=""right"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxColor01_D"" bgcolor=""#3A5490"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Servicios:</h2>
//<h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Tour</a><br>
//<a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Transportación</a>
//</h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td class=""ecxPreheader_Color"" style="""" bgcolor=""#f3f3f3"" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href=""#"" style=""text-decoration:none;color:#151516;text-transform:capitalize;line-height:30px;"">Operadora Turística Itzaa</a></h3>
//</td>
//<td class=""ecxRespoHideSmall"" style="""" width=""150"">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table align=""right"" cellpadding=""0"" cellspacing=""0"">
//<tbody>
//<tr>
//<td style="""" align=""right"" width=""50""><a href=""" + _facebook + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//<td style="""" align=""right"" width=""50""><a href=""" + _twitter + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//<td style="""" align=""right"" width=""50""><a href=""" + _googleplus + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" height=""20""></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table></div></body></html>
//                    ";
//                return html;
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }

//        public static string GenerarHtmlConfirmacionCompra(Solicitud Datos)
//        {
//            try
//            {
//                string dominio = _dominio;
//                string textoAuxiliar = string.Empty;
//                string correoCliente = Datos.Cliente != null ? Datos.Cliente.CorreoElectronico : string.Empty;
//                string Cliente = Datos.Cliente != null ? Datos.Cliente.Nombre : string.Empty;
//                string nombrePaquete = Datos.NombreProducto;
//                string Folio = Datos.Folio;
//                string FechaLimInicial = Datos.FechaLimPagoInicial.ToShortDateString();
//                string FechaLimFinal = Datos.FechaLimPagoFinal.ToShortDateString();
//                string _facebook = Comun.UrlFacebook;
//                string _twitter = Comun.UrlTwitter;
//                string _googleplus = Comun.UrlGoogle;
//                string correoItzaa = Comun.CorreoEmpresa;
//                string telefono = Comun.Telefono;
//                string MontoTotal = string.Format("{0:c}", Datos.MontoPagado);
//                string MontoInicial = string.Format("{0:c}", Datos.MontoInicial);
//                string MotivoMontoInicial = Datos.MotivoMontoInicial;
//                string MontoAnticipo = string.Format("{0:c}", Datos.MontoAnticipo);
//                string MontoFinal = string.Format("{0:c}", Datos.MontoFinal);
//                string txtAnticipoPagado = "Cubierto por monto Inicial";
//                string txtFinalPagado = "Cubierto por monto Inicial";
//                string txtFechaIniPagado = "No aplica";
//                string txtFechaFinPagado = "No aplica";
//                if (Datos.MontoInicial > 0)
//                {
//                    if (Datos.MontoInicial >= Datos.MontoPagado)
//                    {
//                        MontoAnticipo = txtAnticipoPagado;
//                        MontoFinal = txtFinalPagado;
//                        FechaLimInicial = txtFechaIniPagado;
//                        FechaLimFinal = txtFechaFinPagado;
//                    }
//                    else
//                    {
//                        if (Datos.MontoInicial >= Datos.MontoAnticipo)
//                        {
//                            decimal Diferencia = Datos.MontoInicial - Datos.MontoAnticipo;
//                            MontoAnticipo = txtAnticipoPagado;
//                            FechaLimInicial = txtFechaIniPagado;
//                            MontoFinal = string.Format("{0:c}", Datos.MontoFinal - Diferencia);
//                        }
//                        else
//                        {
//                            MontoAnticipo = string.Format("{0:c}", Datos.MontoAnticipo - Datos.MontoInicial);
//                        }
//                    }
//                }
//                string html = @"
//
//<html><head></head><body><br><div><br>
//<title></title>
//<table class=""ecxBg_Color"" align=""center"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td class=""ecxPreheader_Color"" style="""" bgcolor=""#f3f3f3"" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""" align=""center"" width=""191""><a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" style=""width:191px;height:50px;max-width:191px;max-height:50px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""191"" height=""50"">
//</a></td>
//<td class=""ecxRespoHideSmall"" style="""" width=""100%""></td>
//</tr>
//</tbody>
//</table>
//</td>
//<td class=""ecxRespoHideSmall"" style="""" width=""150"">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table align=""right"" cellpadding=""0"" cellspacing=""0"">
//<tbody>
//<tr>
//<td style="""" align=""right"" width=""50""><a href=""" + _facebook + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//<td style="""" align=""right"" width=""50""><a href=""" + _twitter + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//<td style="""" align=""right"" width=""50""><a href=""" + _googleplus + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" height=""20""></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td class=""ecxBgImageAltColor"" style="""" bgcolor=""#3A5490"">
//<table style=""clear:both;"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table align=""center"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h2 style=""text-align:center;color:#ffffff;font-size:18px;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Operadora Turistica - ViajesItzaa</h2>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td class="""" style="""" bgcolor=""#8CBE3F"" width=""100%"" height=""1"">
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""10""></td>
//</tr>
//<tr>
//<td style="""">
//<h1 style=""text-transform:uppercase;text-align:center;color:#ffffff;font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;line-height:40px;"">
//<a href=""#"" style=""color:#ffffff;text-decoration:none;text-transform:capitalize;line-height:30px;"">Gracias por elegirnos<br>
//</a></h1>
//<h3 style=""text-align:center;color:#c7c7c7;font-size:12px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//La mejor experiencia para su viaje</h3>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td class="""" style="""" bgcolor=""#8CBE3F"" width=""100%"" height=""1"">
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" valign=""top"" height=""40"">&nbsp; </td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxContent_Color"" bgcolor=""#ffffff"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//<tbody>
//<tr>
//<td class=""ecxRespoImage_70ToOneW"" style=""""><a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""ecxRespoImage_70ToOne"" alt="""" style=""width:185px;height:130px;display:block;border:0px none;text-decoration:none;"" border=""0"" width=""185"" height=""100""></a>
//</td>
//</tr>
//<tr>
//<td style="""">
//<table cellpadding=""7"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td class=""ecxColor01_B"" style="""" bgcolor=""#8CBE3F"">
//<h3 style=""text-align:center;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href=""" + dominio + @"/MiCuenta"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><span style=""text-decoration:none;color:#ffffff;"">Mis datos</span></a></h3>
//</td>
//<td class=""ecxColor01_D"" style="""" align=""center"" bgcolor=""#3A5490"" width=""50"">
//<a href=""" + dominio + @"/MiCuenta"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" style=""width:32px;height:32px;max-width:32px;max-height:32px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""32"" height=""32"">
//</a></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""30"" cellspacing=""0"" width=""391"">
//<tbody>
//<tr>
//<td style="""" width=""331"">
//<h1 style=""text-transform:uppercase;font-size:15px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;text-align:left;line-height:40px;"">
//" + Cliente + @"</h1>
//<h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Usuario: " + correoCliente + @"</h3>
//<h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Contraseña: *****</h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//
//<tr>
//<td style="""" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//
//<tr>
//<td style="""">
//<table class=""ecxPreheader_Color"" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h2 style=""text-align:center;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//CONFIRMACIÓN DE COMPRA</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxPreheader_Color"" bgcolor=""#8CBE3F"" cellpadding=""20"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td class=""ecxRespoImage_OneToOneW"" style=""""><img class=""ecxRespoImage_OneToOne"" src=""" + dominio + @"/Imagenes/Transportacion/Transportacion.png"" alt="""" style=""width:530px;height:401px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""401"" height=""401"">
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//
//<tr>
//<td style="""">
//<table class=""ecxPreheader_Color"" bgcolor=""#8CBE3F"" cellpadding=""20"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Pago Inicial</h3>
//</td>
//<td style="""">
//<h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//" + MontoAnticipo + @"</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Fecha Límite de Pago Inicial</h3>
//</td>
//<td style="""">
//<h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//" + FechaLimInicial + @"</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Pago Final</h3>
//</td>
//<td style="""">
//<h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//" + MontoFinal + @"</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Fecha Límite de Pago Final</h3>
//</td>
//<td style="""">
//<h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//" + FechaLimFinal + @"</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>";

//                if (!string.IsNullOrEmpty(textoAuxiliar))
//                {
//                    html = html + @"
//                    <tr>
//                    <td style="""">
//                    <table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//                    <tbody>
//                    <tr>
//                    <td style="""">
//                    <h2 style=""text-align:left;font-size:14px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                    " + textoAuxiliar + @"</h2>
//                    </td>
//                    </tr>
//                    </tbody>
//                    </table>
//                    </td>
//                    </tr>";
//                }
//html = html + @"
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//<tr>
//<td style="""">
//<h2 style=""font-size:18px;color:#000;text-align:right;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Monto Total</h2>
//<h1 style=""font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;text-align:right;line-height:40px;"">
//" + MontoTotal + @"</h1>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""60""></td>
//</tr>
//
//
//
//<tr>
//<td style="""">
//<table cellpadding=""7"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td class=""ecxColor01_B"" style="""" bgcolor=""#3A5490"">
//<h3 style=""text-align:center;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href=""https://"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank""><span style=""text-decoration:none;color:#ffffff;""></span></a></h3>
//</td>
//<td class=""ecxColor01_D"" style="""" align=""center"" bgcolor=""#8CBE3F"" width=""50"">
//<a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/details.png"" alt="""" style=""width:32px;height:32px;max-width:32px;max-height:32px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""32"" height=""32"">
//</a></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""60""></td>
//</tr>
//<tr>
//<td class=""ecxColor01_D"" style="""" bgcolor=""#3A5490"" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxColor01_D"" bgcolor=""#3A5490"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Datos de contacto:</h2>
//<h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Tel. " + telefono + @"<br>
//<a href=""#"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"">Email. " + correoItzaa + @"</a></h3>
//
//
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
//<tbody>
//<tr>
//<td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
//<p style=""padding-left:20px;"">&nbsp;</p>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxColor01_D"" bgcolor=""#3A5490"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style=""-webkit-text-size-adjust: none;"">
//<h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
//<h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Chiapas</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Yucatan</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">QuintanaRoo</a></h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
//<tbody>
//<tr>
//<td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
//<p style=""padding-left:20px;"">&nbsp;</p>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxBoxWrap"" align=""right"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxColor01_D"" bgcolor=""#3A5490"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style=""-webkit-text-size-adjust: none;"">
//<h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
//<h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Tour</a><br><a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Transportación</a>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td class=""ecxPreheader_Color"" style="""" bgcolor=""#f3f3f3"" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href=""" + dominio + @""" style=""text-decoration:none;color:#151516;text-transform:capitalize;line-height:30px;"">Operadora Turística Itzaa</a></h3>
//</td>
//<td class=""ecxRespoHideSmall"" style="""" width=""150"">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table align=""right"" cellpadding=""0"" cellspacing=""0"">
//<tbody>
//<tr>
//<td style="""" align=""right"" width=""50""><a href=""" + _facebook + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//<td style="""" align=""right"" width=""50""><a href=""" + _twitter + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//<td style="""" align=""right"" width=""50""><a href=""" + _googleplus + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" height=""20""></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table></div></body></html>
//
//                ";
//                return html;
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }

//        public static string GenerarHtmlConfirmacionPago(Solicitud Datos)
//        {
//            try
//            {
//                string dominio = _dominio;
//                string correoCliente = Datos.Cliente != null ? Datos.Cliente.CorreoElectronico : string.Empty;
//                string Cliente = Datos.Cliente != null ? Datos.Cliente.Nombre : string.Empty;
//                string fechaPago = Datos.Pago != null ? Datos.Pago.FechaPago.ToShortDateString() : string.Empty;
//                string monto = string.Format("{0:c}", Datos.Pago != null ? Datos.Pago.MontoPagado : 0);
//                string nombrePaquete = Datos.NombreProducto;

//                string _facebook = Comun.UrlFacebook;
//                string _twitter = Comun.UrlTwitter;
//                string _googleplus = Comun.UrlGoogle;
//                string correoItzaa = Comun.CorreoEmpresa;
//                string telefono = Comun.Telefono;

//                string html = @"
//                <html>
//                <head>
//                <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
//                <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
//                <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
//                </head>
//                <body><br><div><br>
//                <title></title>
//                <style></style>
//                <table class=""ecxBg_Color"" align=""center"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td class=""ecxPreheader_Color"" style="""" bgcolor=""#f3f3f3"" valign=""top"">
//                <table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//                <tbody>
//                <tr>
//                <td style="""" height=""20""></td>
//                </tr>
//                <tr>
//                <td style="""">
//                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""" align=""center"" width=""191""><a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" style=""width:191px;height:50px;max-width:191px;max-height:50px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""191"" height=""50"">
//                </a></td>
//                <td class=""ecxRespoHideSmall"" style="""" width=""100%""></td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                <td class=""ecxRespoHideSmall"" style="""" width=""150"">
//                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table align=""right"" cellpadding=""0"" cellspacing=""0"">
//                <tbody>
//                <tr>
//                <td style="""" align=""right"" width=""50""><a href=""" + _facebook + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//                </a></td>
//                <td style="""" align=""right"" width=""50""><a href=""" + _twitter + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//                </a></td>
//                <td style="""" align=""right"" width=""50""><a href=""" + _googleplus + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//                </a></td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td style="""" height=""20""></td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td class=""ecxBgImageAltColor"" style="""" bgcolor=""#3A5490"">
//                <table style=""clear:both;"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table align=""center"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""" valign=""top"">
//                <table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//                <tbody>
//                <tr>
//                <td style="""" width=""100%"" height=""20""></td>
//                </tr>
//                <tr>
//                <td style="""">
//                <table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <h2 style=""text-align:center;color:#ffffff;font-size:18px;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//                Operadora Turística - Viajes Itzaa</h2>
//                </td>
//                </tr>
//                <tr>
//                <td style="""" width=""100%"" height=""20""></td>
//                </tr>
//                <tr>
//                <td class="""" style="""" bgcolor=""#8CBE3F"" width=""100%"" height=""1"">
//                </td>
//                </tr>
//                <tr>
//                <td style="""" width=""100%"" height=""10""></td>
//                </tr>
//                <tr>
//                <td style="""">
//                <h1 style=""text-transform:uppercase;text-align:center;color:#ffffff;font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;line-height:40px;"">
//                <a href=""#"" style=""color:#ffffff;text-decoration:none;text-transform:capitalize;line-height:30px;"">Gracias por elegirnos<br>
//                </a></h1>
//                <h3 style=""text-align:center;color:#c7c7c7;font-size:12px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                La mejor experiencia para su viaje</h3>
//                </td>
//                </tr>
//                <tr>
//                <td style="""" width=""100%"" height=""20""></td>
//                </tr>
//                <tr>
//                <td class="""" style="""" bgcolor=""#8CBE3F"" width=""100%"" height=""1"">
//                </td>
//                </tr>
//                <tr>
//                <td style="""" width=""100%"" height=""20""></td>
//                </tr>
//                <tr>
//                <td style="""">
//                <table class=""ecxColor02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <h1 style=""text-align:center;text-transform:uppercase;font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;line-height:40px;"">
//                <a href=""#"" style=""text-transform:uppercase;text-decoration:none;color:#151516;line-height:30px;"">Agradecemos la realización de su pago.</a></h1>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>.
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td style="""" valign=""top"" height=""40"">&nbsp; </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td style="""" valign=""top"">
//                <table class=""ecxBoxWrap"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""" width=""100%"" height=""20""></td>
//                </tr>
//                </tbody>
//                </table>
//                <table class=""ecxContent_Color"" bgcolor=""#ffffff"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//                <tbody>
//                <tr>
//                <td class=""ecxRespoImage_70ToOneW"" style=""""><a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""ecxRespoImage_70ToOne"" alt="""" style=""width:185px;height:130px;display:block;border:0px none;text-decoration:none;"" border=""0"" width=""185"" height=""100""></a>
//                </td>
//                </tr>
//                <tr>
//                <td style="""">
//                <table cellpadding=""7"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td class=""ecxColor01_B"" style="""" bgcolor=""#8CBE3F"">
//                <h3 style=""text-align:center;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                <a href=""" + dominio + @"/MiCuenta"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><span style=""text-decoration:none;color:#ffffff;"">Mis datos</span></a></h3>
//                </td>
//                <td class=""ecxColor01_D"" style="""" align=""center"" bgcolor=""#3A5490"" width=""50"">
//                <a href=""" + dominio + @"/MiCuenta"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" style=""width:32px;height:32px;max-width:32px;max-height:32px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""32"" height=""32"">
//                </a></td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                <table class=""ecxBoxWrap"" align=""left"" cellpadding=""30"" cellspacing=""0"" width=""391"">
//                <tbody>
//                <tr>
//                <td style="""" width=""331"">
//                <h1 style=""text-transform:uppercase;font-size:15px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;text-align:left;line-height:40px;"">
//                " + Cliente + @"</h1>
//                <h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                Usuario: " + correoCliente + @"</h3>
//                <h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                Contraseña: *****</h3>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//
//                <tr>
//                <td style="""" valign=""top"">
//                <table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//                <tbody>
//                <tr>
//                <td style="""" width=""100%"" height=""20""></td>
//                </tr>
//                <tr>
//                <td style="""">
//                <table class=""ecxPreheader_Color"" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <h2 style=""text-align:center;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//                Detalles de la compra</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td style="""">
//                <table class=""ecxPreheader_Color"" bgcolor=""#8CBE3F"" cellpadding=""20"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                Paquete o Servicio:</h3>
//                </td>
//                <td style="""">
//                <h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//                " + nombrePaquete + @"</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td style="""" width=""100%"" height=""2""></td>
//                </tr>
//                <tr>
//                <td style="""">
//                <table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                Fecha de aprobación del pago:</h3>
//                </td>
//                <td style="""">
//                <h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//                " + fechaPago + @"</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td style="""" width=""100%"" height=""2""></td>
//                </tr>
//                <tr>
//                <td style="""">
//                <table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <h3 style=""text-align:left;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                Monto del pago:</h3>
//                </td>
//                <td style="""">
//                <h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#000;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//                " + monto + @"</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td style="""" width=""100%"" height=""2""></td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td style="""" width=""100%"" height=""60""></td>
//                </tr>
//                <tr>
//                <td style="""">
//                <table cellpadding=""7"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td class=""ecxColor01_B"" style="""" bgcolor=""#3A5490"">
//                <h3 style=""text-align:center;font-size:12px;color:#000;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                <a href=""https://"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank""><span style=""text-decoration:none;color:#ffffff;"">Políticas y condiciones del servicio</span></a></h3>
//                </td>
//                <td class=""ecxColor01_D"" style="""" align=""center"" bgcolor=""#8CBE3F"" width=""50"">
//                <a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/details.png"" alt="""" style=""width:32px;height:32px;max-width:32px;max-height:32px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""32"" height=""32"">
//                </a></td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td style="""" width=""100%"" height=""60""></td>
//                </tr>
//                <tr>
//                <td class=""ecxColor01_D"" style="""" bgcolor=""#3A5490"" valign=""top"">
//                <table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table class=""ecxColor01_D"" bgcolor=""#3A5490"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//                Datos de contacto:</h2>
//                <h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                Tel. " + telefono + @"<br>
//                <a href=""#"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"">Email. " + correoItzaa + @"</a></h3>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                <table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
//                <tbody>
//                <tr>
//                <td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
//                <p style=""padding-left:20px;"">&nbsp;</p>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                <table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table class=""ecxColor01_D"" bgcolor=""#3A5490"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//                Paquetes:</h2>
//                <h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                <a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Chiapas</a><br>
//                <a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Yucatan</a><br>
//                <a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">QuintanaRoo</a></h3>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                <table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
//                <tbody>
//                <tr>
//                <td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
//                <p style=""padding-left:20px;"">&nbsp;</p>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                <table class=""ecxBoxWrap"" align=""right"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table class=""ecxColor01_D"" bgcolor=""#3A5490"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//                Servicios:</h2>
//                <h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                <a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Tour</a><br>
//                <a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Transportación</a>
//                </h3>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td class=""ecxPreheader_Color"" style="""" bgcolor=""#f3f3f3"" valign=""top"">
//                <table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//                <tbody>
//                <tr>
//                <td style="""" height=""20""></td>
//                </tr>
//                <tr>
//                <td style="""">
//                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <h3 style=""font-size:12px;color:#000;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                <a href=""" + dominio + @""" style=""text-decoration:none;color:#151516;text-transform:capitalize;line-height:30px;"">Operadora Turística Itzaa</a></h3>
//                </td>
//                <td class=""ecxRespoHideSmall"" style="""" width=""150"">
//                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table align=""right"" cellpadding=""0"" cellspacing=""0"">
//                <tbody>
//                <tr>
//                <td style="""" align=""right"" width=""50""><a href=""" + _facebook + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//                </a></td>
//                <td style="""" align=""right"" width=""50""><a href=""" + _twitter + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//                </a></td>
//                <td style="""" align=""right"" width=""50""><a href=""" + _googleplus + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//                </a></td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td style="""" height=""20""></td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table></div></body></html>
//                ";

//                return html;
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }

//        public static bool EnviarCorreo(string De, string Contraseña, string Para, string Asunto, string Mensaje, bool banArchivo, string Archivo, bool Html, string Host, int Port, bool Ssl)
//        {
//            try
//            {

//                //GMAIL
//                //Habilitar las siguientes opciones en correo de gmail
//                //https://www.google.com/settings/security/lesssecureapps
//                //https://accounts.google.com/DisplayUnlockCaptcha
//                //HOTMAIL
//                //Enviara las primeras veces despues nos llegara un correo para reconocer el inicio de sesion 
//                //ya que depende del servidor donde esta alojado y se tiene que reconocer el inicio de sesion   
//                //Para = "lackke.141727@gmail.com";
//                System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();
//                mailMessage.From = new System.Net.Mail.MailAddress(De);
//                mailMessage.To.Add(Para);
//                mailMessage.Subject = Asunto;
//                if (banArchivo)
//                    mailMessage.Attachments.Add(new System.Net.Mail.Attachment(Archivo));
//                mailMessage.Body = Mensaje;
//                mailMessage.IsBodyHtml = Html;
//                System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient(Host);
//                smtpClient.Port = Port;
//                smtpClient.EnableSsl = Ssl;
//                smtpClient.Credentials = new NetworkCredential(De, Contraseña);
//                smtpClient.Send(mailMessage);
//                return true;
//            }
//            catch (Exception ex)
//            {
//                Comun_Negocio.AddExcFileTxt(ex, "EnvioCorreo.EnviarCorreo");
//                return false;
//            }
//        }

//        public static string GenerarHtmlPaqueteCotizado(Solicitud datos)
//        {
//            string _facebook = Comun.UrlFacebook;
//            string _twitter = Comun.UrlTwitter;
//            string _googleplus = Comun.UrlGoogle;
//            string correoItzaa = Comun.CorreoEmpresa;
//            string telefono = Comun.Telefono;
//            string pass = datos.Cliente != null ? (string.IsNullOrEmpty(datos.Cliente.Password) ? "*****" : datos.Cliente.Password) : "*****";
//            string Monto = string.Format("{0:c}", datos.Cotizacion != null ? datos.Cotizacion.Subtotal : 0);
//            string Comentarios = datos.Cotizacion != null ? datos.Cotizacion.Comentarios : string.Empty;
//            string FechaLlegada = datos.FechaLlegada.ToShortDateString() + " " + datos.HoraLlegada;
//            string FechaSalida = datos.FechaSalida.ToShortDateString() + " " + datos.HoraSalida;
//            string CorreoCliente = datos.Cliente != null ? datos.Cliente.CorreoElectronico : string.Empty;
//            string NombreCliente = datos.Cliente != null ? datos.Cliente.Nombre : string.Empty;
//            string NumPersonas = datos.NumTotalPersonas.ToString();
//            string dominio = _dominio;
//            string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
//            string numeroEstrellas = "";
//            for (int j = 0; j < Convert.ToInt32(datos.CategoriaHotel.ToString()); j++)
//            {
//                numeroEstrellas += "*";
//            }
//            string html = @"<html>
//            <head>
//            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
//            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
//            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
//            <title></title>
//            <style type=""text/css"">
//            div, p, a, li, td { -webkit-text-size-adjust:none; }
//            .ReadMsgBody
//            {width: 100%; background-color: #ffffff;}
//            .ExternalClass
//            {width: 100%; background-color: #ffffff;}
//            body
//            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
//            html
//            {width: 100%; }
//            img 
//            {border:0px; outline:none; text-decoration:none; display:block; }
//            a
//            {text-decoration: none; text-transform: capitalize; line-height: 30px; color: #ffffff;}
//            a span
//            {text-decoration:none; color: #ffffff;}
//            h1 
//            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
//            h2 
//            {font-size: 18px; margin: 10px 0 10px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:uppercase;}
//            h3 
//            {font-size: 12px; margin: 5px 0 5px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
//            @media only screen and (max-width: 900px) 
//            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
//            @media only screen and (max-width: 640px)
//            { body{ width:auto!important; }
//            .BoxWrap { width:440px !important;}
//            .RespoHideMedium { display:none !important; } 
//            .RespoShowMedium { display:block !important; } 
//            .RespoCenterMedium { text-align:center !important; }
//            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
//            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
//            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
//            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
//            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
//            }
//            @media only screen and (max-width: 479px)
//            {
//            body{width:auto!important;}
//            .BoxWrap { width:280px !important;}
//            .RespoHideSmall { display:none !important; }
//            .RespoCenterSmall { text-align:center !important; }
//            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
//            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
//            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
//            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
//            }
//            .Bg_Color
//            {
//             background-color: #fefefe;
//            }
//            .BgImageAltColor
//            {
//            background-color: #3A5490;
//            }
//            .Preheader_Color
//            {
//            background-color: #8CBE3F;
//            }
//            .Content_Color
//            {
//             /*@editable*/ background-color: #ffffff;
//            }
//            .Color01_B
//            {
//             /*@editable background-color: #CE0000;*/
//            }
//            .Color01_D
//            {
//             /*@editable background-color: #000000;*/
//            }
//            .Color02_B
//            {
//             /*@editable*/ background-color: #E7E7EF;
//            } 
//            </style>
//            </head>
//            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
//            <tbody>
//            <tr>
//            <td valign=""top"" class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td class=""RespoHideSmall"" width=""100%"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
//            <tbody>
//            <tr>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td class=""BgImageAltColor"" bgcolor=""#3A5490"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;color: #ffffff;font-size: 18px;margin: 10px 0 10px 0;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Operadora Turística - Viajes Itzaa</h2>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""1"" class="""" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h1 style=""text-transform: uppercase;text-align: center;color: #ffffff;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;line-height: 40px;""><a href=""#"" style=""color: #ffffff;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;"">Gracias por elegirnos<br></a></h1>
//            <h3 style=""text-align: center;color: #c7c7c7;font-size: 12px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">La mejor experiencia para su viaje</h3>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""1"" class="""" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            if (!string.IsNullOrEmpty(Comentarios))
//            {
//                html = html + @"
//                <tr>
//                    <td style=""-webkit-text-size-adjust: none;"">
//                        <table width=""100%"" class=""Color02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"">
//                            <tbody>
//                                <tr>
//                                    <td style=""-webkit-text-size-adjust: none; line-height: 9px; text-transform: uppercase; margin-top: 5px;"">
//                                    <font color=""#000000"" face=""Microsoft Sans Serif"" size=""2"">
//                                        " + Comentarios + @"
//                                    </font>
//                                    </td>
//                                </tr>
//                            </tbody>
//                        </table>
//                     </td>
//                </tr>";
//            }

//            html = html + @"
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;"">
//            &nbsp; 
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""600"" class=""BoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" border=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""RespoImage_70ToOneW"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//			<img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""RespoImage_70ToOne"" alt="""" style=""width: 185px; height: 130px; display: block; border: 0px none; outline: medium none; text-decoration: none;"" border=""0"" height=""100"" width=""185""></a>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""Color01_B"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Mis datos</span></a></h3>
//            </td>
//            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#3A5490"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""" + dominio + @"/MiCuenta"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""391"" align=""left"" cellpadding=""30"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""331"" style=""-webkit-text-size-adjust: none;"">
//            <h1 style=""text-transform: uppercase;font-size: 15px;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + NombreCliente + @"</h1>
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Usuario: " + CorreoCliente + @"</h3>
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Contraseña: " + pass + @"</h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""401"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""RespoImage_OneToOneW"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img class=""RespoImage_OneToOne"" width=""401"" height=""401"" src="" " + dominio + @"" + datos.ImgProducto.Replace("~", "") + @" "" alt="""" border=""0"" style=""width: 401px;height: 401px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">" + datos.NombreProducto + @"</h2>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumDias.ToString() + @" días</h1>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumNoches.ToString() + @" noches</h1>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Color01_D"" bgcolor=""#3A5490"" cellpadding=""5"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/DetallePaquete/?id=" + datos.IDProducto + @"&id_seccion=" + datos.IDSeccion + @""" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Ver paquete</span></a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Detalles cotización del paquete</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""20"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Llegada:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaLlegada + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Salida:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaSalida + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Categoria de Hotel:</h3>
//            </td> 
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align:right;text-transform:capitalize;font-size: 39px;color: #F7E82F;font-weight: 800;line-height: 0px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;margin-top: 15px;margin-bottom: 0px;"">" + numeroEstrellas + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Numero de personas:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + NumPersonas + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">HABITACIONES</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Adultos</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 4-11</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 0-4</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Camas</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Tipo de Habitación</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            foreach (Habitacion datosHab in datos.ListaHabitaciones)
//            {
//                string numAdultos = datosHab.NumAdultos.ToString();
//                string numMenores4 = datosHab.NumMenores4.ToString();
//                string numMenores11 = datosHab.NumMenores11.ToString();
//                string numCamas = datosHab.NumCamas.ToString();
//                string TipoHabitacion = datosHab.TipoHabitacion;

//                html = html + @"<tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//                <tbody>
//                <tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numAdultos + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores11 + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores4 + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numCamas + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + TipoHabitacion + @"</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//                </tr>";
//            }



//            html = html + @"
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">COSTOS</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Tipo de Habitación</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Adulto</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Niños 4-11</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Niños 0-4</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo de Habitación</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            foreach (Habitacion datosHab in datos.ListaHabitaciones)
//            {
//                string TipoHabitacion = datosHab.TipoHabitacion;
//                string costoAdulto = datosHab.CostoAdulto <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoAdulto);
//                string costoMenor4 = datosHab.CostoMenor4 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor4);
//                string costoMenor11 = datosHab.CostoMenor11 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor11);
//                string subtotal = string.Format("{0:c}", datosHab.Subtotal);

//                html = html + @"<tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//                <tbody>
//                <tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + TipoHabitacion + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoAdulto + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoMenor11 + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoMenor4 + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + subtotal + @"</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//                </tr>";
//            }


//            html = html + @"<tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">ITINERARIO</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Orden</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Lugar</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            foreach (LugarTuristico datosLugar in datos.ListaItinerario)
//            {
//                string Orden = datosLugar.Orden.ToString();
//                string Lugar = datosLugar.Lugar;
//                html = html + @"
//                <tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//                <tbody>
//                <tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + Orden + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + Lugar + @"</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>";
//            }

//            html = html + @"            
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Precio</h2>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">" + Monto + @"</h1>
//            </td>
//            </tr>";

//            html = html + @"
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Para poder apartar el paquete se debe pagar el " + Anticipo + @"% del precio. El resto debe cubrirse al llegar a nuestras instalaciones. </h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""30"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//                <td style=""-webkit-text-size-adjust: none;"">
//                    <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
//                        <tbody>
//                            <tr>
//                                <td class=""Color01_B"" bgcolor=""#3A5490"" style=""-webkit-text-size-adjust: none;"">
//                                    <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href="""" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;""></span></a></h3>
//                                </td>
//                                <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;"">
//                                    <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//                                        <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/details.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
//                                    </a>
//                                </td>
//                            </tr>
//                        </tbody>
//                    </table>
//                </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""60"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td valign=""top"" class=""Color01_D"" bgcolor=""#3A5490"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#3A5490"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. " + telefono + @"<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
//            <tbody>
//            <tr>
//            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
//            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#3A5490"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Chiapas</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Yucatan</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">QuintanaRoo</a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
//            <tbody>
//            <tr>
//            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
//            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#3A5490"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Tour</a><br><a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Transportación</a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @""" style=""text-decoration: none;color: #151516;-webkit-text-size-adjust: none;text-transform: capitalize;line-height: 30px;"">Operadora Turística Itzaa</a></h3>
//            </td>
//            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
//            <tbody>
//            <tr>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </body>
//            </html>
//            ";
//            return html;
//        }

//        public static string GenerarHtmlPaqueteVipCotizado(Solicitud datos)
//        {
//            string _facebook = Comun.UrlFacebook;
//            string _twitter = Comun.UrlTwitter;
//            string _googleplus = Comun.UrlGoogle;
//            string correoItzaa = Comun.CorreoEmpresa;
//            string telefono = Comun.Telefono;
//            string pass = datos.Cliente != null ? (string.IsNullOrEmpty(datos.Cliente.Password) ? "*****" : datos.Cliente.Password) : "*****";
//            string Monto = string.Format("{0:c}", datos.Cotizacion != null ? datos.Cotizacion.Subtotal : 0);
//            string Comentarios = datos.Cotizacion != null ? datos.Cotizacion.Comentarios : string.Empty;
//            string FechaLlegada = datos.FechaLlegada.ToShortDateString() + " " + datos.HoraLlegada;
//            string FechaSalida = datos.FechaSalida.ToShortDateString() + " " + datos.HoraSalida;
//            string CorreoCliente = datos.Cliente != null ? datos.Cliente.CorreoElectronico : string.Empty;
//            string NombreCliente = datos.Cliente != null ? datos.Cliente.Nombre : string.Empty;
//            string NumPersonas = datos.NumTotalPersonas.ToString();
//            string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
//            string dominio = _dominio;
//            string numeroEstrellas = "";
//            for (int j = 0; j < Convert.ToInt32(datos.CategoriaHotel.ToString()); j++)
//            {
//                numeroEstrellas += "*";
//            }

//            string html = @"<html>
//            <head>
//            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
//            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
//            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
//            <title></title>
//            <style type=""text/css"">
//            div, p, a, li, td { -webkit-text-size-adjust:none; }
//            .ReadMsgBody
//            {width: 100%; background-color: #ffffff;}
//            .ExternalClass
//            {width: 100%; background-color: #ffffff;}
//            body
//            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
//            html
//            {width: 100%; }
//            img 
//            {border:0px; outline:none; text-decoration:none; display:block; }
//            a
//            {text-decoration: none; text-transform: capitalize; line-height: 30px; color: #ffffff;}
//            a span
//            {text-decoration:none; color: #ffffff;}
//            h1 
//            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
//            h2 
//            {font-size: 18px; margin: 10px 0 10px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:uppercase;}
//            h3 
//            {font-size: 12px; margin: 5px 0 5px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
//            @media only screen and (max-width: 900px) 
//            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
//            @media only screen and (max-width: 640px)
//            { body{ width:auto!important; }
//            .BoxWrap { width:440px !important;}
//            .RespoHideMedium { display:none !important; } 
//            .RespoShowMedium { display:block !important; } 
//            .RespoCenterMedium { text-align:center !important; }
//            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
//            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
//            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
//            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
//            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
//            }
//            @media only screen and (max-width: 479px)
//            {
//            body{width:auto!important;}
//            .BoxWrap { width:280px !important;}
//            .RespoHideSmall { display:none !important; }
//            .RespoCenterSmall { text-align:center !important; }
//            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
//            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
//            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
//            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
//            }
//            .Bg_Color
//            {
//             background-color: #fefefe;
//            }
//            .BgImageAltColor
//            {
//            background-color: #3A5490;
//            }
//            .Preheader_Color
//            {
//            background-color: #f3f3f3;
//            }
//            .Content_Color
//            {
//             /*@editable*/ background-color: #ffffff;
//            }
//            .Color01_B
//            {
//             /*@editable background-color: #CE0000;*/
//            }
//            .Color01_D
//            {
//             /*@editable background-color: #000000;*/
//            }
//            .Color02_B
//            {
//             /*@editable*/ background-color: #E7E7EF;
//            } 
//            </style>
//            </head>
//            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
//            <tbody>
//            <tr>
//            <td valign=""top"" class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td class=""RespoHideSmall"" width=""100%"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
//            <tbody>
//            <tr>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td class=""BgImageAltColor"" bgcolor=""#3A5490"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;color: #ffffff;font-size: 18px;margin: 10px 0 10px 0;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Operadora Turística - Viajes Itzaa</h2>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""1"" class=""Bg_Color"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h1 style=""text-transform: uppercase;text-align: center;color: #ffffff;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;line-height: 40px;""><a href=""#"" style=""color: #ffffff;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;"">Gracias por elegirnos<br></a></h1>
//            <h3 style=""text-align: center;color: #c7c7c7;font-size: 12px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">La mejor experiencia para su viaje</h3>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""1"" class=""Bg_Color"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            if (!string.IsNullOrEmpty(Comentarios))
//            {
//                html = html + @"
//                <tr>
//                    <td style=""-webkit-text-size-adjust: none;"">
//                        <table width=""100%"" class=""Color02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"">
//                            <tbody>
//                                <tr>
//                                    <td style=""-webkit-text-size-adjust: none; line-height: 9px; text-transform: uppercase; margin-top: 5px;"">
//                                    <font color=""#000000"" face=""Microsoft Sans Serif"" size=""2"">
//                                        " + Comentarios + @"
//                                    </font>
//                                    </td>
//                                </tr>
//                            </tbody>
//                        </table>
//                     </td>
//                </tr>";
//            }

//            html = html + @"
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;"">
//            &nbsp; 
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""600"" class=""BoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" border=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""RespoImage_70ToOneW"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//			<img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""RespoImage_70ToOne"" alt="""" style=""width: 185px; height: 130px; display: block; border: 0px none; outline: medium none; text-decoration: none;"" border=""0"" height=""100"" width=""185""></a>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""Color01_B"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Mis datos</span></a></h3>
//            </td>
//            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#3A5490"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""" + dominio + @"/MiCuenta"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""391"" align=""left"" cellpadding=""30"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""331"" style=""-webkit-text-size-adjust: none;"">
//            <h1 style=""text-transform: uppercase;font-size: 15px;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + NombreCliente + @"</h1>
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Usuario: " + CorreoCliente + @"</h3>
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Contraseña: " + pass + @"</h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""401"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""RespoImage_OneToOneW"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img class=""RespoImage_OneToOne"" width=""401"" height=""401"" src="" " + dominio + @"" + datos.ImgProducto.Replace("~", "") + @" "" alt="""" border=""0"" style=""width: 401px;height: 401px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">" + datos.NombreProducto + @"</h2>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumDias.ToString() + @" días</h1>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumNoches.ToString() + @" noches</h1>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Color01_D"" bgcolor=""#8CBE3F"" cellpadding=""5"" cellspacing=""0"">
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Detalles cotización del paquete vip</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""20"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Llegada:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaLlegada + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Salida:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaSalida + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Categoria de Hotel:</h3>
//            </td> 
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align:right;text-transform:capitalize;font-size: 39px;color: #F7E82F;font-weight: 800;line-height: 0px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;margin-top: 15px;margin-bottom: 0px;"">" + numeroEstrellas + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Numero de personas:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + NumPersonas + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">HABITACIONES</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Adultos</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 4-11</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 0-4</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Camas</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Tipo de Habitación</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            foreach (Habitacion datosHab in datos.ListaHabitaciones)
//            {
//                string numAdultos = datosHab.NumAdultos.ToString();
//                string numMenores4 = datosHab.NumMenores4.ToString();
//                string numMenores11 = datosHab.NumMenores11.ToString();
//                string numCamas = datosHab.NumCamas.ToString();
//                string TipoHabitacion = datosHab.TipoHabitacion;
//                html = html + @"<tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//                <tbody>
//                <tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numAdultos + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores11 + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores4 + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numCamas + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + TipoHabitacion + @"</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//                </tr>";
//            }

//            html = html + @"
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">COSTOS</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Tipo de Habitación</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Adulto</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Niños 4-11</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Niños 0-4</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo de Habitación</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>";

//            foreach (Habitacion datosHab in datos.ListaHabitaciones)
//            {
//                string TipoHabitacion = datosHab.TipoHabitacion;
//                string costoAdulto = datosHab.CostoAdulto <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoAdulto);
//                string costoMenor4 = datosHab.CostoMenor4 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor4);
//                string costoMenor11 = datosHab.CostoMenor11 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor11);
//                string subtotal = string.Format("{0:c}", datosHab.Subtotal);

//                html = html + @"<td style=""-webkit-text-size-adjust: none; width:18%"">
//                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//                <tbody>
//                <tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + TipoHabitacion + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoAdulto + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoMenor11 + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoMenor4 + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + subtotal + @"</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//                </tr>";
//            }

//            html = html + @"
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">ITINERARIO</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Orden</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Lugar</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            foreach (LugarTuristico datosLugar in datos.ListaItinerario)
//            {
//                string Orden = datosLugar.Orden.ToString();
//                string Lugar = datosLugar.Lugar;
//                html = html + @"
//                <tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//                <tbody>
//                <tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + Orden + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + Lugar + @"</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//                </tr>";
//            }

//            html = html + @"
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Precio</h2>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">" + Monto + @"</h1>
//            </td>
//            </tr>";

//            html = html + @"
//            
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Para poder apartar el paquete se debe pagar el " + Anticipo + @"% del precio. El resto debe cubrirse al llegar a nuestras instalaciones. </h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""60"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""Color01_B"" bgcolor=""#3A5490"" style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href="""" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;""></span></a></h3>
//            </td>
//            <td width=""50"" align=""center"" class="""" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/details.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            tr>
//            <td width=""100%"" height=""60"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td valign=""top"" class=""Color01_D"" bgcolor=""#3A5490"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#3A5490"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. " + telefono + @"<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
//            <tbody>
//            <tr>
//            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
//            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#3A5490"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Chiapas</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Yucatan</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">QuintanaRoo</a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
//            <tbody>
//            <tr>
//            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
//            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#3A5490"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Tour</a><br><a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Transportación</a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @""" style=""text-decoration: none;color: #151516;-webkit-text-size-adjust: none;text-transform: capitalize;line-height: 30px;"">Operadora Turística Itzaa</a></h3>
//            </td>
//            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
//            <tbody>
//            <tr>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </body>
//            </html>
//            ";
//            return html;
//        }

//        public static string GenerarHtmlToursCotizado(Solicitud datos)
//        {
//            string _facebook = Comun.UrlFacebook;
//            string _twitter = Comun.UrlTwitter;
//            string _googleplus = Comun.UrlGoogle;
//            string correoItzaa = Comun.CorreoEmpresa;
//            string telefono = Comun.Telefono;
//            string pass = datos.Cliente != null ? (string.IsNullOrEmpty(datos.Cliente.Password) ? "*****" : datos.Cliente.Password) : "*****";
//            string Monto = string.Format("{0:c}", datos.Cotizacion != null ? datos.Cotizacion.Subtotal : 0);
//            string Comentarios = datos.Cotizacion != null ? datos.Cotizacion.Comentarios : string.Empty;
//            string FechaLlegada = datos.FechaLlegada.ToShortDateString() + " " + datos.HoraLlegada;
//            string FechaSalida = datos.FechaSalida.ToShortDateString() + " " + datos.HoraSalida;
//            string CorreoCliente = datos.Cliente != null ? datos.Cliente.CorreoElectronico : string.Empty;
//            string NombreCliente = datos.Cliente != null ? datos.Cliente.Nombre : string.Empty;
//            string NumPersonas = datos.NumTotalPersonas.ToString();
//            string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
//            string dominio = _dominio;
//            string numeroEstrellas = "";
//            for (int j = 0; j < Convert.ToInt32(datos.CategoriaHotel.ToString()); j++)
//            {
//                numeroEstrellas += "*";
//            }

//            string html = @"<html>
//            <head>
//            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
//            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
//            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
//            <title></title>
//            <style type=""text/css"">
//            div, p, a, li, td { -webkit-text-size-adjust:none; }
//            .ReadMsgBody
//            {width: 100%; background-color: #ffffff;}
//            .ExternalClass
//            {width: 100%; background-color: #ffffff;}
//            body
//            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
//            html
//            {width: 100%; }
//            img 
//            {border:0px; outline:none; text-decoration:none; display:block; }
//            a
//            {text-decoration: none; text-transform: capitalize; line-height: 30px; color: #ffffff;}
//            a span
//            {text-decoration:none; color: #ffffff;}
//            h1 
//            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
//            h2 
//            {font-size: 18px; margin: 10px 0 10px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:uppercase;}
//            h3 
//            {font-size: 12px; margin: 5px 0 5px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
//            @media only screen and (max-width: 900px) 
//            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
//            @media only screen and (max-width: 640px)
//            { body{ width:auto!important; }
//            .BoxWrap { width:440px !important;}
//            .RespoHideMedium { display:none !important; } 
//            .RespoShowMedium { display:block !important; } 
//            .RespoCenterMedium { text-align:center !important; }
//            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
//            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
//            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
//            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
//            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
//            }
//            @media only screen and (max-width: 479px)
//            {
//            body{width:auto!important;}
//            .BoxWrap { width:280px !important;}
//            .RespoHideSmall { display:none !important; }
//            .RespoCenterSmall { text-align:center !important; }
//            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
//            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
//            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
//            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
//            }
//            .Bg_Color
//            {
//             background-color: #fefefe;
//            }
//            .BgImageAltColor
//            {
//            background-color: #3A5490;
//            }
//            .Preheader_Color
//            {
//            background-color: #f3f3f3;
//            }
//            .Content_Color
//            {
//             /*@editable*/ background-color: #ffffff;
//            }
//            .Color01_B
//            {
//             /*@editable background-color: #CE0000;*/
//            }
//            .Color01_D
//            {
//             /*@editable background-color: #000000;*/
//            }
//            .Color02_B
//            {
//             /*@editable*/ background-color: #E7E7EF;
//            } 
//            </style>
//            </head>
//            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
//            <tbody>
//            <tr>
//            <td valign=""top"" class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td class=""RespoHideSmall"" width=""100%"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
//            <tbody>
//            <tr>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td class=""BgImageAltColor"" bgcolor=""#3A5490"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;color: #ffffff;font-size: 18px;margin: 10px 0 10px 0;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Operadora Turistica - Viajes Itzaa</h2>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""1"" class=""Bg_Color"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h1 style=""text-transform: uppercase;text-align: center;color: #ffffff;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;line-height: 40px;""><a href=""#"" style=""color: #ffffff;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;"">Gracias por elegirnos<br></a></h1>
//            <h3 style=""text-align: center;color: #c7c7c7;font-size: 12px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">La mejor experiencia para su viaje</h3>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""1"" class=""Bg_Color"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            if (!string.IsNullOrEmpty(Comentarios))
//            {
//                html = html + @"
//                <tr>
//                    <td style=""-webkit-text-size-adjust: none;"">
//                        <table width=""100%"" class=""Color02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"">
//                            <tbody>
//                                <tr>
//                                    <td style=""-webkit-text-size-adjust: none; line-height: 9px; text-transform: uppercase; margin-top: 5px;"">
//                                    <font color=""#000000"" face=""Microsoft Sans Serif"" size=""2"">
//                                        " + Comentarios + @"
//                                    </font>
//                                    </td>
//                                </tr>
//                            </tbody>
//                        </table>
//                     </td>
//                </tr>";
//            }

//            html = html + @"
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;"">
//            &nbsp; 
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""600"" class=""BoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" border=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""RespoImage_70ToOneW"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//			<img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""RespoImage_70ToOne"" alt="""" style=""width: 185px; height: 130px; display: block; border: 0px none; outline: medium none; text-decoration: none;"" border=""0"" height=""100"" width=""185""></a>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""Color01_B"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Mis datos</span></a></h3>
//            </td>
//            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#3A5490"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""" + dominio + @"/MiCuenta"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""391"" align=""left"" cellpadding=""30"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""331"" style=""-webkit-text-size-adjust: none;"">
//            <h1 style=""text-transform: uppercase;font-size: 15px;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + NombreCliente + @"</h1>
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Usuario: " + CorreoCliente + @"</h3>
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Contraseña: " + pass + @"</h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""401"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""RespoImage_OneToOneW"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img class=""RespoImage_OneToOne"" width=""401"" height=""401"" src="" " + dominio + @"" + datos.ImgProducto.Replace("~", "") + @" "" alt="""" border=""0"" style=""width: 401px;height: 401px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">" + datos.NombreProducto + @"</h2>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumDias.ToString() + @" días</h1>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumNoches.ToString() + @" noches</h1>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#3A5490"" cellpadding=""5"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/DetalleTour/?id=" + datos.IDProducto + @"&id_seccion=" + datos.IDSeccion + @" "" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Ver tour</span></a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Detalles cotización del tour</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""20"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Llegada:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaLlegada + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Salida:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaSalida + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Numero de personas:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + NumPersonas + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">";

//            html = html + @"
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">PERSONAS</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Adultos</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 4-11</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 0-4</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Total Personas</h2>
//            </td>            
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            foreach (Habitacion datosHab in datos.ListaHabitaciones)
//            {
//                string numAdultos = datosHab.NumAdultos.ToString();
//                string numMenores4 = datosHab.NumMenores4.ToString();
//                string numMenores11 = datosHab.NumMenores11.ToString();
//                string totalPersonas = (datosHab.NumAdultos + datosHab.NumMenores11 + datosHab.NumMenores4).ToString();
//                html = html + @"
//                <tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//                <tbody>
//                <tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numAdultos + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores11 + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores4 + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + totalPersonas + @"</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//                </tr>";
//            }

//            html = html + @"
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">COSTOS</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Adulto</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Niños 4-11</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Niños 0-4</h2>
//            </td>            
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            foreach (Habitacion datosHab in datos.ListaHabitaciones)
//            {
//                string costoAdulto = datosHab.CostoAdulto <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoAdulto);
//                string costoMenor4 = datosHab.CostoMenor4 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor4);
//                string costoMenor11 = datosHab.CostoMenor11 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor11);
//                html = html + @"
//                <tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//                <tbody>
//                <tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoAdulto + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoMenor11 + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoMenor4 + @"</h2>
//                </td>            
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//                </tr>";
//            }

//            html =  html + @"<tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">ITINERARIO</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Orden</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Lugar</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            foreach (LugarTuristico datosLugar in datos.ListaItinerario)
//            {
//                string Orden = datosLugar.Orden.ToString();
//                string Lugar = datosLugar.Lugar;

//                html = html + @"
//                <tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//                <tbody>
//                <tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + Orden + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + Lugar + @"</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//                </tr>";
//            }

//            html = html + @"<tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Precio</h2>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">" + Monto + @"</h1>
//            </td>
//            </tr>";

//            html = html + @"
//            
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Para poder apartar el tour se debe pagar el " + Anticipo + @"% del precio. El resto debe cubrirse al llegar a nuestras instalaciones. </h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""Color01_B"" bgcolor=""#3A5490"" style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href="""" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;""></span></a></h3>
//            </td>
//            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/details.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""60"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td valign=""top"" class=""Color01_D"" bgcolor=""#3A5490"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#3A5490"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. " + telefono + @"<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
//            <tbody>
//            <tr>
//            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
//            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#3A5490"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Chiapas</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Yucatan</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">QuintanaRoo</a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
//            <tbody>
//            <tr>
//            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
//            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#3A5490"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Tour</a><br><a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Transportación</a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @""" style=""text-decoration: none;color: #151516;-webkit-text-size-adjust: none;text-transform: capitalize;line-height: 30px;"">Operadora Turística Itzaa</a></h3>
//            </td>
//            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
//            <tbody>
//            <tr>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </body>
//            </html>
//            ";
//            return html;
//        }

//        public static string GenerarHtmlHotelesCotizado(Solicitud datos)
//        {
//            string _facebook = Comun.UrlFacebook;
//            string _twitter = Comun.UrlTwitter;
//            string _googleplus = Comun.UrlGoogle;
//            string correoItzaa = Comun.CorreoEmpresa;
//            string telefono = Comun.Telefono;
//            string pass = datos.Cliente != null ? (string.IsNullOrEmpty(datos.Cliente.Password) ? "*****" : datos.Cliente.Password) : "*****";
//            string Monto = string.Format("{0:c}", datos.Cotizacion != null ? datos.Cotizacion.Subtotal : 0);
//            string Comentarios = datos.Cotizacion != null ? datos.Cotizacion.Comentarios : string.Empty;
//            string FechaLlegada = datos.FechaLlegada.ToShortDateString() + " " + datos.HoraLlegada;
//            string FechaSalida = datos.FechaSalida.ToShortDateString() + " " + datos.HoraSalida;
//            string CorreoCliente = datos.Cliente != null ? datos.Cliente.CorreoElectronico : string.Empty;
//            string NombreCliente = datos.Cliente != null ? datos.Cliente.Nombre : string.Empty;
//            string NumPersonas = datos.NumTotalPersonas.ToString();
//            string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
//            string dominio = _dominio;
//            string numeroEstrellas = "";
//            for (int j = 0; j < Convert.ToInt32(datos.CategoriaHotel.ToString()); j++)
//            {
//                numeroEstrellas += "*";
//            }
//            string html = @"<html>
//            <head>
//            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
//            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
//            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
//            <title></title>
//            <style type=""text/css"">
//            div, p, a, li, td { -webkit-text-size-adjust:none; }
//            .ReadMsgBody
//            {width: 100%; background-color: #ffffff;}
//            .ExternalClass
//            {width: 100%; background-color: #ffffff;}
//            body
//            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
//            html
//            {width: 100%; }
//            img 
//            {border:0px; outline:none; text-decoration:none; display:block; }
//            a
//            {text-decoration: none; text-transform: capitalize; line-height: 30px; color: #ffffff;}
//            a span
//            {text-decoration:none; color: #ffffff;}
//            h1 
//            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
//            h2 
//            {font-size: 18px; margin: 10px 0 10px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:uppercase;}
//            h3 
//            {font-size: 12px; margin: 5px 0 5px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
//            @media only screen and (max-width: 900px) 
//            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
//            @media only screen and (max-width: 640px)
//            { body{ width:auto!important; }
//            .BoxWrap { width:440px !important;}
//            .RespoHideMedium { display:none !important; } 
//            .RespoShowMedium { display:block !important; } 
//            .RespoCenterMedium { text-align:center !important; }
//            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
//            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
//            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
//            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
//            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
//            }
//            @media only screen and (max-width: 479px)
//            {
//            body{width:auto!important;}
//            .BoxWrap { width:280px !important;}
//            .RespoHideSmall { display:none !important; }
//            .RespoCenterSmall { text-align:center !important; }
//            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
//            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
//            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
//            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
//            }
//            .Bg_Color
//            {
//             background-color: #fefefe;
//            }
//            .BgImageAltColor
//            {
//            background-color: #3A5490;
//            }
//            .Preheader_Color
//            {
//            background-color: #f3f3f3;
//            }
//            .Content_Color
//            {
//             /*@editable*/ background-color: #ffffff;
//            }
//            .Color01_B
//            {
//             /*@editable background-color: #CE0000;*/
//            }
//            .Color01_D
//            {
//             /*@editable background-color: #000000;*/
//            }
//            .Color02_B
//            {
//             /*@editable*/ background-color: #E7E7EF;
//            } 
//            </style>
//            </head>
//            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
//            <tbody>
//            <tr>
//            <td valign=""top"" class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td class=""RespoHideSmall"" width=""100%"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
//            <tbody>
//            <tr>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td class="""" bgcolor=""#3A5490"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;color: #ffffff;font-size: 18px;margin: 10px 0 10px 0;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Operadora Turistica - Viajes Itzaa</h2>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""1"" class="""" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h1 style=""text-transform: uppercase;text-align: center;color: #ffffff;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;line-height: 40px;""><a href=""#"" style=""color: #ffffff;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;"">Gracias por elegirnos<br></a></h1>
//            <h3 style=""text-align: center;color: #c7c7c7;font-size: 12px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">La mejor experiencia para su viaje</h3>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""1"" class="""" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            if (!string.IsNullOrEmpty(Comentarios))
//            {
//                html = html + @"
//                <tr>
//                    <td style=""-webkit-text-size-adjust: none;"">
//                        <table width=""100%"" class=""Color02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"">
//                            <tbody>
//                                <tr>
//                                    <td style=""-webkit-text-size-adjust: none; line-height: 9px; text-transform: uppercase; margin-top: 5px;"">
//                                    <font color=""#000000"" face=""Microsoft Sans Serif"" size=""2"">
//                                        " + Comentarios + @"
//                                    </font>
//                                    </td>
//                                </tr>
//                            </tbody>
//                        </table>
//                     </td>
//                </tr>";
//            }

//            html = html + @"
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;"">
//            &nbsp; 
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""600"" class=""BoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" border=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""RespoImage_70ToOneW"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//			<img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""RespoImage_70ToOne"" alt="""" style=""width: 185px; height: 130px; display: block; border: 0px none; outline: medium none; text-decoration: none;"" border=""0"" height=""100"" width=""185""></a>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""Color01_B"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Mis datos</span></a></h3>
//            </td>
//            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#3A5490"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""" + dominio + @"/MiCuenta"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""391"" align=""left"" cellpadding=""30"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""331"" style=""-webkit-text-size-adjust: none;"">
//            <h1 style=""text-transform: uppercase;font-size: 15px;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + NombreCliente + @"</h1>
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Usuario: " + CorreoCliente + @"</h3>
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Contraseña: " + pass + @"</h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""401"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""RespoImage_OneToOneW"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img class=""RespoImage_OneToOne"" width=""401"" height=""401"" src="" " + dominio + @"" + datos.ImgProducto.Replace("~", "") + @" "" alt="""" border=""0"" style=""width: 401px;height: 401px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">" + datos.NombreProducto + @"</h2>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumDias.ToString() + @" días</h1>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumNoches.ToString() + @" noches</h1>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Detalles cotización del hotel</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""20"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Llegada:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaLlegada + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Salida:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaSalida + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Categoria de Hotel:</h3>
//            </td> 
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align:right;text-transform:capitalize;font-size: 39px;color: #F7E82F;font-weight: 800;line-height: 0px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;margin-top: 15px;margin-bottom: 0px;"">" + numeroEstrellas + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Numero de personas:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + NumPersonas + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">HABITACIONES</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Adultos</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 4-11</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 0-4</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Camas</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Tipo de Habitación</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            foreach (Habitacion datosHab in datos.ListaHabitaciones)
//            {
//                string numAdultos = datosHab.NumAdultos.ToString();
//                string numMenores4 = datosHab.NumMenores4.ToString();
//                string numMenores11 = datosHab.NumMenores11.ToString();
//                string numCamas = datosHab.NumCamas.ToString();
//                string TipoHabitacion = datosHab.TipoHabitacion;            
//                html = html + @"<tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//                <tbody>
//                <tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numAdultos + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores11 + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numMenores4 + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numCamas + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + TipoHabitacion + @"</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//                </tr>";
//            }

//            html = html + @"
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">COSTOS</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Tipo de Habitación</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Adulto</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Niños 4-11</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo Niños 0-4</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Costo de Habitación</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            foreach (Habitacion datosHab in datos.ListaHabitaciones)
//            {
//                string TipoHabitacion = datosHab.TipoHabitacion;
//                string costoAdulto = datosHab.CostoAdulto <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoAdulto);
//                string costoMenor4 = datosHab.CostoMenor4 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor4);
//                string costoMenor11 = datosHab.CostoMenor11 <= 0 ? "(No aplica)" : string.Format("{0:c}", datosHab.CostoMenor11);
//                string subtotal = string.Format("{0:c}", datosHab.Subtotal);
//                html = html + @"
//                <tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//                <tbody>
//                <tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + TipoHabitacion + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoAdulto + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoMenor11 + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + costoMenor4 + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + subtotal + @"</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//                </tr>";
//            }

//            html = html + @"
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Precio</h2>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">" + Monto + @"</h1>
//            </td>
//            </tr>";

//            html = html + @"
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Para poder apartar el servicio de hotel se debe pagar el " + Anticipo + @"% del precio. El resto debe cubrirse al llegar a nuestras instalaciones. </h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""Color01_B"" bgcolor=""#3A5490"" style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href="""" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;""></span></a></h3>
//            </td>
//            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/details.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""60"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td valign=""top"" class=""Color01_D"" bgcolor=""#3A5490"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#3A5490"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. " + telefono + @"<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
//            <tbody>
//            <tr>
//            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
//            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#3A5490"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Chiapas</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Yucatan</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">QuintanaRoo</a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
//            <tbody>
//            <tr>
//            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
//            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#3A5490"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Tour</a><br><a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Transportación</a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""text-decoration: none;color: #151516;-webkit-text-size-adjust: none;text-transform: capitalize;line-height: 30px;"">Operadora Turística Itzaa</a></h3>
//            </td>
//            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
//            <tbody>
//            <tr>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </body>
//            </html>
//            ";
//            return html;
//        }

//        public static string GenerarHtmlTransportacionCotizado(Solicitud datos)
//        {
//            string _facebook = Comun.UrlFacebook;
//            string _twitter = Comun.UrlTwitter;
//            string _googleplus = Comun.UrlGoogle;
//            string correoItzaa = Comun.CorreoEmpresa;
//            string telefono = Comun.Telefono;
//            string pass = datos.Cliente != null ? (string.IsNullOrEmpty(datos.Cliente.Password) ? "*****" : datos.Cliente.Password) : "*****";
//            string Monto = string.Format("{0:c}", datos.Cotizacion != null ? datos.Cotizacion.Subtotal : 0);
//            string Comentarios = datos.Cotizacion != null ? datos.Cotizacion.Comentarios : string.Empty;
//            string FechaLlegada = datos.FechaLlegada.ToShortDateString() + " " + datos.HoraLlegada;
//            string FechaSalida = datos.FechaSalida.ToShortDateString() + " " + datos.HoraSalida;
//            string CorreoCliente = datos.Cliente != null ? datos.Cliente.CorreoElectronico : string.Empty;
//            string NombreCliente = datos.Cliente != null ? datos.Cliente.Nombre : string.Empty;
//            string NumPersonas = datos.NumTotalPersonas.ToString();
//            string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
//            string dominio = _dominio;

//            string html = @"<html>
//            <head>
//            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
//            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
//            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
//            <title></title>
//            <style type=""text/css"">
//            div, p, a, li, td { -webkit-text-size-adjust:none; }
//            .ReadMsgBody
//            {width: 100%; background-color: #ffffff;}
//            .ExternalClass
//            {width: 100%; background-color: #ffffff;}
//            body
//            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
//            html
//            {width: 100%; }
//            img 
//            {border:0px; outline:none; text-decoration:none; display:block; }
//            a
//            {text-decoration: none; text-transform: capitalize; line-height: 30px; color: #ffffff;}
//            a span
//            {text-decoration:none; color: #ffffff;}
//            h1 
//            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
//            h2 
//            {font-size: 18px; margin: 10px 0 10px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:uppercase;}
//            h3 
//            {font-size: 12px; margin: 5px 0 5px 0; color: #000; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
//            @media only screen and (max-width: 900px) 
//            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
//            @media only screen and (max-width: 640px)
//            { body{ width:auto!important; }
//            .BoxWrap { width:440px !important;}
//            .RespoHideMedium { display:none !important; } 
//            .RespoShowMedium { display:block !important; } 
//            .RespoCenterMedium { text-align:center !important; }
//            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
//            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
//            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
//            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
//            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
//            }
//            @media only screen and (max-width: 479px)
//            {
//            body{width:auto!important;}
//            .BoxWrap { width:280px !important;}
//            .RespoHideSmall { display:none !important; }
//            .RespoCenterSmall { text-align:center !important; }
//            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
//            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
//            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
//            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
//            }
//            .Bg_Color
//            {
//             background-color: #fefefe;
//            }
//            .BgImageAltColor
//            {
//            background-color: #3A5490;
//            }
//            .Preheader_Color
//            {
//            background-color: #f3f3f3;
//            }
//            .Content_Color
//            {
//             /*@editable*/ background-color: #ffffff;
//            }
//            .Color01_B
//            {
//             /*@editable background-color: #CE0000;*/
//            }
//            .Color01_D
//            {
//             /*@editable background-color: #000000;*/
//            }
//            .Color02_B
//            {
//             /*@editable*/ background-color: #E7E7EF;
//            } 
//            </style>
//            </head>
//            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
//            <tbody>
//            <tr>
//            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td class=""RespoHideSmall"" width=""100%"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
//            <tbody>
//            <tr>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td class="""" bgcolor=""#3A5490"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;color: #ffffff;font-size: 18px;margin: 10px 0 10px 0;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Operadora Turistica - Viajes Itzaa</h2>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""1"" class="""" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h1 style=""text-transform: uppercase;text-align: center;color: #ffffff;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;line-height: 40px;""><a href=""#"" style=""color: #ffffff;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;"">Gracias por elegirnos<br></a></h1>
//            <h3 style=""text-align: center;color: #c7c7c7;font-size: 12px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">La mejor experiencia para su viaje</h3>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""1"" class="""" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            if (!string.IsNullOrEmpty(Comentarios))
//            {
//                html = html + @"
//                <tr>
//                    <td style=""-webkit-text-size-adjust: none;"">
//                        <table width=""100%"" class=""Color02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"">
//                            <tbody>
//                                <tr>
//                                    <td style=""-webkit-text-size-adjust: none; line-height: 9px; text-transform: uppercase; margin-top: 5px;"">
//                                    <font color=""#000000"" face=""Microsoft Sans Serif"" size=""2"">
//                                        " + Comentarios + @"
//                                    </font>
//                                    </td>
//                                </tr>
//                            </tbody>
//                        </table>
//                     </td>
//                </tr>";
//            }

//            html = html + @"
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;"">
//            &nbsp; 
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""600"" class=""BoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" border=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""RespoImage_70ToOneW"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//			<img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""RespoImage_70ToOne"" alt="""" style=""width: 185px; height: 130px; display: block; border: 0px none; outline: medium none; text-decoration: none;"" border=""0"" height=""100"" width=""185""></a>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""Color01_B"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Mis datos</span></a></h3>
//            </td>
//            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#3A5490"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""" + dominio + @"/MiCuenta"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""391"" align=""left"" cellpadding=""30"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""331"" style=""-webkit-text-size-adjust: none;"">
//            <h1 style=""text-transform: uppercase;font-size: 15px;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + NombreCliente + @"</h1>
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Usuario: " + CorreoCliente + @"</h3>
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Contraseña: " + pass + @"</h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""401"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""RespoImage_OneToOneW"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img class=""RespoImage_OneToOne"" width=""401"" height=""401"" src="" " + dominio + @"" + datos.ImgProducto.Replace("~", "") + @" "" alt="""" border=""0"" style=""width: 401px;height: 401px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">" + datos.NombreProducto + @"</h2>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumDias.ToString() + @" días</h1>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumNoches.ToString() + @" noches</h1>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Detalles cotización de la transportación</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#8CBE3F"" cellpadding=""20"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Llegada:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaLlegada + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Salida:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaSalida + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Numero de personas:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + NumPersonas + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">";

//            html = html + @"<tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #000;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Precio</h2>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">" + Monto + @"</h1>
//            </td>
//            </tr>";
//            html = html + @"
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class="""" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #000;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Para poder apartar el servicio de transportación se debe pagar el " + Anticipo + @"% del precio. El resto debe cubrirse al llegar a nuestras instalaciones. </h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""60"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""Color01_B"" bgcolor=""#3A5490"" style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #000;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href="""" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;""></span></a></h3>
//            </td>
//            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#8CBE3F"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/details.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""60"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td valign=""top"" class=""Color01_D"" bgcolor=""#3A5490"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#3A5490"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. " + telefono + @"<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
//            <tbody>
//            <tr>
//            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
//            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#3A5490"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Chiapas</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Yucatan</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">QuintanaRoo</a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
//            <tbody>
//            <tr>
//            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
//            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#3A5490"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Tour</a><br><a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Transportación</a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" class="""" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #000;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""text-decoration: none;color: #151516;-webkit-text-size-adjust: none;text-transform: capitalize;line-height: 30px;"">Operadora Turística Itzaa</a></h3>
//            </td>
//            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
//            <tbody>
//            <tr>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </body>
//            </html>
//            ";
//            return html;

//        }
//    }
//}

//        static string _dominio = Comun.Dominio;

//        public static string GenerarHtmlCancelacion(Solicitud Datos)
//        {
//            try
//            {
//                string dominio = _dominio;
//                string html = "";
//                string Estatus = Datos.EstatusSolicitud;
//                string MotivoCancelacion = Datos.MotivoCancelacion;
//                string Producto = Datos.NombreProducto;
//                string Total = string.Format("{0:c}", Datos.Pago != null ? Datos.Pago.MontoTotal : 0);
//                string Correo = Datos.Cliente != null ? Datos.Cliente.CorreoElectronico : string.Empty;
//                string MontoPenalizacion = string.Format("{0:c}", Datos.MontoPenalizacion);
//                string _facebook = Comun.UrlFacebook;
//                string _twitter = Comun.UrlTwitter;
//                string _googleplus = Comun.UrlGoogle;
//                string correoItzaa = Comun.CorreoEmpresa;
//                string telefono = Comun.Telefono;
//                html = @"
//                <html><head></head><body><br><div><br>
//<title></title>
//<style></style>
//<table class=""ecxBg_Color"" align=""center"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td class=""ecxPreheader_Color"" style="""" bgcolor=""#f3f3f3"" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""" align=""center"" width=""191""><a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" style=""width:191px;height:50px;max-width:191px;max-height:50px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""191"" height=""50"">
//</a></td>
//<td class=""ecxRespoHideSmall"" style="""" width=""100%""></td>
//</tr>
//</tbody>
//</table>
//</td>
//<td class=""ecxRespoHideSmall"" style="""" width=""150"">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table align=""right"" cellpadding=""0"" cellspacing=""0"">
//<tbody>
//<tr>
//<td style="""" align=""right"" width=""50""><a href=""" + _facebook + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src="""+ dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//<td style="""" align=""right"" width=""50""><a href=""" + _twitter + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//<td style="""" align=""right"" width=""50""><a href=""" + _googleplus + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" height=""20""></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td class=""ecxBgImageAltColor"" style="""" bgcolor=""#000000"">
//<table style=""clear:both;"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table align=""center"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h2 style=""text-align:center;color:#ffffff;font-size:18px;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Operadora Turística - Viajes Itzaa</h2>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td class=""ecxBg_Color"" style="""" bgcolor=""#fefefe"" width=""100%"" height=""1"">
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""10""></td>
//</tr>
//<tr>
//<td style="""">
//<h1 style=""text-transform:uppercase;text-align:center;color:#ffffff;font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;line-height:40px;"">
//<a href=""#"" style=""color:#ffffff;text-decoration:none;text-transform:capitalize;line-height:30px;"">Gracias por elegirnos<br>
//</a></h1>
//<h3 style=""text-align:center;color:#c7c7c7;font-size:12px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//La mejor experiencia para su viaje</h3>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td class=""ecxBg_Color"" style="""" bgcolor=""#fefefe"" width=""100%"" height=""1"">
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxColor02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h1 style=""text-align:center;text-transform:uppercase;font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;line-height:40px;"">
//<a href=""#"" style=""text-transform:uppercase;text-decoration:none;color:#151516;line-height:30px;"">CANCELACIÓN DE SOLICITUD</a></h1>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>.
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" valign=""top"" height=""40"">&nbsp; </td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxContent_Color"" bgcolor=""#ffffff"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//<tbody>
//<tr>
//<td class=""ecxRespoImage_70ToOneW"" style=""""><a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""ecxRespoImage_70ToOne"" alt="""" style=""width:185px;height:130px;display:block;border:0px none;text-decoration:none;"" border=""0"" width=""185"" height=""100""></a>
//</td>
//</tr>
//<tr>
//<td style="""">
//<table cellpadding=""7"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td class=""ecxColor01_B"" style="""" bgcolor=""#CE0000"">
//<h3 style=""text-align:center;font-size:12px;color:#808185;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href=""" + dominio + @"/MiCuenta"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><span style=""text-decoration:none;color:#ffffff;"">Mis datos</span></a></h3>
//</td>
//<td class=""ecxColor01_D"" style="""" align=""center"" bgcolor=""#000000"" width=""50"">
//<a href=""" + dominio + @"/MiCuenta"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" style=""width:32px;height:32px;max-width:32px;max-height:32px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""32"" height=""32"">
//</a></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""30"" cellspacing=""0"" width=""391"">
//<tbody>
//<tr>
//<td style="""" width=""331"">
//<h1 style=""text-transform:uppercase;font-size:15px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;text-align:left;line-height:40px;"">
//Nombre del usuario</h1>
//<h3 style=""font-size:12px;color:#808185;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Usuario: " + Correo + @"</h3>
//<h3 style=""font-size:12px;color:#808185;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Contraseña: *****</h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxPreheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h2 style=""text-align:center;font-size:18px;color:#808185;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Detalles</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxPreheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""20"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table cellpadding=""7"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td class=""ecxColor01_B"" style="""" bgcolor=""#CE0000"">
//<h3 style=""text-align:center;font-size:12px;color:#808185;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;""></h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style=""width:50%"">
//<h2 style=""text-align:center;text-transform:capitalize;font-size:18px;color:#808185;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//Motivo</h2>
//</td>
//<td style=""width:50%"">
//<h2 style=""text-align:center;font-size:18px;color:#808185;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//" + Estatus + @"</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style=""width:100%"">
//<p style=""text-align:justify;font-size:16px;color:#808185;font-weight:normal;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//" + MotivoCancelacion + @"</p>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//
//<tr>
//<td style="""">
//<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""text-align:left;font-size:12px;color:#808185;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Paquete o Servicio:</h3>
//</td>
//<td style="""">
//<h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#808185;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//" + Producto + @"</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""text-align:left;font-size:12px;color:#808185;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Monto del paquete o servicio</h3>
//</td>
//<td style="""">
//<h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#808185;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//" + Total + @"</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""text-align:left;font-size:12px;color:#808185;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Monto de Penalización:</h3>
//</td>
//<td style="""">
//<h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#808185;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//" + MontoPenalizacion + @"</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//<tr>
//<td style="""">
//<table cellpadding=""7"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td class=""ecxColor01_B"" style="""" bgcolor=""#000000"">
//<h3 style=""text-align:center;font-size:12px;color:#808185;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href=""https://"" style=""text-decoration:none;line-height:30px;color:#ffffff;"" target=""_blank""><span style=""text-decoration:none;color:#ffffff;"">Nos ponemos a sus órdenes en el momento que desee volver a contar con alguno de nuestros servicios. Recuerde visitar www.viajesitzaa.com y encontrar novedades de viaje.</span></a></h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""60""></td>
//</tr>
//<tr>
//<td class=""ecxColor01_D"" style="""" bgcolor=""#000000"" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxColor01_D"" bgcolor=""#000000"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Datos de contacto:</h2>
//<h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Tel. "+ telefono + @"<br>
//<a href=""#"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"">Email. " + correoItzaa + @"</a></h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
//<tbody>
//<tr>
//<td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
//<p style=""padding-left:20px;"">&nbsp;</p>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxColor01_D"" bgcolor=""#000000"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Paquetes:</h2>
//<h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Chiapas</a><br>
//<a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Yucatan</a><br>
//<a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">QuintanaRoo</a></h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
//<tbody>
//<tr>
//<td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
//<p style=""padding-left:20px;"">&nbsp;</p>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxBoxWrap"" align=""right"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxColor01_D"" bgcolor=""#000000"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Servicios:</h2>
//<h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Tour</a><br>
//<a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Transportación</a>
//</h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td class=""ecxPreheader_Color"" style="""" bgcolor=""#f3f3f3"" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""font-size:12px;color:#808185;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href="""+ dominio + @""" style=""text-decoration:none;color:#151516;text-transform:capitalize;line-height:30px;"">Operadora Turística Itzaa</a></h3>
//</td>
//<td class=""ecxRespoHideSmall"" style="""" width=""150"">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table align=""right"" cellpadding=""0"" cellspacing=""0"">
//<tbody>
//<tr>
//<td style="""" align=""right"" width=""50""><a href=""" + _facebook + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//<td style="""" align=""right"" width=""50""><a href=""" + _twitter + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//<td style="""" align=""right"" width=""50""><a href=""" + _googleplus + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" height=""20""></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table></div></body></html>";
//                return html;
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }

//        public static string GenerarHtmlOrdenPago(Solicitud Datos)
//        {
//            try
//            {
//                string dominio = _dominio;
//                string html = "";
//                string linkPago = Datos.OrdenPago != null ? Datos.OrdenPago.LinkPago : string.Empty;
//                string Total = string.Format("{0:c}", Datos.OrdenPago != null ? Datos.OrdenPago.Pago : 0);
//                string NombreOrdenPago = Datos.OrdenPago != null ? Datos.OrdenPago.NombrePago : string.Empty;
//                string Descripcion = Datos.OrdenPago != null ? Datos.OrdenPago.DescripcionPago : string.Empty;
//                string Correo = Datos.Cliente != null ? Datos.Cliente.CorreoElectronico : string.Empty;
//                string _facebook = Comun.UrlFacebook;
//                string _twitter = Comun.UrlTwitter;
//                string _googleplus = Comun.UrlGoogle;
//                string correoItzaa = Comun.CorreoEmpresa;
//                string telefono = Comun.Telefono;
//                html = @"
//<html><head></head><body><br><div><br><title></title>
//<style></style>
//<table class=""ecxBg_Color"" align=""center"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td class=""ecxPreheader_Color"" style="""" bgcolor=""#f3f3f3"" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""" align=""center"" width=""191""><a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" style=""width:191px;height:50px;max-width:191px;max-height:50px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""191"" height=""50"">
//</a></td>
//<td class=""ecxRespoHideSmall"" style="""" width=""100%""></td>
//</tr>
//</tbody>
//</table>
//</td>
//<td class=""ecxRespoHideSmall"" style="""" width=""150"">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table align=""right"" cellpadding=""0"" cellspacing=""0"">
//<tbody>
//<tr>
//<td style="""" align=""right"" width=""50""><a href=""" + _facebook + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//<td style="""" align=""right"" width=""50""><a href=""" + _twitter + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//<td style="""" align=""right"" width=""50""><a href=""" + _googleplus + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" height=""20""></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td class=""ecxBgImageAltColor"" style="""" bgcolor=""#000000"">
//<table style=""clear:both;"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table align=""center"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h2 style=""text-align:center;color:#ffffff;font-size:18px;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Operadora Turistica - ViajesItzaa</h2>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td class=""ecxBg_Color"" style="""" bgcolor=""#fefefe"" width=""100%"" height=""1"">
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""10""></td>
//</tr>
//<tr>
//<td style="""">
//<h1 style=""text-transform:uppercase;text-align:center;color:#ffffff;font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;line-height:40px;"">
//<a href=""#"" style=""color:#ffffff;text-decoration:none;text-transform:capitalize;line-height:30px;"">Gracias por elegirnos<br>
//</a></h1>
//<h3 style=""text-align:center;color:#c7c7c7;font-size:12px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//La mejor experiencia para su viaje</h3>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td class=""ecxBg_Color"" style="""" bgcolor=""#fefefe"" width=""100%"" height=""1"">
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxColor02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h1 style=""text-align:center;text-transform:uppercase;font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;line-height:40px;"">
//<a href=""#"" style=""text-transform:uppercase;text-decoration:none;color:#151516;line-height:30px;"">Orden de Pago Paypal</a></h1>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" valign=""top"" height=""40"">&nbsp; </td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxContent_Color"" bgcolor=""#ffffff"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//<tbody>
//<tr>
//<td class=""ecxRespoImage_70ToOneW"" style=""""><a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""ecxRespoImage_70ToOne"" alt="""" style=""width:185px;height:130px;display:block;border:0px none;text-decoration:none;"" border=""0"" width=""185"" height=""100""></a>
//</td>
//</tr>
//<tr>
//<td style="""">
//<table cellpadding=""7"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td class=""ecxColor01_B"" style="""" bgcolor=""#CE0000"">
//<h3 style=""text-align:center;font-size:12px;color:#808185;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href=""" + dominio + @"/MiCuenta"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><span style=""text-decoration:none;color:#ffffff;"">Mis datos</span></a></h3>
//</td>
//<td class=""ecxColor01_D"" style="""" align=""center"" bgcolor=""#000000"" width=""50"">
//<a href=""" + dominio + @"/MiCuenta"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" style=""width:32px;height:32px;max-width:32px;max-height:32px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""32"" height=""32"">
//</a></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""30"" cellspacing=""0"" width=""391"">
//<tbody>
//<tr>
//<td style="""" width=""331"">
//<h1 style=""text-transform:uppercase;font-size:15px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;text-align:left;line-height:40px;"">
//</h1>
//<h3 style=""font-size:12px;color:#808185;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Usuario: " + Correo + @"</h3>
//<h3 style=""font-size:12px;color:#808185;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Contraseña: *****</h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//
//<tr>
//<td style="""" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""" width=""100%"" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxPreheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h2 style=""text-align:center;font-size:18px;color:#808185;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Detalle de la orden de pago</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxPreheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""20"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""text-align:left;font-size:12px;color:#808185;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Nombre del pago:</h3>
//</td>
//<td style="""">
//<h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#808185;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//" + NombreOrdenPago + @"</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//<tr>
//<td style="""">
//<table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""text-align:left;font-size:12px;color:#808185;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Descripción:</h3>
//</td>
//<td style="""">
//<h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#808185;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//" + Descripcion + @"</h2>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""2""></td>
//</tr>
//
//<tr>
//<td style="""">
//<h2 style=""font-size:18px;color:#808185;text-align:right;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Pagar</h2>
//</tr>
//<tr>
//<td>
//<table cellpadding=""7"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td bgcolor=""#CE0000"">
//<h3 style=""text-align:center;font-size:12px;color:#808185;font-weight:normal;font-family:Helvetica,Arial,sans-serif;line-height:18px"">
//<a href=""#"+ linkPago + @""" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff""><span style=""text-decoration:none;color:#ffffff"">Pagar</span></a></h3>
//</td>
//<td align=""center"" bgcolor=""#000000"" width=""50"">
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" width=""100%"" height=""60""></td>
//</tr>
//<tr>
//<td class=""ecxColor01_D"" style="""" bgcolor=""#000000"" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxColor01_D"" bgcolor=""#000000"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Datos de contacto:</h2>
//<h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//Tel. (961) 212 7414<br>
//<a href=""#"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"">Email. ventas@viajesitzaa.com</a></h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
//<tbody>
//<tr>
//<td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
//<p style=""padding-left:20px;"">&nbsp;</p>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxColor01_D"" bgcolor=""#000000"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Paquetes:</h2>
//<h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Chiapas</a><br>
//<a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Yucatan</a><br>
//<a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">QuintanaRoo</a></h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
//<tbody>
//<tr>
//<td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
//<p style=""padding-left:20px;"">&nbsp;</p>
//</td>
//</tr>
//</tbody>
//</table>
//<table class=""ecxBoxWrap"" align=""right"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//<tbody>
//<tr>
//<td style="""">
//<table class=""ecxColor01_D"" bgcolor=""#000000"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//Servicios:</h2>
//<h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Tour</a><br>
//<a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Transportaci&oacuten</a>
//</h3>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td class=""ecxPreheader_Color"" style="""" bgcolor=""#f3f3f3"" valign=""top"">
//<table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//<tbody>
//<tr>
//<td style="""" height=""20""></td>
//</tr>
//<tr>
//<td style="""">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<h3 style=""font-size:12px;color:#808185;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//<a href=""#"" style=""text-decoration:none;color:#151516;text-transform:capitalize;line-height:30px;"">Operadora Tur&iacutestica Itzaa</a></h3>
//</td>
//<td class=""ecxRespoHideSmall"" style="""" width=""150"">
//<table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//<tbody>
//<tr>
//<td style="""">
//<table align=""right"" cellpadding=""0"" cellspacing=""0"">
//<tbody>
//<tr>
//<td style="""" align=""right"" width=""50""><a href=""" + _facebook + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//<td style="""" align=""right"" width=""50""><a href=""" + _twitter + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//<td style="""" align=""right"" width=""50""><a href=""" + _googleplus + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//</a></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//<tr>
//<td style="""" height=""20""></td>
//</tr>
//</tbody>
//</table>
//</td>
//</tr>
//</tbody>
//</table></div></body></html>
//                    ";
//                return html;
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }

//        public static string GenerarHtmlConfirmacionCompra(Solicitud Datos)
//        {            
//            try
//            {
//                string dominio = _dominio;
//                string correoCliente = Datos.Cliente != null ? Datos.Cliente.CorreoElectronico : string.Empty;
//                string nombrePaquete = Datos.NombreProducto;
//                string Folio = Datos.Folio;
//                string FechaLimInicial = Datos.FechaLimPagoInicial.ToShortDateString();
//                string FechaLimFinal = Datos.FechaLimPagoFinal.ToShortDateString();
//                string MontoTotal = string.Format("{0:c}", Datos.MontoPagado);
//                string MontoInicial = string.Format("{0:c}", Datos.MontoInicial);
//                string MotivoMontoInicial = Datos.MotivoMontoInicial;

//                string _facebook = Comun.UrlFacebook;
//                string _twitter = Comun.UrlTwitter;
//                string _googleplus = Comun.UrlGoogle;
//                string correoItzaa = Comun.CorreoEmpresa;
//                string telefono = Comun.Telefono;

//                string html = @"
//                <html> 
//                    <head> </head>
//                    <body>
//                        <table>
//                            <tr>
//                                <td>Fecha Lím. de Pago Inicial</td>
//                                <td>Fecha Lím. de Pago Final</td>
//                            </tr>
//                            <tr>
//                                <td>" + FechaLimInicial + @"</td>
//                                <td>" + FechaLimFinal + @"</td>
//                            </tr>
//                        </table>
//                    </body>
//                </html>
//                ";
//                return html;
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }

//        public static string GenerarHtmlConfirmacionPago(Solicitud Datos)
//        {
//            try
//            {
//                string dominio = _dominio;
//                string correoCliente = Datos.Cliente != null ? Datos.Cliente.CorreoElectronico : string.Empty;
//                string fechaPago = Datos.Pago != null ? Datos.Pago.FechaPago.ToShortDateString() : string.Empty;
//                string monto = string.Format("{0:c}", Datos.Pago != null ? Datos.Pago.MontoPagado : 0);
//                string nombrePaquete = Datos.NombreProducto;

//                string _facebook = Comun.UrlFacebook;
//                string _twitter = Comun.UrlTwitter;
//                string _googleplus = Comun.UrlGoogle;
//                string correoItzaa = Comun.CorreoEmpresa;
//                string telefono = Comun.Telefono;

//                string html = @"
//                <html>
//                <head>
//                <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
//                <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
//                <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
//                </head>
//                <body><br><div><br>
//                <title></title>
//                <style></style>
//                <table class=""ecxBg_Color"" align=""center"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td class=""ecxPreheader_Color"" style="""" bgcolor=""#f3f3f3"" valign=""top"">
//                <table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//                <tbody>
//                <tr>
//                <td style="""" height=""20""></td>
//                </tr>
//                <tr>
//                <td style="""">
//                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""" align=""center"" width=""191""><a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" style=""width:191px;height:50px;max-width:191px;max-height:50px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""191"" height=""50"">
//                </a></td>
//                <td class=""ecxRespoHideSmall"" style="""" width=""100%""></td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                <td class=""ecxRespoHideSmall"" style="""" width=""150"">
//                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table align=""right"" cellpadding=""0"" cellspacing=""0"">
//                <tbody>
//                <tr>
//                <td style="""" align=""right"" width=""50""><a href=""" + _facebook + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//                </a></td>
//                <td style="""" align=""right"" width=""50""><a href=""" + _twitter + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//                </a></td>
//                <td style="""" align=""right"" width=""50""><a href=""" + _googleplus + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//                </a></td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td style="""" height=""20""></td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td class=""ecxBgImageAltColor"" style="""" bgcolor=""#000000"">
//                <table style=""clear:both;"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table align=""center"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""" valign=""top"">
//                <table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//                <tbody>
//                <tr>
//                <td style="""" width=""100%"" height=""20""></td>
//                </tr>
//                <tr>
//                <td style="""">
//                <table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <h2 style=""text-align:center;color:#ffffff;font-size:18px;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//                Operadora Turística - Viajes Itzaa</h2>
//                </td>
//                </tr>
//                <tr>
//                <td style="""" width=""100%"" height=""20""></td>
//                </tr>
//                <tr>
//                <td class=""ecxBg_Color"" style="""" bgcolor=""#fefefe"" width=""100%"" height=""1"">
//                </td>
//                </tr>
//                <tr>
//                <td style="""" width=""100%"" height=""10""></td>
//                </tr>
//                <tr>
//                <td style="""">
//                <h1 style=""text-transform:uppercase;text-align:center;color:#ffffff;font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;line-height:40px;"">
//                <a href=""#"" style=""color:#ffffff;text-decoration:none;text-transform:capitalize;line-height:30px;"">Gracias por elegirnos<br>
//                </a></h1>
//                <h3 style=""text-align:center;color:#c7c7c7;font-size:12px;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                La mejor experiencia para su viaje</h3>
//                </td>
//                </tr>
//                <tr>
//                <td style="""" width=""100%"" height=""20""></td>
//                </tr>
//                <tr>
//                <td class=""ecxBg_Color"" style="""" bgcolor=""#fefefe"" width=""100%"" height=""1"">
//                </td>
//                </tr>
//                <tr>
//                <td style="""" width=""100%"" height=""20""></td>
//                </tr>
//                <tr>
//                <td style="""">
//                <table class=""ecxColor02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <h1 style=""text-align:center;text-transform:uppercase;font-size:30px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;line-height:40px;"">
//                <a href=""#"" style=""text-transform:uppercase;text-decoration:none;color:#151516;line-height:30px;"">Agradecemos la realización de su pago.</a></h1>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>.
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td style="""" valign=""top"" height=""40"">&nbsp; </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td style="""" valign=""top"">
//                <table class=""ecxBoxWrap"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""" width=""100%"" height=""20""></td>
//                </tr>
//                </tbody>
//                </table>
//                <table class=""ecxContent_Color"" bgcolor=""#ffffff"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//                <tbody>
//                <tr>
//                <td class=""ecxRespoImage_70ToOneW"" style=""""><a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""ecxRespoImage_70ToOne"" alt="""" style=""width:185px;height:130px;display:block;border:0px none;text-decoration:none;"" border=""0"" width=""185"" height=""100""></a>
//                </td>
//                </tr>
//                <tr>
//                <td style="""">
//                <table cellpadding=""7"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td class=""ecxColor01_B"" style="""" bgcolor=""#CE0000"">
//                <h3 style=""text-align:center;font-size:12px;color:#808185;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                <a href=""" + dominio + @"/MiCuenta"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><span style=""text-decoration:none;color:#ffffff;"">Mis datos</span></a></h3>
//                </td>
//                <td class=""ecxColor01_D"" style="""" align=""center"" bgcolor=""#000000"" width=""50"">
//                <a href=""" + dominio + @"/MiCuenta"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" style=""width:32px;height:32px;max-width:32px;max-height:32px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""32"" height=""32"">
//                </a></td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                <table class=""ecxBoxWrap"" align=""left"" cellpadding=""30"" cellspacing=""0"" width=""391"">
//                <tbody>
//                <tr>
//                <td style="""" width=""331"">
//                <h1 style=""text-transform:uppercase;font-size:15px;font-family:Helvetica, Arial, sans-serif;font-weight:normal;font-style:normal;color:#151516;text-align:left;line-height:40px;"">
//                Nombre del usuario</h1>
//                <h3 style=""font-size:12px;color:#808185;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                Usuario: " + correoCliente + @"</h3>
//                <h3 style=""font-size:12px;color:#808185;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                Contraseña: *****</h3>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//
//                <tr>
//                <td style="""" valign=""top"">
//                <table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//                <tbody>
//                <tr>
//                <td style="""" width=""100%"" height=""20""></td>
//                </tr>
//                <tr>
//                <td style="""">
//                <table class=""ecxPreheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <h2 style=""text-align:center;font-size:18px;color:#808185;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//                Detalles de la compra</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td style="""">
//                <table class=""ecxPreheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""20"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <h3 style=""text-align:left;font-size:12px;color:#808185;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                Paquete o Servicio:</h3>
//                </td>
//                <td style="""">
//                <h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#808185;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//                " + nombrePaquete + @"</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td style="""" width=""100%"" height=""2""></td>
//                </tr>
//                <tr>
//                <td style="""">
//                <table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <h3 style=""text-align:left;font-size:12px;color:#808185;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                Fecha de aprobación del pago:</h3>
//                </td>
//                <td style="""">
//                <h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#808185;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//                " + fechaPago + @"</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td style="""" width=""100%"" height=""2""></td>
//                </tr>
//                <tr>
//                <td style="""">
//                <table class=""ecxBg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <h3 style=""text-align:left;font-size:12px;color:#808185;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                Monto del pago:</h3>
//                </td>
//                <td style="""">
//                <h2 style=""text-align:right;text-transform:capitalize;font-size:18px;color:#808185;font-weight:normal;line-height:22px;text-decoration:none;font-family:Helvetica, Arial, sans-serif;"">
//                " + monto + @"</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//
//                <tr>
//                <td style="""" width=""100%"" height=""2""></td>
//                </tr>
//
//
//                <tr>
//                <td style="""">
//                <table cellpadding=""7"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td class=""ecxColor01_B"" style="""" bgcolor=""#CE0000"">
//                <h3 style=""text-align:center;font-size:12px;color:#808185;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                <a href=""https://"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank""><span style=""text-decoration:none;color:#ffffff;"">Políticas y condiciones del servicio</span></a></h3>
//                </td>
//                <td class=""ecxColor01_D"" style="""" align=""center"" bgcolor=""#000000"" width=""50"">
//                <a href=""#"" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/details.png"" alt="""" style=""width:32px;height:32px;max-width:32px;max-height:32px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""32"" height=""32"">
//                </a></td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//
//                <tr>
//                <td style="""" width=""100%"" height=""2""></td>
//                </tr>
//
//
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td style="""" width=""100%"" height=""60""></td>
//                </tr>
//                <tr>
//                <td class=""ecxColor01_D"" style="""" bgcolor=""#000000"" valign=""top"">
//                <table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table class=""ecxColor01_D"" bgcolor=""#000000"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//                Datos de contacto:</h2>
//                <h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                Tel. (961) 212 7414<br>
//                <a href=""#"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"">Email. " + correoItzaa + @"</a></h3>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                <table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
//                <tbody>
//                <tr>
//                <td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
//                <p style=""padding-left:20px;"">&nbsp;</p>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                <table class=""ecxBoxWrap"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table class=""ecxColor01_D"" bgcolor=""#000000"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//                Paquetes:</h2>
//                <h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                <a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Chiapas</a><br>
//                <a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Yucatan</a><br>
//                <a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">QuintanaRoo</a></h3>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                <table class=""ecxRespoHideMedium"" style=""font-size:0;line-height:0;border-collapse:collapse;"" align=""left"" cellpadding=""0"" cellspacing=""0"" width=""0"">
//                <tbody>
//                <tr>
//                <td style=""font-size:0;line-height:0;border-collapse:collapse;"" width=""0"" height=""2"">
//                <p style=""padding-left:20px;"">&nbsp;</p>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                <table class=""ecxBoxWrap"" align=""right"" cellpadding=""0"" cellspacing=""0"" width=""184"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table class=""ecxColor01_D"" bgcolor=""#000000"" cellpadding=""14"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <h2 style=""font-size:18px;color:#c5c5c5;text-align:left;font-weight:normal;line-height:22px;text-decoration:none;text-transform:uppercase;font-family:Helvetica, Arial, sans-serif;"">
//                Servicios:</h2>
//                <h3 style=""color:#ffffff;font-size:12px;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                <a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Tour</a><br>
//                <a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;"" target=""_blank"">Transportación</a>
//                </h3>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td class=""ecxPreheader_Color"" style="""" bgcolor=""#f3f3f3"" valign=""top"">
//                <table class=""ecxBoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" width=""600"">
//                <tbody>
//                <tr>
//                <td style="""" height=""20""></td>
//                </tr>
//                <tr>
//                <td style="""">
//                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <h3 style=""font-size:12px;color:#808185;text-align:left;font-weight:normal;font-family:Helvetica, Arial, sans-serif;line-height:18px;"">
//                <a href="""+ dominio + @""" style=""text-decoration:none;color:#151516;text-transform:capitalize;line-height:30px;"">Operadora Turística Itzaa</a></h3>
//                </td>
//                <td class=""ecxRespoHideSmall"" style="""" width=""150"">
//                <table cellpadding=""0"" cellspacing=""0"" width=""100%"">
//                <tbody>
//                <tr>
//                <td style="""">
//                <table align=""right"" cellpadding=""0"" cellspacing=""0"">
//                <tbody>
//                <tr>
//                <td style="""" align=""right"" width=""50""><a href=""" + _facebook + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//                </a></td>
//                <td style="""" align=""right"" width=""50""><a href=""" + _twitter + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//                </a></td>
//                <td style="""" align=""right"" width=""50""><a href=""" + _googleplus + @""" style=""border:none;text-decoration:none;text-transform:capitalize;line-height:30px;color:#ffffff;""><img src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" style=""width:40px;height:40px;max-width:40px;max-height:40px;display:block;border:0px;text-decoration:none;"" border=""0"" width=""40"" height=""40"">
//                </a></td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td style="""" height=""20""></td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                </tbody>
//                </table></div></body></html>
//                ";

//                return html;
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }

//        public static bool EnviarCorreo(string De, string Contraseña, string Para, string Asunto, string Mensaje, bool banArchivo, string Archivo, bool Html, string Host, int Port, bool Ssl)
//        {
//            try
//            {
//                //GMAIL
//                //Habilitar las siguientes opciones en correo de gmail
//                //https://www.google.com/settings/security/lesssecureapps
//                //https://accounts.google.com/DisplayUnlockCaptcha
//                //HOTMAIL
//                //Enviara las primeras veces despues nos llegara un correo para reconocer el inicio de sesion 
//                //ya que depende del servidor donde esta alojado y se tiene que reconocer el inicio de sesion   
//                System.Net.Mail.MailMessage mailMessage = new System.Net.Mail.MailMessage();
//                mailMessage.From = new System.Net.Mail.MailAddress(De);
//                mailMessage.To.Add(Para);
//                mailMessage.Subject = Asunto;
//                if (banArchivo)
//                    mailMessage.Attachments.Add(new System.Net.Mail.Attachment(Archivo));
//                mailMessage.Body = Mensaje;
//                mailMessage.IsBodyHtml = Html;
//                System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient(Host);
//                smtpClient.Port = Port;
//                smtpClient.EnableSsl = Ssl;
//                smtpClient.Credentials = new NetworkCredential(De, Contraseña);
//                smtpClient.Send(mailMessage);
//                return true;
//            }
//            catch (Exception ex)
//            {
//                Comun_Negocio.AddExcFileTxt(ex, "EnvioCorreo.EnviarCorreo");
//                return false;
//            }
//        }

//        public static string GenerarHtmlPaqueteCotizado(Solicitud datos)
//        {
//            string _facebook = Comun.UrlFacebook;
//            string _twitter = Comun.UrlTwitter;
//            string _googleplus = Comun.UrlGoogle;
//            string correoItzaa = Comun.CorreoEmpresa;
//            string telefono = Comun.Telefono;
//            string pass = datos.Cliente != null ? (string.IsNullOrEmpty(datos.Cliente.Password) ? "*****" : datos.Cliente.Password) : "*****";
//            string Monto = string.Format("{0:c}", datos.Cotizacion != null ? datos.Cotizacion.Subtotal : 0);
//            string Comentarios = datos.Cotizacion != null ? datos.Cotizacion.Comentarios : string.Empty;
//            string FechaLlegada = datos.FechaLlegada.ToShortDateString() + " " + datos.HoraLlegada;
//            string FechaSalida = datos.FechaSalida.ToShortDateString() + " " + datos.HoraSalida;
//            string CorreoCliente = datos.Cliente != null ? datos.Cliente.CorreoElectronico : string.Empty;
//            string NombreCliente = datos.Cliente != null ? datos.Cliente.Nombre : string.Empty;
//            string NumPersonas = datos.NumTotalPersonas.ToString();
//            string dominio = _dominio;
//            string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
//            string numeroEstrellas = "";
//            for (int j = 0; j < Convert.ToInt32(datos.CategoriaHotel.ToString()); j++)
//            {
//                numeroEstrellas += "*";
//            }
//            string html = @"<html>
//            <head>
//            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
//            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
//            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
//            <title></title>
//            <style type=""text/css"">
//            div, p, a, li, td { -webkit-text-size-adjust:none; }
//            .ReadMsgBody
//            {width: 100%; background-color: #ffffff;}
//            .ExternalClass
//            {width: 100%; background-color: #ffffff;}
//            body
//            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
//            html
//            {width: 100%; }
//            img 
//            {border:0px; outline:none; text-decoration:none; display:block; }
//            a
//            {text-decoration: none; text-transform: capitalize; line-height: 30px; color: #ffffff;}
//            a span
//            {text-decoration:none; color: #ffffff;}
//            h1 
//            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
//            h2 
//            {font-size: 18px; margin: 10px 0 10px 0; color: #808185; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:uppercase;}
//            h3 
//            {font-size: 12px; margin: 5px 0 5px 0; color: #808185; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
//            @media only screen and (max-width: 900px) 
//            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
//            @media only screen and (max-width: 640px)
//            { body{ width:auto!important; }
//            .BoxWrap { width:440px !important;}
//            .RespoHideMedium { display:none !important; } 
//            .RespoShowMedium { display:block !important; } 
//            .RespoCenterMedium { text-align:center !important; }
//            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
//            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
//            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
//            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
//            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
//            }
//            @media only screen and (max-width: 479px)
//            {
//            body{width:auto!important;}
//            .BoxWrap { width:280px !important;}
//            .RespoHideSmall { display:none !important; }
//            .RespoCenterSmall { text-align:center !important; }
//            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
//            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
//            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
//            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
//            }
//            .Bg_Color
//            {
//             background-color: #fefefe;
//            }
//            .BgImageAltColor
//            {
//            background-color: #000000;
//            }
//            .Preheader_Color
//            {
//            background-color: #f3f3f3;
//            }
//            .Content_Color
//            {
//             /*@editable*/ background-color: #ffffff;
//            }
//            .Color01_B
//            {
//             /*@editable*/ background-color: #CE0000;
//            }
//            .Color01_D
//            {
//             /*@editable*/ background-color: #000000;
//            }
//            .Color02_B
//            {
//             /*@editable*/ background-color: #E7E7EF;
//            } 
//            </style>
//            </head>
//            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
//            <tbody>
//            <tr>
//            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td class=""RespoHideSmall"" width=""100%"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
//            <tbody>
//            <tr>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td class=""BgImageAltColor"" bgcolor=""#000000"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;color: #ffffff;font-size: 18px;margin: 10px 0 10px 0;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Operadora Turística - Viajes Itzaa</h2>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""1"" class=""Bg_Color"" bgcolor=""#fefefe"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h1 style=""text-transform: uppercase;text-align: center;color: #ffffff;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;line-height: 40px;""><a href=""#"" style=""color: #ffffff;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;"">Gracias por elegirnos<br></a></h1>
//            <h3 style=""text-align: center;color: #c7c7c7;font-size: 12px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">La mejor experiencia para su viaje</h3>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""1"" class=""Bg_Color"" bgcolor=""#fefefe"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            if (!string.IsNullOrEmpty(Comentarios))
//            {
//                html = html + @"
//                <tr>
//                    <td style=""-webkit-text-size-adjust: none;"">
//                        <table width=""100%"" class=""Color02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"">
//                            <tbody>
//                                <tr>
//                                    <td style=""-webkit-text-size-adjust: none;"">
//                                        <h1 style=""text-align: center;text-transform: uppercase;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;line-height: 40px;""><a href=""#"" style=""text-transform: uppercase;text-decoration: none;color: #151516;-webkit-text-size-adjust: none;line-height: 30px;"">" + Comentarios + @"</a></h1>
//                                    </td>
//                                </tr>
//                            </tbody>
//                        </table>
//                     </td>
//                </tr>";
//            }

//            html = html + @"
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;"">
//            &nbsp; 
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""600"" class=""BoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" border=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""RespoImage_70ToOneW"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//			<img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""RespoImage_70ToOne"" alt="""" style=""width: 185px; height: 130px; display: block; border: 0px none; outline: medium none; text-decoration: none;"" border=""0"" height=""100"" width=""185""></a>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""Color01_B"" bgcolor=""#CE0000"" style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Mis datos</span></a></h3>
//            </td>
//            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#000000"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""" + dominio + @"/MiCuenta"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""391"" align=""left"" cellpadding=""30"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""331"" style=""-webkit-text-size-adjust: none;"">
//            <h1 style=""text-transform: uppercase;font-size: 15px;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + NombreCliente + @"</h1>
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #808185;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Usuario: " + CorreoCliente+ @"</h3>
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #808185;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Contraseña: " + pass  + @"</h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""401"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""RespoImage_OneToOneW"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img class=""RespoImage_OneToOne"" width=""401"" height=""401"" src="" "+dominio+@""+ datos.ImgProducto.Replace("~", "")+@" "" alt="""" border=""0"" style=""width: 401px;height: 401px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #808185;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">" + datos.NombreProducto + @"</h2>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumDias.ToString() + @" días</h1>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumNoches.ToString() + @" noches</h1>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Color01_D"" bgcolor=""#000000"" cellpadding=""5"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/DetallePaquete/?id=" + datos.IDProducto + @"&id_seccion=" + datos.IDSeccion + @""" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Ver paquete</span></a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Detalles cotización del paquete</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""20"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Llegada:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaLlegada +@"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Salida:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaSalida + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Categoria de Hotel:</h3>
//            </td> 
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numeroEstrellas +@"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Numero de personas:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + NumPersonas + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Adultos</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 4-11</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 0-4</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Camas</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Tipo de Habitación</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            foreach (DataRow recamara in datos.TablaHabitaciones.Rows)
//            {
//                html = html + @"<tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//                <tbody>
//                <tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + recamara["NumAdultos"].ToString() + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + recamara["NumMenores11"].ToString() + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + recamara["NumMenores4"].ToString() + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + recamara["NumCamas"].ToString() + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + recamara["TipoHabitacion"].ToString() + @"</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//                </tr>";
//            }

//            html = html + @"<tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #808185;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Precio</h2>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">" + Monto + @"</h1>
//            </td>
//            </tr>";



//            html = html + @"
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Para poder apartar el paquete se debe pagar el " + Anticipo + @"% del precio. El resto debe cubrirse al llegar a nuestras instalaciones. </h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//
//            <tr>
//                <td style=""-webkit-text-size-adjust: none;"">
//                    <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
//                        <tbody>
//                            <tr>
//                                <td class=""Color01_B"" bgcolor=""#CE0000"" style=""-webkit-text-size-adjust: none;"">
//                                    <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href="""" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;""></span></a></h3>
//                                </td>
//                                <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#000000"" style=""-webkit-text-size-adjust: none;"">
//                                    <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//                                        <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/details.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
//                                    </a>
//                                </td>
//                            </tr>
//                        </tbody>
//                    </table>
//                </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""60"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td valign=""top"" class=""Color01_D"" bgcolor=""#000000"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#000000"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. (961) 212 7414<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
//            <tbody>
//            <tr>
//            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
//            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#000000"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Chiapas</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Yucatan</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">QuintanaRoo</a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
//            <tbody>
//            <tr>
//            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
//            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#000000"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Tour</a><br><a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Transportación</a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #808185;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @""" style=""text-decoration: none;color: #151516;-webkit-text-size-adjust: none;text-transform: capitalize;line-height: 30px;"">Operadora Turística Itzaa</a></h3>
//            </td>
//            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
//            <tbody>
//            <tr>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </body>
//            </html>
//            ";
//            return html;
//        }

//        public static string GenerarHtmlPaqueteVipCotizado(Solicitud datos)
//        {
//            string _facebook = Comun.UrlFacebook;
//            string _twitter = Comun.UrlTwitter;
//            string _googleplus = Comun.UrlGoogle;
//            string correoItzaa = Comun.CorreoEmpresa;
//            string telefono = Comun.Telefono;
//            string pass = datos.Cliente != null ? (string.IsNullOrEmpty(datos.Cliente.Password) ? "*****" : datos.Cliente.Password) : "*****";
//            string Monto = string.Format("{0:c}", datos.Cotizacion != null ? datos.Cotizacion.Subtotal : 0);
//            string Comentarios = datos.Cotizacion != null ? datos.Cotizacion.Comentarios : string.Empty;
//            string FechaLlegada = datos.FechaLlegada.ToShortDateString() + " " + datos.HoraLlegada;
//            string FechaSalida = datos.FechaSalida.ToShortDateString() + " " + datos.HoraSalida;
//            string CorreoCliente = datos.Cliente != null ? datos.Cliente.CorreoElectronico : string.Empty;
//            string NombreCliente = datos.Cliente != null ? datos.Cliente.Nombre : string.Empty;
//            string NumPersonas = datos.NumTotalPersonas.ToString();
//            string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
//            string dominio = _dominio;
//            string numeroEstrellas = "";
//            for (int j = 0; j < Convert.ToInt32(datos.CategoriaHotel.ToString()); j++)
//            {
//                numeroEstrellas += "*";
//            }

//            string html = @"<html>
//            <head>
//            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
//            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
//            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
//            <title></title>
//            <style type=""text/css"">
//            div, p, a, li, td { -webkit-text-size-adjust:none; }
//            .ReadMsgBody
//            {width: 100%; background-color: #ffffff;}
//            .ExternalClass
//            {width: 100%; background-color: #ffffff;}
//            body
//            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
//            html
//            {width: 100%; }
//            img 
//            {border:0px; outline:none; text-decoration:none; display:block; }
//            a
//            {text-decoration: none; text-transform: capitalize; line-height: 30px; color: #ffffff;}
//            a span
//            {text-decoration:none; color: #ffffff;}
//            h1 
//            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
//            h2 
//            {font-size: 18px; margin: 10px 0 10px 0; color: #808185; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:uppercase;}
//            h3 
//            {font-size: 12px; margin: 5px 0 5px 0; color: #808185; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
//            @media only screen and (max-width: 900px) 
//            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
//            @media only screen and (max-width: 640px)
//            { body{ width:auto!important; }
//            .BoxWrap { width:440px !important;}
//            .RespoHideMedium { display:none !important; } 
//            .RespoShowMedium { display:block !important; } 
//            .RespoCenterMedium { text-align:center !important; }
//            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
//            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
//            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
//            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
//            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
//            }
//            @media only screen and (max-width: 479px)
//            {
//            body{width:auto!important;}
//            .BoxWrap { width:280px !important;}
//            .RespoHideSmall { display:none !important; }
//            .RespoCenterSmall { text-align:center !important; }
//            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
//            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
//            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
//            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
//            }
//            .Bg_Color
//            {
//             background-color: #fefefe;
//            }
//            .BgImageAltColor
//            {
//            background-color: #000000;
//            }
//            .Preheader_Color
//            {
//            background-color: #f3f3f3;
//            }
//            .Content_Color
//            {
//             /*@editable*/ background-color: #ffffff;
//            }
//            .Color01_B
//            {
//             /*@editable*/ background-color: #CE0000;
//            }
//            .Color01_D
//            {
//             /*@editable*/ background-color: #000000;
//            }
//            .Color02_B
//            {
//             /*@editable*/ background-color: #E7E7EF;
//            } 
//            </style>
//            </head>
//            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
//            <tbody>
//            <tr>
//            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td class=""RespoHideSmall"" width=""100%"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
//            <tbody>
//            <tr>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td class=""BgImageAltColor"" bgcolor=""#000000"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;color: #ffffff;font-size: 18px;margin: 10px 0 10px 0;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Operadora Turística - Viajes Itzaa</h2>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""1"" class=""Bg_Color"" bgcolor=""#fefefe"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h1 style=""text-transform: uppercase;text-align: center;color: #ffffff;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;line-height: 40px;""><a href=""#"" style=""color: #ffffff;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;"">Gracias por elegirnos<br></a></h1>
//            <h3 style=""text-align: center;color: #c7c7c7;font-size: 12px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">La mejor experiencia para su viaje</h3>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""1"" class=""Bg_Color"" bgcolor=""#fefefe"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            if (!string.IsNullOrEmpty(Comentarios))
//            {
//                html = html + @"
//                <tr>
//                    <td style=""-webkit-text-size-adjust: none;"">
//                        <table width=""100%"" class=""Color02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"">
//                            <tbody>
//                                <tr>
//                                    <td style=""-webkit-text-size-adjust: none;"">
//                                        <h1 style=""text-align: center;text-transform: uppercase;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;line-height: 40px;""><a href=""#"" style=""text-transform: uppercase;text-decoration: none;color: #151516;-webkit-text-size-adjust: none;line-height: 30px;"">" + Comentarios + @"</a></h1>
//                                    </td>
//                                </tr>
//                            </tbody>
//                        </table>
//                     </td>
//                </tr>";
//            }

//            html = html + @"
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;"">
//            &nbsp; 
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""600"" class=""BoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" border=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""RespoImage_70ToOneW"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//			<img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""RespoImage_70ToOne"" alt="""" style=""width: 185px; height: 130px; display: block; border: 0px none; outline: medium none; text-decoration: none;"" border=""0"" height=""100"" width=""185""></a>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""Color01_B"" bgcolor=""#CE0000"" style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Mis datos</span></a></h3>
//            </td>
//            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#000000"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""" + dominio + @"/MiCuenta"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""391"" align=""left"" cellpadding=""30"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""331"" style=""-webkit-text-size-adjust: none;"">
//            <h1 style=""text-transform: uppercase;font-size: 15px;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + NombreCliente + @"</h1>
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #808185;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Usuario: " + CorreoCliente + @"</h3>
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #808185;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Contraseña: " + pass + @"</h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""401"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""RespoImage_OneToOneW"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img class=""RespoImage_OneToOne"" width=""401"" height=""401"" src="" " + dominio + @"" + datos.ImgProducto.Replace("~", "") + @" "" alt="""" border=""0"" style=""width: 401px;height: 401px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #808185;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">" + datos.NombreProducto + @"</h2>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumDias.ToString() + @" días</h1>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumNoches.ToString() + @" noches</h1>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Color01_D"" bgcolor=""#000000"" cellpadding=""5"" cellspacing=""0"">
//            <tbody>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Detalles cotización del paquete vip</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""20"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Llegada:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaLlegada + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Salida:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaSalida + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Categoria de Hotel:</h3>
//            </td> 
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numeroEstrellas + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Numero de personas:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + NumPersonas + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Adultos</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 4-11</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 0-4</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Camas</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Tipo de Habitación</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            foreach (DataRow recamara in datos.TablaHabitaciones.Rows)
//            {
//                html = html + @"<tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//                <tbody>
//                <tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + recamara["NumAdultos"].ToString() + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + recamara["NumMenores11"].ToString() + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + recamara["NumMenores4"].ToString() + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + recamara["NumCamas"].ToString() + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + recamara["TipoHabitacion"].ToString() + @"</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//                </tr>";
//            }

//            html = html + @"<tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #808185;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Precio</h2>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">" + Monto + @"</h1>
//            </td>
//            </tr>";

//            html = html + @"
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Para poder apartar el paquete se debe pagar el " + Anticipo + @"% del precio. El resto debe cubrirse al llegar a nuestras instalaciones. </h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""Color01_B"" bgcolor=""#CE0000"" style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href="""" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;""></span></a></h3>
//            </td>
//            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#000000"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/details.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""60"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td valign=""top"" class=""Color01_D"" bgcolor=""#000000"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#000000"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. (961) 212 7414<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
//            <tbody>
//            <tr>
//            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
//            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#000000"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Chiapas</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Yucatan</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">QuintanaRoo</a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
//            <tbody>
//            <tr>
//            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
//            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#000000"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Tour</a><br><a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Transportación</a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #808185;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href="""+ dominio + @""" style=""text-decoration: none;color: #151516;-webkit-text-size-adjust: none;text-transform: capitalize;line-height: 30px;"">Operadora Turística Itzaa</a></h3>
//            </td>
//            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
//            <tbody>
//            <tr>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </body>
//            </html>
//            ";
//            return html;
//        }

//        public static string GenerarHtmlToursCotizado(Solicitud datos)
//        {
//            string _facebook = Comun.UrlFacebook;
//            string _twitter = Comun.UrlTwitter;
//            string _googleplus = Comun.UrlGoogle;
//            string correoItzaa = Comun.CorreoEmpresa;
//            string telefono = Comun.Telefono;
//            string pass = datos.Cliente != null ? (string.IsNullOrEmpty(datos.Cliente.Password) ? "*****" : datos.Cliente.Password) : "*****";
//            string Monto = string.Format("{0:c}", datos.Cotizacion != null ? datos.Cotizacion.Subtotal : 0);
//            string Comentarios = datos.Cotizacion != null ? datos.Cotizacion.Comentarios : string.Empty;
//            string FechaLlegada = datos.FechaLlegada.ToShortDateString() + " " + datos.HoraLlegada;
//            string FechaSalida = datos.FechaSalida.ToShortDateString() + " " + datos.HoraSalida;
//            string CorreoCliente = datos.Cliente != null ? datos.Cliente.CorreoElectronico : string.Empty;
//            string NombreCliente = datos.Cliente != null ? datos.Cliente.Nombre : string.Empty;
//            string NumPersonas = datos.NumTotalPersonas.ToString();
//            string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
//            string dominio = _dominio;
//            string numeroEstrellas = "";
//            for (int j = 0; j < Convert.ToInt32(datos.CategoriaHotel.ToString()); j++)
//            {
//                numeroEstrellas += "*";
//            }

//            string html = @"<html>
//            <head>
//            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
//            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
//            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
//            <title></title>
//            <style type=""text/css"">
//            div, p, a, li, td { -webkit-text-size-adjust:none; }
//            .ReadMsgBody
//            {width: 100%; background-color: #ffffff;}
//            .ExternalClass
//            {width: 100%; background-color: #ffffff;}
//            body
//            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
//            html
//            {width: 100%; }
//            img 
//            {border:0px; outline:none; text-decoration:none; display:block; }
//            a
//            {text-decoration: none; text-transform: capitalize; line-height: 30px; color: #ffffff;}
//            a span
//            {text-decoration:none; color: #ffffff;}
//            h1 
//            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
//            h2 
//            {font-size: 18px; margin: 10px 0 10px 0; color: #808185; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:uppercase;}
//            h3 
//            {font-size: 12px; margin: 5px 0 5px 0; color: #808185; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
//            @media only screen and (max-width: 900px) 
//            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
//            @media only screen and (max-width: 640px)
//            { body{ width:auto!important; }
//            .BoxWrap { width:440px !important;}
//            .RespoHideMedium { display:none !important; } 
//            .RespoShowMedium { display:block !important; } 
//            .RespoCenterMedium { text-align:center !important; }
//            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
//            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
//            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
//            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
//            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
//            }
//            @media only screen and (max-width: 479px)
//            {
//            body{width:auto!important;}
//            .BoxWrap { width:280px !important;}
//            .RespoHideSmall { display:none !important; }
//            .RespoCenterSmall { text-align:center !important; }
//            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
//            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
//            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
//            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
//            }
//            .Bg_Color
//            {
//             background-color: #fefefe;
//            }
//            .BgImageAltColor
//            {
//            background-color: #000000;
//            }
//            .Preheader_Color
//            {
//            background-color: #f3f3f3;
//            }
//            .Content_Color
//            {
//             /*@editable*/ background-color: #ffffff;
//            }
//            .Color01_B
//            {
//             /*@editable*/ background-color: #CE0000;
//            }
//            .Color01_D
//            {
//             /*@editable*/ background-color: #000000;
//            }
//            .Color02_B
//            {
//             /*@editable*/ background-color: #E7E7EF;
//            } 
//            </style>
//            </head>
//            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
//            <tbody>
//            <tr>
//            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td class=""RespoHideSmall"" width=""100%"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
//            <tbody>
//            <tr>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td class=""BgImageAltColor"" bgcolor=""#000000"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;color: #ffffff;font-size: 18px;margin: 10px 0 10px 0;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Operadora Turistica - Viajes Itzaa</h2>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""1"" class=""Bg_Color"" bgcolor=""#fefefe"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h1 style=""text-transform: uppercase;text-align: center;color: #ffffff;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;line-height: 40px;""><a href=""#"" style=""color: #ffffff;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;"">Gracias por elegirnos<br></a></h1>
//            <h3 style=""text-align: center;color: #c7c7c7;font-size: 12px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">La mejor experiencia para su viaje</h3>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""1"" class=""Bg_Color"" bgcolor=""#fefefe"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            if (!string.IsNullOrEmpty(Comentarios))
//            {
//                html = html + @"
//                <tr>
//                    <td style=""-webkit-text-size-adjust: none;"">
//                        <table width=""100%"" class=""Color02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"">
//                            <tbody>
//                                <tr>
//                                    <td style=""-webkit-text-size-adjust: none;"">
//                                        <h1 style=""text-align: center;text-transform: uppercase;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;line-height: 40px;""><a href=""#"" style=""text-transform: uppercase;text-decoration: none;color: #151516;-webkit-text-size-adjust: none;line-height: 30px;"">" + Comentarios + @"</a></h1>
//                                    </td>
//                                </tr>
//                            </tbody>
//                        </table>
//                     </td>
//                </tr>";
//            }

//            html = html + @"
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;"">
//            &nbsp; 
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""600"" class=""BoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" border=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""RespoImage_70ToOneW"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//			<img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""RespoImage_70ToOne"" alt="""" style=""width: 185px; height: 130px; display: block; border: 0px none; outline: medium none; text-decoration: none;"" border=""0"" height=""100"" width=""185""></a>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""Color01_B"" bgcolor=""#CE0000"" style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Mis datos</span></a></h3>
//            </td>
//            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#000000"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""" + dominio + @"/MiCuenta"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""391"" align=""left"" cellpadding=""30"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""331"" style=""-webkit-text-size-adjust: none;"">
//            <h1 style=""text-transform: uppercase;font-size: 15px;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + NombreCliente + @"</h1>
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #808185;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Usuario: " + CorreoCliente + @"</h3>
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #808185;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Contraseña: " + pass + @"</h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""401"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""RespoImage_OneToOneW"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img class=""RespoImage_OneToOne"" width=""401"" height=""401"" src="" " + dominio + @"" + datos.ImgProducto.Replace("~", "") + @" "" alt="""" border=""0"" style=""width: 401px;height: 401px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #808185;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">" + datos.NombreProducto + @"</h2>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumDias.ToString() + @" días</h1>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumNoches.ToString() + @" noches</h1>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Color01_D"" bgcolor=""#000000"" cellpadding=""5"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/DetalleTour/?id=" + datos.IDProducto + @"&id_seccion=" + datos.IDSeccion + @" "" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Ver tour</span></a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Detalles cotización del tour</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""20"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Llegada:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaLlegada + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Salida:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaSalida + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Numero de personas:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + NumPersonas + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">";

//            html = html + @"<tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #808185;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Precio</h2>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">" + Monto + @"</h1>
//            </td>
//            </tr>";           

//            html = html + @"
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Para poder apartar el tour se debe pagar el " + Anticipo + @"% del precio. El resto debe cubrirse al llegar a nuestras instalaciones. </h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""Color01_B"" bgcolor=""#CE0000"" style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href="""" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;""></span></a></h3>
//            </td>
//            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#000000"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/details.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""60"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td valign=""top"" class=""Color01_D"" bgcolor=""#000000"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#000000"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. (961) 212 7414<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
//            <tbody>
//            <tr>
//            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
//            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#000000"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Chiapas</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Yucatan</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">QuintanaRoo</a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
//            <tbody>
//            <tr>
//            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
//            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#000000"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Tour</a><br><a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Transportación</a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #808185;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href="""+ dominio + @""" style=""text-decoration: none;color: #151516;-webkit-text-size-adjust: none;text-transform: capitalize;line-height: 30px;"">Operadora Turística Itzaa</a></h3>
//            </td>
//            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
//            <tbody>
//            <tr>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </body>
//            </html>
//            ";
//            return html;
//        }

//        public static string GenerarHtmlHotelesCotizado(Solicitud datos)
//        {
//            string _facebook = Comun.UrlFacebook;
//            string _twitter = Comun.UrlTwitter;
//            string _googleplus = Comun.UrlGoogle;
//            string correoItzaa = Comun.CorreoEmpresa;
//            string telefono = Comun.Telefono;
//            string pass = datos.Cliente != null ? (string.IsNullOrEmpty(datos.Cliente.Password) ? "*****" : datos.Cliente.Password) : "*****";
//            string Monto = string.Format("{0:c}", datos.Cotizacion != null ? datos.Cotizacion.Subtotal : 0);
//            string Comentarios = datos.Cotizacion != null ? datos.Cotizacion.Comentarios : string.Empty;
//            string FechaLlegada = datos.FechaLlegada.ToShortDateString() + " " + datos.HoraLlegada;
//            string FechaSalida = datos.FechaSalida.ToShortDateString() + " " + datos.HoraSalida;
//            string CorreoCliente = datos.Cliente != null ? datos.Cliente.CorreoElectronico : string.Empty;
//            string NombreCliente = datos.Cliente != null ? datos.Cliente.Nombre : string.Empty;
//            string NumPersonas = datos.NumTotalPersonas.ToString();
//            string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
//            string dominio = _dominio;
//            string numeroEstrellas = "";
//            for (int j = 0; j < Convert.ToInt32(datos.CategoriaHotel.ToString()); j++)
//            {
//                numeroEstrellas += "*";
//            }
//            string html = @"<html>
//            <head>
//            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
//            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
//            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
//            <title></title>
//            <style type=""text/css"">
//            div, p, a, li, td { -webkit-text-size-adjust:none; }
//            .ReadMsgBody
//            {width: 100%; background-color: #ffffff;}
//            .ExternalClass
//            {width: 100%; background-color: #ffffff;}
//            body
//            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
//            html
//            {width: 100%; }
//            img 
//            {border:0px; outline:none; text-decoration:none; display:block; }
//            a
//            {text-decoration: none; text-transform: capitalize; line-height: 30px; color: #ffffff;}
//            a span
//            {text-decoration:none; color: #ffffff;}
//            h1 
//            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
//            h2 
//            {font-size: 18px; margin: 10px 0 10px 0; color: #808185; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:uppercase;}
//            h3 
//            {font-size: 12px; margin: 5px 0 5px 0; color: #808185; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
//            @media only screen and (max-width: 900px) 
//            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
//            @media only screen and (max-width: 640px)
//            { body{ width:auto!important; }
//            .BoxWrap { width:440px !important;}
//            .RespoHideMedium { display:none !important; } 
//            .RespoShowMedium { display:block !important; } 
//            .RespoCenterMedium { text-align:center !important; }
//            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
//            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
//            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
//            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
//            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
//            }
//            @media only screen and (max-width: 479px)
//            {
//            body{width:auto!important;}
//            .BoxWrap { width:280px !important;}
//            .RespoHideSmall { display:none !important; }
//            .RespoCenterSmall { text-align:center !important; }
//            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
//            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
//            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
//            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
//            }
//            .Bg_Color
//            {
//             background-color: #fefefe;
//            }
//            .BgImageAltColor
//            {
//            background-color: #000000;
//            }
//            .Preheader_Color
//            {
//            background-color: #f3f3f3;
//            }
//            .Content_Color
//            {
//             /*@editable*/ background-color: #ffffff;
//            }
//            .Color01_B
//            {
//             /*@editable*/ background-color: #CE0000;
//            }
//            .Color01_D
//            {
//             /*@editable*/ background-color: #000000;
//            }
//            .Color02_B
//            {
//             /*@editable*/ background-color: #E7E7EF;
//            } 
//            </style>
//            </head>
//            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
//            <tbody>
//            <tr>
//            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td class=""RespoHideSmall"" width=""100%"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
//            <tbody>
//            <tr>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td class=""BgImageAltColor"" bgcolor=""#000000"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;color: #ffffff;font-size: 18px;margin: 10px 0 10px 0;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Operadora Turistica - Viajes Itzaa</h2>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""1"" class=""Bg_Color"" bgcolor=""#fefefe"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h1 style=""text-transform: uppercase;text-align: center;color: #ffffff;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;line-height: 40px;""><a href=""#"" style=""color: #ffffff;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;"">Gracias por elegirnos<br></a></h1>
//            <h3 style=""text-align: center;color: #c7c7c7;font-size: 12px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">La mejor experiencia para su viaje</h3>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""1"" class=""Bg_Color"" bgcolor=""#fefefe"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            if (!string.IsNullOrEmpty(Comentarios))
//            {
//                html = html + @"
//                <tr>
//                    <td style=""-webkit-text-size-adjust: none;"">
//                        <table width=""100%"" class=""Color02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"">
//                            <tbody>
//                                <tr>
//                                    <td style=""-webkit-text-size-adjust: none;"">
//                                        <h1 style=""text-align: center;text-transform: uppercase;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;line-height: 40px;""><a href=""#"" style=""text-transform: uppercase;text-decoration: none;color: #151516;-webkit-text-size-adjust: none;line-height: 30px;"">" + Comentarios + @"</a></h1>
//                                    </td>
//                                </tr>
//                            </tbody>
//                        </table>
//                     </td>
//                </tr>";
//            }

//            html = html + @"
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;"">
//            &nbsp; 
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""600"" class=""BoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" border=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""RespoImage_70ToOneW"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//			<img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""RespoImage_70ToOne"" alt="""" style=""width: 185px; height: 130px; display: block; border: 0px none; outline: medium none; text-decoration: none;"" border=""0"" height=""100"" width=""185""></a>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""Color01_B"" bgcolor=""#CE0000"" style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Mis datos</span></a></h3>
//            </td>
//            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#000000"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""" + dominio + @"/MiCuenta"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""391"" align=""left"" cellpadding=""30"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""331"" style=""-webkit-text-size-adjust: none;"">
//            <h1 style=""text-transform: uppercase;font-size: 15px;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + NombreCliente + @"</h1>
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #808185;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Usuario: " + CorreoCliente + @"</h3>
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #808185;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Contraseña: " + pass + @"</h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""401"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""RespoImage_OneToOneW"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img class=""RespoImage_OneToOne"" width=""401"" height=""401"" src="" " + dominio + @"" + datos.ImgProducto.Replace("~", "") + @" "" alt="""" border=""0"" style=""width: 401px;height: 401px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #808185;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">" + datos.NombreProducto + @"</h2>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumDias.ToString() + @" días</h1>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumNoches.ToString() + @" noches</h1>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Detalles cotización del hotel</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""20"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Llegada:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaLlegada + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Salida:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaSalida + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Categoria de Hotel:</h3>
//            </td> 
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + numeroEstrellas + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Numero de personas:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + NumPersonas + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Adultos</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 4-11</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Niños 0-4</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Camas</h2>
//            </td>
//            <td style=""-webkit-text-size-adjust: none; width:20%"">
//            <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">Tipo de Habitaciòn</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            foreach (DataRow recamara in datos.TablaHabitaciones.Rows)
//            {
//                html = html + @"<tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//                <tbody>
//                <tr>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + recamara["NumAdultos"].ToString() + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + recamara["NumMenores11"].ToString() + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + recamara["NumMenores4"].ToString() + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + recamara["NumCamas"].ToString() + @"</h2>
//                </td>
//                <td style=""-webkit-text-size-adjust: none; width:18%"">
//                <h2 style=""text-align: center;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + recamara["TipoHabitacion"].ToString() + @"</h2>
//                </td>
//                </tr>
//                </tbody>
//                </table>
//                </td>
//                </tr>
//                <tr>
//                <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//                </tr>";
//            }

//            html = html + @"<tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #808185;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Precio</h2>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">" + Monto + @"</h1>
//            </td>
//            </tr>";

//            html = html + @"
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Para poder apartar el servicio de hotel se debe pagar el " + Anticipo + @"% del precio. El resto debe cubrirse al llegar a nuestras instalaciones. </h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""Color01_B"" bgcolor=""#CE0000"" style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href="""" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;""></span></a></h3>
//            </td>
//            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#000000"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/details.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""60"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td valign=""top"" class=""Color01_D"" bgcolor=""#000000"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#000000"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. (961) 212 7414<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
//            <tbody>
//            <tr>
//            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
//            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#000000"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Chiapas</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Yucatan</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">QuintanaRoo</a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
//            <tbody>
//            <tr>
//            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
//            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#000000"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Tour</a><br><a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Transportación</a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #808185;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""text-decoration: none;color: #151516;-webkit-text-size-adjust: none;text-transform: capitalize;line-height: 30px;"">Operadora Turística Itzaa</a></h3>
//            </td>
//            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
//            <tbody>
//            <tr>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </body>
//            </html>
//            ";
//            return html;
//        }

//        public static string GenerarHtmlTransportacionCotizado(Solicitud datos)
//        {
//            string _facebook = Comun.UrlFacebook;
//            string _twitter = Comun.UrlTwitter;
//            string _googleplus = Comun.UrlGoogle;
//            string correoItzaa = Comun.CorreoEmpresa;
//            string telefono = Comun.Telefono;
//            string pass = datos.Cliente != null ? (string.IsNullOrEmpty(datos.Cliente.Password) ? "*****" : datos.Cliente.Password) : "*****";
//            string Monto = string.Format("{0:c}", datos.Cotizacion != null ? datos.Cotizacion.Subtotal : 0);
//            string Comentarios = datos.Cotizacion != null ? datos.Cotizacion.Comentarios : string.Empty;
//            string FechaLlegada = datos.FechaLlegada.ToShortDateString() + " " + datos.HoraLlegada;
//            string FechaSalida = datos.FechaSalida.ToShortDateString() + " " + datos.HoraSalida;
//            string CorreoCliente = datos.Cliente != null ? datos.Cliente.CorreoElectronico : string.Empty;
//            string NombreCliente = datos.Cliente != null ? datos.Cliente.Nombre : string.Empty;
//            string NumPersonas = datos.NumTotalPersonas.ToString();
//            string Anticipo = string.Format("{0:F2}", Comun.PorcentajeAnticipo);
//            string dominio = _dominio;

//            string html = @"<html>
//            <head>
//            <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" >
//            <meta name=""viewport"" content=""width=device-width; initial-scale=1.0; maximum-scale=1.0;"" >
//            <meta property=""og:title"" content=""*|MC:SUBJECT|*"" >
//            <title></title>
//            <style type=""text/css"">
//            div, p, a, li, td { -webkit-text-size-adjust:none; }
//            .ReadMsgBody
//            {width: 100%; background-color: #ffffff;}
//            .ExternalClass
//            {width: 100%; background-color: #ffffff;}
//            body
//            {width: 100%; background-color: #ffffff; margin:0; padding:0; -webkit-font-smoothing: antialiased; mso-margin-top-alt:0px; mso-margin-bottom-alt:0px; mso-padding-alt: 0px 0px 0px 0px;}
//            html
//            {width: 100%; }
//            img 
//            {border:0px; outline:none; text-decoration:none; display:block; }
//            a
//            {text-decoration: none; text-transform: capitalize; line-height: 30px; color: #ffffff;}
//            a span
//            {text-decoration:none; color: #ffffff;}
//            h1 
//            {font-size: 30px; margin: 20px 0 20px 0; font-family: Helvetica, Arial, sans-serif; font-weight: normal; font-style: normal; color: #151516; text-align: left; line-height:40px;} 
//            h2 
//            {font-size: 18px; margin: 10px 0 10px 0; color: #808185; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif !important; line-height: 22px; text-decoration:none; text-transform:uppercase;}
//            h3 
//            {font-size: 12px; margin: 5px 0 5px 0; color: #808185; text-align: left; font-weight: normal; font-family: Helvetica, Arial, sans-serif; line-height: 18px;}
//            @media only screen and (max-width: 900px) 
//            {td[class=headerBG] {width: 100%!important; background-repeat: no-repeat!important; background-size: 900px!important; background-position: center middle!important;}}
//            @media only screen and (max-width: 640px)
//            { body{ width:auto!important; }
//            .BoxWrap { width:440px !important;}
//            .RespoHideMedium { display:none !important; } 
//            .RespoShowMedium { display:block !important; } 
//            .RespoCenterMedium { text-align:center !important; }
//            td[class=headerBG] {width: 100%!important;background-repeat: no-repeat!important; background-size: 800px!important; background-position: center!important;}
//            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 440px!important; height: 212px!important; }
//            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 440px!important; height: 335px!important; }
//            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 440px!important; height: 440px!important; }
//            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 440px!important; height: 628px!important; }
//            }
//            @media only screen and (max-width: 479px)
//            {
//            body{width:auto!important;}
//            .BoxWrap { width:280px !important;}
//            .RespoHideSmall { display:none !important; }
//            .RespoCenterSmall { text-align:center !important; }
//            img[class=RespoImage_OneTo50W],img[class=RespoImage_OneTo50] { width: 280px!important; height: 135px!important; }
//            img[class=RespoImage_OneTo75W],img[class=RespoImage_OneTo75] { width: 280px!important; height: 213px!important; }
//            img[class=RespoImage_OneToOneW],img[class=RespoImage_OneToOne] { width: 280px!important; height: 280px!important; }
//            img[class=RespoImage_70ToOneW],img[class=RespoImage_70ToOne] { width: 280px!important; height: 400px!important; }
//            }
//            .Bg_Color
//            {
//             background-color: #fefefe;
//            }
//            .BgImageAltColor
//            {
//            background-color: #000000;
//            }
//            .Preheader_Color
//            {
//            background-color: #f3f3f3;
//            }
//            .Content_Color
//            {
//             /*@editable*/ background-color: #ffffff;
//            }
//            .Color01_B
//            {
//             /*@editable*/ background-color: #CE0000;
//            }
//            .Color01_D
//            {
//             /*@editable*/ background-color: #000000;
//            }
//            .Color02_B
//            {
//             /*@editable*/ background-color: #E7E7EF;
//            } 
//            </style>
//            </head>
//            <body style=""width: 100%;background-color: #ffffff;margin: 0;padding: 0;-webkit-font-smoothing: antialiased;mso-margin-top-alt: 0px;mso-margin-bottom-alt: 0px;mso-padding-alt: 0px 0px 0px 0px;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""0"" cellspacing=""0"" align=""center"">
//            <tbody>
//            <tr>
//            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""191"" align=""center"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""191"" height=""50"" src=""" + dominio + @"/Content/assetsCorreo/img/logo.png"" alt="""" border=""0"" style=""width: 191px;height: 50px;max-width: 191px;max-height: 50px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td class=""RespoHideSmall"" width=""100%"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
//            <tbody>
//            <tr>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td class=""BgImageAltColor"" bgcolor=""#000000"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center"" style=""clear:both;"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""100%"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;color: #ffffff;font-size: 18px;margin: 10px 0 10px 0;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Operadora Turistica - Viajes Itzaa</h2>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""1"" class=""Bg_Color"" bgcolor=""#fefefe"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""10"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h1 style=""text-transform: uppercase;text-align: center;color: #ffffff;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;line-height: 40px;""><a href=""#"" style=""color: #ffffff;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;"">Gracias por elegirnos<br></a></h1>
//            <h3 style=""text-align: center;color: #c7c7c7;font-size: 12px;margin: 5px 0 5px 0;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">La mejor experiencia para su viaje</h3>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""1"" class=""Bg_Color"" bgcolor=""#fefefe"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>";

//            if (!string.IsNullOrEmpty(Comentarios))
//            {
//                html = html + @"
//                <tr>
//                    <td style=""-webkit-text-size-adjust: none;"">
//                        <table width=""100%"" class=""Color02_B"" bgcolor=""#E7E7EF"" cellpadding=""5"" cellspacing=""0"">
//                            <tbody>
//                                <tr>
//                                    <td style=""-webkit-text-size-adjust: none;"">
//                                        <h1 style=""text-align: center;text-transform: uppercase;font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;line-height: 40px;""><a href=""#"" style=""text-transform: uppercase;text-decoration: none;color: #151516;-webkit-text-size-adjust: none;line-height: 30px;"">" + Comentarios + @"</a></h1>
//                                    </td>
//                                </tr>
//                            </tbody>
//                        </table>
//                     </td>
//                </tr>";
//            }

//            html = html + @"
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" height=""40"" style=""-webkit-text-size-adjust: none;"">
//            &nbsp; 
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""600"" class=""BoxWrap"" align=""center"" cellpadding=""0"" cellspacing=""0"" border=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""RespoImage_70ToOneW"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//			<img src=""" + dominio + @"/Content/assetsCorreo/img/17797.png"" class=""RespoImage_70ToOne"" alt="""" style=""width: 185px; height: 130px; display: block; border: 0px none; outline: medium none; text-decoration: none;"" border=""0"" height=""100"" width=""185""></a>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""Color01_B"" bgcolor=""#CE0000"" style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;"">Mis datos</span></a></h3>
//            </td>
//            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#000000"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""" + dominio + @"/MiCuenta"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/basket.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""391"" align=""left"" cellpadding=""30"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""331"" style=""-webkit-text-size-adjust: none;"">
//            <h1 style=""text-transform: uppercase;font-size: 15px;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + NombreCliente + @"</h1>
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #808185;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Usuario: " + CorreoCliente + @"</h3>
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #808185;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Contraseña: " + pass + @"</h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""Content_Color"" bgcolor=""#ffffff"" width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""401"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""RespoImage_OneToOneW"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img class=""RespoImage_OneToOne"" width=""401"" height=""401"" src="" " + dominio + @"" + datos.ImgProducto.Replace("~", "") + @" "" alt="""" border=""0"" style=""width: 401px;height: 401px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #808185;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">" + datos.NombreProducto + @"</h2>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumDias.ToString() + @" días</h1>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: left;line-height: 40px;"">" + datos.NumNoches.ToString() + @" noches</h1>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Detalles cotización de la transportación</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""20"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Llegada:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaLlegada + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Fecha y hora de Salida:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + FechaSalida + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Bg_Color"" bgcolor=""#fefefe"" cellpadding=""15"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: left;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Numero de personas:</h3>
//            </td>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: right;text-transform: capitalize;font-size: 18px;margin: 10px 0 10px 0;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;font-family: Helvetica, Arial, sans-serif;"">" + NumPersonas + @"</h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""2"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">";

//            html = html + @"<tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #808185;text-align: right;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Precio</h2>
//            <h1 style=""font-size: 30px;margin: 20px 0 20px 0;font-family: Helvetica, Arial, sans-serif;font-weight: normal;font-style: normal;color: #151516;text-align: right;line-height: 40px;"">" + Monto + @"</h1>
//            </td>
//            </tr>";            

//            html = html + @"
//            <tr>
//            <td valign=""top"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td width=""100%"" height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""text-align: center;margin: 20px 0 0 0;font-size: 18px;color: #808185;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Para poder apartar el servicio de transportación se debe pagar el " + Anticipo + @"% del precio. El resto debe cubrirse al llegar a nuestras instalaciones. </h2>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""7"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td class=""Color01_B"" bgcolor=""#CE0000"" style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""text-align: center;font-size: 12px;margin: 5px 0 5px 0;color: #808185;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href="""" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;""><span style=""text-decoration: none;color: #ffffff;""></span></a></h3>
//            </td>
//            <td width=""50"" align=""center"" class=""Color01_D"" bgcolor=""#000000"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""32"" height=""32"" src=""" + dominio + @"/Content/assetsCorreo/img/details.png"" alt="""" border=""0"" style=""width: 32px;height: 32px;max-width: 32px;max-height: 32px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td width=""100%"" height=""60"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td valign=""top"" class=""Color01_D"" bgcolor=""#000000"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#000000"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Datos de contacto:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;"">Tel. (961) 212 7414<br><a href=""#"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Email. " + correoItzaa + @"</a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
//            <tbody>
//            <tr>
//            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
//            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""left"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#000000"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Paquetes:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Paquetes/?id_seccion=AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Chiapas</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=D474D40B-8BFA-4AD0-AD27-CA5F4D92BC43"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Yucatan</a><br><a href=""" + dominio + @"/Paquetes/?id_seccion=A0EDC619-01CC-499C-A4A3-8543300FD9B8"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">QuintanaRoo</a></h3>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""RespoHideMedium"" width=""0"" align=""left"" cellpadding=""0"" cellspacing=""0"" style=""font-size: 0;line-height: 0;border-collapse: collapse;"">
//            <tbody>
//            <tr>
//            <td width=""0"" height=""2"" style=""font-size: 0;line-height: 0;border-collapse: collapse;-webkit-text-size-adjust: none;"">
//            <p style=""padding-left: 20px;-webkit-text-size-adjust: none;"">&nbsp;</p>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            <table class=""BoxWrap"" width=""184"" align=""right"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table class=""Color01_D"" bgcolor=""#000000"" width=""100%"" cellpadding=""14"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h2 style=""font-size: 18px;margin: 10px 0 10px 0;color: #c5c5c5;text-align: left;font-weight: normal;line-height: 22px;text-decoration: none;text-transform: uppercase;font-family: Helvetica, Arial, sans-serif;"">Servicios:</h2>
//            <h3 style=""color: #ffffff;font-size: 12px;margin: 5px 0 5px 0;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""" + dominio + @"/Tours/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Tour</a><br><a href=""" + dominio + @"/Transportacion/AF43EC32-02B3-4B57-847D-E872C02217B9"" style=""-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">Transportación</a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td valign=""top"" class=""Preheader_Color"" bgcolor=""#f3f3f3"" style=""-webkit-text-size-adjust: none;"">
//            <table class=""BoxWrap"" width=""600"" align=""center"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <h3 style=""font-size: 12px;margin: 5px 0 5px 0;color: #808185;text-align: left;font-weight: normal;font-family: Helvetica, Arial, sans-serif;line-height: 18px;""><a href=""#"" style=""text-decoration: none;color: #151516;-webkit-text-size-adjust: none;text-transform: capitalize;line-height: 30px;"">Operadora Turística Itzaa</a></h3>
//            </td>
//            <td class=""RespoHideSmall"" width=""150"" style=""-webkit-text-size-adjust: none;"">
//            <table width=""100%"" cellpadding=""0"" cellspacing=""0"">
//            <tbody>
//            <tr>
//            <td style=""-webkit-text-size-adjust: none;"">
//            <table cellpadding=""0"" cellspacing=""0"" align=""right"">
//            <tbody>
//            <tr>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s01.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s02.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            <td width=""50"" align=""right"" style=""-webkit-text-size-adjust: none;"">
//            <a href=""#"" style=""border: none;-webkit-text-size-adjust: none;text-decoration: none;text-transform: capitalize;line-height: 30px;color: #ffffff;"">
//            <img width=""40"" height=""40"" src=""" + dominio + @"/Content/assetsCorreo/img/icon_s03.png"" alt="""" border=""0"" style=""width: 40px;height: 40px;max-width: 40px;max-height: 40px;display: block;border: 0px;outline: none;text-decoration: none;"">
//            </a>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            <tr>
//            <td height=""20"" style=""-webkit-text-size-adjust: none;""></td>
//            </tr>
//            </tbody>
//            </table>
//            </td>
//            </tr>
//            </tbody>
//            </table>
//            </body>
//            </html>
//            ";
//            return html;

//        }
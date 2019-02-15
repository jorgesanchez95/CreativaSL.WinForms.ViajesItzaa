using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.ViajesItzaa.Global
{
    public class Habitacion
    {
        private string _Conexion;
        private decimal _CostoAdulto;
        private decimal _CostoMenor11;
        private decimal _CostoMenor4;
        private string _IDCotizacion;
        private string _IDHabitacion;
        private string _IDHabitacionCotizacion;
        private string _IDSolicitud;
        private int _IDTipoHabitacion;
        private string _IDUsuario;
        private int _NumAdultos;
        private int _NumCamas;
        private int _NumMenores11;
        private int _NumMenores4;
        private int _Opcion;
        private decimal _Subtotal;
        private string _TipoHabitacion;

        public string Conexion
        {
            get { return _Conexion; }
            set { _Conexion = value; }
        }
        public decimal CostoAdulto
        {
            get { return _CostoAdulto; }
            set { _CostoAdulto = value; }
        }
        public decimal CostoMenor11
        {
            get { return _CostoMenor11; }
            set { _CostoMenor11 = value; }
        }
        public decimal CostoMenor4
        {
            get { return _CostoMenor4; }
            set { _CostoMenor4 = value; }
        }
        public string IDCotizacion
        {
            get { return _IDCotizacion; }
            set { _IDCotizacion = value; }
        }
        public string IDHabitacion
        {
            get { return _IDHabitacion; }
            set { _IDHabitacion = value; }
        }
        public string IDHabitacionCotizacion
        {
            get { return _IDHabitacionCotizacion; }
            set { _IDHabitacionCotizacion = value; }
        }
        public string IDSolicitud
        {
            get { return _IDSolicitud; }
            set { _IDSolicitud = value; }
        }
        public int IDTipoHabitacion
        {
            get { return _IDTipoHabitacion; }
            set { _IDTipoHabitacion = value; }
        }
        public string IDUsuario
        {
            get { return _IDUsuario; }
            set { _IDUsuario = value; }
        }
        public int NumAdultos
        {
            get { return _NumAdultos; }
            set { _NumAdultos = value; }
        }
        public int NumCamas
        {
            get { return _NumCamas; }
            set { _NumCamas = value; }
        }
        public int NumMenores11
        {
            get { return _NumMenores11; }
            set { _NumMenores11 = value; }
        }
        public int NumMenores4
        {
            get { return _NumMenores4; }
            set { _NumMenores4 = value; }
        }
        public int Opcion
        {
            get { return _Opcion; }
            set { _Opcion = value; }
        }
        public decimal Subtotal
        {
            get { return _Subtotal; }
            set { _Subtotal = value; }
        }
        public string TipoHabitacion
        {
            get { return _TipoHabitacion; }
            set { _TipoHabitacion = value; }
        }

    }
}

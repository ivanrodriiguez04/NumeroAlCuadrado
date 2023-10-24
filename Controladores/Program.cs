using NumeroAlCuadrado.Servicios;

namespace NumeroAlCuadrado.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// 24102023 -> irm
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo principal de la aplicacion
        /// 24102023 -> irm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Creamos los objetos
            NumCuadradoInterfaz nI = new NumCuadraroImplementacion();

            //Llamamos al metodo a traves del objeto
            nI.calcularNumeroAlCuadrado();
        }
    }
}

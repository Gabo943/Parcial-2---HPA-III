using Datos;
using Entidad;
using Negocio.Contratos;
using Negocio.Servicios;

namespace Negocio
{
    public class N_Usuario
    {
        private static readonly IVerificarHashService _verificador = new Sha512HashService();

        public static E_Usuarios Login(string strUsuario, string strPassword)
        {
            E_Usuarios usuario = D_Usuario.ObtenerPorUsuario(strUsuario);

            if (usuario == null || usuario.dsEstado != '1')
                return null;

            bool passwordCorrecto = _verificador.VerificarHash(strPassword, usuario.dsPassword);

            return passwordCorrecto ? usuario : null;
        }
    }
}
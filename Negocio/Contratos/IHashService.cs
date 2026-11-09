using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Contratos
{
    public interface IHashService
    {
        /// <summary>
        /// Genera el hash de una contraseña en texto plano.
        /// </summary>
        string GenerarHash(string passwordPlano);
    }
}

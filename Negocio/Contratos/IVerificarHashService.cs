using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Contratos
{
    public interface IVerificarHashService
    {
        /// <summary>
        /// Verifica si una contraseña en texto plano corresponde al hash almacenado.
        /// </summary>
        bool VerificarHash(string passwordPlano, string hashAlmacenado);
    }
}

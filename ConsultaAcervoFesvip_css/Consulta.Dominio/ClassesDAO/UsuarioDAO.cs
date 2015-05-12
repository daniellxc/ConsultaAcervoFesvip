using Consulta.Dominio.Classes;
using Consulta.Dominio.Entidades;
using Consulta.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consulta.Dominio.ClassesDAO
{
    public class UsuarioDAO:AbstractCrudDAO<Usuario>,IUsuarioDAO
    {
    }
}

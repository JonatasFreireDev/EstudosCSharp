using ProjetoAPI.Entidades;
using ProjetoAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAPI.Repositorio
{
    public class RepositoryProduto : RepositoryGenerics<Produto>, IProduto
    {
    }
}
using RestApiModeloDDD.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiModeloDDD.Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDto produtoDto);

        void Update(ProdutoDto produtoDto);

        void Remove(ProdutoDto produtoDto);

        IEnumerable<ProdutoDto> GetAll();

        ProdutoDto GetById(int id);
    }
}
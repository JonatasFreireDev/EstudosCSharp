using RestApiModeloDDD.Application.Dtos;
using RestApiModeloDDD.Application.Interfaces.Mappers;
using RestApiModeloDDD.Domain.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Application.Mappers
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                Id = produtoDto.Id,
                Nome = produtoDto.Nome,
                Preco = produtoDto.Valor,
            };

            return produto;
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            var produtoDto = new ProdutoDto()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Preco,
            };
            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListClienteDto(IEnumerable<Produto> produtos)
        {
            var dto = produtos.Select(c =>
                new ProdutoDto { Id = c.Id, Nome = c.Nome, Valor = c.Preco }
            );

            return dto;
        }
    }
}
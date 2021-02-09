using AutoMapper;
using NerdStore.Catalogo.Application.ViewModels;
using NerdStore.Catalogo.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Catalogo.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            // aqui eu to mapeando da ViewModel para o meu Domain

            CreateMap<ProdutoViewModel, Produto>()
                .ConstructUsing(pw =>
                    new Produto(pw.Nome, pw.Descricao, pw.Ativo,
                        pw.Valor, pw.CategoriaId, pw.DataCadastro,
                        pw.Imagem, new Dimensoes(pw.Altura, pw.Largura, pw.Profundidade)));

            CreateMap<CategoriaViewModel, Categoria>()
                .ConstructUsing(cw => new Categoria(cw.Nome, cw.Codigo));
        }
    }
}

using AutoMapper;
using NerdStore.Catalogo.Application.ViewModels;
using NerdStore.Catalogo.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Catalogo.Application.AutoMapper
{
    // Essa Classe é o perfil de mapeamento de Dominio para a ViewModel do AutoMapper
    // Profile classe  do AutoMapper
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            // Categoria para CategoriaView model, Produto para ProdutoViewModel...
            CreateMap<Categoria, CategoriaViewModel>();


            //no caso de produto se tem um propriedade dimensões
            //que é uma classe a parte e no ProdutoView model as 
            //dimensões estão dentro da propria classe ProdutoViewModel
            //então pra isso é necessário criar um mapeamento adicional para cada campo
            CreateMap<Produto, ProdutoViewModel>()
                .ForMember(pw => pw.Largura, o => o.MapFrom(p => p.Dimensoes.Largura))
                .ForMember(pw => pw.Altura, o => o.MapFrom(p => p.Dimensoes.Altura))
                .ForMember(pw => pw.Profundidade, o => o.MapFrom(p => p.Dimensoes.Profundidade));
        }
    }
}

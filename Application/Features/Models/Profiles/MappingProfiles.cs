using Application.Features.Models.Queries.GetList;
using Application.Features.Models.Queries.GetListByDynamic;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.Models.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Model, GetListModelListItemDto>().ReverseMap();
        CreateMap<Model, GetListByDynamicModelListItemDto>().ReverseMap();
        CreateMap<Paginate<Model>, GetListResponse<GetListModelListItemDto>>().ReverseMap();        
        CreateMap<Paginate<Model>, GetListResponse<GetListByDynamicModelListItemDto>>().ReverseMap();
    }
}

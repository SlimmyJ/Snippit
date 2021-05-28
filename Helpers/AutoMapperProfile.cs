namespace Snippit.Helpers
{
    using AutoMapper;

    using Snippit.Models;
    using Snippit.Models.SnippitViewModels;

    public class AutoMapperProfile : Profile
        {
        public AutoMapperProfile()
        {
                CreateMap<Snippit, SnippitDetailViewModel>()
                                .ReverseMap();

                CreateMap<Snippit, SnippitCreateViewModel>()
                                .ReverseMap();

                CreateMap<Snippit, SnippitEditViewModel>()
                                .ReverseMap();

                CreateMap<Snippit, SnippitDeleteViewModel>()
                                .ReverseMap();

                CreateMap<Author, AuthorViewModel>()
                                .ReverseMap();
        }
    }
}
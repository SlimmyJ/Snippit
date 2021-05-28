namespace Snippit.Helpers
{
    using AutoMapper;

    using Snippit.Models;
    using Snippit.Models.ViewModels;

    public class AutoMapperProfile : Profile
        {
        public AutoMapperProfile()
        {
                CreateMap<UserSnippit, SnippitDetailViewModel>()
                                .ReverseMap();

                CreateMap<UserSnippit, SnippitCreateViewModel>()
                                .ReverseMap();

                CreateMap<UserSnippit, SnippitEditViewModel>()
                                .ReverseMap();

                CreateMap<UserSnippit, SnippitDeleteViewModel>()
                                .ReverseMap();

                CreateMap<Author, AuthorViewModel>()
                                .ReverseMap();
        }
    }
}
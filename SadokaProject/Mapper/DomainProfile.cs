using AutoMapper;
using Languagy_project.Data.Entities;
using Languagy_project.Models;

namespace Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Header, HeaderVM>();
            CreateMap<HeaderVM, Header>();

            CreateMap<Subscriptions, SubscriptionsVM>();
            CreateMap<SubscriptionsVM, Subscriptions>();

            CreateMap<ContactUS, ContactUSVM>();
            CreateMap<ContactUSVM, ContactUS>();

            CreateMap<Welcome, WelcomeVM>();
            CreateMap<WelcomeVM, Welcome>();

            CreateMap<Theme, ThemeVM>();
            CreateMap<ThemeVM, Theme>();

            CreateMap<Features, FeaturesVM>();
            CreateMap<FeaturesVM, Features>();

            CreateMap<Partners, PartnersVM>();
            CreateMap<PartnersVM, Partners>();

            CreateMap<Members, MembersVM>();
            CreateMap<MembersVM, Members>();

            CreateMap<Questions, QuestionsVM>();
            CreateMap<QuestionsVM, Questions>();

        }
    }
}

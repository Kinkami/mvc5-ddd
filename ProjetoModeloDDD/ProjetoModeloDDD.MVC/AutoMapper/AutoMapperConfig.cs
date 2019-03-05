using AutoMapper;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static IMapper Mapper { get; private set; }
        public static void RegisterMappings()
        {
            //Mapper.Initialize(x => x.AddProfile<DomainToViewModelMappingProfile>());
            //Mapper.Initialize(x => x.AddProfile<ViewModelToDomainMappingProfile>());
            AutoMapperConfig.Mapper = new MapperConfiguration((mapper) =>
            {
                mapper.AddProfile<DomainToViewModelMappingProfile>();
                mapper.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}
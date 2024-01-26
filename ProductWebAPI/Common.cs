using AutoMapper;
namespace ProductWebAPI
{
    public static class Common
    {
        /// <summary>
        /// To generate the instance for AutoMapper
        /// </summary>
        /// <returns></returns>
        public static IMapper CreateMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });

            return config.CreateMapper();
        }
    }
}

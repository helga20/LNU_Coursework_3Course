using AutoMapper;
using ZNO.BLL.Models;
using ZNO.DAL.Models;


namespace ZNO.BLL.Profiles
{
    public class AutoMapping :Profile
    {
        public AutoMapping()
        {
            CreateMap<Model1, Model1Dto>();
            CreateMap<Model1Dto, Model1>();
        }
    }
}

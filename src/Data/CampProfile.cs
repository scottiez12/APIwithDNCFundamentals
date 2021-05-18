using AutoMapper;
using CoreCodeCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCodeCamp.Data
{
    public class CampProfile : Profile
    {
        public CampProfile( )
        {
            this.CreateMap<Camp, CampModel>()
                .ForMember(x => x.Venue, y => y.MapFrom(z => z.Location.VenueName))
                .ReverseMap(); 

            this.CreateMap<Talk, TalkModel>()
                .ReverseMap(); 

            this.CreateMap<Speaker, SpeakerModel>()
                .ReverseMap(); 
        }
    }
}

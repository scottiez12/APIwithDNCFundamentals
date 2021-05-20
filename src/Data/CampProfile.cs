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
                .ReverseMap()
                //this is effectively saying "dont get rid of the camp and the speaker" just because we're updating a talk model that doesn't neccessairly
                //have a camp or speaker specified..
                .ForMember(t => t.Camp, opt => opt.Ignore())
                .ForMember(t => t.Speaker, opt => opt.Ignore());
            

            this.CreateMap<Speaker, SpeakerModel>()
                .ReverseMap(); 
        }
    }
}

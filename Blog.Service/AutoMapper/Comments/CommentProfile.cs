using AutoMapper;
using Blog.Entity.DTOs.Comments;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.AutoMapper.Comments
{
    public class CommentProfile : Profile
    {
        public CommentProfile() 
        {
            CreateMap<Comment, CommentDto>().ReverseMap();
            CreateMap<Comment, CommentAddDto>().ReverseMap();
        }
    }
}

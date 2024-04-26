using AutoMapper;
using TodoAPI.Models;
using TodoAPI.ViewModels;

namespace TodoAPI.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Todo, TodoViewModel>();
        CreateMap<TodoViewModel, Todo>();
    }
}

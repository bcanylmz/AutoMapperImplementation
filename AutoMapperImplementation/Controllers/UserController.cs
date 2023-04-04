using AutoMapper;
using AutoMapperImplementation.DTO;
using AutoMapperImplementation.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperImplementation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private static readonly List<User> Users = new List<User>()
        {
            new User()
            {
                UserId = 1,
                FirstName="Barýþ",
                MiddleName="Can",
                LastName="YILMAZ",
                UserName="bcanylmz",
                Password="12345",
                Age=27,
                Email="me@bariscanyilmaz.net"
            },
            new User() {
                UserId = 2,
                FirstName="Halil",
                MiddleName="Can",
                LastName="TURAN",
                UserName="hcanturan",
                Password="54321",
                Age=27,
                Email="halilcan@example.com"
            },
            new User() {
                UserId = 3,
                FirstName="Fatih",
                MiddleName= string.Empty,
                LastName="KODALAK",
                UserName="fkodalak",
                Password="32142",
                Age=26,
                Email="fkodalak@example.com"
            },
        };

        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper=mapper;
        }

        /// <summary>
        /// Not Auto Mapper
        /// </summary>
        /// <returns></returns>
        //[HttpGet(Name = "UserListNotAutoMapper")]
        //public IEnumerable<UserListDto> Get()
        //{
        //    List<UserListDto> userCollection = new();
        //    UserListDto userListDto;
        //    foreach (var user in Users)
        //    {
        //        userListDto = new();
        //        userListDto.UserId = user.UserId;
        //        userListDto.FirstName = user.FirstName;
        //        userListDto.LastName = user.LastName;
        //        userListDto.Email = user.Email;
        //        userCollection.Add(userListDto);
        //    }
        //    return userCollection;
        //}

        [HttpGet(Name = "UserListByAutoMapper")]
        public IEnumerable<UserListDto> GetTest()
        {
            return _mapper.Map<List<UserListDto>>(Users);
        }
    }
}
using AutoMapperImplementation.ViewModel;

namespace AutoMapperImplementation.ViewResult
{
    public class UserListVR
    {
        public UserListVM Model { get; set; }
        public string Message { get; set; }
        public bool Status { get; set; }
    }
}

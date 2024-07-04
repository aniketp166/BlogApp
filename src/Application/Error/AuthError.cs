namespace Application;

public static class AuthError
{
    public static Error InvalidRegisterRequest => new(ErrorTypeConstant.ValidationError, "Invalid Register request");
    public static Error UserAlreadyExist => new(ErrorTypeConstant.ValidationError, "User Already Exist");
    public static Error InvalidLoginRequest => new(ErrorTypeConstant.ValidationError, "Invalid Login request");
    public static Error UserNotFound => new(ErrorTypeConstant.NotFound, "User not found");
    public static Error InValidPassword => new(ErrorTypeConstant.ValidationError, "Invalid password");

}

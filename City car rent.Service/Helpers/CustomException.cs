namespace City_car_rent.Service.Helpers;
public class CustomException:Exception
{
    public int Code { get; set; }
    public CustomException(int code, string message):base(message)
    {  
        Code= code;
    }
}

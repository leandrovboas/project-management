namespace ProjectManagement.Application.Exceptions;

public class ResponseErrorJson
{
  public ResponseErrorJson(string message){
    ErrorMessage = message;
  }
  public string ErrorMessage { get; set; }= string.Empty;
}
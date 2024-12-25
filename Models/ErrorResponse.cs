namespace TodoAPI.Models;

   public class ErrorResponse
{
 public string Title { get; set; }
 public int StatusCode { get; set; }
 public string Message { get; set; }
}


// This ErrorResponse model will be used to return error messages to the client when an error occurs in our 
// application. It includes a title for the error, massage, and a status code, providing the client with useful
//  information about what went wrong.
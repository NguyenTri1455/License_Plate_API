using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace License_Plate_API.Model
{
    public class ResponseModel
    {
        public string? Status { get; set; }
        public string? Message { get; set; }
        public string? Data { get; set; }
        public string? RootImagePath { get; set; }
        public string? PlateImagePath { get; set; }
        public ResponseModel() { }
        public ResponseModel(string status, string message, Object data)
        {
            Status = status;
            Message = message;
            Data = JsonConvert.SerializeObject(data);
        }
        public ResponseModel(string status, string message)
        {
            Status = status;
            Message = message;
            Data = null;
        }
    }
    public class ResponseModelSuccess : ResponseModel
    {
        public ResponseModelSuccess()
        {
        }

        public ResponseModelSuccess(string message, Object? data = null)
        {
            Status = "OK";
            Message = message;
            Data = JsonConvert.SerializeObject(data);
        }
    }
    public class ResponseModelError : ResponseModel
    {
        public ResponseModelError()
        {
        }

        public ResponseModelError(string message, Object? data = null)
        {
            Status = "Error";
            Message = message;
            Data = JsonConvert.SerializeObject(data);
        }
    }
}

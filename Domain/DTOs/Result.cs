using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Domain.Enums;


namespace Domain.DTOs
{
    public class Result
    {
        [JsonIgnore]
        public ResultStatus Status { get; set; }
        public string? Error { get; set; }

        public static Result Success(ResultStatus status) => new() { Status = status };
        public static Result Failure(string error, ResultStatus status) => new() { Status = status, Error = error };
    }

    public class Result<T>
    {
        [JsonIgnore]
        public ResultStatus Status { get; set; }
        public string? Error { get; set; }
        public T? Data { get; set; }

        public static Result<T> Success(T data, ResultStatus status) => new() { Status = status, Data = data };
        public static Result<T> Failure(string error, ResultStatus status) => new() { Status = status, Error = error };
    }
}
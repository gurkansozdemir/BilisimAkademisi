using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OBS.Core.DTOs
{
    public class CustomResponseDto<T>
    {
        public T Data { get; set; }
        public List<string> Errors { get; set; }

        public static CustomResponseDto<T> Success(T data)
        {
            return new CustomResponseDto<T> { Data = data };
        }

        public static CustomResponseDto<T> Fail(List<string> errors)
        {
            return new CustomResponseDto<T> { Errors = errors };
        }
    }
}
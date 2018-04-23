﻿using System;

namespace Services.Api.Responses
{
    public abstract class ServiceResponse<TResult>
    {
        public bool Succeeded { get; set; }
        public string Error { get; set; }
        public TResult Result { get; set; }
    }
}

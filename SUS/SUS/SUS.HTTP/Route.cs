﻿using SUS.HTTP;
using System;

namespace SUS.HTTP
{
    public class Route
    {
        public Route(string path,HttpMethod method, Func<HttpRequest, HttpResponse> action)
        {
            this.Path = path;
            this.Action = action;
            this.Method = method;
        }
        public string Path { get; set; }

        public HttpMethod Method { get; set; }
        public Func<HttpRequest, HttpResponse> Action { get; set; }
    }
}

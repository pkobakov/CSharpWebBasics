﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUS.HTTP
{
    public class ResponseCookie:Cookie
    {
        public ResponseCookie(string name, string value)
            :base(name, value)
        {
            this.Path = "/";
        }

        public int MaxAge { get; set; }
        public bool HttpOnly { get; set; }
        public string Path { get; set; }

        //Response Cookie Example:
        //Set-Cookie: SSDI=Ap$p_GTEq; Domain=foo.com; Path=/; Max-Age=2; Expires=Wed, 13 Jan 2021
        public override string ToString()
        {
            StringBuilder cookieBuilder = new StringBuilder();
            cookieBuilder.Append($"{this.Name}={this.Value}; Path={this.Path};");

            if (MaxAge != 0 )
            {
                cookieBuilder.Append($" Max-Age={this.MaxAge};");
            }

            if (this.HttpOnly)
            {
                cookieBuilder.Append($" HttpOnly;");
            }
            return cookieBuilder.ToString();
        }
    }
}

﻿using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeRest
{
    class Program
    {
        static void Main(string[] args)
        {
            QuoteGenerator.KanyeQuote();
            QuoteGenerator.RonQuote();
        }
    }
}

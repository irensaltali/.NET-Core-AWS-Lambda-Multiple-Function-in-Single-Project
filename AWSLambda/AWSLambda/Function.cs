using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace AWSLambda
{
    public class Function
    {
        public string ToUpper(string input, ILambdaContext context)
        {
            return input?.ToUpper();
        }

        public string ToLower(string input, ILambdaContext context)
        {
            return input?.ToLower();
        }
    }
}

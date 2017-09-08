using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class StringReverser : IStringReverser
    {
        public ReverseResponse Reverse(ReverseRequest request)
        {
            return new ReverseResponse
            {
                Text = string.Join("Welcome ", request.Text.Reverse().ToArray())
            };
        }
    }
}

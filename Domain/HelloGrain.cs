using Contracts;
using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class HelloGrain : Grain, IHelloGrain
    {
        public Task<string> Hello(string name)
        {
            return Task.FromResult($"Hello {name}");
        }
    }
}

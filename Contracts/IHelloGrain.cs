using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IHelloGrain : IGrainWithGuidKey
    {
        Task<string> Hello(string name);
    }
}

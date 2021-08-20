using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroDependencyInjection.Services
{
    public interface IScopedService : IService
    {
    }

    public class ScopedService : IScopedService
    {
        private string _guid;
        public ScopedService()
        {
            _guid = Guid.NewGuid().ToString();
        }
        public string GetGuid()
        {
            return _guid;
        }
    }
}

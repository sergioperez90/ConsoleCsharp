using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Services
{
    interface IService
    {
        Task<Quandl> GetCompanyData();
    }
}

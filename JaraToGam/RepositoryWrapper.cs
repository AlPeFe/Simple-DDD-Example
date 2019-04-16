using JaraToGam.Interface;
using JaraToGam.Models;
using JaraToGam.Repos;
using System;
using System.Collections.Generic;
using System.Text;

namespace JaraToGam
{
    class RepositoryWrapper : IRepositoryWrapper
    {
        private GamContext _gamContext;
        private IGamRepository _gam;
        public IGamRepository GamRepository => _gam ?? new GamRepository(_gamContext);

        public RepositoryWrapper(GamContext gamContext)
        {
            _gamContext = gamContext;
        }
    }
}

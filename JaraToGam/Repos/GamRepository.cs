using System;
using System.Collections.Generic;
using System.Text;
using JaraToGam.Interface;
using JaraToGam.Models;

namespace JaraToGam.Repos
{
    public class GamRepository : RepositoryGeneric<Srv>, IGamRepository
    {
        public GamRepository(GamContext gamContext)
            : base(gamContext)
        {
        }

    }
}

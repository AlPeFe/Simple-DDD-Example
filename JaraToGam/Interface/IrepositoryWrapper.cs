using System;
using System.Collections.Generic;
using System.Text;

namespace JaraToGam.Interface
{
    interface IRepositoryWrapper
    {
        IGamRepository GamRepository { get; }
    }
}

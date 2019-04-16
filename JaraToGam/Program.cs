using JaraToGam.Interface;
using JaraToGam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace JaraToGam
{
    class Program
    {
        static void Main(string[] args)
        {

            var serviceProvider = new ServiceCollection()
                .AddScoped<IRepositoryWrapper, RepositoryWrapper>()
                .AddDbContext<GamContext>(opt => opt.UseSqlServer("")); 




    
        }
    }
}

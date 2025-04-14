using AutoMapper.Configuration;
using Dal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationsSystem
{
    public class BasicConfiguration : BaseConfiguration
    {
        public string ConnectionString { get; private set; }

        public BasicConfiguration(IConfiguration configuration) : base(configuration) { }
    }
}

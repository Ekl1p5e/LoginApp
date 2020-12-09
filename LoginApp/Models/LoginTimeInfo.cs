using LoginApp.Models.Interfaces;
using System;

namespace LoginApp.Models
{
    public class LoginTimeInfo : ILoginTimeInfo
    {
        public string Name { get; set; }

        public DateTime Time { get; set; }
    }
}

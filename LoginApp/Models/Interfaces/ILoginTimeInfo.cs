using System;

namespace LoginApp.Models.Interfaces
{
    public interface ILoginTimeInfo
    {
        string Name { get; set; }

        DateTime Time { get; set; }
    }
}

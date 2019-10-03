using System;

namespace SqImport.Services.Interfaces
{
    public interface ILogService
    {
        void Log(Exception ex);
    }
}
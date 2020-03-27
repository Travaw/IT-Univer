﻿using ITUniversity.Runtime.Session;

namespace ITUniversity.Application.Services
{
    /// <summary>
    /// Базовый интерфейс для всех сервисов приложения
    /// </summary>
    public interface IApplicationService
    {
        IAppSession AppSession { get; }
    }
}
﻿using System.Collections.Generic;
using ITUniversity.Application.Services;
using ITUniversity.Tasks.Application.Services.Dto;

namespace ITUniversity.Tasks.Application.Services
{
    /// <summary>
    /// Сервис для работы с пользователями
    /// </summary>
    public interface IUserAppService : IApplicationService
    {
        /// <summary>
        /// Создать пользователя
        /// </summary>
        /// <param name="dto"></param>
        UserDto Create(CreateUserDto dto);

        /// <summary>
        /// Получить пользователя
        /// </summary>
        /// <param name="login">Логин</param>
        UserDto Get(string login);

        /// <summary>
        /// Получить пользователя
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        UserDto Get(string login, string password);

        ICollection<UserDto> GetAll();

        /// <summary>
        /// Проверить пароль
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="password">Пароль</param>
        bool IsValidPassword(UserDto dto, string password);

        /// <summary>
        /// Заблокировать пользователя
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="password">Пароль</param>
        bool Block(int id);
    }
}
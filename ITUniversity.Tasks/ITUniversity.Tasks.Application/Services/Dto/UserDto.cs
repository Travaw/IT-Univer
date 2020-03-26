namespace ITUniversity.Tasks.Application.Services.Dto
{
    /// <summary>
    /// 
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Логин
        /// </summary>
        public string Login
        {
            get;
            set;
        }

        /// <summary>
        /// Почта
        /// </summary>
        public string Email
        {
            get;
            set;
        }

        public bool IsBlocked
        {
            get;
            set;
        }
    }
}
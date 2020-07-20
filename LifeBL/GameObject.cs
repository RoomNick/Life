namespace LifeBL
{
    public class GameObject : IChangeHealth
    {
        /// <summary>
        /// Шкала здоровья персонажа
        /// </summary>
        private int _health;

        public int Health
        {
            get => _health;
        }

        /// <summary>
        /// Показатель жив персонаж или нет
        /// </summary>
        private bool _isLive;

        public bool IsLive {
            get
            {
                if (_health <= 0)
                {
                    _isLive = false;
                }

                return _isLive;
            }
        }

        public void ChangeHealth(int change)
        {
            this._health -= change;
        }

        /// <summary>
        /// Если нет параметров, то задаются дефолтные значения
        /// </summary>
        public GameObject()
        {
            this._health = 100;
            this._isLive = false;
        }

        public GameObject(int health)
        {
            this._health = health;
            this._isLive = true;
        }
    }
}
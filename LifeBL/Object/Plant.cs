namespace LifeBL.Object
{
    public class Plant : IChangeHeigth
    {
        private GameObject _gameObject;

        public GameObject GameObject
        {
            get => _gameObject;
            set
            {
                _gameObject = value ?? new GameObject();
            }
        }
        
        /// <summary>
        /// Рост растения
        /// </summary>
        private int _heigth;

        public int Heigth
        {
            get
            {
                return _heigth;
            }
        }

        /// <summary>
        /// Сколько теряется здоровья за 1 атаку
        /// </summary>
        private int _vitality;

        public int Vitality
        {
            get => _vitality;
            set => _vitality = value;
        }

        public Plant()
        {
            this._gameObject = new GameObject();
            this._heigth = 50;
        }

        public Plant(int heigth)
        {
            this._heigth = heigth;
            this._gameObject = new GameObject();
        }

        public Plant(int heigth, int health)
        {
            this._heigth = heigth;
            this._gameObject = new GameObject(health);
        }

        public void ChangeHeigth()
        {
            _heigth++;
        }

        public void ChangeHealthAfterAttack()
        {
            _gameObject.ChangeHealth(_vitality);
        }
    }
}
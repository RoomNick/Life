using LifeBL.Check;

namespace LifeBL.Object.PlantPers
{
    /// <summary>
    /// Дерево
    /// </summary>
    public class Tree : ITakeAStepPlant
    {
        private Environment _environment;

        public Environment Environment => _environment;

        private Plant _plant;

        public Plant Plant
        {
            get => _plant;
            set
            {
                _plant = value ?? new Plant();
            }
        }

        public Tree()
        {
            _plant = new Plant();
            _environment.Type = TypeEnvironment.Land;
        }

        /// <summary>
        /// Выполняется при совершении хода
        /// </summary>
        public void ChangeHeigth()
        {
            _plant.ChangeHeigth();
        }

        /// <summary>
        /// Выполняется после атаки на растение
        /// </summary>
        public void ChangeHealthAfterAttack()
        {
            _plant.ChangeHealthAfterAttack();
        }
    }
}
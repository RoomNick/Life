using LifeBL.Check;

namespace LifeBL.Object.PlantPers
{
    public class Seaweed : ITakeAStepPlant
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

        public Seaweed()
        {
            _plant = new Plant();
            _environment.Type = TypeEnvironment.Water;
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
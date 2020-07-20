namespace LifeBL.Object
{
    /// <summary>
    /// действия при совершении хода 
    /// </summary>
    public interface ITakeAStepPlant
    {
        public void ChangeHeigth();
        public void ChangeHealthAfterAttack();
    }
}
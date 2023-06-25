namespace Architecture
{
    public class BankInteractor : Interactor
    {
        private BankRepository _repository;

        public int Coins
        {
            get
            {
                if (_repository != null)
                {
                    return _repository.Coins;
                }

                return 0;
            }
        }

        public override void OnCreate()
        {
            base.OnCreate();
            _repository = Tester.Scene.GetRepository<BankRepository>();
            
        }

        public void AddCoins(object sender, int value)
        {
            _repository.Coins += value;
            _repository.Save();
        }

        public void SpendCoins(object sender, int value)
        {
            _repository.Coins -= value;
            _repository.Save();
        }
        
        
    }
}


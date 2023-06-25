using UnityEngine;

namespace Architecture
{
    public class BankRepository : Repository
    {
        private const string KEY = "COINS_KEY";
        public int Coins { get; set; }
        public override void Initialize()
        {
            Coins = PlayerPrefs.GetInt(KEY, 0);
        }
        
        public override void Save()
        {
            PlayerPrefs.SetInt(KEY,Coins);
        }
    }
}



namespace Class1
{
    /// <summary>
    /// 
    /// </summary>
    public class Enemy
    {
        // Attributo privato
        // il private health è accessibile dall'esterno della classe Enemy 
        private int _health; //mutabile

        //attributo costante privato
        private const int _maxHealth = 100; //salute massima nemico

        //proprietà pubblica per accedere all'attributo privato _health
        public int Health { get; private set; } //forma abbreviata senza conotrolli

        //public int Health
        //{
        //    get { return _health; }
        //    set
        //    {
        //        if (value < 0)// caso limite1
        //        {
        //            _health = 0;
        //        } else if (value > _maxHealth)// caso limite2
        //        {
        //            _health = _maxHealth;
        //        }
        //        else // caso normale
        //        {
        //            _health = value;
        //        }
        //    }
        //}



        //costruttore pubblico per istanziare un oggetto della classe Enemy
        public Enemy()
        {

        }

        public void setHealth (int newHealth)
        {
            if (newHealth < 0)
                Health = 0; //se il costrutto è solo una riga, si possono omettere le parentesi graffe
            else if (newHealth > _maxHealth
                Health = _maxHealth;
            else
                Health = newHealth;
        }
    }

}

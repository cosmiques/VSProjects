using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BottleImp
{
    class Deck
    {
        private List<Card> _cards;
        private Random _rng = new Random();

        public Deck()
        {
            #region full carddeck
            _cards = new List<Card>();
            _cards.Add(new Card() { CardNumber = 1, ColorValue = Color.Yellow, CoinValue = 1 });
            _cards.Add(new Card() { CardNumber = 2, ColorValue = Color.Yellow, CoinValue = 1 });
            _cards.Add(new Card() { CardNumber = 3, ColorValue = Color.Yellow, CoinValue = 2 });
            _cards.Add(new Card() { CardNumber = 4, ColorValue = Color.Blue, CoinValue = 1 });
            _cards.Add(new Card() { CardNumber = 5, ColorValue = Color.Yellow, CoinValue = 2 });
            _cards.Add(new Card() { CardNumber = 6, ColorValue = Color.Blue, CoinValue = 1 });
            _cards.Add(new Card() { CardNumber = 7, ColorValue = Color.Yellow, CoinValue = 3 });
            _cards.Add(new Card() { CardNumber = 8, ColorValue = Color.Blue, CoinValue = 2 });
            _cards.Add(new Card() { CardNumber = 9, ColorValue = Color.Yellow, CoinValue = 3 });
            _cards.Add(new Card() { CardNumber = 10, ColorValue = Color.Blue, CoinValue = 2 });
            _cards.Add(new Card() { CardNumber = 11, ColorValue = Color.Red, CoinValue = 1 });
            _cards.Add(new Card() { CardNumber = 12, ColorValue = Color.Yellow, CoinValue = 4 });
            _cards.Add(new Card() { CardNumber = 13, ColorValue = Color.Blue, CoinValue = 3 });
            _cards.Add(new Card() { CardNumber = 14, ColorValue = Color.Red, CoinValue = 1 });
            _cards.Add(new Card() { CardNumber = 15, ColorValue = Color.Yellow, CoinValue = 4 });
            _cards.Add(new Card() { CardNumber = 16, ColorValue = Color.Red, CoinValue = 2 });
            _cards.Add(new Card() { CardNumber = 17, ColorValue = Color.Blue, CoinValue = 3 });
            _cards.Add(new Card() { CardNumber = 18, ColorValue = Color.Yellow, CoinValue = 5 });
            _cards.Add(new Card() { CardNumber = 19, ColorValue = Color.Black, CoinValue = 0});
            _cards.Add(new Card() { CardNumber = 20, ColorValue = Color.Blue, CoinValue = 4 });
            _cards.Add(new Card() { CardNumber = 21, ColorValue = Color.Red, CoinValue = 2 });
            _cards.Add(new Card() { CardNumber = 22, ColorValue = Color.Yellow, CoinValue = 5 });
            _cards.Add(new Card() { CardNumber = 23, ColorValue = Color.Red, CoinValue = 3 });
            _cards.Add(new Card() { CardNumber = 24, ColorValue = Color.Blue, CoinValue = 4 });
            _cards.Add(new Card() { CardNumber = 25, ColorValue = Color.Yellow, CoinValue = 6 });
            _cards.Add(new Card() { CardNumber = 26, ColorValue = Color.Red, CoinValue = 3 });
            _cards.Add(new Card() { CardNumber = 27, ColorValue = Color.Blue, CoinValue = 5 });
            _cards.Add(new Card() { CardNumber = 28, ColorValue = Color.Yellow, CoinValue = 6 });
            _cards.Add(new Card() { CardNumber = 29, ColorValue = Color.Red, CoinValue = 4 });
            _cards.Add(new Card() { CardNumber = 30, ColorValue = Color.Blue, CoinValue = 5 });
            _cards.Add(new Card() { CardNumber = 31, ColorValue = Color.Red, CoinValue = 4 });
            _cards.Add(new Card() { CardNumber = 32, ColorValue = Color.Blue, CoinValue = 6 });
            _cards.Add(new Card() { CardNumber = 33, ColorValue = Color.Red, CoinValue = 5 });
            _cards.Add(new Card() { CardNumber = 34, ColorValue = Color.Blue, CoinValue = 6 });
            _cards.Add(new Card() { CardNumber = 35, ColorValue = Color.Red, CoinValue = 5 });
            _cards.Add(new Card() { CardNumber = 36, ColorValue = Color.Red, CoinValue = 6 });
            _cards.Add(new Card() { CardNumber = 37, ColorValue = Color.Red, CoinValue = 6 });
            #endregion
        }

        public List<Card> GetCards()
        {
            return _cards;
        }


        public void Shuffle()
        {
            int n = _cards.Count;
            while (n > 1)
            {
                n--;
                int k = _rng.Next(n + 1);
                Card tempCard = _cards[k];
                _cards[k] = _cards[n];
                _cards[n] = tempCard;
            }
        }

    }
}

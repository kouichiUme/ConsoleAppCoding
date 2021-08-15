using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Chapter7CardDeck
    {
    }

    public enum Suit
    {
        Club = 0, Diamond = 1, Heart = 2, Spade = 3
    };

    public static class SuitExtension
    {
        public static Suit s = Suit.Spade;

        public static Suit getSuitFromValue(int value)
        {


            return Suit.Spade;

        }

        public static Suit getValue(this Suit suit)
        {
            return suit;
        }

        //https://www.arungudelli.com/tutorial/c-sharp/how-to-cast-int-to-enum-in-c-sharp/
        //To cast int to enum in C# use the below single line C# code
        //SampleEnum sample = (SampleEnum)IntVariable;

        public static Suit getFromValue(this Suit suit, int i)
        {

            switch (i)
            {
                case ((int)Suit.Club):
                    return Suit.Club;
                case ((int)Suit.Diamond):
                    return Suit.Diamond;
                case ((int)Suit.Heart):
                    return Suit.Heart;
                case ((int)Suit.Spade):
                    return Suit.Spade;
                default:
                    return Suit.Spade;
            }

        }

    }

    public abstract class Cards
    {
        private int value;
        private Suit s;


        public int getValue()
        {
            return value;
        }

        // 
        public Suit getSuit()
        {
            return s;
        }

    }
    public class BlackJackCards : Cards
    {

    }


    // プレイヤーの手持ちのカード群
    public class Hand <T> where T : Cards
    {

        LinkedList<Cards> a = new LinkedList<Cards>();




        // after draw Card add to This Hand

        public void drawCardFromDeck(Deck<Cards> d)
        {
            Cards c = d.draw();

            this.addCard(c);


        }

        public void addCard(Cards c)
        {
            this.a.AddLast(c);
        }




        // 手持ちカードの点数
        public int Score()
        {
            int scoreValue = 0;

            foreach(Cards c in a)
            {

                scoreValue += c.getValue();
            }


            return scoreValue;
        }

        

    }

    public class BlackJackHand : Hand<BlackJackCards>
    {



    }


    // ゲームのデッキ（ここからカードをとる）
    public class Deck<T> where T : Cards
    {
        LinkedList<T> cardsStack = new LinkedList<T>();


        // Cards 混ぜる(shuffle?)
        void shuffle()
        {
            
        }

        // draw one card from stack
        public T draw()
        {

            T c = cardsStack.Last.Value;
            cardsStack.RemoveLast();


            return c;
        }
    }

    public class Dealer
    {
        LinkedList<Hand<Cards>> players = new LinkedList<Hand<Cards>>();

        public void draw(Deck<Cards> d)
        {
            for (int i = 0; i < players.Count; i++){
                Cards c = d.draw();

                players[i].addCard(c);
            }
        }

        public void addPlayer(Hand<Cards> c)
        {
            players.AddLast(c);
        }
    }


    public class CardGame
    {
        public static void  main(string[] args)
        {

            ConsoleApp1.Deck<Cards> d = new ConsoleApp1.Deck<Cards>();

            Hand<Cards> playerHands = new Hand<Cards>();

            Dealer dealer = new Dealer();

            dealer.addPlayer(playerHands);
            dealer.draw(d);

            playerHands.drawCardFromDeck(d);

            playerHands.Score();

            int exitCode = 0;
            Environment.Exit(exitCode);

        }
    }


}

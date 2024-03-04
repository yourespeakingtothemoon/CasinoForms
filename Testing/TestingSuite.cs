using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoForms.Testing
{
    public enum Result
    {
        Undecided,
        Passed,
        Failed
    }
    public struct Test
    {
        public Result result;
        public Label label;
    }


    internal class TestingSuite
    {
        List<Test> tests = new List<Test>();
        public TestView view;

        public void execute()
        {
            testWithdraw();
            testDeposit();
            testDepositWithdraw();
            testDeckCount();
            testDeckSuits();
            testDeckCardsForDupes();
            testPayout();

            updateColors();

        }


        void updateColors()
        {
                        foreach (var test in tests)
            {
                if (test.result == Result.Passed)
                {
                    test.label.ForeColor = System.Drawing.Color.Green;
                }
                else if (test.result == Result.Failed)
                {
                    test.label.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    test.label.ForeColor = System.Drawing.Color.Black;
                }
            }
        }
        



        //applicationManager and User Model Tests

        public void testWithdraw()
        {
            Test test = new Test { result = Result.Undecided, label = view.withdrawcheck};
            //Arrange
            CasinoForms.Models.UserModel user = new CasinoForms.Models.UserModel("test", 100);
            CasinoForms.Models.BankModel bank = new CasinoForms.Models.BankModel(100);
            float amount = 1;
            float expectedUserBalance = 101;
            float expectedBankBalance = 99;

            //Act
            bank.Withdraw(user, amount);

            //Assert
            AddTest(test, user.balance == expectedUserBalance && bank.balance == expectedBankBalance);
        }

        public void testDeposit()
        {
            Test test = new Test { result = Result.Undecided, label = view.depositcheck };
            //Arrange
            CasinoForms.Models.BankModel bank = new CasinoForms.Models.BankModel(100);
            CasinoForms.Models.UserModel user = new CasinoForms.Models.UserModel(1,"test", 100, bank);
            float amount = 1;
            float expectedUserBalance = 99;
            float expectedBankBalance = 101;

            //Act
            user.Deposit(amount);

            //Assert
            AddTest(test, user.balance == expectedUserBalance && bank.balance == expectedBankBalance);
        }
        public void testDepositWithdraw()
        {
            Test test = new Test { result = Result.Undecided, label = view.depositandwithdrawcheck };
            //Arrange
            CasinoForms.Models.BankModel bank = new CasinoForms.Models.BankModel(100);
            CasinoForms.Models.UserModel user = new CasinoForms.Models.UserModel(1,"test", 100, bank);
            float DepositAmount = 50;
            float WithdrawAmount = 25;
            float expectedUserBalance = 75;
            float expectedBankBalance = 125;

            //Act
            user.Deposit(DepositAmount);
            bank.Withdraw(user, WithdrawAmount);

            //Assert
            AddTest(test, user.balance == expectedUserBalance && bank.balance == expectedBankBalance);

        }

        //Deck Tests
        public void testDeckCount()
        {
           Test test = new Test { result = Result.Undecided, label = view.decktest1 };
            //Arrange
            CasinoForms.Controllers.GameManager game = new CasinoForms.Controllers.GameManager();
            game.SetDeck();
            int expected = 52;

            //Act
            int actual = game.getDeck().Count;

            //Assert
            AddTest(test, actual == expected);
        }
        
        public void testDeckSuits()
        {
            Test test = new Test { result = Result.Undecided, label = view.Decktest2 };
            //Arrange
            CasinoForms.Controllers.GameManager game = new CasinoForms.Controllers.GameManager();
            game.SetDeck();
            int expected = 13;
            List<int> expectedList = new List<int> { 13, 13, 13, 13 };

            //Act
            int actual = game.getDeck().Count / 4;
            List<int> suitCounts = CountSuits(game.getDeck());
            bool suitsEven = suitCounts.TrueForAll(x => x == expected);


            //Assert
            AddTest(test, actual == expected && suitCounts.Count == 4 && suitsEven);
        }

        public void testDeckCardsForDupes()
        {
            Test test = new Test { result = Result.Undecided, label = view.Decktest3 };
            //Arrange
            List<CasinoForms.Models.CardModel> check = new List<CasinoForms.Models.CardModel>();
            CasinoForms.Controllers.GameManager game = new CasinoForms.Controllers.GameManager();
            game.SetDeck();
            List<CasinoForms.Models.CardModel> deck = game.getDeck();

            //Act
            foreach (var card in deck)
            {
                if (check.Contains(card))
                {
                    AddTest(test, false);
                    return;
                }
                check.Add(card);
            }

            //Assert
            AddTest(test, check.Count == 52);

        }

        //payout test

        public void testPayout()
        {
            Test test = new Test { result = Result.Undecided, label = view.Payout };
            //Arrange
            CasinoForms.Models.UserModel user = new CasinoForms.Models.UserModel("test", 100);
           ;
            CasinoForms.Models.PlayerModel player = new CasinoForms.Models.PlayerModel("test", 100, new List<CasinoForms.Models.CardModel>());
            float expectedUserBalance = 200;
                

            //Act
            CasinoForms.Controllers.ApplicationManager app = new CasinoForms.Controllers.ApplicationManager(user, 100);
            app.Payout(player);

            //Assert
            AddTest(test, user.balance == expectedUserBalance);
        }





        //general methods used for testing

        public void AddTest(Test test, bool result)
        {
            Result output = result ? Result.Passed : Result.Failed;
            test.result = output;
            tests.Add(test);
        }

        public List<int> CountSuits(List<CasinoForms.Models.CardModel> deck)
        {
            List<int> result = new List<int> { 0, 0, 0, 0 };

            foreach(var card in deck)
            {
                if (card.suit == "Hearts")
                {
                    result[0]++;
                }
                else if (card.suit == "Diamonds")
                {
                    result[1]++;
                }
                else if (card.suit == "Clubs")
                {
                    result[2]++;
                }
                else if (card.suit == "Spades")
                {
                    result[3]++;
                }
            }

            return result;
        }
    }
}

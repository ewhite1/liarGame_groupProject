using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiarDice_grpProjCS
{
    class Player
    {
        //fields
        //d1 stands for die one, d2 for die two, etc.
        private string _name;
        private int _d1, _d2, _d3, _d4, _d5, _d6, _betNumOfDice, _betDieVal, _diceCountLeft;

        //constructor
        public Player()
        {

        }
        //properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int D1
        {
            get { return _d1; }
            set { _d1 = value; }
        }

        public int D2
        {
            get { return _d2; }
            set { _d2 = value; }
        }
        public int D3
        {
            get { return _d3; }
            set { _d3 = value; }
        }
        public int D4
        {
            get { return _d4; }
            set { _d4 = value; }
        }
        public int D5
        {
            get { return _d5; }
            set { _d5 = value; }
        }
        public int D6
        {
            get { return _d6; }
            set { _d6 = value; }
        }

        public int BetNumOfDice
        {
            get { return _betNumOfDice; }
            set { _betNumOfDice = value; }
        }
        public int BetDieValue
        {
            get { return _betDieVal; }
            set { _betDieVal = value; }
        }
        public int DiceCountLeft
        {
            get { return _diceCountLeft; }
            set { _diceCountLeft = value; }
        }
    }
}

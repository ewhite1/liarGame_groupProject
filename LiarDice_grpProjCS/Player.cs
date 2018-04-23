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
        private bool _d1On, _d2On, _d3On, _d4On, _d5On, _d6On, _won, _lost;

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
        public bool D1On
        {
            get { return _d1On; }
            set { _d1On = value; }
        }
        public bool D2On
        {
            get { return _d2On; }
            set { _d2On = value; }
        }
        public bool D3On
        {
            get { return _d3On; }
            set { _d3On = value; }
        }
        public bool D4On
        {
            get { return _d4On; }
            set { _d4On = value; }
        }
        public bool D5On
        {
            get { return _d5On; }
            set { _d5On = value; }
        }
        public bool D6On
        {
            get { return _d6On; }
            set { _d6On = value; }
        }
        public bool Lost
        {
            get { return _lost; }
            set { _lost = value; }
        }
        public bool Won
        {
            get { return _won; }
            set { _won = value; }
        }
    }
}

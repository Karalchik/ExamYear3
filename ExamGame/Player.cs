using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGame
{
    internal class Player
    {
        public string Nickname { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }

        public Player(string nickname, string address, string password)
        {
            Nickname = nickname;
            Address = address;
            Password = password;
        }
        public Player()
        {
            Nickname= "Null";
            Address= "Null";
            Password= "Null";
        }
        public override string ToString()
        {
            return $"{Nickname} , {Address} , {Password}";
        }
    }
}

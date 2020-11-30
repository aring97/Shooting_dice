using System;
using System.Collections.Generic;
namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer:SmackTalkingPlayer
    {
        public override int Roll(){
        List<string> Taunts =new List<string>{"taunt 1", "taunt 2", "taunt 3", "taunt 4", "taunt 5"};
        int TauntNumber=new Random().Next(5);
        Taunt=Taunts[TauntNumber];
        System.Console.WriteLine(Taunt);
        Player p=new Player();
        return p.Roll();
        }
    }
}
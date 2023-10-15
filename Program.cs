using System;
using RPG_GAME.Models;

Character character = new("Afonso","Mage", 1);
Console.WriteLine(character.GetCharacter());
Console.WriteLine(character.GetLifePoint());
character.DetailCharacter();

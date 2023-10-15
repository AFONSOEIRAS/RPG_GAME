namespace RPG_GAME.Models
{
    public class Character
    {
        private string Name { get; set; } //Criar uma classe de Status
        private CharacterLevel CharacterLevel { get; set; }
        private int LifePoint { get; set; }
        private int PhysicalAttack { get; set; }
        private int MagicAttack { get; set; }
        private int PhysicalDefense { get; set; }
        private int MagicDefense { get; set; }
        private int CriticalChance { get; set; }
        private int Skills { get; set; } //Criar uma classe de 4 a 8 Skills
        private CharacterClass CharacterClass { get; set; } //Criar  depois uma classe de Class
        private string Status { get; set; } //Criar uma classe de Status


        public Character(string name, string characterClass, int characterLevel)
        {
            Name = name;
            CharacterClass = new CharacterClass(characterClass);
            LifePoint = CharacterClass.GetBaseLifePoint();
            PhysicalAttack = CharacterClass.GetBasePhysicalAttack();
            MagicAttack = CharacterClass.GetBaseMagicAttack();
            MagicDefense = CharacterClass.GetBaseBaseMagicDefense();
            Skills = 0;
            CriticalChance = CharacterClass.GetBaseCriticalChance();
            Status= "None";
            CharacterLevel = new CharacterLevel(characterLevel);

        }

        public string GetName()
        {
          return Name;

        }
        public CharacterClass GetCharacter()
        {
          return CharacterClass;

        }

        public int GetLifePoint()
        {
            return LifePoint;
        }

        public int GetPhysicalAttack()
        {
            return PhysicalAttack;
        }

        public int GetMagicAttack()
        {
            return MagicAttack;
        }
        public int GetPhysicalDefense()
        {
            return PhysicalDefense;
        }

        public int GetMagicDefense()
        {
            return MagicDefense;
        }

        public int GetSkills()
        {
            return Skills;
        }

        public int GetCriticalChance()
        {
            return CriticalChance;
        }

        public void DetailCharacter(){
            Console.WriteLine("-------Character Details---------");
            Console.WriteLine("LifePoint: " + GetName());
            Console.WriteLine("ClassType: "+ CharacterClass.GetClassType());
            Console.WriteLine("LifePoint: " + GetLifePoint());
            Console.WriteLine("PhysicalAttack: "+ GetPhysicalAttack());
            Console.WriteLine("PhysicalAttack: "+ GetMagicAttack());
            Console.WriteLine("PhysicalDefense: "+ GetPhysicalDefense());
            Console.WriteLine("MagicDefense: "+ GetMagicDefense());
            Console.WriteLine("CriticalChance: "+ GetCriticalChance());


        }


    }
}
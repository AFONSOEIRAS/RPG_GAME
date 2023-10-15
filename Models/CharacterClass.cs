namespace RPG_GAME.Models
{
    public class CharacterClass
    {

        private string ClassType { get; set; }
        private int BaseLifePoint { get; set; }
        private int BasePhysicalAttack { get; set; }
        private int BaseMagicAttack { get; set; }
        private int BasePhysicalDefense { get; set; }
        private int BaseMagicDefense { get; set; }
        private int BaseCriticalChance { get; set; }


        public  CharacterClass(string classType)
        {
            ClassType = classType;
            switch (ClassType)
            {
                case "Mage":
                    BaseLifePoint = 100;
                    BasePhysicalAttack = 0;
                    BaseMagicAttack = 40;
                    BasePhysicalDefense = 20;
                    BaseMagicDefense = 5;
                    BaseCriticalChance = 0;
                    break;
                case "Warrior":
                    BaseLifePoint = 100;
                    BasePhysicalAttack = 10;
                    BaseMagicAttack = 0;
                    BasePhysicalDefense = 20;
                    BaseMagicDefense = 20;
                    BaseCriticalChance = 0;
                    break;
                case "Assassin": //ACHO QUE FALTA O RETURN
                    BaseLifePoint = 100;
                    BasePhysicalAttack = 60;
                    BaseMagicAttack = 0;
                    BasePhysicalDefense = 5;
                    BaseMagicDefense = 5; 
                    BaseCriticalChance = 0;
                    //Depois separar as classes Separadamente em outras classes e adicionar atributo evasão ao assassino, talvez chame as classes nesse construtor
                    break;
                default:
                    Console.WriteLine("Classe Inválida");
                    break;
            }

        }


        public string GetClassType()
        {
            return ClassType;
        }

        public string SetClassType(string classType)
        {
            return ClassType = classType;
        }

        
        public int GetBaseLifePoint()
        {
            return BaseLifePoint;
        }

        
        public int GetBasePhysicalAttack()
        {
            return BasePhysicalAttack;
        }

        
        public int GetBaseMagicAttack()
        {
            return BaseMagicAttack;
        }


        public int GetBasePhysicalDefense()
        {
            return BasePhysicalDefense;
        }


        public int GetBaseBaseMagicDefense()
        {
            return BaseMagicDefense;
        }

        public int GetBaseCriticalChance()
        {
            return BaseCriticalChance;
        }


    }
}
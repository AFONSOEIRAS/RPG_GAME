namespace RPG_GAME.Models
{
    public class CharacterLevel
    {
        private int Level { get; set; }
        private int ExperiencePoints { get; set; }
        private int NextLevelExperiencePoints { get; set; }


        public  CharacterLevel(int level)
        {
            Level = level;
        }

        public void LevelUp(int level, int experiencePoints)
        {   
            Level = level;
            int nextLevel;
            nextLevel = level * 100;
            while(experiencePoints > 0){
                if(experiencePoints >= nextLevel){
                    Level++;
                    experiencePoints = experiencePoints - nextLevel;
                } else{
                    nextLevel = nextLevel - experiencePoints;
                    experiencePoints = 0;
                }
            }

        }
        public int GetLevel()
        {
            return Level;
        }
        public int GetExperiencePoints()
        {
            return ExperiencePoints;
        }

        public int GetNextLevelExperiencePoints()
        {
            return NextLevelExperiencePoints;
        }


    }
}
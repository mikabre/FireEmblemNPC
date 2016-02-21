using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Emblem_Actor_Generator
{
    public static class JobList
    {
        public static Actor GetBaseCleric(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Cleric",
                statBlock = new StatBlock(14, 0, 4, 4, 5, 0, 4, 5, 5),
                statGrowthBlock = new StatGrowthBlock(50, 10, 40, 35, 40, 10, 35)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseBishop(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Bishop",
                statBlock = new StatBlock(19, 1, 8, 8, 9, 1, 8, 5, 6),
                statGrowthBlock = new StatGrowthBlock(55, 15, 45, 40, 45, 15, 35)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseTroubadour(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Troubadour",
                statBlock = new StatBlock(19, 1, 8, 8, 9, 1, 8, 7, 7),
                statGrowthBlock = new StatGrowthBlock(55, 15, 45, 40, 45, 15, 35)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseSaint(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Saint",
                statBlock = new StatBlock(30, 4, 17, 16, 18, 4, 14, 6, 8),
                statGrowthBlock = new StatGrowthBlock(55, 15, 45, 40, 45, 15, 35)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseWarCleric(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "War Cleric",
                statBlock = new StatBlock(33, 10, 15, 16, 18, 7, 14, 6, 9),
                statGrowthBlock = new StatGrowthBlock(55, 40, 40, 40, 45, 20, 35)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseValkyrie(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Valkyrie",
                statBlock = new StatBlock(30, 4, 17, 16, 18, 4, 14, 8, 9),
                statGrowthBlock = new StatGrowthBlock(55, 15, 45, 40, 45, 15, 35)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseDrifter(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Drifter",
                statBlock = new StatBlock(15, 3, 0, 6, 7, 3, 0, 5, 6),
                statGrowthBlock = new StatGrowthBlock(60, 35, 10, 40, 65, 15, 10)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }

        public static Actor GetBaseMyrmidon(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Myrmidon",
                statBlock = new StatBlock(21, 6, 1, 11, 11, 5, 1, 5, 7),
                statGrowthBlock = new StatGrowthBlock(60, 35, 10, 40, 65, 15, 10)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }

        public static Actor GetBaseThief(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Thief",
                statBlock = new StatBlock(21, 6, 1, 11, 11, 5, 1, 5, 7),
                statGrowthBlock = new StatGrowthBlock(60, 35, 10, 40, 65, 15, 10)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }

        public static Actor GetBaseSwordmaster(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Swordmaster",
                statBlock = new StatBlock(32, 12, 3, 19, 24, 9, 3, 6, 8),
                statGrowthBlock = new StatGrowthBlock(60, 35, 10, 40, 65, 15, 10)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }

        public static Actor GetBaseAssassin(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Assassin",
                statBlock = new StatBlock(27, 11, 3, 18, 19, 8, 2, 6, 8),
                statGrowthBlock = new StatGrowthBlock(60, 35, 10, 40, 65, 15, 10)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }

        public static Actor GetBaseRogue(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Rogue",
                statBlock = new StatBlock(32, 12, 3, 19, 22, 9, 3, 6, 9),
                statGrowthBlock = new StatGrowthBlock(60, 35, 10, 40, 65, 15, 10)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseHunter(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Hunter",
                statBlock = new StatBlock(17, 4, 0, 7, 5, 3, 1, 5, 5),
                statGrowthBlock = new StatGrowthBlock(65, 40, 10, 50, 45, 15, 15)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseNomad(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Nomad",
                statBlock = new StatBlock(24, 8, 1, 11, 10, 4, 3, 7, 7),
                statGrowthBlock = new StatGrowthBlock(65, 40, 10, 50, 45, 15, 15)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseArcher(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Archer",
                statBlock = new StatBlock(24, 8, 1, 11, 10, 4, 3, 5, 6),
                statGrowthBlock = new StatGrowthBlock(65, 40, 10, 50, 45, 15, 15)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseTrooper(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Trooper",
                statBlock = new StatBlock(36, 16, 3, 19, 18, 6, 7, 8, 10),
                statGrowthBlock = new StatGrowthBlock(65, 40, 10, 50, 45, 15, 15)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseScout(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Scout",
                statBlock = new StatBlock(36, 16, 3, 19, 18, 6, 7, 7, 8),
                statGrowthBlock = new StatGrowthBlock(65, 40, 10, 50, 45, 15, 15)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseSniper(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Sniper",
                statBlock = new StatBlock(36, 16, 3, 19, 18, 6, 7, 6, 9),
                statGrowthBlock = new StatGrowthBlock(65, 40, 10, 50, 45, 15, 15)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseJourneyman(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Journeyman",
                statBlock = new StatBlock(20, 5, 0, 3, 3, 4, 0, 5, 7),
                statGrowthBlock = new StatGrowthBlock(85, 55, 10, 30, 25, 20, 10)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }

        public static Actor GetBaseBarbarian(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Barbarian",
                statBlock = new StatBlock(28, 10, 1, 6, 5, 6, 1, 5, 10),
                statGrowthBlock = new StatGrowthBlock(85, 55, 10, 30, 25, 20, 10)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }

        public static Actor GetBaseFighter(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Fighter",
                statBlock = new StatBlock(28, 10, 1, 6, 5, 6, 1, 5, 9),
                statGrowthBlock = new StatGrowthBlock(85, 55, 10, 30, 25, 20, 10)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }

        public static Actor GetBaseBerserker(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Berserker",
                statBlock = new StatBlock(44, 19, 3, 12, 10, 10, 3, 6, 12),
                statGrowthBlock = new StatGrowthBlock(85, 55, 10, 30, 25, 20, 10)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }

        public static Actor GetBaseSentinel(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Sentinel",
                statBlock = new StatBlock(42, 18, 3, 14, 11, 11, 4, 6, 10),
                statGrowthBlock = new StatGrowthBlock(85, 55, 10, 30, 25, 20, 10)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }

        public static Actor GetBaseWarrior(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Warrior",
                statBlock = new StatBlock(44, 19, 3, 12, 10, 10, 3, 6, 11),
                statGrowthBlock = new StatGrowthBlock(85, 55, 10, 30, 25, 20, 10)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseLancer(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Lancer",
                statBlock = new StatBlock(16, 4, 0, 6, 6, 2, 2, 5, 6),
                statGrowthBlock = new StatGrowthBlock(60, 35, 10, 40, 45, 15, 15)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBasePegasusKnight(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Pegasus Knight",
                statBlock = new StatBlock(24, 7, 1, 10, 11, 3, 5, 7, 7),
                statGrowthBlock = new StatGrowthBlock(60, 35, 15, 45, 55, 15, 25)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseWyvernRider(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Wyvern Rider",
                statBlock = new StatBlock(25, 9, 1, 10, 11, 5, 3, 6, 8),
                statGrowthBlock = new StatGrowthBlock(60, 50, 10, 40, 45, 25, 15)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseFalcoknight(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Falcoknight",
                statBlock = new StatBlock(38, 15, 10, 19, 22, 7, 9, 8, 9),
                statGrowthBlock = new StatGrowthBlock(60, 35, 40, 45, 55, 15, 20)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseGriffonRider(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Griffon Rider",
                statBlock = new StatBlock(39, 15, 2, 19, 21, 8, 7, 7, 8),
                statGrowthBlock = new StatGrowthBlock(60, 45, 10, 40, 50, 25, 10)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseWyvernLord(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Wyvern Lord",
                statBlock = new StatBlock(40, 16, 4, 19, 20, 9, 6, 7, 10),
                statGrowthBlock = new StatGrowthBlock(60, 45, 10, 40, 50, 25, 10)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBasePupil(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Pupil",
                statBlock = new StatBlock(14, 1, 5, 3, 4, 0, 3, 5, 5),
                statGrowthBlock = new StatGrowthBlock(55, 10, 45, 35, 35, 10, 30)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }

        public static Actor GetBaseMage(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Mage",
                statBlock = new StatBlock(20, 2, 9, 6, 7, 2, 6, 5, 6),
                statGrowthBlock = new StatGrowthBlock(55, 10, 45, 35, 35, 10, 30)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }

        public static Actor GetBaseShaman(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Shaman",
                statBlock = new StatBlock(20, 2, 9, 6, 7, 3, 5, 5, 6),
                statGrowthBlock = new StatGrowthBlock(55, 10, 45, 35, 35, 20, 20)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }

        public static Actor GetBaseSage(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Sage",
                statBlock = new StatBlock(31, 4, 18, 12, 14, 5, 12, 6, 8),
                statGrowthBlock = new StatGrowthBlock(55, 10, 45, 35, 35, 10, 30)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }

        public static Actor GetBaseMageKnight(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Mage Knight",
                statBlock = new StatBlock(34, 10, 16, 12, 14, 5, 12, 7, 9),
                statGrowthBlock = new StatGrowthBlock(60, 40, 45, 35, 35, 20, 25)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }

        public static Actor GetBaseSummoner(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Summoner",
                statBlock = new StatBlock(32, 1, 19, 12, 14, 10, 8, 6, 10),
                statGrowthBlock = new StatGrowthBlock(55, 10, 40, 35, 35, 20, 20)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseRecruit(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Recruit",
                statBlock = new StatBlock(18, 4, 0, 4, 4, 4, 3, 5, 6),
                statGrowthBlock = new StatGrowthBlock(80, 40, 10, 35, 25, 25, 10)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseKnight(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Knight",
                statBlock = new StatBlock(25, 7, 1, 7, 6, 7, 4, 4, 10),
                statGrowthBlock = new StatGrowthBlock(80, 45, 10, 35, 25, 45, 5)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseCavalier(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Cavalier",
                statBlock = new StatBlock(25, 7, 1, 7, 7, 6, 5, 7, 8),
                statGrowthBlock = new StatGrowthBlock(80, 40, 10, 40, 30, 25, 20)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseGeneral(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "General",
                statBlock = new StatBlock(39, 14, 3, 14, 10, 13, 7, 5, 11),
                statGrowthBlock = new StatGrowthBlock(80, 45, 10, 35, 25, 45, 5)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseGreatKnight(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Great Knight",
                statBlock = new StatBlock(39, 14, 3, 14, 11, 12, 8, 6, 10),
                statGrowthBlock = new StatGrowthBlock(80, 45, 10, 35, 25, 45, 5)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBasePaladin(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Paladin",
                statBlock = new StatBlock(39, 14, 3, 14, 12, 11, 10, 7, 9),
                statGrowthBlock = new StatGrowthBlock(80, 40, 10, 40, 30, 25, 20)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
        public static Actor GetBaseSquire(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Squire",
                statBlock = new StatBlock(17, 4, 0, 6, 5, 3, 0, 5, 6),
                statGrowthBlock = new StatGrowthBlock(70, 45, 10, 35, 40, 25, 10)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }


        public static Actor GetBaseMercenary(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Mercenary",
                statBlock = new StatBlock(25, 9, 1, 10, 9, 6, 1, 5, 8),
                statGrowthBlock = new StatGrowthBlock(70, 45, 10, 35, 40, 25, 10)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }


        public static Actor GetBaseMagus(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Magus",
                statBlock = new StatBlock(25, 8, 5, 10, 9, 3, 5, 5, 8),
                statGrowthBlock = new StatGrowthBlock(65, 40, 35, 35, 40, 15, 25)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }


        public static Actor GetBaseHero(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Hero",
                statBlock = new StatBlock(41, 17, 3, 12, 13, 8, 5, 6, 10),
                statGrowthBlock = new StatGrowthBlock(70, 45, 10, 35, 40, 25, 10)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }


        public static Actor GetBaseAvenger(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Avenger",
                statBlock = new StatBlock(40, 16, 10, 12, 13, 6, 6, 6, 9),
                statGrowthBlock = new StatGrowthBlock(65, 45, 40, 35, 40, 15, 25)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }

        public static Actor GetBaseSpellsword(int level)
        {
            Actor actor = new Actor(level)
            {
                name = "Spellsword",
                statBlock = new StatBlock(40, 16, 13, 12, 13, 6, 7, 6, 8),
                statGrowthBlock = new StatGrowthBlock(65, 45, 40, 35, 40, 15, 25)
            };
            Utils.LevelActor(actor, level);
            return actor;
        }
    }
}

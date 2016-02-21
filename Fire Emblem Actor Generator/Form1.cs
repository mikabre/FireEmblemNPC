using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fire_Emblem_Actor_Generator
{
    public partial class Form1 : Form
    {
        private string activeJob;
        private int activeLevel;
        public Form1()
        {
            InitializeComponent();
            cmbJob.SelectedIndex = 0;
            cmbLevel.SelectedIndex = 0;
            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            switch (activeJob)
            {
                case "Archer":
                    txtOutput.Text = JobList.GetBaseArcher(activeLevel).Display();
                    break;
                case "Assassin":
                    txtOutput.Text = JobList.GetBaseAssassin(activeLevel).Display();
                    break;
                case "Avenger":
                    txtOutput.Text = JobList.GetBaseAvenger(activeLevel).Display();
                    break;
                case "Barbarian":
                    txtOutput.Text = JobList.GetBaseBarbarian(activeLevel).Display();
                    break;
                case "Berserker":
                    txtOutput.Text = JobList.GetBaseBerserker(activeLevel).Display();
                    break;
                case "Bishop":
                    txtOutput.Text = JobList.GetBaseBishop(activeLevel).Display();
                    break;
                case "Cavalier":
                    txtOutput.Text = JobList.GetBaseCavalier(activeLevel).Display();
                    break;
                case "Cleric":
                    txtOutput.Text = JobList.GetBaseCleric(activeLevel).Display();
                    break;
                case "Drifter":
                    txtOutput.Text = JobList.GetBaseDrifter(activeLevel).Display();
                    break;
                case "Falcoknight":
                    txtOutput.Text = JobList.GetBaseFalcoknight(activeLevel).Display();
                    break;
                case "Fighter":
                    txtOutput.Text = JobList.GetBaseFighter(activeLevel).Display();
                    break;
                case "General":
                    txtOutput.Text = JobList.GetBaseGeneral(activeLevel).Display();
                    break;
                case "Great Knight":
                    txtOutput.Text = JobList.GetBaseGreatKnight(activeLevel).Display();
                    break;
                case "Griffon Rider":
                    txtOutput.Text = JobList.GetBaseGriffonRider(activeLevel).Display();
                    break;
                case "Hero":
                    txtOutput.Text = JobList.GetBaseHero(activeLevel).Display();
                    break;
                case "Hunter":
                    txtOutput.Text = JobList.GetBaseHunter(activeLevel).Display();
                    break;
                case "Journeyman":
                    txtOutput.Text = JobList.GetBaseJourneyman(activeLevel).Display();
                    break;
                case "Knight":
                    txtOutput.Text = JobList.GetBaseKnight(activeLevel).Display();
                    break;
                case "Lancer":
                    txtOutput.Text = JobList.GetBaseLancer(activeLevel).Display();
                    break;
                case "Mage":
                    txtOutput.Text = JobList.GetBaseMage(activeLevel).Display();
                    break;
                case "Mage Knight":
                    txtOutput.Text = JobList.GetBaseMageKnight(activeLevel).Display();
                    break;
                case "Magus":
                    txtOutput.Text = JobList.GetBaseMagus(activeLevel).Display();
                    break;
                case "Mercenary":
                    txtOutput.Text = JobList.GetBaseMercenary(activeLevel).Display();
                    break;
                case "Myrmidon":
                    txtOutput.Text = JobList.GetBaseMyrmidon(activeLevel).Display();
                    break;
                case "Nomad":
                    txtOutput.Text = JobList.GetBaseNomad(activeLevel).Display();
                    break;
                case "Paladin":
                    txtOutput.Text = JobList.GetBasePaladin(activeLevel).Display();
                    break;
                case "Pegasus Knight":
                    txtOutput.Text = JobList.GetBasePegasusKnight(activeLevel).Display();
                    break;
                case "Pupil":
                    txtOutput.Text = JobList.GetBasePupil(activeLevel).Display();
                    break;
                case "Recruit":
                    txtOutput.Text = JobList.GetBaseRecruit(activeLevel).Display();
                    break;
                case "Rogue":
                    txtOutput.Text = JobList.GetBaseRogue(activeLevel).Display();
                    break;
                case "Sage":
                    txtOutput.Text = JobList.GetBaseSage(activeLevel).Display();
                    break;
                case "Saint":
                    txtOutput.Text = JobList.GetBaseSaint(activeLevel).Display();
                    break;
                case "Scout":
                    txtOutput.Text = JobList.GetBaseScout(activeLevel).Display();
                    break;
                case "Sentinel":
                    txtOutput.Text = JobList.GetBaseSentinel(activeLevel).Display();
                    break;
                case "Shaman":
                    txtOutput.Text = JobList.GetBaseShaman(activeLevel).Display();
                    break;
                case "Sniper":
                    txtOutput.Text = JobList.GetBaseSniper(activeLevel).Display();
                    break;
                case "Spellsword":
                    txtOutput.Text = JobList.GetBaseSpellsword(activeLevel).Display();
                    break;
                case "Squire":
                    txtOutput.Text = JobList.GetBaseSquire(activeLevel).Display();
                    break;
                case "Summoner":
                    txtOutput.Text = JobList.GetBaseSummoner(activeLevel).Display();
                    break;
                case "Swordmaster":
                    txtOutput.Text = JobList.GetBaseSwordmaster(activeLevel).Display();
                    break;
                case "Thief":
                    txtOutput.Text = JobList.GetBaseThief(activeLevel).Display();
                    break;
                case "Trooper":
                    txtOutput.Text = JobList.GetBaseTrooper(activeLevel).Display();
                    break;
                case "Troubadour":
                    txtOutput.Text = JobList.GetBaseTroubadour(activeLevel).Display();
                    break;
                case "Valkyrie":
                    txtOutput.Text = JobList.GetBaseValkyrie(activeLevel).Display();
                    break;
                case "War Cleric":
                    txtOutput.Text = JobList.GetBaseWarCleric(activeLevel).Display();
                    break;
                case "Warrior":
                    txtOutput.Text = JobList.GetBaseWarrior(activeLevel).Display();
                    break;
                case "Wyvern Lord":
                    txtOutput.Text = JobList.GetBaseWyvernLord(activeLevel).Display();
                    break;
                case "Wyvern Rider":
                    txtOutput.Text = JobList.GetBaseWyvernRider(activeLevel).Display();
                    break;
                default:
                    txtOutput.Text ="UHHHHHHHHHHH WAT";
                    break;

            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOutput.Text);
        }

        private void cmbJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeJob = cmbJob.Text;
        }

        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeLevel = Int32.Parse(cmbLevel.Text);
        }
    }
}

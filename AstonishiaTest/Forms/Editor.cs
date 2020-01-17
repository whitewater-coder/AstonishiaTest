using Astonishia.Character;
using Astonishia.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astonishia.Forms
{
    public partial class Editor : Form
    {
        private AstCharactor chr = null;
        public Editor(AstCharactor chr)
        {
            this.chr = chr;
            InitializeComponent();
            InitializeStatus();
            Text = string.Format(Text,chr.Name,chr.Level);
            Icon = Resources.icon;
        }

        private void InitializeStatus()
        {
            imgPortrait.Image = AstConstants.PORTRAITS[chr.Index];
            lblName.Text = chr.Name;
            
            numMaxHP.Value = chr.MaxHP;
            numMinHP.Value = chr.HP;
            numMaxMP.Value = chr.MaxHP;
            numMinMP.Value = chr.MP;
            numEXP.Maximum = chr.NextLevelExp;
            numEXP.Value = chr.EXP;
            numAttack.Value = chr.Attack;
            numDefense.Value = chr.Defense;
            numDexterity.Value = chr.Dexterity;
            numMove.Value = chr.Move;
            numTechnician.Value = chr.Technician;
        }

        private void OnSaveStatus(object sender, EventArgs e)
        {
            chr.MaxHP = (uint)numMaxHP.Value;
            chr.HP = (uint)numMinHP.Value;
            chr.MaxHP = (uint)numMaxMP.Value;
            chr.MP = (uint)numMinMP.Value;
            chr.EXP = (uint)numEXP.Value;
            chr.Attack = (uint)numAttack.Value;
            chr.Defense = (uint)numDefense.Value;
            chr.Dexterity = (uint)numDexterity.Value;
            chr.Move = (uint)numMove.Value;
            chr.Technician = (uint)numTechnician.Value;

            DialogResult = DialogResult.OK;
        }
    }
}

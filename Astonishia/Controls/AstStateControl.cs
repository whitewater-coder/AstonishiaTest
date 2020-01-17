using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Astonishia.Properties;
using Astonishia.Character;
using Astonishia.Forms;

namespace Astonishia
{
    public partial class AstStateControl : UserControl
    {
        private AstCharactor chr = null;
        public AstStateControl()
        {
            InitializeComponent();
            
        }

        public AstCharactor Character { 
            
            get
            {
                return chr;
            }
            set
            {
                this.chr = value;
                if (imgPortrait.Image != null)
                {
                    imgPortrait.Image.Dispose();
                }
                imgPortrait.Image = AstConstants.PORTRAITS[chr.Index];
                UpdateCharacter();
            }
        }


        public void UpdateCharacter()
        {
            lblName.Text = chr.Name;
            barHP.Maximum = (int) chr.MaxHP;
            barHP.Value = (int)chr.HP;
            barMP.Maximum = (int)chr.MaxMP;
            barMP.Value = (int)chr.MP;
            barEXP.Maximum = (int)chr.NextLevelExp;
            barEXP.Value = (int)chr.EXP;

            chkParty.Checked = chr.Party;

            lblLevel.Text = String.Format("Lv.{0:00}",chr.Level);
            lblAtt.Text = chr.Attack.ToString();
            lblDef.Text = chr.Defense.ToString();
            lblDex.Text = chr.Dexterity.ToString();
            lblMove.Text = chr.Move.ToString();
            lblTech.Text = chr.Technician.ToString();
        }

        private void OnEditCharacter(object sender, EventArgs e)
        {
            using (Editor form = new Editor(chr))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //MessageBox.Show("캐릭터 편집 완료!", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }

}

using Astonishia.Controls;

namespace Astonishia
{
    partial class AstStateControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgPortrait = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.chkParty = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAtt = new System.Windows.Forms.Label();
            this.lblDef = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDex = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMove = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTech = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.barEXP = new Astonishia.Controls.CustomBar();
            this.barMP = new Astonishia.Controls.CustomBar();
            this.barHP = new Astonishia.Controls.CustomBar();
            ((System.ComponentModel.ISupportInitialize)(this.imgPortrait)).BeginInit();
            this.imgPortrait.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgPortrait
            // 
            this.imgPortrait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPortrait.Controls.Add(this.lblName);
            this.imgPortrait.Controls.Add(this.lblLevel);
            this.imgPortrait.Image = global::Astonishia.Properties.Resources.empty;
            this.imgPortrait.Location = new System.Drawing.Point(2, 2);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.Size = new System.Drawing.Size(75, 104);
            this.imgPortrait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPortrait.TabIndex = 0;
            this.imgPortrait.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblName.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.ForeColor = System.Drawing.Color.Ivory;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "-";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLevel
            // 
            this.lblLevel.BackColor = System.Drawing.Color.White;
            this.lblLevel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLevel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblLevel.Location = new System.Drawing.Point(0, 79);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(75, 20);
            this.lblLevel.TabIndex = 21;
            this.lblLevel.Text = "Lv.00";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkParty
            // 
            this.chkParty.FlatAppearance.BorderSize = 2;
            this.chkParty.Location = new System.Drawing.Point(83, 90);
            this.chkParty.Name = "chkParty";
            this.chkParty.Size = new System.Drawing.Size(106, 18);
            this.chkParty.TabIndex = 1;
            this.chkParty.Text = "파티상태";
            this.chkParty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkParty.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(79, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "HP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(79, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "MP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(79, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "EXP";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEdit.Location = new System.Drawing.Point(83, 65);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 20);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "에디트";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.OnEditCharacter);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(198, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "공격력 : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAtt
            // 
            this.lblAtt.Location = new System.Drawing.Point(247, 6);
            this.lblAtt.Name = "lblAtt";
            this.lblAtt.Size = new System.Drawing.Size(30, 15);
            this.lblAtt.TabIndex = 12;
            this.lblAtt.Text = "000";
            this.lblAtt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDef
            // 
            this.lblDef.Location = new System.Drawing.Point(247, 26);
            this.lblDef.Name = "lblDef";
            this.lblDef.Size = new System.Drawing.Size(30, 15);
            this.lblDef.TabIndex = 14;
            this.lblDef.Text = "000";
            this.lblDef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(198, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "방어력 : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDex
            // 
            this.lblDex.Location = new System.Drawing.Point(247, 46);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(30, 15);
            this.lblDex.TabIndex = 16;
            this.lblDex.Text = "000";
            this.lblDex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(198, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "민첩성 : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMove
            // 
            this.lblMove.Location = new System.Drawing.Point(247, 66);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(30, 15);
            this.lblMove.TabIndex = 18;
            this.lblMove.Text = "000";
            this.lblMove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(198, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "　이동 : ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTech
            // 
            this.lblTech.Location = new System.Drawing.Point(247, 86);
            this.lblTech.Name = "lblTech";
            this.lblTech.Size = new System.Drawing.Size(30, 15);
            this.lblTech.TabIndex = 20;
            this.lblTech.Text = "000";
            this.lblTech.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(198, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "기술력 : ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // barEXP
            // 
            this.barEXP.BackColor = System.Drawing.Color.DarkGray;
            this.barEXP.BackgroundColor = System.Drawing.Color.Black;
            this.barEXP.CustomText = "";
            this.barEXP.ForeColor = System.Drawing.Color.Blue;
            this.barEXP.Location = new System.Drawing.Point(115, 41);
            this.barEXP.Margin = new System.Windows.Forms.Padding(0);
            this.barEXP.Name = "barEXP";
            this.barEXP.ProgressColor = System.Drawing.Color.ForestGreen;
            this.barEXP.Size = new System.Drawing.Size(74, 15);
            this.barEXP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barEXP.TabIndex = 9;
            this.barEXP.TextColor = System.Drawing.Color.White;
            this.barEXP.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.barEXP.Value = 50;
            this.barEXP.VisualMode = Astonishia.Controls.ProgressBarDisplayMode.CurrProgress;
            // 
            // barMP
            // 
            this.barMP.BackgroundColor = System.Drawing.Color.Black;
            this.barMP.CustomText = "";
            this.barMP.ForeColor = System.Drawing.Color.Blue;
            this.barMP.Location = new System.Drawing.Point(115, 23);
            this.barMP.Margin = new System.Windows.Forms.Padding(0);
            this.barMP.Name = "barMP";
            this.barMP.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.barMP.Size = new System.Drawing.Size(74, 15);
            this.barMP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barMP.TabIndex = 7;
            this.barMP.TextColor = System.Drawing.Color.White;
            this.barMP.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.barMP.Value = 50;
            this.barMP.VisualMode = Astonishia.Controls.ProgressBarDisplayMode.CurrProgress;
            // 
            // barHP
            // 
            this.barHP.BackgroundColor = System.Drawing.Color.Black;
            this.barHP.CustomText = "";
            this.barHP.ForeColor = System.Drawing.Color.Blue;
            this.barHP.Location = new System.Drawing.Point(115, 5);
            this.barHP.Margin = new System.Windows.Forms.Padding(0);
            this.barHP.Name = "barHP";
            this.barHP.ProgressColor = System.Drawing.Color.DarkRed;
            this.barHP.Size = new System.Drawing.Size(74, 15);
            this.barHP.TabIndex = 5;
            this.barHP.TextColor = System.Drawing.Color.White;
            this.barHP.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.barHP.Value = 50;
            this.barHP.VisualMode = Astonishia.Controls.ProgressBarDisplayMode.CurrProgress;
            // 
            // AstStateControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblTech);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblMove);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblDex);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDef);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAtt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.barEXP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.barMP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barHP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkParty);
            this.Controls.Add(this.imgPortrait);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "AstStateControl";
            this.Size = new System.Drawing.Size(280, 110);
            ((System.ComponentModel.ISupportInitialize)(this.imgPortrait)).EndInit();
            this.imgPortrait.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPortrait;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private CustomBar barHP;
        private CustomBar barMP;
        private System.Windows.Forms.Label label2;
        private CustomBar barEXP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAtt;
        private System.Windows.Forms.Label lblDef;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTech;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.CheckBox chkParty;
        private System.Windows.Forms.Label lblLevel;
    }
}

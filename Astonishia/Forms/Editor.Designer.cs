namespace Astonishia.Forms
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgPortrait = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numAttack = new System.Windows.Forms.NumericUpDown();
            this.numDefense = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numDexterity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numMinHP = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numMaxHP = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numMaxMP = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numMinMP = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numEXP = new System.Windows.Forms.NumericUpDown();
            this.numMove = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numTechnician = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPortrait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDexterity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEXP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTechnician)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPortrait
            // 
            this.imgPortrait.BackColor = System.Drawing.Color.Linen;
            this.imgPortrait.Location = new System.Drawing.Point(12, 12);
            this.imgPortrait.Name = "imgPortrait";
            this.imgPortrait.Size = new System.Drawing.Size(150, 210);
            this.imgPortrait.TabIndex = 0;
            this.imgPortrait.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(172, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 27);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "ABCD";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(168, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "공격력 :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numAttack
            // 
            this.numAttack.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numAttack.Location = new System.Drawing.Point(233, 134);
            this.numAttack.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numAttack.Name = "numAttack";
            this.numAttack.Size = new System.Drawing.Size(50, 25);
            this.numAttack.TabIndex = 4;
            this.numAttack.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numDefense
            // 
            this.numDefense.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numDefense.Location = new System.Drawing.Point(233, 165);
            this.numDefense.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numDefense.Name = "numDefense";
            this.numDefense.Size = new System.Drawing.Size(50, 25);
            this.numDefense.TabIndex = 6;
            this.numDefense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(168, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "방어력 : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numDexterity
            // 
            this.numDexterity.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numDexterity.Location = new System.Drawing.Point(233, 196);
            this.numDexterity.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numDexterity.Name = "numDexterity";
            this.numDexterity.Size = new System.Drawing.Size(50, 25);
            this.numDexterity.TabIndex = 8;
            this.numDexterity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(168, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "민첩성 : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numMinHP
            // 
            this.numMinHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMinHP.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numMinHP.Location = new System.Drawing.Point(233, 42);
            this.numMinHP.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMinHP.Name = "numMinHP";
            this.numMinHP.Size = new System.Drawing.Size(70, 25);
            this.numMinHP.TabIndex = 10;
            this.numMinHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMinHP.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(168, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "HP :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(309, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "/";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numMaxHP
            // 
            this.numMaxHP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMaxHP.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numMaxHP.Location = new System.Drawing.Point(331, 42);
            this.numMaxHP.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMaxHP.Name = "numMaxHP";
            this.numMaxHP.Size = new System.Drawing.Size(70, 25);
            this.numMaxHP.TabIndex = 12;
            this.numMaxHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMaxHP.ThousandsSeparator = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(309, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "/";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numMaxMP
            // 
            this.numMaxMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMaxMP.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numMaxMP.Location = new System.Drawing.Point(331, 73);
            this.numMaxMP.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMaxMP.Name = "numMaxMP";
            this.numMaxMP.Size = new System.Drawing.Size(70, 25);
            this.numMaxMP.TabIndex = 16;
            this.numMaxMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMaxMP.ThousandsSeparator = true;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(168, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "MP :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numMinMP
            // 
            this.numMinMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMinMP.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numMinMP.Location = new System.Drawing.Point(233, 73);
            this.numMinMP.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMinMP.Name = "numMinMP";
            this.numMinMP.Size = new System.Drawing.Size(70, 25);
            this.numMinMP.TabIndex = 14;
            this.numMinMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numMinMP.ThousandsSeparator = true;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(168, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "EXP :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numEXP
            // 
            this.numEXP.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numEXP.Location = new System.Drawing.Point(233, 104);
            this.numEXP.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numEXP.Name = "numEXP";
            this.numEXP.Size = new System.Drawing.Size(168, 25);
            this.numEXP.TabIndex = 18;
            this.numEXP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numMove
            // 
            this.numMove.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numMove.Location = new System.Drawing.Point(351, 136);
            this.numMove.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numMove.Name = "numMove";
            this.numMove.Size = new System.Drawing.Size(50, 25);
            this.numMove.TabIndex = 24;
            this.numMove.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(286, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "이동 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numTechnician
            // 
            this.numTechnician.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numTechnician.Location = new System.Drawing.Point(351, 167);
            this.numTechnician.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numTechnician.Name = "numTechnician";
            this.numTechnician.Size = new System.Drawing.Size(50, 25);
            this.numTechnician.TabIndex = 26;
            this.numTechnician.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(286, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 21);
            this.label13.TabIndex = 25;
            this.label13.Text = "기술 :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(290, 198);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 25);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "저장후 닫기";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnSaveStatus);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(413, 233);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numTechnician);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numMove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numEXP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numMaxMP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numMinMP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numMaxHP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numMinHP);
            this.Controls.Add(this.numDexterity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numDefense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numAttack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.imgPortrait);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "이름: {0} - 레벨: {1}";
            ((System.ComponentModel.ISupportInitialize)(this.imgPortrait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAttack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDexterity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEXP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTechnician)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPortrait;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numAttack;
        private System.Windows.Forms.NumericUpDown numDefense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDexterity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numMinHP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numMaxHP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numMaxMP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numMinMP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numEXP;
        private System.Windows.Forms.NumericUpDown numMove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numTechnician;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSave;
    }
}
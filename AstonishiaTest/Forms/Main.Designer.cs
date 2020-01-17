namespace Astonishia.Forms
{
    partial class Main
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.paneCharacter = new System.Windows.Forms.FlowLayoutPanel();
            this.bgwrkUpdater = new System.ComponentModel.BackgroundWorker();
            this.timerProcess = new System.Windows.Forms.Timer(this.components);
            this.lblState = new System.Windows.Forms.Label();
            this.btnShowInventory = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            this.numMoney = new System.Windows.Forms.NumericUpDown();
            this.btnSetMoney = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // paneCharacter
            // 
            this.paneCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.paneCharacter.AutoScroll = true;
            this.paneCharacter.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.paneCharacter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneCharacter.Location = new System.Drawing.Point(185, 9);
            this.paneCharacter.Name = "paneCharacter";
            this.paneCharacter.Size = new System.Drawing.Size(593, 230);
            this.paneCharacter.TabIndex = 5;
            // 
            // bgwrkUpdater
            // 
            this.bgwrkUpdater.WorkerSupportsCancellation = true;
            this.bgwrkUpdater.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DoUpdate);
            this.bgwrkUpdater.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ExitedWorker);
            // 
            // timerProcess
            // 
            this.timerProcess.Enabled = true;
            this.timerProcess.Tick += new System.EventHandler(this.ProcessCheckTick);
            // 
            // lblState
            // 
            this.lblState.AutoEllipsis = true;
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblState.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblState.Location = new System.Drawing.Point(12, 9);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(165, 62);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "준비 중";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowInventory
            // 
            this.btnShowInventory.Location = new System.Drawing.Point(12, 169);
            this.btnShowInventory.Name = "btnShowInventory";
            this.btnShowInventory.Size = new System.Drawing.Size(165, 23);
            this.btnShowInventory.TabIndex = 7;
            this.btnShowInventory.Text = "인벤토리";
            this.btnShowInventory.UseVisualStyleBackColor = true;
            // 
            // lblMoney
            // 
            this.lblMoney.BackColor = System.Drawing.Color.SeaGreen;
            this.lblMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMoney.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMoney.ForeColor = System.Drawing.Color.Ivory;
            this.lblMoney.Location = new System.Drawing.Point(12, 107);
            this.lblMoney.Margin = new System.Windows.Forms.Padding(0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.lblMoney.Size = new System.Drawing.Size(165, 27);
            this.lblMoney.TabIndex = 8;
            this.lblMoney.Text = "0 겔더";
            this.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numMoney
            // 
            this.numMoney.Location = new System.Drawing.Point(12, 140);
            this.numMoney.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numMoney.Name = "numMoney";
            this.numMoney.Size = new System.Drawing.Size(109, 23);
            this.numMoney.TabIndex = 9;
            this.numMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSetMoney
            // 
            this.btnSetMoney.Location = new System.Drawing.Point(127, 140);
            this.btnSetMoney.Name = "btnSetMoney";
            this.btnSetMoney.Size = new System.Drawing.Size(50, 23);
            this.btnSetMoney.TabIndex = 10;
            this.btnSetMoney.Text = "적용";
            this.btnSetMoney.UseVisualStyleBackColor = true;
            this.btnSetMoney.Click += new System.EventHandler(this.OnApplyMoney);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(12, 78);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(165, 23);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "불러오기!";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.OnStart);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 251);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSetMoney);
            this.Controls.Add(this.numMoney);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.btnShowInventory);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.paneCharacter);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(803, 758);
            this.MinimumSize = new System.Drawing.Size(803, 290);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "어스토니시아 For PPSSPP 트뤠이너";
            ((System.ComponentModel.ISupportInitialize)(this.numMoney)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel paneCharacter;
        private System.ComponentModel.BackgroundWorker bgwrkUpdater;
        private System.Windows.Forms.Timer timerProcess;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Button btnShowInventory;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.NumericUpDown numMoney;
        private System.Windows.Forms.Button btnSetMoney;
        private System.Windows.Forms.Button btnLoad;
    }
}


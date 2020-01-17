using Astonishia.Client;
using Astonishia.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astonishia.Forms
{
    public partial class Main : Form
    {

        private AstClient client = null;
        private Process process;
        private bool canProcessing = true;
        public Main()
        {
            Icon = Resources.icon;
            InitializeComponent();
            ControlEnabler(false);
        }
        
        
        private void ProcessCheckTick(object sender, EventArgs e)
        {
            process = GetProcess();
            if (process == null)
            {
                lblState.Text = "에뮬레이터가 실행되지 않음";
                btnLoad.Enabled = false;
                if (AliveBackgroundWokrer)
                {
                    CancelWorker();
                }
                return;
            }

            string wintitle = process.MainWindowTitle;
            bool isRunning = wintitle.ToLower().Contains("astonishia");
            if (wintitle.Length == 0)
            {
                lblState.Text = "(o_0)?";
                return;
            }
            if (!isRunning)
            {
                lblState.Text = "게임이 실행되지 않음";
                btnLoad.Enabled = false;
                if (AliveBackgroundWokrer)
                {
                    CancelWorker();
                }
                return;
            }
            if (client != null && bgwrkUpdater.IsBusy)
            {
                lblState.Text = "정상 작동 중..";
                return;
            }
            

            
            if (client == null && canProcessing)
            {
                lblState.Text = "작업 준비";
                btnLoad.Enabled = true;
            }
        }

        private void CancelWorker()
        {
            if (!bgwrkUpdater.CancellationPending)
            {
                bgwrkUpdater.CancelAsync();
            }
        }

        private bool AliveBackgroundWokrer
        {
            get
            {
                return bgwrkUpdater.IsBusy;
            }
        }

        private Process GetProcess()
        {
            var procList = Process.GetProcessesByName(AstConstants.PROCESS_NAME);
            if (procList.Length > 0)
            {
                return procList[0];
            }
            else
            {
                return null;
            }
        }

        private void PartyStateChanged(object sender, EventArgs e)
        {
            var control = sender as CheckBox;
            var parent = control.Parent as AstStateControl;
            parent.Character.Party = control.Checked;

            UpdateState();
        }

        private void UpdateState()
        {
            var sorted = paneCharacter.Controls.Cast<AstStateControl>().OrderBy(b => b.Character.Index);
            sorted = sorted.OrderByDescending(a => a.Character.Party);
            paneCharacter.Controls.AddRange(sorted.ToArray());

            foreach (AstStateControl control in paneCharacter.Controls)
            {
                control.UpdateCharacter();
            }

            lblMoney.Text = string.Format("{0:#,##0} 겔더",client.Storage.Money);
        }


        private void DoUpdate(object sender, DoWorkEventArgs e)
        {
            while (!bgwrkUpdater.CancellationPending)
            {
                Invoke(new Action(() =>
                {
                    UpdateState();

                }));
                Thread.Sleep(100);
            }
        }

        private void ExitedWorker(object sender, RunWorkerCompletedEventArgs e)
        {
            client = null;
            paneCharacter.Controls.Clear();
            ControlEnabler(false);
            btnLoad.Enabled = false;
            canProcessing = true;
        }

        private void OnApplyMoney(object sender, EventArgs e)
        {
            client.Storage.Money = (uint) numMoney.Value;
        }

        private void OnStart(object sender, EventArgs e)
        {
            btnLoad.Enabled = false;
            Thread thread = new Thread(() => {
                if (!bgwrkUpdater.IsBusy && !bgwrkUpdater.CancellationPending)
                {
                    Invoke(new Action(() => {
                        lblState.Text = "불러오는 중..";
                    }));

                    canProcessing = false;
                    client = new AstClient(process);
                    
                    Invoke(new Action(() => {
                        paneCharacter.Controls.Clear();
                        foreach (var chr in client.Characters)
                        {
                            var chrControl = new AstStateControl();
                            chrControl.Character = chr;
                            chrControl.chkParty.CheckStateChanged += PartyStateChanged;
                            paneCharacter.Controls.Add(chrControl);
                        }
                        UpdateState();
                        bgwrkUpdater.RunWorkerAsync();
                        ControlEnabler(true);
                    }));
                }
            });
            thread.Start();
        }

        private void ControlEnabler(bool enable)
        {
            btnLoad.Enabled = !enable;
            btnSetMoney.Enabled = enable;
            numMoney.Enabled = enable;
        }
    }
}

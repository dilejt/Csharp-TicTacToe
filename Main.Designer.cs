
namespace TicTacToe
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.labelThema = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelSizeInfo = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.tableLayoutPanelScore = new System.Windows.Forms.TableLayoutPanel();
            this.labelOScore = new System.Windows.Forms.Label();
            this.labelOInfo = new System.Windows.Forms.Label();
            this.labelXInfo = new System.Windows.Forms.Label();
            this.labelXScore = new System.Windows.Forms.Label();
            this.labelScoreInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            this.tableLayoutPanelScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarSize
            // 
            this.trackBarSize.Location = new System.Drawing.Point(480, 228);
            this.trackBarSize.Maximum = 15;
            this.trackBarSize.Minimum = 3;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(230, 45);
            this.trackBarSize.TabIndex = 0;
            this.trackBarSize.Value = 3;
            this.trackBarSize.ValueChanged += new System.EventHandler(this.trackBarSize_ValueChanged);
            // 
            // labelThema
            // 
            this.labelThema.AutoSize = true;
            this.labelThema.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThema.Location = new System.Drawing.Point(12, 9);
            this.labelThema.Name = "labelThema";
            this.labelThema.Size = new System.Drawing.Size(157, 33);
            this.labelThema.TabIndex = 1;
            this.labelThema.Text = "TicTacToe";
            this.labelThema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSize.Location = new System.Drawing.Point(716, 228);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(25, 25);
            this.labelSize.TabIndex = 2;
            this.labelSize.Text = "3";
            // 
            // labelSizeInfo
            // 
            this.labelSizeInfo.AutoSize = true;
            this.labelSizeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSizeInfo.Location = new System.Drawing.Point(485, 194);
            this.labelSizeInfo.Name = "labelSizeInfo";
            this.labelSizeInfo.Size = new System.Drawing.Size(159, 20);
            this.labelSizeInfo.TabIndex = 3;
            this.labelSizeInfo.Text = "Choose size of board";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.Location = new System.Drawing.Point(35, 384);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 40);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlay.ForeColor = System.Drawing.Color.Red;
            this.buttonPlay.Location = new System.Drawing.Point(641, 301);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(100, 40);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // tableLayoutPanelScore
            // 
            this.tableLayoutPanelScore.ColumnCount = 2;
            this.tableLayoutPanelScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelScore.Controls.Add(this.labelOScore, 1, 1);
            this.tableLayoutPanelScore.Controls.Add(this.labelOInfo, 1, 0);
            this.tableLayoutPanelScore.Controls.Add(this.labelXInfo, 0, 0);
            this.tableLayoutPanelScore.Controls.Add(this.labelXScore, 0, 1);
            this.tableLayoutPanelScore.Location = new System.Drawing.Point(118, 153);
            this.tableLayoutPanelScore.Name = "tableLayoutPanelScore";
            this.tableLayoutPanelScore.RowCount = 2;
            this.tableLayoutPanelScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelScore.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanelScore.TabIndex = 6;
            // 
            // labelOScore
            // 
            this.labelOScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOScore.AutoSize = true;
            this.labelOScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOScore.Location = new System.Drawing.Point(142, 67);
            this.labelOScore.Name = "labelOScore";
            this.labelOScore.Size = new System.Drawing.Size(15, 16);
            this.labelOScore.TabIndex = 8;
            this.labelOScore.Text = "0";
            this.labelOScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOInfo
            // 
            this.labelOInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOInfo.AutoSize = true;
            this.labelOInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOInfo.Location = new System.Drawing.Point(140, 17);
            this.labelOInfo.Name = "labelOInfo";
            this.labelOInfo.Size = new System.Drawing.Size(19, 16);
            this.labelOInfo.TabIndex = 9;
            this.labelOInfo.Text = "O";
            this.labelOInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelXInfo
            // 
            this.labelXInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelXInfo.AutoSize = true;
            this.labelXInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelXInfo.Location = new System.Drawing.Point(41, 17);
            this.labelXInfo.Name = "labelXInfo";
            this.labelXInfo.Size = new System.Drawing.Size(17, 16);
            this.labelXInfo.TabIndex = 8;
            this.labelXInfo.Text = "X";
            this.labelXInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelXScore
            // 
            this.labelXScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelXScore.AutoSize = true;
            this.labelXScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelXScore.Location = new System.Drawing.Point(42, 67);
            this.labelXScore.Name = "labelXScore";
            this.labelXScore.Size = new System.Drawing.Size(15, 16);
            this.labelXScore.TabIndex = 8;
            this.labelXScore.Text = "0";
            this.labelXScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScoreInfo
            // 
            this.labelScoreInfo.AutoSize = true;
            this.labelScoreInfo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelScoreInfo.Location = new System.Drawing.Point(196, 131);
            this.labelScoreInfo.Name = "labelScoreInfo";
            this.labelScoreInfo.Size = new System.Drawing.Size(44, 19);
            this.labelScoreInfo.TabIndex = 7;
            this.labelScoreInfo.Text = "Score";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.labelScoreInfo);
            this.Controls.Add(this.tableLayoutPanelScore);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelSizeInfo);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelThema);
            this.Controls.Add(this.trackBarSize);
            this.Name = "Main";
            this.Text = "TicTacToe by Damian Jancewicz";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            this.tableLayoutPanelScore.ResumeLayout(false);
            this.tableLayoutPanelScore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.Label labelThema;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelSizeInfo;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelScore;
        private System.Windows.Forms.Label labelOScore;
        private System.Windows.Forms.Label labelOInfo;
        private System.Windows.Forms.Label labelXInfo;
        private System.Windows.Forms.Label labelXScore;
        private System.Windows.Forms.Label labelScoreInfo;
    }
}


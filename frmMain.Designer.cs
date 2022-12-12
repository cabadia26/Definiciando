namespace Deficiando
{
    partial class frmMain
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tblControls = new System.Windows.Forms.TableLayoutPanel();
            this.btnPickWord = new System.Windows.Forms.Button();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.optdef1 = new System.Windows.Forms.RadioButton();
            this.optdef2 = new System.Windows.Forms.RadioButton();
            this.optdef3 = new System.Windows.Forms.RadioButton();
            this.btntEnter = new System.Windows.Forms.Button();
            this.tblPlayArea = new System.Windows.Forms.TableLayoutPanel();
            this.tblDefinitions = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbldef3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbldef2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldef1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblwordscaptioned = new System.Windows.Forms.Label();
            this.lblNumWords = new System.Windows.Forms.Label();
            this.lblscorecaotion = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.tblMain.SuspendLayout();
            this.tblControls.SuspendLayout();
            this.tblPlayArea.SuspendLayout();
            this.tblDefinitions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.lblMessage, 0, 0);
            this.tblMain.Controls.Add(this.tblControls, 0, 1);
            this.tblMain.Controls.Add(this.tblPlayArea, 0, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tblMain.Size = new System.Drawing.Size(1034, 707);
            this.tblMain.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Location = new System.Drawing.Point(3, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(1028, 64);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "label1";
            // 
            // tblControls
            // 
            this.tblControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tblControls.ColumnCount = 6;
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblControls.Controls.Add(this.btnPickWord, 0, 0);
            this.tblControls.Controls.Add(this.btnGiveUp, 1, 0);
            this.tblControls.Controls.Add(this.optdef1, 2, 0);
            this.tblControls.Controls.Add(this.optdef2, 3, 0);
            this.tblControls.Controls.Add(this.optdef3, 4, 0);
            this.tblControls.Controls.Add(this.btntEnter, 5, 0);
            this.tblControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblControls.Location = new System.Drawing.Point(3, 67);
            this.tblControls.Name = "tblControls";
            this.tblControls.RowCount = 1;
            this.tblControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblControls.Size = new System.Drawing.Size(1028, 315);
            this.tblControls.TabIndex = 1;
            // 
            // btnPickWord
            // 
            this.btnPickWord.BackColor = System.Drawing.Color.Blue;
            this.btnPickWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPickWord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPickWord.Location = new System.Drawing.Point(3, 3);
            this.btnPickWord.Name = "btnPickWord";
            this.btnPickWord.Size = new System.Drawing.Size(165, 309);
            this.btnPickWord.TabIndex = 0;
            this.btnPickWord.Text = "Pick A Word";
            this.btnPickWord.UseVisualStyleBackColor = false;
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.BackColor = System.Drawing.Color.White;
            this.btnGiveUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGiveUp.Location = new System.Drawing.Point(174, 3);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(165, 309);
            this.btnGiveUp.TabIndex = 1;
            this.btnGiveUp.Text = "I Give Up";
            this.btnGiveUp.UseVisualStyleBackColor = false;
            // 
            // optdef1
            // 
            this.optdef1.AutoSize = true;
            this.optdef1.BackColor = System.Drawing.Color.Red;
            this.optdef1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optdef1.Location = new System.Drawing.Point(345, 3);
            this.optdef1.Name = "optdef1";
            this.optdef1.Size = new System.Drawing.Size(165, 309);
            this.optdef1.TabIndex = 2;
            this.optdef1.TabStop = true;
            this.optdef1.Text = "def 1";
            this.optdef1.UseVisualStyleBackColor = false;
            // 
            // optdef2
            // 
            this.optdef2.AutoSize = true;
            this.optdef2.BackColor = System.Drawing.Color.Fuchsia;
            this.optdef2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optdef2.Location = new System.Drawing.Point(516, 3);
            this.optdef2.Name = "optdef2";
            this.optdef2.Size = new System.Drawing.Size(165, 309);
            this.optdef2.TabIndex = 3;
            this.optdef2.TabStop = true;
            this.optdef2.Text = "def 2";
            this.optdef2.UseVisualStyleBackColor = false;
            // 
            // optdef3
            // 
            this.optdef3.AutoSize = true;
            this.optdef3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.optdef3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optdef3.Location = new System.Drawing.Point(687, 3);
            this.optdef3.Name = "optdef3";
            this.optdef3.Size = new System.Drawing.Size(165, 309);
            this.optdef3.TabIndex = 4;
            this.optdef3.TabStop = true;
            this.optdef3.Text = "def 3";
            this.optdef3.UseVisualStyleBackColor = false;
            // 
            // btntEnter
            // 
            this.btntEnter.BackColor = System.Drawing.Color.Lime;
            this.btntEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btntEnter.Location = new System.Drawing.Point(858, 3);
            this.btntEnter.Name = "btntEnter";
            this.btntEnter.Size = new System.Drawing.Size(167, 309);
            this.btntEnter.TabIndex = 5;
            this.btntEnter.Text = "enter";
            this.btntEnter.UseVisualStyleBackColor = false;
            // 
            // tblPlayArea
            // 
            this.tblPlayArea.ColumnCount = 5;
            this.tblPlayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPlayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPlayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tblPlayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPlayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tblPlayArea.Controls.Add(this.tblDefinitions, 0, 0);
            this.tblPlayArea.Controls.Add(this.lblwordscaptioned, 1, 0);
            this.tblPlayArea.Controls.Add(this.lblNumWords, 2, 0);
            this.tblPlayArea.Controls.Add(this.lblscorecaotion, 3, 0);
            this.tblPlayArea.Controls.Add(this.lblscore, 4, 0);
            this.tblPlayArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPlayArea.Location = new System.Drawing.Point(3, 388);
            this.tblPlayArea.Name = "tblPlayArea";
            this.tblPlayArea.RowCount = 1;
            this.tblPlayArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPlayArea.Size = new System.Drawing.Size(1028, 316);
            this.tblPlayArea.TabIndex = 2;
            // 
            // tblDefinitions
            // 
            this.tblDefinitions.BackColor = System.Drawing.Color.Cyan;
            this.tblDefinitions.ColumnCount = 2;
            this.tblDefinitions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDefinitions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDefinitions.Controls.Add(this.label7, 1, 3);
            this.tblDefinitions.Controls.Add(this.lbldef3, 0, 3);
            this.tblDefinitions.Controls.Add(this.label5, 1, 2);
            this.tblDefinitions.Controls.Add(this.lbldef2, 0, 2);
            this.tblDefinitions.Controls.Add(this.label1, 1, 1);
            this.tblDefinitions.Controls.Add(this.lbldef1, 0, 1);
            this.tblDefinitions.Controls.Add(this.label2, 1, 0);
            this.tblDefinitions.Controls.Add(this.lblWord, 0, 0);
            this.tblDefinitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDefinitions.Location = new System.Drawing.Point(3, 3);
            this.tblDefinitions.Name = "tblDefinitions";
            this.tblDefinitions.RowCount = 4;
            this.tblDefinitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDefinitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDefinitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDefinitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDefinitions.Size = new System.Drawing.Size(705, 310);
            this.tblDefinitions.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(355, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(347, 79);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // lbldef3
            // 
            this.lbldef3.AutoSize = true;
            this.lbldef3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbldef3.Location = new System.Drawing.Point(3, 231);
            this.lbldef3.Name = "lbldef3";
            this.lbldef3.Size = new System.Drawing.Size(346, 79);
            this.lbldef3.TabIndex = 6;
            this.lbldef3.Text = "def 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(355, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 77);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // lbldef2
            // 
            this.lbldef2.AutoSize = true;
            this.lbldef2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbldef2.Location = new System.Drawing.Point(3, 154);
            this.lbldef2.Name = "lbldef2";
            this.lbldef2.Size = new System.Drawing.Size(346, 77);
            this.lbldef2.TabIndex = 4;
            this.lbldef2.Text = "def 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(355, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 77);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // lbldef1
            // 
            this.lbldef1.AutoSize = true;
            this.lbldef1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbldef1.Location = new System.Drawing.Point(3, 77);
            this.lbldef1.Name = "lbldef1";
            this.lbldef1.Size = new System.Drawing.Size(346, 77);
            this.lbldef1.TabIndex = 2;
            this.lbldef1.Text = "def 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(355, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 77);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWord.Location = new System.Drawing.Point(3, 0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(346, 77);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "word";
            // 
            // lblwordscaptioned
            // 
            this.lblwordscaptioned.AutoSize = true;
            this.lblwordscaptioned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblwordscaptioned.Location = new System.Drawing.Point(714, 0);
            this.lblwordscaptioned.Name = "lblwordscaptioned";
            this.lblwordscaptioned.Size = new System.Drawing.Size(111, 316);
            this.lblwordscaptioned.TabIndex = 1;
            this.lblwordscaptioned.Text = "num word tried";
            // 
            // lblNumWords
            // 
            this.lblNumWords.AutoSize = true;
            this.lblNumWords.BackColor = System.Drawing.Color.Blue;
            this.lblNumWords.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNumWords.ForeColor = System.Drawing.Color.White;
            this.lblNumWords.Location = new System.Drawing.Point(831, 0);
            this.lblNumWords.Name = "lblNumWords";
            this.lblNumWords.Size = new System.Drawing.Size(69, 20);
            this.lblNumWords.TabIndex = 2;
            this.lblNumWords.Text = "0";
            this.lblNumWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblscorecaotion
            // 
            this.lblscorecaotion.AutoSize = true;
            this.lblscorecaotion.Location = new System.Drawing.Point(906, 0);
            this.lblscorecaotion.Name = "lblscorecaotion";
            this.lblscorecaotion.Size = new System.Drawing.Size(44, 20);
            this.lblscorecaotion.TabIndex = 3;
            this.lblscorecaotion.Text = "score";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.Teal;
            this.lblscore.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblscore.ForeColor = System.Drawing.Color.White;
            this.lblscore.Location = new System.Drawing.Point(956, 0);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(69, 20);
            this.lblscore.TabIndex = 4;
            this.lblscore.Text = "0";
            this.lblscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 707);
            this.Controls.Add(this.tblMain);
            this.Name = "frmMain";
            this.Text = "Deficiando";
            this.tblMain.ResumeLayout(false);
            this.tblControls.ResumeLayout(false);
            this.tblControls.PerformLayout();
            this.tblPlayArea.ResumeLayout(false);
            this.tblPlayArea.PerformLayout();
            this.tblDefinitions.ResumeLayout(false);
            this.tblDefinitions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblMessage;
        private TableLayoutPanel tblControls;
        private Button btnPickWord;
        private Button btnGiveUp;
        private RadioButton optdef1;
        private RadioButton optdef2;
        private RadioButton optdef3;
        private Button btntEnter;
        private TableLayoutPanel tblPlayArea;
        private TableLayoutPanel tblDefinitions;
        private Label label7;
        private Label lbldef3;
        private Label label5;
        private Label lbldef2;
        private Label label1;
        private Label lbldef1;
        private Label label2;
        private Label lblWord;
        private Label lblwordscaptioned;
        private Label lblNumWords;
        private Label lblscorecaotion;
        private Label lblscore;
    }
}
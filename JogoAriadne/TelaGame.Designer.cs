namespace JogoAriadne
{
    partial class TelaGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaGame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difícilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoJogoToolStripMenuItem,
            this.nivelToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // novoJogoToolStripMenuItem
            // 
            this.novoJogoToolStripMenuItem.Name = "novoJogoToolStripMenuItem";
            this.novoJogoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.novoJogoToolStripMenuItem.Text = "Novo Jogo";
            this.novoJogoToolStripMenuItem.Click += new System.EventHandler(this.novoJogoToolStripMenuItem_Click);
            // 
            // nivelToolStripMenuItem
            // 
            this.nivelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facilToolStripMenuItem,
            this.médioToolStripMenuItem,
            this.difícilToolStripMenuItem});
            this.nivelToolStripMenuItem.Name = "nivelToolStripMenuItem";
            this.nivelToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.nivelToolStripMenuItem.Text = "Nivel";
            this.nivelToolStripMenuItem.Click += new System.EventHandler(this.nivelToolStripMenuItem_Click);
            // 
            // facilToolStripMenuItem
            // 
            this.facilToolStripMenuItem.Name = "facilToolStripMenuItem";
            this.facilToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.facilToolStripMenuItem.Text = "Facil";
            this.facilToolStripMenuItem.Click += new System.EventHandler(this.facilToolStripMenuItem_Click);
            // 
            // médioToolStripMenuItem
            // 
            this.médioToolStripMenuItem.Name = "médioToolStripMenuItem";
            this.médioToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.médioToolStripMenuItem.Text = "Médio";
            this.médioToolStripMenuItem.Click += new System.EventHandler(this.médioToolStripMenuItem_Click);
            // 
            // difícilToolStripMenuItem
            // 
            this.difícilToolStripMenuItem.Name = "difícilToolStripMenuItem";
            this.difícilToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.difícilToolStripMenuItem.Text = "Difícil";
            this.difícilToolStripMenuItem.Click += new System.EventHandler(this.difícilToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            this.label1.Location = new System.Drawing.Point(288, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            this.label2.Location = new System.Drawing.Point(159, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Advinhe o número:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(280, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 30);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            this.label3.Location = new System.Drawing.Point(204, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 43);
            this.label3.TabIndex = 5;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            this.label4.Location = new System.Drawing.Point(12, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // TelaGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "     ";
            this.Load += new System.EventHandler(this.TelaGame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem facilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difícilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
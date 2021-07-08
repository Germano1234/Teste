namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ADD = new System.Windows.Forms.Button();
            this.IDP = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.línguaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portuguêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.españolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvlProdutos = new System.Windows.Forms.ListView();
            this.NOP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DES = new System.Windows.Forms.TextBox();
            this.PRP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.REM = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ADD
            // 
            resources.ApplyResources(this.ADD, "ADD");
            this.ADD.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ADD.ForeColor = System.Drawing.SystemColors.Control;
            this.ADD.Name = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // IDP
            // 
            resources.ApplyResources(this.IDP, "IDP");
            this.IDP.Name = "IDP";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.línguaToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // línguaToolStripMenuItem
            // 
            resources.ApplyResources(this.línguaToolStripMenuItem, "línguaToolStripMenuItem");
            this.línguaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.portuguêsToolStripMenuItem,
            this.españolToolStripMenuItem});
            this.línguaToolStripMenuItem.Name = "línguaToolStripMenuItem";
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // portuguêsToolStripMenuItem
            // 
            resources.ApplyResources(this.portuguêsToolStripMenuItem, "portuguêsToolStripMenuItem");
            this.portuguêsToolStripMenuItem.Name = "portuguêsToolStripMenuItem";
            this.portuguêsToolStripMenuItem.Click += new System.EventHandler(this.portuguêsToolStripMenuItem_Click_1);
            // 
            // españolToolStripMenuItem
            // 
            resources.ApplyResources(this.españolToolStripMenuItem, "españolToolStripMenuItem");
            this.españolToolStripMenuItem.Name = "españolToolStripMenuItem";
            this.españolToolStripMenuItem.Click += new System.EventHandler(this.españolToolStripMenuItem_Click);
            // 
            // lvlProdutos
            // 
            resources.ApplyResources(this.lvlProdutos, "lvlProdutos");
            this.lvlProdutos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lvlProdutos.FullRowSelect = true;
            this.lvlProdutos.HideSelection = false;
            this.lvlProdutos.Name = "lvlProdutos";
            this.lvlProdutos.UseCompatibleStateImageBehavior = false;
            this.lvlProdutos.View = System.Windows.Forms.View.Details;
            this.lvlProdutos.SelectedIndexChanged += new System.EventHandler(this.lvlProdutos_SelectedIndexChanged);
            // 
            // NOP
            // 
            resources.ApplyResources(this.NOP, "NOP");
            this.NOP.Name = "NOP";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // DES
            // 
            resources.ApplyResources(this.DES, "DES");
            this.DES.Name = "DES";
            // 
            // PRP
            // 
            resources.ApplyResources(this.PRP, "PRP");
            this.PRP.Name = "PRP";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Name = "label5";
            // 
            // REM
            // 
            resources.ApplyResources(this.REM, "REM");
            this.REM.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.REM.ForeColor = System.Drawing.SystemColors.Control;
            this.REM.Name = "REM";
            this.REM.UseVisualStyleBackColor = false;
            this.REM.Click += new System.EventHandler(this.REM_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.REM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PRP);
            this.Controls.Add(this.DES);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NOP);
            this.Controls.Add(this.lvlProdutos);
            this.Controls.Add(this.IDP);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.TextBox IDP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListView lvlProdutos;
        private System.Windows.Forms.TextBox NOP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DES;
        private System.Windows.Forms.TextBox PRP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button REM;
        private System.Windows.Forms.ToolStripMenuItem línguaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portuguêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem españolToolStripMenuItem;
    }
}


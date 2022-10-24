namespace Cozee_V4
{
    partial class UC_HOME
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.verSel = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedButton1 = new Cozee_V4.RoundedButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // verSel
            // 
            this.verSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.verSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.verSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verSel.FormattingEnabled = true;
            this.verSel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.verSel.Location = new System.Drawing.Point(50, 52);
            this.verSel.Name = "verSel";
            this.verSel.Size = new System.Drawing.Size(303, 37);
            this.verSel.TabIndex = 0;
            this.verSel.SelectedIndexChanged += new System.EventHandler(this.test_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.usernameext);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.roundedButton1);
            this.panel1.Controls.Add(this.verSel);
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 205);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Cozee_V4.Properties.Resources._515647;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(359, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 48);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(90, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Game Version";
            // 
            // usernameext
            // 
            this.usernameext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameext.Location = new System.Drawing.Point(455, 129);
            this.usernameext.Name = "usernameext";
            this.usernameext.Size = new System.Drawing.Size(159, 35);
            this.usernameext.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(456, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.Black;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundedButton1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.White;
            this.roundedButton1.Location = new System.Drawing.Point(50, 104);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(360, 56);
            this.roundedButton1.TabIndex = 2;
            this.roundedButton1.Text = "Launch";
            this.roundedButton1.UseVisualStyleBackColor = false;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // UC_HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cozee_V4.Properties.Resources.unknown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UC_HOME";
            this.Size = new System.Drawing.Size(997, 525);
            this.Load += new System.EventHandler(this.UC_HOME_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox verSel;
        private System.Windows.Forms.Panel panel1;
        private RoundedButton roundedButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

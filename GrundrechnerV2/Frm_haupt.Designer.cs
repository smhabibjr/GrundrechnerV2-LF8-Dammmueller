namespace GrundrechnerV2
{
    partial class Frm_haupt
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lBx_z1 = new System.Windows.Forms.ListBox();
            this.lBx_z2 = new System.Windows.Forms.ListBox();
            this.lbl_z1 = new System.Windows.Forms.Label();
            this.lbl_z2 = new System.Windows.Forms.Label();
            this.btn_init = new System.Windows.Forms.Button();
            this.grpB_op = new System.Windows.Forms.GroupBox();
            this.rBtn_div = new System.Windows.Forms.RadioButton();
            this.rBtn_multi = new System.Windows.Forms.RadioButton();
            this.rBtn_sub = new System.Windows.Forms.RadioButton();
            this.rBtn_add = new System.Windows.Forms.RadioButton();
            this.lbl_ergebnis = new System.Windows.Forms.Label();
            this.grBx_auswahl = new System.Windows.Forms.GroupBox();
            this.lbl_pot_z2 = new System.Windows.Forms.Label();
            this.lbl_pot_z1 = new System.Windows.Forms.Label();
            this.tB_pot_z2 = new System.Windows.Forms.TextBox();
            this.tB_pot_z1 = new System.Windows.Forms.TextBox();
            this.btn_speichern = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpB_op.SuspendLayout();
            this.grBx_auswahl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lBx_z1
            // 
            this.lBx_z1.FormattingEnabled = true;
            this.lBx_z1.ItemHeight = 16;
            this.lBx_z1.Location = new System.Drawing.Point(223, 46);
            this.lBx_z1.Margin = new System.Windows.Forms.Padding(4);
            this.lBx_z1.Name = "lBx_z1";
            this.lBx_z1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lBx_z1.Size = new System.Drawing.Size(65, 180);
            this.lBx_z1.TabIndex = 2;
            // 
            // lBx_z2
            // 
            this.lBx_z2.FormattingEnabled = true;
            this.lBx_z2.ItemHeight = 16;
            this.lBx_z2.Location = new System.Drawing.Point(300, 46);
            this.lBx_z2.Margin = new System.Windows.Forms.Padding(4);
            this.lBx_z2.Name = "lBx_z2";
            this.lBx_z2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lBx_z2.Size = new System.Drawing.Size(65, 180);
            this.lBx_z2.TabIndex = 3;
            // 
            // lbl_z1
            // 
            this.lbl_z1.AutoSize = true;
            this.lbl_z1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_z1.Location = new System.Drawing.Point(223, 15);
            this.lbl_z1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_z1.Name = "lbl_z1";
            this.lbl_z1.Size = new System.Drawing.Size(54, 18);
            this.lbl_z1.TabIndex = 2;
            this.lbl_z1.Text = "Zahl 1";
            // 
            // lbl_z2
            // 
            this.lbl_z2.AutoSize = true;
            this.lbl_z2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_z2.Location = new System.Drawing.Point(300, 15);
            this.lbl_z2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_z2.Name = "lbl_z2";
            this.lbl_z2.Size = new System.Drawing.Size(54, 18);
            this.lbl_z2.TabIndex = 3;
            this.lbl_z2.Text = "Zahl 2";
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(16, 128);
            this.btn_init.Margin = new System.Windows.Forms.Padding(4);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(192, 98);
            this.btn_init.TabIndex = 4;
            this.btn_init.Text = "Initialisieren";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // grpB_op
            // 
            this.grpB_op.Controls.Add(this.rBtn_div);
            this.grpB_op.Controls.Add(this.rBtn_multi);
            this.grpB_op.Controls.Add(this.rBtn_sub);
            this.grpB_op.Controls.Add(this.rBtn_add);
            this.grpB_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpB_op.Location = new System.Drawing.Point(16, 234);
            this.grpB_op.Margin = new System.Windows.Forms.Padding(4);
            this.grpB_op.Name = "grpB_op";
            this.grpB_op.Padding = new System.Windows.Forms.Padding(4);
            this.grpB_op.Size = new System.Drawing.Size(351, 97);
            this.grpB_op.TabIndex = 6;
            this.grpB_op.TabStop = false;
            this.grpB_op.Text = "Auswahl Operation";
            // 
            // rBtn_div
            // 
            this.rBtn_div.AutoSize = true;
            this.rBtn_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_div.Location = new System.Drawing.Point(191, 62);
            this.rBtn_div.Margin = new System.Windows.Forms.Padding(4);
            this.rBtn_div.Name = "rBtn_div";
            this.rBtn_div.Size = new System.Drawing.Size(78, 21);
            this.rBtn_div.TabIndex = 10;
            this.rBtn_div.TabStop = true;
            this.rBtn_div.Text = "Division";
            this.rBtn_div.UseVisualStyleBackColor = true;
            this.rBtn_div.CheckedChanged += new System.EventHandler(this.rBtn_div_CheckedChanged);
            // 
            // rBtn_multi
            // 
            this.rBtn_multi.AutoSize = true;
            this.rBtn_multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_multi.Location = new System.Drawing.Point(191, 33);
            this.rBtn_multi.Margin = new System.Windows.Forms.Padding(4);
            this.rBtn_multi.Name = "rBtn_multi";
            this.rBtn_multi.Size = new System.Drawing.Size(110, 21);
            this.rBtn_multi.TabIndex = 9;
            this.rBtn_multi.TabStop = true;
            this.rBtn_multi.Text = "Multiplikation";
            this.rBtn_multi.UseVisualStyleBackColor = true;
            this.rBtn_multi.CheckedChanged += new System.EventHandler(this.rBtn_multi_CheckedChanged);
            // 
            // rBtn_sub
            // 
            this.rBtn_sub.AutoSize = true;
            this.rBtn_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_sub.Location = new System.Drawing.Point(52, 62);
            this.rBtn_sub.Margin = new System.Windows.Forms.Padding(4);
            this.rBtn_sub.Name = "rBtn_sub";
            this.rBtn_sub.Size = new System.Drawing.Size(101, 21);
            this.rBtn_sub.TabIndex = 8;
            this.rBtn_sub.TabStop = true;
            this.rBtn_sub.Text = "Subtraktion";
            this.rBtn_sub.UseVisualStyleBackColor = true;
            this.rBtn_sub.CheckedChanged += new System.EventHandler(this.rBtn_sub_CheckedChanged);
            // 
            // rBtn_add
            // 
            this.rBtn_add.AutoSize = true;
            this.rBtn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtn_add.Location = new System.Drawing.Point(52, 33);
            this.rBtn_add.Margin = new System.Windows.Forms.Padding(4);
            this.rBtn_add.Name = "rBtn_add";
            this.rBtn_add.Size = new System.Drawing.Size(80, 21);
            this.rBtn_add.TabIndex = 7;
            this.rBtn_add.TabStop = true;
            this.rBtn_add.Text = "Addition";
            this.rBtn_add.UseVisualStyleBackColor = true;
            this.rBtn_add.CheckedChanged += new System.EventHandler(this.rBtn_add_CheckedChanged);
            // 
            // lbl_ergebnis
            // 
            this.lbl_ergebnis.AutoSize = true;
            this.lbl_ergebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ergebnis.Location = new System.Drawing.Point(11, 347);
            this.lbl_ergebnis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ergebnis.Name = "lbl_ergebnis";
            this.lbl_ergebnis.Size = new System.Drawing.Size(89, 20);
            this.lbl_ergebnis.TabIndex = 1;
            this.lbl_ergebnis.Text = "Ergebnis:";
            // 
            // grBx_auswahl
            // 
            this.grBx_auswahl.Controls.Add(this.lbl_pot_z2);
            this.grBx_auswahl.Controls.Add(this.lbl_pot_z1);
            this.grBx_auswahl.Controls.Add(this.tB_pot_z2);
            this.grBx_auswahl.Controls.Add(this.tB_pot_z1);
            this.grBx_auswahl.Location = new System.Drawing.Point(16, 15);
            this.grBx_auswahl.Margin = new System.Windows.Forms.Padding(4);
            this.grBx_auswahl.Name = "grBx_auswahl";
            this.grBx_auswahl.Padding = new System.Windows.Forms.Padding(4);
            this.grBx_auswahl.Size = new System.Drawing.Size(192, 106);
            this.grBx_auswahl.TabIndex = 5;
            this.grBx_auswahl.TabStop = false;
            this.grBx_auswahl.Text = "Auswahl 10\'er-Potenzen:";
            // 
            // lbl_pot_z2
            // 
            this.lbl_pot_z2.AutoSize = true;
            this.lbl_pot_z2.Location = new System.Drawing.Point(19, 66);
            this.lbl_pot_z2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pot_z2.Name = "lbl_pot_z2";
            this.lbl_pot_z2.Size = new System.Drawing.Size(73, 17);
            this.lbl_pot_z2.TabIndex = 4;
            this.lbl_pot_z2.Text = "für Zahl 2:";
            // 
            // lbl_pot_z1
            // 
            this.lbl_pot_z1.AutoSize = true;
            this.lbl_pot_z1.Location = new System.Drawing.Point(19, 34);
            this.lbl_pot_z1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pot_z1.Name = "lbl_pot_z1";
            this.lbl_pot_z1.Size = new System.Drawing.Size(73, 17);
            this.lbl_pot_z1.TabIndex = 3;
            this.lbl_pot_z1.Text = "für Zahl 1:";
            // 
            // tB_pot_z2
            // 
            this.tB_pot_z2.Location = new System.Drawing.Point(100, 63);
            this.tB_pot_z2.Margin = new System.Windows.Forms.Padding(4);
            this.tB_pot_z2.Name = "tB_pot_z2";
            this.tB_pot_z2.Size = new System.Drawing.Size(72, 22);
            this.tB_pot_z2.TabIndex = 0;
            // 
            // tB_pot_z1
            // 
            this.tB_pot_z1.Location = new System.Drawing.Point(100, 31);
            this.tB_pot_z1.Margin = new System.Windows.Forms.Padding(4);
            this.tB_pot_z1.Name = "tB_pot_z1";
            this.tB_pot_z1.Size = new System.Drawing.Size(72, 22);
            this.tB_pot_z1.TabIndex = 5;
            // 
            // btn_speichern
            // 
            this.btn_speichern.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_speichern.Location = new System.Drawing.Point(0, 386);
            this.btn_speichern.Margin = new System.Windows.Forms.Padding(4);
            this.btn_speichern.Name = "btn_speichern";
            this.btn_speichern.Size = new System.Drawing.Size(384, 28);
            this.btn_speichern.TabIndex = 7;
            this.btn_speichern.Text = "Speichern";
            this.btn_speichern.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Frm_haupt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 414);
            this.Controls.Add(this.btn_speichern);
            this.Controls.Add(this.grBx_auswahl);
            this.Controls.Add(this.lbl_ergebnis);
            this.Controls.Add(this.grpB_op);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.lbl_z2);
            this.Controls.Add(this.lbl_z1);
            this.Controls.Add(this.lBx_z2);
            this.Controls.Add(this.lBx_z1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_haupt";
            this.Text = "Grundrechner V2.0";
            this.grpB_op.ResumeLayout(false);
            this.grpB_op.PerformLayout();
            this.grBx_auswahl.ResumeLayout(false);
            this.grBx_auswahl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBx_z1;
        private System.Windows.Forms.ListBox lBx_z2;
        private System.Windows.Forms.Label lbl_z1;
        private System.Windows.Forms.Label lbl_z2;
        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.GroupBox grpB_op;
        private System.Windows.Forms.RadioButton rBtn_div;
        private System.Windows.Forms.RadioButton rBtn_multi;
        private System.Windows.Forms.RadioButton rBtn_sub;
        private System.Windows.Forms.RadioButton rBtn_add;
        private System.Windows.Forms.Label lbl_ergebnis;
        private System.Windows.Forms.GroupBox grBx_auswahl;
        private System.Windows.Forms.TextBox tB_pot_z2;
        private System.Windows.Forms.TextBox tB_pot_z1;
        private System.Windows.Forms.Label lbl_pot_z2;
        private System.Windows.Forms.Label lbl_pot_z1;
        private System.Windows.Forms.Button btn_speichern;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}


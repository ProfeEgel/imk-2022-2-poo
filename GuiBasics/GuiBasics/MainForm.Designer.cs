namespace GuiBasics
{
    partial class MainForm
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
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.chkDouble = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColors = new System.Windows.Forms.TextBox();
            this.chkRojo = new System.Windows.Forms.CheckBox();
            this.chkAzul = new System.Windows.Forms.CheckBox();
            this.chkVerde = new System.Windows.Forms.CheckBox();
            this.chkAmarillo = new System.Windows.Forms.CheckBox();
            this.chkMagenta = new System.Windows.Forms.CheckBox();
            this.chkCyan = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColors2 = new System.Windows.Forms.TextBox();
            this.radRojo = new System.Windows.Forms.RadioButton();
            this.radAzul = new System.Windows.Forms.RadioButton();
            this.radVerde = new System.Windows.Forms.RadioButton();
            this.radAmarillo = new System.Windows.Forms.RadioButton();
            this.radCyan = new System.Windows.Forms.RadioButton();
            this.radMagenta = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(391, 21);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(93, 38);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prueba:";
            // 
            // txtTest
            // 
            this.txtTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTest.Location = new System.Drawing.Point(82, 27);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(292, 26);
            this.txtTest.TabIndex = 2;
            // 
            // chkDouble
            // 
            this.chkDouble.AutoSize = true;
            this.chkDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDouble.Location = new System.Drawing.Point(82, 59);
            this.chkDouble.Name = "chkDouble";
            this.chkDouble.Size = new System.Drawing.Size(152, 24);
            this.chkDouble.TabIndex = 3;
            this.chkDouble.Text = "Incremento doble";
            this.chkDouble.UseVisualStyleBackColor = true;
            this.chkDouble.CheckedChanged += new System.EventHandler(this.chkDouble_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Colores:";
            // 
            // txtColors
            // 
            this.txtColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColors.Location = new System.Drawing.Point(82, 98);
            this.txtColors.Name = "txtColors";
            this.txtColors.ReadOnly = true;
            this.txtColors.Size = new System.Drawing.Size(402, 26);
            this.txtColors.TabIndex = 2;
            // 
            // chkRojo
            // 
            this.chkRojo.AutoSize = true;
            this.chkRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRojo.Location = new System.Drawing.Point(82, 143);
            this.chkRojo.Name = "chkRojo";
            this.chkRojo.Size = new System.Drawing.Size(55, 20);
            this.chkRojo.TabIndex = 4;
            this.chkRojo.Text = "Rojo";
            this.chkRojo.UseVisualStyleBackColor = true;
            this.chkRojo.CheckedChanged += new System.EventHandler(this.chkRojo_CheckedChanged);
            // 
            // chkAzul
            // 
            this.chkAzul.AutoSize = true;
            this.chkAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAzul.Location = new System.Drawing.Point(82, 169);
            this.chkAzul.Name = "chkAzul";
            this.chkAzul.Size = new System.Drawing.Size(51, 20);
            this.chkAzul.TabIndex = 4;
            this.chkAzul.Text = "Azul";
            this.chkAzul.UseVisualStyleBackColor = true;
            this.chkAzul.CheckedChanged += new System.EventHandler(this.chkRojo_CheckedChanged);
            // 
            // chkVerde
            // 
            this.chkVerde.AutoSize = true;
            this.chkVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVerde.Location = new System.Drawing.Point(82, 194);
            this.chkVerde.Name = "chkVerde";
            this.chkVerde.Size = new System.Drawing.Size(63, 20);
            this.chkVerde.TabIndex = 4;
            this.chkVerde.Text = "Verde";
            this.chkVerde.UseVisualStyleBackColor = true;
            this.chkVerde.CheckedChanged += new System.EventHandler(this.chkRojo_CheckedChanged);
            // 
            // chkAmarillo
            // 
            this.chkAmarillo.AutoSize = true;
            this.chkAmarillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAmarillo.Location = new System.Drawing.Point(186, 143);
            this.chkAmarillo.Name = "chkAmarillo";
            this.chkAmarillo.Size = new System.Drawing.Size(75, 20);
            this.chkAmarillo.TabIndex = 4;
            this.chkAmarillo.Text = "Amarillo";
            this.chkAmarillo.UseVisualStyleBackColor = true;
            this.chkAmarillo.CheckedChanged += new System.EventHandler(this.chkRojo_CheckedChanged);
            // 
            // chkMagenta
            // 
            this.chkMagenta.AutoSize = true;
            this.chkMagenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMagenta.Location = new System.Drawing.Point(186, 194);
            this.chkMagenta.Name = "chkMagenta";
            this.chkMagenta.Size = new System.Drawing.Size(79, 20);
            this.chkMagenta.TabIndex = 4;
            this.chkMagenta.Text = "Magenta";
            this.chkMagenta.UseVisualStyleBackColor = true;
            this.chkMagenta.CheckedChanged += new System.EventHandler(this.chkRojo_CheckedChanged);
            // 
            // chkCyan
            // 
            this.chkCyan.AutoSize = true;
            this.chkCyan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCyan.Location = new System.Drawing.Point(186, 169);
            this.chkCyan.Name = "chkCyan";
            this.chkCyan.Size = new System.Drawing.Size(57, 20);
            this.chkCyan.TabIndex = 4;
            this.chkCyan.Text = "Cyan";
            this.chkCyan.UseVisualStyleBackColor = true;
            this.chkCyan.CheckedChanged += new System.EventHandler(this.chkRojo_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Colores:";
            // 
            // txtColors2
            // 
            this.txtColors2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColors2.Location = new System.Drawing.Point(82, 234);
            this.txtColors2.Name = "txtColors2";
            this.txtColors2.ReadOnly = true;
            this.txtColors2.Size = new System.Drawing.Size(402, 26);
            this.txtColors2.TabIndex = 2;
            this.txtColors2.Text = "Rojo+Amarillo";
            // 
            // radRojo
            // 
            this.radRojo.AutoSize = true;
            this.radRojo.Checked = true;
            this.radRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRojo.Location = new System.Drawing.Point(27, 30);
            this.radRojo.Name = "radRojo";
            this.radRojo.Size = new System.Drawing.Size(54, 20);
            this.radRojo.TabIndex = 5;
            this.radRojo.TabStop = true;
            this.radRojo.Text = "Rojo";
            this.radRojo.UseVisualStyleBackColor = true;
            this.radRojo.Click += new System.EventHandler(this.radRojo_Click);
            // 
            // radAzul
            // 
            this.radAzul.AutoSize = true;
            this.radAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAzul.Location = new System.Drawing.Point(27, 56);
            this.radAzul.Name = "radAzul";
            this.radAzul.Size = new System.Drawing.Size(50, 20);
            this.radAzul.TabIndex = 5;
            this.radAzul.Text = "Azul";
            this.radAzul.UseVisualStyleBackColor = true;
            this.radAzul.Click += new System.EventHandler(this.radRojo_Click);
            // 
            // radVerde
            // 
            this.radVerde.AutoSize = true;
            this.radVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVerde.Location = new System.Drawing.Point(27, 82);
            this.radVerde.Name = "radVerde";
            this.radVerde.Size = new System.Drawing.Size(62, 20);
            this.radVerde.TabIndex = 5;
            this.radVerde.Text = "Verde";
            this.radVerde.UseVisualStyleBackColor = true;
            this.radVerde.Click += new System.EventHandler(this.radRojo_Click);
            // 
            // radAmarillo
            // 
            this.radAmarillo.AutoSize = true;
            this.radAmarillo.Checked = true;
            this.radAmarillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAmarillo.Location = new System.Drawing.Point(29, 30);
            this.radAmarillo.Name = "radAmarillo";
            this.radAmarillo.Size = new System.Drawing.Size(74, 20);
            this.radAmarillo.TabIndex = 5;
            this.radAmarillo.TabStop = true;
            this.radAmarillo.Text = "Amarillo";
            this.radAmarillo.UseVisualStyleBackColor = true;
            this.radAmarillo.Click += new System.EventHandler(this.radAmarillo_Click);
            // 
            // radCyan
            // 
            this.radCyan.AutoSize = true;
            this.radCyan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCyan.Location = new System.Drawing.Point(29, 56);
            this.radCyan.Name = "radCyan";
            this.radCyan.Size = new System.Drawing.Size(56, 20);
            this.radCyan.TabIndex = 5;
            this.radCyan.Text = "Cyan";
            this.radCyan.UseVisualStyleBackColor = true;
            this.radCyan.Click += new System.EventHandler(this.radAmarillo_Click);
            // 
            // radMagenta
            // 
            this.radMagenta.AutoSize = true;
            this.radMagenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMagenta.Location = new System.Drawing.Point(29, 82);
            this.radMagenta.Name = "radMagenta";
            this.radMagenta.Size = new System.Drawing.Size(78, 20);
            this.radMagenta.TabIndex = 5;
            this.radMagenta.Text = "Magenta";
            this.radMagenta.UseVisualStyleBackColor = true;
            this.radMagenta.Click += new System.EventHandler(this.radAmarillo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRojo);
            this.groupBox1.Controls.Add(this.radAzul);
            this.groupBox1.Controls.Add(this.radVerde);
            this.groupBox1.Location = new System.Drawing.Point(82, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radAmarillo);
            this.groupBox2.Controls.Add(this.radCyan);
            this.groupBox2.Controls.Add(this.radMagenta);
            this.groupBox2.Location = new System.Drawing.Point(305, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 121);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color B";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkCyan);
            this.Controls.Add(this.chkAzul);
            this.Controls.Add(this.chkMagenta);
            this.Controls.Add(this.chkVerde);
            this.Controls.Add(this.chkAmarillo);
            this.Controls.Add(this.chkRojo);
            this.Controls.Add(this.chkDouble);
            this.Controls.Add(this.txtColors2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtColors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTest);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.CheckBox chkDouble;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColors;
        private System.Windows.Forms.CheckBox chkRojo;
        private System.Windows.Forms.CheckBox chkAzul;
        private System.Windows.Forms.CheckBox chkVerde;
        private System.Windows.Forms.CheckBox chkAmarillo;
        private System.Windows.Forms.CheckBox chkMagenta;
        private System.Windows.Forms.CheckBox chkCyan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColors2;
        private System.Windows.Forms.RadioButton radRojo;
        private System.Windows.Forms.RadioButton radAzul;
        private System.Windows.Forms.RadioButton radVerde;
        private System.Windows.Forms.RadioButton radAmarillo;
        private System.Windows.Forms.RadioButton radCyan;
        private System.Windows.Forms.RadioButton radMagenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


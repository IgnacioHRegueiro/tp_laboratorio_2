
namespace MiCalculadora
{
	partial class FormCalculadora
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.lblBinary = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lstOperaciones = new System.Windows.Forms.ListBox();
            this.cbmOperadores = new System.Windows.Forms.ComboBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConvertirBinario = new System.Windows.Forms.Button();
            this.btnConvertirDecimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBinary
            // 
            this.lblBinary.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBinary.Location = new System.Drawing.Point(135, 7);
            this.lblBinary.Name = "lblBinary";
            this.lblBinary.Size = new System.Drawing.Size(275, 25);
            this.lblBinary.TabIndex = 0;
            this.lblBinary.Text = "0";
            this.lblBinary.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNumero1
            // 
            this.txtNumero1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero1.Location = new System.Drawing.Point(12, 37);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(133, 46);
            this.txtNumero1.TabIndex = 1;
            this.txtNumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumero2
            // 
            this.txtNumero2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero2.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero2.Location = new System.Drawing.Point(278, 39);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(121, 46);
            this.txtNumero2.TabIndex = 3;
            this.txtNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstOperaciones
            // 
            this.lstOperaciones.FormattingEnabled = true;
            this.lstOperaciones.ItemHeight = 15;
            this.lstOperaciones.Location = new System.Drawing.Point(405, 9);
            this.lstOperaciones.Name = "lstOperaciones";
            this.lstOperaciones.Size = new System.Drawing.Size(127, 184);
            this.lstOperaciones.TabIndex = 4;
            this.lstOperaciones.SelectedIndexChanged += new System.EventHandler(this.lstOperaciones_SelectedIndexChanged);
            // 
            // cbmOperadores
            // 
            this.cbmOperadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmOperadores.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbmOperadores.FormattingEnabled = true;
            this.cbmOperadores.Items.AddRange(new object[] {
            "",
            "+",
            "-",
            "*",
            "/"});
            this.cbmOperadores.Location = new System.Drawing.Point(165, 35);
            this.cbmOperadores.Name = "cbmOperadores";
            this.cbmOperadores.Size = new System.Drawing.Size(91, 48);
            this.cbmOperadores.TabIndex = 2;
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(12, 89);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(133, 47);
            this.btnOperar.TabIndex = 5;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(165, 91);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(91, 47);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(278, 93);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(121, 47);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConvertirBinario
            // 
            this.btnConvertirBinario.Enabled = false;
            this.btnConvertirBinario.Location = new System.Drawing.Point(12, 144);
            this.btnConvertirBinario.Name = "btnConvertirBinario";
            this.btnConvertirBinario.Size = new System.Drawing.Size(189, 47);
            this.btnConvertirBinario.TabIndex = 8;
            this.btnConvertirBinario.Text = "Convertir a Binario";
            this.btnConvertirBinario.UseVisualStyleBackColor = true;
            this.btnConvertirBinario.Click += new System.EventHandler(this.btnConvertirBinario_Click);
            // 
            // btnConvertirDecimal
            // 
            this.btnConvertirDecimal.Enabled = false;
            this.btnConvertirDecimal.Location = new System.Drawing.Point(213, 146);
            this.btnConvertirDecimal.Name = "btnConvertirDecimal";
            this.btnConvertirDecimal.Size = new System.Drawing.Size(186, 47);
            this.btnConvertirDecimal.TabIndex = 9;
            this.btnConvertirDecimal.Text = "Convertir a Decimal";
            this.btnConvertirDecimal.UseVisualStyleBackColor = true;
            this.btnConvertirDecimal.Click += new System.EventHandler(this.btnConvertirDecimal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 207);
            this.Controls.Add(this.btnConvertirDecimal);
            this.Controls.Add(this.btnConvertirBinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.cbmOperadores);
            this.Controls.Add(this.lstOperaciones);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblBinary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Regueiro Ignacio 2°A";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNumero1;
		private System.Windows.Forms.TextBox txtNumero2;
		private System.Windows.Forms.ListBox lstOperaciones;
		private System.Windows.Forms.ComboBox cbmOperadores;
		private System.Windows.Forms.Button btnOperar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnConvertirBinario;
		private System.Windows.Forms.Button btnConvertirDecimal;
        private System.Windows.Forms.Label lblBinary;
    }
}


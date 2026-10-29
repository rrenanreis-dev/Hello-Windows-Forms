namespace form
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPeso = new TextBox();
            label4 = new Label();
            txtAltura = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            lblSituacao = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(602, 60);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 30);
            label1.TabIndex = 0;
            label1.Text = "Sistema de IMC";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(526, 206);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(565, 206);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 30);
            label3.TabIndex = 2;
            label3.Text = "Peso:";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(671, 199);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 37);
            txtPeso.TabIndex = 3;
            txtPeso.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(531, 278);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 30);
            label4.TabIndex = 4;
            label4.Text = "Altura:";
            label4.Click += label4_Click;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(671, 271);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 37);
            txtAltura.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(620, 439);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(175, 68);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(526, 661);
            lblResultado.Margin = new Padding(7, 0, 7, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(157, 30);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado:";
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(526, 750);
            lblSituacao.Margin = new Padding(7, 0, 7, 0);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(135, 30);
            lblSituacao.TabIndex = 8;
            lblSituacao.Text = "Situação:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1829, 900);
            Controls.Add(lblSituacao);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(label4);
            Controls.Add(txtPeso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 6, 7, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPeso;
        private Label label4;
        private TextBox txtAltura;
        private Button btnCalcular;
        private Label lblResultado;
        private Label lblSituacao;
    }
}

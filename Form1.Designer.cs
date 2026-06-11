namespace Aula09
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBoxNome = new TextBox();
            label2 = new Label();
            textBoxCPF = new TextBox();
            label3 = new Label();
            textBoxTelefone = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(134, 170);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 0;
            button1.Text = "Conectar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(43, 170);
            button2.Name = "button2";
            button2.Size = new Size(85, 23);
            button2.TabIndex = 1;
            button2.Text = "Salvar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 35);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(45, 53);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(172, 23);
            textBoxNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 79);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "CPF:";
            label2.Click += label2_Click;
            // 
            // textBoxCPF
            // 
            textBoxCPF.Location = new Point(43, 97);
            textBoxCPF.Name = "textBoxCPF";
            textBoxCPF.Size = new Size(174, 23);
            textBoxCPF.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 123);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "Telefone:";
            label3.Click += label3_Click;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(45, 141);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(174, 23);
            textBoxTelefone.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 236);
            Controls.Add(textBoxTelefone);
            Controls.Add(label3);
            Controls.Add(textBoxCPF);
            Controls.Add(label2);
            Controls.Add(textBoxNome);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBoxNome;
        private Label label2;
        private TextBox textBoxCPF;
        private Label label3;
        private TextBox textBoxTelefone;
    }
}

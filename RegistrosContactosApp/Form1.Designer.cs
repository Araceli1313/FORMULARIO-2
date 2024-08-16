namespace RegistrosContactosApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TextBoxNombre = new TextBox();
            TextBoxTelefono = new TextBox();
            TextBoxEmail = new TextBox();
            ButtonAgregar = new Button();
            ButtonLimpiar = new Button();
            ListBoxContactos = new ListBox();
            LabelEstado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 70);
            label1.Name = "label1";
            label1.Size = new Size(78, 18);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 98);
            label2.Name = "label2";
            label2.Size = new Size(87, 18);
            label2.TabIndex = 1;
            label2.Text = "Teléfono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 128);
            label3.Name = "label3";
            label3.Size = new Size(165, 18);
            label3.TabIndex = 2;
            label3.Text = "Correo Electrónico:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(177, 19);
            label4.Name = "label4";
            label4.Size = new Size(295, 23);
            label4.TabIndex = 3;
            label4.Text = "REGISTRO DE CONTACTOS";
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Location = new Point(201, 65);
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(271, 23);
            TextBoxNombre.TabIndex = 4;
            // 
            // TextBoxTelefono
            // 
            TextBoxTelefono.Location = new Point(201, 98);
            TextBoxTelefono.Name = "TextBoxTelefono";
            TextBoxTelefono.Size = new Size(271, 23);
            TextBoxTelefono.TabIndex = 5;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(201, 127);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(271, 23);
            TextBoxEmail.TabIndex = 6;
            // 
            // ButtonAgregar
            // 
            ButtonAgregar.BackColor = SystemColors.InactiveCaption;
            ButtonAgregar.Location = new Point(518, 65);
            ButtonAgregar.Name = "ButtonAgregar";
            ButtonAgregar.Size = new Size(122, 37);
            ButtonAgregar.TabIndex = 7;
            ButtonAgregar.Text = "Agregar Contacto";
            ButtonAgregar.UseVisualStyleBackColor = false;
            ButtonAgregar.Click += ButtonAgregar_Click;
            // 
            // ButtonLimpiar
            // 
            ButtonLimpiar.BackColor = SystemColors.InactiveCaption;
            ButtonLimpiar.Location = new Point(518, 121);
            ButtonLimpiar.Name = "ButtonLimpiar";
            ButtonLimpiar.Size = new Size(122, 36);
            ButtonLimpiar.TabIndex = 8;
            ButtonLimpiar.Text = "Limpiar Campos";
            ButtonLimpiar.UseVisualStyleBackColor = false;
            ButtonLimpiar.Click += ButtonLimpiar_Click;
            // 
            // ListBoxContactos
            // 
            ListBoxContactos.FormattingEnabled = true;
            ListBoxContactos.ItemHeight = 15;
            ListBoxContactos.Location = new Point(39, 176);
            ListBoxContactos.Name = "ListBoxContactos";
            ListBoxContactos.Size = new Size(433, 169);
            ListBoxContactos.TabIndex = 9;
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelEstado.Location = new Point(497, 257);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(108, 18);
            LabelEstado.TabIndex = 10;
            LabelEstado.Text = "LabelEstado";
            LabelEstado.Click += LabelEstado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(777, 450);
            Controls.Add(LabelEstado);
            Controls.Add(ListBoxContactos);
            Controls.Add(ButtonLimpiar);
            Controls.Add(ButtonAgregar);
            Controls.Add(TextBoxEmail);
            Controls.Add(TextBoxTelefono);
            Controls.Add(TextBoxNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.TextBox TextBoxTelefono;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Button ButtonAgregar;
        private System.Windows.Forms.Button ButtonLimpiar;
        private System.Windows.Forms.ListBox ListBoxContactos;
        private System.Windows.Forms.Label LabelEstado;
    }
}
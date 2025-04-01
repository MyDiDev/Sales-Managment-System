namespace ExamenP3
{
    partial class ClientForm
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
            label1 = new Label();
            btnClient = new Button();
            label2 = new Label();
            nameClient = new TextBox();
            apellidoClient = new TextBox();
            label3 = new Label();
            correoClient = new TextBox();
            label4 = new Label();
            phoneClient = new TextBox();
            label5 = new Label();
            errorLabel = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(454, 72);
            label1.TabIndex = 2;
            label1.Text = "Registrar Cliente";
            // 
            // btnClient
            // 
            btnClient.Anchor = AnchorStyles.None;
            btnClient.BackColor = Color.DodgerBlue;
            btnClient.Cursor = Cursors.Hand;
            btnClient.FlatAppearance.BorderSize = 0;
            btnClient.FlatStyle = FlatStyle.Flat;
            btnClient.Font = new Font("Segoe UI", 9F);
            btnClient.ForeColor = Color.White;
            btnClient.Location = new Point(25, 566);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(546, 48);
            btnClient.TabIndex = 3;
            btnClient.Text = "Registrar Cliente";
            btnClient.UseVisualStyleBackColor = false;
            btnClient.Click += btnClient_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.Location = new Point(36, 139);
            label2.Name = "label2";
            label2.Size = new Size(134, 18);
            label2.TabIndex = 4;
            label2.Text = "Nombre del Cliente";
            // 
            // nameClient
            // 
            nameClient.Location = new Point(36, 173);
            nameClient.Name = "nameClient";
            nameClient.Size = new Size(521, 27);
            nameClient.TabIndex = 5;
            // 
            // apellidoClient
            // 
            apellidoClient.Location = new Point(36, 271);
            apellidoClient.Name = "apellidoClient";
            apellidoClient.Size = new Size(521, 27);
            apellidoClient.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(36, 237);
            label3.Name = "label3";
            label3.Size = new Size(131, 18);
            label3.TabIndex = 6;
            label3.Text = "Apellido del Cliente";
            // 
            // correoClient
            // 
            correoClient.Location = new Point(36, 372);
            correoClient.Name = "correoClient";
            correoClient.Size = new Size(521, 27);
            correoClient.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.Location = new Point(36, 338);
            label4.Name = "label4";
            label4.Size = new Size(127, 18);
            label4.TabIndex = 8;
            label4.Text = "Correo del Cliente";
            // 
            // phoneClient
            // 
            phoneClient.Location = new Point(36, 474);
            phoneClient.Name = "phoneClient";
            phoneClient.Size = new Size(521, 27);
            phoneClient.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F);
            label5.Location = new Point(36, 440);
            label5.Name = "label5";
            label5.Size = new Size(138, 18);
            label5.TabIndex = 10;
            label5.Text = "Telefono del Cliente";
            // 
            // errorLabel
            // 
            errorLabel.Font = new Font("Microsoft Sans Serif", 9F);
            errorLabel.LinkColor = Color.Red;
            errorLabel.Location = new Point(25, 527);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(532, 25);
            errorLabel.TabIndex = 12;
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 626);
            Controls.Add(errorLabel);
            Controls.Add(phoneClient);
            Controls.Add(label5);
            Controls.Add(correoClient);
            Controls.Add(label4);
            Controls.Add(apellidoClient);
            Controls.Add(label3);
            Controls.Add(nameClient);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClient);
            Name = "ClientForm";
            Text = "VentasForm";
            FormClosing += ClienForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnClient;
        private Label label2;
        private TextBox nameClient;
        private TextBox apellidoClient;
        private Label label3;
        private TextBox correoClient;
        private Label label4;
        private TextBox phoneClient;
        private Label label5;
        private LinkLabel errorLabel;
    }
}
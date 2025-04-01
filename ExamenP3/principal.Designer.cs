namespace ExamenP3
{
    partial class principal
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
            btnClient = new Button();
            btnVentas = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(74, 80);
            label1.Name = "label1";
            label1.Size = new Size(231, 72);
            label1.TabIndex = 0;
            label1.Text = "Sistema";
            // 
            // btnClient
            // 
            btnClient.Anchor = AnchorStyles.None;
            btnClient.BackColor = Color.DodgerBlue;
            btnClient.Cursor = Cursors.Hand;
            btnClient.FlatAppearance.BorderSize = 0;
            btnClient.FlatStyle = FlatStyle.Flat;
            btnClient.Font = new Font("Segoe UI", 12F);
            btnClient.ForeColor = Color.White;
            btnClient.Location = new Point(83, 202);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(401, 71);
            btnClient.TabIndex = 1;
            btnClient.Text = "Registrar Cliente";
            btnClient.UseVisualStyleBackColor = false;
            btnClient.Click += btnClient_Click;
            // 
            // btnVentas
            // 
            btnVentas.Anchor = AnchorStyles.None;
            btnVentas.BackColor = Color.DodgerBlue;
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 12F);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(83, 321);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(401, 71);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Registrar Venta";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnClient);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 488);
            panel1.TabIndex = 3;
            // 
            // principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(564, 488);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            FormClosing += principalform_closing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnClient;
        private Button btnVentas;
        private Panel panel1;
    }
}

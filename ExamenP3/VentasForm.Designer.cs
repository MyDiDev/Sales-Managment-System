namespace ExamenP3
{
    partial class VentasForm
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
            label2 = new Label();
            label1 = new Label();
            btnVenta = new Button();
            label3 = new Label();
            precioTotal = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            cantProductoVendidos = new NumericUpDown();
            metodoPago = new ComboBox();
            estadoPago = new ComboBox();
            fechaEntrega = new DateTimePicker();
            fechaRetiro = new DateTimePicker();
            ventaFecha = new DateTimePicker();
            errorLabel = new LinkLabel();
            nameClient = new ComboBox();
            apellidoClient = new ComboBox();
            cantProductos = new NumericUpDown();
            label12 = new Label();
            docRespaldo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)cantProductoVendidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cantProductos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.Location = new Point(36, 105);
            label2.Name = "label2";
            label2.Size = new Size(134, 18);
            label2.TabIndex = 8;
            label2.Text = "Nombre del Cliente";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(418, 72);
            label1.TabIndex = 6;
            label1.Text = "Registrar Venta";
            // 
            // btnVenta
            // 
            btnVenta.Anchor = AnchorStyles.None;
            btnVenta.BackColor = Color.DodgerBlue;
            btnVenta.Cursor = Cursors.Hand;
            btnVenta.FlatAppearance.BorderSize = 0;
            btnVenta.FlatStyle = FlatStyle.Flat;
            btnVenta.Font = new Font("Segoe UI", 9F);
            btnVenta.ForeColor = Color.White;
            btnVenta.Location = new Point(36, 761);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(661, 48);
            btnVenta.TabIndex = 7;
            btnVenta.Text = "Registrar Venta";
            btnVenta.UseVisualStyleBackColor = false;
            btnVenta.Click += btnVenta_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.Location = new Point(36, 208);
            label3.Name = "label3";
            label3.Size = new Size(125, 18);
            label3.TabIndex = 10;
            label3.Text = "Fecha de la Venta";
            // 
            // precioTotal
            // 
            precioTotal.Location = new Point(36, 446);
            precioTotal.Name = "precioTotal";
            precioTotal.Size = new Size(308, 27);
            precioTotal.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.Location = new Point(36, 412);
            label4.Name = "label4";
            label4.Size = new Size(88, 18);
            label4.TabIndex = 12;
            label4.Text = "Precio Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F);
            label5.Location = new Point(389, 312);
            label5.Name = "label5";
            label5.Size = new Size(118, 18);
            label5.TabIndex = 18;
            label5.Text = "Metodo de Pago";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F);
            label6.Location = new Point(389, 208);
            label6.Name = "label6";
            label6.Size = new Size(224, 18);
            label6.TabIndex = 16;
            label6.Text = "Cantidad de Productos Vendidos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F);
            label7.Location = new Point(389, 105);
            label7.Name = "label7";
            label7.Size = new Size(131, 18);
            label7.TabIndex = 14;
            label7.Text = "Apellido del Cliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F);
            label8.Location = new Point(36, 606);
            label8.Name = "label8";
            label8.Size = new Size(124, 18);
            label8.TabIndex = 24;
            label8.Text = "Fecha de Entrega";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F);
            label9.Location = new Point(389, 412);
            label9.Name = "label9";
            label9.Size = new Size(173, 18);
            label9.TabIndex = 22;
            label9.Text = "Documento de Respaldo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F);
            label10.Location = new Point(36, 512);
            label10.Name = "label10";
            label10.Size = new Size(114, 18);
            label10.TabIndex = 20;
            label10.Text = "Estado de Pago";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F);
            label11.Location = new Point(389, 506);
            label11.Name = "label11";
            label11.Size = new Size(93, 18);
            label11.TabIndex = 26;
            label11.Text = "Fecha Retiro";
            // 
            // cantProductoVendidos
            // 
            cantProductoVendidos.Location = new Point(389, 242);
            cantProductoVendidos.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            cantProductoVendidos.Name = "cantProductoVendidos";
            cantProductoVendidos.Size = new Size(308, 27);
            cantProductoVendidos.TabIndex = 29;
            // 
            // metodoPago
            // 
            metodoPago.FormattingEnabled = true;
            metodoPago.Items.AddRange(new object[] { "Tarjeta", "Efectivo", "Transferencia" });
            metodoPago.Location = new Point(389, 346);
            metodoPago.Name = "metodoPago";
            metodoPago.Size = new Size(308, 28);
            metodoPago.TabIndex = 30;
            // 
            // estadoPago
            // 
            estadoPago.FormattingEnabled = true;
            estadoPago.Items.AddRange(new object[] { "pagado", "pendiente", "cancelado" });
            estadoPago.Location = new Point(36, 546);
            estadoPago.Name = "estadoPago";
            estadoPago.Size = new Size(308, 28);
            estadoPago.TabIndex = 31;
            // 
            // fechaEntrega
            // 
            fechaEntrega.Location = new Point(36, 640);
            fechaEntrega.Name = "fechaEntrega";
            fechaEntrega.Size = new Size(308, 27);
            fechaEntrega.TabIndex = 32;
            // 
            // fechaRetiro
            // 
            fechaRetiro.Location = new Point(389, 540);
            fechaRetiro.Name = "fechaRetiro";
            fechaRetiro.Size = new Size(308, 27);
            fechaRetiro.TabIndex = 33;
            // 
            // ventaFecha
            // 
            ventaFecha.Location = new Point(36, 242);
            ventaFecha.Name = "ventaFecha";
            ventaFecha.Size = new Size(308, 27);
            ventaFecha.TabIndex = 34;
            // 
            // errorLabel
            // 
            errorLabel.Font = new Font("Microsoft Sans Serif", 9F);
            errorLabel.LinkColor = Color.Red;
            errorLabel.Location = new Point(36, 717);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(661, 25);
            errorLabel.TabIndex = 35;
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameClient
            // 
            nameClient.FormattingEnabled = true;
            nameClient.Location = new Point(36, 139);
            nameClient.Name = "nameClient";
            nameClient.Size = new Size(308, 28);
            nameClient.TabIndex = 36;
            // 
            // apellidoClient
            // 
            apellidoClient.FormattingEnabled = true;
            apellidoClient.Location = new Point(389, 139);
            apellidoClient.Name = "apellidoClient";
            apellidoClient.Size = new Size(308, 28);
            apellidoClient.TabIndex = 37;
            // 
            // cantProductos
            // 
            cantProductos.Location = new Point(36, 346);
            cantProductos.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            cantProductos.Name = "cantProductos";
            cantProductos.Size = new Size(308, 27);
            cantProductos.TabIndex = 39;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9F);
            label12.Location = new Point(36, 312);
            label12.Name = "label12";
            label12.Size = new Size(159, 18);
            label12.TabIndex = 38;
            label12.Text = "Cantidad de Productos";
            // 
            // docRespaldo
            // 
            docRespaldo.FormattingEnabled = true;
            docRespaldo.Items.AddRange(new object[] { "Factura", "Nota de Venta" });
            docRespaldo.Location = new Point(389, 445);
            docRespaldo.Name = "docRespaldo";
            docRespaldo.Size = new Size(308, 28);
            docRespaldo.TabIndex = 40;
            // 
            // VentasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 821);
            Controls.Add(docRespaldo);
            Controls.Add(cantProductos);
            Controls.Add(label12);
            Controls.Add(apellidoClient);
            Controls.Add(nameClient);
            Controls.Add(errorLabel);
            Controls.Add(ventaFecha);
            Controls.Add(fechaRetiro);
            Controls.Add(fechaEntrega);
            Controls.Add(estadoPago);
            Controls.Add(metodoPago);
            Controls.Add(cantProductoVendidos);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(precioTotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVenta);
            Name = "VentasForm";
            Text = "ClientForm";
            FormClosing += VentasForm_FormClosing;
            Load += VentasForm_Load;
            ((System.ComponentModel.ISupportInitialize)cantProductoVendidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)cantProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button btnVenta;
        private TextBox fechaVenta;
        private Label label3;
        private TextBox precioTotal;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private NumericUpDown cantProductoVendidos;
        private ComboBox metodoPago;
        private ComboBox estadoPago;
        private DateTimePicker fechaEntrega;
        private DateTimePicker fechaRetiro;
        private DateTimePicker ventaFecha;
        private LinkLabel errorLabel;
        private ComboBox nameClient;
        private ComboBox apellidoClient;
        private NumericUpDown cantProductos;
        private Label label12;
        private ComboBox docRespaldo;
    }
}
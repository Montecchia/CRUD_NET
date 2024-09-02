namespace CRUD_SQL
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
            labelCodigo = new Label();
            labelNombre = new Label();
            labelTelefono = new Label();
            labelCorreo = new Label();
            labelSucursal = new Label();
            boxCliente = new GroupBox();
            labelTest = new Label();
            comboSucursal = new ComboBox();
            buttonModificar = new Button();
            buttonGuardar = new Button();
            buttonEliminar = new Button();
            textCorreo = new TextBox();
            textTelefono = new TextBox();
            textNombre = new TextBox();
            textCodigo = new TextBox();
            gridClientes = new DataGridView();
            gridSucursales = new DataGridView();
            boxCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridSucursales).BeginInit();
            SuspendLayout();
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Location = new Point(6, 25);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(46, 15);
            labelCodigo.TabIndex = 0;
            labelCodigo.Text = "Código";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(6, 54);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(6, 83);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(52, 15);
            labelTelefono.TabIndex = 2;
            labelTelefono.Text = "Teléfono";
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(6, 112);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(43, 15);
            labelCorreo.TabIndex = 3;
            labelCorreo.Text = "Correo";
            // 
            // labelSucursal
            // 
            labelSucursal.AutoSize = true;
            labelSucursal.Location = new Point(6, 141);
            labelSucursal.Name = "labelSucursal";
            labelSucursal.Size = new Size(51, 15);
            labelSucursal.TabIndex = 4;
            labelSucursal.Text = "Sucursal";
            // 
            // boxCliente
            // 
            boxCliente.Controls.Add(labelTest);
            boxCliente.Controls.Add(comboSucursal);
            boxCliente.Controls.Add(buttonModificar);
            boxCliente.Controls.Add(buttonGuardar);
            boxCliente.Controls.Add(buttonEliminar);
            boxCliente.Controls.Add(textCorreo);
            boxCliente.Controls.Add(textTelefono);
            boxCliente.Controls.Add(textNombre);
            boxCliente.Controls.Add(textCodigo);
            boxCliente.Controls.Add(labelCodigo);
            boxCliente.Controls.Add(labelSucursal);
            boxCliente.Controls.Add(labelNombre);
            boxCliente.Controls.Add(labelCorreo);
            boxCliente.Controls.Add(labelTelefono);
            boxCliente.Location = new Point(12, 12);
            boxCliente.Name = "boxCliente";
            boxCliente.Size = new Size(427, 226);
            boxCliente.TabIndex = 5;
            boxCliente.TabStop = false;
            boxCliente.Text = "Datos del cliente";
            // 
            // labelTest
            // 
            labelTest.AutoSize = true;
            labelTest.Location = new Point(23, 190);
            labelTest.Name = "labelTest";
            labelTest.Size = new Size(26, 15);
            labelTest.TabIndex = 14;
            labelTest.Text = "test";
            // 
            // comboSucursal
            // 
            comboSucursal.FormattingEnabled = true;
            comboSucursal.Location = new Point(77, 138);
            comboSucursal.Name = "comboSucursal";
            comboSucursal.Size = new Size(344, 23);
            comboSucursal.TabIndex = 13;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(346, 186);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(75, 23);
            buttonModificar.TabIndex = 12;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(265, 186);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 11;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(184, 186);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 10;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // textCorreo
            // 
            textCorreo.Location = new Point(77, 109);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(344, 23);
            textCorreo.TabIndex = 8;
            textCorreo.TextAlign = HorizontalAlignment.Right;
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(77, 80);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(344, 23);
            textTelefono.TabIndex = 7;
            textTelefono.TextAlign = HorizontalAlignment.Right;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(77, 51);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(344, 23);
            textNombre.TabIndex = 6;
            textNombre.TextAlign = HorizontalAlignment.Right;
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(77, 22);
            textCodigo.Name = "textCodigo";
            textCodigo.ReadOnly = true;
            textCodigo.Size = new Size(344, 23);
            textCodigo.TabIndex = 5;
            textCodigo.TextAlign = HorizontalAlignment.Right;
            // 
            // gridClientes
            // 
            gridClientes.AllowUserToAddRows = false;
            gridClientes.AllowUserToDeleteRows = false;
            gridClientes.AllowUserToResizeRows = false;
            gridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Location = new Point(12, 244);
            gridClientes.Name = "gridClientes";
            gridClientes.RowTemplate.Height = 25;
            gridClientes.ShowEditingIcon = false;
            gridClientes.Size = new Size(776, 194);
            gridClientes.TabIndex = 6;
            gridClientes.SelectionChanged += gridClientes_SelectionChanged;
            // 
            // gridSucursales
            // 
            gridSucursales.AllowUserToAddRows = false;
            gridSucursales.AllowUserToDeleteRows = false;
            gridSucursales.AllowUserToResizeRows = false;
            gridSucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridSucursales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSucursales.Location = new Point(445, 18);
            gridSucursales.MultiSelect = false;
            gridSucursales.Name = "gridSucursales";
            gridSucursales.RowTemplate.Height = 25;
            gridSucursales.ShowEditingIcon = false;
            gridSucursales.Size = new Size(343, 220);
            gridSucursales.TabIndex = 7;
            gridSucursales.CellClick += gridSucursales_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridSucursales);
            Controls.Add(gridClientes);
            Controls.Add(boxCliente);
            Name = "Form1";
            Text = "Clientes DB";
            boxCliente.ResumeLayout(false);
            boxCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridSucursales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelCodigo;
        private Label labelNombre;
        private Label labelTelefono;
        private Label labelCorreo;
        private Label labelSucursal;
        private GroupBox boxCliente;
        private TextBox textCorreo;
        private TextBox textTelefono;
        private TextBox textNombre;
        private TextBox textCodigo;
        private Button buttonModificar;
        private Button buttonGuardar;
        private Button buttonEliminar;
        private ComboBox comboSucursal;
        private DataGridView gridClientes;
        private DataGridView gridSucursales;
        private Label labelTest;
    }
}
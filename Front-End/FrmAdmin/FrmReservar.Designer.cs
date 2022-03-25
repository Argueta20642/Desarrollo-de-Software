
namespace Hotel5taReal.Front_End.FrmAdmin
{
    partial class FrmReservar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cod_ReservasLabel;
            System.Windows.Forms.Label nombreClienteLabel;
            System.Windows.Forms.Label apellidoClienteLabel;
            System.Windows.Forms.Label dNILabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label numerodeHabitacionLabel;
            System.Windows.Forms.Label fechaIngresoLabel;
            System.Windows.Forms.Label fechaSalidaLabel;
            System.Windows.Forms.Label moraLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReservar));
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.bntNuevo = new System.Windows.Forms.Button();
            this.hotel5taRealDataSet = new Hotel5taReal.Hotel5taRealDataSet();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservaTableAdapter = new Hotel5taReal.Hotel5taRealDataSetTableAdapters.ReservaTableAdapter();
            this.tableAdapterManager = new Hotel5taReal.Hotel5taRealDataSetTableAdapters.TableAdapterManager();
            this.reservaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_ReservasTextBox = new System.Windows.Forms.TextBox();
            this.nombreClienteTextBox = new System.Windows.Forms.TextBox();
            this.apellidoClienteTextBox = new System.Windows.Forms.TextBox();
            this.dNITextBox = new System.Windows.Forms.TextBox();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.paisTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.numerodeHabitacionTextBox = new System.Windows.Forms.TextBox();
            this.fechaIngresoTextBox = new System.Windows.Forms.TextBox();
            this.fechaSalidaTextBox = new System.Windows.Forms.TextBox();
            this.moraTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            cod_ReservasLabel = new System.Windows.Forms.Label();
            nombreClienteLabel = new System.Windows.Forms.Label();
            apellidoClienteLabel = new System.Windows.Forms.Label();
            dNILabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            numerodeHabitacionLabel = new System.Windows.Forms.Label();
            fechaIngresoLabel = new System.Windows.Forms.Label();
            fechaSalidaLabel = new System.Windows.Forms.Label();
            moraLabel = new System.Windows.Forms.Label();
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotel5taRealDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_ReservasLabel
            // 
            cod_ReservasLabel.AutoSize = true;
            cod_ReservasLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_ReservasLabel.Location = new System.Drawing.Point(29, 99);
            cod_ReservasLabel.Name = "cod_ReservasLabel";
            cod_ReservasLabel.Size = new System.Drawing.Size(73, 20);
            cod_ReservasLabel.TabIndex = 32;
            cod_ReservasLabel.Text = "Cod Reservas:";
            // 
            // nombreClienteLabel
            // 
            nombreClienteLabel.AutoSize = true;
            nombreClienteLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreClienteLabel.Location = new System.Drawing.Point(195, 102);
            nombreClienteLabel.Name = "nombreClienteLabel";
            nombreClienteLabel.Size = new System.Drawing.Size(77, 20);
            nombreClienteLabel.TabIndex = 33;
            nombreClienteLabel.Text = "Nombre Cliente:";
            // 
            // apellidoClienteLabel
            // 
            apellidoClienteLabel.AutoSize = true;
            apellidoClienteLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoClienteLabel.Location = new System.Drawing.Point(423, 102);
            apellidoClienteLabel.Name = "apellidoClienteLabel";
            apellidoClienteLabel.Size = new System.Drawing.Size(75, 20);
            apellidoClienteLabel.TabIndex = 34;
            apellidoClienteLabel.Text = "Apellido Cliente:";
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dNILabel.Location = new System.Drawing.Point(636, 102);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(26, 20);
            dNILabel.TabIndex = 35;
            dNILabel.Text = "DNI:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciudadLabel.Location = new System.Drawing.Point(30, 165);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(40, 20);
            ciudadLabel.TabIndex = 36;
            ciudadLabel.Text = "Ciudad:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paisLabel.Location = new System.Drawing.Point(210, 165);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(30, 20);
            paisLabel.TabIndex = 37;
            paisLabel.Text = "Pais:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioLabel.Location = new System.Drawing.Point(158, 226);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 20);
            precioLabel.TabIndex = 38;
            precioLabel.Text = "Precio:";
            // 
            // numerodeHabitacionLabel
            // 
            numerodeHabitacionLabel.AutoSize = true;
            numerodeHabitacionLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numerodeHabitacionLabel.Location = new System.Drawing.Point(362, 165);
            numerodeHabitacionLabel.Name = "numerodeHabitacionLabel";
            numerodeHabitacionLabel.Size = new System.Drawing.Size(102, 20);
            numerodeHabitacionLabel.TabIndex = 39;
            numerodeHabitacionLabel.Text = "Numerode Habitacion:";
            // 
            // fechaIngresoLabel
            // 
            fechaIngresoLabel.AutoSize = true;
            fechaIngresoLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaIngresoLabel.Location = new System.Drawing.Point(578, 168);
            fechaIngresoLabel.Name = "fechaIngresoLabel";
            fechaIngresoLabel.Size = new System.Drawing.Size(71, 20);
            fechaIngresoLabel.TabIndex = 40;
            fechaIngresoLabel.Text = "Fecha Ingreso:";
            // 
            // fechaSalidaLabel
            // 
            fechaSalidaLabel.AutoSize = true;
            fechaSalidaLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaSalidaLabel.Location = new System.Drawing.Point(330, 226);
            fechaSalidaLabel.Name = "fechaSalidaLabel";
            fechaSalidaLabel.Size = new System.Drawing.Size(64, 20);
            fechaSalidaLabel.TabIndex = 41;
            fechaSalidaLabel.Text = "Fecha Salida:";
            // 
            // moraLabel
            // 
            moraLabel.AutoSize = true;
            moraLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            moraLabel.Location = new System.Drawing.Point(542, 226);
            moraLabel.Name = "moraLabel";
            moraLabel.Size = new System.Drawing.Size(35, 20);
            moraLabel.TabIndex = 42;
            moraLabel.Text = "mora:";
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pnlBarra.Controls.Add(this.label1);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(794, 45);
            this.pnlBarra.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(347, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESERVAR";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(294, 281);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 51);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(375, 281);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 51);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // bntNuevo
            // 
            this.bntNuevo.BackColor = System.Drawing.Color.Transparent;
            this.bntNuevo.FlatAppearance.BorderSize = 0;
            this.bntNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.bntNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.bntNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntNuevo.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntNuevo.ForeColor = System.Drawing.Color.White;
            this.bntNuevo.Location = new System.Drawing.Point(467, 281);
            this.bntNuevo.Name = "bntNuevo";
            this.bntNuevo.Size = new System.Drawing.Size(75, 51);
            this.bntNuevo.TabIndex = 31;
            this.bntNuevo.Text = "NUEVO";
            this.bntNuevo.UseVisualStyleBackColor = false;
            this.bntNuevo.Click += new System.EventHandler(this.bntNuevo_Click);
            // 
            // hotel5taRealDataSet
            // 
            this.hotel5taRealDataSet.DataSetName = "Hotel5taRealDataSet";
            this.hotel5taRealDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataMember = "Reserva";
            this.reservaBindingSource.DataSource = this.hotel5taRealDataSet;
            // 
            // reservaTableAdapter
            // 
            this.reservaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.facturasTableAdapter = null;
            this.tableAdapterManager.HabitacionesTableAdapter = null;
            this.tableAdapterManager.OrdenItemsTableAdapter = null;
            this.tableAdapterManager.OrdenTableAdapter = null;
            this.tableAdapterManager.PlanillaTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ReservaTableAdapter = this.reservaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Hotel5taReal.Hotel5taRealDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // reservaDataGridView
            // 
            this.reservaDataGridView.AllowUserToAddRows = false;
            this.reservaDataGridView.AllowUserToDeleteRows = false;
            this.reservaDataGridView.AutoGenerateColumns = false;
            this.reservaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.reservaDataGridView.DataSource = this.reservaBindingSource;
            this.reservaDataGridView.Location = new System.Drawing.Point(43, 355);
            this.reservaDataGridView.Name = "reservaDataGridView";
            this.reservaDataGridView.ReadOnly = true;
            this.reservaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reservaDataGridView.Size = new System.Drawing.Size(730, 220);
            this.reservaDataGridView.TabIndex = 32;
            this.reservaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservaDataGridView_CellClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_Reservas";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cod_Reservas";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreCliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombreCliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ApellidoCliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "ApellidoCliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DNI";
            this.dataGridViewTextBoxColumn4.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ciudad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ciudad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Pais";
            this.dataGridViewTextBoxColumn6.HeaderText = "Pais";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn7.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NumerodeHabitacion";
            this.dataGridViewTextBoxColumn8.HeaderText = "NumerodeHabitacion";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FechaIngreso";
            this.dataGridViewTextBoxColumn9.HeaderText = "FechaIngreso";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FechaSalida";
            this.dataGridViewTextBoxColumn10.HeaderText = "FechaSalida";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "mora";
            this.dataGridViewTextBoxColumn11.HeaderText = "mora";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // cod_ReservasTextBox
            // 
            this.cod_ReservasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Cod_Reservas", true));
            this.cod_ReservasTextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_ReservasTextBox.Location = new System.Drawing.Point(112, 96);
            this.cod_ReservasTextBox.MaxLength = 2;
            this.cod_ReservasTextBox.Name = "cod_ReservasTextBox";
            this.cod_ReservasTextBox.Size = new System.Drawing.Size(51, 26);
            this.cod_ReservasTextBox.TabIndex = 33;
            this.cod_ReservasTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cod_ReservasTextBox_KeyPress);
            // 
            // nombreClienteTextBox
            // 
            this.nombreClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "NombreCliente", true));
            this.nombreClienteTextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreClienteTextBox.Location = new System.Drawing.Point(283, 99);
            this.nombreClienteTextBox.MaxLength = 10;
            this.nombreClienteTextBox.Name = "nombreClienteTextBox";
            this.nombreClienteTextBox.Size = new System.Drawing.Size(113, 26);
            this.nombreClienteTextBox.TabIndex = 34;
            this.nombreClienteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreClienteTextBox_KeyPress);
            // 
            // apellidoClienteTextBox
            // 
            this.apellidoClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "ApellidoCliente", true));
            this.apellidoClienteTextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoClienteTextBox.Location = new System.Drawing.Point(511, 99);
            this.apellidoClienteTextBox.MaxLength = 10;
            this.apellidoClienteTextBox.Name = "apellidoClienteTextBox";
            this.apellidoClienteTextBox.Size = new System.Drawing.Size(100, 26);
            this.apellidoClienteTextBox.TabIndex = 35;
            this.apellidoClienteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellidoClienteTextBox_KeyPress);
            // 
            // dNITextBox
            // 
            this.dNITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "DNI", true));
            this.dNITextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dNITextBox.Location = new System.Drawing.Point(671, 99);
            this.dNITextBox.MaxLength = 13;
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.Size = new System.Drawing.Size(100, 26);
            this.dNITextBox.TabIndex = 36;
            this.dNITextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dNITextBox_KeyPress);
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Ciudad", true));
            this.ciudadTextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudadTextBox.Location = new System.Drawing.Point(79, 162);
            this.ciudadTextBox.MaxLength = 10;
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(100, 26);
            this.ciudadTextBox.TabIndex = 37;
            this.ciudadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ciudadTextBox_KeyPress);
            // 
            // paisTextBox
            // 
            this.paisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Pais", true));
            this.paisTextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paisTextBox.Location = new System.Drawing.Point(246, 162);
            this.paisTextBox.MaxLength = 10;
            this.paisTextBox.Name = "paisTextBox";
            this.paisTextBox.Size = new System.Drawing.Size(100, 26);
            this.paisTextBox.TabIndex = 38;
            this.paisTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paisTextBox_KeyPress);
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "Precio", true));
            this.precioTextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTextBox.Location = new System.Drawing.Point(204, 223);
            this.precioTextBox.MaxLength = 9;
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(100, 26);
            this.precioTextBox.TabIndex = 39;
            this.precioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioTextBox_KeyPress);
            // 
            // numerodeHabitacionTextBox
            // 
            this.numerodeHabitacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "NumerodeHabitacion", true));
            this.numerodeHabitacionTextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerodeHabitacionTextBox.Location = new System.Drawing.Point(481, 162);
            this.numerodeHabitacionTextBox.MaxLength = 2;
            this.numerodeHabitacionTextBox.Name = "numerodeHabitacionTextBox";
            this.numerodeHabitacionTextBox.Size = new System.Drawing.Size(50, 26);
            this.numerodeHabitacionTextBox.TabIndex = 40;
            this.numerodeHabitacionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numerodeHabitacionTextBox_KeyPress);
            // 
            // fechaIngresoTextBox
            // 
            this.fechaIngresoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "FechaIngreso", true));
            this.fechaIngresoTextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaIngresoTextBox.Location = new System.Drawing.Point(662, 165);
            this.fechaIngresoTextBox.MaxLength = 8;
            this.fechaIngresoTextBox.Name = "fechaIngresoTextBox";
            this.fechaIngresoTextBox.Size = new System.Drawing.Size(100, 26);
            this.fechaIngresoTextBox.TabIndex = 41;
            // 
            // fechaSalidaTextBox
            // 
            this.fechaSalidaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "FechaSalida", true));
            this.fechaSalidaTextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaSalidaTextBox.Location = new System.Drawing.Point(408, 223);
            this.fechaSalidaTextBox.MaxLength = 8;
            this.fechaSalidaTextBox.Name = "fechaSalidaTextBox";
            this.fechaSalidaTextBox.Size = new System.Drawing.Size(100, 26);
            this.fechaSalidaTextBox.TabIndex = 42;
            // 
            // moraTextBox
            // 
            this.moraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservaBindingSource, "mora", true));
            this.moraTextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moraTextBox.Location = new System.Drawing.Point(581, 223);
            this.moraTextBox.MaxLength = 3;
            this.moraTextBox.Name = "moraTextBox";
            this.moraTextBox.Size = new System.Drawing.Size(100, 26);
            this.moraTextBox.TabIndex = 43;
            this.moraTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.moraTextBox_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmReservar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(794, 689);
            this.Controls.Add(moraLabel);
            this.Controls.Add(this.moraTextBox);
            this.Controls.Add(fechaSalidaLabel);
            this.Controls.Add(this.fechaSalidaTextBox);
            this.Controls.Add(fechaIngresoLabel);
            this.Controls.Add(this.fechaIngresoTextBox);
            this.Controls.Add(numerodeHabitacionLabel);
            this.Controls.Add(this.numerodeHabitacionTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(paisLabel);
            this.Controls.Add(this.paisTextBox);
            this.Controls.Add(ciudadLabel);
            this.Controls.Add(this.ciudadTextBox);
            this.Controls.Add(dNILabel);
            this.Controls.Add(this.dNITextBox);
            this.Controls.Add(apellidoClienteLabel);
            this.Controls.Add(this.apellidoClienteTextBox);
            this.Controls.Add(nombreClienteLabel);
            this.Controls.Add(this.nombreClienteTextBox);
            this.Controls.Add(cod_ReservasLabel);
            this.Controls.Add(this.cod_ReservasTextBox);
            this.Controls.Add(this.reservaDataGridView);
            this.Controls.Add(this.bntNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pnlBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReservar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReservar";
            this.Load += new System.EventHandler(this.FrmReservar_Load);
            this.pnlBarra.ResumeLayout(false);
            this.pnlBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotel5taRealDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn idRecepcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHabitacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalidaConfirmacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adelantoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioRestanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPagadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoPenalidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button bntNuevo;
        private Hotel5taRealDataSet hotel5taRealDataSet;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private Hotel5taRealDataSetTableAdapters.ReservaTableAdapter reservaTableAdapter;
        private Hotel5taRealDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView reservaDataGridView;
        private System.Windows.Forms.TextBox cod_ReservasTextBox;
        private System.Windows.Forms.TextBox nombreClienteTextBox;
        private System.Windows.Forms.TextBox apellidoClienteTextBox;
        private System.Windows.Forms.TextBox dNITextBox;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox paisTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox numerodeHabitacionTextBox;
        private System.Windows.Forms.TextBox fechaIngresoTextBox;
        private System.Windows.Forms.TextBox fechaSalidaTextBox;
        private System.Windows.Forms.TextBox moraTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
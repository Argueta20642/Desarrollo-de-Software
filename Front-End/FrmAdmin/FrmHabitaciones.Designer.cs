
namespace Hotel5taReal.Front_End.FrmAdmin
{
    partial class FrmHabitaciones
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
            System.Windows.Forms.Label cod_HabitacionesLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHabitaciones));
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bntNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.hotel5taRealDataSet = new Hotel5taReal.Hotel5taRealDataSet();
            this.habitacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.habitacionesTableAdapter = new Hotel5taReal.Hotel5taRealDataSetTableAdapters.HabitacionesTableAdapter();
            this.tableAdapterManager = new Hotel5taReal.Hotel5taRealDataSetTableAdapters.TableAdapterManager();
            this.cod_HabitacionesTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.habitacionesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            cod_HabitacionesLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotel5taRealDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_HabitacionesLabel
            // 
            cod_HabitacionesLabel.AutoSize = true;
            cod_HabitacionesLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_HabitacionesLabel.Location = new System.Drawing.Point(66, 83);
            cod_HabitacionesLabel.Name = "cod_HabitacionesLabel";
            cod_HabitacionesLabel.Size = new System.Drawing.Size(99, 20);
            cod_HabitacionesLabel.TabIndex = 37;
            cod_HabitacionesLabel.Text = "Cod Habitaciones:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombresLabel.Location = new System.Drawing.Point(108, 118);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(58, 20);
            nombresLabel.TabIndex = 38;
            nombresLabel.Text = "Nombres:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioLabel.Location = new System.Drawing.Point(120, 158);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(46, 20);
            precioLabel.TabIndex = 39;
            precioLabel.Text = "Precio:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoLabel.Location = new System.Drawing.Point(117, 200);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(45, 20);
            estadoLabel.TabIndex = 40;
            estadoLabel.Text = "Estado:";
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pnlBarra.Controls.Add(this.label1);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(771, 45);
            this.pnlBarra.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(308, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "HABITACIONES";
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
            this.bntNuevo.Location = new System.Drawing.Point(599, 135);
            this.bntNuevo.Name = "bntNuevo";
            this.bntNuevo.Size = new System.Drawing.Size(75, 51);
            this.bntNuevo.TabIndex = 34;
            this.bntNuevo.Text = "NUEVO";
            this.bntNuevo.UseVisualStyleBackColor = false;
            this.bntNuevo.Click += new System.EventHandler(this.bntNuevo_Click);
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
            this.btnModificar.Location = new System.Drawing.Point(507, 135);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 51);
            this.btnModificar.TabIndex = 33;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.btnAgregar.Location = new System.Drawing.Point(426, 135);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 51);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // hotel5taRealDataSet
            // 
            this.hotel5taRealDataSet.DataSetName = "Hotel5taRealDataSet";
            this.hotel5taRealDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // habitacionesBindingSource
            // 
            this.habitacionesBindingSource.DataMember = "Habitaciones";
            this.habitacionesBindingSource.DataSource = this.hotel5taRealDataSet;
            // 
            // habitacionesTableAdapter
            // 
            this.habitacionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.facturasTableAdapter = null;
            this.tableAdapterManager.HabitacionesTableAdapter = this.habitacionesTableAdapter;
            this.tableAdapterManager.OrdenItemsTableAdapter = null;
            this.tableAdapterManager.OrdenTableAdapter = null;
            this.tableAdapterManager.PlanillaTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ReservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hotel5taReal.Hotel5taRealDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // cod_HabitacionesTextBox
            // 
            this.cod_HabitacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionesBindingSource, "Cod_Habitaciones", true));
            this.cod_HabitacionesTextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_HabitacionesTextBox.Location = new System.Drawing.Point(166, 80);
            this.cod_HabitacionesTextBox.MaxLength = 2;
            this.cod_HabitacionesTextBox.Name = "cod_HabitacionesTextBox";
            this.cod_HabitacionesTextBox.Size = new System.Drawing.Size(100, 27);
            this.cod_HabitacionesTextBox.TabIndex = 38;
            this.cod_HabitacionesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cod_HabitacionesTextBox_KeyPress);
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionesBindingSource, "Nombres", true));
            this.nombresTextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombresTextBox.Location = new System.Drawing.Point(166, 115);
            this.nombresTextBox.MaxLength = 10;
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(100, 27);
            this.nombresTextBox.TabIndex = 39;
            this.nombresTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombresTextBox_KeyPress);
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionesBindingSource, "Precio", true));
            this.precioTextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioTextBox.Location = new System.Drawing.Point(166, 155);
            this.precioTextBox.MaxLength = 10;
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(100, 27);
            this.precioTextBox.TabIndex = 40;
            this.precioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioTextBox_KeyPress);
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.habitacionesBindingSource, "Estado", true));
            this.estadoTextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoTextBox.Location = new System.Drawing.Point(166, 197);
            this.estadoTextBox.MaxLength = 10;
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 27);
            this.estadoTextBox.TabIndex = 41;
            this.estadoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.estadoTextBox_KeyPress);
            // 
            // habitacionesDataGridView
            // 
            this.habitacionesDataGridView.AllowUserToAddRows = false;
            this.habitacionesDataGridView.AllowUserToDeleteRows = false;
            this.habitacionesDataGridView.AutoGenerateColumns = false;
            this.habitacionesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.habitacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.habitacionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.habitacionesDataGridView.DataSource = this.habitacionesBindingSource;
            this.habitacionesDataGridView.Location = new System.Drawing.Point(189, 281);
            this.habitacionesDataGridView.Name = "habitacionesDataGridView";
            this.habitacionesDataGridView.ReadOnly = true;
            this.habitacionesDataGridView.Size = new System.Drawing.Size(440, 220);
            this.habitacionesDataGridView.TabIndex = 41;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_Habitaciones";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cod_Habitaciones";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombres";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombres";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn4.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(771, 577);
            this.Controls.Add(this.habitacionesDataGridView);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(cod_HabitacionesLabel);
            this.Controls.Add(this.cod_HabitacionesTextBox);
            this.Controls.Add(this.bntNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pnlBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHabitaciones";
            this.Text = "FrmHabitaciones";
            this.Load += new System.EventHandler(this.FrmHabitaciones_Load);
            this.pnlBarra.ResumeLayout(false);
            this.pnlBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotel5taRealDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private Hotel5taRealDataSet hotel5taRealDataSet;
        private System.Windows.Forms.BindingSource habitacionesBindingSource;
        private Hotel5taRealDataSetTableAdapters.HabitacionesTableAdapter habitacionesTableAdapter;
        private Hotel5taRealDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cod_HabitacionesTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.DataGridView habitacionesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
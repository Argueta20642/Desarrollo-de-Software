
namespace Hotel5taReal.Front_End.FrmAdmin
{
    partial class FrmPlanilla
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
            System.Windows.Forms.Label cod_TrabajadorLabel;
            System.Windows.Forms.Label nombreTrabajadorLabel;
            System.Windows.Forms.Label apellidoTrabajadorLabel;
            System.Windows.Forms.Label dNILabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label sueldoLabel;
            System.Windows.Forms.Label estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlanilla));
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tRABAJADORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bntNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.hotel5taRealDataSet = new Hotel5taReal.Hotel5taRealDataSet();
            this.planillaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planillaTableAdapter = new Hotel5taReal.Hotel5taRealDataSetTableAdapters.PlanillaTableAdapter();
            this.tableAdapterManager = new Hotel5taReal.Hotel5taRealDataSetTableAdapters.TableAdapterManager();
            this.planillaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_TrabajadorTextBox = new System.Windows.Forms.TextBox();
            this.nombreTrabajadorTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTrabajadorTextBox = new System.Windows.Forms.TextBox();
            this.dNITextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.sueldoTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.ErrorPlanilla = new System.Windows.Forms.ErrorProvider(this.components);
            cod_TrabajadorLabel = new System.Windows.Forms.Label();
            nombreTrabajadorLabel = new System.Windows.Forms.Label();
            apellidoTrabajadorLabel = new System.Windows.Forms.Label();
            dNILabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            sueldoLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRABAJADORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel5taRealDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planillaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planillaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPlanilla)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_TrabajadorLabel
            // 
            cod_TrabajadorLabel.AutoSize = true;
            cod_TrabajadorLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cod_TrabajadorLabel.Location = new System.Drawing.Point(46, 68);
            cod_TrabajadorLabel.Name = "cod_TrabajadorLabel";
            cod_TrabajadorLabel.Size = new System.Drawing.Size(79, 20);
            cod_TrabajadorLabel.TabIndex = 34;
            cod_TrabajadorLabel.Text = "Cod Trabajador:";
            // 
            // nombreTrabajadorLabel
            // 
            nombreTrabajadorLabel.AutoSize = true;
            nombreTrabajadorLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreTrabajadorLabel.Location = new System.Drawing.Point(28, 99);
            nombreTrabajadorLabel.Name = "nombreTrabajadorLabel";
            nombreTrabajadorLabel.Size = new System.Drawing.Size(97, 20);
            nombreTrabajadorLabel.TabIndex = 35;
            nombreTrabajadorLabel.Text = "Nombre Trabajador:";
            // 
            // apellidoTrabajadorLabel
            // 
            apellidoTrabajadorLabel.AutoSize = true;
            apellidoTrabajadorLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoTrabajadorLabel.Location = new System.Drawing.Point(28, 130);
            apellidoTrabajadorLabel.Name = "apellidoTrabajadorLabel";
            apellidoTrabajadorLabel.Size = new System.Drawing.Size(95, 20);
            apellidoTrabajadorLabel.TabIndex = 36;
            apellidoTrabajadorLabel.Text = "Apellido Trabajador:";
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dNILabel.Location = new System.Drawing.Point(98, 161);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(26, 20);
            dNILabel.TabIndex = 37;
            dNILabel.Text = "DNI:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(92, 192);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 20);
            emailLabel.TabIndex = 38;
            emailLabel.Text = "Email:";
            // 
            // sueldoLabel
            // 
            sueldoLabel.AutoSize = true;
            sueldoLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sueldoLabel.Location = new System.Drawing.Point(84, 224);
            sueldoLabel.Name = "sueldoLabel";
            sueldoLabel.Size = new System.Drawing.Size(40, 20);
            sueldoLabel.TabIndex = 39;
            sueldoLabel.Text = "Sueldo:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoLabel.Location = new System.Drawing.Point(84, 250);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(40, 20);
            estadoLabel.TabIndex = 40;
            estadoLabel.Text = "Estado:";
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlBarra.Controls.Add(this.label1);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(824, 45);
            this.pnlBarra.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(346, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLANILLA";
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
            this.bntNuevo.Location = new System.Drawing.Point(610, 151);
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
            this.btnModificar.Location = new System.Drawing.Point(518, 151);
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
            this.btnAgregar.Location = new System.Drawing.Point(436, 151);
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
            // planillaBindingSource
            // 
            this.planillaBindingSource.DataMember = "Planilla";
            this.planillaBindingSource.DataSource = this.hotel5taRealDataSet;
            // 
            // planillaTableAdapter
            // 
            this.planillaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.facturasTableAdapter = null;
            this.tableAdapterManager.HabitacionesTableAdapter = null;
            this.tableAdapterManager.OrdenItemsTableAdapter = null;
            this.tableAdapterManager.OrdenTableAdapter = null;
            this.tableAdapterManager.PlanillaTableAdapter = this.planillaTableAdapter;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.ReservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Hotel5taReal.Hotel5taRealDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // planillaDataGridView
            // 
            this.planillaDataGridView.AllowUserToAddRows = false;
            this.planillaDataGridView.AllowUserToDeleteRows = false;
            this.planillaDataGridView.AutoGenerateColumns = false;
            this.planillaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.planillaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.planillaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.planillaDataGridView.DataSource = this.planillaBindingSource;
            this.planillaDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.planillaDataGridView.Location = new System.Drawing.Point(24, 289);
            this.planillaDataGridView.Name = "planillaDataGridView";
            this.planillaDataGridView.ReadOnly = true;
            this.planillaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.planillaDataGridView.Size = new System.Drawing.Size(744, 240);
            this.planillaDataGridView.TabIndex = 34;
            this.planillaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.planillaDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_Trabajador";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cod_Trabajador";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreTrabajador";
            this.dataGridViewTextBoxColumn2.HeaderText = "NombreTrabajador";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ApellidoTrabajador";
            this.dataGridViewTextBoxColumn3.HeaderText = "ApellidoTrabajador";
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Sueldo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Sueldo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn7.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // cod_TrabajadorTextBox
            // 
            this.cod_TrabajadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planillaBindingSource, "Cod_Trabajador", true));
            this.cod_TrabajadorTextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_TrabajadorTextBox.Location = new System.Drawing.Point(170, 65);
            this.cod_TrabajadorTextBox.MaxLength = 2;
            this.cod_TrabajadorTextBox.Name = "cod_TrabajadorTextBox";
            this.cod_TrabajadorTextBox.Size = new System.Drawing.Size(100, 26);
            this.cod_TrabajadorTextBox.TabIndex = 35;
            this.cod_TrabajadorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cod_TrabajadorTextBox_KeyPress);
            // 
            // nombreTrabajadorTextBox
            // 
            this.nombreTrabajadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planillaBindingSource, "NombreTrabajador", true));
            this.nombreTrabajadorTextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTrabajadorTextBox.Location = new System.Drawing.Point(170, 96);
            this.nombreTrabajadorTextBox.MaxLength = 10;
            this.nombreTrabajadorTextBox.Name = "nombreTrabajadorTextBox";
            this.nombreTrabajadorTextBox.Size = new System.Drawing.Size(100, 26);
            this.nombreTrabajadorTextBox.TabIndex = 36;
            this.nombreTrabajadorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTrabajadorTextBox_KeyPress);
            // 
            // apellidoTrabajadorTextBox
            // 
            this.apellidoTrabajadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planillaBindingSource, "ApellidoTrabajador", true));
            this.apellidoTrabajadorTextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTrabajadorTextBox.Location = new System.Drawing.Point(170, 127);
            this.apellidoTrabajadorTextBox.MaxLength = 10;
            this.apellidoTrabajadorTextBox.Name = "apellidoTrabajadorTextBox";
            this.apellidoTrabajadorTextBox.Size = new System.Drawing.Size(100, 26);
            this.apellidoTrabajadorTextBox.TabIndex = 37;
            this.apellidoTrabajadorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellidoTrabajadorTextBox_KeyPress);
            // 
            // dNITextBox
            // 
            this.dNITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planillaBindingSource, "DNI", true));
            this.dNITextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dNITextBox.Location = new System.Drawing.Point(170, 158);
            this.dNITextBox.MaxLength = 13;
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.Size = new System.Drawing.Size(100, 26);
            this.dNITextBox.TabIndex = 38;
            this.dNITextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dNITextBox_KeyPress);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planillaBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(170, 189);
            this.emailTextBox.MaxLength = 20;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 26);
            this.emailTextBox.TabIndex = 39;
            // 
            // sueldoTextBox
            // 
            this.sueldoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planillaBindingSource, "Sueldo", true));
            this.sueldoTextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sueldoTextBox.Location = new System.Drawing.Point(170, 218);
            this.sueldoTextBox.MaxLength = 5;
            this.sueldoTextBox.Name = "sueldoTextBox";
            this.sueldoTextBox.Size = new System.Drawing.Size(100, 26);
            this.sueldoTextBox.TabIndex = 40;
            this.sueldoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sueldoTextBox_KeyPress);
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planillaBindingSource, "Estado", true));
            this.estadoTextBox.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoTextBox.Location = new System.Drawing.Point(170, 247);
            this.estadoTextBox.MaxLength = 10;
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 26);
            this.estadoTextBox.TabIndex = 41;
            this.estadoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.estadoTextBox_KeyPress);
            // 
            // ErrorPlanilla
            // 
            this.ErrorPlanilla.ContainerControl = this;
            // 
            // FrmPlanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(824, 561);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(sueldoLabel);
            this.Controls.Add(this.sueldoTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(dNILabel);
            this.Controls.Add(this.dNITextBox);
            this.Controls.Add(apellidoTrabajadorLabel);
            this.Controls.Add(this.apellidoTrabajadorTextBox);
            this.Controls.Add(nombreTrabajadorLabel);
            this.Controls.Add(this.nombreTrabajadorTextBox);
            this.Controls.Add(cod_TrabajadorLabel);
            this.Controls.Add(this.cod_TrabajadorTextBox);
            this.Controls.Add(this.planillaDataGridView);
            this.Controls.Add(this.bntNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pnlBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPlanilla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPlanilla";
            this.Load += new System.EventHandler(this.FrmPlanilla_Load);
            this.pnlBarra.ResumeLayout(false);
            this.pnlBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRABAJADORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel5taRealDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planillaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planillaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPlanilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.BindingSource tRABAJADORESBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAcodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAnombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAapellidoPaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAapellidoMaternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAdniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAfechaContratoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAcargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRAsueldoMensualDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bntNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private Hotel5taRealDataSet hotel5taRealDataSet;
        private System.Windows.Forms.BindingSource planillaBindingSource;
        private Hotel5taRealDataSetTableAdapters.PlanillaTableAdapter planillaTableAdapter;
        private Hotel5taRealDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView planillaDataGridView;
        private System.Windows.Forms.TextBox cod_TrabajadorTextBox;
        private System.Windows.Forms.TextBox nombreTrabajadorTextBox;
        private System.Windows.Forms.TextBox apellidoTrabajadorTextBox;
        private System.Windows.Forms.TextBox dNITextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox sueldoTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ErrorProvider ErrorPlanilla;
    }
}
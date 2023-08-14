namespace ExpoArqui_II
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCapturar = new System.Windows.Forms.Button();
            this.LbNombre = new System.Windows.Forms.Label();
            this.LbFecha = new System.Windows.Forms.Label();
            this.LbHora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbPuertos = new System.Windows.Forms.ComboBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnDetener = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.PbFoto = new System.Windows.Forms.PictureBox();
            this.tb_FotosDataGridView = new System.Windows.Forms.DataGridView();
            this.iDFotosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_FotosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_FotosDataSet = new ExpoArqui_II.BD_FotosDataSet();
            this.tableAdapterManager = new ExpoArqui_II.BD_FotosDataSetTableAdapters.Tb_FotosTableAdapter();
            this.CbBaudios = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_FotosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_FotosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_FotosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCapturar
            // 
            this.BtnCapturar.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCapturar.Location = new System.Drawing.Point(1043, 364);
            this.BtnCapturar.Name = "BtnCapturar";
            this.BtnCapturar.Size = new System.Drawing.Size(107, 46);
            this.BtnCapturar.TabIndex = 0;
            this.BtnCapturar.Text = "Capturar";
            this.BtnCapturar.UseVisualStyleBackColor = true;
            this.BtnCapturar.Click += new System.EventHandler(this.BtnCapturar_Click);
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombre.Location = new System.Drawing.Point(1078, 104);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(40, 18);
            this.LbNombre.TabIndex = 2;
            this.LbNombre.Text = "----";
            // 
            // LbFecha
            // 
            this.LbFecha.AutoSize = true;
            this.LbFecha.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFecha.Location = new System.Drawing.Point(1078, 162);
            this.LbFecha.Name = "LbFecha";
            this.LbFecha.Size = new System.Drawing.Size(40, 18);
            this.LbFecha.TabIndex = 3;
            this.LbFecha.Text = "----";
            // 
            // LbHora
            // 
            this.LbHora.AutoSize = true;
            this.LbHora.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHora.Location = new System.Drawing.Point(1080, 231);
            this.LbHora.Name = "LbHora";
            this.LbHora.Size = new System.Drawing.Size(40, 18);
            this.LbHora.TabIndex = 4;
            this.LbHora.Text = "----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1002, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(999, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(999, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Puertos:";
            // 
            // CbPuertos
            // 
            this.CbPuertos.FormattingEnabled = true;
            this.CbPuertos.Location = new System.Drawing.Point(646, 498);
            this.CbPuertos.Name = "CbPuertos";
            this.CbPuertos.Size = new System.Drawing.Size(150, 24);
            this.CbPuertos.TabIndex = 15;
            this.CbPuertos.DropDown += new System.EventHandler(this.CbPuertos_DropDown);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(26, 485);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(107, 40);
            this.BtnEliminar.TabIndex = 16;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.BtnActualizar.BackgroundImage = global::ExpoArqui_II.Properties.Resources.Daco_5706067;
            this.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnActualizar.Location = new System.Drawing.Point(148, 486);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(40, 40);
            this.BtnActualizar.TabIndex = 17;
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnDetener
            // 
            this.BtnDetener.BackColor = System.Drawing.Color.Transparent;
            this.BtnDetener.BackgroundImage = global::ExpoArqui_II.Properties.Resources.stop;
            this.BtnDetener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDetener.Location = new System.Drawing.Point(919, 493);
            this.BtnDetener.Name = "BtnDetener";
            this.BtnDetener.Size = new System.Drawing.Size(40, 40);
            this.BtnDetener.TabIndex = 14;
            this.BtnDetener.UseVisualStyleBackColor = false;
            this.BtnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.BtnIniciar.BackgroundImage = global::ExpoArqui_II.Properties.Resources.boton_de_play;
            this.BtnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnIniciar.Location = new System.Drawing.Point(845, 493);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(40, 40);
            this.BtnIniciar.TabIndex = 12;
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // PbFoto
            // 
            this.PbFoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PbFoto.Image = global::ExpoArqui_II.Properties.Resources.gallery;
            this.PbFoto.Location = new System.Drawing.Point(535, 24);
            this.PbFoto.Name = "PbFoto";
            this.PbFoto.Size = new System.Drawing.Size(450, 450);
            this.PbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbFoto.TabIndex = 1;
            this.PbFoto.TabStop = false;
            // 
            // tb_FotosDataGridView
            // 
            this.tb_FotosDataGridView.AllowUserToAddRows = false;
            this.tb_FotosDataGridView.AllowUserToDeleteRows = false;
            this.tb_FotosDataGridView.AllowUserToResizeColumns = false;
            this.tb_FotosDataGridView.AllowUserToResizeRows = false;
            this.tb_FotosDataGridView.AutoGenerateColumns = false;
            this.tb_FotosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tb_FotosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tb_FotosDataGridView.ColumnHeadersHeight = 30;
            this.tb_FotosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tb_FotosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDFotosDataGridViewTextBoxColumn,
            this.Check,
            this.nombreDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn});
            this.tb_FotosDataGridView.DataSource = this.tb_FotosBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tb_FotosDataGridView.DefaultCellStyle = dataGridViewCellStyle10;
            this.tb_FotosDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.tb_FotosDataGridView.Location = new System.Drawing.Point(26, 24);
            this.tb_FotosDataGridView.Name = "tb_FotosDataGridView";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tb_FotosDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.tb_FotosDataGridView.RowHeadersVisible = false;
            this.tb_FotosDataGridView.RowHeadersWidth = 51;
            this.tb_FotosDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.tb_FotosDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.tb_FotosDataGridView.RowTemplate.Height = 24;
            this.tb_FotosDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_FotosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tb_FotosDataGridView.Size = new System.Drawing.Size(486, 450);
            this.tb_FotosDataGridView.TabIndex = 18;
            this.tb_FotosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tb_FotosDataGridView_CellClick_1);
            // 
            // iDFotosDataGridViewTextBoxColumn
            // 
            this.iDFotosDataGridViewTextBoxColumn.DataPropertyName = "ID_Fotos";
            this.iDFotosDataGridViewTextBoxColumn.HeaderText = "ID_Fotos";
            this.iDFotosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDFotosDataGridViewTextBoxColumn.Name = "iDFotosDataGridViewTextBoxColumn";
            this.iDFotosDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDFotosDataGridViewTextBoxColumn.Visible = false;
            this.iDFotosDataGridViewTextBoxColumn.Width = 125;
            // 
            // Check
            // 
            this.Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Check.FalseValue = "";
            this.Check.HeaderText = "";
            this.Check.MinimumWidth = 6;
            this.Check.Name = "Check";
            this.Check.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Check.Width = 30;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 180;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 83;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.Width = 73;
            // 
            // tb_FotosBindingSource
            // 
            this.tb_FotosBindingSource.DataMember = "Tb_Fotos";
            this.tb_FotosBindingSource.DataSource = this.bD_FotosDataSet;
            // 
            // bD_FotosDataSet
            // 
            this.bD_FotosDataSet.DataSetName = "BD_FotosDataSet";
            this.bD_FotosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ClearBeforeFill = true;
            // 
            // CbBaudios
            // 
            this.CbBaudios.FormattingEnabled = true;
            this.CbBaudios.Location = new System.Drawing.Point(646, 533);
            this.CbBaudios.Name = "CbBaudios";
            this.CbBaudios.Size = new System.Drawing.Size(150, 24);
            this.CbBaudios.TabIndex = 19;
            this.CbBaudios.DropDown += new System.EventHandler(this.CbBaudios_DropDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1006, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 569);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CbBaudios);
            this.Controls.Add(this.tb_FotosDataGridView);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.CbPuertos);
            this.Controls.Add(this.BtnDetener);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbHora);
            this.Controls.Add(this.LbFecha);
            this.Controls.Add(this.LbNombre);
            this.Controls.Add(this.PbFoto);
            this.Controls.Add(this.BtnCapturar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_FotosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_FotosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_FotosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCapturar;
        private System.Windows.Forms.PictureBox PbFoto;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.Label LbFecha;
        private System.Windows.Forms.Label LbHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnDetener;
        private System.Windows.Forms.ComboBox CbPuertos;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataGridView tb_FotosDataGridView;
        private BD_FotosDataSet bD_FotosDataSet;
        private System.Windows.Forms.BindingSource tb_FotosBindingSource;
        private BD_FotosDataSetTableAdapters.Tb_FotosTableAdapter tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFotosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox CbBaudios;
        private System.Windows.Forms.Button button1;
    }
}


namespace Salon.Clientes
{
    partial class Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvDatosEmpleados = new DrakeUI.Framework.DrakeUIDataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.drakeUITextBox1 = new DrakeUI.Framework.DrakeUITextBox();
            this.btnAgregclient = new System.Windows.Forms.Button();
            this.Closemenu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closemenu)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDatosEmpleados
            // 
            this.DgvDatosEmpleados.AllowUserToAddRows = false;
            this.DgvDatosEmpleados.AllowUserToDeleteRows = false;
            this.DgvDatosEmpleados.AllowUserToResizeColumns = false;
            this.DgvDatosEmpleados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgvDatosEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvDatosEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvDatosEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgvDatosEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvDatosEmpleados.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvDatosEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDatosEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DgvDatosEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvDatosEmpleados.ColumnHeadersHeight = 32;
            this.DgvDatosEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvDatosEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.ID_Empleado,
            this.Nombre,
            this.Apellido,
            this.Cedula,
            this.Sexo,
            this.Estado,
            this.Puesto});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvDatosEmpleados.DefaultCellStyle = dataGridViewCellStyle4;
            this.DgvDatosEmpleados.EnableHeadersVisualStyles = false;
            this.DgvDatosEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DgvDatosEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.DgvDatosEmpleados.Location = new System.Drawing.Point(13, 206);
            this.DgvDatosEmpleados.Name = "DgvDatosEmpleados";
            this.DgvDatosEmpleados.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvDatosEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvDatosEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvDatosEmpleados.RowHeadersVisible = false;
            this.DgvDatosEmpleados.RowHeadersWidth = 25;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvDatosEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvDatosEmpleados.RowTemplate.Height = 29;
            this.DgvDatosEmpleados.SelectedIndex = -1;
            this.DgvDatosEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDatosEmpleados.ShowRect = false;
            this.DgvDatosEmpleados.Size = new System.Drawing.Size(937, 354);
            this.DgvDatosEmpleados.StripeOddColor = System.Drawing.Color.White;
            this.DgvDatosEmpleados.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DgvDatosEmpleados.StyleCustomMode = true;
            this.DgvDatosEmpleados.TabIndex = 57;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.Width = 55;
            // 
            // ID_Empleado
            // 
            this.ID_Empleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID_Empleado.DataPropertyName = "ID_Empleado";
            this.ID_Empleado.HeaderText = "ID Cliente";
            this.ID_Empleado.Name = "ID_Empleado";
            this.ID_Empleado.Width = 95;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 130;
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 130;
            // 
            // Cedula
            // 
            this.Cedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cedula.DataPropertyName = "Cedula";
            this.Cedula.HeaderText = "Telefono";
            this.Cedula.Name = "Cedula";
            this.Cedula.Width = 130;
            // 
            // Sexo
            // 
            this.Sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Correo";
            this.Sexo.Name = "Sexo";
            this.Sexo.Width = 120;
            // 
            // Estado
            // 
            this.Estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Estado.DataPropertyName = "Estado";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.DefaultCellStyle = dataGridViewCellStyle3;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Puesto
            // 
            this.Puesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Puesto.DataPropertyName = "Puesto";
            this.Puesto.HeaderText = "Fecha Registro";
            this.Puesto.Name = "Puesto";
            this.Puesto.Width = 256;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(-6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(979, 1);
            this.label1.TabIndex = 220;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 219;
            this.label2.Text = "Clientes";
            // 
            // drakeUITextBox1
            // 
            this.drakeUITextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.drakeUITextBox1.FillColor = System.Drawing.Color.White;
            this.drakeUITextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drakeUITextBox1.Location = new System.Drawing.Point(58, 158);
            this.drakeUITextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drakeUITextBox1.Maximum = 2147483647D;
            this.drakeUITextBox1.Minimum = -2147483648D;
            this.drakeUITextBox1.Name = "drakeUITextBox1";
            this.drakeUITextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.drakeUITextBox1.RectColor = System.Drawing.Color.Silver;
            this.drakeUITextBox1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.drakeUITextBox1.Size = new System.Drawing.Size(228, 29);
            this.drakeUITextBox1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.drakeUITextBox1.TabIndex = 221;
            // 
            // btnAgregclient
            // 
            this.btnAgregclient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(160)))), ((int)(((byte)(190)))));
            this.btnAgregclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregclient.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregclient.ForeColor = System.Drawing.Color.White;
            this.btnAgregclient.Image = global::Salon.Properties.Resources.icons8_más_2_matemáticas_23;
            this.btnAgregclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregclient.Location = new System.Drawing.Point(867, 155);
            this.btnAgregclient.Name = "btnAgregclient";
            this.btnAgregclient.Size = new System.Drawing.Size(83, 32);
            this.btnAgregclient.TabIndex = 58;
            this.btnAgregclient.Text = "      Nuevo";
            this.btnAgregclient.UseVisualStyleBackColor = false;
            this.btnAgregclient.Click += new System.EventHandler(this.btnAgregclient_Click);
            // 
            // Closemenu
            // 
            this.Closemenu.BackColor = System.Drawing.SystemColors.Control;
            this.Closemenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Closemenu.Image = global::Salon.Properties.Resources.icons8_búsqueda_22;
            this.Closemenu.Location = new System.Drawing.Point(23, 158);
            this.Closemenu.Name = "Closemenu";
            this.Closemenu.Size = new System.Drawing.Size(35, 29);
            this.Closemenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Closemenu.TabIndex = 225;
            this.Closemenu.TabStop = false;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 584);
            this.Controls.Add(this.Closemenu);
            this.Controls.Add(this.drakeUITextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregclient);
            this.Controls.Add(this.DgvDatosEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatosEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Closemenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DrakeUI.Framework.DrakeUIDataGridView DgvDatosEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.Button btnAgregclient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DrakeUI.Framework.DrakeUITextBox drakeUITextBox1;
        private System.Windows.Forms.PictureBox Closemenu;
    }
}
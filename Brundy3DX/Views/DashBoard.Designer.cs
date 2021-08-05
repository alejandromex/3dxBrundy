
namespace Brundy3DX.Views
{
    partial class DashBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDashBoard = new System.Windows.Forms.DataGridView();
            this.pm25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pm10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amoniaco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alcohol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.benceno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monoxido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dioxidocarb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTiempoVuelo = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.lblNombreMedicion = new System.Windows.Forms.Label();
            this.lblMedicionAlta = new System.Windows.Forms.Label();
            this.lblMedicionPromedio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDashBoard
            // 
            this.dgvDashBoard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.dgvDashBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDashBoard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDashBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDashBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pm25,
            this.pm10,
            this.amoniaco,
            this.alcohol,
            this.benceno,
            this.humo,
            this.nox,
            this.monoxido,
            this.dioxidocarb});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDashBoard.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDashBoard.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(237)))));
            this.dgvDashBoard.Location = new System.Drawing.Point(0, 0);
            this.dgvDashBoard.Name = "dgvDashBoard";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDashBoard.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDashBoard.Size = new System.Drawing.Size(827, 63);
            this.dgvDashBoard.TabIndex = 11;
            this.dgvDashBoard.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDashBoard_CellDoubleClick);
            this.dgvDashBoard.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDashBoard_ColumnHeaderMouseDoubleClick);
            // 
            // pm25
            // 
            this.pm25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pm25.HeaderText = "PM 2.5";
            this.pm25.Name = "pm25";
            // 
            // pm10
            // 
            this.pm10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pm10.HeaderText = "PM 10";
            this.pm10.Name = "pm10";
            // 
            // amoniaco
            // 
            this.amoniaco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amoniaco.HeaderText = "Amoniaco";
            this.amoniaco.Name = "amoniaco";
            // 
            // alcohol
            // 
            this.alcohol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alcohol.HeaderText = "Alcohol";
            this.alcohol.Name = "alcohol";
            // 
            // benceno
            // 
            this.benceno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.benceno.HeaderText = "Benceno";
            this.benceno.Name = "benceno";
            // 
            // humo
            // 
            this.humo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.humo.HeaderText = "Humo";
            this.humo.Name = "humo";
            // 
            // nox
            // 
            this.nox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nox.HeaderText = "NOx";
            this.nox.Name = "nox";
            // 
            // monoxido
            // 
            this.monoxido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.monoxido.HeaderText = "Monoxido";
            this.monoxido.Name = "monoxido";
            // 
            // dioxidocarb
            // 
            this.dioxidocarb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dioxidocarb.HeaderText = "Dioxido de carbono";
            this.dioxidocarb.Name = "dioxidocarb";
            // 
            // lblTiempoVuelo
            // 
            this.lblTiempoVuelo.AutoSize = true;
            this.lblTiempoVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoVuelo.ForeColor = System.Drawing.Color.White;
            this.lblTiempoVuelo.Location = new System.Drawing.Point(535, 70);
            this.lblTiempoVuelo.Name = "lblTiempoVuelo";
            this.lblTiempoVuelo.Size = new System.Drawing.Size(292, 25);
            this.lblTiempoVuelo.TabIndex = 12;
            this.lblTiempoVuelo.Text = "Tiempo de vuelo: 00:00:00";
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.ForeColor = System.Drawing.Color.White;
            this.lblRegistros.Location = new System.Drawing.Point(603, 109);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(224, 25);
            this.lblRegistros.TabIndex = 13;
            this.lblRegistros.Text = "Total de registros: 0";
            // 
            // lblNombreMedicion
            // 
            this.lblNombreMedicion.AutoSize = true;
            this.lblNombreMedicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMedicion.ForeColor = System.Drawing.Color.White;
            this.lblNombreMedicion.Location = new System.Drawing.Point(34, 70);
            this.lblNombreMedicion.Name = "lblNombreMedicion";
            this.lblNombreMedicion.Size = new System.Drawing.Size(100, 25);
            this.lblNombreMedicion.TabIndex = 14;
            this.lblNombreMedicion.Text = "Nombre:";
            // 
            // lblMedicionAlta
            // 
            this.lblMedicionAlta.AutoSize = true;
            this.lblMedicionAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicionAlta.ForeColor = System.Drawing.Color.White;
            this.lblMedicionAlta.Location = new System.Drawing.Point(34, 113);
            this.lblMedicionAlta.Name = "lblMedicionAlta";
            this.lblMedicionAlta.Size = new System.Drawing.Size(210, 25);
            this.lblMedicionAlta.TabIndex = 15;
            this.lblMedicionAlta.Text = "Medicion mas alta:";
            // 
            // lblMedicionPromedio
            // 
            this.lblMedicionPromedio.AutoSize = true;
            this.lblMedicionPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicionPromedio.ForeColor = System.Drawing.Color.White;
            this.lblMedicionPromedio.Location = new System.Drawing.Point(34, 157);
            this.lblMedicionPromedio.Name = "lblMedicionPromedio";
            this.lblMedicionPromedio.Size = new System.Drawing.Size(189, 25);
            this.lblMedicionPromedio.TabIndex = 16;
            this.lblMedicionPromedio.Text = "Promedio actual:";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblMedicionPromedio);
            this.Controls.Add(this.lblMedicionAlta);
            this.Controls.Add(this.lblNombreMedicion);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.lblTiempoVuelo);
            this.Controls.Add(this.dgvDashBoard);
            this.Name = "DashBoard";
            this.Size = new System.Drawing.Size(827, 412);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDashBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDashBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm25;
        private System.Windows.Forms.DataGridViewTextBoxColumn pm10;
        private System.Windows.Forms.DataGridViewTextBoxColumn amoniaco;
        private System.Windows.Forms.DataGridViewTextBoxColumn alcohol;
        private System.Windows.Forms.DataGridViewTextBoxColumn benceno;
        private System.Windows.Forms.DataGridViewTextBoxColumn humo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nox;
        private System.Windows.Forms.DataGridViewTextBoxColumn monoxido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dioxidocarb;
        private System.Windows.Forms.Label lblTiempoVuelo;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label lblNombreMedicion;
        private System.Windows.Forms.Label lblMedicionAlta;
        private System.Windows.Forms.Label lblMedicionPromedio;
    }
}

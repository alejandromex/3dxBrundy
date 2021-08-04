
namespace Brundy3DX.Views
{
    partial class Mapa
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
            this.gMapa = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMapLatitud = new System.Windows.Forms.TextBox();
            this.txtMapLongitud = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMapAltitud = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gMapa
            // 
            this.gMapa.Bearing = 0F;
            this.gMapa.CanDragMap = true;
            this.gMapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapa.GrayScaleMode = false;
            this.gMapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapa.LevelsKeepInMemmory = 5;
            this.gMapa.Location = new System.Drawing.Point(3, 3);
            this.gMapa.MarkersEnabled = true;
            this.gMapa.MaxZoom = 2;
            this.gMapa.MinZoom = 2;
            this.gMapa.MouseWheelZoomEnabled = true;
            this.gMapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapa.Name = "gMapa";
            this.gMapa.NegativeMode = false;
            this.gMapa.PolygonsEnabled = true;
            this.gMapa.RetryLoadTile = 0;
            this.gMapa.RoutesEnabled = true;
            this.gMapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapa.ShowTileGridLines = false;
            this.gMapa.Size = new System.Drawing.Size(525, 396);
            this.gMapa.TabIndex = 0;
            this.gMapa.Zoom = 0D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(542, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Latitud";
            // 
            // txtMapLatitud
            // 
            this.txtMapLatitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMapLatitud.Location = new System.Drawing.Point(546, 40);
            this.txtMapLatitud.Name = "txtMapLatitud";
            this.txtMapLatitud.Size = new System.Drawing.Size(253, 26);
            this.txtMapLatitud.TabIndex = 2;
            // 
            // txtMapLongitud
            // 
            this.txtMapLongitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMapLongitud.Location = new System.Drawing.Point(546, 112);
            this.txtMapLongitud.Name = "txtMapLongitud";
            this.txtMapLongitud.Size = new System.Drawing.Size(253, 26);
            this.txtMapLongitud.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(542, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Longitud";
            // 
            // txtMapAltitud
            // 
            this.txtMapAltitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMapAltitud.Location = new System.Drawing.Point(546, 188);
            this.txtMapAltitud.Name = "txtMapAltitud";
            this.txtMapAltitud.Size = new System.Drawing.Size(253, 26);
            this.txtMapAltitud.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(542, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Altitud";
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtMapAltitud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMapLongitud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMapLatitud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gMapa);
            this.Name = "Mapa";
            this.Size = new System.Drawing.Size(827, 412);
            this.Load += new System.EventHandler(this.Mapa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMapLatitud;
        private System.Windows.Forms.TextBox txtMapLongitud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMapAltitud;
        private System.Windows.Forms.Label label3;
    }
}

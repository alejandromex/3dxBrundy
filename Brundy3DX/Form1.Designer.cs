
namespace Brundy3DX
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistros = new System.Windows.Forms.Button();
            this.btnMapa = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnRegistros);
            this.panel1.Controls.Add(this.btnMapa);
            this.panel1.Controls.Add(this.btnDashBoard);
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 484);
            this.panel1.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(237)))));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1018, 51);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "3DX Ingenieria";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panel3.Controls.Add(this.lblTitulo);
            this.panel3.Controls.Add(this.btnTest);
            this.panel3.Controls.Add(this.btnRestart);
            this.panel3.Controls.Add(this.btnStop);
            this.panel3.Controls.Add(this.btnStart);
            this.panel3.Location = new System.Drawing.Point(170, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(848, 50);
            this.panel3.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(237)))));
            this.lblTitulo.Location = new System.Drawing.Point(311, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(142, 29);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "DashBoard";
            // 
            // btnTest
            // 
            this.btnTest.Image = global::Brundy3DX.Properties.Resources.PCR_Test_30px;
            this.btnTest.Location = new System.Drawing.Point(691, 10);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(31, 29);
            this.btnTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnTest.TabIndex = 3;
            this.btnTest.TabStop = false;
            // 
            // btnRestart
            // 
            this.btnRestart.Image = global::Brundy3DX.Properties.Resources.restart_24px;
            this.btnRestart.Location = new System.Drawing.Point(728, 10);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(31, 29);
            this.btnRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRestart.TabIndex = 2;
            this.btnRestart.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Image = global::Brundy3DX.Properties.Resources.stop_24px;
            this.btnStop.Location = new System.Drawing.Point(765, 10);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(31, 29);
            this.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStop.TabIndex = 1;
            this.btnStop.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Image = global::Brundy3DX.Properties.Resources.play_24px;
            this.btnStart.Location = new System.Drawing.Point(802, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(31, 29);
            this.btnStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStart.TabIndex = 0;
            this.btnStart.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::Brundy3DX.Properties.Resources.exit_24px;
            this.btnExit.Location = new System.Drawing.Point(970, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 38);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Brundy3DX.Properties.Resources.labrats;
            this.pictureBox1.Location = new System.Drawing.Point(3, 445);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistros
            // 
            this.btnRegistros.FlatAppearance.BorderSize = 0;
            this.btnRegistros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(237)))));
            this.btnRegistros.Image = global::Brundy3DX.Properties.Resources.bulleted_list_35px;
            this.btnRegistros.Location = new System.Drawing.Point(0, 145);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(170, 40);
            this.btnRegistros.TabIndex = 2;
            this.btnRegistros.Text = "Registros";
            this.btnRegistros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistros.UseVisualStyleBackColor = true;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // btnMapa
            // 
            this.btnMapa.FlatAppearance.BorderSize = 0;
            this.btnMapa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMapa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(237)))));
            this.btnMapa.Image = global::Brundy3DX.Properties.Resources.map_35px;
            this.btnMapa.Location = new System.Drawing.Point(0, 99);
            this.btnMapa.Name = "btnMapa";
            this.btnMapa.Size = new System.Drawing.Size(170, 40);
            this.btnMapa.TabIndex = 1;
            this.btnMapa.Text = "Mapa";
            this.btnMapa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMapa.UseVisualStyleBackColor = true;
            this.btnMapa.Click += new System.EventHandler(this.btnMapa_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(150)))), ((int)(((byte)(237)))));
            this.btnDashBoard.Image = global::Brundy3DX.Properties.Resources.chart_35px;
            this.btnDashBoard.Location = new System.Drawing.Point(0, 56);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(170, 40);
            this.btnDashBoard.TabIndex = 0;
            this.btnDashBoard.Text = "DashBoard";
            this.btnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1015, 531);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnStop;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.PictureBox btnRestart;
        private System.Windows.Forms.PictureBox btnTest;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnMapa;
        private System.Windows.Forms.Button btnRegistros;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


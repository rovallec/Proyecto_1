
namespace Proyecto_1
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
            this.imgHeader = new System.Windows.Forms.PictureBox();
            this.cmbProfiles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPixar = new System.Windows.Forms.ListView();
            this.lstviewMylist = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWatch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstviewContinue = new System.Windows.Forms.ListView();
            this.imgView = new System.Windows.Forms.PictureBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstviewDisney = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.lstviewMarvel = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.lstviewStarWars = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.lstviewNatGeo = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstviewRes = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgView)).BeginInit();
            this.SuspendLayout();
            // 
            // imgHeader
            // 
            this.imgHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgHeader.Location = new System.Drawing.Point(546, 42);
            this.imgHeader.Name = "imgHeader";
            this.imgHeader.Size = new System.Drawing.Size(190, 190);
            this.imgHeader.TabIndex = 0;
            this.imgHeader.TabStop = false;
            // 
            // cmbProfiles
            // 
            this.cmbProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProfiles.FormattingEnabled = true;
            this.cmbProfiles.Location = new System.Drawing.Point(1221, 7);
            this.cmbProfiles.Name = "cmbProfiles";
            this.cmbProfiles.Size = new System.Drawing.Size(144, 23);
            this.cmbProfiles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1171, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Profile:";
            // 
            // lstPixar
            // 
            this.lstPixar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPixar.HideSelection = false;
            this.lstPixar.Location = new System.Drawing.Point(12, 615);
            this.lstPixar.Name = "lstPixar";
            this.lstPixar.Size = new System.Drawing.Size(1353, 219);
            this.lstPixar.TabIndex = 3;
            this.lstPixar.UseCompatibleStateImageBehavior = false;
            this.lstPixar.SelectedIndexChanged += new System.EventHandler(this.lstPixar_SelectedIndexChanged);
            // 
            // lstviewMylist
            // 
            this.lstviewMylist.HideSelection = false;
            this.lstviewMylist.Location = new System.Drawing.Point(12, 345);
            this.lstviewMylist.Name = "lstviewMylist";
            this.lstviewMylist.Size = new System.Drawing.Size(641, 219);
            this.lstviewMylist.TabIndex = 4;
            this.lstviewMylist.UseCompatibleStateImageBehavior = false;
            this.lstviewMylist.SelectedIndexChanged += new System.EventHandler(this.lstviewMylist_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mi Lista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 581);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pixar";
            // 
            // btnWatch
            // 
            this.btnWatch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnWatch.Location = new System.Drawing.Point(742, 66);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(144, 29);
            this.btnWatch.TabIndex = 6;
            this.btnWatch.Text = "Watch Now";
            this.btnWatch.UseVisualStyleBackColor = true;
            this.btnWatch.Visible = false;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Location = new System.Drawing.Point(742, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 29);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add To My List";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(723, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Continuar Viendo";
            // 
            // lstviewContinue
            // 
            this.lstviewContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstviewContinue.HideSelection = false;
            this.lstviewContinue.Location = new System.Drawing.Point(723, 345);
            this.lstviewContinue.Name = "lstviewContinue";
            this.lstviewContinue.Size = new System.Drawing.Size(642, 219);
            this.lstviewContinue.TabIndex = 7;
            this.lstviewContinue.UseCompatibleStateImageBehavior = false;
            this.lstviewContinue.SelectedIndexChanged += new System.EventHandler(this.lstviewContinue_SelectedIndexChanged);
            // 
            // imgView
            // 
            this.imgView.BackColor = System.Drawing.SystemColors.Control;
            this.imgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgView.Location = new System.Drawing.Point(0, 0);
            this.imgView.Name = "imgView";
            this.imgView.Size = new System.Drawing.Size(1577, 1845);
            this.imgView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgView.TabIndex = 0;
            this.imgView.TabStop = false;
            this.imgView.Visible = false;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(1221, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(144, 29);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 837);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Disney";
            // 
            // lstviewDisney
            // 
            this.lstviewDisney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstviewDisney.HideSelection = false;
            this.lstviewDisney.Location = new System.Drawing.Point(12, 865);
            this.lstviewDisney.Name = "lstviewDisney";
            this.lstviewDisney.Size = new System.Drawing.Size(1353, 219);
            this.lstviewDisney.TabIndex = 9;
            this.lstviewDisney.UseCompatibleStateImageBehavior = false;
            this.lstviewDisney.SelectedIndexChanged += new System.EventHandler(this.lstviewDisney_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 1093);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Marvel";
            // 
            // lstviewMarvel
            // 
            this.lstviewMarvel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstviewMarvel.HideSelection = false;
            this.lstviewMarvel.Location = new System.Drawing.Point(12, 1121);
            this.lstviewMarvel.Name = "lstviewMarvel";
            this.lstviewMarvel.Size = new System.Drawing.Size(1349, 219);
            this.lstviewMarvel.TabIndex = 11;
            this.lstviewMarvel.UseCompatibleStateImageBehavior = false;
            this.lstviewMarvel.SelectedIndexChanged += new System.EventHandler(this.lstviewMarvel_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 1346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Star Wars";
            // 
            // lstviewStarWars
            // 
            this.lstviewStarWars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstviewStarWars.HideSelection = false;
            this.lstviewStarWars.Location = new System.Drawing.Point(12, 1374);
            this.lstviewStarWars.Name = "lstviewStarWars";
            this.lstviewStarWars.Size = new System.Drawing.Size(1349, 219);
            this.lstviewStarWars.TabIndex = 13;
            this.lstviewStarWars.UseCompatibleStateImageBehavior = false;
            this.lstviewStarWars.SelectedIndexChanged += new System.EventHandler(this.lstviewStarWars_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 1598);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "National Geographic";
            // 
            // lstviewNatGeo
            // 
            this.lstviewNatGeo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstviewNatGeo.HideSelection = false;
            this.lstviewNatGeo.Location = new System.Drawing.Point(12, 1626);
            this.lstviewNatGeo.Name = "lstviewNatGeo";
            this.lstviewNatGeo.Size = new System.Drawing.Size(1349, 219);
            this.lstviewNatGeo.TabIndex = 15;
            this.lstviewNatGeo.UseCompatibleStateImageBehavior = false;
            this.lstviewNatGeo.SelectedIndexChanged += new System.EventHandler(this.lstviewNatGeo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Search:";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(500, 12);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(374, 23);
            this.txtFind.TabIndex = 18;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(880, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(59, 25);
            this.btnFind.TabIndex = 19;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(945, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 25);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Return";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lstviewRes
            // 
            this.lstviewRes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstviewRes.HideSelection = false;
            this.lstviewRes.Location = new System.Drawing.Point(12, 615);
            this.lstviewRes.Name = "lstviewRes";
            this.lstviewRes.Size = new System.Drawing.Size(1353, 219);
            this.lstviewRes.TabIndex = 21;
            this.lstviewRes.UseCompatibleStateImageBehavior = false;
            this.lstviewRes.Visible = false;
            this.lstviewRes.SelectedIndexChanged += new System.EventHandler(this.lstviewRes_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1594, 1061);
            this.Controls.Add(this.lstviewRes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstviewNatGeo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstviewStarWars);
            this.Controls.Add(this.lstviewMarvel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstviewDisney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstviewContinue);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnWatch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstviewMylist);
            this.Controls.Add(this.lstPixar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProfiles);
            this.Controls.Add(this.imgView);
            this.Controls.Add(this.imgHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgHeader;
        private System.Windows.Forms.ComboBox cmbProfiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstPixar;
        private System.Windows.Forms.ListView lstviewMylist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstviewContinue;
        private System.Windows.Forms.PictureBox imgView;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lstviewDisney;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lstviewMarvel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lstviewStarWars;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lstviewNatGeo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView lstviewRes;
    }
}


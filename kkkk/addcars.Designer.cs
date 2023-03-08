namespace kkkk
{
    partial class addcars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addcars));
            this.btnupload = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.cpic = new System.Windows.Forms.PictureBox();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kkkkDataSet = new kkkk.kkkkDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.txtrent = new System.Windows.Forms.TextBox();
            this.lbrent = new System.Windows.Forms.Label();
            this.txtquality = new System.Windows.Forms.TextBox();
            this.lbquality = new System.Windows.Forms.Label();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.lbcolor = new System.Windows.Forms.Label();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.lbcname = new System.Windows.Forms.Label();
            this.txtnoplate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.carTableAdapter = new kkkk.kkkkDataSetTableAdapters.carTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkkkDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnupload
            // 
            this.btnupload.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnupload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupload.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnupload.Location = new System.Drawing.Point(819, 574);
            this.btnupload.Margin = new System.Windows.Forms.Padding(6);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(131, 50);
            this.btnupload.TabIndex = 35;
            this.btnupload.Text = "Upload";
            this.btnupload.UseVisualStyleBackColor = false;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Red;
            this.btncancel.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncancel.Location = new System.Drawing.Point(652, 703);
            this.btncancel.Margin = new System.Windows.Forms.Padding(6);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(131, 39);
            this.btncancel.TabIndex = 33;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncalcle_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsave.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsave.Location = new System.Drawing.Point(356, 703);
            this.btnsave.Margin = new System.Windows.Forms.Padding(6);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(131, 39);
            this.btnsave.TabIndex = 32;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // cpic
            // 
            this.cpic.BackColor = System.Drawing.SystemColors.Window;
            this.cpic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpic.Location = new System.Drawing.Point(389, 532);
            this.cpic.Margin = new System.Windows.Forms.Padding(6);
            this.cpic.Name = "cpic";
            this.cpic.Size = new System.Drawing.Size(355, 135);
            this.cpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cpic.TabIndex = 31;
            this.cpic.TabStop = false;
            this.cpic.Click += new System.EventHandler(this.cpic_Click);
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "car";
            this.carBindingSource.DataSource = this.kkkkDataSet;
            // 
            // kkkkDataSet
            // 
            this.kkkkDataSet.DataSetName = "kkkkDataSet";
            this.kkkkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(147, 546);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Quality";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtrent
            // 
            this.txtrent.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrent.Location = new System.Drawing.Point(356, 455);
            this.txtrent.Margin = new System.Windows.Forms.Padding(6);
            this.txtrent.Name = "txtrent";
            this.txtrent.Size = new System.Drawing.Size(427, 30);
            this.txtrent.TabIndex = 29;
            // 
            // lbrent
            // 
            this.lbrent.AutoSize = true;
            this.lbrent.BackColor = System.Drawing.Color.White;
            this.lbrent.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrent.Location = new System.Drawing.Point(147, 463);
            this.lbrent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbrent.Name = "lbrent";
            this.lbrent.Size = new System.Drawing.Size(91, 23);
            this.lbrent.TabIndex = 28;
            this.lbrent.Text = "Rent/days";
            this.lbrent.Click += new System.EventHandler(this.lbrent_Click);
            // 
            // txtquality
            // 
            this.txtquality.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquality.Location = new System.Drawing.Point(356, 376);
            this.txtquality.Margin = new System.Windows.Forms.Padding(6);
            this.txtquality.Name = "txtquality";
            this.txtquality.Size = new System.Drawing.Size(427, 30);
            this.txtquality.TabIndex = 27;
            // 
            // lbquality
            // 
            this.lbquality.AutoSize = true;
            this.lbquality.BackColor = System.Drawing.Color.White;
            this.lbquality.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbquality.Location = new System.Drawing.Point(147, 380);
            this.lbquality.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbquality.Name = "lbquality";
            this.lbquality.Size = new System.Drawing.Size(71, 23);
            this.lbquality.TabIndex = 26;
            this.lbquality.Text = "Quality";
            this.lbquality.Click += new System.EventHandler(this.lbquality_Click);
            // 
            // txtcolor
            // 
            this.txtcolor.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcolor.Location = new System.Drawing.Point(356, 289);
            this.txtcolor.Margin = new System.Windows.Forms.Padding(6);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(427, 30);
            this.txtcolor.TabIndex = 25;
            // 
            // lbcolor
            // 
            this.lbcolor.AutoSize = true;
            this.lbcolor.BackColor = System.Drawing.Color.White;
            this.lbcolor.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcolor.Location = new System.Drawing.Point(147, 297);
            this.lbcolor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbcolor.Name = "lbcolor";
            this.lbcolor.Size = new System.Drawing.Size(57, 23);
            this.lbcolor.TabIndex = 24;
            this.lbcolor.Text = "Color";
            this.lbcolor.Click += new System.EventHandler(this.lbcolor_Click);
            // 
            // txtcname
            // 
            this.txtcname.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcname.Location = new System.Drawing.Point(356, 209);
            this.txtcname.Margin = new System.Windows.Forms.Padding(6);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(427, 30);
            this.txtcname.TabIndex = 23;
            // 
            // lbcname
            // 
            this.lbcname.AutoSize = true;
            this.lbcname.BackColor = System.Drawing.Color.White;
            this.lbcname.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcname.Location = new System.Drawing.Point(147, 213);
            this.lbcname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbcname.Name = "lbcname";
            this.lbcname.Size = new System.Drawing.Size(95, 23);
            this.lbcname.TabIndex = 22;
            this.lbcname.Text = "Car Name";
            this.lbcname.Click += new System.EventHandler(this.lbcname_Click);
            // 
            // txtnoplate
            // 
            this.txtnoplate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carBindingSource, "pno", true));
            this.txtnoplate.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoplate.Location = new System.Drawing.Point(356, 124);
            this.txtnoplate.Margin = new System.Windows.Forms.Padding(6);
            this.txtnoplate.Name = "txtnoplate";
            this.txtnoplate.Size = new System.Drawing.Size(427, 30);
            this.txtnoplate.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Plate No";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtcid
            // 
            this.txtcid.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcid.Location = new System.Drawing.Point(356, 44);
            this.txtcid.Margin = new System.Windows.Forms.Padding(6);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(427, 30);
            this.txtcid.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Car ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnupload);
            this.panel1.Controls.Add(this.txtcid);
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.txtnoplate);
            this.panel1.Controls.Add(this.cpic);
            this.panel1.Controls.Add(this.lbcname);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtcname);
            this.panel1.Controls.Add(this.txtrent);
            this.panel1.Controls.Add(this.lbcolor);
            this.panel1.Controls.Add(this.lbrent);
            this.panel1.Controls.Add(this.txtcolor);
            this.panel1.Controls.Add(this.txtquality);
            this.panel1.Controls.Add(this.lbquality);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 857);
            this.panel1.TabIndex = 36;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // addcars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 857);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "addcars";
            this.Text = "addcars";
            this.Load += new System.EventHandler(this.addcars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kkkkDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.PictureBox cpic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtrent;
        private System.Windows.Forms.Label lbrent;
        private System.Windows.Forms.TextBox txtquality;
        private System.Windows.Forms.Label lbquality;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.Label lbcolor;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.Label lbcname;
        private System.Windows.Forms.TextBox txtnoplate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.Label label1;
        private kkkkDataSet kkkkDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private kkkkDataSetTableAdapters.carTableAdapter carTableAdapter;
        private System.Windows.Forms.Panel panel1;
    }
}
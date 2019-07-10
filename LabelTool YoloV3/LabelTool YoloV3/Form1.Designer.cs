namespace LabelTool_YoloV3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImgIn = new System.Windows.Forms.Button();
            this.tbImgIn = new System.Windows.Forms.TextBox();
            this.tbLabelOut = new System.Windows.Forms.TextBox();
            this.btnLabelOut = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.FolderInfo = new System.Windows.Forms.Label();
            this.gbFolder = new System.Windows.Forms.GroupBox();
            this.gbLabeling = new System.Windows.Forms.GroupBox();
            this.tbLabelList = new System.Windows.Forms.RichTextBox();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.gbNavigating = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnImgTo = new System.Windows.Forms.Button();
            this.tbImgTo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblPointEnd = new System.Windows.Forms.Label();
            this.lblPointStart = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbFolder.SuspendLayout();
            this.gbLabeling.SuspendLayout();
            this.gbNavigating.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnImgIn
            // 
            this.btnImgIn.Location = new System.Drawing.Point(6, 32);
            this.btnImgIn.Name = "btnImgIn";
            this.btnImgIn.Size = new System.Drawing.Size(75, 23);
            this.btnImgIn.TabIndex = 1;
            this.btnImgIn.Text = "Image Input";
            this.btnImgIn.UseVisualStyleBackColor = true;
            this.btnImgIn.Click += new System.EventHandler(this.btnImgIn_Click);
            // 
            // tbImgIn
            // 
            this.tbImgIn.Location = new System.Drawing.Point(87, 32);
            this.tbImgIn.Name = "tbImgIn";
            this.tbImgIn.Size = new System.Drawing.Size(329, 20);
            this.tbImgIn.TabIndex = 2;
            // 
            // tbLabelOut
            // 
            this.tbLabelOut.Location = new System.Drawing.Point(87, 61);
            this.tbLabelOut.Name = "tbLabelOut";
            this.tbLabelOut.Size = new System.Drawing.Size(329, 20);
            this.tbLabelOut.TabIndex = 4;
            // 
            // btnLabelOut
            // 
            this.btnLabelOut.Location = new System.Drawing.Point(6, 61);
            this.btnLabelOut.Name = "btnLabelOut";
            this.btnLabelOut.Size = new System.Drawing.Size(75, 23);
            this.btnLabelOut.TabIndex = 3;
            this.btnLabelOut.Text = "LabelOutput";
            this.btnLabelOut.UseVisualStyleBackColor = true;
            this.btnLabelOut.Click += new System.EventHandler(this.btnLabelOut_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(341, 46);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete(Last)";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(341, 113);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "ClearAll";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FolderInfo
            // 
            this.FolderInfo.AutoSize = true;
            this.FolderInfo.Location = new System.Drawing.Point(338, 55);
            this.FolderInfo.Name = "FolderInfo";
            this.FolderInfo.Size = new System.Drawing.Size(54, 13);
            this.FolderInfo.TabIndex = 8;
            this.FolderInfo.Text = "FolderInfo";
            // 
            // gbFolder
            // 
            this.gbFolder.Controls.Add(this.btnImgIn);
            this.gbFolder.Controls.Add(this.tbImgIn);
            this.gbFolder.Controls.Add(this.btnLabelOut);
            this.gbFolder.Controls.Add(this.tbLabelOut);
            this.gbFolder.Location = new System.Drawing.Point(806, 12);
            this.gbFolder.Name = "gbFolder";
            this.gbFolder.Size = new System.Drawing.Size(422, 100);
            this.gbFolder.TabIndex = 9;
            this.gbFolder.TabStop = false;
            this.gbFolder.Text = "FolderOptions";
            // 
            // gbLabeling
            // 
            this.gbLabeling.Controls.Add(this.tbLabelList);
            this.gbLabeling.Controls.Add(this.btnClear);
            this.gbLabeling.Controls.Add(this.btnAddClass);
            this.gbLabeling.Controls.Add(this.btnDelete);
            this.gbLabeling.Controls.Add(this.cbClasses);
            this.gbLabeling.Location = new System.Drawing.Point(806, 118);
            this.gbLabeling.Name = "gbLabeling";
            this.gbLabeling.Size = new System.Drawing.Size(422, 147);
            this.gbLabeling.TabIndex = 10;
            this.gbLabeling.TabStop = false;
            this.gbLabeling.Text = "Labeling";
            // 
            // tbLabelList
            // 
            this.tbLabelList.Location = new System.Drawing.Point(6, 46);
            this.tbLabelList.Name = "tbLabelList";
            this.tbLabelList.Size = new System.Drawing.Size(324, 90);
            this.tbLabelList.TabIndex = 10;
            this.tbLabelList.Text = "";
            this.tbLabelList.WordWrap = false;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(341, 17);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(75, 23);
            this.btnAddClass.TabIndex = 9;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = true;
            // 
            // cbClasses
            // 
            this.cbClasses.FormattingEnabled = true;
            this.cbClasses.Location = new System.Drawing.Point(6, 19);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(324, 21);
            this.cbClasses.TabIndex = 8;
            // 
            // gbNavigating
            // 
            this.gbNavigating.Controls.Add(this.btnNext);
            this.gbNavigating.Controls.Add(this.btnPrev);
            this.gbNavigating.Controls.Add(this.btnImgTo);
            this.gbNavigating.Controls.Add(this.tbImgTo);
            this.gbNavigating.Controls.Add(this.FolderInfo);
            this.gbNavigating.Location = new System.Drawing.Point(806, 271);
            this.gbNavigating.Name = "gbNavigating";
            this.gbNavigating.Size = new System.Drawing.Size(422, 83);
            this.gbNavigating.TabIndex = 10;
            this.gbNavigating.TabStop = false;
            this.gbNavigating.Text = "Navigating";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(87, 19);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next >>>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(6, 19);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 9;
            this.btnPrev.Text = "<<< Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnImgTo
            // 
            this.btnImgTo.Location = new System.Drawing.Point(341, 19);
            this.btnImgTo.Name = "btnImgTo";
            this.btnImgTo.Size = new System.Drawing.Size(75, 23);
            this.btnImgTo.TabIndex = 5;
            this.btnImgTo.Text = "GoTo: IMG";
            this.btnImgTo.UseVisualStyleBackColor = true;
            this.btnImgTo.Click += new System.EventHandler(this.btnImgTo_Click);
            // 
            // tbImgTo
            // 
            this.tbImgTo.Location = new System.Drawing.Point(260, 22);
            this.tbImgTo.Name = "tbImgTo";
            this.tbImgTo.Size = new System.Drawing.Size(75, 20);
            this.tbImgTo.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblPointEnd);
            this.gbInfo.Controls.Add(this.lblPointStart);
            this.gbInfo.Controls.Add(this.lblHeight);
            this.gbInfo.Controls.Add(this.lblWidth);
            this.gbInfo.Location = new System.Drawing.Point(806, 360);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(422, 97);
            this.gbInfo.TabIndex = 11;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // lblPointEnd
            // 
            this.lblPointEnd.AutoSize = true;
            this.lblPointEnd.Location = new System.Drawing.Point(84, 60);
            this.lblPointEnd.Name = "lblPointEnd";
            this.lblPointEnd.Size = new System.Drawing.Size(56, 13);
            this.lblPointEnd.TabIndex = 5;
            this.lblPointEnd.Text = "Point End:";
            // 
            // lblPointStart
            // 
            this.lblPointStart.AutoSize = true;
            this.lblPointStart.Location = new System.Drawing.Point(81, 33);
            this.lblPointStart.Name = "lblPointStart";
            this.lblPointStart.Size = new System.Drawing.Size(59, 13);
            this.lblPointStart.TabIndex = 4;
            this.lblPointStart.Text = "Point Start:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(252, 60);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(51, 13);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "HEIGHT:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(256, 33);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(47, 13);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "WIDTH:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 601);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbNavigating);
            this.Controls.Add(this.gbLabeling);
            this.Controls.Add(this.gbFolder);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LabelTool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbFolder.ResumeLayout(false);
            this.gbFolder.PerformLayout();
            this.gbLabeling.ResumeLayout(false);
            this.gbNavigating.ResumeLayout(false);
            this.gbNavigating.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnImgIn;
        private System.Windows.Forms.TextBox tbImgIn;
        private System.Windows.Forms.TextBox tbLabelOut;
        private System.Windows.Forms.Button btnLabelOut;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label FolderInfo;
        private System.Windows.Forms.GroupBox gbFolder;
        private System.Windows.Forms.GroupBox gbLabeling;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.GroupBox gbNavigating;
        private System.Windows.Forms.Button btnImgTo;
        private System.Windows.Forms.TextBox tbImgTo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox tbLabelList;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblPointEnd;
        private System.Windows.Forms.Label lblPointStart;
    }
}


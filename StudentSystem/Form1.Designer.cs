namespace StudentSystem
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
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.txtTotalMark = new System.Windows.Forms.TextBox();
			this.txtSubject1 = new System.Windows.Forms.TextBox();
			this.txtSubject3 = new System.Windows.Forms.TextBox();
			this.txtSubject2 = new System.Windows.Forms.TextBox();
			this.grpboxResults = new System.Windows.Forms.GroupBox();
			this.txtGrade = new System.Windows.Forms.TextBox();
			this.txtPrecentage = new System.Windows.Forms.TextBox();
			this.grpBoxStudentInfo = new System.Windows.Forms.GroupBox();
			this.txtGrp = new System.Windows.Forms.TextBox();
			this.txtClass = new System.Windows.Forms.TextBox();
			this.grpBoxMarks = new System.Windows.Forms.GroupBox();
			this.Status = new System.Windows.Forms.RichTextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnXML = new System.Windows.Forms.Button();
			this.grpboxResults.SuspendLayout();
			this.grpBoxStudentInfo.SuspendLayout();
			this.grpBoxMarks.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(6, 19);
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(40, 20);
			this.txtId.TabIndex = 0;
			this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(52, 19);
			this.txtName.Name = "txtName";
			this.txtName.ReadOnly = true;
			this.txtName.Size = new System.Drawing.Size(150, 20);
			this.txtName.TabIndex = 1;
			// 
			// btnNext
			// 
			this.btnNext.Location = new System.Drawing.Point(167, 280);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(60, 23);
			this.btnNext.TabIndex = 2;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = true;
			// 
			// btnPrevious
			// 
			this.btnPrevious.Location = new System.Drawing.Point(12, 280);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(60, 23);
			this.btnPrevious.TabIndex = 3;
			this.btnPrevious.Text = "Previous";
			this.btnPrevious.UseVisualStyleBackColor = true;
			// 
			// txtTotalMark
			// 
			this.txtTotalMark.Location = new System.Drawing.Point(79, 45);
			this.txtTotalMark.Name = "txtTotalMark";
			this.txtTotalMark.ReadOnly = true;
			this.txtTotalMark.Size = new System.Drawing.Size(50, 20);
			this.txtTotalMark.TabIndex = 4;
			// 
			// txtSubject1
			// 
			this.txtSubject1.Location = new System.Drawing.Point(6, 19);
			this.txtSubject1.Name = "txtSubject1";
			this.txtSubject1.ReadOnly = true;
			this.txtSubject1.Size = new System.Drawing.Size(50, 20);
			this.txtSubject1.TabIndex = 5;
			// 
			// txtSubject3
			// 
			this.txtSubject3.Location = new System.Drawing.Point(152, 19);
			this.txtSubject3.Name = "txtSubject3";
			this.txtSubject3.ReadOnly = true;
			this.txtSubject3.Size = new System.Drawing.Size(50, 20);
			this.txtSubject3.TabIndex = 6;
			// 
			// txtSubject2
			// 
			this.txtSubject2.Location = new System.Drawing.Point(79, 19);
			this.txtSubject2.Name = "txtSubject2";
			this.txtSubject2.ReadOnly = true;
			this.txtSubject2.Size = new System.Drawing.Size(50, 20);
			this.txtSubject2.TabIndex = 7;
			// 
			// grpboxResults
			// 
			this.grpboxResults.Controls.Add(this.txtGrade);
			this.grpboxResults.Controls.Add(this.txtPrecentage);
			this.grpboxResults.Location = new System.Drawing.Point(12, 199);
			this.grpboxResults.Name = "grpboxResults";
			this.grpboxResults.Size = new System.Drawing.Size(65, 75);
			this.grpboxResults.TabIndex = 8;
			this.grpboxResults.TabStop = false;
			this.grpboxResults.Text = "Results";
			// 
			// txtGrade
			// 
			this.txtGrade.Location = new System.Drawing.Point(6, 45);
			this.txtGrade.Name = "txtGrade";
			this.txtGrade.ReadOnly = true;
			this.txtGrade.Size = new System.Drawing.Size(50, 20);
			this.txtGrade.TabIndex = 1;
			// 
			// txtPrecentage
			// 
			this.txtPrecentage.Location = new System.Drawing.Point(6, 19);
			this.txtPrecentage.Name = "txtPrecentage";
			this.txtPrecentage.ReadOnly = true;
			this.txtPrecentage.Size = new System.Drawing.Size(50, 20);
			this.txtPrecentage.TabIndex = 0;
			// 
			// grpBoxStudentInfo
			// 
			this.grpBoxStudentInfo.Controls.Add(this.txtGrp);
			this.grpBoxStudentInfo.Controls.Add(this.txtClass);
			this.grpBoxStudentInfo.Controls.Add(this.txtId);
			this.grpBoxStudentInfo.Controls.Add(this.txtName);
			this.grpBoxStudentInfo.Location = new System.Drawing.Point(12, 12);
			this.grpBoxStudentInfo.Name = "grpBoxStudentInfo";
			this.grpBoxStudentInfo.Size = new System.Drawing.Size(215, 100);
			this.grpBoxStudentInfo.TabIndex = 9;
			this.grpBoxStudentInfo.TabStop = false;
			this.grpBoxStudentInfo.Text = "Student";
			// 
			// txtGrp
			// 
			this.txtGrp.Location = new System.Drawing.Point(52, 71);
			this.txtGrp.Name = "txtGrp";
			this.txtGrp.ReadOnly = true;
			this.txtGrp.Size = new System.Drawing.Size(75, 20);
			this.txtGrp.TabIndex = 3;
			// 
			// txtClass
			// 
			this.txtClass.Location = new System.Drawing.Point(52, 45);
			this.txtClass.Name = "txtClass";
			this.txtClass.ReadOnly = true;
			this.txtClass.Size = new System.Drawing.Size(75, 20);
			this.txtClass.TabIndex = 2;
			// 
			// grpBoxMarks
			// 
			this.grpBoxMarks.Controls.Add(this.txtSubject1);
			this.grpBoxMarks.Controls.Add(this.txtSubject2);
			this.grpBoxMarks.Controls.Add(this.txtSubject3);
			this.grpBoxMarks.Controls.Add(this.txtTotalMark);
			this.grpBoxMarks.Location = new System.Drawing.Point(12, 118);
			this.grpBoxMarks.Name = "grpBoxMarks";
			this.grpBoxMarks.Size = new System.Drawing.Size(215, 75);
			this.grpBoxMarks.TabIndex = 10;
			this.grpBoxMarks.TabStop = false;
			this.grpBoxMarks.Text = "Marks";
			// 
			// Status
			// 
			this.Status.Location = new System.Drawing.Point(83, 199);
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			this.Status.Size = new System.Drawing.Size(144, 75);
			this.Status.TabIndex = 11;
			this.Status.Text = "";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(12, 309);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(60, 23);
			this.btnAdd.TabIndex = 12;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(167, 309);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(60, 23);
			this.btnDelete.TabIndex = 13;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(90, 309);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(60, 23);
			this.btnEdit.TabIndex = 14;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(90, 280);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(60, 23);
			this.btnSearch.TabIndex = 15;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// btnXML
			// 
			this.btnXML.Location = new System.Drawing.Point(12, 338);
			this.btnXML.Name = "btnXML";
			this.btnXML.Size = new System.Drawing.Size(215, 23);
			this.btnXML.TabIndex = 16;
			this.btnXML.Text = "Export XML";
			this.btnXML.UseVisualStyleBackColor = true;
			// 
			// StudentSystem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(234, 371);
			this.Controls.Add(this.btnXML);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.Status);
			this.Controls.Add(this.grpBoxMarks);
			this.Controls.Add(this.grpBoxStudentInfo);
			this.Controls.Add(this.grpboxResults);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.btnNext);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "StudentSystem";
			this.Text = "Student System";
			this.grpboxResults.ResumeLayout(false);
			this.grpboxResults.PerformLayout();
			this.grpBoxStudentInfo.ResumeLayout(false);
			this.grpBoxStudentInfo.PerformLayout();
			this.grpBoxMarks.ResumeLayout(false);
			this.grpBoxMarks.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.TextBox txtTotalMark;
		private System.Windows.Forms.GroupBox grpboxResults;
		private System.Windows.Forms.TextBox txtGrade;
		private System.Windows.Forms.TextBox txtPrecentage;
		private System.Windows.Forms.GroupBox grpBoxStudentInfo;
		private System.Windows.Forms.GroupBox grpBoxMarks;
		private System.Windows.Forms.RichTextBox Status;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		public System.Windows.Forms.TextBox txtId;
		public System.Windows.Forms.TextBox txtName;
		public System.Windows.Forms.TextBox txtSubject1;
		public System.Windows.Forms.TextBox txtSubject3;
		public System.Windows.Forms.TextBox txtSubject2;
		public System.Windows.Forms.TextBox txtGrp;
		public System.Windows.Forms.TextBox txtClass;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnXML;
	}
}


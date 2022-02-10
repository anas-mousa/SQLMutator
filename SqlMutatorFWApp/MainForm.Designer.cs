
namespace SqlMutatorFWApp
{
    partial class formSqlMutatorMainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnNullOperators = new System.Windows.Forms.Button();
            this.btnRelationalOperators = new System.Windows.Forms.Button();
            this.btnLogicalOperators = new System.Windows.Forms.Button();
            this.btnOrdOperators = new System.Windows.Forms.Button();
            this.btnUniOperators = new System.Windows.Forms.Button();
            this.btnSelOperator = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.rtbCode = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnNullOperators);
            this.splitContainer1.Panel1.Controls.Add(this.btnRelationalOperators);
            this.splitContainer1.Panel1.Controls.Add(this.btnLogicalOperators);
            this.splitContainer1.Panel1.Controls.Add(this.btnOrdOperators);
            this.splitContainer1.Panel1.Controls.Add(this.btnUniOperators);
            this.splitContainer1.Panel1.Controls.Add(this.btnSelOperator);
            this.splitContainer1.Panel1.Controls.Add(this.btnBrowse);
            this.splitContainer1.Panel1.Controls.Add(this.txtFilePath);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbCode);
            this.splitContainer1.Size = new System.Drawing.Size(932, 453);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnNullOperators
            // 
            this.btnNullOperators.Enabled = false;
            this.btnNullOperators.Location = new System.Drawing.Point(12, 380);
            this.btnNullOperators.Name = "btnNullOperators";
            this.btnNullOperators.Size = new System.Drawing.Size(472, 40);
            this.btnNullOperators.TabIndex = 2;
            this.btnNullOperators.Text = "Mutate NULL Checks";
            this.btnNullOperators.UseVisualStyleBackColor = true;
            this.btnNullOperators.Click += new System.EventHandler(this.btnNullOperators_Click);
            // 
            // btnRelationalOperators
            // 
            this.btnRelationalOperators.Enabled = false;
            this.btnRelationalOperators.Location = new System.Drawing.Point(12, 254);
            this.btnRelationalOperators.Name = "btnRelationalOperators";
            this.btnRelationalOperators.Size = new System.Drawing.Size(472, 40);
            this.btnRelationalOperators.TabIndex = 2;
            this.btnRelationalOperators.Text = "Mutate Relational Clauses";
            this.btnRelationalOperators.UseVisualStyleBackColor = true;
            this.btnRelationalOperators.Click += new System.EventHandler(this.btnRelationalOperators_Click);
            // 
            // btnLogicalOperators
            // 
            this.btnLogicalOperators.Enabled = false;
            this.btnLogicalOperators.Location = new System.Drawing.Point(12, 320);
            this.btnLogicalOperators.Name = "btnLogicalOperators";
            this.btnLogicalOperators.Size = new System.Drawing.Size(472, 40);
            this.btnLogicalOperators.TabIndex = 2;
            this.btnLogicalOperators.Text = "Mutate Logical Clauses";
            this.btnLogicalOperators.UseVisualStyleBackColor = true;
            this.btnLogicalOperators.Click += new System.EventHandler(this.btnLogicalOperators_Click);
            // 
            // btnOrdOperators
            // 
            this.btnOrdOperators.Enabled = false;
            this.btnOrdOperators.Location = new System.Drawing.Point(12, 130);
            this.btnOrdOperators.Name = "btnOrdOperators";
            this.btnOrdOperators.Size = new System.Drawing.Size(472, 40);
            this.btnOrdOperators.TabIndex = 2;
            this.btnOrdOperators.Text = "Mutate ORDER BY/ORDER BY DESC Clauses";
            this.btnOrdOperators.UseVisualStyleBackColor = true;
            this.btnOrdOperators.Click += new System.EventHandler(this.btnOrdOperators_Click);
            // 
            // btnUniOperators
            // 
            this.btnUniOperators.Enabled = false;
            this.btnUniOperators.Location = new System.Drawing.Point(12, 194);
            this.btnUniOperators.Name = "btnUniOperators";
            this.btnUniOperators.Size = new System.Drawing.Size(472, 40);
            this.btnUniOperators.TabIndex = 2;
            this.btnUniOperators.Text = "Mutate UNION/UNION ALL Clauses";
            this.btnUniOperators.UseVisualStyleBackColor = true;
            this.btnUniOperators.Click += new System.EventHandler(this.btnUniOperators_Click);
            // 
            // btnSelOperator
            // 
            this.btnSelOperator.Enabled = false;
            this.btnSelOperator.Location = new System.Drawing.Point(12, 70);
            this.btnSelOperator.Name = "btnSelOperator";
            this.btnSelOperator.Size = new System.Drawing.Size(472, 40);
            this.btnSelOperator.TabIndex = 2;
            this.btnSelOperator.Text = "Mutate SELECT/SELECT DISTINCT Clauses";
            this.btnSelOperator.UseVisualStyleBackColor = true;
            this.btnSelOperator.Click += new System.EventHandler(this.btnSelOperator_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(390, 13);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 29);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = " Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 13);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(372, 27);
            this.txtFilePath.TabIndex = 0;
            // 
            // rtbCode
            // 
            this.rtbCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbCode.Location = new System.Drawing.Point(0, 0);
            this.rtbCode.Name = "rtbCode";
            this.rtbCode.ReadOnly = true;
            this.rtbCode.Size = new System.Drawing.Size(428, 453);
            this.rtbCode.TabIndex = 0;
            this.rtbCode.Text = "";
            // 
            // formSqlMutatorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 453);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(950, 500);
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "formSqlMutatorMainForm";
            this.Text = "SQL Mutator Main Form";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.RichTextBox rtbCode;
        private System.Windows.Forms.Button btnSelOperator;
        private System.Windows.Forms.Button btnOrdOperators;
        private System.Windows.Forms.Button btnNullOperators;
        private System.Windows.Forms.Button btnRelationalOperators;
        private System.Windows.Forms.Button btnLogicalOperators;
        private System.Windows.Forms.Button btnUniOperators;
    }
}


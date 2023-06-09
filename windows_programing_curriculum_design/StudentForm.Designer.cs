﻿namespace windows_programing_curriculum_design
{
    partial class StudentForm
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
            this.database2DataSet = new windows_programing_curriculum_design.Database2DataSet();
            this.database2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tmpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tmpTableAdapter = new windows_programing_curriculum_design.Database2DataSetTableAdapters.tmpTableAdapter();
            this.tableAdapterManager = new windows_programing_curriculum_design.Database2DataSetTableAdapters.TableAdapterManager();
            this.lightAndWaterButten = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.accommodationButten = new System.Windows.Forms.Button();
            this.maintainButten = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmpBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // database2DataSet
            // 
            this.database2DataSet.DataSetName = "Database2DataSet";
            this.database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database2DataSetBindingSource
            // 
            this.database2DataSetBindingSource.DataSource = this.database2DataSet;
            this.database2DataSetBindingSource.Position = 0;
            // 
            // tmpBindingSource
            // 
            this.tmpBindingSource.DataMember = "tmp";
            this.tmpBindingSource.DataSource = this.database2DataSet;
            // 
            // tmpTableAdapter
            // 
            this.tmpTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tmpTableAdapter = this.tmpTableAdapter;
            this.tableAdapterManager.UpdateOrder = windows_programing_curriculum_design.Database2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lightAndWaterButten
            // 
            this.lightAndWaterButten.Location = new System.Drawing.Point(3, 3);
            this.lightAndWaterButten.Name = "lightAndWaterButten";
            this.lightAndWaterButten.Size = new System.Drawing.Size(174, 105);
            this.lightAndWaterButten.TabIndex = 1;
            this.lightAndWaterButten.Text = "水电";
            this.lightAndWaterButten.UseVisualStyleBackColor = true;
            this.lightAndWaterButten.Click += new System.EventHandler(this.lightAndWaterButten_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.Controls.Add(this.lightAndWaterButten, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.accommodationButten, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.maintainButten, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(477, 111);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // accommodationButten
            // 
            this.accommodationButten.Location = new System.Drawing.Point(183, 3);
            this.accommodationButten.Name = "accommodationButten";
            this.accommodationButten.Size = new System.Drawing.Size(174, 105);
            this.accommodationButten.TabIndex = 2;
            this.accommodationButten.Text = "住宿调整";
            this.accommodationButten.UseVisualStyleBackColor = true;
            // 
            // maintainButten
            // 
            this.maintainButten.Location = new System.Drawing.Point(363, 3);
            this.maintainButten.Name = "maintainButten";
            this.maintainButten.Size = new System.Drawing.Size(110, 105);
            this.maintainButten.TabIndex = 3;
            this.maintainButten.Text = "报修";
            this.maintainButten.UseVisualStyleBackColor = true;
            this.maintainButten.Click += new System.EventHandler(this.maintainButten_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(492, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.15991F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.84009F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(483, 646);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(3, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(477, 478);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(-2, -1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(978, 652);
            this.tableLayoutPanel3.TabIndex = 4;
            this.tableLayoutPanel3.SizeChanged += new System.EventHandler(this.tableLayoutPanel3_SizeChanged);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 650);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.SizeChanged += new System.EventHandler(this.StudentForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmpBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource database2DataSetBindingSource;
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource tmpBindingSource;
        private Database2DataSetTableAdapters.tmpTableAdapter tmpTableAdapter;
        private Database2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button lightAndWaterButten;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button accommodationButten;
        private System.Windows.Forms.Button maintainButten;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FontDialog fontDialog1;

        //用户自定义控件窗口
        private StudentLightAndWaterForm studentLightAndWaterForm=new StudentLightAndWaterForm();
        private StudentMaintainForm studentMaintainForm=new StudentMaintainForm();
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
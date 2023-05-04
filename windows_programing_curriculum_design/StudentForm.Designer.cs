namespace windows_programing_curriculum_design
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
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmpBindingSource)).BeginInit();
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
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmpBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource database2DataSetBindingSource;
        private Database2DataSet database2DataSet;
        private System.Windows.Forms.BindingSource tmpBindingSource;
        private Database2DataSetTableAdapters.tmpTableAdapter tmpTableAdapter;
        private Database2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}
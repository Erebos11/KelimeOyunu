namespace final_ingilizce_sözlük
{
    partial class mesajgoruntule
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
            this.kullaniciDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullaniciDataSet1 = new final_ingilizce_sözlük.kullaniciDataSet1();
            this.kullaniciDataSet = new final_ingilizce_sözlük.kullaniciDataSet();
            this.kullaniciDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullaniciDataSet2 = new final_ingilizce_sözlük.kullaniciDataSet2();
            this.kullaniciDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciDataSet1BindingSource
            // 
            this.kullaniciDataSet1BindingSource.DataSource = this.kullaniciDataSet1;
            this.kullaniciDataSet1BindingSource.Position = 0;
            // 
            // kullaniciDataSet1
            // 
            this.kullaniciDataSet1.DataSetName = "kullaniciDataSet1";
            this.kullaniciDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciDataSet
            // 
            this.kullaniciDataSet.DataSetName = "kullaniciDataSet";
            this.kullaniciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciDataSetBindingSource
            // 
            this.kullaniciDataSetBindingSource.DataSource = this.kullaniciDataSet;
            this.kullaniciDataSetBindingSource.Position = 0;
            // 
            // kullaniciDataSet2
            // 
            this.kullaniciDataSet2.DataSetName = "kullaniciDataSet2";
            this.kullaniciDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciDataSet2BindingSource
            // 
            this.kullaniciDataSet2BindingSource.DataSource = this.kullaniciDataSet2;
            this.kullaniciDataSet2BindingSource.Position = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.DataSource = this.kullaniciDataSet2BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(88, 219);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(551, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // mesajgoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Name = "mesajgoruntule";
            this.Text = "mesajgoruntule";
            this.Load += new System.EventHandler(this.mesajgoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource kullaniciDataSetBindingSource;
        private kullaniciDataSet kullaniciDataSet;
        private System.Windows.Forms.BindingSource kullaniciDataSet1BindingSource;
        private kullaniciDataSet1 kullaniciDataSet1;
        private System.Windows.Forms.BindingSource kullaniciDataSet2BindingSource;
        private kullaniciDataSet2 kullaniciDataSet2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
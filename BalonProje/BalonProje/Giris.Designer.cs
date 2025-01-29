namespace BalonProje
{
    partial class Giris
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.playerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLGECMISOYUNLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bALONPROJEDataSet1 = new BalonProje.BALONPROJEDataSet1();
            this.bALONPROJEDataSet = new BalonProje.BALONPROJEDataSet();
            this.bALONPROJEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bALONPROJEDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_GECMISOYUNLARTableAdapter = new BalonProje.BALONPROJEDataSet1TableAdapters.TBL_GECMISOYUNLARTableAdapter();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLGECMISOYUNLARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bALONPROJEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bALONPROJEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bALONPROJEDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bALONPROJEDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.btnPlay.Location = new System.Drawing.Point(471, 197);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(156, 55);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(460, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 29);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(378, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(358, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter your name to start the game.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerNameDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLGECMISOYUNLARBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(21, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(293, 354);
            this.dataGridView1.TabIndex = 5;
            // 
            // playerNameDataGridViewTextBoxColumn
            // 
            this.playerNameDataGridViewTextBoxColumn.DataPropertyName = "PlayerName";
            this.playerNameDataGridViewTextBoxColumn.HeaderText = "PlayerName";
            this.playerNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
            this.playerNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            // 
            // tBLGECMISOYUNLARBindingSource
            // 
            this.tBLGECMISOYUNLARBindingSource.DataMember = "TBL_GECMISOYUNLAR";
            this.tBLGECMISOYUNLARBindingSource.DataSource = this.bALONPROJEDataSet1;
            // 
            // bALONPROJEDataSet1
            // 
            this.bALONPROJEDataSet1.DataSetName = "BALONPROJEDataSet1";
            this.bALONPROJEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bALONPROJEDataSet
            // 
            this.bALONPROJEDataSet.DataSetName = "BALONPROJEDataSet";
            this.bALONPROJEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bALONPROJEDataSetBindingSource
            // 
            this.bALONPROJEDataSetBindingSource.DataSource = this.bALONPROJEDataSet;
            this.bALONPROJEDataSetBindingSource.Position = 0;
//            this.bALONPROJEDataSetBindingSource.CurrentChanged += new System.EventHandler(this.bALONPROJEDataSetBindingSource_CurrentChanged);
            // 
            // bALONPROJEDataSetBindingSource1
            // 
            this.bALONPROJEDataSetBindingSource1.DataSource = this.bALONPROJEDataSet;
            this.bALONPROJEDataSetBindingSource1.Position = 0;
            // 
            // tBL_GECMISOYUNLARTableAdapter
            // 
            this.tBL_GECMISOYUNLARTableAdapter.ClearBeforeFill = true;
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.btnExit.Location = new System.Drawing.Point(471, 270);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 55);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "EXİT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(746, 466);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPlay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLGECMISOYUNLARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bALONPROJEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bALONPROJEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bALONPROJEDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bALONPROJEDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bALONPROJEDataSetBindingSource;
        private BALONPROJEDataSet bALONPROJEDataSet;
        private System.Windows.Forms.BindingSource bALONPROJEDataSetBindingSource1;
        private BALONPROJEDataSet1 bALONPROJEDataSet1;
        private System.Windows.Forms.BindingSource tBLGECMISOYUNLARBindingSource;
        private BALONPROJEDataSet1TableAdapters.TBL_GECMISOYUNLARTableAdapter tBL_GECMISOYUNLARTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExit;
    }
}
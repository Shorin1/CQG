namespace CQG
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
            this.layout = new System.Windows.Forms.DataGridView();
            this.goalLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.hiScoreLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.AllowUserToAddRows = false;
            this.layout.AllowUserToDeleteRows = false;
            this.layout.AllowUserToResizeColumns = false;
            this.layout.AllowUserToResizeRows = false;
            this.layout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.layout.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.layout.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.layout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.layout.ColumnHeadersVisible = false;
            this.layout.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.layout.Location = new System.Drawing.Point(44, 36);
            this.layout.MultiSelect = false;
            this.layout.Name = "layout";
            this.layout.ReadOnly = true;
            this.layout.RowHeadersVisible = false;
            this.layout.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.layout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.layout.Size = new System.Drawing.Size(200, 400);
            this.layout.TabIndex = 0;
            this.layout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress);
            // 
            // goalLabel
            // 
            this.goalLabel.AutoSize = true;
            this.goalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goalLabel.Location = new System.Drawing.Point(297, 308);
            this.goalLabel.Name = "goalLabel";
            this.goalLabel.Size = new System.Drawing.Size(0, 16);
            this.goalLabel.TabIndex = 1;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedLabel.Location = new System.Drawing.Point(313, 254);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(0, 16);
            this.speedLabel.TabIndex = 2;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.Location = new System.Drawing.Point(303, 49);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 16);
            this.scoreLabel.TabIndex = 3;
            // 
            // hiScoreLabel
            // 
            this.hiScoreLabel.AutoSize = true;
            this.hiScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hiScoreLabel.Location = new System.Drawing.Point(297, 100);
            this.hiScoreLabel.Name = "hiScoreLabel";
            this.hiScoreLabel.Size = new System.Drawing.Size(0, 16);
            this.hiScoreLabel.TabIndex = 4;
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.healthLabel.Location = new System.Drawing.Point(303, 177);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(0, 16);
            this.healthLabel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(292, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Health";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::CQG.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(404, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.hiScoreLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.goalLabel);
            this.Controls.Add(this.layout);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 498);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 498);
            this.Name = "Form1";
            this.Text = "Brick game - Car Racing";
            ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView layout;
        private System.Windows.Forms.Label goalLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label hiScoreLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label label1;
    }
}


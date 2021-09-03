
namespace copy2
{
    partial class frmConfigurApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigurApp));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdImportarDB = new copy2.botonPer();
            this.cmdExportarDB = new copy2.botonPer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmdImportarDB);
            this.groupBox1.Controls.Add(this.cmdExportarDB);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Botones";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // cmdImportarDB
            // 
            this.cmdImportarDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImportarDB.Location = new System.Drawing.Point(262, 86);
            this.cmdImportarDB.Name = "cmdImportarDB";
            this.cmdImportarDB.Size = new System.Drawing.Size(111, 29);
            this.cmdImportarDB.TabIndex = 1;
            this.cmdImportarDB.Text = "Importar";
            this.cmdImportarDB.UseVisualStyleBackColor = true;
            this.cmdImportarDB.Click += new System.EventHandler(this.cmdImportarDB_Click);
            // 
            // cmdExportarDB
            // 
            this.cmdExportarDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportarDB.Location = new System.Drawing.Point(145, 86);
            this.cmdExportarDB.Name = "cmdExportarDB";
            this.cmdExportarDB.Size = new System.Drawing.Size(111, 29);
            this.cmdExportarDB.TabIndex = 0;
            this.cmdExportarDB.Text = "Exportar";
            this.cmdExportarDB.UseVisualStyleBackColor = true;
            this.cmdExportarDB.Click += new System.EventHandler(this.cmdExportarDB_Click);
            // 
            // frmConfigurApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 523);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConfigurApp";
            this.Text = "Configuración CopyApp";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private botonPer cmdImportarDB;
        private botonPer cmdExportarDB;
    }
}
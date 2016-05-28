namespace Sample
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this._ribbon = new RibbonLib.Ribbon();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(517, 100);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this._ribbon;
            this.propertyGrid1.Size = new System.Drawing.Size(267, 461);
            this.propertyGrid1.TabIndex = 1;
            // 
            // ribbon
            // 
            this._ribbon.Location = new System.Drawing.Point(0, 0);
            this._ribbon.Minimized = false;
            this._ribbon.Name = "ribbon";
            this._ribbon.ResourceName = "Sample.RibbonMarkup.ribbon";
            this._ribbon.ShortcutTableResourceName = null;
            this._ribbon.Size = new System.Drawing.Size(784, 100);
            this._ribbon.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this._ribbon);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private RibbonLib.Ribbon _ribbon;
    }
}


namespace DirectorioWF
{
    partial class FormPrincipal
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
            button_gotoDirectory = new Button();
            textBoxContenidoArchivo = new TextBox();
            SuspendLayout();
            // 
            // button_gotoDirectory
            // 
            button_gotoDirectory.Location = new Point(44, 45);
            button_gotoDirectory.Name = "button_gotoDirectory";
            button_gotoDirectory.Size = new Size(157, 27);
            button_gotoDirectory.TabIndex = 1;
            button_gotoDirectory.Text = "Ir al directorio";
            button_gotoDirectory.UseVisualStyleBackColor = true;
            button_gotoDirectory.Click += Button_gotoDirectory_Click;
            // 
            // textBoxContenidoArchivo
            // 
            textBoxContenidoArchivo.Location = new Point(44, 100);
            textBoxContenidoArchivo.Multiline = true;
            textBoxContenidoArchivo.Name = "textBoxContenidoArchivo";
            textBoxContenidoArchivo.Size = new Size(683, 270);
            textBoxContenidoArchivo.TabIndex = 3;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxContenidoArchivo);
            Controls.Add(button_gotoDirectory);
            Name = "FormPrincipal";
            Text = "Manejo de directorios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_gotoDirectory;
        private TextBox textBoxContenidoArchivo;
    }
}

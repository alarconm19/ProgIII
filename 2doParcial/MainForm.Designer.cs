namespace _2doParcial
{
    partial class MainForm
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
            textBox_Texto = new TextBox();
            label_DatosdelTexto = new Label();
            dataGridView_Estadisticas = new DataGridView();
            button_CargarTexto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Estadisticas).BeginInit();
            SuspendLayout();
            //
            // textBox_Texto
            //
            textBox_Texto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Texto.BackColor = SystemColors.ScrollBar;
            textBox_Texto.Location = new Point(12, 43);
            textBox_Texto.Multiline = true;
            textBox_Texto.Name = "textBox_Texto";
            textBox_Texto.ReadOnly = true;
            textBox_Texto.Size = new Size(810, 275);
            textBox_Texto.TabIndex = 0;
            //
            // label_DatosdelTexto
            //
            label_DatosdelTexto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_DatosdelTexto.AutoSize = true;
            label_DatosdelTexto.BackColor = SystemColors.WindowFrame;
            label_DatosdelTexto.Font = new Font("Segoe UI", 13F);
            label_DatosdelTexto.ForeColor = SystemColors.Info;
            label_DatosdelTexto.Location = new Point(12, 9);
            label_DatosdelTexto.Name = "label_DatosdelTexto";
            label_DatosdelTexto.Size = new Size(213, 25);
            label_DatosdelTexto.TabIndex = 1;
            label_DatosdelTexto.Text = "[ Words: 0, Characters: 0 ]";
            label_DatosdelTexto.TextAlign = ContentAlignment.MiddleCenter;
            //
            // dataGridView_Estadisticas
            //
            dataGridView_Estadisticas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_Estadisticas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Estadisticas.BackgroundColor = SystemColors.Control;
            dataGridView_Estadisticas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Estadisticas.Location = new Point(11, 324);
            dataGridView_Estadisticas.Name = "dataGridView_Estadisticas";
            dataGridView_Estadisticas.ReadOnly = true;
            dataGridView_Estadisticas.RowHeadersWidth = 51;
            dataGridView_Estadisticas.Size = new Size(810, 225);
            dataGridView_Estadisticas.TabIndex = 2;
            //
            // button_CargarTexto
            //
            button_CargarTexto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_CargarTexto.Location = new Point(734, 12);
            button_CargarTexto.Name = "button_CargarTexto";
            button_CargarTexto.Size = new Size(88, 23);
            button_CargarTexto.TabIndex = 3;
            button_CargarTexto.Text = "Cargar texto";
            button_CargarTexto.UseVisualStyleBackColor = true;
            button_CargarTexto.Click += Button_CargarTexto_Click;
            //
            // MainForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(834, 561);
            Controls.Add(button_CargarTexto);
            Controls.Add(dataGridView_Estadisticas);
            Controls.Add(label_DatosdelTexto);
            Controls.Add(textBox_Texto);
            ForeColor = SystemColors.InfoText;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estadísticas de Texto";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Estadisticas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Texto;
        private Label label_DatosdelTexto;
        private DataGridView dataGridView_Estadisticas;
        private Button button_CargarTexto;
    }
}
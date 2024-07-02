namespace JuegoSimónDiceWF
{
    partial class Juego
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
            button_Amarillo = new Button();
            button_Azul = new Button();
            button_Rojo = new Button();
            button_Verde = new Button();
            button_Comenzar = new Button();
            SuspendLayout();
            // 
            // button_Amarillo
            // 
            button_Amarillo.BackColor = Color.Yellow;
            button_Amarillo.Location = new Point(114, 84);
            button_Amarillo.Margin = new Padding(3, 4, 3, 4);
            button_Amarillo.Name = "button_Amarillo";
            button_Amarillo.Size = new Size(149, 133);
            button_Amarillo.TabIndex = 0;
            button_Amarillo.Text = "AMARILLO";
            button_Amarillo.UseVisualStyleBackColor = false;
            button_Amarillo.Click += Button_Amarillo_Click;
            // 
            // button_Azul
            // 
            button_Azul.BackColor = Color.Blue;
            button_Azul.Location = new Point(324, 84);
            button_Azul.Margin = new Padding(3, 4, 3, 4);
            button_Azul.Name = "button_Azul";
            button_Azul.Size = new Size(152, 133);
            button_Azul.TabIndex = 1;
            button_Azul.Text = "AZUL";
            button_Azul.UseVisualStyleBackColor = false;
            button_Azul.Click += Button_Azul_Click;
            // 
            // button_Rojo
            // 
            button_Rojo.BackColor = Color.Red;
            button_Rojo.Location = new Point(114, 255);
            button_Rojo.Margin = new Padding(3, 4, 3, 4);
            button_Rojo.Name = "button_Rojo";
            button_Rojo.Size = new Size(149, 133);
            button_Rojo.TabIndex = 2;
            button_Rojo.Text = "ROJO";
            button_Rojo.UseVisualStyleBackColor = false;
            button_Rojo.Click += Button_Rojo_Click;
            // 
            // button_Verde
            // 
            button_Verde.BackColor = Color.Green;
            button_Verde.Location = new Point(324, 255);
            button_Verde.Margin = new Padding(3, 4, 3, 4);
            button_Verde.Name = "button_Verde";
            button_Verde.Size = new Size(152, 133);
            button_Verde.TabIndex = 3;
            button_Verde.Text = "VERDE";
            button_Verde.UseVisualStyleBackColor = false;
            button_Verde.Click += Button_Verde_Click;
            // 
            // button_Comenzar
            // 
            button_Comenzar.BackColor = SystemColors.WindowText;
            button_Comenzar.ForeColor = SystemColors.Control;
            button_Comenzar.Location = new Point(250, 12);
            button_Comenzar.Margin = new Padding(3, 4, 3, 4);
            button_Comenzar.Name = "button_Comenzar";
            button_Comenzar.Size = new Size(89, 64);
            button_Comenzar.TabIndex = 4;
            button_Comenzar.Text = "Comenzar el juego";
            button_Comenzar.UseVisualStyleBackColor = false;
            button_Comenzar.Click += Button_Comenzar_Click;
            // 
            // Juego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(592, 433);
            Controls.Add(button_Comenzar);
            Controls.Add(button_Verde);
            Controls.Add(button_Rojo);
            Controls.Add(button_Azul);
            Controls.Add(button_Amarillo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Juego";
            Text = "Simón Dice";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Amarillo;
        private Button button_Azul;
        private Button button_Rojo;
        private Button button_Verde;
        private Button button_Comenzar;
    }
}

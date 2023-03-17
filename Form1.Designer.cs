namespace editor_rrc
{
    partial class Form1
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
            btn_editor = new Button();
            btn_guardar = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btn_editor
            // 
            btn_editor.Location = new Point(12, 21);
            btn_editor.Name = "btn_editor";
            btn_editor.Size = new Size(160, 42);
            btn_editor.TabIndex = 0;
            btn_editor.Text = "ABRIR ARCHIVO";
            btn_editor.UseVisualStyleBackColor = true;
            btn_editor.Click += btn_editor_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(178, 21);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(160, 42);
            btn_guardar.TabIndex = 1;
            btn_guardar.Text = "GUARDAR ARCHIVO";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 69);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 369);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(btn_guardar);
            Controls.Add(btn_editor);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_editor;
        private Button btn_guardar;
        private RichTextBox richTextBox1;
    }
}
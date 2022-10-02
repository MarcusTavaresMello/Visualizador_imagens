namespace WinFormsApp
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
            this.imagemlistBox1 = new System.Windows.Forms.ListBox();
            this.favoritoslistBox1 = new System.Windows.Forms.ListBox();
            this.adicionarbutton1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imagemlistBox1
            // 
            this.imagemlistBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagemlistBox1.BackColor = System.Drawing.SystemColors.Window;
            this.imagemlistBox1.FormattingEnabled = true;
            this.imagemlistBox1.ItemHeight = 15;
            this.imagemlistBox1.Location = new System.Drawing.Point(12, 12);
            this.imagemlistBox1.Name = "imagemlistBox1";
            this.imagemlistBox1.Size = new System.Drawing.Size(422, 94);
            this.imagemlistBox1.TabIndex = 0;
            this.imagemlistBox1.SelectedIndexChanged += new System.EventHandler(this.imagemlistBox1_SelectedIndexChanged);
            // 
            // favoritoslistBox1
            // 
            this.favoritoslistBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favoritoslistBox1.FormattingEnabled = true;
            this.favoritoslistBox1.ItemHeight = 15;
            this.favoritoslistBox1.Location = new System.Drawing.Point(12, 151);
            this.favoritoslistBox1.Name = "favoritoslistBox1";
            this.favoritoslistBox1.Size = new System.Drawing.Size(422, 94);
            this.favoritoslistBox1.TabIndex = 1;
            this.favoritoslistBox1.SelectedIndexChanged += new System.EventHandler(this.favoritoslistBox1_SelectedIndexChanged);
            // 
            // adicionarbutton1
            // 
            this.adicionarbutton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.adicionarbutton1.ForeColor = System.Drawing.Color.Black;
            this.adicionarbutton1.Location = new System.Drawing.Point(116, 112);
            this.adicionarbutton1.Name = "adicionarbutton1";
            this.adicionarbutton1.Size = new System.Drawing.Size(199, 33);
            this.adicionarbutton1.TabIndex = 2;
            this.adicionarbutton1.Text = "Adicionar aos Favoritos";
            this.adicionarbutton1.UseVisualStyleBackColor = true;
            this.adicionarbutton1.Click += new System.EventHandler(this.adicionarbutton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 320);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(446, 593);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adicionarbutton1);
            this.Controls.Add(this.favoritoslistBox1);
            this.Controls.Add(this.imagemlistBox1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "Form1";
            this.Text = "Visualizador de Imagens";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox imagemlistBox1;
        private ListBox favoritoslistBox1;
        private Button adicionarbutton1;
        private PictureBox pictureBox1;
    }
}
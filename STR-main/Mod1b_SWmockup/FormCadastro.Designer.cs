namespace Mod1b_SWmockup
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel3 = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel4 = new ReaLTaiizor.Controls.FoxLabel();
            MUs_cadastrados = new ListBox();
            buttonAdd = new ReaLTaiizor.Controls.Button();
            textBoxDescricao = new TextBox();
            textBoxApelido = new TextBox();
            textBoxCurto = new TextBox();
            foxLabel6 = new ReaLTaiizor.Controls.FoxLabel();
            buttonRemove = new ReaLTaiizor.Controls.Button();
            foxLabel7 = new ReaLTaiizor.Controls.FoxLabel();
            metroDivider1 = new ReaLTaiizor.Controls.MetroDivider();
            labelId = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            textBoxCorrente = new TextBox();
            foxLabel5 = new ReaLTaiizor.Controls.FoxLabel();
            textBoxTensao = new TextBox();
            foxLabel = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel9 = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel10 = new ReaLTaiizor.Controls.FoxLabel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(220, 23, 24, 29);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(bigLabel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 81);
            panel1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(21, 16);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            bigLabel2.ForeColor = Color.White;
            bigLabel2.Location = new Point(77, 13);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(349, 57);
            bigLabel2.TabIndex = 1;
            bigLabel2.Text = "CADASTRO MUs";
            // 
            // foxLabel1
            // 
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Segoe UI", 10F);
            foxLabel1.ForeColor = Color.FromArgb(250, 23, 24, 29);
            foxLabel1.Location = new Point(21, 107);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(160, 37);
            foxLabel1.TabIndex = 6;
            foxLabel1.Text = "MU ID:";
            // 
            // foxLabel2
            // 
            foxLabel2.BackColor = Color.Transparent;
            foxLabel2.Font = new Font("Segoe UI", 10F);
            foxLabel2.ForeColor = Color.FromArgb(250, 23, 24, 29);
            foxLabel2.Location = new Point(18, 315);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(160, 37);
            foxLabel2.TabIndex = 7;
            foxLabel2.Text = "Apelido MU:";
            // 
            // foxLabel3
            // 
            foxLabel3.BackColor = Color.Transparent;
            foxLabel3.Font = new Font("Segoe UI", 10F);
            foxLabel3.ForeColor = Color.FromArgb(250, 23, 24, 29);
            foxLabel3.Location = new Point(18, 361);
            foxLabel3.Name = "foxLabel3";
            foxLabel3.Size = new Size(160, 37);
            foxLabel3.TabIndex = 8;
            foxLabel3.Text = "Descrição da MU:";
            // 
            // foxLabel4
            // 
            foxLabel4.BackColor = Color.Transparent;
            foxLabel4.Font = new Font("Segoe UI", 10F);
            foxLabel4.ForeColor = Color.FromArgb(250, 23, 24, 29);
            foxLabel4.Location = new Point(18, 269);
            foxLabel4.Name = "foxLabel4";
            foxLabel4.Size = new Size(160, 37);
            foxLabel4.TabIndex = 9;
            foxLabel4.Text = "Valor de curto:";
            // 
            // MUs_cadastrados
            // 
            MUs_cadastrados.BackColor = Color.WhiteSmoke;
            MUs_cadastrados.BorderStyle = BorderStyle.FixedSingle;
            MUs_cadastrados.Dock = DockStyle.Right;
            MUs_cadastrados.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MUs_cadastrados.FormattingEnabled = true;
            MUs_cadastrados.ItemHeight = 37;
            MUs_cadastrados.Location = new Point(688, 81);
            MUs_cadastrados.Name = "MUs_cadastrados";
            MUs_cadastrados.Size = new Size(512, 574);
            MUs_cadastrados.TabIndex = 10;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Transparent;
            buttonAdd.BorderColor = Color.FromArgb(220, 23, 24, 29);
            buttonAdd.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            buttonAdd.EnteredColor = Color.FromArgb(32, 34, 37);
            buttonAdd.Font = new Font("Microsoft Sans Serif", 12F);
            buttonAdd.Image = null;
            buttonAdd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAdd.InactiveColor = Color.FromArgb(220, 23, 24, 29);
            buttonAdd.Location = new Point(82, 527);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.PressedBorderColor = Color.Black;
            buttonAdd.PressedColor = Color.Snow;
            buttonAdd.Size = new Size(150, 51);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Adicionar";
            buttonAdd.TextAlignment = StringAlignment.Center;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.Location = new Point(174, 357);
            textBoxDescricao.Multiline = true;
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(291, 93);
            textBoxDescricao.TabIndex = 13;
            // 
            // textBoxApelido
            // 
            textBoxApelido.Location = new Point(174, 315);
            textBoxApelido.Name = "textBoxApelido";
            textBoxApelido.Size = new Size(291, 27);
            textBoxApelido.TabIndex = 14;
            // 
            // textBoxCurto
            // 
            textBoxCurto.Location = new Point(174, 269);
            textBoxCurto.Name = "textBoxCurto";
            textBoxCurto.Size = new Size(214, 27);
            textBoxCurto.TabIndex = 15;
            // 
            // foxLabel6
            // 
            foxLabel6.BackColor = Color.Transparent;
            foxLabel6.Font = new Font("Segoe UI", 16F);
            foxLabel6.ForeColor = Color.FromArgb(192, 0, 0);
            foxLabel6.Location = new Point(394, 269);
            foxLabel6.Name = "foxLabel6";
            foxLabel6.Size = new Size(19, 37);
            foxLabel6.TabIndex = 17;
            foxLabel6.Text = "*";
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.Transparent;
            buttonRemove.BorderColor = Color.FromArgb(220, 23, 24, 29);
            buttonRemove.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            buttonRemove.EnteredColor = Color.Maroon;
            buttonRemove.Font = new Font("Microsoft Sans Serif", 12F);
            buttonRemove.Image = null;
            buttonRemove.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRemove.InactiveColor = Color.Brown;
            buttonRemove.Location = new Point(315, 527);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.PressedBorderColor = Color.FromArgb(165, 37, 37);
            buttonRemove.PressedColor = Color.FromArgb(165, 37, 37);
            buttonRemove.Size = new Size(150, 51);
            buttonRemove.TabIndex = 18;
            buttonRemove.Text = "Remover";
            buttonRemove.TextAlignment = StringAlignment.Center;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // foxLabel7
            // 
            foxLabel7.BackColor = Color.Transparent;
            foxLabel7.Font = new Font("Segoe UI", 8F);
            foxLabel7.ForeColor = Color.FromArgb(250, 23, 24, 29);
            foxLabel7.Location = new Point(315, 583);
            foxLabel7.Name = "foxLabel7";
            foxLabel7.Size = new Size(222, 37);
            foxLabel7.TabIndex = 19;
            foxLabel7.Text = "*Selecione a MU que deseja remover.";
            // 
            // metroDivider1
            // 
            metroDivider1.IsDerivedStyle = true;
            metroDivider1.Location = new Point(14, 152);
            metroDivider1.Name = "metroDivider1";
            metroDivider1.Orientation = ReaLTaiizor.Enum.Metro.DividerStyle.Horizontal;
            metroDivider1.Size = new Size(472, 4);
            metroDivider1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroDivider1.StyleManager = null;
            metroDivider1.TabIndex = 21;
            metroDivider1.Text = "metroDivider1";
            metroDivider1.ThemeAuthor = "Taiizor";
            metroDivider1.ThemeName = "MetroLight";
            metroDivider1.Thickness = 1;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.BackColor = Color.Transparent;
            labelId.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelId.ForeColor = Color.FromArgb(76, 76, 77);
            labelId.Location = new Point(149, 107);
            labelId.Name = "labelId";
            labelId.Size = new Size(32, 25);
            labelId.TabIndex = 22;
            labelId.Text = "ID";
            // 
            // textBoxCorrente
            // 
            textBoxCorrente.Location = new Point(174, 175);
            textBoxCorrente.Name = "textBoxCorrente";
            textBoxCorrente.Size = new Size(214, 27);
            textBoxCorrente.TabIndex = 24;
            textBoxCorrente.MouseCaptureChanged += textBoxCorrente_MouseCaptureChanged;
            // 
            // foxLabel5
            // 
            foxLabel5.BackColor = Color.Transparent;
            foxLabel5.Font = new Font("Segoe UI", 10F);
            foxLabel5.ForeColor = Color.FromArgb(250, 23, 24, 29);
            foxLabel5.Location = new Point(18, 175);
            foxLabel5.Name = "foxLabel5";
            foxLabel5.Size = new Size(160, 37);
            foxLabel5.TabIndex = 23;
            foxLabel5.Text = "Valor de corrente:";
            // 
            // textBoxTensao
            // 
            textBoxTensao.Location = new Point(174, 219);
            textBoxTensao.Name = "textBoxTensao";
            textBoxTensao.Size = new Size(214, 27);
            textBoxTensao.TabIndex = 26;
            // 
            // foxLabel
            // 
            foxLabel.BackColor = Color.Transparent;
            foxLabel.Font = new Font("Segoe UI", 10F);
            foxLabel.ForeColor = Color.FromArgb(250, 23, 24, 29);
            foxLabel.Location = new Point(18, 219);
            foxLabel.Name = "foxLabel";
            foxLabel.Size = new Size(160, 37);
            foxLabel.TabIndex = 25;
            foxLabel.Text = "Valor de tensão:";
            // 
            // foxLabel9
            // 
            foxLabel9.BackColor = Color.Transparent;
            foxLabel9.Font = new Font("Segoe UI", 16F);
            foxLabel9.ForeColor = Color.FromArgb(192, 0, 0);
            foxLabel9.Location = new Point(394, 175);
            foxLabel9.Name = "foxLabel9";
            foxLabel9.Size = new Size(19, 37);
            foxLabel9.TabIndex = 27;
            foxLabel9.Text = "*";
            // 
            // foxLabel10
            // 
            foxLabel10.BackColor = Color.Transparent;
            foxLabel10.Font = new Font("Segoe UI", 16F);
            foxLabel10.ForeColor = Color.FromArgb(192, 0, 0);
            foxLabel10.Location = new Point(394, 219);
            foxLabel10.Name = "foxLabel10";
            foxLabel10.Size = new Size(19, 37);
            foxLabel10.TabIndex = 28;
            foxLabel10.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(361, 219);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 29;
            label1.Text = "(V)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(359, 175);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 30;
            label2.Text = "(A)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(359, 272);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 31;
            label3.Text = "(A)";
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 655);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(foxLabel10);
            Controls.Add(foxLabel9);
            Controls.Add(textBoxTensao);
            Controls.Add(foxLabel);
            Controls.Add(textBoxCorrente);
            Controls.Add(foxLabel5);
            Controls.Add(labelId);
            Controls.Add(metroDivider1);
            Controls.Add(foxLabel7);
            Controls.Add(buttonRemove);
            Controls.Add(foxLabel6);
            Controls.Add(textBoxCurto);
            Controls.Add(textBoxApelido);
            Controls.Add(textBoxDescricao);
            Controls.Add(buttonAdd);
            Controls.Add(MUs_cadastrados);
            Controls.Add(foxLabel4);
            Controls.Add(foxLabel3);
            Controls.Add(foxLabel2);
            Controls.Add(foxLabel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCadastro";
            Text = "FormCadastro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox3;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.FoxLabel foxLabel3;
        private ReaLTaiizor.Controls.FoxLabel foxLabel4;
        private ListBox MUs_cadastrados;
        private ReaLTaiizor.Controls.Button buttonAdd;
        private TextBox textBoxDescricao;
        private TextBox textBoxApelido;
        private TextBox textBoxCurto;
        private ReaLTaiizor.Controls.FoxLabel foxLabel6;
        private ReaLTaiizor.Controls.Button buttonRemove;
        private ReaLTaiizor.Controls.FoxLabel foxLabel7;
        private ReaLTaiizor.Controls.MetroDivider metroDivider1;
        private ReaLTaiizor.Controls.DungeonHeaderLabel labelId;
        private TextBox textBoxCorrente;
        private ReaLTaiizor.Controls.FoxLabel foxLabel5;
        private TextBox textBoxTensao;
        private ReaLTaiizor.Controls.FoxLabel foxLabel;
        private ReaLTaiizor.Controls.FoxLabel foxLabel9;
        private ReaLTaiizor.Controls.FoxLabel foxLabel10;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
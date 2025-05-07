namespace AppAnalisePacotes
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            dataGridView1 = new DataGridView();
            mUBindingSource1 = new BindingSource(components);
            buttonReceba = new ReaLTaiizor.Controls.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            mUBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            ID = new DataGridViewTextBoxColumn();
            objectDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            resourceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            currentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            voltageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            messageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timestampDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mUBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mUBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(foxLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 45);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(23, 24, 29);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(23, 24, 29);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(23, 24, 29);
            nightControlBox1.Location = new Point(1161, 0);
            nightControlBox1.MaximizeHoverColor = Color.Black;
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.Black;
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // foxLabel1
            // 
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel1.ForeColor = Color.FromArgb(76, 88, 100);
            foxLabel1.Location = new Point(69, 12);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(614, 24);
            foxLabel1.TabIndex = 0;
            foxLabel1.Text = "Módulo 1b - Software Auxiliar (recebimento e análise temporal de pacotes)";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, objectDataGridViewTextBoxColumn, resourceDataGridViewTextBoxColumn, currentDataGridViewTextBoxColumn, voltageDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, messageDataGridViewTextBoxColumn, timestampDataGridViewTextBoxColumn });
            dataGridView1.DataSource = mUBindingSource1;
            dataGridView1.Location = new Point(40, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1213, 379);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // mUBindingSource1
            // 
            mUBindingSource1.DataSource = typeof(MU);
            // 
            // buttonReceba
            // 
            buttonReceba.BackColor = Color.Transparent;
            buttonReceba.BorderColor = Color.FromArgb(32, 34, 37);
            buttonReceba.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            buttonReceba.EnteredColor = Color.FromArgb(32, 34, 37);
            buttonReceba.Font = new Font("Microsoft Sans Serif", 12F);
            buttonReceba.Image = null;
            buttonReceba.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReceba.InactiveColor = Color.FromArgb(32, 34, 37);
            buttonReceba.Location = new Point(131, 559);
            buttonReceba.Name = "buttonReceba";
            buttonReceba.PressedBorderColor = Color.FromArgb(165, 37, 37);
            buttonReceba.PressedColor = Color.FromArgb(165, 37, 37);
            buttonReceba.Size = new Size(246, 50);
            buttonReceba.TabIndex = 2;
            buttonReceba.Text = "Executar Recebimento";
            buttonReceba.TextAlignment = StringAlignment.Center;
            buttonReceba.MouseClick += buttonReceba_MouseClick;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLight;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.ControlLight;
            textBox2.Location = new Point(131, 529);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 22);
            textBox2.TabIndex = 6;
            textBox2.Text = "Latência: 0 ms";
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 50F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 50;
            // 
            // objectDataGridViewTextBoxColumn
            // 
            objectDataGridViewTextBoxColumn.DataPropertyName = "Object";
            objectDataGridViewTextBoxColumn.HeaderText = "Object";
            objectDataGridViewTextBoxColumn.MinimumWidth = 6;
            objectDataGridViewTextBoxColumn.Name = "objectDataGridViewTextBoxColumn";
            objectDataGridViewTextBoxColumn.Width = 125;
            // 
            // resourceDataGridViewTextBoxColumn
            // 
            resourceDataGridViewTextBoxColumn.DataPropertyName = "Resource";
            resourceDataGridViewTextBoxColumn.HeaderText = "Resource";
            resourceDataGridViewTextBoxColumn.MinimumWidth = 6;
            resourceDataGridViewTextBoxColumn.Name = "resourceDataGridViewTextBoxColumn";
            resourceDataGridViewTextBoxColumn.Width = 125;
            // 
            // currentDataGridViewTextBoxColumn
            // 
            currentDataGridViewTextBoxColumn.DataPropertyName = "Current";
            currentDataGridViewTextBoxColumn.HeaderText = "Current (A)";
            currentDataGridViewTextBoxColumn.MinimumWidth = 6;
            currentDataGridViewTextBoxColumn.Name = "currentDataGridViewTextBoxColumn";
            currentDataGridViewTextBoxColumn.Width = 125;
            // 
            // voltageDataGridViewTextBoxColumn
            // 
            voltageDataGridViewTextBoxColumn.DataPropertyName = "Voltage";
            voltageDataGridViewTextBoxColumn.HeaderText = "Voltage (V)";
            voltageDataGridViewTextBoxColumn.MinimumWidth = 6;
            voltageDataGridViewTextBoxColumn.Name = "voltageDataGridViewTextBoxColumn";
            voltageDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            messageDataGridViewTextBoxColumn.HeaderText = "Message";
            messageDataGridViewTextBoxColumn.MinimumWidth = 6;
            messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            messageDataGridViewTextBoxColumn.Width = 400;
            // 
            // timestampDataGridViewTextBoxColumn
            // 
            timestampDataGridViewTextBoxColumn.DataPropertyName = "Timestamp";
            timestampDataGridViewTextBoxColumn.HeaderText = "Timestamp";
            timestampDataGridViewTextBoxColumn.MinimumWidth = 6;
            timestampDataGridViewTextBoxColumn.Name = "timestampDataGridViewTextBoxColumn";
            timestampDataGridViewTextBoxColumn.Width = 212;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1300, 700);
            Controls.Add(textBox2);
            Controls.Add(buttonReceba);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mUBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mUBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.Button buttonReceba;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn iEDDataGridViewTextBoxColumn;
        private BindingSource mUBindingSource1;
        private BindingSource mUBindingSource;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn objectDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resourceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn currentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn voltageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timestampDataGridViewTextBoxColumn;
    }
}

using System.Windows.Forms;

namespace ApontamentoDeHoras.APP
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            Atividade = new Label();
            label2 = new Label();
            contagemDeTempo = new RichTextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            buttonAnterior = new Button();
            button_hoje = new Button();
            buttonProximo = new Button();
            dateTimePicker = new DateTimePicker();
            button_comecarOuParar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(218, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(252, 23);
            comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(577, 23);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "Ticket";
            // 
            // Atividade
            // 
            Atividade.AutoSize = true;
            Atividade.Location = new Point(218, 13);
            Atividade.Name = "Atividade";
            Atividade.Size = new Size(57, 15);
            Atividade.TabIndex = 6;
            Atividade.Text = "Atividade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "Descrição";
            // 
            // contagemDeTempo
            // 
            contagemDeTempo.Enabled = false;
            contagemDeTempo.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contagemDeTempo.Location = new Point(595, 31);
            contagemDeTempo.Name = "contagemDeTempo";
            contagemDeTempo.Size = new Size(193, 67);
            contagemDeTempo.TabIndex = 8;
            contagemDeTempo.Text = "00:00:00";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 243);
            dataGridView1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(671, 402);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 10;
            button1.Text = "Lançar horas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += LancarHoras_Click;
            // 
            // buttonAnterior
            // 
            buttonAnterior.Location = new Point(12, 402);
            buttonAnterior.Name = "buttonAnterior";
            buttonAnterior.Size = new Size(38, 23);
            buttonAnterior.TabIndex = 11;
            buttonAnterior.Text = "<";
            buttonAnterior.UseVisualStyleBackColor = true;
            buttonAnterior.Click += buttonAnterior_Click;
            // 
            // button_hoje
            // 
            button_hoje.Location = new Point(546, 402);
            button_hoje.Name = "button_hoje";
            button_hoje.Size = new Size(119, 23);
            button_hoje.TabIndex = 12;
            button_hoje.Text = "Hoje";
            button_hoje.UseVisualStyleBackColor = true;
            button_hoje.Click += buttonHoje_Click;
            // 
            // buttonProximo
            // 
            buttonProximo.Location = new Point(314, 402);
            buttonProximo.Name = "buttonProximo";
            buttonProximo.Size = new Size(40, 23);
            buttonProximo.TabIndex = 13;
            buttonProximo.Text = " >";
            buttonProximo.UseVisualStyleBackColor = true;
            buttonProximo.Click += buttonProximo_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(56, 402);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(252, 23);
            dateTimePicker.TabIndex = 14;
            dateTimePicker.ValueChanged += DateTimePicker_ValueChanged;
            // 
            // button_comecarOuParar
            // 
            button_comecarOuParar.Location = new Point(476, 31);
            button_comecarOuParar.Name = "button_comecarOuParar";
            button_comecarOuParar.Size = new Size(113, 23);
            button_comecarOuParar.TabIndex = 15;
            button_comecarOuParar.Text = "Começar";
            button_comecarOuParar.UseVisualStyleBackColor = true;
            button_comecarOuParar.Click += ComecarOuPararContagem;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 450);
            Controls.Add(button_comecarOuParar);
            Controls.Add(dateTimePicker);
            Controls.Add(buttonProximo);
            Controls.Add(button_hoje);
            Controls.Add(buttonAnterior);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(contagemDeTempo);
            Controls.Add(label2);
            Controls.Add(Atividade);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            Load += OnForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label Atividade;
        private Label label2;
        private RichTextBox contagemDeTempo;
        private DataGridView dataGridView1;
        private Button button1;
        private Button buttonAnterior;
        private Button button_hoje;
        private Button buttonProximo;
        private DateTimePicker dateTimePicker;
        private Button button_comecarOuParar;

        private void AlinharTextoDaContagemDeTempo()
        {
            contagemDeTempo.SelectAll();
            contagemDeTempo.SelectionAlignment = HorizontalAlignment.Center;
            contagemDeTempo.DeselectAll();
        }
    }
}

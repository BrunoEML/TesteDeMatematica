namespace TesteDeMatematica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTempo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoma1 = new System.Windows.Forms.Label();
            this.nudSoma = new System.Windows.Forms.NumericUpDown();
            this.lblSoma2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSubtracao2 = new System.Windows.Forms.Label();
            this.nudSubtracao = new System.Windows.Forms.NumericUpDown();
            this.lblSubtracao1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMultiplicacao2 = new System.Windows.Forms.Label();
            this.nudMultiplicacao = new System.Windows.Forms.NumericUpDown();
            this.lblMultiplicacao1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDivisao2 = new System.Windows.Forms.Label();
            this.nudDivisao = new System.Windows.Forms.NumericUpDown();
            this.lblDivisao1 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubtracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMultiplicacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDivisao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTempo
            // 
            this.lblTempo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(246, 6);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(183, 30);
            this.lblTempo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tempo Restante";
            // 
            // lblSoma1
            // 
            this.lblSoma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoma1.Location = new System.Drawing.Point(54, 75);
            this.lblSoma1.Name = "lblSoma1";
            this.lblSoma1.Size = new System.Drawing.Size(64, 28);
            this.lblSoma1.TabIndex = 2;
            this.lblSoma1.Text = "?";
            this.lblSoma1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudSoma
            // 
            this.nudSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoma.Location = new System.Drawing.Point(334, 73);
            this.nudSoma.Name = "nudSoma";
            this.nudSoma.Size = new System.Drawing.Size(108, 35);
            this.nudSoma.TabIndex = 5;
            this.nudSoma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSoma.ValueChanged += new System.EventHandler(this.ValorCorretoSoma);
            this.nudSoma.Enter += new System.EventHandler(this.Responder_enter);
            // 
            // lblSoma2
            // 
            this.lblSoma2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoma2.Location = new System.Drawing.Point(194, 75);
            this.lblSoma2.Name = "lblSoma2";
            this.lblSoma2.Size = new System.Drawing.Size(64, 28);
            this.lblSoma2.TabIndex = 7;
            this.lblSoma2.Text = "?";
            this.lblSoma2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtracao2
            // 
            this.lblSubtracao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtracao2.Location = new System.Drawing.Point(194, 134);
            this.lblSubtracao2.Name = "lblSubtracao2";
            this.lblSubtracao2.Size = new System.Drawing.Size(64, 28);
            this.lblSubtracao2.TabIndex = 12;
            this.lblSubtracao2.Text = "?";
            this.lblSubtracao2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudSubtracao
            // 
            this.nudSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSubtracao.Location = new System.Drawing.Point(334, 132);
            this.nudSubtracao.Name = "nudSubtracao";
            this.nudSubtracao.Size = new System.Drawing.Size(108, 35);
            this.nudSubtracao.TabIndex = 11;
            this.nudSubtracao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSubtracao.ValueChanged += new System.EventHandler(this.ValorCorretoSub);
            this.nudSubtracao.Enter += new System.EventHandler(this.Responder_enter);
            // 
            // lblSubtracao1
            // 
            this.lblSubtracao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtracao1.Location = new System.Drawing.Point(54, 134);
            this.lblSubtracao1.Name = "lblSubtracao1";
            this.lblSubtracao1.Size = new System.Drawing.Size(64, 28);
            this.lblSubtracao1.TabIndex = 10;
            this.lblSubtracao1.Text = "?";
            this.lblSubtracao1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(124, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "x";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(264, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "=";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMultiplicacao2
            // 
            this.lblMultiplicacao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplicacao2.Location = new System.Drawing.Point(194, 193);
            this.lblMultiplicacao2.Name = "lblMultiplicacao2";
            this.lblMultiplicacao2.Size = new System.Drawing.Size(64, 28);
            this.lblMultiplicacao2.TabIndex = 17;
            this.lblMultiplicacao2.Text = "?";
            this.lblMultiplicacao2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudMultiplicacao
            // 
            this.nudMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMultiplicacao.Location = new System.Drawing.Point(334, 191);
            this.nudMultiplicacao.Name = "nudMultiplicacao";
            this.nudMultiplicacao.Size = new System.Drawing.Size(108, 35);
            this.nudMultiplicacao.TabIndex = 16;
            this.nudMultiplicacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMultiplicacao.ValueChanged += new System.EventHandler(this.ValorCorretoMult);
            this.nudMultiplicacao.Enter += new System.EventHandler(this.Responder_enter);
            // 
            // lblMultiplicacao1
            // 
            this.lblMultiplicacao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplicacao1.Location = new System.Drawing.Point(54, 193);
            this.lblMultiplicacao1.Name = "lblMultiplicacao1";
            this.lblMultiplicacao1.Size = new System.Drawing.Size(64, 28);
            this.lblMultiplicacao1.TabIndex = 15;
            this.lblMultiplicacao1.Text = "?";
            this.lblMultiplicacao1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(124, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 28);
            this.label12.TabIndex = 24;
            this.label12.Text = "÷";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(264, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 28);
            this.label13.TabIndex = 23;
            this.label13.Text = "=";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDivisao2
            // 
            this.lblDivisao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisao2.Location = new System.Drawing.Point(194, 252);
            this.lblDivisao2.Name = "lblDivisao2";
            this.lblDivisao2.Size = new System.Drawing.Size(64, 28);
            this.lblDivisao2.TabIndex = 22;
            this.lblDivisao2.Text = "?";
            this.lblDivisao2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudDivisao
            // 
            this.nudDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDivisao.Location = new System.Drawing.Point(334, 250);
            this.nudDivisao.Name = "nudDivisao";
            this.nudDivisao.Size = new System.Drawing.Size(108, 35);
            this.nudDivisao.TabIndex = 21;
            this.nudDivisao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDivisao.ValueChanged += new System.EventHandler(this.ValorCorretoDiv);
            this.nudDivisao.Enter += new System.EventHandler(this.Responder_enter);
            // 
            // lblDivisao1
            // 
            this.lblDivisao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisao1.Location = new System.Drawing.Point(54, 252);
            this.lblDivisao1.Name = "lblDivisao1";
            this.lblDivisao1.Size = new System.Drawing.Size(64, 28);
            this.lblDivisao1.TabIndex = 20;
            this.lblDivisao1.Text = "?";
            this.lblDivisao1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(145, 308);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(183, 42);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar o Teste !!!";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // tmrTimer
            // 
            this.tmrTimer.Interval = 1000;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblDivisao2);
            this.Controls.Add(this.nudDivisao);
            this.Controls.Add(this.lblDivisao1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMultiplicacao2);
            this.Controls.Add(this.nudMultiplicacao);
            this.Controls.Add(this.lblMultiplicacao1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSubtracao2);
            this.Controls.Add(this.nudSubtracao);
            this.Controls.Add(this.lblSubtracao1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSoma2);
            this.Controls.Add(this.nudSoma);
            this.Controls.Add(this.lblSoma1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTempo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Teste de Matemática";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Responder_enter);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSubtracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMultiplicacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDivisao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoma1;
        private System.Windows.Forms.NumericUpDown nudSoma;
        private System.Windows.Forms.Label lblSoma2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSubtracao2;
        private System.Windows.Forms.NumericUpDown nudSubtracao;
        private System.Windows.Forms.Label lblSubtracao1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMultiplicacao2;
        private System.Windows.Forms.NumericUpDown nudMultiplicacao;
        private System.Windows.Forms.Label lblMultiplicacao1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDivisao2;
        private System.Windows.Forms.NumericUpDown nudDivisao;
        private System.Windows.Forms.Label lblDivisao1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Timer tmrTimer;
    }
}


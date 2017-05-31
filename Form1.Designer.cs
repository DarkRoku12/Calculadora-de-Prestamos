namespace CalculadoraPrestamos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TablaResultados = new System.Windows.Forms.TableLayoutPanel();
            this.textBalance = new System.Windows.Forms.Label();
            this.textInteres = new System.Windows.Forms.Label();
            this.textMeses = new System.Windows.Forms.Label();
            this.BalanceTB = new System.Windows.Forms.TextBox();
            this.InteresTB = new System.Windows.Forms.TextBox();
            this.PlazoTB = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TablaResultados
            // 
            this.TablaResultados.AutoScroll = true;
            this.TablaResultados.ColumnCount = 5;
            this.TablaResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.TablaResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.TablaResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.TablaResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.TablaResultados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.TablaResultados.Location = new System.Drawing.Point(147, 23);
            this.TablaResultados.Name = "TablaResultados";
            this.TablaResultados.RowCount = 1;
            this.TablaResultados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TablaResultados.Size = new System.Drawing.Size(396, 185);
            this.TablaResultados.TabIndex = 0;
            this.TablaResultados.Paint += new System.Windows.Forms.PaintEventHandler(this.TablaResultados_Paint);
            // 
            // textBalance
            // 
            this.textBalance.AutoSize = true;
            this.textBalance.Location = new System.Drawing.Point(20, 23);
            this.textBalance.Name = "textBalance";
            this.textBalance.Size = new System.Drawing.Size(46, 13);
            this.textBalance.TabIndex = 1;
            this.textBalance.Text = "Balance";
            // 
            // textInteres
            // 
            this.textInteres.AutoSize = true;
            this.textInteres.Location = new System.Drawing.Point(20, 83);
            this.textInteres.Name = "textInteres";
            this.textInteres.Size = new System.Drawing.Size(101, 13);
            this.textInteres.TabIndex = 2;
            this.textInteres.Text = "Porciento de interes";
            // 
            // textMeses
            // 
            this.textMeses.AutoSize = true;
            this.textMeses.Location = new System.Drawing.Point(20, 145);
            this.textMeses.Name = "textMeses";
            this.textMeses.Size = new System.Drawing.Size(81, 13);
            this.textMeses.TabIndex = 3;
            this.textMeses.Text = "Plazo en meses";
            // 
            // BalanceTB
            // 
            this.BalanceTB.Location = new System.Drawing.Point(23, 41);
            this.BalanceTB.Name = "BalanceTB";
            this.BalanceTB.Size = new System.Drawing.Size(100, 20);
            this.BalanceTB.TabIndex = 1;
            // 
            // InteresTB
            // 
            this.InteresTB.Location = new System.Drawing.Point(23, 100);
            this.InteresTB.Name = "InteresTB";
            this.InteresTB.Size = new System.Drawing.Size(100, 20);
            this.InteresTB.TabIndex = 2;
            // 
            // PlazoTB
            // 
            this.PlazoTB.Location = new System.Drawing.Point(23, 162);
            this.PlazoTB.Name = "PlazoTB";
            this.PlazoTB.Size = new System.Drawing.Size(100, 20);
            this.PlazoTB.TabIndex = 3;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(23, 206);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 4;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_OnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(584, 256);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.PlazoTB);
            this.Controls.Add(this.InteresTB);
            this.Controls.Add(this.BalanceTB);
            this.Controls.Add(this.textMeses);
            this.Controls.Add(this.textInteres);
            this.Controls.Add(this.textBalance);
            this.Controls.Add(this.TablaResultados);
            this.Name = "Form1";
            this.Text = "Calculadora de Prestamos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TablaResultados;
        private System.Windows.Forms.Label textBalance;
        private System.Windows.Forms.Label textInteres;
        private System.Windows.Forms.Label textMeses;
        private System.Windows.Forms.TextBox BalanceTB;
        private System.Windows.Forms.TextBox InteresTB;
        private System.Windows.Forms.TextBox PlazoTB;
        private System.Windows.Forms.Button Calcular;
    }
}


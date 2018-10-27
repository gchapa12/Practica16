namespace OrdenamientoyBusqueda
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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNuevos = new System.Windows.Forms.Button();
            this.lbNumeros = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbOrden = new System.Windows.Forms.Label();
            this.btnBurbuja = new System.Windows.Forms.Button();
            this.bntQuickSort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSecuencial = new System.Windows.Forms.Button();
            this.btnBinario = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbBuscar = new System.Windows.Forms.TextBox();
            this.lbEncontrado = new System.Windows.Forms.Label();
            this.lbIndice = new System.Windows.Forms.Label();
            this.lbPos = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordenamiento Y Búsqueda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Números a manejar (10):";
            // 
            // btnNuevos
            // 
            this.btnNuevos.Location = new System.Drawing.Point(259, 98);
            this.btnNuevos.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevos.Name = "btnNuevos";
            this.btnNuevos.Size = new System.Drawing.Size(253, 38);
            this.btnNuevos.TabIndex = 2;
            this.btnNuevos.Text = "Generar Nuevos Números";
            this.btnNuevos.UseVisualStyleBackColor = true;
            this.btnNuevos.Click += new System.EventHandler(this.btnNuevos_Click);
            // 
            // lbNumeros
            // 
            this.lbNumeros.AutoSize = true;
            this.lbNumeros.Location = new System.Drawing.Point(201, 65);
            this.lbNumeros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumeros.Name = "lbNumeros";
            this.lbNumeros.Size = new System.Drawing.Size(46, 17);
            this.lbNumeros.TabIndex = 3;
            this.lbNumeros.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ordenamiento";
            // 
            // lbOrden
            // 
            this.lbOrden.AutoSize = true;
            this.lbOrden.Location = new System.Drawing.Point(201, 159);
            this.lbOrden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOrden.Name = "lbOrden";
            this.lbOrden.Size = new System.Drawing.Size(163, 17);
            this.lbOrden.TabIndex = 5;
            this.lbOrden.Text = "[Pulse un botón primero]";
            // 
            // btnBurbuja
            // 
            this.btnBurbuja.Location = new System.Drawing.Point(229, 193);
            this.btnBurbuja.Margin = new System.Windows.Forms.Padding(4);
            this.btnBurbuja.Name = "btnBurbuja";
            this.btnBurbuja.Size = new System.Drawing.Size(133, 28);
            this.btnBurbuja.TabIndex = 6;
            this.btnBurbuja.Text = "Burbuja";
            this.btnBurbuja.UseVisualStyleBackColor = true;
            this.btnBurbuja.Click += new System.EventHandler(this.btnBurbuja_Click);
            // 
            // bntQuickSort
            // 
            this.bntQuickSort.Location = new System.Drawing.Point(405, 193);
            this.bntQuickSort.Margin = new System.Windows.Forms.Padding(4);
            this.bntQuickSort.Name = "bntQuickSort";
            this.bntQuickSort.Size = new System.Drawing.Size(140, 28);
            this.bntQuickSort.TabIndex = 7;
            this.bntQuickSort.Text = "QuickSort";
            this.bntQuickSort.UseVisualStyleBackColor = true;
            this.bntQuickSort.Click += new System.EventHandler(this.bntQuickSort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Método de ordenamiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Búsqueda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 262);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "[Ingrese un valor a buscar primero]";
            // 
            // btnSecuencial
            // 
            this.btnSecuencial.Location = new System.Drawing.Point(229, 295);
            this.btnSecuencial.Margin = new System.Windows.Forms.Padding(4);
            this.btnSecuencial.Name = "btnSecuencial";
            this.btnSecuencial.Size = new System.Drawing.Size(133, 28);
            this.btnSecuencial.TabIndex = 11;
            this.btnSecuencial.Text = "Secuencial";
            this.btnSecuencial.UseVisualStyleBackColor = true;
            this.btnSecuencial.Click += new System.EventHandler(this.btnSecuencial_Click);
            // 
            // btnBinario
            // 
            this.btnBinario.Location = new System.Drawing.Point(405, 295);
            this.btnBinario.Margin = new System.Windows.Forms.Padding(4);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(140, 28);
            this.btnBinario.TabIndex = 12;
            this.btnBinario.Text = "Binario";
            this.btnBinario.UseVisualStyleBackColor = true;
            this.btnBinario.Click += new System.EventHandler(this.btnBinario_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 302);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Método de búsqueda:";
            // 
            // txtbBuscar
            // 
            this.txtbBuscar.Location = new System.Drawing.Point(437, 259);
            this.txtbBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtbBuscar.Name = "txtbBuscar";
            this.txtbBuscar.Size = new System.Drawing.Size(75, 22);
            this.txtbBuscar.TabIndex = 14;
            this.txtbBuscar.Text = " ";
            // 
            // lbEncontrado
            // 
            this.lbEncontrado.AutoSize = true;
            this.lbEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEncontrado.Location = new System.Drawing.Point(628, 274);
            this.lbEncontrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEncontrado.Name = "lbEncontrado";
            this.lbEncontrado.Size = new System.Drawing.Size(13, 17);
            this.lbEncontrado.TabIndex = 15;
            this.lbEncontrado.Text = " ";
            // 
            // lbIndice
            // 
            this.lbIndice.AutoSize = true;
            this.lbIndice.Location = new System.Drawing.Point(660, 302);
            this.lbIndice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIndice.Name = "lbIndice";
            this.lbIndice.Size = new System.Drawing.Size(12, 17);
            this.lbIndice.TabIndex = 16;
            this.lbIndice.Text = " ";
            // 
            // lbPos
            // 
            this.lbPos.AutoSize = true;
            this.lbPos.Location = new System.Drawing.Point(585, 302);
            this.lbPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPos.Name = "lbPos";
            this.lbPos.Size = new System.Drawing.Size(65, 17);
            this.lbPos.TabIndex = 17;
            this.lbPos.Text = "Posición:";
            this.lbPos.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 364);
            this.Controls.Add(this.lbPos);
            this.Controls.Add(this.lbIndice);
            this.Controls.Add(this.lbEncontrado);
            this.Controls.Add(this.txtbBuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.btnSecuencial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bntQuickSort);
            this.Controls.Add(this.btnBurbuja);
            this.Controls.Add(this.lbOrden);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbNumeros);
            this.Controls.Add(this.btnNuevos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNuevos;
        private System.Windows.Forms.Label lbNumeros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbOrden;
        private System.Windows.Forms.Button btnBurbuja;
        private System.Windows.Forms.Button bntQuickSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSecuencial;
        private System.Windows.Forms.Button btnBinario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbBuscar;
        private System.Windows.Forms.Label lbEncontrado;
        private System.Windows.Forms.Label lbIndice;
        private System.Windows.Forms.Label lbPos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}


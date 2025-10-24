namespace Meteorologia
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Capital");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Carlos Paz");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("San Francisco");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Rio Cuarto");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Córdoba", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Capital");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Monteros");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Aguilares");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Tafí del Valle");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Tucumán", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Salta");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("La Pampa");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Mendoza");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("PROVINCIAS", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Temp Mìnima");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Temp Màxima");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblfecha = new System.Windows.Forms.Label();
            this.stpseleccion = new System.Windows.Forms.StatusStrip();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblubicaciones = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trvprovincias = new System.Windows.Forms.TreeView();
            this.lsvtemperaturas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblfecha.Location = new System.Drawing.Point(59, 32);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(69, 24);
            this.lblfecha.TabIndex = 0;
            this.lblfecha.Text = "Fecha:";
            // 
            // stpseleccion
            // 
            this.stpseleccion.Location = new System.Drawing.Point(0, 428);
            this.stpseleccion.Name = "stpseleccion";
            this.stpseleccion.Size = new System.Drawing.Size(800, 22);
            this.stpseleccion.TabIndex = 1;
            this.stpseleccion.Text = "Seleccionado:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblubicaciones
            // 
            this.lblubicaciones.AutoSize = true;
            this.lblubicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblubicaciones.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblubicaciones.Location = new System.Drawing.Point(59, 106);
            this.lblubicaciones.Name = "lblubicaciones";
            this.lblubicaciones.Size = new System.Drawing.Size(119, 24);
            this.lblubicaciones.TabIndex = 3;
            this.lblubicaciones.Text = "Ubicaciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(374, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Temperaturas:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // trvprovincias
            // 
            this.trvprovincias.Location = new System.Drawing.Point(63, 133);
            this.trvprovincias.Name = "trvprovincias";
            treeNode1.Name = "Nodo2";
            treeNode1.Text = "Capital";
            treeNode2.Name = "Nodo3";
            treeNode2.Text = "Carlos Paz";
            treeNode3.Name = "Nodo4";
            treeNode3.Text = "San Francisco";
            treeNode4.Name = "Nodo5";
            treeNode4.Text = "Rio Cuarto";
            treeNode5.Name = "Nodo1";
            treeNode5.Text = "Córdoba";
            treeNode6.Name = "Nodo7";
            treeNode6.Text = "Capital";
            treeNode7.Name = "Nodo8";
            treeNode7.Text = "Monteros";
            treeNode8.Name = "Nodo9";
            treeNode8.Text = "Aguilares";
            treeNode9.Name = "Nodo10";
            treeNode9.Text = "Tafí del Valle";
            treeNode10.Name = "Nodo6";
            treeNode10.Text = "Tucumán";
            treeNode11.Name = "Nodo11";
            treeNode11.Text = "Salta";
            treeNode12.Name = "Nodo12";
            treeNode12.Text = "La Pampa";
            treeNode13.Name = "Nodo13";
            treeNode13.Text = "Mendoza";
            treeNode14.Name = "Nodo0";
            treeNode14.Text = "PROVINCIAS";
            this.trvprovincias.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.trvprovincias.Size = new System.Drawing.Size(186, 236);
            this.trvprovincias.TabIndex = 7;
            // 
            // lsvtemperaturas
            // 
            this.lsvtemperaturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lsvtemperaturas.HideSelection = false;
            this.lsvtemperaturas.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lsvtemperaturas.Location = new System.Drawing.Point(378, 133);
            this.lsvtemperaturas.Name = "lsvtemperaturas";
            this.lsvtemperaturas.Size = new System.Drawing.Size(220, 82);
            this.lsvtemperaturas.TabIndex = 8;
            this.lsvtemperaturas.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Temp Mìnima";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsvtemperaturas);
            this.Controls.Add(this.trvprovincias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblubicaciones);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.stpseleccion);
            this.Controls.Add(this.lblfecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.StatusStrip stpseleccion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblubicaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView trvprovincias;
        private System.Windows.Forms.ListView lsvtemperaturas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}


namespace Ejercicio1;

partial class FormPrincipal
{
    /// <summary>
    /// Variable del diseñador requerida.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén utilizando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
    /// el contenido del método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
        groupBox1 = new GroupBox();
        groupBox3 = new GroupBox();
        btnBuscar = new Button();
        label1 = new Label();
        dtpFechaHoy = new DateTimePicker();
        tbPatente = new TextBox();
        label6 = new Label();
        groupBox2 = new GroupBox();
        label2 = new Label();
        tbCorreo = new TextBox();
        label3 = new Label();
        label4 = new Label();
        tbDNI = new TextBox();
        tbApellidoNombres = new TextBox();
        btnIniciarCargarVTV = new Button();
        btnVer = new Button();
        openFileDialog1 = new OpenFileDialog();
        saveFileDialog1 = new SaveFileDialog();
        btbImportarVTV = new Button();
        btnExportar = new Button();
        groupBox1.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(groupBox3);
        groupBox1.Controls.Add(groupBox2);
        groupBox1.Controls.Add(btnIniciarCargarVTV);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(542, 313);
        groupBox1.TabIndex = 12;
        groupBox1.TabStop = false;
        groupBox1.Text = "Registro de VTV";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(btnBuscar);
        groupBox3.Controls.Add(label1);
        groupBox3.Controls.Add(dtpFechaHoy);
        groupBox3.Controls.Add(tbPatente);
        groupBox3.Controls.Add(label6);
        groupBox3.Location = new Point(6, 160);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(530, 97);
        groupBox3.TabIndex = 13;
        groupBox3.TabStop = false;
        groupBox3.Text = "Datos del vehiculo";
        // 
        // btnBuscar
        // 
        btnBuscar.Location = new Point(420, 25);
        btnBuscar.Name = "btnBuscar";
        btnBuscar.Size = new Size(93, 26);
        btnBuscar.TabIndex = 17;
        btnBuscar.Text = "Buscar";
        btnBuscar.UseVisualStyleBackColor = true;
        btnBuscar.Click += btnBuscar_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(72, 62);
        label1.Name = "label1";
        label1.Size = new Size(105, 20);
        label1.TabIndex = 7;
        label1.Text = "Fecha de hoy";
        // 
        // dtpFechaHoy
        // 
        dtpFechaHoy.CustomFormat = "";
        dtpFechaHoy.Format = DateTimePickerFormat.Short;
        dtpFechaHoy.Location = new Point(205, 57);
        dtpFechaHoy.Name = "dtpFechaHoy";
        dtpFechaHoy.Size = new Size(160, 26);
        dtpFechaHoy.TabIndex = 6;
        // 
        // tbPatente
        // 
        tbPatente.Location = new Point(205, 25);
        tbPatente.Name = "tbPatente";
        tbPatente.Size = new Size(209, 26);
        tbPatente.TabIndex = 0;
        tbPatente.Text = "ABC123";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(112, 28);
        label6.Name = "label6";
        label6.Size = new Size(65, 20);
        label6.TabIndex = 2;
        label6.Text = "Patente";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(tbCorreo);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(tbDNI);
        groupBox2.Controls.Add(tbApellidoNombres);
        groupBox2.Location = new Point(6, 25);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(530, 129);
        groupBox2.TabIndex = 13;
        groupBox2.TabStop = false;
        groupBox2.Text = "Datos del propietario";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(120, 91);
        label2.Name = "label2";
        label2.Size = new Size(57, 20);
        label2.TabIndex = 5;
        label2.Text = "Correo";
        // 
        // tbCorreo
        // 
        tbCorreo.Location = new Point(205, 91);
        tbCorreo.Name = "tbCorreo";
        tbCorreo.Size = new Size(308, 26);
        tbCorreo.TabIndex = 4;
        tbCorreo.Text = "agustina@gmail.com";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(25, 59);
        label3.Name = "label3";
        label3.Size = new Size(152, 20);
        label3.TabIndex = 3;
        label3.Text = "Apellidos y Nombres";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(140, 31);
        label4.Name = "label4";
        label4.Size = new Size(37, 20);
        label4.TabIndex = 2;
        label4.Text = "DNI";
        // 
        // tbDNI
        // 
        tbDNI.Location = new Point(205, 25);
        tbDNI.Name = "tbDNI";
        tbDNI.Size = new Size(129, 26);
        tbDNI.TabIndex = 0;
        tbDNI.Text = "45645455";
        // 
        // tbApellidoNombres
        // 
        tbApellidoNombres.Location = new Point(205, 59);
        tbApellidoNombres.Name = "tbApellidoNombres";
        tbApellidoNombres.Size = new Size(308, 26);
        tbApellidoNombres.TabIndex = 1;
        tbApellidoNombres.Text = "Agustina";
        // 
        // btnIniciarCargarVTV
        // 
        btnIniciarCargarVTV.Location = new Point(188, 263);
        btnIniciarCargarVTV.Name = "btnIniciarCargarVTV";
        btnIniciarCargarVTV.Size = new Size(201, 41);
        btnIniciarCargarVTV.TabIndex = 14;
        btnIniciarCargarVTV.Text = "Iniciar Carga VTV";
        btnIniciarCargarVTV.UseVisualStyleBackColor = true;
        btnIniciarCargarVTV.Click += btnIniciarCargarVTV_Click;
        // 
        // btnVer
        // 
        btnVer.Location = new Point(560, 25);
        btnVer.Name = "btnVer";
        btnVer.Size = new Size(127, 73);
        btnVer.TabIndex = 16;
        btnVer.Text = "Ver VTV Realizados";
        btnVer.UseVisualStyleBackColor = true;
        btnVer.Click += btnVer_Click;
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // btbImportarVTV
        // 
        btbImportarVTV.Location = new Point(560, 105);
        btbImportarVTV.Name = "btbImportarVTV";
        btbImportarVTV.Size = new Size(127, 73);
        btbImportarVTV.TabIndex = 17;
        btbImportarVTV.Text = "Importar VTV";
        btbImportarVTV.UseVisualStyleBackColor = true;
        btbImportarVTV.Click += btnImportar_Click;
        // 
        // btnExportar
        // 
        btnExportar.Location = new Point(560, 184);
        btnExportar.Name = "btnExportar";
        btnExportar.Size = new Size(127, 73);
        btnExportar.TabIndex = 18;
        btnExportar.Text = "Exportar Vehículos";
        btnExportar.UseVisualStyleBackColor = true;
        btnExportar.Click += btnExportar_Click;
        // 
        // FormPrincipal
        // 
        AutoScaleDimensions = new SizeF(9F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(700, 332);
        Controls.Add(btnExportar);
        Controls.Add(btbImportarVTV);
        Controls.Add(btnVer);
        Controls.Add(groupBox1);
        Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 5, 4, 5);
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Ejercicio 1";
        FormClosing += FormPrincipal_FormClosing;
        Load += FormPrincipal_Load;
        groupBox1.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox tbPatente;
    private System.Windows.Forms.Button btnIniciarCargarVTV;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox tbDNI;
    private System.Windows.Forms.TextBox tbApellidoNombres;
    private System.Windows.Forms.DateTimePicker dtpFechaHoy;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnVer;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbCorreo;
    private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.Button btbImportarVTV;
    private System.Windows.Forms.Button btnExportar;
}


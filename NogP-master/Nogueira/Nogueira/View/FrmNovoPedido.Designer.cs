namespace Nogueira
{
    partial class FrmNovoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNovoPedido));
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnBuscarTel = new System.Windows.Forms.Button();
            this.txtPonto_Referencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.groupBoxPizza1Sabor = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxPreco = new System.Windows.Forms.MaskedTextBox();
            this.btnIncluir1Sabor = new System.Windows.Forms.Button();
            this.txtQtd1Sabor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxPizza1Sabor = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxPizzaMeio = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxPrecoMeio2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPrecoMeio1 = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxMeio2 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnIncluirMeio = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxMeio1 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.labelMotoboy = new System.Windows.Forms.Label();
            this.comboBoxMotoboy = new System.Windows.Forms.ComboBox();
            this.radioButtonEntrega = new System.Windows.Forms.RadioButton();
            this.radioButtonBalcao = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.labelRS = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.groupBoxBebidas = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxPrecoBebida = new System.Windows.Forms.MaskedTextBox();
            this.btnIncluirBebida = new System.Windows.Forms.Button();
            this.txtQtdBebida = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.comboBoxBebida = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.labelInteira = new System.Windows.Forms.Label();
            this.btnPizzaInteira = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPizzaMeio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBebida = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBoxCliente.SuspendLayout();
            this.groupBoxPizza1Sabor.SuspendLayout();
            this.groupBoxPizzaMeio.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxBebidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.label22);
            this.groupBoxCliente.Controls.Add(this.btnBuscarTel);
            this.groupBoxCliente.Controls.Add(this.txtPonto_Referencia);
            this.groupBoxCliente.Controls.Add(this.label6);
            this.groupBoxCliente.Controls.Add(this.txtComplemento);
            this.groupBoxCliente.Controls.Add(this.txtTelefone);
            this.groupBoxCliente.Controls.Add(this.label5);
            this.groupBoxCliente.Controls.Add(this.label1);
            this.groupBoxCliente.Controls.Add(this.txtNumero);
            this.groupBoxCliente.Controls.Add(this.label2);
            this.groupBoxCliente.Controls.Add(this.label4);
            this.groupBoxCliente.Controls.Add(this.txtNome);
            this.groupBoxCliente.Controls.Add(this.txtEndereco);
            this.groupBoxCliente.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCliente.Location = new System.Drawing.Point(36, 135);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(966, 121);
            this.groupBoxCliente.TabIndex = 48;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(226, 61);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 14);
            this.label22.TabIndex = 60;
            this.label22.Text = "Endereço:";
            // 
            // btnBuscarTel
            // 
            this.btnBuscarTel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarTel.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarTel.Image")));
            this.btnBuscarTel.Location = new System.Drawing.Point(286, 15);
            this.btnBuscarTel.Name = "btnBuscarTel";
            this.btnBuscarTel.Size = new System.Drawing.Size(63, 36);
            this.btnBuscarTel.TabIndex = 59;
            this.btnBuscarTel.UseVisualStyleBackColor = false;
            this.btnBuscarTel.Click += new System.EventHandler(this.btnBuscarTel_Click_1);
            // 
            // txtPonto_Referencia
            // 
            this.txtPonto_Referencia.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPonto_Referencia.Location = new System.Drawing.Point(699, 78);
            this.txtPonto_Referencia.Name = "txtPonto_Referencia";
            this.txtPonto_Referencia.ReadOnly = true;
            this.txtPonto_Referencia.Size = new System.Drawing.Size(231, 20);
            this.txtPonto_Referencia.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(697, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 14);
            this.label6.TabIndex = 57;
            this.label6.Text = "Ponto de Referência:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(588, 78);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.ReadOnly = true;
            this.txtComplemento.Size = new System.Drawing.Size(82, 20);
            this.txtComplemento.TabIndex = 56;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefone.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(163, 19);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(117, 26);
            this.txtTelefone.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(585, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 14);
            this.label5.TabIndex = 55;
            this.label5.Text = "Complemento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 14);
            this.label1.TabIndex = 48;
            this.label1.Text = "Número de Telefone:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(517, 78);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(49, 20);
            this.txtNumero.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 14);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 53;
            this.label4.Text = "Número:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(40, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(161, 20);
            this.txtNome.TabIndex = 51;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(224, 78);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.ReadOnly = true;
            this.txtEndereco.Size = new System.Drawing.Size(270, 20);
            this.txtEndereco.TabIndex = 52;
            // 
            // groupBoxPizza1Sabor
            // 
            this.groupBoxPizza1Sabor.Controls.Add(this.maskedTextBoxPreco);
            this.groupBoxPizza1Sabor.Controls.Add(this.btnIncluir1Sabor);
            this.groupBoxPizza1Sabor.Controls.Add(this.txtQtd1Sabor);
            this.groupBoxPizza1Sabor.Controls.Add(this.label15);
            this.groupBoxPizza1Sabor.Controls.Add(this.comboBoxPizza1Sabor);
            this.groupBoxPizza1Sabor.Controls.Add(this.label14);
            this.groupBoxPizza1Sabor.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPizza1Sabor.Location = new System.Drawing.Point(36, 313);
            this.groupBoxPizza1Sabor.Name = "groupBoxPizza1Sabor";
            this.groupBoxPizza1Sabor.Size = new System.Drawing.Size(440, 122);
            this.groupBoxPizza1Sabor.TabIndex = 49;
            this.groupBoxPizza1Sabor.TabStop = false;
            this.groupBoxPizza1Sabor.Visible = false;
            // 
            // maskedTextBoxPreco
            // 
            this.maskedTextBoxPreco.Enabled = false;
            this.maskedTextBoxPreco.Location = new System.Drawing.Point(187, 56);
            this.maskedTextBoxPreco.Mask = "$ 99,99";
            this.maskedTextBoxPreco.Name = "maskedTextBoxPreco";
            this.maskedTextBoxPreco.Size = new System.Drawing.Size(85, 20);
            this.maskedTextBoxPreco.TabIndex = 15;
            // 
            // btnIncluir1Sabor
            // 
            this.btnIncluir1Sabor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIncluir1Sabor.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir1Sabor.Image")));
            this.btnIncluir1Sabor.Location = new System.Drawing.Point(320, 48);
            this.btnIncluir1Sabor.Name = "btnIncluir1Sabor";
            this.btnIncluir1Sabor.Size = new System.Drawing.Size(52, 36);
            this.btnIncluir1Sabor.TabIndex = 6;
            this.btnIncluir1Sabor.UseVisualStyleBackColor = false;
            this.btnIncluir1Sabor.Click += new System.EventHandler(this.btnIncluir1Sabor_Click);
            // 
            // txtQtd1Sabor
            // 
            this.txtQtd1Sabor.Enabled = false;
            this.txtQtd1Sabor.Location = new System.Drawing.Point(112, 10);
            this.txtQtd1Sabor.Name = "txtQtd1Sabor";
            this.txtQtd1Sabor.Size = new System.Drawing.Size(67, 20);
            this.txtQtd1Sabor.TabIndex = 5;
            this.txtQtd1Sabor.Text = "1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(184, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 14);
            this.label15.TabIndex = 2;
            this.label15.Text = "Preço";
            // 
            // comboBoxPizza1Sabor
            // 
            this.comboBoxPizza1Sabor.FormattingEnabled = true;
            this.comboBoxPizza1Sabor.Location = new System.Drawing.Point(38, 55);
            this.comboBoxPizza1Sabor.Name = "comboBoxPizza1Sabor";
            this.comboBoxPizza1Sabor.Size = new System.Drawing.Size(121, 20);
            this.comboBoxPizza1Sabor.TabIndex = 1;
            this.comboBoxPizza1Sabor.SelectedIndexChanged += new System.EventHandler(this.comboBoxPizza1Sabor_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(35, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 14);
            this.label14.TabIndex = 0;
            this.label14.Text = "Sabor Pizza";
            // 
            // groupBoxPizzaMeio
            // 
            this.groupBoxPizzaMeio.Controls.Add(this.maskedTextBoxPrecoMeio2);
            this.groupBoxPizzaMeio.Controls.Add(this.maskedTextBoxPrecoMeio1);
            this.groupBoxPizzaMeio.Controls.Add(this.label17);
            this.groupBoxPizzaMeio.Controls.Add(this.comboBoxMeio2);
            this.groupBoxPizzaMeio.Controls.Add(this.label20);
            this.groupBoxPizzaMeio.Controls.Add(this.btnIncluirMeio);
            this.groupBoxPizzaMeio.Controls.Add(this.label18);
            this.groupBoxPizzaMeio.Controls.Add(this.comboBoxMeio1);
            this.groupBoxPizzaMeio.Controls.Add(this.label19);
            this.groupBoxPizzaMeio.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPizzaMeio.Location = new System.Drawing.Point(562, 313);
            this.groupBoxPizzaMeio.Name = "groupBoxPizzaMeio";
            this.groupBoxPizzaMeio.Size = new System.Drawing.Size(440, 122);
            this.groupBoxPizzaMeio.TabIndex = 50;
            this.groupBoxPizzaMeio.TabStop = false;
            this.groupBoxPizzaMeio.Visible = false;
            // 
            // maskedTextBoxPrecoMeio2
            // 
            this.maskedTextBoxPrecoMeio2.Enabled = false;
            this.maskedTextBoxPrecoMeio2.Location = new System.Drawing.Point(192, 87);
            this.maskedTextBoxPrecoMeio2.Mask = "$ 99,99";
            this.maskedTextBoxPrecoMeio2.Name = "maskedTextBoxPrecoMeio2";
            this.maskedTextBoxPrecoMeio2.Size = new System.Drawing.Size(85, 20);
            this.maskedTextBoxPrecoMeio2.TabIndex = 17;
            // 
            // maskedTextBoxPrecoMeio1
            // 
            this.maskedTextBoxPrecoMeio1.Enabled = false;
            this.maskedTextBoxPrecoMeio1.Location = new System.Drawing.Point(192, 33);
            this.maskedTextBoxPrecoMeio1.Mask = "$ 99,99";
            this.maskedTextBoxPrecoMeio1.Name = "maskedTextBoxPrecoMeio1";
            this.maskedTextBoxPrecoMeio1.Size = new System.Drawing.Size(85, 20);
            this.maskedTextBoxPrecoMeio1.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(191, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 14);
            this.label17.TabIndex = 9;
            this.label17.Text = "Preço";
            // 
            // comboBoxMeio2
            // 
            this.comboBoxMeio2.FormattingEnabled = true;
            this.comboBoxMeio2.Location = new System.Drawing.Point(35, 86);
            this.comboBoxMeio2.Name = "comboBoxMeio2";
            this.comboBoxMeio2.Size = new System.Drawing.Size(121, 20);
            this.comboBoxMeio2.TabIndex = 8;
            this.comboBoxMeio2.SelectedIndexChanged += new System.EventHandler(this.comboBoxMeio2_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(32, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 14);
            this.label20.TabIndex = 7;
            this.label20.Text = "Sabor Pizza";
            // 
            // btnIncluirMeio
            // 
            this.btnIncluirMeio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIncluirMeio.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluirMeio.Image")));
            this.btnIncluirMeio.Location = new System.Drawing.Point(326, 55);
            this.btnIncluirMeio.Name = "btnIncluirMeio";
            this.btnIncluirMeio.Size = new System.Drawing.Size(52, 36);
            this.btnIncluirMeio.TabIndex = 6;
            this.btnIncluirMeio.UseVisualStyleBackColor = false;
            this.btnIncluirMeio.Click += new System.EventHandler(this.btnIncluirMeio_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(191, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 14);
            this.label18.TabIndex = 2;
            this.label18.Text = "Preço";
            // 
            // comboBoxMeio1
            // 
            this.comboBoxMeio1.FormattingEnabled = true;
            this.comboBoxMeio1.Location = new System.Drawing.Point(35, 32);
            this.comboBoxMeio1.Name = "comboBoxMeio1";
            this.comboBoxMeio1.Size = new System.Drawing.Size(121, 20);
            this.comboBoxMeio1.TabIndex = 1;
            this.comboBoxMeio1.SelectedIndexChanged += new System.EventHandler(this.comboBoxMeio1_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(32, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 14);
            this.label19.TabIndex = 0;
            this.label19.Text = "Sabor Pizza";
            // 
            // labelMotoboy
            // 
            this.labelMotoboy.AutoSize = true;
            this.labelMotoboy.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotoboy.Location = new System.Drawing.Point(596, 48);
            this.labelMotoboy.Name = "labelMotoboy";
            this.labelMotoboy.Size = new System.Drawing.Size(191, 14);
            this.labelMotoboy.TabIndex = 51;
            this.labelMotoboy.Text = "Qual motoboy irá fazer a entrega ?";
            this.labelMotoboy.Visible = false;
            // 
            // comboBoxMotoboy
            // 
            this.comboBoxMotoboy.FormattingEnabled = true;
            this.comboBoxMotoboy.Location = new System.Drawing.Point(793, 44);
            this.comboBoxMotoboy.Name = "comboBoxMotoboy";
            this.comboBoxMotoboy.Size = new System.Drawing.Size(201, 21);
            this.comboBoxMotoboy.TabIndex = 52;
            this.comboBoxMotoboy.Visible = false;
            // 
            // radioButtonEntrega
            // 
            this.radioButtonEntrega.AutoSize = true;
            this.radioButtonEntrega.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEntrega.Location = new System.Drawing.Point(13, 19);
            this.radioButtonEntrega.Name = "radioButtonEntrega";
            this.radioButtonEntrega.Size = new System.Drawing.Size(66, 18);
            this.radioButtonEntrega.TabIndex = 53;
            this.radioButtonEntrega.TabStop = true;
            this.radioButtonEntrega.Text = "Entrega";
            this.radioButtonEntrega.UseVisualStyleBackColor = true;
            this.radioButtonEntrega.CheckedChanged += new System.EventHandler(this.radioButtonEntrega_CheckedChanged);
            // 
            // radioButtonBalcao
            // 
            this.radioButtonBalcao.AutoSize = true;
            this.radioButtonBalcao.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonBalcao.Location = new System.Drawing.Point(143, 19);
            this.radioButtonBalcao.Name = "radioButtonBalcao";
            this.radioButtonBalcao.Size = new System.Drawing.Size(61, 18);
            this.radioButtonBalcao.TabIndex = 54;
            this.radioButtonBalcao.TabStop = true;
            this.radioButtonBalcao.Text = "Balcão";
            this.radioButtonBalcao.UseVisualStyleBackColor = true;
            this.radioButtonBalcao.CheckedChanged += new System.EventHandler(this.radioButtonBalcao_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButtonEntrega);
            this.groupBox7.Controls.Add(this.radioButtonBalcao);
            this.groupBox7.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(36, 25);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(522, 54);
            this.groupBox7.TabIndex = 55;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "FORMA DE VENDA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 615);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(651, 123);
            this.dataGridView1.TabIndex = 56;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemove.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Location = new System.Drawing.Point(699, 627);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(118, 39);
            this.btnRemove.TabIndex = 57;
            this.btnRemove.Text = "EXCLUIR LINHA";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(838, 679);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 12);
            this.label21.TabIndex = 58;
            this.label21.Text = "TOTAL";
            // 
            // labelRS
            // 
            this.labelRS.AutoSize = true;
            this.labelRS.Location = new System.Drawing.Point(887, 679);
            this.labelRS.Name = "labelRS";
            this.labelRS.Size = new System.Drawing.Size(21, 13);
            this.labelRS.TabIndex = 59;
            this.labelRS.Text = "R$";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(915, 679);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 13);
            this.labelTotal.TabIndex = 60;
            // 
            // groupBoxBebidas
            // 
            this.groupBoxBebidas.Controls.Add(this.maskedTextBoxPrecoBebida);
            this.groupBoxBebidas.Controls.Add(this.btnIncluirBebida);
            this.groupBoxBebidas.Controls.Add(this.txtQtdBebida);
            this.groupBoxBebidas.Controls.Add(this.label24);
            this.groupBoxBebidas.Controls.Add(this.comboBoxBebida);
            this.groupBoxBebidas.Controls.Add(this.label25);
            this.groupBoxBebidas.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBebidas.Location = new System.Drawing.Point(36, 483);
            this.groupBoxBebidas.Name = "groupBoxBebidas";
            this.groupBoxBebidas.Size = new System.Drawing.Size(440, 122);
            this.groupBoxBebidas.TabIndex = 61;
            this.groupBoxBebidas.TabStop = false;
            this.groupBoxBebidas.Visible = false;
            // 
            // maskedTextBoxPrecoBebida
            // 
            this.maskedTextBoxPrecoBebida.Enabled = false;
            this.maskedTextBoxPrecoBebida.Location = new System.Drawing.Point(188, 57);
            this.maskedTextBoxPrecoBebida.Mask = "$ 99,99";
            this.maskedTextBoxPrecoBebida.Name = "maskedTextBoxPrecoBebida";
            this.maskedTextBoxPrecoBebida.Size = new System.Drawing.Size(85, 20);
            this.maskedTextBoxPrecoBebida.TabIndex = 15;
            // 
            // btnIncluirBebida
            // 
            this.btnIncluirBebida.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIncluirBebida.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluirBebida.Image")));
            this.btnIncluirBebida.Location = new System.Drawing.Point(320, 40);
            this.btnIncluirBebida.Name = "btnIncluirBebida";
            this.btnIncluirBebida.Size = new System.Drawing.Size(52, 36);
            this.btnIncluirBebida.TabIndex = 6;
            this.btnIncluirBebida.UseVisualStyleBackColor = false;
            this.btnIncluirBebida.Click += new System.EventHandler(this.BtnIncluirBebida_Click);
            // 
            // txtQtdBebida
            // 
            this.txtQtdBebida.Enabled = false;
            this.txtQtdBebida.Location = new System.Drawing.Point(112, 19);
            this.txtQtdBebida.Name = "txtQtdBebida";
            this.txtQtdBebida.Size = new System.Drawing.Size(67, 20);
            this.txtQtdBebida.TabIndex = 5;
            this.txtQtdBebida.Text = "1";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(185, 40);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 14);
            this.label24.TabIndex = 2;
            this.label24.Text = "Preço";
            // 
            // comboBoxBebida
            // 
            this.comboBoxBebida.FormattingEnabled = true;
            this.comboBoxBebida.Location = new System.Drawing.Point(38, 56);
            this.comboBoxBebida.Name = "comboBoxBebida";
            this.comboBoxBebida.Size = new System.Drawing.Size(121, 20);
            this.comboBoxBebida.TabIndex = 1;
            this.comboBoxBebida.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBebida_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(35, 40);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 14);
            this.label25.TabIndex = 0;
            this.label25.Text = "Bebida";
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFinalizarPedido.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPedido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinalizarPedido.Location = new System.Drawing.Point(699, 690);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(118, 39);
            this.btnFinalizarPedido.TabIndex = 62;
            this.btnFinalizarPedido.Text = "FECHAR PEDIDO";
            this.btnFinalizarPedido.UseVisualStyleBackColor = false;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.BtnFinalizarPedido_Click);
            // 
            // labelInteira
            // 
            this.labelInteira.Location = new System.Drawing.Point(0, 0);
            this.labelInteira.Name = "labelInteira";
            this.labelInteira.Size = new System.Drawing.Size(100, 23);
            this.labelInteira.TabIndex = 67;
            // 
            // btnPizzaInteira
            // 
            this.btnPizzaInteira.Activecolor = System.Drawing.Color.DarkRed;
            this.btnPizzaInteira.BackColor = System.Drawing.Color.DarkRed;
            this.btnPizzaInteira.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPizzaInteira.BorderRadius = 0;
            this.btnPizzaInteira.ButtonText = "            PIZZA INTEIRA";
            this.btnPizzaInteira.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPizzaInteira.DisabledColor = System.Drawing.Color.Gray;
            this.btnPizzaInteira.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPizzaInteira.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPizzaInteira.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPizzaInteira.Iconimage")));
            this.btnPizzaInteira.Iconimage_right = null;
            this.btnPizzaInteira.Iconimage_right_Selected = null;
            this.btnPizzaInteira.Iconimage_Selected = null;
            this.btnPizzaInteira.IconMarginLeft = 0;
            this.btnPizzaInteira.IconMarginRight = 0;
            this.btnPizzaInteira.IconRightVisible = true;
            this.btnPizzaInteira.IconRightZoom = 0D;
            this.btnPizzaInteira.IconVisible = true;
            this.btnPizzaInteira.IconZoom = 50D;
            this.btnPizzaInteira.IsTab = false;
            this.btnPizzaInteira.Location = new System.Drawing.Point(36, 272);
            this.btnPizzaInteira.Name = "btnPizzaInteira";
            this.btnPizzaInteira.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnPizzaInteira.OnHovercolor = System.Drawing.Color.DarkSalmon;
            this.btnPizzaInteira.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPizzaInteira.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPizzaInteira.selected = false;
            this.btnPizzaInteira.Size = new System.Drawing.Size(440, 48);
            this.btnPizzaInteira.TabIndex = 66;
            this.btnPizzaInteira.Text = "            PIZZA INTEIRA";
            this.btnPizzaInteira.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPizzaInteira.Textcolor = System.Drawing.Color.Gold;
            this.btnPizzaInteira.TextFont = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPizzaInteira.Click += new System.EventHandler(this.BtnPizzaInteira_Click);
            // 
            // btnPizzaMeio
            // 
            this.btnPizzaMeio.Activecolor = System.Drawing.Color.DarkRed;
            this.btnPizzaMeio.BackColor = System.Drawing.Color.DarkRed;
            this.btnPizzaMeio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPizzaMeio.BorderRadius = 0;
            this.btnPizzaMeio.ButtonText = "         PIZZA MEIO A MEIO";
            this.btnPizzaMeio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPizzaMeio.DisabledColor = System.Drawing.Color.Gray;
            this.btnPizzaMeio.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPizzaMeio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPizzaMeio.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPizzaMeio.Iconimage")));
            this.btnPizzaMeio.Iconimage_right = null;
            this.btnPizzaMeio.Iconimage_right_Selected = null;
            this.btnPizzaMeio.Iconimage_Selected = null;
            this.btnPizzaMeio.IconMarginLeft = 0;
            this.btnPizzaMeio.IconMarginRight = 0;
            this.btnPizzaMeio.IconRightVisible = true;
            this.btnPizzaMeio.IconRightZoom = 0D;
            this.btnPizzaMeio.IconVisible = true;
            this.btnPizzaMeio.IconZoom = 50D;
            this.btnPizzaMeio.IsTab = false;
            this.btnPizzaMeio.Location = new System.Drawing.Point(562, 272);
            this.btnPizzaMeio.Name = "btnPizzaMeio";
            this.btnPizzaMeio.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnPizzaMeio.OnHovercolor = System.Drawing.Color.DarkSalmon;
            this.btnPizzaMeio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPizzaMeio.selected = false;
            this.btnPizzaMeio.Size = new System.Drawing.Size(440, 48);
            this.btnPizzaMeio.TabIndex = 68;
            this.btnPizzaMeio.Text = "         PIZZA MEIO A MEIO";
            this.btnPizzaMeio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPizzaMeio.Textcolor = System.Drawing.Color.Gold;
            this.btnPizzaMeio.TextFont = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPizzaMeio.Click += new System.EventHandler(this.BtnPizzaMeio_Click);
            // 
            // btnBebida
            // 
            this.btnBebida.Activecolor = System.Drawing.Color.DarkRed;
            this.btnBebida.BackColor = System.Drawing.Color.DarkRed;
            this.btnBebida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBebida.BorderRadius = 0;
            this.btnBebida.ButtonText = "            BEBIDA";
            this.btnBebida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBebida.DisabledColor = System.Drawing.Color.Gray;
            this.btnBebida.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBebida.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBebida.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBebida.Iconimage")));
            this.btnBebida.Iconimage_right = null;
            this.btnBebida.Iconimage_right_Selected = null;
            this.btnBebida.Iconimage_Selected = null;
            this.btnBebida.IconMarginLeft = 0;
            this.btnBebida.IconMarginRight = 0;
            this.btnBebida.IconRightVisible = true;
            this.btnBebida.IconRightZoom = 0D;
            this.btnBebida.IconVisible = true;
            this.btnBebida.IconZoom = 50D;
            this.btnBebida.IsTab = false;
            this.btnBebida.Location = new System.Drawing.Point(36, 440);
            this.btnBebida.Name = "btnBebida";
            this.btnBebida.Normalcolor = System.Drawing.Color.DarkRed;
            this.btnBebida.OnHovercolor = System.Drawing.Color.DarkSalmon;
            this.btnBebida.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBebida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBebida.selected = false;
            this.btnBebida.Size = new System.Drawing.Size(440, 48);
            this.btnBebida.TabIndex = 69;
            this.btnBebida.Text = "            BEBIDA";
            this.btnBebida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBebida.Textcolor = System.Drawing.Color.Gold;
            this.btnBebida.TextFont = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBebida.Click += new System.EventHandler(this.BtnBebida_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "            DADOS CLIENTE";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(36, 96);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DarkSalmon;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(966, 48);
            this.bunifuFlatButton1.TabIndex = 70;
            this.bunifuFlatButton1.Text = "            DADOS CLIENTE";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Gold;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FrmNovoPedido
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1123, 760);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.btnBebida);
            this.Controls.Add(this.btnPizzaMeio);
            this.Controls.Add(this.btnPizzaInteira);
            this.Controls.Add(this.labelInteira);
            this.Controls.Add(this.btnFinalizarPedido);
            this.Controls.Add(this.groupBoxBebidas);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelRS);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.comboBoxMotoboy);
            this.Controls.Add(this.labelMotoboy);
            this.Controls.Add(this.groupBoxPizzaMeio);
            this.Controls.Add(this.groupBoxPizza1Sabor);
            this.Controls.Add(this.groupBoxCliente);
            this.Name = "FrmNovoPedido";
            this.Load += new System.EventHandler(this.FrmNovoPedido_Load);
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.groupBoxPizza1Sabor.ResumeLayout(false);
            this.groupBoxPizza1Sabor.PerformLayout();
            this.groupBoxPizzaMeio.ResumeLayout(false);
            this.groupBoxPizzaMeio.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxBebidas.ResumeLayout(false);
            this.groupBoxBebidas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBoxCliente;
		private System.Windows.Forms.Button btnBuscarTel;
		private System.Windows.Forms.TextBox txtPonto_Referencia;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtComplemento;
		private System.Windows.Forms.TextBox txtTelefone;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.GroupBox groupBoxPizza1Sabor;
		private System.Windows.Forms.Button btnIncluir1Sabor;
		private System.Windows.Forms.TextBox txtQtd1Sabor;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox comboBoxPizza1Sabor;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.GroupBox groupBoxPizzaMeio;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.ComboBox comboBoxMeio2;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Button btnIncluirMeio;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox comboBoxMeio1;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label labelMotoboy;
		private System.Windows.Forms.ComboBox comboBoxMotoboy;
		private System.Windows.Forms.RadioButton radioButtonEntrega;
		private System.Windows.Forms.RadioButton radioButtonBalcao;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxPreco;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxPrecoMeio2;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxPrecoMeio1;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label labelRS;
		private System.Windows.Forms.Label labelTotal;
		private System.Windows.Forms.GroupBox groupBoxBebidas;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxPrecoBebida;
		private System.Windows.Forms.Button btnIncluirBebida;
		private System.Windows.Forms.TextBox txtQtdBebida;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.ComboBox comboBoxBebida;
		private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.Label labelInteira;
        private Bunifu.Framework.UI.BunifuFlatButton btnPizzaInteira;
        private Bunifu.Framework.UI.BunifuFlatButton btnPizzaMeio;
        private Bunifu.Framework.UI.BunifuFlatButton btnBebida;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}
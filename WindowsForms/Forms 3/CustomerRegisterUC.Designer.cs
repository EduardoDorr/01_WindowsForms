
using System;

namespace WindowsForms {
  partial class CustomerRegisterUC {
    /// <summary> 
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Designer de Componentes

    /// <summary> 
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRegisterUC));
      this.txtID = new System.Windows.Forms.TextBox();
      this.txtPhone = new System.Windows.Forms.TextBox();
      this.lblPhone = new System.Windows.Forms.Label();
      this.txtJob = new System.Windows.Forms.TextBox();
      this.lblJob = new System.Windows.Forms.Label();
      this.txtFamilyIncome = new System.Windows.Forms.TextBox();
      this.lblFamilyIncome = new System.Windows.Forms.Label();
      this.grbID = new System.Windows.Forms.GroupBox();
      this.grbAddress = new System.Windows.Forms.GroupBox();
      this.cmbStates = new System.Windows.Forms.ComboBox();
      this.txtCity = new System.Windows.Forms.TextBox();
      this.lblCity = new System.Windows.Forms.Label();
      this.lblState = new System.Windows.Forms.Label();
      this.txtDistrict = new System.Windows.Forms.TextBox();
      this.lblDistrict = new System.Windows.Forms.Label();
      this.txtComplement = new System.Windows.Forms.TextBox();
      this.lblComplement = new System.Windows.Forms.Label();
      this.txtStreet = new System.Windows.Forms.TextBox();
      this.lblStreet = new System.Windows.Forms.Label();
      this.txtCEP = new System.Windows.Forms.TextBox();
      this.lblCEP = new System.Windows.Forms.Label();
      this.lblCustomerName = new System.Windows.Forms.Label();
      this.txtCustomerName = new System.Windows.Forms.TextBox();
      this.lblFatherName = new System.Windows.Forms.Label();
      this.txtFatherName = new System.Windows.Forms.TextBox();
      this.lblCPF = new System.Windows.Forms.Label();
      this.txtCPF = new System.Windows.Forms.TextBox();
      this.grbPersonalData = new System.Windows.Forms.GroupBox();
      this.txtMotherName = new System.Windows.Forms.TextBox();
      this.lblMotherName = new System.Windows.Forms.Label();
      this.grbGender = new System.Windows.Forms.GroupBox();
      this.rdbNoGender = new System.Windows.Forms.RadioButton();
      this.rdbFemale = new System.Windows.Forms.RadioButton();
      this.rdbMale = new System.Windows.Forms.RadioButton();
      this.chkHasFather = new System.Windows.Forms.CheckBox();
      this.txtRG = new System.Windows.Forms.TextBox();
      this.lblRG = new System.Windows.Forms.Label();
      this.grbOthers = new System.Windows.Forms.GroupBox();
      this.tlsMain = new System.Windows.Forms.ToolStrip();
      this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.cleanToolStripButton = new System.Windows.Forms.ToolStripButton();
      this.btnSearch = new System.Windows.Forms.Button();
      this.grbID.SuspendLayout();
      this.grbAddress.SuspendLayout();
      this.grbPersonalData.SuspendLayout();
      this.grbGender.SuspendLayout();
      this.grbOthers.SuspendLayout();
      this.tlsMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtID
      // 
      this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtID.Location = new System.Drawing.Point(6, 19);
      this.txtID.Name = "txtID";
      this.txtID.Size = new System.Drawing.Size(174, 20);
      this.txtID.TabIndex = 1;
      // 
      // txtPhone
      // 
      this.txtPhone.Location = new System.Drawing.Point(6, 32);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new System.Drawing.Size(353, 20);
      this.txtPhone.TabIndex = 15;
      // 
      // lblPhone
      // 
      this.lblPhone.AutoSize = true;
      this.lblPhone.Location = new System.Drawing.Point(6, 16);
      this.lblPhone.Name = "lblPhone";
      this.lblPhone.Size = new System.Drawing.Size(49, 13);
      this.lblPhone.TabIndex = 20;
      this.lblPhone.Text = "Telefone";
      // 
      // txtJob
      // 
      this.txtJob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtJob.Location = new System.Drawing.Point(365, 32);
      this.txtJob.Name = "txtJob";
      this.txtJob.Size = new System.Drawing.Size(415, 20);
      this.txtJob.TabIndex = 16;
      // 
      // lblJob
      // 
      this.lblJob.AutoSize = true;
      this.lblJob.Location = new System.Drawing.Point(365, 16);
      this.lblJob.Name = "lblJob";
      this.lblJob.Size = new System.Drawing.Size(50, 13);
      this.lblJob.TabIndex = 22;
      this.lblJob.Text = "Profissão";
      // 
      // txtFamilyIncome
      // 
      this.txtFamilyIncome.Location = new System.Drawing.Point(6, 72);
      this.txtFamilyIncome.Name = "txtFamilyIncome";
      this.txtFamilyIncome.Size = new System.Drawing.Size(353, 20);
      this.txtFamilyIncome.TabIndex = 17;
      // 
      // lblFamilyIncome
      // 
      this.lblFamilyIncome.AutoSize = true;
      this.lblFamilyIncome.Location = new System.Drawing.Point(6, 56);
      this.lblFamilyIncome.Name = "lblFamilyIncome";
      this.lblFamilyIncome.Size = new System.Drawing.Size(77, 13);
      this.lblFamilyIncome.TabIndex = 24;
      this.lblFamilyIncome.Text = "Renda Familiar";
      // 
      // grbID
      // 
      this.grbID.Controls.Add(this.btnSearch);
      this.grbID.Controls.Add(this.txtID);
      this.grbID.Location = new System.Drawing.Point(12, 28);
      this.grbID.Name = "grbID";
      this.grbID.Size = new System.Drawing.Size(271, 51);
      this.grbID.TabIndex = 1;
      this.grbID.TabStop = false;
      this.grbID.Text = "ID";
      // 
      // grbAddress
      // 
      this.grbAddress.Controls.Add(this.cmbStates);
      this.grbAddress.Controls.Add(this.txtCity);
      this.grbAddress.Controls.Add(this.lblCity);
      this.grbAddress.Controls.Add(this.lblState);
      this.grbAddress.Controls.Add(this.txtDistrict);
      this.grbAddress.Controls.Add(this.lblDistrict);
      this.grbAddress.Controls.Add(this.txtComplement);
      this.grbAddress.Controls.Add(this.lblComplement);
      this.grbAddress.Controls.Add(this.txtStreet);
      this.grbAddress.Controls.Add(this.lblStreet);
      this.grbAddress.Controls.Add(this.txtCEP);
      this.grbAddress.Controls.Add(this.lblCEP);
      this.grbAddress.Location = new System.Drawing.Point(12, 274);
      this.grbAddress.Name = "grbAddress";
      this.grbAddress.Size = new System.Drawing.Size(786, 145);
      this.grbAddress.TabIndex = 3;
      this.grbAddress.TabStop = false;
      this.grbAddress.Text = "Endereço";
      // 
      // cmbStates
      // 
      this.cmbStates.FormattingEnabled = true;
      this.cmbStates.Location = new System.Drawing.Point(365, 110);
      this.cmbStates.Name = "cmbStates";
      this.cmbStates.Size = new System.Drawing.Size(415, 21);
      this.cmbStates.TabIndex = 14;
      // 
      // txtCity
      // 
      this.txtCity.Location = new System.Drawing.Point(6, 110);
      this.txtCity.Name = "txtCity";
      this.txtCity.Size = new System.Drawing.Size(353, 20);
      this.txtCity.TabIndex = 13;
      // 
      // lblCity
      // 
      this.lblCity.AutoSize = true;
      this.lblCity.Location = new System.Drawing.Point(6, 94);
      this.lblCity.Name = "lblCity";
      this.lblCity.Size = new System.Drawing.Size(40, 13);
      this.lblCity.TabIndex = 30;
      this.lblCity.Text = "Cidade";
      // 
      // lblState
      // 
      this.lblState.AutoSize = true;
      this.lblState.Location = new System.Drawing.Point(365, 94);
      this.lblState.Name = "lblState";
      this.lblState.Size = new System.Drawing.Size(40, 13);
      this.lblState.TabIndex = 28;
      this.lblState.Text = "Estado";
      // 
      // txtDistrict
      // 
      this.txtDistrict.Location = new System.Drawing.Point(365, 71);
      this.txtDistrict.Name = "txtDistrict";
      this.txtDistrict.Size = new System.Drawing.Size(415, 20);
      this.txtDistrict.TabIndex = 12;
      // 
      // lblDistrict
      // 
      this.lblDistrict.AutoSize = true;
      this.lblDistrict.Location = new System.Drawing.Point(365, 55);
      this.lblDistrict.Name = "lblDistrict";
      this.lblDistrict.Size = new System.Drawing.Size(34, 13);
      this.lblDistrict.TabIndex = 26;
      this.lblDistrict.Text = "Bairro";
      // 
      // txtComplement
      // 
      this.txtComplement.Location = new System.Drawing.Point(6, 71);
      this.txtComplement.Name = "txtComplement";
      this.txtComplement.Size = new System.Drawing.Size(353, 20);
      this.txtComplement.TabIndex = 11;
      // 
      // lblComplement
      // 
      this.lblComplement.AutoSize = true;
      this.lblComplement.Location = new System.Drawing.Point(6, 55);
      this.lblComplement.Name = "lblComplement";
      this.lblComplement.Size = new System.Drawing.Size(71, 13);
      this.lblComplement.TabIndex = 24;
      this.lblComplement.Text = "Complemento";
      // 
      // txtStreet
      // 
      this.txtStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtStreet.Location = new System.Drawing.Point(119, 32);
      this.txtStreet.Name = "txtStreet";
      this.txtStreet.Size = new System.Drawing.Size(661, 20);
      this.txtStreet.TabIndex = 10;
      // 
      // lblStreet
      // 
      this.lblStreet.AutoSize = true;
      this.lblStreet.Location = new System.Drawing.Point(119, 16);
      this.lblStreet.Name = "lblStreet";
      this.lblStreet.Size = new System.Drawing.Size(61, 13);
      this.lblStreet.TabIndex = 22;
      this.lblStreet.Text = "Logradouro";
      // 
      // txtCEP
      // 
      this.txtCEP.Location = new System.Drawing.Point(6, 32);
      this.txtCEP.Name = "txtCEP";
      this.txtCEP.Size = new System.Drawing.Size(107, 20);
      this.txtCEP.TabIndex = 9;
      this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
      // 
      // lblCEP
      // 
      this.lblCEP.AutoSize = true;
      this.lblCEP.Location = new System.Drawing.Point(6, 16);
      this.lblCEP.Name = "lblCEP";
      this.lblCEP.Size = new System.Drawing.Size(28, 13);
      this.lblCEP.TabIndex = 20;
      this.lblCEP.Text = "CEP";
      // 
      // lblCustomerName
      // 
      this.lblCustomerName.AutoSize = true;
      this.lblCustomerName.Location = new System.Drawing.Point(7, 16);
      this.lblCustomerName.Name = "lblCustomerName";
      this.lblCustomerName.Size = new System.Drawing.Size(35, 13);
      this.lblCustomerName.TabIndex = 28;
      this.lblCustomerName.Text = "Nome";
      // 
      // txtCustomerName
      // 
      this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtCustomerName.Location = new System.Drawing.Point(6, 32);
      this.txtCustomerName.Name = "txtCustomerName";
      this.txtCustomerName.Size = new System.Drawing.Size(774, 20);
      this.txtCustomerName.TabIndex = 2;
      // 
      // lblFatherName
      // 
      this.lblFatherName.AutoSize = true;
      this.lblFatherName.Location = new System.Drawing.Point(6, 94);
      this.lblFatherName.Name = "lblFatherName";
      this.lblFatherName.Size = new System.Drawing.Size(68, 13);
      this.lblFatherName.TabIndex = 30;
      this.lblFatherName.Text = "Nome do Pai";
      // 
      // txtFatherName
      // 
      this.txtFatherName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFatherName.Location = new System.Drawing.Point(6, 110);
      this.txtFatherName.Name = "txtFatherName";
      this.txtFatherName.Size = new System.Drawing.Size(753, 20);
      this.txtFatherName.TabIndex = 4;
      // 
      // lblCPF
      // 
      this.lblCPF.AutoSize = true;
      this.lblCPF.Location = new System.Drawing.Point(231, 136);
      this.lblCPF.Name = "lblCPF";
      this.lblCPF.Size = new System.Drawing.Size(27, 13);
      this.lblCPF.TabIndex = 36;
      this.lblCPF.Text = "CPF";
      // 
      // txtCPF
      // 
      this.txtCPF.Location = new System.Drawing.Point(231, 152);
      this.txtCPF.Name = "txtCPF";
      this.txtCPF.Size = new System.Drawing.Size(277, 20);
      this.txtCPF.TabIndex = 7;
      // 
      // grbPersonalData
      // 
      this.grbPersonalData.Controls.Add(this.txtMotherName);
      this.grbPersonalData.Controls.Add(this.lblMotherName);
      this.grbPersonalData.Controls.Add(this.grbGender);
      this.grbPersonalData.Controls.Add(this.chkHasFather);
      this.grbPersonalData.Controls.Add(this.txtRG);
      this.grbPersonalData.Controls.Add(this.lblRG);
      this.grbPersonalData.Controls.Add(this.txtCPF);
      this.grbPersonalData.Controls.Add(this.lblCPF);
      this.grbPersonalData.Controls.Add(this.txtFatherName);
      this.grbPersonalData.Controls.Add(this.lblFatherName);
      this.grbPersonalData.Controls.Add(this.txtCustomerName);
      this.grbPersonalData.Controls.Add(this.lblCustomerName);
      this.grbPersonalData.Location = new System.Drawing.Point(12, 85);
      this.grbPersonalData.Name = "grbPersonalData";
      this.grbPersonalData.Size = new System.Drawing.Size(787, 183);
      this.grbPersonalData.TabIndex = 2;
      this.grbPersonalData.TabStop = false;
      this.grbPersonalData.Text = "Dados Pessoais";
      // 
      // txtMotherName
      // 
      this.txtMotherName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtMotherName.Location = new System.Drawing.Point(6, 71);
      this.txtMotherName.Name = "txtMotherName";
      this.txtMotherName.Size = new System.Drawing.Size(774, 20);
      this.txtMotherName.TabIndex = 3;
      // 
      // lblMotherName
      // 
      this.lblMotherName.AutoSize = true;
      this.lblMotherName.Location = new System.Drawing.Point(6, 55);
      this.lblMotherName.Name = "lblMotherName";
      this.lblMotherName.Size = new System.Drawing.Size(74, 13);
      this.lblMotherName.TabIndex = 42;
      this.lblMotherName.Text = "Nome da Mãe";
      // 
      // grbGender
      // 
      this.grbGender.Controls.Add(this.rdbNoGender);
      this.grbGender.Controls.Add(this.rdbFemale);
      this.grbGender.Controls.Add(this.rdbMale);
      this.grbGender.Location = new System.Drawing.Point(6, 139);
      this.grbGender.Name = "grbGender";
      this.grbGender.Size = new System.Drawing.Size(219, 33);
      this.grbGender.TabIndex = 6;
      this.grbGender.TabStop = false;
      this.grbGender.Text = "Gênero";
      // 
      // rdbNoGender
      // 
      this.rdbNoGender.AutoSize = true;
      this.rdbNoGender.Location = new System.Drawing.Point(156, 13);
      this.rdbNoGender.Name = "rdbNoGender";
      this.rdbNoGender.Size = new System.Drawing.Size(51, 17);
      this.rdbNoGender.TabIndex = 2;
      this.rdbNoGender.TabStop = true;
      this.rdbNoGender.Text = "Outro";
      this.rdbNoGender.UseVisualStyleBackColor = true;
      // 
      // rdbFemale
      // 
      this.rdbFemale.AutoSize = true;
      this.rdbFemale.Location = new System.Drawing.Point(83, 13);
      this.rdbFemale.Name = "rdbFemale";
      this.rdbFemale.Size = new System.Drawing.Size(67, 17);
      this.rdbFemale.TabIndex = 1;
      this.rdbFemale.TabStop = true;
      this.rdbFemale.Text = "Feminino";
      this.rdbFemale.UseVisualStyleBackColor = true;
      // 
      // rdbMale
      // 
      this.rdbMale.AutoSize = true;
      this.rdbMale.Location = new System.Drawing.Point(4, 13);
      this.rdbMale.Name = "rdbMale";
      this.rdbMale.Size = new System.Drawing.Size(73, 17);
      this.rdbMale.TabIndex = 0;
      this.rdbMale.TabStop = true;
      this.rdbMale.Text = "Masculino";
      this.rdbMale.UseVisualStyleBackColor = true;
      // 
      // chkHasFather
      // 
      this.chkHasFather.AutoSize = true;
      this.chkHasFather.Location = new System.Drawing.Point(765, 113);
      this.chkHasFather.Name = "chkHasFather";
      this.chkHasFather.Size = new System.Drawing.Size(15, 14);
      this.chkHasFather.TabIndex = 5;
      this.chkHasFather.UseVisualStyleBackColor = true;
      this.chkHasFather.CheckedChanged += new System.EventHandler(this.chkHasFather_CheckedChanged);
      // 
      // txtRG
      // 
      this.txtRG.Location = new System.Drawing.Point(514, 152);
      this.txtRG.Name = "txtRG";
      this.txtRG.Size = new System.Drawing.Size(266, 20);
      this.txtRG.TabIndex = 8;
      // 
      // lblRG
      // 
      this.lblRG.AutoSize = true;
      this.lblRG.Location = new System.Drawing.Point(514, 136);
      this.lblRG.Name = "lblRG";
      this.lblRG.Size = new System.Drawing.Size(23, 13);
      this.lblRG.TabIndex = 38;
      this.lblRG.Text = "RG";
      // 
      // grbOthers
      // 
      this.grbOthers.Controls.Add(this.lblPhone);
      this.grbOthers.Controls.Add(this.txtPhone);
      this.grbOthers.Controls.Add(this.lblJob);
      this.grbOthers.Controls.Add(this.txtJob);
      this.grbOthers.Controls.Add(this.txtFamilyIncome);
      this.grbOthers.Controls.Add(this.lblFamilyIncome);
      this.grbOthers.Location = new System.Drawing.Point(12, 425);
      this.grbOthers.Name = "grbOthers";
      this.grbOthers.Size = new System.Drawing.Size(786, 100);
      this.grbOthers.TabIndex = 4;
      this.grbOthers.TabStop = false;
      this.grbOthers.Text = "Outros";
      // 
      // tlsMain
      // 
      this.tlsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.deleteToolStripButton,
            this.cleanToolStripButton});
      this.tlsMain.Location = new System.Drawing.Point(0, 0);
      this.tlsMain.Name = "tlsMain";
      this.tlsMain.Size = new System.Drawing.Size(806, 25);
      this.tlsMain.TabIndex = 32;
      this.tlsMain.Text = "toolStrip1";
      // 
      // newToolStripButton
      // 
      this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
      this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.newToolStripButton.Name = "newToolStripButton";
      this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.newToolStripButton.Text = "&Novo";
      this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
      // 
      // openToolStripButton
      // 
      this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
      this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.openToolStripButton.Name = "openToolStripButton";
      this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.openToolStripButton.Text = "&Abrir";
      this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
      // 
      // saveToolStripButton
      // 
      this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
      this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolStripButton.Name = "saveToolStripButton";
      this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.saveToolStripButton.Text = "&Salvar";
      this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
      // 
      // deleteToolStripButton
      // 
      this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.deleteToolStripButton.Image = global::WindowsForms.Properties.Resources.imgDeleteBar;
      this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.deleteToolStripButton.Name = "deleteToolStripButton";
      this.deleteToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.deleteToolStripButton.Text = "&Excluir";
      this.deleteToolStripButton.ToolTipText = "Excluir";
      this.deleteToolStripButton.Click += new System.EventHandler(this.deleteToolStripButton_Click);
      // 
      // cleanToolStripButton
      // 
      this.cleanToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.cleanToolStripButton.Image = global::WindowsForms.Properties.Resources.imgCleanBar;
      this.cleanToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cleanToolStripButton.Name = "cleanToolStripButton";
      this.cleanToolStripButton.Size = new System.Drawing.Size(23, 22);
      this.cleanToolStripButton.Text = "&Limpar";
      this.cleanToolStripButton.Click += new System.EventHandler(this.cleanToolStripButton_Click);
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(186, 17);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 24);
      this.btnSearch.TabIndex = 2;
      this.btnSearch.Text = "Buscar";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // CustomerRegisterUC
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tlsMain);
      this.Controls.Add(this.grbOthers);
      this.Controls.Add(this.grbAddress);
      this.Controls.Add(this.grbPersonalData);
      this.Controls.Add(this.grbID);
      this.Cursor = System.Windows.Forms.Cursors.Default;
      this.Name = "CustomerRegisterUC";
      this.Size = new System.Drawing.Size(806, 537);
      this.grbID.ResumeLayout(false);
      this.grbID.PerformLayout();
      this.grbAddress.ResumeLayout(false);
      this.grbAddress.PerformLayout();
      this.grbPersonalData.ResumeLayout(false);
      this.grbPersonalData.PerformLayout();
      this.grbGender.ResumeLayout(false);
      this.grbGender.PerformLayout();
      this.grbOthers.ResumeLayout(false);
      this.grbOthers.PerformLayout();
      this.tlsMain.ResumeLayout(false);
      this.tlsMain.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox txtID;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.Label lblPhone;
    private System.Windows.Forms.TextBox txtJob;
    private System.Windows.Forms.Label lblJob;
    private System.Windows.Forms.TextBox txtFamilyIncome;
    private System.Windows.Forms.Label lblFamilyIncome;
    private System.Windows.Forms.GroupBox grbID;
    private System.Windows.Forms.GroupBox grbAddress;
    private System.Windows.Forms.Label lblState;
    private System.Windows.Forms.TextBox txtDistrict;
    private System.Windows.Forms.Label lblDistrict;
    private System.Windows.Forms.TextBox txtComplement;
    private System.Windows.Forms.Label lblComplement;
    private System.Windows.Forms.TextBox txtStreet;
    private System.Windows.Forms.Label lblStreet;
    private System.Windows.Forms.TextBox txtCEP;
    private System.Windows.Forms.Label lblCEP;
    private System.Windows.Forms.Label lblCustomerName;
    private System.Windows.Forms.TextBox txtCustomerName;
    private System.Windows.Forms.Label lblFatherName;
    private System.Windows.Forms.TextBox txtFatherName;
    private System.Windows.Forms.Label lblCPF;
    private System.Windows.Forms.TextBox txtCPF;
    private System.Windows.Forms.GroupBox grbPersonalData;
    private System.Windows.Forms.TextBox txtRG;
    private System.Windows.Forms.Label lblRG;
    private System.Windows.Forms.GroupBox grbOthers;
    private System.Windows.Forms.TextBox txtCity;
    private System.Windows.Forms.Label lblCity;
    private System.Windows.Forms.CheckBox chkHasFather;
    private System.Windows.Forms.GroupBox grbGender;
    private System.Windows.Forms.RadioButton rdbNoGender;
    private System.Windows.Forms.RadioButton rdbFemale;
    private System.Windows.Forms.RadioButton rdbMale;
    private System.Windows.Forms.TextBox txtMotherName;
    private System.Windows.Forms.Label lblMotherName;
    private System.Windows.Forms.ComboBox cmbStates;
    private System.Windows.Forms.ToolStrip tlsMain;
    private System.Windows.Forms.ToolStripButton newToolStripButton;
    private System.Windows.Forms.ToolStripButton openToolStripButton;
    private System.Windows.Forms.ToolStripButton saveToolStripButton;
    private System.Windows.Forms.ToolStripButton deleteToolStripButton;
    private System.Windows.Forms.ToolStripButton cleanToolStripButton;
    private System.Windows.Forms.Button btnSearch;
  }
}

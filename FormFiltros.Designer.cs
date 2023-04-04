namespace PrototipoIntegracoesAssurant
{
    partial class FormFiltros
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroBilheteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDeSerieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorBilheteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDoProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prazoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.segurosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segurosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "TODAS",
            "1006 - LB BONOCO",
            "1007 - LB SAO CRISTOVAO",
            "1008 - LB COMERCIO",
            "1010 - LB SALVADOR SHOPPING",
            "1011 - LB SH BOULEVARD FEIRA",
            "1012 - LB SH RIOMAR ARACAJU",
            "1013 - LB CAMACARI",
            "1014 - LB SH PARALELA",
            "1015 - LB SH CONQ. SUL",
            "1016 - LB SH ITAGUARY",
            "1017 - LB SH SALVADOR NORTE SH",
            "1018 - LB SH DA BAHIA",
            "1019 - LB SH JEQUITIBA",
            "1020 - LB SH D. PEDRO",
            "1022 - LB SH PREMIO",
            "1023 - LB SH DA ILHA",
            "1024 - LB SH MOOCA",
            "1025 - LB SIMOES FILHO",
            "1027 - LB SH RECIFE",
            "1029 - LB SH BELA VISTA",
            "1030 - LB RIOMAR RECIFE",
            "1031 - LB CARUARU ",
            "1032 - LB SH MIDWAY MALL",
            "1033 - LB CENTER TIBERY",
            "1034 - LB UBERLANDIA SHOPPING",
            "1036 - LB TERESINA RUA",
            "1038 - LB IMPERIAL SHOPPING",
            "1041 - LB SAO BERNARDO",
            "1042 - LB BELEM RUA - PA",
            "1043 - LB NACOES BAURU",
            "1044 - LB PQ SHOP BELEM",
            "1045 - LB LITORAL NORTE",
            "1047 - LB PATIO ARAPIRACA",
            "1049 - LB BARREIRAS",
            "1050 - LB RUA GRANDE",
            "1051 - LB NORTH SH SOBRAL",
            "1052 - LB WEST SH MOSSORO",
            "1053 - LB NORTH SH JOQUEI",
            "1056 - LB ALAGOINHAS",
            "1057 - LB PQ SH MACEIO",
            "1058 - LB RIVER SH PETROLINA",
            "1059 - LB JEQUIE RUA",
            "1063 - LB RIO ANIL",
            "1064 - LB SH PARANGABA",
            "1065 - LB SH DOS HOLANDESES",
            "1066 - LB SH PATIO MACEIO",
            "1067 - LB MACEIO SHOPPING",
            "1068 - LB PITUBA",
            "1069 - LB PAULO AFONSO",
            "1070 - LB SAO LUIS SH",
            "1071 - LB TACARUNA",
            "1074 - LB LIBERDADE",
            "1075 - LB SH JARDINS",
            "1076 - LB LUIS EDUARDO",
            "1077 - LB MARACANAU",
            "1079 - LB SH RIOMAR FORTALEZA",
            "1080 - LB SH MANGABEIRAS",
            "1081 - LB PATIO NORTE",
            "1082 - LB IGUATEMI FORTALEZA",
            "1083 - LB NORTH WAY PAULISTA",
            "1084 - LB RIO POTY",
            "1087 - LB NATAL NORTE SH",
            "1088 - LB SH GUARARAPES",
            "1089 - LB SH RIOMAR PRES KENNEDY",
            "1090 - LB SH MANAIRA",
            "1091 - LB SH PEIXOTO",
            "1092 - LB SH CAJAZEIRAS",
            "1093 - LB SH BOULEVARD BELEM",
            "1094 - LB SH COSTA DOURADA",
            "1095 - LB NORTH SH FORTALEZA",
            "1096 - LB GOLDEN CALHAU",
            "1097 - LB BOULEVARD TROPICAL",
            "1098 - LB SH TAMBIA",
            "1099 - LB EUNAPOLIS",
            "1100 - LB SH PARTAGE CP GRANDE",
            "1101 - LB SH METROPOLE",
            "1102 - LB SH PIEDADE",
            "1103 - LB SH ITAU POWER",
            "1105 - LB CONQUISTA RUA",
            "1107 - LB SH CAMARA",
            "1108 - LB SH PATTEO OLINDA",
            "1109 - LB SH PARTAGE PARAUAPEBAS",
            "1110 - LB SH B GRAO PARA",
            "1111 - LB SH BOULEVARD CAMAÇARI",
            "1112 - LB SH MOXUARA",
            "1113 - LB SH MONTSERRAT",
            "1114 - LB SH VITORIA",
            "1115 - LB TEIXEIRA DE FREITAS",
            "1116 - LB JUAZEIRO RUA",
            "1117 - LB SH BARRA",
            "1118 - LB GETULIO VARGAS FSA",
            "1119 - LB SANTA INES RUA",
            "1120 - LB RECIFE CENTRO",
            "1121 - LB SH BOA VISTA",
            "1122 - LB SH MAUA PLAZA",
            "1123 - LB SH LITORAL PLAZA",
            "1124 - LB SH MESTRE ALVARO",
            "1125 - LB SH PRAIA DA COSTA",
            "1126 - LB SH VILA VELHA",
            "1127 - LB MOSSORO RUA",
            "1128 - LB ARACAJU PARQUE SH",
            "1129 - LB SH IT CENTER",
            "1130 - LB AGUAS CLARAS RUA",
            "1131 - LB SH PATIO BELEM",
            "1132 - LB SH PATIO MARABA",
            "1134 - LB PATOS SH",
            "1135 - LB SH DIFUSORA",
            "1136 - LB VITORIA DE S ANTAO RUA",
            "1137 - LB SENHOR DOS PASSOS",
            "1138 - LB TERESINA SHOPPING",
            "1140 - LB SH VIA BRASIL",
            "1141 - LB BIG SHOPPING",
            "1142 - LB GRAND SH MESSEJANA",
            "1143 - LB PASSEIO DAS AGUAS",
            "1144 - LB CASTANHAL",
            "1145 - LB SH CERRADO",
            "1146 - LB SH BETIM",
            "1147 - LB PIAUI SH",
            "1148 - LB TIETE PLAZA SH",
            "1151 - LB PQ SH MAIA",
            "1152 - LB SH ESTACAO BH",
            "1153 - LB SH CIDADE",
            "1154 - LB PQ SH BAHIA",
            "1155 - LB ICOARACI",
            "1157 - LB SH VIA SUL",
            "1158 - LB MINAS SHOPPING",
            "1159 - LB CRUZ DAS ALMAS",
            "1160 - LB SH RIO TAPAJOS",
            "1161 - LB MADALENA"});
            this.comboBox1.Location = new System.Drawing.Point(44, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteCustomSource.AddRange(new string[] {
            "GARANTIA ESTENDIDA",
            "SEGURO DE CELULAR"});
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "TUDO",
            "GARANTIA ESTENDIDA",
            "SEGURO DE CELULAR"});
            this.comboBox3.Location = new System.Drawing.Point(605, 7);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(145, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Loja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(349, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn,
            this.lojaDataGridViewTextBoxColumn,
            this.numeroBilheteDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.numeroDeSerieDataGridViewTextBoxColumn,
            this.valorBilheteDataGridViewTextBoxColumn,
            this.valorDoProdutoDataGridViewTextBoxColumn,
            this.planoDataGridViewTextBoxColumn,
            this.prazoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.Editar});
            this.dataGridView1.DataSource = this.segurosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1146, 309);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lojaDataGridViewTextBoxColumn
            // 
            this.lojaDataGridViewTextBoxColumn.DataPropertyName = "Loja";
            this.lojaDataGridViewTextBoxColumn.HeaderText = "Loja";
            this.lojaDataGridViewTextBoxColumn.Name = "lojaDataGridViewTextBoxColumn";
            this.lojaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroBilheteDataGridViewTextBoxColumn
            // 
            this.numeroBilheteDataGridViewTextBoxColumn.DataPropertyName = "NumeroBilhete";
            this.numeroBilheteDataGridViewTextBoxColumn.HeaderText = "NumeroBilhete";
            this.numeroBilheteDataGridViewTextBoxColumn.Name = "numeroBilheteDataGridViewTextBoxColumn";
            this.numeroBilheteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDeSerieDataGridViewTextBoxColumn
            // 
            this.numeroDeSerieDataGridViewTextBoxColumn.DataPropertyName = "NumeroDeSerie";
            this.numeroDeSerieDataGridViewTextBoxColumn.HeaderText = "NumeroDeSerie";
            this.numeroDeSerieDataGridViewTextBoxColumn.Name = "numeroDeSerieDataGridViewTextBoxColumn";
            this.numeroDeSerieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorBilheteDataGridViewTextBoxColumn
            // 
            this.valorBilheteDataGridViewTextBoxColumn.DataPropertyName = "ValorBilhete";
            this.valorBilheteDataGridViewTextBoxColumn.HeaderText = "ValorBilhete";
            this.valorBilheteDataGridViewTextBoxColumn.Name = "valorBilheteDataGridViewTextBoxColumn";
            this.valorBilheteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDoProdutoDataGridViewTextBoxColumn
            // 
            this.valorDoProdutoDataGridViewTextBoxColumn.DataPropertyName = "ValorDoProduto";
            this.valorDoProdutoDataGridViewTextBoxColumn.HeaderText = "ValorDoProduto";
            this.valorDoProdutoDataGridViewTextBoxColumn.Name = "valorDoProdutoDataGridViewTextBoxColumn";
            this.valorDoProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // planoDataGridViewTextBoxColumn
            // 
            this.planoDataGridViewTextBoxColumn.DataPropertyName = "Plano";
            this.planoDataGridViewTextBoxColumn.HeaderText = "Plano";
            this.planoDataGridViewTextBoxColumn.Name = "planoDataGridViewTextBoxColumn";
            this.planoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prazoDataGridViewTextBoxColumn
            // 
            this.prazoDataGridViewTextBoxColumn.DataPropertyName = "Prazo";
            this.prazoDataGridViewTextBoxColumn.HeaderText = "Prazo";
            this.prazoDataGridViewTextBoxColumn.Name = "prazoDataGridViewTextBoxColumn";
            this.prazoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Editar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "Modificar";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Editar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Editar.HeaderText = "Ações";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            // 
            // segurosBindingSource
            // 
            this.segurosBindingSource.DataSource = typeof(PrototipoIntegracoesAssurant.FormFiltros.Seguros);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(60, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total de Operações";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(40, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Operações Aprovadas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(40, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Operações Rejeitadas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(251, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(251, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(251, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1059, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Reprocessar todos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(770, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Status";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "GARANTIA ESTENDIDA",
            "SEGURO DE CELULAR"});
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "TODOS",
            "APROVADOS",
            "REJEITADOS"});
            this.comboBox2.Location = new System.Drawing.Point(813, 7);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(145, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // FormFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormFiltros";
            this.Text = "FormFiltros";
            this.Load += new System.EventHandler(this.FormFiltros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segurosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource segurosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroBilheteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDeSerieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorBilheteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDoProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prazoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}
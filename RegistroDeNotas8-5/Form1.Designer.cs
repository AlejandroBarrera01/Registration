namespace RegistroDeNotas8_5
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxStudentIDRegisterStudent = new System.Windows.Forms.TextBox();
            this.TextBoxNameRegisterStudents = new System.Windows.Forms.TextBox();
            this.TextBoxLastNameStudents = new System.Windows.Forms.TextBox();
            this.ComboBoxSubject = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ComboxBuscar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxAprovados = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DatagridRegisterNotes = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxRegisterNotesSubject = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridRegisterNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(250, 23);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1228, 563);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.btnRegister);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TextBoxStudentIDRegisterStudent);
            this.tabPage1.Controls.Add(this.TextBoxNameRegisterStudents);
            this.tabPage1.Controls.Add(this.TextBoxLastNameStudents);
            this.tabPage1.Controls.Add(this.ComboBoxSubject);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1220, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register Students";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.Location = new System.Drawing.Point(99, 180);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(87, 28);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Names";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student ID";
            // 
            // TextBoxStudentIDRegisterStudent
            // 
            this.TextBoxStudentIDRegisterStudent.Location = new System.Drawing.Point(99, 41);
            this.TextBoxStudentIDRegisterStudent.Name = "TextBoxStudentIDRegisterStudent";
            this.TextBoxStudentIDRegisterStudent.Size = new System.Drawing.Size(121, 26);
            this.TextBoxStudentIDRegisterStudent.TabIndex = 1;
            // 
            // TextBoxNameRegisterStudents
            // 
            this.TextBoxNameRegisterStudents.Location = new System.Drawing.Point(99, 73);
            this.TextBoxNameRegisterStudents.Name = "TextBoxNameRegisterStudents";
            this.TextBoxNameRegisterStudents.Size = new System.Drawing.Size(121, 26);
            this.TextBoxNameRegisterStudents.TabIndex = 2;
            // 
            // TextBoxLastNameStudents
            // 
            this.TextBoxLastNameStudents.Location = new System.Drawing.Point(99, 105);
            this.TextBoxLastNameStudents.Name = "TextBoxLastNameStudents";
            this.TextBoxLastNameStudents.Size = new System.Drawing.Size(121, 26);
            this.TextBoxLastNameStudents.TabIndex = 3;
            // 
            // ComboBoxSubject
            // 
            this.ComboBoxSubject.FormattingEnabled = true;
            this.ComboBoxSubject.Items.AddRange(new object[] {
            "Math",
            "Reading",
            "Dance",
            "History"});
            this.ComboBoxSubject.Location = new System.Drawing.Point(99, 137);
            this.ComboBoxSubject.Name = "ComboBoxSubject";
            this.ComboBoxSubject.Size = new System.Drawing.Size(121, 28);
            this.ComboBoxSubject.TabIndex = 4;
            this.ComboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSubject_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.ComboxBuscar);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnBuscar);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.TextBoxAprovados);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.DatagridRegisterNotes);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.ComboBoxRegisterNotesSubject);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1220, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Register Notes";
            // 
            // ComboxBuscar
            // 
            this.ComboxBuscar.FormattingEnabled = true;
            this.ComboxBuscar.Location = new System.Drawing.Point(912, 30);
            this.ComboxBuscar.Name = "ComboxBuscar";
            this.ComboxBuscar.Size = new System.Drawing.Size(81, 28);
            this.ComboxBuscar.TabIndex = 21;
            this.ComboxBuscar.SelectedIndexChanged += new System.EventHandler(this.ComboxBuscar_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(922, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "ID";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(999, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 34);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(622, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Aprovados/Reprovados";
            // 
            // TextBoxAprovados
            // 
            this.TextBoxAprovados.Location = new System.Drawing.Point(617, 33);
            this.TextBoxAprovados.Multiline = true;
            this.TextBoxAprovados.Name = "TextBoxAprovados";
            this.TextBoxAprovados.Size = new System.Drawing.Size(191, 87);
            this.TextBoxAprovados.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(261, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 27);
            this.button1.TabIndex = 14;
            this.button1.Text = "Guardar Datos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DatagridRegisterNotes
            // 
            this.DatagridRegisterNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridRegisterNotes.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DatagridRegisterNotes.Location = new System.Drawing.Point(14, 126);
            this.DatagridRegisterNotes.Name = "DatagridRegisterNotes";
            this.DatagridRegisterNotes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DatagridRegisterNotes.Size = new System.Drawing.Size(1203, 403);
            this.DatagridRegisterNotes.TabIndex = 13;
            this.DatagridRegisterNotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridRegisterNotes_CellClick);
            this.DatagridRegisterNotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridRegisterNotes_CellContentClick);
            this.DatagridRegisterNotes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridRegisterNotes_CellEndEdit);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Subject";
            // 
            // ComboBoxRegisterNotesSubject
            // 
            this.ComboBoxRegisterNotesSubject.FormattingEnabled = true;
            this.ComboBoxRegisterNotesSubject.Items.AddRange(new object[] {
            "Math",
            "Reading",
            "Dance",
            "History"});
            this.ComboBoxRegisterNotesSubject.Location = new System.Drawing.Point(85, 15);
            this.ComboBoxRegisterNotesSubject.Name = "ComboBoxRegisterNotesSubject";
            this.ComboBoxRegisterNotesSubject.Size = new System.Drawing.Size(121, 28);
            this.ComboBoxRegisterNotesSubject.TabIndex = 6;
            this.ComboBoxRegisterNotesSubject.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRegisterNotesSubject_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 570);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Registro De Notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridRegisterNotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxStudentIDRegisterStudent;
        private System.Windows.Forms.TextBox TextBoxNameRegisterStudents;
        private System.Windows.Forms.TextBox TextBoxLastNameStudents;
        private System.Windows.Forms.ComboBox ComboBoxSubject;
        private System.Windows.Forms.DataGridView DatagridRegisterNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxRegisterNotesSubject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxAprovados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboxBuscar;
    }
}


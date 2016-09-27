using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeNotas8_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Boolean bandera = false;
        string subject;
        void Imprimir2()
        {
            InformationOfStudents a = new InformationOfStudents();
            DataTable count = a.AVG("Tabla", ComboBoxRegisterNotesSubject.SelectedItem.ToString());

            TextBoxAprovados.Text=(count.Rows[0][0].ToString());
        }
        void Imprimir() 
        {
            if (DatagridRegisterNotes.Rows.Count > 1)
            {
                for (int v = DatagridRegisterNotes.Rows.Count - 2; v >= 0; v--)
                {
                    DatagridRegisterNotes.Rows.RemoveAt(v);
                }
            }

            InformationOfStudents P = new InformationOfStudents();
            DataTable info=P.Imprimir("TABLA", ComboBoxRegisterNotesSubject.SelectedItem.ToString());

            int f = 0;
            for (int a = 0; a<info.Rows.Count; a++)
            {
              
                    DatagridRegisterNotes.Rows.Add();
                    DatagridRegisterNotes.Rows[a].Cells[0].Value = Convert.ToString(info.Rows[a][0]);
                    DatagridRegisterNotes.Rows[a].Cells[1].Value = Convert.ToString(info.Rows[a][1]);
                    DatagridRegisterNotes.Rows[a].Cells[2].Value = Convert.ToString(info.Rows[a][2]);
                    DatagridRegisterNotes.Rows[a].Cells[3].Value = Convert.ToString(info.Rows[a][3]);
                    DatagridRegisterNotes.Rows[a].Cells[4].Value = Convert.ToString(info.Rows[a][4]);
                    DatagridRegisterNotes.Rows[a].Cells[5].Value = Convert.ToString(info.Rows[a][5]);
                    DatagridRegisterNotes.Rows[a].Cells[6].Value = Convert.ToString(info.Rows[a][6]);
                    DatagridRegisterNotes.Rows[a].Cells[7].Value = Convert.ToString(info.Rows[a][7]);
                    DatagridRegisterNotes.Rows[a].Cells[8].Value = Convert.ToString(info.Rows[a][8]);
                    DatagridRegisterNotes.Rows[a].Cells[9].Value = Convert.ToString(info.Rows[a][9]) ;

                if (int.Parse(info.Rows[a][6].ToString()) >= 60 || int.Parse(info.Rows[a][8].ToString()) >= 60 || int.Parse(info.Rows[a][9].ToString()) >= 60)
                    {
                        DatagridRegisterNotes.Rows[a].Cells[11].Value = true;
                    }

                    
                }

            

        }
        void guardar()
        {
            bandera = false;
            for (int x = 0; x <= (DatagridRegisterNotes.Rows.Count - 2); x++)

            {
                InformationOfStudents Instancia;
                Instancia = new InformationOfStudents();
                Boolean Band;
                Band = Instancia.Guardar("TABLA", int.Parse(DatagridRegisterNotes.Rows[x].Cells[0].Value.ToString()), (DatagridRegisterNotes.Rows[0].Cells[1].Value.ToString()), (DatagridRegisterNotes.Rows[0].Cells[2].Value.ToString()),(ComboBoxSubject.SelectedItem.ToString()), int.Parse(DatagridRegisterNotes.Rows[0].Cells[3].Value.ToString()), int.Parse(DatagridRegisterNotes.Rows[0].Cells[4].Value.ToString()), int.Parse(DatagridRegisterNotes.Rows[0].Cells[5].Value.ToString()), int.Parse(DatagridRegisterNotes.Rows[0].Cells[7].Value.ToString()), int.Parse(DatagridRegisterNotes.Rows[0].Cells[8].Value.ToString()), int.Parse(DatagridRegisterNotes.Rows[0].Cells[9].Value.ToString()), int.Parse(DatagridRegisterNotes.Rows[0].Cells[9].Value.ToString()));
                if (Band == true)
                {
                    MessageBox.Show("Estudiante Guardado");
                }
                else
                {
                    MessageBox.Show("Error al Guardar");
                    TextBoxStudentIDRegisterStudent.Focus();
                }


            }

            MessageBox.Show("Guardado!");
            Metodo();

        }


        public void Metodo()
        {
            try
            {
                int aprobados = 0, reprobados = 0, porceA = 0, porceR = 0;
                for (int w = 0; w < Arreglo.Length; w++)
                {
                    if (ComboBoxRegisterNotesSubject.SelectedItem.ToString() == Arreglo[w].GSSubject)
                    {
                        if (Arreglo[w].GSNF >= 60 || Arreglo[w].GSITCONV >= 60 || Arreglo[w].GSNFCONV >= 60)
                        {
                            aprobados++;

                        }
                        else reprobados++;
                    }

                }
                porceA = (aprobados * 100) / Arreglo.Length;
                porceR = (reprobados * 100) / Arreglo.Length;



                TextBoxAprovados.Text = ("Aprovados #" + aprobados + "\t" + porceA + "%\r\n" + "Reprovados #" + reprobados + "\t" + porceR + "%");
            }
            catch { }
        }

        int i = 0;

        InformationOfStudents[] Arreglo;



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)


        {
            


            this.WindowState = FormWindowState.Maximized;   
            this.StartPosition = FormStartPosition.CenterScreen;

            //Names
            DatagridRegisterNotes.Columns.Add("", "ID");
            DatagridRegisterNotes.Columns.Add("", "Name");
            DatagridRegisterNotes.Columns.Add("", "Last Name");
            DatagridRegisterNotes.Columns.Add("", "IP");
            DatagridRegisterNotes.Columns.Add("", "IIP");
            DatagridRegisterNotes.Columns.Add("", "SIST");
            DatagridRegisterNotes.Columns.Add("", "PROY");
            DatagridRegisterNotes.Columns.Add("", "N.F");
            DatagridRegisterNotes.Columns.Add("", "EXA I CONV");
            DatagridRegisterNotes.Columns.Add("", "N.F I CONV");
            DatagridRegisterNotes.Columns.Add("", "II CONV");

            //Colors

            DatagridRegisterNotes.Columns[6].DefaultCellStyle.BackColor = Color.LightCoral;
            DatagridRegisterNotes.Columns[7].DefaultCellStyle.BackColor = Color.LightCoral;
            DatagridRegisterNotes.Columns[9].DefaultCellStyle.BackColor = Color.LightCoral;
            DatagridRegisterNotes.Columns[0].DefaultCellStyle.BackColor = Color.LightSkyBlue;
            DatagridRegisterNotes.Columns[1].DefaultCellStyle.BackColor = Color.LightYellow;
            DatagridRegisterNotes.Columns[2].DefaultCellStyle.BackColor = Color.LightYellow;
            DatagridRegisterNotes.Columns[7].DefaultCellStyle.ForeColor = Color.White;
            DatagridRegisterNotes.Columns[9].DefaultCellStyle.ForeColor = Color.White;

            //size
            DatagridRegisterNotes.Columns[0].Width = 100;
            DatagridRegisterNotes.Columns[1].Width = 200;
            DatagridRegisterNotes.Columns[2].Width = 200;

            DatagridRegisterNotes.Columns[3].Width = 50;
            DatagridRegisterNotes.Columns[4].Width = 50;
            DatagridRegisterNotes.Columns[5].Width = 50;
            DatagridRegisterNotes.Columns[6].Width = 50;
            DatagridRegisterNotes.Columns[7].Width = 50;
            DatagridRegisterNotes.Columns[8].Width = 60;
            DatagridRegisterNotes.Columns[9].Width = 60;
            DatagridRegisterNotes.Columns[10].Width = 60;


            //Details
            DatagridRegisterNotes.Columns[6].ReadOnly = true;
            DatagridRegisterNotes.Columns[7].ReadOnly = true;
            DatagridRegisterNotes.Columns[9].ReadOnly = true;
            DatagridRegisterNotes.Columns[0].ReadOnly = true;
            DatagridRegisterNotes.Columns[1].ReadOnly = true;
            DatagridRegisterNotes.Columns[2].ReadOnly = true;
            


            ComboBoxSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxRegisterNotesSubject.DropDownStyle = ComboBoxStyle.DropDownList;

            //CheckBoxAdd
            DataGridViewCheckBoxColumn Checkbox = new DataGridViewCheckBoxColumn();
            Checkbox.HeaderText = "Aprovado";
            Checkbox.Name = "CheckBox";
            DatagridRegisterNotes.Columns.Add(Checkbox);

        }

        private void btnRegister_Click(object sender, EventArgs e)

        {

            try
            {
                Array.Resize(ref Arreglo, i + 1);
                Arreglo[i] = new InformationOfStudents();
                Arreglo[i].GSID = int.Parse(TextBoxStudentIDRegisterStudent.Text);
                Arreglo[i].GSName = TextBoxNameRegisterStudents.Text;
                Arreglo[i].GSLastName = TextBoxLastNameStudents.Text;
                Arreglo[i].GSSubject = ComboBoxSubject.SelectedItem.ToString();
                i++;

                MessageBox.Show("Registered!");
            }

            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
         
        }

        
        private void ComboBoxRegisterNotesSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bandera == true)
            {
                DialogResult resultado = MessageBox.Show("Desea guardar los cambios realizados", "SIRI", MessageBoxButtons.YesNoCancel);
                if (resultado == DialogResult.No)
                {
                    Imprimir();
                    Imprimir2();

                }
                else
                if (resultado == DialogResult.Yes)
                {
                    guardar();
                    Imprimir();
                    Imprimir2();
                    
                }

            }
            else
                Imprimir();
                Imprimir2();

        }


        private void DatagridRegisterNotes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //MATH

            bandera = true;
            subject = ComboBoxRegisterNotesSubject.SelectedItem.ToString();
            for (int x = 0; x <= (DatagridRegisterNotes.Rows.Count - 2); x++)

            {

                int num1, num2, num3, num4, num5;

                if (DatagridRegisterNotes.Rows[x].Cells[3].Value == null)
                {
                    num1 = 0;
                }
                else
                {
                    num1 = int.Parse(DatagridRegisterNotes.Rows[x].Cells[3].Value.ToString());
                }

                if (DatagridRegisterNotes.Rows[x].Cells[4].Value == null)
                {
                    num2 = 0;
                }
                else
                {
                    num2 = int.Parse(DatagridRegisterNotes.Rows[x].Cells[4].Value.ToString());
                }
                if (DatagridRegisterNotes.Rows[x].Cells[5].Value == null)
                {
                    num3 = 0;
                }
                else
                {
                    num3 = int.Parse(DatagridRegisterNotes.Rows[x].Cells[5].Value.ToString());
                }
                if (DatagridRegisterNotes.Rows[x].Cells[8].Value == null)
                {
                    num4 = 0;
                }
                else
                {
                    num4 = int.Parse(DatagridRegisterNotes.Rows[x].Cells[8].Value.ToString());
                }
                if (DatagridRegisterNotes.Rows[x].Cells[10].Value == null)
                {
                    num5 = 0;
                }
                else
                {
                    num5 = int.Parse(DatagridRegisterNotes.Rows[x].Cells[10].Value.ToString());
                }


                if (num1 > 35)
                {
                    MessageBox.Show("El primera parcial debe se <= 35");
                    num1 = 0;
                    DatagridRegisterNotes.Rows[x].Cells[3].Value = num1;
                    DatagridRegisterNotes.Rows[x].Cells[7].Value = num1 + num2 + num3;
                }
                if (num2 > 35)
                {
                    MessageBox.Show("El Segundo parcial debe se <= 35");
                    num2 = 0;
                    DatagridRegisterNotes.Rows[x].Cells[4].Value = num2;
                    DatagridRegisterNotes.Rows[x].Cells[7].Value = num1 + num2 + num3;
                }
                if (num3 > 35)
                {
                    MessageBox.Show("El Tercer parcial debe se <= 35");
                    num3 = 0;
                    DatagridRegisterNotes.Rows[x].Cells[5].Value = num3;
                    DatagridRegisterNotes.Rows[x].Cells[7].Value = num1 + num2 + num3;
                }
                if (((num5 > 100) || (num5 < 0)))
                {
                    MessageBox.Show("El Numero Tiene que ser Mayor que 0 y menor que 100 ");
                    num5 = 0;
                    DatagridRegisterNotes.Rows[x].Cells[10].Value = num5;
                }


                //Normal
                try
                {
                    DatagridRegisterNotes.Rows[x].Cells[7].Value = num1 + num2 + num3;
                    DatagridRegisterNotes.Rows[x].Cells[9].Value = num4 + num3;

                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }

                if (int.Parse(DatagridRegisterNotes.Rows[x].Cells[7].Value.ToString()) >= 60)
                {

                    DatagridRegisterNotes.Rows[x].Cells[9].Value = 0;
                    DatagridRegisterNotes.Rows[x].Cells[8].Value = 0;
                    DatagridRegisterNotes.Rows[x].Cells[10].Value = 0;

                }
                if (int.Parse(DatagridRegisterNotes.Rows[x].Cells[9].Value.ToString()) >= 60)
                {
                    DatagridRegisterNotes.Rows[x].Cells[10].Value = 0;

                }
                if (int.Parse(DatagridRegisterNotes.Rows[x].Cells[9].Value.ToString()) >= 60 || int.Parse(DatagridRegisterNotes.Rows[x].Cells[10].Value.ToString()) >= 60 || int.Parse(DatagridRegisterNotes.Rows[x].Cells[7].Value.ToString()) >= 60)
                {
                    DatagridRegisterNotes.Rows[x].Cells[11].Value = true;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void DatagridRegisterNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11)
            {
                MessageBox.Show("Aprovado");
            }
        }

        private void DatagridRegisterNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                InformationOfStudents Instacia = new InformationOfStudents();
                DataTable infor;
                infor = Instacia.Imprimir("TABLA", int.Parse(ComboBoxSubject.SelectedValue.ToString()));

                DatagridRegisterNotes.DataSource = infor;


            }
            catch { }




        }

        private void ComboxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
    }

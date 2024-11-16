using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhoneBookEF
{
    public partial class Form1 : Form
    {
        PhoneContext context = new PhoneContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void LoadDGV()
        {
            var query = from c in context.Person
                        select c; // new { c.StudentID, c.StudentName, c.Weight };
            var results = query.ToList();
            dgv1.DataSource = results;
        }


        bool Fined = false;
        private void btn_search_Click(object sender, EventArgs e)
        {
            var query = from c in context.Person
                            //where c.StudentName == txt_title.Text.Trim()
                        where c.PersonTitle.Contains(txt_title.Text.Trim())
                        select c; // new { c.StudentID, c.StudentName, c.Height, c.Weight };

            var results = query.ToList();
            dgv1.DataSource = results;
            Fined = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int SelectedID = Convert.ToInt32(dgv1[0, dgv1.CurrentRow.Index].Value.ToString());
                var result = context.Person.SingleOrDefault(b => b.PersonID == SelectedID);
                context.Person.Remove(result);
                context.SaveChanges();

                LoadDGV();
            }
            catch
            { }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt_title.Text.Trim() != string.Empty)
            {
         
                var count = (from c in context.Person
                            where c.PersonTitle == txt_title.Text.Trim()
                            select c).Count();  

                if (count == 0)
                {

                    Person Persond = new Person()
                    {
                        PersonTitle = txt_title.Text.Trim(),
                        PersonPhone = txt_tel.Text.Trim(),
                        PersonMobil = txt_mobil.Text.Trim(),
                        PersonAddress = txt_address.Text.Trim()
                    };
                    context.Person.Add(Persond);
                    context.SaveChanges();
                    LoadDGV();
                }
                else
                {
                    MessageBox.Show("Name Exist!", "Error");
                }
            }
            else
            {
                context.SaveChanges();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int SelectedID = Convert.ToInt32(dgv1[0, dgv1.CurrentRow.Index].Value.ToString());
            var result = context.Person.SingleOrDefault(b => b.PersonID == SelectedID);
            if (result != null)
            {
                result.PersonTitle = txt_title.Text.Trim();
                result.PersonPhone = txt_tel.Text.Trim();
                result.PersonMobil = txt_mobil.Text.Trim();
                result.PersonAddress = txt_address.Text.Trim();
                context.SaveChanges();

                LoadDGV();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Fined)
            {
                LoadDGV();
                Fined = false;
            }
            else
            {
                this.Close();
            }
        }

 

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_title.ResetText();
            txt_tel.ResetText();
            txt_mobil.ResetText();
            txt_address.ResetText();
            txt_title.Focus();
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int SelectedID = Convert.ToInt32(dgv1[0, dgv1.CurrentRow.Index].Value.ToString());
                Person aPerson = new Person();
                aPerson = context.Person.FirstOrDefault(x => x.PersonID == SelectedID);
                txt_title.Text = aPerson.PersonTitle.Trim();
                txt_tel.Text = aPerson.PersonPhone.Trim();
                txt_mobil.Text = aPerson.PersonMobil.Trim();
                txt_address.Text = aPerson.PersonAddress.Trim();
            }
            catch
            { }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoFarm_LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void select_db_Click(object sender, EventArgs e)
        {
            
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ecoFarmDataSet);

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ecoFarmDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.ecoFarmDataSet.Employees);

        }
       
        #region array 
        private void select_arr_Click(object sender, EventArgs e)
        {
            string[] directors = new string[] { "Эльдар Рязанов", "Леонид Гайдай", "Игорь Масленников", "Сергей Бондарчук", "Георгий Данелия", "Андрей Тарковский", "Александр Роу", "Марк Захаров", "Владимир Меньшов", "Станислав Ростоцкий", "Сергей Эйзенштейн" };
            var selectedDirectors = (from d in directors where d.StartsWith("А") select d.ToLower()).ToArray();
            MessageBox.Show("Directors who's name begins with A:  "+selectedDirectors.Aggregate((current, next) => current + ", " + next));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] num = new int[] {2, 11, 32, 324, 5, 4, 67, 3, 13, 9, 21, 55, 222, 67, 467};
            var factorRes = num.Where(n => n * n < 1000).Select(n => n.ToString()).ToArray().Reverse();
            MessageBox.Show(factorRes.Aggregate((current, next) => current + ", " + next));
        }
        #endregion

        #region data source
        private void select_db_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ecoFarmDataSet.Employees.Where(x => x.Birth_Date >= dateTimePicker1.Value && x.Birth_Date <= dateTimePicker2.Value).OrderBy(x => x.Birth_Date).Select(emp => new
            {
                emp.Full_Name,
                emp.Adress,
                emp.Position_Code,
                emp.Passport_Number,
                emp.Passport_Series
            }).ToList();
        }

        private void select_pos_code_Click(object sender, EventArgs e)
        {
            var res = (from m in ecoFarmDataSet.Employees where(m.Position_Code > 2 && m.Passport_Number.ToString().StartsWith("0")) orderby m.Full_Name select new
            {
                m.Full_Name,
                m.Employee_Number,
                m.Passport_Number,
                m.Passport_Series,
                m.Birth_Date,
                m.Position_Code
            }).ToList();
            dataGridView1.DataSource = res;
        }

        #endregion

        #region collection
        List<Employees> emps = new List<Employees>()
            {
                new Employees("Andrew", 21, "Microsoft"),
                new Employees("Jean", 22, "LG"),
                new Employees("Luc", 52, "Apple"),
                new Employees("Tom", 44, "Apple"),
                new Employees("Richard", 18, "Microsoft"),
                new Employees("David", 28, "Apple"),
                new Employees("Paul", 29, "LG"),
                new Employees("Kai", 35, "Microsoft"),
                new Employees("Persi", 38, "LG"),
                new Employees("Katherine", 31, "Microsoft"),
                new Employees("Javier", 31, "Apple"),
                new Employees("Penelope", 37, "Microsoft"),
                new Employees("Ramapatrikuna", 28, "LG"),
                new Employees("Josh", 28, "Microsoft"),
                new Employees("Kristina", 28, "Microsoft")
            };

        List<Languages> lang = new List<Languages>()
        {
            new Languages("Microsoft", "C#"),
            new Languages("Apple", "X-Code"),
            new Languages("LG", "Python")
        };

        private void button2_Click(object sender, EventArgs e)
        {
            
            //var young = (from m in emps orderby m.Age select m.Name).First();
            //yongTB.Text = young.ToString();
            //
            //var old = (from m in emps orderby m.Age select m.Name).Last();
            //oldTB.Text = old.ToString();
            //
            var count = (from m in emps where m.Age == 28 select m.Age).Count();
            textBox1.Text = count.ToString();
            yongTB.Text = emps.Min(m=>m.Name);
            oldTB.Text = emps.Max(m => m.Name);
            avTB.Text = Convert.ToInt32(emps.Average(m => m.Age)).ToString();
        }

        private void select_by_companies_Click(object sender, EventArgs e)
        {
            var res = (from em in emps
                       join lan in lang on em.Company equals lan.Company
                       where lan.Company == CompaniesCB.SelectedItem.ToString()
                       select new
                       {
                           em.Name,
                           em.Company,
                           lan.Language
                       }.ToString()).ToList();
            string s = string.Empty;
            foreach (var item in res)
            {
                s += item.Replace('{', ' ').Replace('}',' ') + "\n";
            }
            MessageBox.Show(s);
        }
        #endregion


    }
}

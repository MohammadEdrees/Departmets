using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF3Last
{

    public partial class Form1 : Form
    {
        Model1 db = new Model1();
        
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            fillDapartments();
            base.OnLoad(e);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmboxDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            int DepId = int.Parse(cmboxDep.SelectedItem.ToString());
            Department D = (from obj in db.Departments
                            where obj.id == DepId
                            select obj).FirstOrDefault();

            var Emp = (from obj in db.Employees
                           where obj.DepId == DepId
                           select obj).ToList();
            txtDeapartment.Text = D.name;
            listBoxEmps.Items.Clear();
            foreach (var E in Emp)
            {
                listBoxEmps.Items.Add(E.Fname + E.Lname);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add department
            Department Dep = new Department();
            int DepId = Convert.ToInt32(cmboxDep.Text);
            string DepName = txtDeapartment.Text;
            Dep.id = DepId;
            Dep.name = DepName;
            db.Departments.Add(Dep);
            db.SaveChanges();
            cmboxDep.Items.Clear();
            cmboxDep.Text = string.Empty;
            txtDeapartment.Text = string.Empty;
            MessageBox.Show($"{DepName} Added Successfully");
            fillDapartments();

            
        }
        private void fillDapartments() {
            var Departments = (from objs in db.Departments
                               select objs
                                     ).ToList();
            foreach (var Department in Departments)
            {
                cmboxDep.Items.Add(Department.id);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Remove department
            Department Dep = new Department();
            int DepId = Convert.ToInt32(cmboxDep.Text);
            string DepName = txtDeapartment.Text;
            Dep = (from obj in db.Departments
                   where obj.id == DepId
                   select obj).FirstOrDefault();
            db.Departments.Remove(Dep);
            db.SaveChanges();
            cmboxDep.Items.Clear();
            cmboxDep.Text = string.Empty;
            txtDeapartment.Text = string.Empty;
            MessageBox.Show($"{DepName} Deleted Successfully");
            fillDapartments();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Update department
            Department Dep = new Department();
            int DepId = Convert.ToInt32(cmboxDep.Text);
            string DepName = txtDeapartment.Text;
            Dep = (from obj in db.Departments
                   where obj.id == DepId
                   select obj).FirstOrDefault();
            Dep.id = DepId;
            Dep.name = DepName;
            db.SaveChanges();
            cmboxDep.Items.Clear();
            cmboxDep.Text = string.Empty;
            txtDeapartment.Text = string.Empty;
            MessageBox.Show($"{DepName} Updated Successfully");
            listBoxEmps.Items.Clear();
            fillDapartments();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee Emp = new Employee();
            int EmpId = Convert.ToInt32(txtEmpId.Text);
            string EmpFnm = txtEmpFnm.Text;
            string EmpLnm = txtEmpLnm.Text;
            int Salary = int.Parse(txtEmpSal.Text);
            Emp.id = EmpId;
            Emp.Fname = EmpFnm;
            Emp.Lname = EmpLnm;
            Emp.salary = Salary;
            db.Employees.Add(Emp);
            db.SaveChanges();
            txtEmpId.Text = string.Empty;
            txtEmpFnm.Text = string.Empty;
            txtEmpLnm.Text = string.Empty;
            txtEmpSal.Text = string.Empty;
            listBoxEmps.Items.Add(Emp.Fname + "" + Emp.Lname);
            MessageBox.Show($"{Emp.Fname}{EmpLnm} Added Successfully");
            
        }
    }
}

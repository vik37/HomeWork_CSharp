using Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUiCore
{
    public partial class Form1 : Form
    {
       List<PersonClass> People = ListMenager.LoadSempleData();
        public Form1()
        {
            InitializeComponent();
            //InitializeBandings();
            initialBind();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void initialBind()
        {
            initializeBindings.DataSource = People;
            initializeBindings.DisplayMember = "FullName";
            filteredList.DataSource = People.Where(p => p.YearsExperience >= 5).OrderBy(p => p.FirstName).ThenBy(p => p.LastName).ToList();
            filteredList.DisplayMember = "FullName";
            
        }
        private void updateBindings()
        {
            filteredList.DataSource = People.Where(p => p.YearsExperience >= 5).OrderBy(p => p.FirstName).ThenBy(p => p.LastName).ToList();
        }
        private void initializeBindings_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonClass selectedPerson = (PersonClass)initializeBindings.SelectedItem;
            //YearsExperiencePcicker.value = 
            yearExperiencePicker.Value = selectedPerson.YearsExperience;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void updatePersonButton_Click_Click(object sender, EventArgs e)
        {
            PersonClass selectedPerson = (PersonClass)initializeBindings.SelectedItem;
            selectedPerson.YearsExperience = Convert.ToInt32(yearExperiencePicker.Value);

            updateBindings();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

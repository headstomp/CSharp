using LinqLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = ListManager.LoadSampleData();

        public Dashboard()
        {
            InitializeComponent();

            InitializeBindings();

        }

        private void InitializeBindings()
        {
            AllPeopleDropDown.DataSource = people;
            AllPeopleDropDown.DisplayMember = "FullName";
            filteredPeopleList.DataSource = people.Where(x => x.YearsExperience >= 10).ToList();
            filteredPeopleList.DisplayMember = "FullName";
        }

        private void UpdateBindings()
        {
            filteredPeopleList.DataSource = people.Where(x => x.YearsExperience >= 10).ToList();
        }

        private void AllPeopleDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person selectedPerson = (Person)AllPeopleDropDown.SelectedItem;
            yearsExperienceUpDown.Value = selectedPerson.YearsExperience;
        }

        private void updatePersonButton_Click(object sender, EventArgs e)
        {
            Person selectedPerson = (Person)AllPeopleDropDown.SelectedItem;
            selectedPerson.YearsExperience = Convert.ToInt32(yearsExperienceUpDown.Value);
            UpdateBindings();
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListApp
{
    // struktura przechowywana w liście
    public struct Location
    {
        public string Province;
        public string Capital;
    }

    public partial class MainForm : Form
    {
        private List<Location> MyList;

        public MainForm()
        {
            InitializeComponent();
        }

        // metoda uaktualniająca stan komponentu ListBox zgodnie ze stanem faktycznym
        private void UpdateList()
        {
            lbLocation.Items.Clear();

            for (int i = 0; i < MyList.Count; i++)
            {
                lbLocation.Items.Add(
                    String.Format("{0,-10} {1,10}", MyList[i].Province, MyList[i].Capital
                ));
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // utworzenie instancji klasy w momencie załadowania formularza
            MyList = new List<Location>();
            lbLocation.Items.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MyList.Clear();
            UpdateList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // usunięcie zaznaczonej pozycji
            MyList.RemoveAt(lbLocation.SelectedIndex);
            UpdateList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Location MyLocation = new Location();

            MyLocation.Province = textProvince.Text;
            MyLocation.Capital = textCapitol.Text;

            textProvince.Text = textCapitol.Text = "";

            MyList.Add(MyLocation);
            UpdateList();
        }
    }
}
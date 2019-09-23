using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organizatiom2019
{
    public partial class SpecialistMenu : Form
    {
        public SpecialistMenu()
        {
            InitializeComponent();
        }

        private void SpecialistMenu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.dbDataSet.Orders);

        }
    }
}

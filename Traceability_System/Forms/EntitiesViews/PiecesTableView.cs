using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traceability_System.Models;
using Traceability_System.Repositories;

namespace Traceability_System.Forms.EntitiesViews
{
    public partial class PiecesTableView : UserControl
    {
        PiecesRepository repository = new PiecesRepository();

        public PiecesTableView()
        {
            InitializeComponent();
        }

        private void PiecesTableView_Load(object sender, EventArgs e)
        {
            RefreshInfo();
        }

        private void RefreshInfo()
        {
            PiecesGv.DataSource = null;
            PiecesGv.DataSource = repository.GetAllPieces();
            PiecesGv.Columns["UserScannedNavigation"].Visible = false;
            PiecesGv.Columns["LogRecords"].Visible = false;
            PiecesGv.Columns["SerialNumbers"].Visible = false;
            PiecesGv.Refresh();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MercadoEnvio.Modelo
{
        public class SuperGrid : DataGridView
    {
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value;
            }
        }
        public int _pageSize = 10;
        BindingSource bs = new BindingSource();
        BindingList<DataTable> tables = new BindingList<DataTable>();
        
        public void SetPagedDataSource(DataTable dataTable, BindingNavigator bnav)
        {
            DataTable dt = null;
            int counter = 1;
            foreach (DataRow dr in dataTable.Rows)
            {
                if (counter == 1)
                {
                    dt = dataTable.Clone();
                    tables.Add(dt);
                }
                dt.Rows.Add(dr.ItemArray);
                if (PageSize < ++counter  )
                {
                    counter = 1;
                }
            }
            bnav.BindingSource = bs;
            bs.DataSource = tables;
            bs.PositionChanged += bs_PositionChanged;
            bs_PositionChanged(bs, EventArgs.Empty);
        }
        void bs_PositionChanged(object sender, EventArgs e)
        {
            if (tables.Count != 0)
            {
                this.DataSource = tables[bs.Position];

            }
            if (tables.Count == 0)
            {
                this.DataSource = null;

            }
        }
        

        public void LimpiarPagedDataSource(DataTable dataTable, BindingNavigator bnav)
        {
            this.DataSource = null;
            //bs.Position = -1;
            BindingList<DataTable> tables2 = new BindingList<DataTable>();
            tables = tables2;
            //tables.Add(dataTable);
            //bs.Position = 0;
            bs.DataSource = tables;
            bnav.BindingSource = bs;

        }

    }

}
    


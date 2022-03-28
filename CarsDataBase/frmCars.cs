using System.Data;

namespace CarsDataBase
{
    public partial class frmCars : Form
    {
        public frmCars()
        {
            InitializeComponent();
        }

        constructor c = new constructor();

        private void frmCars_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();

            // Take all the data from database, 1 row([0]) and put it into appropriate textboxes
            // (txtVehRegNum[0], txtMake[1], txtEngineSize[2].....
            // When the form loads the first data will be filled. 

            txtVehRegNum.Text = dt.Rows[0][0].ToString();

            txtMake.Text = dt.Rows[0][1].ToString();

            txtEngineSize.Text = dt.Rows[0][2].ToString();

            txtDateRegistered.Text = Convert.ToDateTime(dt.Rows[0][3]).ToString("dd/MM/yyyy");

            txtRentalPerDay.Text = Convert.ToDecimal(dt.Rows[0][4]).ToString("0.00");
        }
    }
}
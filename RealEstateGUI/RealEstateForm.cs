using MySql.Data.MySqlClient;

namespace RealEstateGUI
{
    public partial class RealEstateForm : Form
    {
        private string _connectionString = 
            "Server=localhost;" +
            "Database=realestates;" +
            "Uid=root;";

        private List<Seller> _sellers = new();

        public RealEstateForm()
        {
            InitializeComponent();
            Load += RealEstateForm_Load;
            lsbNames.SelectedIndexChanged += LsbNames_SelectedIndexChanged;
            btnLoadAds.Click += BtnLoadAds_Click;
        }

        private void BtnLoadAds_Click(object sender, EventArgs e)
        {
            if (lsbNames.SelectedIndex != -1)
            {
                using MySqlConnection connection = new(_connectionString);
                connection.Open();
                MySqlDataReader reader = new MySqlCommand(
                    "SELECT COUNT(*) FROM realestates " +
                    "INNER JOIN sellers ON sellerId = sellers.id " +
                    $"WHERE sellerId = {_sellers[lsbNames.SelectedIndex].ID};",
                    connection).ExecuteReader();
                reader.Read();
                lblNoAds.Text = $"{reader[0]}";
            }
        }

        private void LsbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblName.Text = _sellers[lsbNames.SelectedIndex].Name;
            lblPhone.Text = _sellers[lsbNames.SelectedIndex].Phone;
        }

        private void RealEstateForm_Load(object? sender, EventArgs e)
        {
            using MySqlConnection connection = new(_connectionString);
            connection.Open();

            MySqlDataReader reader = new MySqlCommand(
                "SELECT * FROM sellers;", connection)
                .ExecuteReader();

            while (reader.Read())
            {
                _sellers.Add(new(){
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Phone = reader.GetString(2),
                });
                lsbNames.Items.Add(_sellers.Last().Name);
            }
        }
    }
}

using RegisterApplication.DAO;
using RegisterApplication.objects;

namespace RegisterApplication
{
    public partial class MainForm : Form
    {

        BindingSource productsBindingSources = new BindingSource();

        List<Product> products = new List<Product>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           ProductsDAO productsDAO = new ProductsDAO();

            products = productsDAO.getAllProducts();
            productsBindingSources.DataSource = products;
            dataGridView1.DataSource = productsBindingSources;
        }
    }
}

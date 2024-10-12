using Npgsql;
using BLL;
using BLL.DTO;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        //MyPizzaDeliveryContext dbContext=new MyPizzaDeliveryContext();
        //private string connectionString;
        //List<clients> allClients;
        //List<DelStatus> delStatuses;
        //List<couriers> allCouriers;
        //List<ingredients> allIngredients;
        //List<pizza> allPizzas;

        OrderLinesService orderlinesService = new OrderLinesService();
        OrderService orderService = new OrderService();
        //ReportService reportService = new ReportService();
        int currentOrderId, currentClientId;

        List<IngredientDto> allingredients;
        List<OrderDto> allorders;
        List<OrderLineDto> allorderlines;
        List<PizzaSizesDto> allpizzasizes;
        List<PizzaDto> allpizzas;
        List<DelStatusDto> alldelstatus;
        List<CouriersDto> allcouriers;
        List<ManagerDto> allmanagers;

        

        public Form1()
        {
            InitializeComponent();
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            
            currentClientId = 1;
            currentOrderId = orderService.GetCurrentOrder(currentClientId);
            

            loadData();
            
        }

        private void loadData()
        {
            allpizzas = orderlinesService.GetPizzas();
            allingredients = orderlinesService.GetIngredients();
            allorderlines = orderlinesService.GetAllOrderLines(currentOrderId);
            allorders = orderService.GetAllOrders(currentClientId);
            alldelstatus = orderlinesService.GetDelStatuses();
            bindingSourceOrders.DataSource = allorders;
            bindingSourceOrderLines.DataSource = allorderlines;
            allpizzasizes = orderlinesService.GetPizzaSizes();
            allmanagers = orderService.GetAllManagers();
            allcouriers = orderService.GetAllCouriers();
            FillCourierCombobox();
            FillStatusCombobox();
            FillManagerCombobox();
            FillPizzaCombobox();
            FillReport1Combobox();
        }
        //private void LoadPizzas()
        //{
        //    dbContext.pizza.Load();
        //    allPizzas = dbContext.pizza.Local.ToList();
        //}
        //private void LoadIngredients()
        //{
        //    dbContext.ingredients.Load();
        //    allIngredients = dbContext.ingredients.Local.ToList();
        //}
        //private void LoadClients()
        //{
        //    dbContext.clients.Load();
        //    allClients = dbContext.clients.Local.ToList();
        //    dataGridViewClients.DataSource = allClients;

        //}
        //private void LoadCouriers()
        //{
        //    dbContext.couriers.Load();
        //    allCouriers = dbContext.couriers.Local.ToList();

        //}
        //private void LoadStatuses()
        //{
        //    dbContext.DelStatus.Load();
        //    delStatuses = dbContext.DelStatus.Local.ToList();

        //}

        //private void LoadOrders()
        //{
        //    dataGridViewOrders.DataSource = dbContext.orders.Include("Clients").ToList().Select(i => new { i.id, i.ordertime, i.final_price, i.clientId, i.courierId, i.delstatusId, i.address_del, i.deliverytime, i.comment, i.weight}).ToList();
        //}

        private void FillStatusCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["delstatus"]).DataSource =
                alldelstatus;
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["delstatus"]).DisplayMember =
                "description";
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["delstatus"]).ValueMember =
                "Id";
        }

        private void FillManagerCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["managersId"]).DataSource =
                allmanagers;
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["managersId"]).DisplayMember =
                "first_name";
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["managersId"]).ValueMember =
                "Id";
        }

        private void FillPizzaCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewOrderLines.Columns["pizzaId"]).DataSource =
                allpizzas;
            ((DataGridViewComboBoxColumn)dataGridViewOrderLines.Columns["pizzaId"]).DisplayMember =
                "C_name";
            ((DataGridViewComboBoxColumn)dataGridViewOrderLines.Columns["pizzaId"]).ValueMember =
                "Id";
        }



        //private void FillClientCombobox()
        //{
        //    ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["clientId"]).DataSource =
        //        allclients;
        //    ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["ClientId"]).DisplayMember =
        //        "first_name";
        //    ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["ClientId"]).ValueMember =
        //        "id";
        //}

        private void FillReport1Combobox()
        {
            comboBoxIngredients.DataSource = allingredients;
            comboBoxIngredients.DisplayMember = "C_name";
            comboBoxIngredients.ValueMember = "id";
        }

        /// <summary>
        /// Заполнить комбобокс "Курьеры" в таблице "Заказы".
        /// </summary>
        private void FillCourierCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["CourierId_Orders"]).DataSource =
                allcouriers;
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["CourierId_Orders"]).DisplayMember =
                "first_name";
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["CourierId_Orders"]).ValueMember =
                "Id";
        }

        /// <summary>
        /// Сохранить изменения в таблице clients.
        /// </summary>
        private void buttonSaveClients_Click(object sender, EventArgs e)
        {
            
            bool res = Validate();
            if (res)
            {
                //dbContext.clients.Load();
                ////dataGridViewClients.Refresh();
                //allClients = dbContext.clients.Local.ToList();
                //dataGridViewOrderLines.DataSource = null;
                //dataGridViewOrderLines.DataSource = allClients;
                //dataGridViewOrderLines.Refresh();

            }

        }

        private void buttonGetReport1_Click(object sender, EventArgs e)
        {
            dataGridViewReport1.DataSource = ReportService.ReportOrdersByMonth((int)comboBoxIngredients.SelectedValue);
        }

        

        //private void buttonGetReport1_Click(object sender, EventArgs e)
        //{
        //    //var request = dbContext.pizza.Join(dbContext.ingredients, p => p.ingredients, m => m.id,
        //    //    (p, m) => p).Where(i => i.ingredients == (int)comboBoxIngredients.SelectedValue)
        //    //    .Select(i => new { PizzaName = i.C_name, Description = i.description })
        //    //    .ToList();
        //    var request = dbContext.pizza.Where(p => p.ingredients.Any(i => i.id == (int)comboBoxIngredients.SelectedValue))
        //        .Select(p=>new
        //        {
        //            Name = p.C_name,
        //            Description = p.description
                   
        //        }).ToList();
        //    dataGridViewReport1.DataSource = request;


        //}

        //private class ParResult
        //{
        //    public int order_id { get; set; }
        //    public string client_full_name { get; set; }
        //    public string courier_full_name { get; set; }
        //    public DateTime order_date { get; set; }
        //}

        private void buttonReport2_Click(object sender, EventArgs e)
        {
            dataGridViewReport2.DataSource = ReportService.ExecuteSP((int)numericUpDown1.Value, (int)numericUpDown2.Value, 1);
        }

        /// <summary>
        /// нажатие кнопки вызова хранимой процедуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void buttonReport2_Click(object sender, EventArgs e)
        //{


        //    NpgsqlParameter param1 = new NpgsqlParameter("month", (int)numericUpDown1.Value);
        //    NpgsqlParameter param2 = new NpgsqlParameter("year", (int)numericUpDown2.Value);

        //    var result = dbContext.Database.SqlQuery<ParResult>("select * from GetOrdersByMonthYear(@month, @year)", new object[] { param1, param2 }).ToList();
            
        //    var data = result.GroupBy(i => i.courier_full_name).Select(j =>
        //    new { j.Key, ordercount = j.Count()}).OrderByDescending(c => c.ordercount).ToList();


        //    dataGridViewReport2.DataSource = data;
            
        //}

        private void buttonSaveOrders_Click(object sender, EventArgs e)
        {

            bool res = Validate();
            if (res)
            {
                //LoadCouriers();
                //LoadStatuses();
                //dataGridViewOrders.DataSource = null;
                //LoadOrders();
                //dataGridViewClients.DataSource = null;
                //dataGridViewClients.Refresh();

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddClientForm f = new AddClientForm(/*dbContext, null*/);
            

            f.ShowDialog(this);

        }

        private int getSelectedRow(DataGridView dgv)
        {
            int index = -1;
            if (dgv.SelectedRows.Count > 0 || dgv.SelectedCells.Count == 1)
            {
                if (dgv.SelectedRows.Count > 0)
                    index = dgv.SelectedRows[0].Index;
                else index = dgv.SelectedCells[0].RowIndex;
            }
            return index;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //int index = getSelectedRow(dataGridViewOrderLines);
            //int id = 0;
            //bool converted = Int32.TryParse(dataGridViewOrderLines[0, index].Value.ToString(), out id);
            //if (converted == false)
            //    return;
            //dbContext.clients.Remove(dbContext.clients.Find(id));
            //dbContext.SaveChanges();



            //dataGridViewClients.DataSource = null;
            //dataGridViewClients.DataSource=dbContext.clients;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    int index = getSelectedRow(dataGridViewOrderLines);
        //    if (index != -1)
        //    {
        //        int id = 0;
        //        bool converted = Int32.TryParse(dataGridViewOrderLines[0, index].Value.ToString(), out id);
        //        if (converted == false)
        //            return;

        //        clients ncl = dbContext.clients.Where(i => i.id == id).FirstOrDefault();
        //        if (ncl != null)
        //        {
        //            AddClientForm f = new AddClientForm(dbContext, ncl);
                    
        //            f.textBox1.Text = ncl.first_name;
        //            f.textBox2.Text = ncl.last_name;
        //            f.textBox3.Text = ncl.surname;
        //            f.textBox4.Text = ncl.login;
        //            f.textBox5.Text = ncl.C_password;
        //            f.textBox6.Text = ncl.phone;
        //            f.textBox7.Text = ncl.email;
        //            f.textBox8.Text = ncl.address;
        //            f.textBox9.Text = ncl.C_password;

        //            f.ShowDialog(this);

                    
        //        }
        //    }
        //    else
        //        MessageBox.Show("Ни один объект не выбран!");
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewReport1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridViewClients_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}

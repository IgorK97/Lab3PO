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
using System.IO;

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

        List<IngredientShortDto> allingredients;
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
            
            currentClientId = 3;
            currentOrderId = orderService.GetCurrentOrder(currentClientId);
            

            loadData();
            
        }

        private void loadData()
        {
            allpizzas = orderlinesService.GetPizzas();
            allingredients = orderlinesService.GetIngredients(OrderLinesService.PizzaSize.Small);
            allorderlines = orderlinesService.GetAllOrderLines(currentOrderId);
            allorders = orderService.GetAllOrders(currentClientId);
            alldelstatus = orderlinesService.GetDelStatuses();
            
            allpizzasizes = orderlinesService.GetPizzaSizes();
            allmanagers = orderService.GetAllManagers();
            allcouriers = orderService.GetAllCouriers();
            FillCourierCombobox();
            FillStatusCombobox();
            FillManagerCombobox();
            FillPizzaCombobox();
            FillReport1Combobox();
            bindingSourceOrders.DataSource = allorders;
            bindingSourceOrderLines.DataSource = allorderlines;
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

        private void FillReport1Combobox()
        {
            comboBoxIngredients.DataSource = allingredients;
            comboBoxIngredients.DisplayMember = "C_name";
            comboBoxIngredients.ValueMember = "id";
        }

        private void FillCourierCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["CourierId_Orders"]).DataSource =
                allcouriers;
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["CourierId_Orders"]).DisplayMember =
                "first_name";
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["CourierId_Orders"]).ValueMember =
                "Id";
        }

       
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
            dataGridViewReport1.DataSource = ReportService.ReportPizzas((int)comboBoxIngredients.SelectedValue);
        }



        private void buttonReport2_Click(object sender, EventArgs e)
        {
            dataGridViewReport2.DataSource = ReportService.ExecuteSP((int)numericUpDown1.Value, (int)numericUpDown2.Value, currentClientId);
        }

        
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
            int index = getSelectedRow(dataGridViewReport1);
            if (index != -1)
            {
                int p_id = 0;
                bool converted = Int32.TryParse(dataGridViewReport1[0, index].Value.ToString(), out p_id);
                if (converted == false)
                    return;
                PizzaDto p = allpizzas.Where(i => i.Id == p_id).FirstOrDefault();
                if (p != null)
                {
                    AddClientForm f = new AddClientForm(/*dbContext, null*/);

                    f.comboBoxPizzasName.DataSource = allpizzas;
                    f.comboBoxPizzasName.DisplayMember = "C_name";
                    f.comboBoxPizzasName.ValueMember = "Id";
                    f.comboBoxPizzasName.SelectedValue = p.Id;

                    f.pictureBox1.Image = ByteToImage(p.pizzaimage);
                    f.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                    f.richTextBox1.Text = p.description;

                    f.comboBoxPizzasSizes.DataSource = allpizzasizes;
                    f.comboBoxPizzasSizes.DisplayMember = "name";
                    f.comboBoxPizzasSizes.ValueMember = "Id";
                    f.comboBoxPizzasSizes.SelectedIndex = 0;

                    f.dataGridView1.DataSource = allingredients;

                    DialogResult result = f.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                        return;


                    //Дальше идет создание строки заказа

                    MessageBox.Show("Новый товар добавлен в корзину");
                }
            }
            else MessageBox.Show("Выберите пиццу, которую хотите поместить в корзину");
            

        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
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

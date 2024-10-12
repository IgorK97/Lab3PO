namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridViewOrderLines = new System.Windows.Forms.DataGridView();
            this.bindingSourceOrderLines = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.bindingSourceOrders = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxIngredients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewReport1 = new System.Windows.Forms.DataGridView();
            this.NA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewReport2 = new System.Windows.Forms.DataGridView();
            this.KC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Id_OrderLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdersId_OrderLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pizzaId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.CustomColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PositionPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientId_Orders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourierId_Orders = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.final_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_del = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight_orders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordertime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverytime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delstatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managersId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrderLines)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrders)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.dataGridViewOrderLines);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Корзина";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(231, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 32);
            this.button7.TabIndex = 4;
            this.button7.Text = "DELETE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(117, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 33);
            this.button6.TabIndex = 3;
            this.button6.Text = "UPDATE";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(406, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 32);
            this.button5.TabIndex = 2;
            this.button5.Text = "ADD";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewOrderLines
            // 
            this.dataGridViewOrderLines.AllowUserToAddRows = false;
            this.dataGridViewOrderLines.AllowUserToDeleteRows = false;
            this.dataGridViewOrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_OrderLine,
            this.OrdersId_OrderLine,
            this.pizzaId,
            this.CustomColumn,
            this.PositionPrice,
            this.Weight});
            this.dataGridViewOrderLines.Location = new System.Drawing.Point(7, 43);
            this.dataGridViewOrderLines.Name = "dataGridViewOrderLines";
            this.dataGridViewOrderLines.ReadOnly = true;
            this.dataGridViewOrderLines.Size = new System.Drawing.Size(755, 351);
            this.dataGridViewOrderLines.TabIndex = 1;
            this.dataGridViewOrderLines.DoubleClick += new System.EventHandler(this.dataGridViewClients_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSaveClients_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewOrders);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заказы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOrders,
            this.clientId_Orders,
            this.CourierId_Orders,
            this.final_price,
            this.address_del,
            this.weight_orders,
            this.ordertime,
            this.deliverytime,
            this.delstatus,
            this.comment,
            this.managersId});
            this.dataGridViewOrders.Location = new System.Drawing.Point(7, 51);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.Size = new System.Drawing.Size(755, 343);
            this.dataGridViewOrders.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 37);
            this.button2.TabIndex = 0;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonSaveOrders_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.dataGridViewReport1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Пиццы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxIngredients);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 46);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxIngredients
            // 
            this.comboBoxIngredients.FormattingEnabled = true;
            this.comboBoxIngredients.Location = new System.Drawing.Point(80, 17);
            this.comboBoxIngredients.Name = "comboBoxIngredients";
            this.comboBoxIngredients.Size = new System.Drawing.Size(185, 21);
            this.comboBoxIngredients.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ингредиент";
            // 
            // dataGridViewReport1
            // 
            this.dataGridViewReport1.AllowUserToAddRows = false;
            this.dataGridViewReport1.AllowUserToDeleteRows = false;
            this.dataGridViewReport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NA,
            this.ND});
            this.dataGridViewReport1.Location = new System.Drawing.Point(3, 76);
            this.dataGridViewReport1.Name = "dataGridViewReport1";
            this.dataGridViewReport1.ReadOnly = true;
            this.dataGridViewReport1.Size = new System.Drawing.Size(762, 321);
            this.dataGridViewReport1.TabIndex = 1;
            this.dataGridViewReport1.DoubleClick += new System.EventHandler(this.dataGridViewReport1_DoubleClick);
            // 
            // NA
            // 
            this.NA.DataPropertyName = "Name";
            this.NA.HeaderText = "Название";
            this.NA.Name = "NA";
            this.NA.ReadOnly = true;
            // 
            // ND
            // 
            this.ND.DataPropertyName = "Description";
            this.ND.HeaderText = "Описание";
            this.ND.Name = "ND";
            this.ND.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 30);
            this.button3.TabIndex = 0;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonGetReport1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.dataGridViewReport2);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 400);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Заказы за месяц";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 48);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(227, 15);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Год";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(58, 15);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Месяц";
            // 
            // dataGridViewReport2
            // 
            this.dataGridViewReport2.AllowUserToAddRows = false;
            this.dataGridViewReport2.AllowUserToDeleteRows = false;
            this.dataGridViewReport2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KC,
            this.FC});
            this.dataGridViewReport2.Location = new System.Drawing.Point(4, 58);
            this.dataGridViewReport2.Name = "dataGridViewReport2";
            this.dataGridViewReport2.ReadOnly = true;
            this.dataGridViewReport2.Size = new System.Drawing.Size(761, 339);
            this.dataGridViewReport2.TabIndex = 1;
            // 
            // KC
            // 
            this.KC.DataPropertyName = "Key";
            this.KC.HeaderText = "ФИО";
            this.KC.Name = "KC";
            this.KC.ReadOnly = true;
            // 
            // FC
            // 
            this.FC.DataPropertyName = "ordercount";
            this.FC.HeaderText = "Количество";
            this.FC.Name = "FC";
            this.FC.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(379, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 37);
            this.button4.TabIndex = 0;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonReport2_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(338, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 31);
            this.button8.TabIndex = 5;
            this.button8.Text = "Заказать";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Id_OrderLine
            // 
            this.Id_OrderLine.DataPropertyName = "id";
            this.Id_OrderLine.HeaderText = "Id";
            this.Id_OrderLine.Name = "Id_OrderLine";
            this.Id_OrderLine.ReadOnly = true;
            // 
            // OrdersId_OrderLine
            // 
            this.OrdersId_OrderLine.DataPropertyName = "ordersId";
            this.OrdersId_OrderLine.HeaderText = "Номер заказа";
            this.OrdersId_OrderLine.Name = "OrdersId_OrderLine";
            this.OrdersId_OrderLine.ReadOnly = true;
            // 
            // pizzaId
            // 
            this.pizzaId.DataPropertyName = "pizzaId";
            this.pizzaId.HeaderText = "Пицца";
            this.pizzaId.Name = "pizzaId";
            this.pizzaId.ReadOnly = true;
            // 
            // CustomColumn
            // 
            this.CustomColumn.DataPropertyName = "custom";
            this.CustomColumn.HeaderText = "Пользовательская";
            this.CustomColumn.Name = "CustomColumn";
            this.CustomColumn.ReadOnly = true;
            // 
            // PositionPrice
            // 
            this.PositionPrice.DataPropertyName = "position_price";
            this.PositionPrice.HeaderText = "Цена";
            this.PositionPrice.Name = "PositionPrice";
            this.PositionPrice.ReadOnly = true;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "weight";
            this.Weight.HeaderText = "Вес";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Weight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IdOrders
            // 
            this.IdOrders.DataPropertyName = "id";
            this.IdOrders.HeaderText = "Id";
            this.IdOrders.Name = "IdOrders";
            this.IdOrders.ReadOnly = true;
            // 
            // clientId_Orders
            // 
            this.clientId_Orders.DataPropertyName = "clientId";
            this.clientId_Orders.HeaderText = "Клиент";
            this.clientId_Orders.Name = "clientId_Orders";
            this.clientId_Orders.ReadOnly = true;
            // 
            // CourierId_Orders
            // 
            this.CourierId_Orders.DataPropertyName = "courierId";
            this.CourierId_Orders.HeaderText = "Курьер";
            this.CourierId_Orders.Name = "CourierId_Orders";
            this.CourierId_Orders.ReadOnly = true;
            this.CourierId_Orders.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CourierId_Orders.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // final_price
            // 
            this.final_price.DataPropertyName = "final_price";
            this.final_price.HeaderText = "Цена";
            this.final_price.Name = "final_price";
            this.final_price.ReadOnly = true;
            // 
            // address_del
            // 
            this.address_del.DataPropertyName = "address_del";
            this.address_del.HeaderText = "Адрес";
            this.address_del.Name = "address_del";
            this.address_del.ReadOnly = true;
            // 
            // weight_orders
            // 
            this.weight_orders.DataPropertyName = "weight";
            this.weight_orders.HeaderText = "Вес";
            this.weight_orders.Name = "weight_orders";
            this.weight_orders.ReadOnly = true;
            // 
            // ordertime
            // 
            this.ordertime.DataPropertyName = "ordertime";
            this.ordertime.HeaderText = "Время заказа";
            this.ordertime.Name = "ordertime";
            this.ordertime.ReadOnly = true;
            // 
            // deliverytime
            // 
            this.deliverytime.DataPropertyName = "deliverytime";
            this.deliverytime.HeaderText = "Время доставки";
            this.deliverytime.Name = "deliverytime";
            this.deliverytime.ReadOnly = true;
            // 
            // delstatus
            // 
            this.delstatus.DataPropertyName = "delstatusId";
            this.delstatus.HeaderText = "Статус";
            this.delstatus.Name = "delstatus";
            this.delstatus.ReadOnly = true;
            // 
            // comment
            // 
            this.comment.DataPropertyName = "comment";
            this.comment.HeaderText = "Примечание";
            this.comment.Name = "comment";
            this.comment.ReadOnly = true;
            // 
            // managersId
            // 
            this.managersId.DataPropertyName = "managersId";
            this.managersId.HeaderText = "Менеджер";
            this.managersId.Name = "managersId";
            this.managersId.ReadOnly = true;
            this.managersId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.managersId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrderLines)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrders)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewOrderLines;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridView dataGridViewReport1;
        private System.Windows.Forms.DataGridView dataGridViewReport2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxIngredients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSourceOrderLines;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn clientId;
        private System.Windows.Forms.DataGridViewComboBoxColumn courierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressdelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn delstatusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverytimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn NA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ND;
        private System.Windows.Forms.DataGridViewTextBoxColumn KC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FC;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_OrderLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdersId_OrderLine;
        private System.Windows.Forms.DataGridViewComboBoxColumn pizzaId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CustomColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientId_Orders;
        private System.Windows.Forms.DataGridViewComboBoxColumn CourierId_Orders;
        private System.Windows.Forms.DataGridViewTextBoxColumn final_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_del;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight_orders;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertime;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverytime;
        private System.Windows.Forms.DataGridViewComboBoxColumn delstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.DataGridViewComboBoxColumn managersId;
    }
}


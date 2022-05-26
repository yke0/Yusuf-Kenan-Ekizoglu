
namespace CiftlikOtomasyon
{
    partial class AdminArayuz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.çiftlikDataSet1 = new CiftlikOtomasyon.ÇiftlikDataSet1();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çiftlikİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.büyükbaşHayvanİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.küçükbaşHayvanİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çiftlikRaporlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.büyükbaşHayvanRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.küçükbaşHayvanRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullancıEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDeğiştirmeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.çiftlikDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 139);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.çiftlikDataSet1;
            this.bindingSource1.Position = 0;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // çiftlikDataSet1
            // 
            this.çiftlikDataSet1.DataSetName = "ÇiftlikDataSet1";
            this.çiftlikDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.yöneticiİşlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çiftlikİşlemleriToolStripMenuItem,
            this.çiftlikRaporlarıToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.işlemlerToolStripMenuItem.Text = "Çiftlik";
            // 
            // çiftlikİşlemleriToolStripMenuItem
            // 
            this.çiftlikİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.büyükbaşHayvanİşlemlerToolStripMenuItem,
            this.küçükbaşHayvanİşlemleriToolStripMenuItem});
            this.çiftlikİşlemleriToolStripMenuItem.Name = "çiftlikİşlemleriToolStripMenuItem";
            this.çiftlikİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çiftlikİşlemleriToolStripMenuItem.Text = "Çiftlik İşlemleri";
            this.çiftlikİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.çiftlikİşlemleriToolStripMenuItem_Click);
            // 
            // büyükbaşHayvanİşlemlerToolStripMenuItem
            // 
            this.büyükbaşHayvanİşlemlerToolStripMenuItem.Name = "büyükbaşHayvanİşlemlerToolStripMenuItem";
            this.büyükbaşHayvanİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.büyükbaşHayvanİşlemlerToolStripMenuItem.Text = "Büyükbaş Hayvan İşlemler";
            this.büyükbaşHayvanİşlemlerToolStripMenuItem.Click += new System.EventHandler(this.büyükbaşHayvanİşlemlerToolStripMenuItem_Click);
            // 
            // küçükbaşHayvanİşlemleriToolStripMenuItem
            // 
            this.küçükbaşHayvanİşlemleriToolStripMenuItem.Name = "küçükbaşHayvanİşlemleriToolStripMenuItem";
            this.küçükbaşHayvanİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.küçükbaşHayvanİşlemleriToolStripMenuItem.Text = "Küçükbaş Hayvan İşlemleri";
            this.küçükbaşHayvanİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.küçükbaşHayvanİşlemleriToolStripMenuItem_Click);
            // 
            // çiftlikRaporlarıToolStripMenuItem
            // 
            this.çiftlikRaporlarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.büyükbaşHayvanRaporuToolStripMenuItem,
            this.küçükbaşHayvanRaporuToolStripMenuItem});
            this.çiftlikRaporlarıToolStripMenuItem.Name = "çiftlikRaporlarıToolStripMenuItem";
            this.çiftlikRaporlarıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.çiftlikRaporlarıToolStripMenuItem.Text = "Çiftlik Raporları";
            // 
            // büyükbaşHayvanRaporuToolStripMenuItem
            // 
            this.büyükbaşHayvanRaporuToolStripMenuItem.Name = "büyükbaşHayvanRaporuToolStripMenuItem";
            this.büyükbaşHayvanRaporuToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.büyükbaşHayvanRaporuToolStripMenuItem.Text = "Büyükbaş Hayvan Raporu";
            this.büyükbaşHayvanRaporuToolStripMenuItem.Click += new System.EventHandler(this.büyükbaşHayvanRaporuToolStripMenuItem_Click);
            // 
            // küçükbaşHayvanRaporuToolStripMenuItem
            // 
            this.küçükbaşHayvanRaporuToolStripMenuItem.Name = "küçükbaşHayvanRaporuToolStripMenuItem";
            this.küçükbaşHayvanRaporuToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.küçükbaşHayvanRaporuToolStripMenuItem.Text = "Küçükbaş Hayvan Raporu";
            this.küçükbaşHayvanRaporuToolStripMenuItem.Click += new System.EventHandler(this.küçükbaşHayvanRaporuToolStripMenuItem_Click);
            // 
            // yöneticiİşlemlerToolStripMenuItem
            // 
            this.yöneticiİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcılarToolStripMenuItem});
            this.yöneticiİşlemlerToolStripMenuItem.Name = "yöneticiİşlemlerToolStripMenuItem";
            this.yöneticiİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.yöneticiİşlemlerToolStripMenuItem.Text = "Yönetici İşlemleri";
            // 
            // kullanıcılarToolStripMenuItem
            // 
            this.kullanıcılarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullancıEklemeToolStripMenuItem,
            this.şifreDeğiştirmeToolStripMenuItem1,
            this.kullanıcıBilgileriToolStripMenuItem});
            this.kullanıcılarToolStripMenuItem.Name = "kullanıcılarToolStripMenuItem";
            this.kullanıcılarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kullanıcılarToolStripMenuItem.Text = "Kullanıcılar";
            this.kullanıcılarToolStripMenuItem.Click += new System.EventHandler(this.kullanıcılarToolStripMenuItem_Click);
            // 
            // kullancıEklemeToolStripMenuItem
            // 
            this.kullancıEklemeToolStripMenuItem.Name = "kullancıEklemeToolStripMenuItem";
            this.kullancıEklemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kullancıEklemeToolStripMenuItem.Text = "Kullancı Ekleme";
            this.kullancıEklemeToolStripMenuItem.Click += new System.EventHandler(this.kullancıEklemeToolStripMenuItem_Click);
            // 
            // şifreDeğiştirmeToolStripMenuItem1
            // 
            this.şifreDeğiştirmeToolStripMenuItem1.Name = "şifreDeğiştirmeToolStripMenuItem1";
            this.şifreDeğiştirmeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.şifreDeğiştirmeToolStripMenuItem1.Text = "Şifre Değiştirme";
            this.şifreDeğiştirmeToolStripMenuItem1.Click += new System.EventHandler(this.şifreDeğiştirmeToolStripMenuItem1_Click);
            // 
            // kullanıcıBilgileriToolStripMenuItem
            // 
            this.kullanıcıBilgileriToolStripMenuItem.Name = "kullanıcıBilgileriToolStripMenuItem";
            this.kullanıcıBilgileriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kullanıcıBilgileriToolStripMenuItem.Text = "Kullanıcı Bilgileri";
            this.kullanıcıBilgileriToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıBilgileriToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 139);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(179, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "İSTE Çiftlik Otomasyonu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(12, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Büyükbaş Hayvanları Görünüle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(93, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 53);
            this.button3.TabIndex = 6;
            this.button3.Text = "Küçükbaş Hayvanları Görünüle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AdminArayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(630, 295);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminArayuz";
            this.ShowIcon = false;
            this.Text = "Çiftlik Otomasyonu(Admin)";
            this.Load += new System.EventHandler(this.AdminArayuz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.çiftlikDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ÇiftlikDataSet1 çiftlikDataSet1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çiftlikİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiİşlemlerToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullancıEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreDeğiştirmeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıBilgileriToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem büyükbaşHayvanİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem küçükbaşHayvanİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çiftlikRaporlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem büyükbaşHayvanRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem küçükbaşHayvanRaporuToolStripMenuItem;
    }
}
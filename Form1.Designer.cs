namespace Notebook
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rdctnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shrftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hlpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gnrtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wrtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutappToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.rdctnToolStripMenuItem,
            this.shrftToolStripMenuItem,
            this.hlpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gnrtToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // rdctnToolStripMenuItem
            // 
            this.rdctnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dltToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.wrtToolStripMenuItem});
            this.rdctnToolStripMenuItem.Name = "rdctnToolStripMenuItem";
            this.rdctnToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.rdctnToolStripMenuItem.Text = "Правка";
            // 
            // shrftToolStripMenuItem
            // 
            this.shrftToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clrToolStripMenuItem,
            this.szToolStripMenuItem,
            this.ftToolStripMenuItem,
            this.crsvToolStripMenuItem});
            this.shrftToolStripMenuItem.Name = "shrftToolStripMenuItem";
            this.shrftToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.shrftToolStripMenuItem.Text = "Шрифт";
            this.shrftToolStripMenuItem.Click += new System.EventHandler(this.форматToolStripMenuItem_Click);
            // 
            // hlpToolStripMenuItem
            // 
            this.hlpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutappToolStripMenuItem});
            this.hlpToolStripMenuItem.Name = "hlpToolStripMenuItem";
            this.hlpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.hlpToolStripMenuItem.Text = "Справка";
            // 
            // gnrtToolStripMenuItem
            // 
            this.gnrtToolStripMenuItem.Name = "gnrtToolStripMenuItem";
            this.gnrtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gnrtToolStripMenuItem.Text = "Создать";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // dltToolStripMenuItem
            // 
            this.dltToolStripMenuItem.Name = "dltToolStripMenuItem";
            this.dltToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dltToolStripMenuItem.Text = "Вырезать";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Копировать";
            // 
            // wrtToolStripMenuItem
            // 
            this.wrtToolStripMenuItem.Name = "wrtToolStripMenuItem";
            this.wrtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wrtToolStripMenuItem.Text = "Вставить";
            // 
            // clrToolStripMenuItem
            // 
            this.clrToolStripMenuItem.Name = "clrToolStripMenuItem";
            this.clrToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clrToolStripMenuItem.Text = "Цвет";
            // 
            // szToolStripMenuItem
            // 
            this.szToolStripMenuItem.Name = "szToolStripMenuItem";
            this.szToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.szToolStripMenuItem.Text = "Размер";
            // 
            // ftToolStripMenuItem
            // 
            this.ftToolStripMenuItem.Name = "ftToolStripMenuItem";
            this.ftToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ftToolStripMenuItem.Text = "Полужирный";
            // 
            // crsvToolStripMenuItem
            // 
            this.crsvToolStripMenuItem.Name = "crsvToolStripMenuItem";
            this.crsvToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crsvToolStripMenuItem.Text = "Курсив";
            // 
            // aboutappToolStripMenuItem
            // 
            this.aboutappToolStripMenuItem.Name = "aboutappToolStripMenuItem";
            this.aboutappToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutappToolStripMenuItem.Text = "О программе";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Блокнот";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gnrtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rdctnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wrtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shrftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hlpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutappToolStripMenuItem;
    }
}


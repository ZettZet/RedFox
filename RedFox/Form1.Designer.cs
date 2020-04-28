namespace RedFox
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.новоеОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.перейтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.linesCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.wordCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lettersSpaced = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.letterUnspaced = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
			this.caretCurrentPosition = new System.Windows.Forms.ToolStripStatusLabel();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.text = new System.Windows.Forms.RichTextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.FontsSize = new System.Windows.Forms.NumericUpDown();
			this.Fonts = new System.Windows.Forms.ComboBox();
			this.isUnderline = new System.Windows.Forms.CheckBox();
			this.isItalic = new System.Windows.Forms.CheckBox();
			this.isBold = new System.Windows.Forms.CheckBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Copy = new System.Windows.Forms.Button();
			this.Search = new System.Windows.Forms.Button();
			this.SelectAll = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.Cut = new System.Windows.Forms.Button();
			this.Paste = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.ReplaceAll = new System.Windows.Forms.Button();
			this.isCaseSensetive = new System.Windows.Forms.CheckBox();
			this.isFromStart = new System.Windows.Forms.CheckBox();
			this.StartReplace = new System.Windows.Forms.Button();
			this.StartSeacrh = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.toReplace = new System.Windows.Forms.TextBox();
			this.toSearch = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.goTo = new System.Windows.Forms.Button();
			this.lines = new System.Windows.Forms.NumericUpDown();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FontsSize)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lines)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.форматToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(932, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.новоеОкноToolStripMenuItem,
            this.toolStripSeparator1,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// создатьToolStripMenuItem
			// 
			this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
			this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.создатьToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
			this.создатьToolStripMenuItem.Text = "Создать";
			this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
			// 
			// открытьToolStripMenuItem
			// 
			this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
			this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.открытьToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
			this.открытьToolStripMenuItem.Text = "Открыть";
			this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
			// 
			// новоеОкноToolStripMenuItem
			// 
			this.новоеОкноToolStripMenuItem.Name = "новоеОкноToolStripMenuItem";
			this.новоеОкноToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
			this.новоеОкноToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
			this.новоеОкноToolStripMenuItem.Text = "Новое окно";
			this.новоеОкноToolStripMenuItem.Click += new System.EventHandler(this.новоеОкноToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
			// 
			// сохранитьToolStripMenuItem
			// 
			this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
			this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
			this.сохранитьToolStripMenuItem.Text = "Сохранить";
			this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
			// 
			// сохранитьКакToolStripMenuItem
			// 
			this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
			this.сохранитьКакToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
			this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
			this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(223, 6);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
			// 
			// правкаToolStripMenuItem
			// 
			this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьToolStripMenuItem,
            this.toolStripSeparator3,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.toolStripSeparator4,
            this.найтиToolStripMenuItem,
            this.перейтиToolStripMenuItem});
			this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
			this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.правкаToolStripMenuItem.Text = "Правка";
			// 
			// отменитьToolStripMenuItem
			// 
			this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
			this.отменитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.отменитьToolStripMenuItem.Text = "Отменить";
			this.отменитьToolStripMenuItem.Click += new System.EventHandler(this.отменитьToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
			// 
			// вырезатьToolStripMenuItem
			// 
			this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
			this.вырезатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.вырезатьToolStripMenuItem.Text = "Вырезать";
			this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
			// 
			// копироватьToolStripMenuItem
			// 
			this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
			this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.копироватьToolStripMenuItem.Text = "Копировать";
			this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
			// 
			// вставитьToolStripMenuItem
			// 
			this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
			this.вставитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.вставитьToolStripMenuItem.Text = "Вставить";
			this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(178, 6);
			// 
			// найтиToolStripMenuItem
			// 
			this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
			this.найтиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.найтиToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.найтиToolStripMenuItem.Text = "Найти";
			this.найтиToolStripMenuItem.Click += new System.EventHandler(this.найтиToolStripMenuItem_Click);
			// 
			// перейтиToolStripMenuItem
			// 
			this.перейтиToolStripMenuItem.Name = "перейтиToolStripMenuItem";
			this.перейтиToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.перейтиToolStripMenuItem.Text = "Перейти";
			this.перейтиToolStripMenuItem.Click += new System.EventHandler(this.перейтиToolStripMenuItem_Click);
			// 
			// форматToolStripMenuItem
			// 
			this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шрифтToolStripMenuItem});
			this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
			this.форматToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.форматToolStripMenuItem.Text = "Формат";
			// 
			// шрифтToolStripMenuItem
			// 
			this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
			this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.шрифтToolStripMenuItem.Text = "Шрифт";
			this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.linesCount,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.wordCount,
            this.toolStripStatusLabel5,
            this.lettersSpaced,
            this.toolStripStatusLabel4,
            this.letterUnspaced,
            this.toolStripStatusLabel6,
            this.caretCurrentPosition});
			this.statusStrip1.Location = new System.Drawing.Point(0, 659);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(932, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(112, 17);
			this.toolStripStatusLabel1.Text = "Количество строк: ";
			// 
			// linesCount
			// 
			this.linesCount.Name = "linesCount";
			this.linesCount.Size = new System.Drawing.Size(13, 17);
			this.linesCount.Text = "0";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(107, 17);
			this.toolStripStatusLabel3.Text = "Количество слов: ";
			// 
			// wordCount
			// 
			this.wordCount.Name = "wordCount";
			this.wordCount.Size = new System.Drawing.Size(13, 17);
			this.wordCount.Text = "0";
			// 
			// toolStripStatusLabel5
			// 
			this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			this.toolStripStatusLabel5.Size = new System.Drawing.Size(145, 17);
			this.toolStripStatusLabel5.Text = "Символов с пробелами: ";
			// 
			// lettersSpaced
			// 
			this.lettersSpaced.Name = "lettersSpaced";
			this.lettersSpaced.Size = new System.Drawing.Size(13, 17);
			this.lettersSpaced.Text = "0";
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(141, 17);
			this.toolStripStatusLabel4.Text = "Символов без пробела: ";
			// 
			// letterUnspaced
			// 
			this.letterUnspaced.Name = "letterUnspaced";
			this.letterUnspaced.Size = new System.Drawing.Size(13, 17);
			this.letterUnspaced.Text = "0";
			// 
			// toolStripStatusLabel6
			// 
			this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
			this.toolStripStatusLabel6.Size = new System.Drawing.Size(107, 17);
			this.toolStripStatusLabel6.Text = "Позиция каретки: ";
			// 
			// caretCurrentPosition
			// 
			this.caretCurrentPosition.Name = "caretCurrentPosition";
			this.caretCurrentPosition.Size = new System.Drawing.Size(13, 17);
			this.caretCurrentPosition.Text = "0";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// text
			// 
			this.text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.text.Location = new System.Drawing.Point(0, 134);
			this.text.Margin = new System.Windows.Forms.Padding(0);
			this.text.Name = "text";
			this.text.Size = new System.Drawing.Size(932, 522);
			this.text.TabIndex = 3;
			this.text.Text = "";
			this.text.TextChanged += new System.EventHandler(this.text_TextChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.53648F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.67811F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(932, 110);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.FontsSize);
			this.panel1.Controls.Add(this.Fonts);
			this.panel1.Controls.Add(this.isUnderline);
			this.panel1.Controls.Add(this.isItalic);
			this.panel1.Controls.Add(this.isBold);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(226, 104);
			this.panel1.TabIndex = 0;
			// 
			// FontsSize
			// 
			this.FontsSize.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.FontsSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.FontsSize.DecimalPlaces = 2;
			this.FontsSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.FontsSize.Location = new System.Drawing.Point(152, 24);
			this.FontsSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.FontsSize.Name = "FontsSize";
			this.FontsSize.Size = new System.Drawing.Size(72, 21);
			this.FontsSize.TabIndex = 4;
			this.toolTip1.SetToolTip(this.FontsSize, "Кегель");
			this.FontsSize.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
			this.FontsSize.ValueChanged += new System.EventHandler(this.FontsSize_ValueChanged);
			// 
			// Fonts
			// 
			this.Fonts.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Fonts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.Fonts.DropDownHeight = 120;
			this.Fonts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Fonts.FormattingEnabled = true;
			this.Fonts.IntegralHeight = false;
			this.Fonts.Location = new System.Drawing.Point(3, 24);
			this.Fonts.Name = "Fonts";
			this.Fonts.Size = new System.Drawing.Size(147, 21);
			this.Fonts.TabIndex = 3;
			this.toolTip1.SetToolTip(this.Fonts, "Шрифты");
			this.Fonts.SelectedIndexChanged += new System.EventHandler(this.Fonts_SelectedIndexChanged);
			// 
			// isUnderline
			// 
			this.isUnderline.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.isUnderline.Appearance = System.Windows.Forms.Appearance.Button;
			this.isUnderline.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.isUnderline.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
			this.isUnderline.FlatAppearance.BorderSize = 0;
			this.isUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.isUnderline.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.isUnderline.Location = new System.Drawing.Point(151, 49);
			this.isUnderline.Margin = new System.Windows.Forms.Padding(1);
			this.isUnderline.Name = "isUnderline";
			this.isUnderline.Size = new System.Drawing.Size(73, 27);
			this.isUnderline.TabIndex = 2;
			this.isUnderline.Text = "Underline";
			this.isUnderline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.isUnderline, "Подчеркивание");
			this.isUnderline.UseVisualStyleBackColor = false;
			this.isUnderline.CheckedChanged += new System.EventHandler(this.isUnderline_CheckedChanged);
			// 
			// isItalic
			// 
			this.isItalic.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.isItalic.Appearance = System.Windows.Forms.Appearance.Button;
			this.isItalic.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.isItalic.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
			this.isItalic.FlatAppearance.BorderSize = 0;
			this.isItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.isItalic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.isItalic.Location = new System.Drawing.Point(76, 49);
			this.isItalic.Margin = new System.Windows.Forms.Padding(1);
			this.isItalic.Name = "isItalic";
			this.isItalic.Size = new System.Drawing.Size(73, 27);
			this.isItalic.TabIndex = 1;
			this.isItalic.Text = "Italic";
			this.isItalic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.isItalic, "Италик");
			this.isItalic.UseVisualStyleBackColor = false;
			this.isItalic.CheckedChanged += new System.EventHandler(this.isItalic_CheckedChanged);
			// 
			// isBold
			// 
			this.isBold.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.isBold.Appearance = System.Windows.Forms.Appearance.Button;
			this.isBold.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.isBold.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
			this.isBold.FlatAppearance.BorderSize = 0;
			this.isBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.isBold.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.isBold.Location = new System.Drawing.Point(1, 49);
			this.isBold.Margin = new System.Windows.Forms.Padding(1);
			this.isBold.Name = "isBold";
			this.isBold.Size = new System.Drawing.Size(73, 27);
			this.isBold.TabIndex = 0;
			this.isBold.Text = "Bold";
			this.isBold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.isBold, "Полужирный");
			this.isBold.UseVisualStyleBackColor = false;
			this.isBold.CheckedChanged += new System.EventHandler(this.isBold_CheckedChanged);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.Copy);
			this.panel2.Controls.Add(this.Search);
			this.panel2.Controls.Add(this.SelectAll);
			this.panel2.Controls.Add(this.Cancel);
			this.panel2.Controls.Add(this.Cut);
			this.panel2.Controls.Add(this.Paste);
			this.panel2.Location = new System.Drawing.Point(235, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(226, 104);
			this.panel2.TabIndex = 1;
			// 
			// Copy
			// 
			this.Copy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Copy.BackgroundImage = global::RedFox.Icons.copy;
			this.Copy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Copy.FlatAppearance.BorderSize = 0;
			this.Copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Copy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.Copy.Location = new System.Drawing.Point(1, 2);
			this.Copy.Margin = new System.Windows.Forms.Padding(1);
			this.Copy.Name = "Copy";
			this.Copy.Size = new System.Drawing.Size(73, 50);
			this.Copy.TabIndex = 0;
			this.toolTip1.SetToolTip(this.Copy, "Копировать выделенный фрагмент");
			this.Copy.UseVisualStyleBackColor = false;
			this.Copy.Click += new System.EventHandler(this.Copy_Click);
			// 
			// Search
			// 
			this.Search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Search.BackgroundImage")));
			this.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Search.FlatAppearance.BorderSize = 0;
			this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Search.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
			this.Search.Location = new System.Drawing.Point(151, 53);
			this.Search.Margin = new System.Windows.Forms.Padding(1);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(73, 50);
			this.Search.TabIndex = 5;
			this.toolTip1.SetToolTip(this.Search, "Найти выбранный фрагмент");
			this.Search.UseVisualStyleBackColor = false;
			this.Search.Click += new System.EventHandler(this.Search_Click);
			// 
			// SelectAll
			// 
			this.SelectAll.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.SelectAll.BackgroundImage = global::RedFox.Icons.select_all;
			this.SelectAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.SelectAll.FlatAppearance.BorderSize = 0;
			this.SelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SelectAll.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Bold);
			this.SelectAll.Location = new System.Drawing.Point(76, 53);
			this.SelectAll.Margin = new System.Windows.Forms.Padding(1);
			this.SelectAll.Name = "SelectAll";
			this.SelectAll.Size = new System.Drawing.Size(73, 50);
			this.SelectAll.TabIndex = 4;
			this.toolTip1.SetToolTip(this.SelectAll, "Выделить все");
			this.SelectAll.UseVisualStyleBackColor = false;
			this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
			// 
			// Cancel
			// 
			this.Cancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Cancel.BackgroundImage = global::RedFox.Icons.undo;
			this.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Cancel.FlatAppearance.BorderSize = 0;
			this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
			this.Cancel.Location = new System.Drawing.Point(1, 53);
			this.Cancel.Margin = new System.Windows.Forms.Padding(1);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(73, 50);
			this.Cancel.TabIndex = 3;
			this.toolTip1.SetToolTip(this.Cancel, "Отменить");
			this.Cancel.UseVisualStyleBackColor = false;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// Cut
			// 
			this.Cut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Cut.BackgroundImage = global::RedFox.Icons.cut;
			this.Cut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Cut.FlatAppearance.BorderSize = 0;
			this.Cut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Cut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.Cut.Location = new System.Drawing.Point(151, 2);
			this.Cut.Margin = new System.Windows.Forms.Padding(1);
			this.Cut.Name = "Cut";
			this.Cut.Size = new System.Drawing.Size(73, 50);
			this.Cut.TabIndex = 2;
			this.toolTip1.SetToolTip(this.Cut, "Вырезать фрагмент");
			this.Cut.UseVisualStyleBackColor = false;
			this.Cut.Click += new System.EventHandler(this.Cut_Click);
			// 
			// Paste
			// 
			this.Paste.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Paste.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Paste.BackgroundImage")));
			this.Paste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.Paste.FlatAppearance.BorderSize = 0;
			this.Paste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Paste.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.Paste.Location = new System.Drawing.Point(76, 2);
			this.Paste.Margin = new System.Windows.Forms.Padding(1);
			this.Paste.Name = "Paste";
			this.Paste.Size = new System.Drawing.Size(73, 50);
			this.Paste.TabIndex = 1;
			this.toolTip1.SetToolTip(this.Paste, "Вставить из буфера обмена");
			this.Paste.UseVisualStyleBackColor = false;
			this.Paste.Click += new System.EventHandler(this.Paste_Click);
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Controls.Add(this.ReplaceAll);
			this.panel3.Controls.Add(this.isCaseSensetive);
			this.panel3.Controls.Add(this.isFromStart);
			this.panel3.Controls.Add(this.StartReplace);
			this.panel3.Controls.Add(this.StartSeacrh);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.toReplace);
			this.panel3.Controls.Add(this.toSearch);
			this.panel3.Location = new System.Drawing.Point(467, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(231, 104);
			this.panel3.TabIndex = 2;
			// 
			// ReplaceAll
			// 
			this.ReplaceAll.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ReplaceAll.BackgroundImage = global::RedFox.Icons.replace_all;
			this.ReplaceAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ReplaceAll.FlatAppearance.BorderSize = 0;
			this.ReplaceAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ReplaceAll.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.ReplaceAll.Location = new System.Drawing.Point(147, 55);
			this.ReplaceAll.Margin = new System.Windows.Forms.Padding(0);
			this.ReplaceAll.Name = "ReplaceAll";
			this.ReplaceAll.Size = new System.Drawing.Size(41, 41);
			this.ReplaceAll.TabIndex = 7;
			this.toolTip1.SetToolTip(this.ReplaceAll, "Заменить все");
			this.ReplaceAll.UseVisualStyleBackColor = false;
			this.ReplaceAll.Click += new System.EventHandler(this.ReplaceAll_Click);
			// 
			// isCaseSensetive
			// 
			this.isCaseSensetive.Appearance = System.Windows.Forms.Appearance.Button;
			this.isCaseSensetive.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.isCaseSensetive.BackgroundImage = global::RedFox.Icons.case_sensetive_false;
			this.isCaseSensetive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.isCaseSensetive.FlatAppearance.BorderSize = 0;
			this.isCaseSensetive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.isCaseSensetive.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.isCaseSensetive.Location = new System.Drawing.Point(188, 5);
			this.isCaseSensetive.Margin = new System.Windows.Forms.Padding(0);
			this.isCaseSensetive.Name = "isCaseSensetive";
			this.isCaseSensetive.Size = new System.Drawing.Size(41, 41);
			this.isCaseSensetive.TabIndex = 6;
			this.toolTip1.SetToolTip(this.isCaseSensetive, "Чувствителен ли поиск к регистру\r\n");
			this.isCaseSensetive.UseVisualStyleBackColor = false;
			this.isCaseSensetive.CheckedChanged += new System.EventHandler(this.isCaseSensetive_CheckedChanged);
			// 
			// isFromStart
			// 
			this.isFromStart.Appearance = System.Windows.Forms.Appearance.Button;
			this.isFromStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.isFromStart.BackgroundImage = global::RedFox.Icons.direct_order;
			this.isFromStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.isFromStart.FlatAppearance.BorderSize = 0;
			this.isFromStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.isFromStart.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.isFromStart.Location = new System.Drawing.Point(147, 5);
			this.isFromStart.Margin = new System.Windows.Forms.Padding(0);
			this.isFromStart.Name = "isFromStart";
			this.isFromStart.Size = new System.Drawing.Size(41, 41);
			this.isFromStart.TabIndex = 4;
			this.toolTip1.SetToolTip(this.isFromStart, "В каком направлении осуществляется поиск\r\n1—>9 — прямой порядок. Поиск и замена д" +
        "алее от курсора\r\n9—>1 — обратный порядок. Поиск и замена ранее от курсора\r\n");
			this.isFromStart.UseVisualStyleBackColor = false;
			this.isFromStart.CheckedChanged += new System.EventHandler(this.isFromStart_CheckedChanged);
			// 
			// StartReplace
			// 
			this.StartReplace.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.StartReplace.BackgroundImage = global::RedFox.Icons.replace;
			this.StartReplace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.StartReplace.FlatAppearance.BorderSize = 0;
			this.StartReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StartReplace.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.StartReplace.Location = new System.Drawing.Point(106, 55);
			this.StartReplace.Margin = new System.Windows.Forms.Padding(0);
			this.StartReplace.Name = "StartReplace";
			this.StartReplace.Size = new System.Drawing.Size(41, 41);
			this.StartReplace.TabIndex = 5;
			this.toolTip1.SetToolTip(this.StartReplace, "Заменить");
			this.StartReplace.UseVisualStyleBackColor = false;
			this.StartReplace.Click += new System.EventHandler(this.StartReplace_Click);
			// 
			// StartSeacrh
			// 
			this.StartSeacrh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.StartSeacrh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartSeacrh.BackgroundImage")));
			this.StartSeacrh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.StartSeacrh.FlatAppearance.BorderSize = 0;
			this.StartSeacrh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StartSeacrh.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.StartSeacrh.ForeColor = System.Drawing.SystemColors.ControlText;
			this.StartSeacrh.Location = new System.Drawing.Point(106, 5);
			this.StartSeacrh.Margin = new System.Windows.Forms.Padding(0);
			this.StartSeacrh.Name = "StartSeacrh";
			this.StartSeacrh.Size = new System.Drawing.Size(41, 41);
			this.StartSeacrh.TabIndex = 4;
			this.toolTip1.SetToolTip(this.StartSeacrh, "Найти\r\n");
			this.StartSeacrh.UseVisualStyleBackColor = false;
			this.StartSeacrh.Click += new System.EventHandler(this.StartSeacrh_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.label2.Location = new System.Drawing.Point(4, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Замена";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.label1.Location = new System.Drawing.Point(4, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Поиск";
			// 
			// toReplace
			// 
			this.toReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.toReplace.Location = new System.Drawing.Point(3, 64);
			this.toReplace.Margin = new System.Windows.Forms.Padding(0);
			this.toReplace.Name = "toReplace";
			this.toReplace.Size = new System.Drawing.Size(100, 26);
			this.toReplace.TabIndex = 1;
			// 
			// toSearch
			// 
			this.toSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.toSearch.Location = new System.Drawing.Point(3, 14);
			this.toSearch.Margin = new System.Windows.Forms.Padding(0);
			this.toSearch.Name = "toSearch";
			this.toSearch.Size = new System.Drawing.Size(100, 26);
			this.toSearch.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.BackColor = System.Drawing.Color.White;
			this.panel4.Controls.Add(this.goTo);
			this.panel4.Controls.Add(this.lines);
			this.panel4.Location = new System.Drawing.Point(704, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(225, 104);
			this.panel4.TabIndex = 3;
			// 
			// goTo
			// 
			this.goTo.BackgroundImage = global::RedFox.Icons.go_to;
			this.goTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.goTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.goTo.Location = new System.Drawing.Point(135, 24);
			this.goTo.Name = "goTo";
			this.goTo.Size = new System.Drawing.Size(41, 41);
			this.goTo.TabIndex = 1;
			this.toolTip1.SetToolTip(this.goTo, "Перейти к строке");
			this.goTo.UseVisualStyleBackColor = true;
			this.goTo.Click += new System.EventHandler(this.goTo_Click);
			// 
			// lines
			// 
			this.lines.Location = new System.Drawing.Point(38, 36);
			this.lines.Name = "lines";
			this.lines.Size = new System.Drawing.Size(46, 20);
			this.lines.TabIndex = 0;
			this.toolTip1.SetToolTip(this.lines, "К какой строке перейти");
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(932, 681);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.text);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "RedFox";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.FontsSize)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lines)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новоеОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перейтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox isBold;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox isItalic;
        private System.Windows.Forms.CheckBox isUnderline;
        private System.Windows.Forms.ComboBox Fonts;
        private System.Windows.Forms.NumericUpDown FontsSize;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button SelectAll;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Cut;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.CheckBox isFromStart;
        private System.Windows.Forms.Button StartReplace;
        private System.Windows.Forms.Button StartSeacrh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox toReplace;
        private System.Windows.Forms.TextBox toSearch;
        private System.Windows.Forms.Button ReplaceAll;
        private System.Windows.Forms.CheckBox isCaseSensetive;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button goTo;
        private System.Windows.Forms.NumericUpDown lines;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel linesCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel wordCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lettersSpaced;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel letterUnspaced;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel caretCurrentPosition;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}


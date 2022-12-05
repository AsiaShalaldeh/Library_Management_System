﻿namespace LibraryManagementSystem
{
    partial class LibrarianForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.createPanel = new System.Windows.Forms.Panel();
            this.bookSummaryBox = new System.Windows.Forms.RichTextBox();
            this.createBook = new System.Windows.Forms.Button();
            this.cancelBookPanel = new System.Windows.Forms.Button();
            this.bookCatalogIDBox = new System.Windows.Forms.ComboBox();
            this.bookLibraryIDBox = new System.Windows.Forms.ComboBox();
            this.bookRefBox = new System.Windows.Forms.ComboBox();
            this.bookLanguageBox = new System.Windows.Forms.TextBox();
            this.bookRFIDBox = new System.Windows.Forms.TextBox();
            this.bookPagesBox = new System.Windows.Forms.TextBox();
            this.bookPublisherBox = new System.Windows.Forms.TextBox();
            this.bookBarcodeBox = new System.Windows.Forms.TextBox();
            this.bookPubDate = new System.Windows.Forms.DateTimePicker();
            this.bookTitleBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bookPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteBookBtn = new System.Windows.Forms.Button();
            this.updateBookBtn = new System.Windows.Forms.Button();
            this.searchBookBtn = new System.Windows.Forms.Button();
            this.retrieveBookBtn = new System.Windows.Forms.Button();
            this.createBookBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.updateBookPanel = new System.Windows.Forms.Panel();
            this.updateBook = new System.Windows.Forms.Button();
            this.cancelBookUpdatePanel = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bookIDToUpdateBox = new System.Windows.Forms.TextBox();
            this.deleteBookPanel = new System.Windows.Forms.Panel();
            this.bookIDToDelete = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.deleteBook = new System.Windows.Forms.Button();
            this.cencelBookDeletePanel = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.serachBookPanel = new System.Windows.Forms.Panel();
            this.bookISBNSearch = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.searchBook = new System.Windows.Forms.Button();
            this.cancelSearchbookPanel = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.bookTitleSearch = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.createPanel.SuspendLayout();
            this.bookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.updateBookPanel.SuspendLayout();
            this.deleteBookPanel.SuspendLayout();
            this.serachBookPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1376, 749);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.library;
            this.tabPage1.Controls.Add(this.createPanel);
            this.tabPage1.Controls.Add(this.bookPanel);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1368, 711);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Book";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // createPanel
            // 
            this.createPanel.BackColor = System.Drawing.Color.LightGray;
            this.createPanel.Controls.Add(this.serachBookPanel);
            this.createPanel.Controls.Add(this.deleteBookPanel);
            this.createPanel.Controls.Add(this.updateBookPanel);
            this.createPanel.Controls.Add(this.bookSummaryBox);
            this.createPanel.Controls.Add(this.createBook);
            this.createPanel.Controls.Add(this.cancelBookPanel);
            this.createPanel.Controls.Add(this.bookCatalogIDBox);
            this.createPanel.Controls.Add(this.bookLibraryIDBox);
            this.createPanel.Controls.Add(this.bookRefBox);
            this.createPanel.Controls.Add(this.bookLanguageBox);
            this.createPanel.Controls.Add(this.bookRFIDBox);
            this.createPanel.Controls.Add(this.bookPagesBox);
            this.createPanel.Controls.Add(this.bookPublisherBox);
            this.createPanel.Controls.Add(this.bookBarcodeBox);
            this.createPanel.Controls.Add(this.bookPubDate);
            this.createPanel.Controls.Add(this.bookTitleBox);
            this.createPanel.Controls.Add(this.label12);
            this.createPanel.Controls.Add(this.label11);
            this.createPanel.Controls.Add(this.label10);
            this.createPanel.Controls.Add(this.label9);
            this.createPanel.Controls.Add(this.label8);
            this.createPanel.Controls.Add(this.label7);
            this.createPanel.Controls.Add(this.label6);
            this.createPanel.Controls.Add(this.label5);
            this.createPanel.Controls.Add(this.label2);
            this.createPanel.Controls.Add(this.label1);
            this.createPanel.Controls.Add(this.label3);
            this.createPanel.Controls.Add(this.label4);
            this.createPanel.Location = new System.Drawing.Point(369, 19);
            this.createPanel.Name = "createPanel";
            this.createPanel.Size = new System.Drawing.Size(928, 697);
            this.createPanel.TabIndex = 1;
            this.createPanel.Visible = false;
            this.createPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.createPanel_Paint);
            // 
            // bookSummaryBox
            // 
            this.bookSummaryBox.Location = new System.Drawing.Point(509, 516);
            this.bookSummaryBox.Name = "bookSummaryBox";
            this.bookSummaryBox.Size = new System.Drawing.Size(350, 112);
            this.bookSummaryBox.TabIndex = 32;
            this.bookSummaryBox.Text = "";
            // 
            // createBook
            // 
            this.createBook.BackColor = System.Drawing.Color.DarkOrange;
            this.createBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createBook.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.createBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createBook.Location = new System.Drawing.Point(265, 645);
            this.createBook.Name = "createBook";
            this.createBook.Size = new System.Drawing.Size(140, 44);
            this.createBook.TabIndex = 11;
            this.createBook.Text = "Create";
            this.createBook.UseVisualStyleBackColor = false;
            this.createBook.Click += new System.EventHandler(this.createBook_Click);
            // 
            // cancelBookPanel
            // 
            this.cancelBookPanel.BackColor = System.Drawing.Color.DarkOrange;
            this.cancelBookPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBookPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBookPanel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cancelBookPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelBookPanel.Location = new System.Drawing.Point(484, 645);
            this.cancelBookPanel.Name = "cancelBookPanel";
            this.cancelBookPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cancelBookPanel.Size = new System.Drawing.Size(147, 44);
            this.cancelBookPanel.TabIndex = 12;
            this.cancelBookPanel.Text = "Cancel";
            this.cancelBookPanel.UseVisualStyleBackColor = false;
            this.cancelBookPanel.Click += new System.EventHandler(this.cancelBookPanel_Click);
            // 
            // bookCatalogIDBox
            // 
            this.bookCatalogIDBox.FormattingEnabled = true;
            this.bookCatalogIDBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.bookCatalogIDBox.Location = new System.Drawing.Point(509, 392);
            this.bookCatalogIDBox.Name = "bookCatalogIDBox";
            this.bookCatalogIDBox.Size = new System.Drawing.Size(350, 38);
            this.bookCatalogIDBox.TabIndex = 31;
            // 
            // bookLibraryIDBox
            // 
            this.bookLibraryIDBox.FormattingEnabled = true;
            this.bookLibraryIDBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.bookLibraryIDBox.Location = new System.Drawing.Point(509, 291);
            this.bookLibraryIDBox.Name = "bookLibraryIDBox";
            this.bookLibraryIDBox.Size = new System.Drawing.Size(350, 38);
            this.bookLibraryIDBox.TabIndex = 30;
            // 
            // bookRefBox
            // 
            this.bookRefBox.FormattingEnabled = true;
            this.bookRefBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.bookRefBox.Location = new System.Drawing.Point(30, 497);
            this.bookRefBox.Name = "bookRefBox";
            this.bookRefBox.Size = new System.Drawing.Size(333, 38);
            this.bookRefBox.TabIndex = 29;
            // 
            // bookLanguageBox
            // 
            this.bookLanguageBox.Location = new System.Drawing.Point(28, 593);
            this.bookLanguageBox.Name = "bookLanguageBox";
            this.bookLanguageBox.Size = new System.Drawing.Size(335, 35);
            this.bookLanguageBox.TabIndex = 26;
            // 
            // bookRFIDBox
            // 
            this.bookRFIDBox.Location = new System.Drawing.Point(509, 108);
            this.bookRFIDBox.Name = "bookRFIDBox";
            this.bookRFIDBox.Size = new System.Drawing.Size(357, 35);
            this.bookRFIDBox.TabIndex = 25;
            // 
            // bookPagesBox
            // 
            this.bookPagesBox.Location = new System.Drawing.Point(28, 392);
            this.bookPagesBox.Name = "bookPagesBox";
            this.bookPagesBox.Size = new System.Drawing.Size(333, 35);
            this.bookPagesBox.TabIndex = 23;
            // 
            // bookPublisherBox
            // 
            this.bookPublisherBox.Location = new System.Drawing.Point(28, 296);
            this.bookPublisherBox.Name = "bookPublisherBox";
            this.bookPublisherBox.Size = new System.Drawing.Size(333, 35);
            this.bookPublisherBox.TabIndex = 22;
            // 
            // bookBarcodeBox
            // 
            this.bookBarcodeBox.Location = new System.Drawing.Point(28, 199);
            this.bookBarcodeBox.Name = "bookBarcodeBox";
            this.bookBarcodeBox.Size = new System.Drawing.Size(333, 35);
            this.bookBarcodeBox.TabIndex = 21;
            // 
            // bookPubDate
            // 
            this.bookPubDate.Location = new System.Drawing.Point(509, 199);
            this.bookPubDate.Name = "bookPubDate";
            this.bookPubDate.Size = new System.Drawing.Size(357, 35);
            this.bookPubDate.TabIndex = 20;
            // 
            // bookTitleBox
            // 
            this.bookTitleBox.Location = new System.Drawing.Point(28, 108);
            this.bookTitleBox.Name = "bookTitleBox";
            this.bookTitleBox.Size = new System.Drawing.Size(333, 35);
            this.bookTitleBox.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(509, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 30);
            this.label12.TabIndex = 17;
            this.label12.Text = "Library ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(516, 352);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 30);
            this.label11.TabIndex = 16;
            this.label11.Text = "Catalog ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(509, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 30);
            this.label10.TabIndex = 15;
            this.label10.Text = "RFID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(26, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 30);
            this.label9.TabIndex = 14;
            this.label9.Text = "Is Reference Only";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 30);
            this.label8.TabIndex = 13;
            this.label8.Text = "Barcode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 549);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Language";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Number Of Pages";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(509, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Publication Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Publisher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(516, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(304, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 45);
            this.label4.TabIndex = 6;
            this.label4.Text = "Create New Book";
            // 
            // bookPanel
            // 
            this.bookPanel.BackColor = System.Drawing.Color.White;
            this.bookPanel.Controls.Add(this.pictureBox1);
            this.bookPanel.Controls.Add(this.deleteBookBtn);
            this.bookPanel.Controls.Add(this.updateBookBtn);
            this.bookPanel.Controls.Add(this.searchBookBtn);
            this.bookPanel.Controls.Add(this.retrieveBookBtn);
            this.bookPanel.Controls.Add(this.createBookBtn);
            this.bookPanel.Location = new System.Drawing.Point(0, 0);
            this.bookPanel.Name = "bookPanel";
            this.bookPanel.Size = new System.Drawing.Size(302, 716);
            this.bookPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.center;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, 351);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 368);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // deleteBookBtn
            // 
            this.deleteBookBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBookBtn.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBookBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBookBtn.Location = new System.Drawing.Point(0, 303);
            this.deleteBookBtn.Name = "deleteBookBtn";
            this.deleteBookBtn.Size = new System.Drawing.Size(302, 47);
            this.deleteBookBtn.TabIndex = 4;
            this.deleteBookBtn.Text = "Delete Book";
            this.deleteBookBtn.UseVisualStyleBackColor = false;
            this.deleteBookBtn.Click += new System.EventHandler(this.deleteBookBtn_Click);
            // 
            // updateBookBtn
            // 
            this.updateBookBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateBookBtn.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateBookBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBookBtn.Location = new System.Drawing.Point(0, 115);
            this.updateBookBtn.Name = "updateBookBtn";
            this.updateBookBtn.Size = new System.Drawing.Size(302, 47);
            this.updateBookBtn.TabIndex = 3;
            this.updateBookBtn.Text = "Update Book";
            this.updateBookBtn.UseVisualStyleBackColor = false;
            this.updateBookBtn.Click += new System.EventHandler(this.updateBookBtn_Click);
            // 
            // searchBookBtn
            // 
            this.searchBookBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBookBtn.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchBookBtn.ForeColor = System.Drawing.Color.Black;
            this.searchBookBtn.Location = new System.Drawing.Point(0, 178);
            this.searchBookBtn.Name = "searchBookBtn";
            this.searchBookBtn.Size = new System.Drawing.Size(302, 47);
            this.searchBookBtn.TabIndex = 2;
            this.searchBookBtn.Text = "Search Book";
            this.searchBookBtn.UseVisualStyleBackColor = false;
            this.searchBookBtn.Click += new System.EventHandler(this.searchBookBtn_Click);
            // 
            // retrieveBookBtn
            // 
            this.retrieveBookBtn.BackColor = System.Drawing.Color.Transparent;
            this.retrieveBookBtn.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.retrieveBookBtn.ForeColor = System.Drawing.Color.Black;
            this.retrieveBookBtn.Location = new System.Drawing.Point(0, 240);
            this.retrieveBookBtn.Name = "retrieveBookBtn";
            this.retrieveBookBtn.Size = new System.Drawing.Size(302, 47);
            this.retrieveBookBtn.TabIndex = 1;
            this.retrieveBookBtn.Text = "Retrieve Book";
            this.retrieveBookBtn.UseVisualStyleBackColor = false;
            // 
            // createBookBtn
            // 
            this.createBookBtn.BackColor = System.Drawing.Color.Transparent;
            this.createBookBtn.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createBookBtn.ForeColor = System.Drawing.Color.Black;
            this.createBookBtn.Location = new System.Drawing.Point(0, 52);
            this.createBookBtn.Name = "createBookBtn";
            this.createBookBtn.Size = new System.Drawing.Size(302, 47);
            this.createBookBtn.TabIndex = 0;
            this.createBookBtn.Text = "Create Book";
            this.createBookBtn.UseVisualStyleBackColor = false;
            this.createBookBtn.Click += new System.EventHandler(this.createBookBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.library;
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1368, 711);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Patron";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // updateBookPanel
            // 
            this.updateBookPanel.BackColor = System.Drawing.Color.LightGray;
            this.updateBookPanel.Controls.Add(this.bookIDToUpdateBox);
            this.updateBookPanel.Controls.Add(this.label13);
            this.updateBookPanel.Controls.Add(this.updateBook);
            this.updateBookPanel.Controls.Add(this.cancelBookUpdatePanel);
            this.updateBookPanel.Controls.Add(this.label24);
            this.updateBookPanel.Location = new System.Drawing.Point(111, 82);
            this.updateBookPanel.Name = "updateBookPanel";
            this.updateBookPanel.Size = new System.Drawing.Size(676, 453);
            this.updateBookPanel.TabIndex = 2;
            this.updateBookPanel.Visible = false;
            // 
            // updateBook
            // 
            this.updateBook.BackColor = System.Drawing.Color.DarkOrange;
            this.updateBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateBook.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.updateBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateBook.Location = new System.Drawing.Point(168, 351);
            this.updateBook.Name = "updateBook";
            this.updateBook.Size = new System.Drawing.Size(140, 44);
            this.updateBook.TabIndex = 11;
            this.updateBook.Text = "Update";
            this.updateBook.UseVisualStyleBackColor = false;
            this.updateBook.Click += new System.EventHandler(this.updateBook_Click);
            // 
            // cancelBookUpdatePanel
            // 
            this.cancelBookUpdatePanel.BackColor = System.Drawing.Color.DarkOrange;
            this.cancelBookUpdatePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBookUpdatePanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelBookUpdatePanel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cancelBookUpdatePanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelBookUpdatePanel.Location = new System.Drawing.Point(354, 351);
            this.cancelBookUpdatePanel.Name = "cancelBookUpdatePanel";
            this.cancelBookUpdatePanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cancelBookUpdatePanel.Size = new System.Drawing.Size(147, 44);
            this.cancelBookUpdatePanel.TabIndex = 12;
            this.cancelBookUpdatePanel.Text = "Cancel";
            this.cancelBookUpdatePanel.UseVisualStyleBackColor = false;
            this.cancelBookUpdatePanel.Click += new System.EventHandler(this.cancelBookUpdatePanel_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.ForeColor = System.Drawing.Color.DarkOrange;
            this.label24.Location = new System.Drawing.Point(193, 14);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(221, 45);
            this.label24.TabIndex = 6;
            this.label24.Text = "Update Book";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(83, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 30);
            this.label13.TabIndex = 13;
            this.label13.Text = "ID";
            // 
            // bookIDToUpdateBox
            // 
            this.bookIDToUpdateBox.Location = new System.Drawing.Point(168, 117);
            this.bookIDToUpdateBox.Name = "bookIDToUpdateBox";
            this.bookIDToUpdateBox.Size = new System.Drawing.Size(333, 35);
            this.bookIDToUpdateBox.TabIndex = 19;
            // 
            // deleteBookPanel
            // 
            this.deleteBookPanel.BackColor = System.Drawing.Color.LightGray;
            this.deleteBookPanel.Controls.Add(this.bookIDToDelete);
            this.deleteBookPanel.Controls.Add(this.label14);
            this.deleteBookPanel.Controls.Add(this.deleteBook);
            this.deleteBookPanel.Controls.Add(this.cencelBookDeletePanel);
            this.deleteBookPanel.Controls.Add(this.label15);
            this.deleteBookPanel.Location = new System.Drawing.Point(108, 57);
            this.deleteBookPanel.Name = "deleteBookPanel";
            this.deleteBookPanel.Size = new System.Drawing.Size(676, 453);
            this.deleteBookPanel.TabIndex = 3;
            this.deleteBookPanel.Visible = false;
            // 
            // bookIDToDelete
            // 
            this.bookIDToDelete.Location = new System.Drawing.Point(168, 117);
            this.bookIDToDelete.Name = "bookIDToDelete";
            this.bookIDToDelete.Size = new System.Drawing.Size(333, 35);
            this.bookIDToDelete.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(83, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 30);
            this.label14.TabIndex = 13;
            this.label14.Text = "ID";
            // 
            // deleteBook
            // 
            this.deleteBook.BackColor = System.Drawing.Color.DarkOrange;
            this.deleteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBook.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.deleteBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteBook.Location = new System.Drawing.Point(168, 351);
            this.deleteBook.Name = "deleteBook";
            this.deleteBook.Size = new System.Drawing.Size(140, 44);
            this.deleteBook.TabIndex = 11;
            this.deleteBook.Text = "Update";
            this.deleteBook.UseVisualStyleBackColor = false;
            this.deleteBook.Click += new System.EventHandler(this.deleteBook_Click);
            // 
            // cencelBookDeletePanel
            // 
            this.cencelBookDeletePanel.BackColor = System.Drawing.Color.DarkOrange;
            this.cencelBookDeletePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cencelBookDeletePanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cencelBookDeletePanel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cencelBookDeletePanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cencelBookDeletePanel.Location = new System.Drawing.Point(354, 351);
            this.cencelBookDeletePanel.Name = "cencelBookDeletePanel";
            this.cencelBookDeletePanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cencelBookDeletePanel.Size = new System.Drawing.Size(147, 44);
            this.cencelBookDeletePanel.TabIndex = 12;
            this.cencelBookDeletePanel.Text = "Cancel";
            this.cencelBookDeletePanel.UseVisualStyleBackColor = false;
            this.cencelBookDeletePanel.Click += new System.EventHandler(this.cencelBookDeletePanel_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.DarkOrange;
            this.label15.Location = new System.Drawing.Point(193, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(212, 45);
            this.label15.TabIndex = 6;
            this.label15.Text = "Delete Book";
            // 
            // serachBookPanel
            // 
            this.serachBookPanel.BackColor = System.Drawing.Color.LightGray;
            this.serachBookPanel.Controls.Add(this.bookTitleSearch);
            this.serachBookPanel.Controls.Add(this.label18);
            this.serachBookPanel.Controls.Add(this.bookISBNSearch);
            this.serachBookPanel.Controls.Add(this.label16);
            this.serachBookPanel.Controls.Add(this.searchBook);
            this.serachBookPanel.Controls.Add(this.cancelSearchbookPanel);
            this.serachBookPanel.Controls.Add(this.label17);
            this.serachBookPanel.Location = new System.Drawing.Point(49, 46);
            this.serachBookPanel.Name = "serachBookPanel";
            this.serachBookPanel.Size = new System.Drawing.Size(831, 453);
            this.serachBookPanel.TabIndex = 4;
            this.serachBookPanel.Visible = false;
            // 
            // bookISBNSearch
            // 
            this.bookISBNSearch.Location = new System.Drawing.Point(168, 117);
            this.bookISBNSearch.Name = "bookISBNSearch";
            this.bookISBNSearch.Size = new System.Drawing.Size(146, 35);
            this.bookISBNSearch.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(83, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 30);
            this.label16.TabIndex = 13;
            this.label16.Text = "ISBN";
            // 
            // searchBook
            // 
            this.searchBook.BackColor = System.Drawing.Color.DarkOrange;
            this.searchBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBook.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.searchBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchBook.Location = new System.Drawing.Point(255, 390);
            this.searchBook.Name = "searchBook";
            this.searchBook.Size = new System.Drawing.Size(140, 44);
            this.searchBook.TabIndex = 11;
            this.searchBook.Text = "Search";
            this.searchBook.UseVisualStyleBackColor = false;
            this.searchBook.Click += new System.EventHandler(this.searchBook_Click);
            // 
            // cancelSearchbookPanel
            // 
            this.cancelSearchbookPanel.BackColor = System.Drawing.Color.DarkOrange;
            this.cancelSearchbookPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelSearchbookPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelSearchbookPanel.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cancelSearchbookPanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelSearchbookPanel.Location = new System.Drawing.Point(435, 390);
            this.cancelSearchbookPanel.Name = "cancelSearchbookPanel";
            this.cancelSearchbookPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cancelSearchbookPanel.Size = new System.Drawing.Size(147, 44);
            this.cancelSearchbookPanel.TabIndex = 12;
            this.cancelSearchbookPanel.Text = "Cancel";
            this.cancelSearchbookPanel.UseVisualStyleBackColor = false;
            this.cancelSearchbookPanel.Click += new System.EventHandler(this.cancelSearchbookPanel_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.DarkOrange;
            this.label17.Location = new System.Drawing.Point(313, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(221, 45);
            this.label17.TabIndex = 6;
            this.label17.Text = "Search Book";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(435, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 30);
            this.label18.TabIndex = 20;
            this.label18.Text = "Title";
            // 
            // bookTitleSearch
            // 
            this.bookTitleSearch.Location = new System.Drawing.Point(529, 117);
            this.bookTitleSearch.Name = "bookTitleSearch";
            this.bookTitleSearch.Size = new System.Drawing.Size(146, 35);
            this.bookTitleSearch.TabIndex = 21;
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1329, 749);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LibrarianForm";
            this.Text = "Library Management System";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.createPanel.ResumeLayout(false);
            this.createPanel.PerformLayout();
            this.bookPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.updateBookPanel.ResumeLayout(false);
            this.updateBookPanel.PerformLayout();
            this.deleteBookPanel.ResumeLayout(false);
            this.deleteBookPanel.PerformLayout();
            this.serachBookPanel.ResumeLayout(false);
            this.serachBookPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel bookPanel;
        private Button createBookBtn;
        private TabPage tabPage2;
        private Button deleteBookBtn;
        private Button updateBookBtn;
        private Button searchBookBtn;
        private Button retrieveBookBtn;
        private PictureBox pictureBox1;
        private Panel createPanel;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label9;
        private Label label8;
        private TextBox bookLanguageBox;
        private TextBox bookRFIDBox;
        private TextBox bookPagesBox;
        private TextBox bookPublisherBox;
        private TextBox bookBarcodeBox;
        private DateTimePicker bookPubDate;
        private TextBox bookTitleBox;
        private Label label12;
        private Label label11;
        private Label label10;
        private ComboBox bookRefBox;
        private ComboBox bookCatalogIDBox;
        private ComboBox bookLibraryIDBox;
        private Button createBook;
        private Button cancelBookPanel;
        private RichTextBox bookSummaryBox;
        private Panel updateBookPanel;
        private TextBox bookIDToUpdateBox;
        private Label label13;
        private Button updateBook;
        private Button cancelBookUpdatePanel;
        private Label label24;
        private Panel deleteBookPanel;
        private TextBox bookIDToDelete;
        private Label label14;
        private Button deleteBook;
        private Button cencelBookDeletePanel;
        private Label label15;
        private Panel serachBookPanel;
        private TextBox bookTitleSearch;
        private Label label18;
        private TextBox bookISBNSearch;
        private Label label16;
        private Button searchBook;
        private Button cancelSearchbookPanel;
        private Label label17;
    }
}
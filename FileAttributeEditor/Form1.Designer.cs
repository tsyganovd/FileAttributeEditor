namespace FileAttributeEditor
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
			this.label1 = new System.Windows.Forms.Label();
			this.edFileName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.edFilePath = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbHidden = new System.Windows.Forms.CheckBox();
			this.cbSystem = new System.Windows.Forms.CheckBox();
			this.cbReadOnly = new System.Windows.Forms.CheckBox();
			this.cbArchive = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dtCreationTime = new System.Windows.Forms.DateTimePicker();
			this.dtWriteTime = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.dtLastAccessTime = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.btnShowFileProperties = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Имя:";
			// 
			// edFileName
			// 
			this.edFileName.Location = new System.Drawing.Point(50, 19);
			this.edFileName.Name = "edFileName";
			this.edFileName.Size = new System.Drawing.Size(436, 20);
			this.edFileName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Путь";
			// 
			// edFilePath
			// 
			this.edFilePath.Location = new System.Drawing.Point(49, 45);
			this.edFilePath.Name = "edFilePath";
			this.edFilePath.ReadOnly = true;
			this.edFilePath.Size = new System.Drawing.Size(437, 20);
			this.edFilePath.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbHidden);
			this.groupBox1.Controls.Add(this.cbSystem);
			this.groupBox1.Controls.Add(this.cbReadOnly);
			this.groupBox1.Controls.Add(this.cbArchive);
			this.groupBox1.Location = new System.Drawing.Point(15, 69);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(130, 110);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Атрибуты файла";
			// 
			// cbHidden
			// 
			this.cbHidden.AutoSize = true;
			this.cbHidden.Location = new System.Drawing.Point(6, 88);
			this.cbHidden.Name = "cbHidden";
			this.cbHidden.Size = new System.Drawing.Size(72, 17);
			this.cbHidden.TabIndex = 3;
			this.cbHidden.Text = "Скрытый";
			this.cbHidden.UseVisualStyleBackColor = true;
			// 
			// cbSystem
			// 
			this.cbSystem.AutoSize = true;
			this.cbSystem.Location = new System.Drawing.Point(6, 65);
			this.cbSystem.Name = "cbSystem";
			this.cbSystem.Size = new System.Drawing.Size(84, 17);
			this.cbSystem.TabIndex = 2;
			this.cbSystem.Text = "Системный";
			this.cbSystem.UseVisualStyleBackColor = true;
			// 
			// cbReadOnly
			// 
			this.cbReadOnly.AutoSize = true;
			this.cbReadOnly.Location = new System.Drawing.Point(6, 42);
			this.cbReadOnly.Name = "cbReadOnly";
			this.cbReadOnly.Size = new System.Drawing.Size(115, 17);
			this.cbReadOnly.TabIndex = 1;
			this.cbReadOnly.Text = "Только для чтени";
			this.cbReadOnly.UseVisualStyleBackColor = true;
			// 
			// cbArchive
			// 
			this.cbArchive.AutoSize = true;
			this.cbArchive.Location = new System.Drawing.Point(6, 19);
			this.cbArchive.Name = "cbArchive";
			this.cbArchive.Size = new System.Drawing.Size(76, 17);
			this.cbArchive.TabIndex = 0;
			this.cbArchive.Text = "Архивный";
			this.cbArchive.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(148, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Создан";
			// 
			// dtCreationTime
			// 
			this.dtCreationTime.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			this.dtCreationTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtCreationTime.Location = new System.Drawing.Point(207, 75);
			this.dtCreationTime.Name = "dtCreationTime";
			this.dtCreationTime.Size = new System.Drawing.Size(139, 20);
			this.dtCreationTime.TabIndex = 6;
			// 
			// dtWriteTime
			// 
			this.dtWriteTime.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			this.dtWriteTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtWriteTime.Location = new System.Drawing.Point(207, 101);
			this.dtWriteTime.Name = "dtWriteTime";
			this.dtWriteTime.Size = new System.Drawing.Size(139, 20);
			this.dtWriteTime.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(148, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Изменён";
			// 
			// dtLastAccessTime
			// 
			this.dtLastAccessTime.CustomFormat = "dd.MM.yyyy HH:mm:ss";
			this.dtLastAccessTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtLastAccessTime.Location = new System.Drawing.Point(207, 127);
			this.dtLastAccessTime.Name = "dtLastAccessTime";
			this.dtLastAccessTime.Size = new System.Drawing.Size(139, 20);
			this.dtLastAccessTime.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(148, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Открыть";
			// 
			// btnShowFileProperties
			// 
			this.btnShowFileProperties.Location = new System.Drawing.Point(151, 153);
			this.btnShowFileProperties.Name = "btnShowFileProperties";
			this.btnShowFileProperties.Size = new System.Drawing.Size(332, 20);
			this.btnShowFileProperties.TabIndex = 11;
			this.btnShowFileProperties.Text = "Удаление дополнительной информации из файла";
			this.btnShowFileProperties.UseVisualStyleBackColor = true;
			this.btnShowFileProperties.Click += new System.EventHandler(this.btnShowFileProperties_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(151, 183);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 12;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(352, 183);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(131, 23);
			this.button2.TabIndex = 14;
			this.button2.Text = "Выйти без сохранения";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(232, 183);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(114, 23);
			this.button3.TabIndex = 13;
			this.button3.Text = "Сохранить и выйти";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button1_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(352, 75);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(131, 23);
			this.button4.TabIndex = 15;
			this.button4.Text = "< Скопировать во все.";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(289, 1);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(200, 13);
			this.linkLabel1.TabIndex = 0;
			this.linkLabel1.Text = "github.com/tsyganovd/FileAttributeEditor";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(177, 1);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(114, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Open source software:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 218);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnShowFileProperties);
			this.Controls.Add(this.dtLastAccessTime);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dtWriteTime);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtCreationTime);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.edFilePath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.edFileName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox edFileName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox edFilePath;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox cbHidden;
		private System.Windows.Forms.CheckBox cbSystem;
		private System.Windows.Forms.CheckBox cbReadOnly;
		private System.Windows.Forms.CheckBox cbArchive;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dtCreationTime;
		private System.Windows.Forms.DateTimePicker dtWriteTime;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtLastAccessTime;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnShowFileProperties;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label6;
	}
}


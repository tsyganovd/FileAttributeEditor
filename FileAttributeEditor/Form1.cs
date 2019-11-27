//Copyright D.M. Tsyganov, 2019
//https://github.com/tsyganovd/FileAttributeEditor
//
using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FileAttributeEditor
{
	public partial class Form1 : Form
	{
		//Not my code starts. Source - https://stackoverflow.com/a/1936957
		[DllImport("shell32.dll", CharSet = CharSet.Auto)]
		static extern bool ShellExecuteEx(ref SHELLEXECUTEINFO lpExecInfo);

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
		public struct SHELLEXECUTEINFO
		{
			public int cbSize;
			public uint fMask;
			public IntPtr hwnd;
			[MarshalAs(UnmanagedType.LPTStr)]
			public string lpVerb;
			[MarshalAs(UnmanagedType.LPTStr)]
			public string lpFile;
			[MarshalAs(UnmanagedType.LPTStr)]
			public string lpParameters;
			[MarshalAs(UnmanagedType.LPTStr)]
			public string lpDirectory;
			public int nShow;
			public IntPtr hInstApp;
			public IntPtr lpIDList;
			[MarshalAs(UnmanagedType.LPTStr)]
			public string lpClass;
			public IntPtr hkeyClass;
			public uint dwHotKey;
			public IntPtr hIcon;
			public IntPtr hProcess;
		}

		private const int SW_SHOW = 5;
		private const uint SEE_MASK_INVOKEIDLIST = 12;
		public static bool ShowFileProperties(string Filename)
		{
			SHELLEXECUTEINFO info = new SHELLEXECUTEINFO();
			info.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(info);
			info.lpVerb = "properties";
			info.lpFile = Filename;
			info.nShow = SW_SHOW;
			info.fMask = SEE_MASK_INVOKEIDLIST;
			return ShellExecuteEx(ref info);
		}
		//Not my code ends.

		private string FileName;
		private DateTime CreationTime;
		private DateTime LastAccessTime;
		private DateTime WriteTime;
		public Form1(string fileName)
		{
			FileName = fileName;
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Text = $"Редактор атрибутов файла {FileName}.";

			if (!File.Exists(FileName))
			{
				MessageBox.Show($"Файл {FileName} не найден.","Ошибка");
				Application.Exit();
			}
			try
			{
				edFileName.Text = Path.GetFileNameWithoutExtension(FileName);
				edFilePath.Text = Path.GetDirectoryName(FileName);
				toolTip1.SetToolTip(edFilePath, edFilePath.Text);

				FileAttributes FileAttribute = File.GetAttributes(FileName);
				if ((FileAttribute & FileAttributes.Archive) == FileAttributes.Archive) cbArchive.Checked = true;
				if ((FileAttribute & FileAttributes.ReadOnly) == FileAttributes.ReadOnly) cbReadOnly.Checked = true;
				if ((FileAttribute & FileAttributes.Hidden) == FileAttributes.Hidden) cbHidden.Checked = true;
				if ((FileAttribute & FileAttributes.System) == FileAttributes.System) cbSystem.Checked = true;
				cbHidden.CheckStateChanged += new System.EventHandler(Hidden_CheckStateChanged);
				cbSystem.CheckStateChanged += new System.EventHandler(Hidden_CheckStateChanged);

				CreationTime = File.GetCreationTime(FileName);
				dtCreationTime.Value = CreationTime;
				LastAccessTime = File.GetLastAccessTime(FileName);
				dtLastAccessTime.Value = LastAccessTime;
				WriteTime = File.GetLastWriteTime(FileName);
				dtWriteTime.Value = WriteTime;
				
			}
			catch (UnauthorizedAccessException)
			{
				MessageBox.Show($"Отсутствует необходимое разрешение на доступ к файлу {FileName}.", "Ошибка");
				Application.Exit();
			}
			catch (Exception ex)
			{

				MessageBox.Show($"Открытия файла {FileName} вызвало исключение {ex.Message}.", "Ошибка");
				Application.Exit();
			}
			

		}


		private void Hidden_CheckStateChanged(object sender, EventArgs e)
		{
			if ((sender as CheckBox).Checked)
			{
				if (MessageBox.Show("Если вы установите этот атрибут, то сделаете файл невидимым для большинства программ. Всё равно установить?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.No)
				{
					(sender as CheckBox).Checked = false;
				}
			}
		}

		private void btnShowFileProperties_Click(object sender, EventArgs e)
		{
			ShowFileProperties(FileName);
			MessageBox.Show("Чтобы удалить дополнительные свойства (например EXIF) в появившемся далее окне нужно выбрать вкладку \"Подробно\"->\"Удаление свойств и личной информации\"->\"Удалить следующие свойства для этого файла\"-> кнопка \"Выделить всё\"->OK");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (edFileName.Text != Path.GetFileNameWithoutExtension(FileName))
			{
				if (MessageBox.Show("Имя файла изменено. Вы уверены, что хотите переименовать файл?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					string ext = Path.GetExtension(FileName);
					string NewFileName = Path.Combine(edFilePath.Text, edFileName.Text + ext);
					try
					{
						File.Move(FileName, NewFileName);
						FileName = NewFileName;
					}
					catch (Exception ex)
					{
						MessageBox.Show($"Переименование файла {FileName} \n\rв {NewFileName} вызвало исключение: {ex.Message}.", "Ошибка");
						Application.Exit();
					}
				} else
				{
					edFileName.Text = Path.GetFileNameWithoutExtension(FileName);
				}
			}
			try
			{
				FileAttributes FileAttribute = 0;
				File.SetAttributes(FileName, FileAttribute);//Устанавливаем пустые атрибуты, чтобы изменить дату и время при необходимости
				if (dtCreationTime.Value != CreationTime)
					File.SetCreationTime(FileName, dtCreationTime.Value);
				if (dtLastAccessTime.Value != LastAccessTime)
					File.SetLastAccessTime(FileName, dtLastAccessTime.Value);
				if (dtWriteTime.Value != WriteTime)
					File.SetLastWriteTime(FileName, dtWriteTime.Value);

				if (cbArchive.Checked) FileAttribute = FileAttribute | FileAttributes.Archive;
				if (cbReadOnly.Checked) FileAttribute = FileAttribute | FileAttributes.ReadOnly;
				if (cbHidden.Checked) FileAttribute = FileAttribute | FileAttributes.Hidden;
				if (cbSystem.Checked) FileAttribute = FileAttribute | FileAttributes.System;
				File.SetAttributes(FileName, FileAttribute);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Изменение атрибутов файла {FileName} в вызвало исключение: {ex.Message}.", "Ошибка");
				Application.Exit();
			}

			if ((sender as Button).Name == "button3") Application.Exit();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			dtLastAccessTime.Value = dtWriteTime.Value = dtCreationTime.Value;
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(@"https://github.com/tsyganovd/FileAttributeEditor/blob/master/LICENSE");
		}
	}
}

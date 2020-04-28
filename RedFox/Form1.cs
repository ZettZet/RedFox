using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RedFox {
	public partial class Form1 : Form {
		private bool isNeedSave = false;
		private string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\NewFile.txt";
		private int caretPosition;

		public Form1() {
			InitializeComponent();
			Fonts.DataSource = FontFamily.Families;
			Fonts.DisplayMember = "Name";
			Fonts.SelectedIndex = 0;
			text.Font = new Font((FontFamily)Fonts.SelectedValue, (float)Convert.ToDouble(FontsSize.Value.ToString()), FontStyle.Regular);
			FontsSize.Increment = 0.1m;
			lines.Minimum = 0;
		}
		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			if(isNeedSave == true) {
				DialogResult result = MessageBox.Show("Сохранить изменения?", "Сохранить?", MessageBoxButtons.YesNoCancel);
				if(result == DialogResult.Yes) {
					if(!string.IsNullOrEmpty(path)) {
						FileLogic.Save(ref text, ref isNeedSave, ref path);
					}
					else {
						FileLogic.SaveAs(ref text, ref isNeedSave, ref path);
					}
					Application.Exit();
				}
				else if(result == DialogResult.No) {
					isNeedSave = false;
					Application.Exit();
				}
				else if(result == DialogResult.Cancel) {
					e.Cancel = true;
				}
			}
		}
		public void StatusAnalize() {
			Regex regex1 = new Regex(@"[\t\n\r\ ]");
			Regex regex2 = new Regex(@"\w+\b");
			string textref = text.Text;
			linesCount.Text = text.Lines.Count().ToString();
			wordCount.Text = regex2.Matches(textref).Count.ToString();
			letterUnspaced.Text = regex1.Replace(textref, "").Length.ToString();
			lettersSpaced.Text = textref.Length.ToString();
			caretCurrentPosition.Text = text.SelectionStart.ToString();
		}
		private void text_TextChanged(object sender, EventArgs e) {
			isNeedSave = true;
			StatusAnalize();
			lines.Maximum = text.Lines.Count();
		}

		#region Меню Файл
		private void создатьToolStripMenuItem_Click(object sender, EventArgs e) {
			if(isNeedSave == true) {
				DialogResult message = MessageBox.Show("Сохранить изменения?", "Создание документа", MessageBoxButtons.YesNoCancel);
				if(message == DialogResult.Yes) {
					if(string.IsNullOrEmpty(path)) {
						FileLogic.Save(ref text, ref isNeedSave, ref path);
					}
					else {
						FileLogic.SaveAs(ref text, ref isNeedSave, ref path);
					}
					FileLogic.Create(ref text, ref isNeedSave, ref path);
				}
				else if(message == DialogResult.No) {
					FileLogic.Create(ref text, ref isNeedSave, ref path);
				}
			}
			else {
				FileLogic.Create(ref text, ref isNeedSave, ref path);
			}
		}
		private void открытьToolStripMenuItem_Click(object sender, EventArgs e) {
			if(isNeedSave == true) {
				DialogResult message = MessageBox.Show("Сохранить изменения?", "Создание документа", MessageBoxButtons.YesNoCancel);
				if(message == DialogResult.Yes) {
					if(string.IsNullOrEmpty(path)) {
						FileLogic.Save(ref text, ref isNeedSave, ref path);
					}
					else {
						FileLogic.SaveAs(ref text, ref isNeedSave, ref path);
					}
					FileLogic.Open(ref text, ref isNeedSave, ref path);
				}
				else if(message == DialogResult.No) {
					FileLogic.Open(ref text, ref isNeedSave, ref path);
				}
				else
					return;
			}
			else {
				FileLogic.Open(ref text, ref isNeedSave, ref path);
			}
		}
		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e) {
			if(string.IsNullOrEmpty(path)) {
				FileLogic.Save(ref text, ref isNeedSave, ref path);
			}
			else {
				FileLogic.SaveAs(ref text, ref isNeedSave, ref path);
			}
		}
		private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e) {
			FileLogic.SaveAs(ref text, ref isNeedSave, ref path);
		}
		private void новоеОкноToolStripMenuItem_Click(object sender, EventArgs e) {
			Form1 form1 = new Form1();
			form1.Show();
		}
		private void выходToolStripMenuItem_Click(object sender, EventArgs e) => Form1_FormClosing(sender, new FormClosingEventArgs(CloseReason.UserClosing, false));
		#endregion

		#region Меню Правка
		private void отменитьToolStripMenuItem_Click(object sender, EventArgs e) => Cancel_Click(sender, e);

		private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e) => Cut_Click(sender, e);

		private void копироватьToolStripMenuItem_Click(object sender, EventArgs e) => Copy_Click(sender, e);

		private void вставитьToolStripMenuItem_Click(object sender, EventArgs e) => Paste_Click(sender, e);

		private void найтиToolStripMenuItem_Click(object sender, EventArgs e) {
			if(text.SelectedText.Length > 0) {
				toSearch.Text = text.SelectedText;
				StartSeacrh_Click(sender, e);
			}
		}
		private void перейтиToolStripMenuItem_Click(object sender, EventArgs e) => goTo.Focus();
		#endregion

		#region Меню Формат
		private void шрифтToolStripMenuItem_Click(object sender, EventArgs e) {
			fontDialog1.Font = text.Font;
			DialogResult = fontDialog1.ShowDialog();
			if(DialogResult == DialogResult.OK) {
				text.Font = text.Font;
			}
		}
		#endregion

		#region Блок шрифтов
		private void Fonts_SelectedIndexChanged(object sender, EventArgs e) {
			text.SelectionFont = new Font((FontFamily)Fonts.SelectedValue, text.Font.Size, text.Font.Style);
			text.Focus();
		}
		private void FontsSize_ValueChanged(object sender, EventArgs e) {
			text.SelectionFont = new Font((FontFamily)Fonts.SelectedValue, (float)Convert.ToDouble(FontsSize.Value.ToString()), text.Font.Style);
			text.Focus();
		}
		private void isBold_CheckedChanged(object sender, EventArgs e) {
			text.SelectionFont = new Font(text.Font, text.SelectionFont.Style ^ FontStyle.Bold);
			text.Focus();
		}
		private void isItalic_CheckedChanged(object sender, EventArgs e) {
			text.SelectionFont = new Font(text.Font, text.SelectionFont.Style ^ FontStyle.Italic);
			text.Focus();
		}
		private void isUnderline_CheckedChanged(object sender, EventArgs e) {
			text.SelectionFont = new Font(text.Font, text.SelectionFont.Style ^ FontStyle.Underline);
			text.Focus();
		}
		#endregion

		#region Блок редактирования
		private void Copy_Click(object sender, EventArgs e) => text.Copy();
		private void Paste_Click(object sender, EventArgs e) => text.Paste();
		private void Cut_Click(object sender, EventArgs e) => text.Cut();
		private void Cancel_Click(object sender, EventArgs e) => text.Undo();
		private void SelectAll_Click(object sender, EventArgs e) => text.SelectAll();
		private void Search_Click(object sender, EventArgs e) {
			if(text.SelectedText.Length > 0) {
				toSearch.Text = text.SelectedText;
				StartSeacrh_Click(sender, e);
			}
		}
		#endregion

		#region Блок поиска и замены
		private void StartSeacrh_Click(object sender, EventArgs e) {
			caretPosition = text.SelectionStart + toSearch.TextLength;
			TextLogic.Find(ref text, toSearch.Text, ref caretPosition, isCaseSensetive.Checked, isFromStart.Checked);
		}
		private void isFromStart_CheckedChanged(object sender, EventArgs e) => isFromStart.BackgroundImage = isFromStart.Checked ? Icons.direct_order : Icons.reverse_order;
		private void isCaseSensetive_CheckedChanged(object sender, EventArgs e) => isCaseSensetive.BackgroundImage = isCaseSensetive.Checked ? Icons.case_sensetive_true : Icons.case_sensetive_false;
		private void StartReplace_Click(object sender, EventArgs e) {
			caretPosition = text.SelectionStart + toReplace.TextLength;
			TextLogic.Replace(ref text, toSearch.Text, toReplace.Text, ref caretPosition, isCaseSensetive.Checked, isFromStart.Checked);
		}
		private void ReplaceAll_Click(object sender, EventArgs e) {
			caretPosition = text.SelectionStart;
			TextLogic.ReplaceAll(ref text, toSearch.Text, toReplace.Text, isCaseSensetive.Checked, isFromStart.Checked);
		}
		#endregion

		#region Блок перейти к строчке
		private void goTo_Click(object sender, EventArgs e) {
			int lineNumber = Convert.ToInt32(lines.Value);
			if(lineNumber > 0 && lineNumber <= text.Lines.Count()) {
				text.SelectionStart = text.GetFirstCharIndexFromLine(lineNumber - 1);
				text.ScrollToCaret();
			}
		}
		#endregion
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedFox {
	class FileLogic {
		public static void Create(ref RichTextBox text, ref bool isNeedSave, ref string path) {
			text.Clear();
			path = "";
			isNeedSave = false;
		}

		public static void Open(ref RichTextBox text, ref bool isNeedSave, ref string path) {
			OpenFileDialog openFile = new OpenFileDialog {
				Title = "Открыть текстовый документ",
				Filter = "Текстовые файлы (*.txt) |*.txt| Все файлы (*.*)|*.*"
			};
			if(openFile.ShowDialog() == DialogResult.OK) {
				text.LoadFile(openFile.FileName);
				path = openFile.FileName;
				isNeedSave = false;
			}
		}

		public static void Save(ref RichTextBox text, ref bool isNeedSave, ref string path) {
			text.SaveFile(path);
			isNeedSave = false;
		}

		public static void SaveAs(ref RichTextBox text, ref bool isNeedSave, ref string path) {
			SaveFileDialog saveAsDocument = new SaveFileDialog {
				Title = "Сохранить документ как...",
				FileName = "Текстовый документ",
				Filter = "Текстовые файлы (*.txt) |*.txt| Все файлы (*.*)|*.*"
			};

			if(saveAsDocument.ShowDialog() == DialogResult.OK) {
				FileStream file = new FileStream(saveAsDocument.FileName, FileMode.Create, FileAccess.Write);
				StreamWriter writer = new StreamWriter(file, Encoding.Default);
				writer.Write(text.Rtf);
				writer.Close();
				isNeedSave = false;
				path = saveAsDocument.FileName;
			}
			else {
				isNeedSave = true;
				return;
			}
		}
	}
}

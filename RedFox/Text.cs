using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedFox {
	class TextLogic {
		public static string BeforeCaret { get; set; } = "";
		public static string AfterCaret { get; set; } = "";

		public static int Find(ref RichTextBox text, string toFind, ref int position, bool isCaseSensetive, bool isDirectOrder) {
			toFind = isCaseSensetive ? toFind : toFind.ToLower();
			string localText = isCaseSensetive ? text.Text : text.Text.ToLower();

			if(localText.Contains(toFind) && localText.Length != 0) {
				BeforeCaret = localText.Substring(0, position);
				AfterCaret = localText.Substring(position);

				int resultPosition = isDirectOrder ? AfterCaret.IndexOf(toFind) : BeforeCaret.LastIndexOf(toFind);

				if(resultPosition != -1 && isDirectOrder)
					resultPosition += BeforeCaret.Length;

				if(resultPosition != -1) {
					text.Select(resultPosition, toFind.Length);
					text.ScrollToCaret();
					text.Focus();
					position = toFind.Length + resultPosition;
				}
				else if(resultPosition == -1 && toFind.Length != 0) {
					position = isDirectOrder ? 0 : text.Text.Length;
					return Find(ref text, toFind, ref position, isCaseSensetive, isDirectOrder);
				}
			}
			else {
				MessageBox.Show("Совпадений не найдено", "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			return 0;
		}
		
		public static int Replace(ref RichTextBox text, string oldText, string newText, ref int position, bool isCaseSensetive, bool isDirectOrder) {
			oldText = isCaseSensetive ? oldText : oldText.ToLower();
			string localText = isCaseSensetive ? text.Text : text.Text.ToLower();

			if(localText.Contains(oldText)) {
				if(text.SelectedText == "" || text.SelectedText != oldText) {
					BeforeCaret = localText.Substring(0, position);
					AfterCaret = localText.Substring(position + 1);

					int resultPosition = isDirectOrder ? AfterCaret.IndexOf(oldText) : BeforeCaret.LastIndexOf(oldText);

					if(resultPosition != -1 && isDirectOrder)
						resultPosition += BeforeCaret.Length;

					if(resultPosition != -1) {
						text.Select(resultPosition, oldText.Length);
						text.ScrollToCaret();
						text.Focus();
						position += oldText.Length + resultPosition;
					}
					else if(resultPosition == -1 && position != 0) {
						position = 0;
						return Replace(ref text, oldText, newText, ref position, isCaseSensetive, isDirectOrder);
					}
				}
				else if(text.SelectedText == oldText) {
					text.SelectedText = newText;
				}
			}
			else {
				position = isDirectOrder ? 0 : text.Text.Length;
				MessageBox.Show("Совпадений не найдено", "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			return 0;
		}

		public static int ReplaceAll(ref RichTextBox text, string oldText, string newText, bool isCaseSensetive, bool isDirectOrder) {
			oldText = isCaseSensetive ? oldText : oldText.ToLower();
			string localText = isCaseSensetive ? text.Text : text.Text.ToLower();

			if(localText.Contains(oldText)) {
				int startPosition = localText.IndexOf(oldText);
				text.Select(startPosition, oldText.Length);
				text.SelectedText = newText;
				return ReplaceAll(ref text, oldText, newText, isCaseSensetive, isDirectOrder);
			}
			else {
				MessageBox.Show("Замены произведены успешно.", "Заменить всё", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			return 0;
		}
	}
}

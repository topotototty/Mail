using PiskaPerepiska.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows;
using EmailApp.MVVM.ViewModel.Helpers;
using MailKit;
using System.Collections.ObjectModel;

namespace EmailApp.MVVM.ViewModel
{
    internal class MainPageVM : BindingsHelper
    {
        #region Свойства

        public RichTextBox richTextBox { get; set; }

        private bool _isBold;
        public bool IsBold
        {
            get { return _isBold; }
            set
            {
                if (_isBold != value)
                {
                    _isBold = value;
                    OnPropertyChanged(nameof(IsBold));
                }
            }
        }

        private bool _isItalic;
        public bool IsItalic
        {
            get { return _isItalic; }
            set
            {
                if (_isItalic != value)
                {
                    _isItalic = value;
                    OnPropertyChanged(nameof(IsItalic));
                }
            }
        }

        private bool _isUnderline;
        public bool IsUnderline
        {
            get { return _isUnderline; }
            set
            {
                if (_isUnderline != value)
                {
                    _isUnderline = value;
                    OnPropertyChanged(nameof(IsUnderline));
                }
            }
        }

        public IList<IMailFolder> Folders { get; set; }

        #endregion

        public BindableCommand BoldCommand { get; set; }
        public BindableCommand ItalicCommand { get; set; }
        public BindableCommand UnderlineCommand { get; set; }
        public BindableCommand LeftAlignCommand { get; set; }
        public BindableCommand CenterAlignCommand { get; set; }
        public BindableCommand RightAlignCommand { get; set; }
        public BindableCommand IncreaseFontSizeCommand { get; set; }
        public BindableCommand DecreaseFontSizeCommand { get; set; }



        public MainPageVM()
        {
            BoldCommand = new BindableCommand(_ => { SetBold(IsBold); });
            ItalicCommand = new BindableCommand(_ => { SetItalic(IsItalic); });
            UnderlineCommand = new BindableCommand(_ => { SetUnderline(IsUnderline); });
            LeftAlignCommand = new BindableCommand(_ => LeftAlign());
            CenterAlignCommand = new BindableCommand(_ => CenterAlign());
            RightAlignCommand = new BindableCommand(_ => RightAlign());
            IncreaseFontSizeCommand = new BindableCommand(_ => IncreaseFontSize());
            DecreaseFontSizeCommand = new BindableCommand(_ => DecreaseFontSize());
            Folders = ImapHelper.GetFolders();
        }

        private void SetBold(bool isBold)
        {
            TextSelection selection = richTextBox.Selection;
            if (!selection.IsEmpty)
            {
                selection.ApplyPropertyValue(TextElement.FontWeightProperty, isBold ? FontWeights.Bold : FontWeights.Normal);
            }
        }

        private void SetItalic(bool isItalic)
        {
            TextSelection selection = richTextBox.Selection;
            if (!selection.IsEmpty)
            {
                selection.ApplyPropertyValue(TextElement.FontStyleProperty, isItalic ? FontStyles.Italic : FontStyles.Normal);
            }
        }

        private void SetUnderline(bool isUnderline)
        {
            TextSelection selection = richTextBox.Selection;
            if (!selection.IsEmpty)
            {
                selection.ApplyPropertyValue(Inline.TextDecorationsProperty, isUnderline ? TextDecorations.Underline : null);
            }
        }

        private void LeftAlign()
        {
            TextSelection selection = richTextBox.Selection;
            if (!selection.IsEmpty)
            {
                selection.ApplyPropertyValue(Paragraph.TextAlignmentProperty, TextAlignment.Left);
            }
        }

        private void CenterAlign()
        {
            TextSelection selection = richTextBox.Selection;
            if (!selection.IsEmpty)
            {
                selection.ApplyPropertyValue(Paragraph.TextAlignmentProperty, TextAlignment.Center);
            }
        }

        private void RightAlign()
        {
            TextSelection selection = richTextBox.Selection;
            if (!selection.IsEmpty)
            {
                selection.ApplyPropertyValue(Paragraph.TextAlignmentProperty, TextAlignment.Right);
            }
        }

        private void IncreaseFontSize()
        {
            if (richTextBox.Selection.IsEmpty)
            {
                richTextBox.FontSize += 1;
            }
            else
            {
                TextRange selectionTextRange = new TextRange(richTextBox.Selection.Start, richTextBox.Selection.End);
                selectionTextRange.ApplyPropertyValue(TextElement.FontSizeProperty, richTextBox.FontSize + 2);
            }
        }

        private void DecreaseFontSize()
        {
            try
            {
                if (richTextBox.Selection.IsEmpty)
                {
                    richTextBox.FontSize -= 1;
                }
                else
                {
                    TextRange selectionTextRange = new TextRange(richTextBox.Selection.Start, richTextBox.Selection.End);
                    selectionTextRange.ApplyPropertyValue(TextElement.FontSizeProperty, richTextBox.FontSize - 1);
                }
            }
            catch { }
        }

    }
}

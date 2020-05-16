using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator
{
    public class ArticleDialogBox
    {
        private ListBox articleListBox = new ListBox();
        private TextBox titleTextBox = new TextBox();
        private Button saveButton = new Button();

        public ArticleDialogBox()
        {
            //articleListBox.AddEventHandler(this.ArticleSelected);
        }


        public void SimulateUserInteraction()
        {
            articleListBox.SetSelection("Article 1");
            titleTextBox.SetContent("");
            titleTextBox.SetContent("Article 2");
            Console.WriteLine("Textbox: " + titleTextBox.GetContent());
            Console.WriteLine("Button: " + saveButton.IsEnabled());
        }

        private void TitleChanged()
        {
            var content = titleTextBox.GetContent();
            var IsEmpty = string.IsNullOrEmpty(content);
            saveButton.SetEnabled(!IsEmpty);
        }

        private void ArticleSelected()
        {
            titleTextBox.SetContent(articleListBox.GetSelection());
            saveButton.SetEnabled(true);
        }
    }
}

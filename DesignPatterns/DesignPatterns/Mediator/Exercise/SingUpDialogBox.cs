using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator.Exercise
{
    public class SingUpDialogBox
    {
        private TextBox usernameTextBox = new TextBox();
        private TextBox passwordTextBox = new TextBox();
        private CheckBox agreeToTermsCheckBox = new CheckBox();
        private Button signUpButton = new Button();

        public SingUpDialogBox()
        {
            //this.usernameTextBox.AddEventHandler();
        }

        private void ControlChanged()
        {
            this.signUpButton.SetEnabled(this.IsFormValid());
        }

        private bool IsFormValid()
        {
            return !this.usernameTextBox.IsEmpty() && !this.passwordTextBox.IsEmpty() && !this.agreeToTermsCheckBox.IsChecked();
        }

        public void SimulateUserInteraction()
        {
            Console.WriteLine("Initially: " + this.signUpButton.IsEnabled());
            this.usernameTextBox.SetContent("username");
            Console.WriteLine("After setting the username: " + this.signUpButton.IsEnabled());
            this.passwordTextBox.SetContent("password");
            Console.WriteLine("After setting the password: " + this.signUpButton.IsEnabled());
            this.agreeToTermsCheckBox.SetCheked(true);
            Console.WriteLine("After agreeing to terms: " + this.signUpButton.IsEnabled());
            this.passwordTextBox.SetContent("");
            Console.WriteLine("After removing the password: " + this.signUpButton.IsEnabled());
            this.passwordTextBox.SetContent("password");
            Console.WriteLine("After re-setting the password: " + this.signUpButton.IsEnabled());
        }
    }
}

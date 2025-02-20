using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace calculator
{
    [ToolboxItem(true)]
    [Designer(typeof(ControlDesigner))]
    internal class NumButton:Button 
    {
         // Делаем переменную num свойством
        [Browsable(true)] // Отображать в свойствах
        [Category("Appearance")] // Категория в свойствах
        [Description("Число, связанное с кнопкой")] // Описание свойства
        public string Num
        {
            get { return num; }
            set { num = value; }
        }

        private string num;

        public NumButton() : base()
        {
            this.num = null;
        }

        public NumButton(string num) : base()
        {
            this.num = num;
        }

        public void AddNum(TextBox textBox)
        {
            textBox.Text += num;
        }
    }
}

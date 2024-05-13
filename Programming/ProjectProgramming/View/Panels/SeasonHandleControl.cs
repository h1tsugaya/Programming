using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectProgramming.View.Panels
{
    
    public partial class SeasonHandleControl : UserControl
    {
        public event EventHandler<SeasonChangedEventArgs> SeasonChanged;
        public SeasonHandleControl()
        {
            InitializeComponent();
            object[] values = Enum.GetValues(typeof(Seasons)).Cast<object>().ToArray();
            SeasonComboBox.Items.AddRange(values);
        }
        private void SeasonButton_Click(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem == null)
            {
                MessageBox.Show("Значение не выбрано!");
            }
            SeasonComboBox.BackColor = System.Drawing.Color.White;
            switch (SeasonComboBox.SelectedItem)
            {
                case Seasons.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Seasons.Autumn:
                    SeasonChanged.Invoke(this, new SeasonChangedEventArgs(Seasons.Autumn));
                    break;
                case Seasons.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Seasons.Spring:
                    SeasonChanged.Invoke(this, new SeasonChangedEventArgs(Seasons.Spring));
                    break;
            }
        }
    }
    public class SeasonChangedEventArgs : EventArgs
    {
        public Seasons Season { get; }

        public SeasonChangedEventArgs(Seasons season)
        {
            Season = season;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GroupListElemtsLesson
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			List<Item> items = new List<Item>
			{
				new Item
				{
					Id=1,
					Name="Хлеб",
					Price=150
				},
				new Item
				{
					Id=2,
					Name="Чай",
					Price=50
				},
				new Item
				{
					Id=3,
					Name="Печенье",
					Price=260
				},
				new Item
				{
					Id=4,
					Name="Кофе",
					Price=80
				},
			};

			//foreach (var item in items)
			//{
			//	listBox.Items.Add(item);
			//}

			listBox.ItemsSource = items;
		}

		private void ListBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			MessageBox.Show($"Выбранный индекс - {listBox.SelectedIndex}");
		}
	}
}

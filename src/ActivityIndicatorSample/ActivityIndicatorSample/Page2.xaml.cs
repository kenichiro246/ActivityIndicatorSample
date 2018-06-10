using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ActivityIndicatorSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
        ObservableCollection<ListViewItem> _list = new ObservableCollection<ListViewItem>();
        private int n = 0;
        private int _CellAmount = 10;

		public Page2 ()
		{
			InitializeComponent ();

            ListView1.ItemsSource = _list;
            ListView1.ItemAppearing += (async (s, e) => {
                frameLayer.IsVisible = true;
                if (_list.Last() == e.Item as ListViewItem)
                {
                    n++;
                    AddListItem(_CellAmount * n);
                }
                await Task.Delay(3000);
                frameLayer.IsVisible = false;
            });
            AddListItem(_CellAmount * n);
        }

        private void AddListItem(int i)
        {
            foreach(var j in Enumerable.Range(i, _CellAmount))
            {
                _list.Add(new ListViewItem { Name = $"Data{j}", Text = $"sample {j}" });
            }
        }

        public class ListViewItem
        {
            public string Name { get; set; }
            public string Text { get; set; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace RadioList_v._1._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal List<Station> databaseStations { get; private set; }

        GridViewColumnHeader _lastHeaderClicked = null;
        ListSortDirection _lastDirection = ListSortDirection.Ascending;

        MediaPlayer mediaPlayer = new MediaPlayer();
        string stream;

        public MainWindow()
        {
            InitializeComponent();
            readDataFromList();
        }

        private void gridViewColumnHeaderClickedHandler(object sender, RoutedEventArgs e)
        {
            var headerClicked = e.OriginalSource as GridViewColumnHeader;
            ListSortDirection direction;

            if (headerClicked != null)
            {
                if (headerClicked.Role != GridViewColumnHeaderRole.Padding)
                {
                    if (headerClicked != _lastHeaderClicked)
                    {
                        direction = ListSortDirection.Ascending;
                    }
                    else
                    {
                        if (_lastDirection == ListSortDirection.Ascending)
                        {
                            direction = ListSortDirection.Descending;
                        }
                        else
                        {
                            direction = ListSortDirection.Ascending;
                        }
                    }

                    var columnBinding = headerClicked.Column.DisplayMemberBinding as Binding;
                    var sortBy = columnBinding?.Path.Path ?? headerClicked.Column.Header as string;

                    sort(sortBy, direction);

                    if (direction == ListSortDirection.Ascending)
                    {
                        headerClicked.Column.HeaderTemplate =
                          Resources["HeaderTemplateArrowUp"] as DataTemplate;
                    }
                    else
                    {
                        headerClicked.Column.HeaderTemplate =
                          Resources["HeaderTemplateArrowDown"] as DataTemplate;
                    }

                    // Remove arrow from previously sorted header
                    if (_lastHeaderClicked != null && _lastHeaderClicked != headerClicked)
                    {
                        _lastHeaderClicked.Column.HeaderTemplate = null;
                    }

                    _lastHeaderClicked = headerClicked;
                    _lastDirection = direction;
                }
            }
        }
        private void sort(string sortBy, ListSortDirection direction)
        {
            ICollectionView dataView = CollectionViewSource.GetDefaultView(stationListView.ItemsSource);

            dataView.SortDescriptions.Clear();
            SortDescription sd = new SortDescription(sortBy, direction);
            dataView.SortDescriptions.Add(sd);
            dataView.Refresh();
        }

        private void addDataToList()
        {
            using (DataContext context = new DataContext())
            {
                var name = stationNameTextBox.Text;
                var description = stationDescriptionTextBox.Text;
                var country = stationCountryTextBox.Text;
                var url = stationUrlTextBox.Text;

                if (name != "" && country != "" && url != "")
                {
                    context.Stations.Add(new Station() { Name = name, Description = description, Country = country, Url = url });
                    context.SaveChanges();
                }
            }
            readDataFromList();
        }
        private void deleteDataFromList()
        {
            using (DataContext context = new DataContext())
            {

                Station selectedStation = stationListView.SelectedItem as Station;

                if (stationNameTextBox.Text != "" && stationCountryTextBox.Text != "" && stationUrlTextBox.Text != "")
                {
                    if (true)
                    {
                        if (selectedStation!=null){
                            Station station = context.Stations.Single(x => x.Id == selectedStation.Id);
                            context.Remove(station);
                            context.SaveChanges();
                        }
                    }
                }
            }
            readDataFromList();
        }
        private void readDataFromList()

        {
            using (DataContext context = new DataContext())
            {
                databaseStations = context.Stations.ToList();
                stationListView.ItemsSource = databaseStations;
            }
        }
        private void updateDataFromList()
        {
            using (DataContext context = new DataContext())
            {

                Station selectedStation = stationListView.SelectedItem as Station;
                if (stationNameTextBox.Text != "" && stationDescriptionTextBox.Text != "" && stationCountryTextBox.Text != "" && stationUrlTextBox.Text != "")
                {
                    var name = stationNameTextBox.Text;
                    var description = stationDescriptionTextBox.Text;
                    var country = stationCountryTextBox.Text;
                    var url = stationUrlTextBox.Text;

                    if (name != null && country != null && url != null)
                    {
                        Station station = context.Stations.Find(selectedStation.Id);
                        station.Name = name;
                        station.Description = description;
                        station.Country = country;
                        station.Url = url;

                        context.SaveChanges();
                    }
                }
            }
            readDataFromList();
        }
        private void searchDataFromList()
        {
            using (DataContext context = new DataContext())
            {
                readDataFromList();
                if (nameRadioButton.IsChecked == true)
                {
                    string searchStation = searchTextBox.Text;
                    databaseStations = databaseStations.Where(x => x.Name.Contains(searchStation)).ToList();
                    stationListView.ItemsSource = databaseStations;
                }
                if (countryRadioButton.IsChecked == true)
                {
                    string searchStation = searchTextBox.Text;
                    databaseStations = databaseStations.Where(x => x.Country.Contains(searchStation)).ToList();
                    stationListView.ItemsSource = databaseStations;
                }
                if (descriptionRadioButton.IsChecked == true)
                {
                    string searchStation = searchTextBox.Text;
                    databaseStations = databaseStations.Where(x => x.Description.Contains(searchStation)).ToList();
                    stationListView.ItemsSource = databaseStations;
                }
            }
        }


        private void addDataToListBtn(object sender, RoutedEventArgs e)
        {
            addDataToList();
        }
        private void deleteDataFromListBtn(object sender, RoutedEventArgs e)
        {
            deleteDataFromList();
        }
        private void updateDataFromListBtn(object sender, RoutedEventArgs e)
        {
            updateDataFromList();
        }
        private void refreshBtn(object sender, RoutedEventArgs e)
        {
            readDataFromList();
        }
        private void clearTextBoxesBtn(object sender, RoutedEventArgs e)
        {
            stationNameTextBox.Text = " ";
            stationDescriptionTextBox.Text = " ";
            stationCountryTextBox.Text = " ";
            stationUrlTextBox.Text = " ";
        }

        private void copyUrlBtn(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(stationUrlTextBox.Text);
        }

        private void playStationBtn(object sender, RoutedEventArgs e)
        {
            if (stationUrlTextBox.Text == "")
            {
                readDataFromList();
            }
            else
            {
                stream = stationUrlTextBox.Text;
                mediaPlayer.Open(new Uri(stream));
                mediaPlayer.Play();
            }
        }
        private void stopStationBtn(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }

        private void searchStationFromListBtn(object sender, RoutedEventArgs e)
        {
            searchDataFromList();
        }
        private void searchTextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                searchDataFromList();
            }
        }

    }
}

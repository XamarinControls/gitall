using System.Collections;
using System.Collections.Specialized;
using Xamarin.Forms;
using GitAll.Core.Utils;

namespace GitAll.Forms.Controls
{
    public class BindablePicker : Picker
    {
        public BindablePicker()
        {            
            BackgroundColor = Color.Transparent;
            Margin = new Thickness(8, 0, 8, 0);
            TextColor = Color.Black;
            AlignmentRight = false;
            StartIndexElement = 0;
        }


        #region Fields

        //Bindable property for the items source
        public static readonly BindableProperty ItemsSourceProperty =
            BindableProperty.Create<BindablePicker, IEnumerable>(p => p.ItemsSource, null, propertyChanged: OnItemsSourcePropertyChanged);

        //Bindable property for the selected item
        public static readonly BindableProperty SelectedItemProperty =
            BindableProperty.Create<BindablePicker, object>(p => p.SelectedItem, null, BindingMode.TwoWay, propertyChanged: OnSelectedItemPropertyChanged);

        public static readonly BindableProperty AlignmentRightProperty =
            BindableProperty.Create<BindablePicker, object>(p => p.AlignmentRight, null, BindingMode.TwoWay, propertyChanged: OnAligmentRightPropertyChanged);

        public static readonly BindableProperty StartIndexElementProperty =
            BindableProperty.Create<BindablePicker, object>(p => p.StartIndexElement, null, BindingMode.OneWayToSource, propertyChanged: OnStartIndexElementPropertyChanged);
        
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the items source.
        /// </summary>
        /// <value>
        /// The items source.
        /// </value>
        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        /// <summary>
        /// Gets or sets the selected item.
        /// </summary>
        /// <value>
        /// The selected item.
        /// </value>
        public object SelectedItem
        {
            get { return GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        public object AlignmentRight
        {
            get { return GetValue(AlignmentRightProperty); }
            set { SetValue(AlignmentRightProperty, value); }
        }

        public object StartIndexElement
        {
            get { return GetValue(StartIndexElementProperty); }
            set { SetValue(StartIndexElementProperty, value); }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Called when [items source property changed].
        /// </summary>
        /// <param name="bindable">The bindable.</param>
        /// <param name="value">The value.</param>
        /// <param name="newValue">The new value.</param>
        private static void OnItemsSourcePropertyChanged(BindableObject bindable, IEnumerable value, IEnumerable newValue)
        {
            var picker = (BindablePicker)bindable;
            var notifyCollection = newValue as INotifyCollectionChanged;
            if (notifyCollection != null)
            {
                notifyCollection.CollectionChanged += (sender, args) =>
                {
                    if (args.NewItems != null)
                    {
                        foreach (var newItem in args.NewItems)
                        {
                            picker.Items.Add((newItem ?? "").ToString());
                        }
                    }
                    if (args.OldItems != null)
                    {
                        foreach (var oldItem in args.OldItems)
                        {
                            picker.Items.Remove((oldItem ?? "").ToString());
                        }
                    }
                };
            }

            if (newValue == null)
                return;

            picker.Items.Clear();

            foreach (var item in newValue)
                picker.Items.Add((item ?? "").ToString());

            picker.SelectedIndex = int.Parse(picker.StartIndexElement.ToString());
        }

        /// <summary>
        /// Called when [selected item property changed].
        /// </summary>
        /// <param name="bindable">The bindable.</param>
        /// <param name="value">The value.</param>
        /// <param name="newValue">The new value.</param>
        private static void OnSelectedItemPropertyChanged(BindableObject bindable, object value, object newValue)
        {
            var picker = (BindablePicker)bindable;
            if (picker.ItemsSource != null)
                picker.SelectedIndex = picker.ItemsSource.IndexOf(picker.SelectedItem);            
        }

        private static void OnAligmentRightPropertyChanged(BindableObject bindalble, object value, object newValue)
        {
            //Nothing to do.
        }

        private static void OnStartIndexElementPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            //Nothing to do.
        }

        #endregion
    }
}

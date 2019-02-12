using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

using XF_CSSandBindableL.Models;
using XF_CSSandBindableL.Services;

namespace XF_CSSandBindableL.ViewModels
{
    public class BlogViewModel : INotifyPropertyChanged
    {
        private Publication[] _listPublications;

        public Publication[] ListPublications
        {
            get { return _listPublications; }
            set
            {
                _listPublications = value;
                OnPropertyChanged();
            }
        }

        private Publication _publication = new Publication();

        public Publication Publication
        {
            get { return _publication; }
            set { _publication = value; }
        }

        public BlogViewModel()
        {
            GetService();
        }

        public void GetService()
        {
            var service = new PublicationsService();
            ListPublications = service.GetPublication();
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}

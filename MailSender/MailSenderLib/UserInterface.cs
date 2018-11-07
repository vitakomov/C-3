﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MailSenderLib.Annotations;

namespace MailSenderLib
{
    public class UserInterface : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null) => 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));

        #endregion
    }
}

﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.Generic
{
    public class PlainText
    {
        private string _text;
        public string Text { get { return _text; } }

        public PlainText(string text)
        {
            //Contract.Requires<ArgumentNullException>(text != null, "text");
            //Contract.Requires<ArgumentCannotBeEmptyStringException>(!string.IsNullOrEmpty(text), "text");

            if (text == null)
                throw new ArgumentNullException();
            if (string.IsNullOrEmpty(text))
                throw new ArgumentCannotBeEmptyStringException("text");
            _text = text;
        }

        #region override object
        public override string ToString()
        {
            return Text;
        }

        public override bool Equals(object obj)
        {
            var nume = (PlainText)obj;
            return Text.Equals(nume.Text);
        }

        public override int GetHashCode()
        {
            return Text.GetHashCode();
        }
        #endregion
    }
}

using System;
using System.Drawing;

namespace Tools4Libraries
{

    /// <summary>
    /// This class represents an ComboBox item of the ImagedComboBox which may contains an image and value.
    /// 
    /// </summary>
    [Serializable]
    public class ComboBoxItem
    {
        #region Attribute
        private object _value;
        private Image _image;
        #endregion

        #region Properties
        /// <summary>
        /// ComobBox Item.
        /// </summary>
        public object Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
        /// <summary>
        /// Item image.
        /// </summary>
        public Image Image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
            }
        }
        #endregion

        #region Constructor
        public ComboBoxItem()
        {
            _value = String.Empty;
            _image  = new Bitmap(1,1);
        }
        /// <summary>
        /// Constructor item without image.
        /// </summary>
        /// <param name="value">Item value.</param>
        public ComboBoxItem(object value)
        {
            _value = value;
            _image = new Bitmap(1, 1);
            
        }
        /// <summary>
        ///  Constructor item with image.
        /// </summary>
        /// <param name="value">Item value.</param>
        /// <param name="image">Item image.</param>
        public ComboBoxItem(object value, Image image)
        {
            _value = value;
            _image = image;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return _value.ToString();
        }
        #endregion
    }
}

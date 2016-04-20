using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BOMParser
{
    public class Base
    {
        #region Properties
        /// <summary>
        /// The current status of processing. Fires an event of type "Status Changed"
        /// </summary>
        public string Status
        {
            set
            {
                if(this.StatusChanged != null)
                    this.StatusChanged.Invoke(this, new StatusChangedEventArgs(value));
            }
        }
        #endregion

        #region Delegates
        /// <summary>
        /// Handles the change of the status.
        /// </summary>
        /// <param name="sender">Who created the action.</param>
        /// <param name="e">The arguments of the event, contain the status.</param>
        public delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);
        #endregion

        #region Events
        /// <summary>
        /// The event which fires when the status changes.
        /// </summary>
        public event StatusChangedEventHandler StatusChanged;
        #endregion
    }
}

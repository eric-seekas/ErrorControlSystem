﻿using System;
using System.Windows.Controls;

namespace ErrorControlSystem.Shared.UI.ExceptionMapper
{
    public class TreeMapItem : TreeViewItem
    {
        #region Properties

        public Exception Exception { get; set; }


        public MessageBlock MessageBlock { get; protected set; }

        public StackTraceBlock StackTrace { get; protected set; }

        public TreeMapItem InnerException { get; protected set; }


        #endregion

        public CodeMapEventHandler OnShowCodeMapEventHandler = delegate(object sender, CodeMapEventArgs args) { };

        public TreeMapItem(Exception exp, TreeMapItemMode mode = TreeMapItemMode.Exception)
        {
            IsExpanded = true;
            Exception = exp;

            Header = new HeaderBlock() { Text = mode.ToString() };
            //
            // Create MessageBlock
            MessageBlock = new MessageBlock() { Text = string.Format("{0}: {1}", Exception.GetType(), Exception.Message) };
            Items.Add(MessageBlock);

            //
            // Create StackTrace
            if (exp.StackTrace != null)
            {
                StackTrace = new StackTraceBlock(exp);
                StackTrace.ExceptionStackFrameSelectedChanged += (s, e) => OnShowCodeMapEventHandler(s, e);
                Items.Add(StackTrace);
            }
            //
            // Create InnerException
            if (exp.InnerException != null)
            {
                InnerException = new TreeMapItem(exp.InnerException, TreeMapItemMode.InnerException);
                InnerException.OnShowCodeMapEventHandler += (s, e) => this.OnShowCodeMapEventHandler(s, e);
                Items.Add(InnerException);
            }
        }

    }
}

﻿using System;
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

namespace AMS.CIM.Caojin.SqlReplicationAnalysisTool.Content.ModernFrame
{
    /// <summary>
    /// Interaction logic for ErrorSample.xaml
    /// </summary>
    public partial class ErrorSample : UserControl
    {
        public ErrorSample()
        {
            InitializeComponent();

            // raise exception to create navigation failure
            throw new NotSupportedException();
        }
    }
}
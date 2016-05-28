using RibbonLib.Controls;
using RibbonLib.Controls.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample
{
    public enum RibbonMarkupCommands : uint
    {
        cmdTabMain = 1001,
        cmdGroupCommon = 1002,
        cmdGroupSimple = 1003,
        cmdGroupAdvanced = 1004,
        cmdButtonNew = 1005,
        cmdButtonOpen = 1006,
        cmdButtonSave = 1007,
        cmdButtonDropA = 1008,
        cmdButtonDropB = 1009,
        cmdButtonDropC = 1010,
        cmdButtonSwitchToAdvanced = 1011,
        cmdButtonSwitchToSimple = 1012,
        cmdMenuGroupFile = 10051,
        cmdMenuGroupExit = 10061,
        cmdDropDownButton = 10071,
        cmdButtonExit= 10041,

    }

    public partial class FormMain : Form
    {

        private RibbonTab _tabMain;
        private RibbonGroup _groupCommon;
        private RibbonGroup _groupSimple;
        private RibbonGroup _groupAdvanced;
        private RibbonButton _buttonNew;
        private RibbonButton _buttonOpen;
        private RibbonButton _buttonSave;
        private RibbonButton _buttonDropA;
        private RibbonButton _buttonDropB;
        private RibbonButton _buttonDropC;
        private RibbonButton _buttonSwitchToAdvanced;
        private RibbonButton _buttonSwitchToSimple;

        private RibbonButton _buttonExit;

        public FormMain()
        {

            InitializeComponent();
            _tabMain = new RibbonTab(_ribbon, (uint)RibbonMarkupCommands.cmdTabMain);
            _groupCommon = new RibbonGroup(_ribbon, (uint)RibbonMarkupCommands.cmdGroupCommon);
            _groupSimple = new RibbonGroup(_ribbon, (uint)RibbonMarkupCommands.cmdGroupSimple);
            _groupAdvanced = new RibbonGroup(_ribbon, (uint)RibbonMarkupCommands.cmdGroupAdvanced);
            _buttonNew = new RibbonButton(_ribbon, (uint)RibbonMarkupCommands.cmdButtonNew);
            _buttonOpen = new RibbonButton(_ribbon, (uint)RibbonMarkupCommands.cmdButtonOpen);
            _buttonSave = new RibbonButton(_ribbon, (uint)RibbonMarkupCommands.cmdButtonSave);
            _buttonDropA = new RibbonButton(_ribbon, (uint)RibbonMarkupCommands.cmdButtonDropA);
            _buttonDropB = new RibbonButton(_ribbon, (uint)RibbonMarkupCommands.cmdButtonDropB);
            _buttonDropC = new RibbonButton(_ribbon, (uint)RibbonMarkupCommands.cmdButtonDropC);
            _buttonSwitchToAdvanced = new RibbonButton(_ribbon, (uint)RibbonMarkupCommands.cmdButtonSwitchToAdvanced);
            _buttonSwitchToSimple = new RibbonButton(_ribbon, (uint)RibbonMarkupCommands.cmdButtonSwitchToSimple);

            _buttonExit = new RibbonButton(_ribbon, (uint)RibbonMarkupCommands.cmdButtonExit);

            _buttonSwitchToAdvanced.ExecuteEvent += new EventHandler<ExecuteEventArgs>(_buttonSwitchToAdvanced_ExecuteEvent);
            _buttonSwitchToSimple.ExecuteEvent += new EventHandler<ExecuteEventArgs>(_buttonSwitchToSimple_ExecuteEvent);

            _buttonExit.ExecuteEvent += _buttonExit_ExecuteEvent;
        }

        private void _buttonExit_ExecuteEvent(object sender, ExecuteEventArgs e)
        {
            Environment.Exit(0);
        }

        void _buttonSwitchToAdvanced_ExecuteEvent(object sender, ExecuteEventArgs e)
        {
            _ribbon.SetModes(1);
        }

        void _buttonSwitchToSimple_ExecuteEvent(object sender, ExecuteEventArgs e)
        {
            _ribbon.SetModes(0);
        }

    }
}

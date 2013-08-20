#tag Menu
Begin Menu mmMain
   Begin MenuItem FileMenu
      SpecialMenu = 0
      Text = "文件"
      Index = -2147483648
      AutoEnable = True
      Begin QuitMenuItem FileQuit
         SpecialMenu = 0
         Text = "#App.kFileQuit"
         Index = -2147483648
         ShortcutKey = "#App.kFileQuitShortcut"
         Shortcut = "#App.kFileQuitShortcut"
         AutoEnable = True
      End
   End
   Begin MenuItem EditMenu
      SpecialMenu = 0
      Text = "编辑"
      Index = -2147483648
      AutoEnable = True
      Begin MenuItem EditUndo
         SpecialMenu = 0
         Text = "还原"
         Index = -2147483648
         ShortcutKey = "Z"
         Shortcut = "Cmd+Z"
         MenuModifier = True
         AutoEnable = True
      End
      Begin MenuItem UntitledMenu1
         SpecialMenu = 0
         Text = "-"
         Index = -2147483648
         AutoEnable = True
      End
      Begin MenuItem EditCut
         SpecialMenu = 0
         Text = "剪切"
         Index = -2147483648
         ShortcutKey = "X"
         Shortcut = "Cmd+X"
         MenuModifier = True
         AutoEnable = True
      End
      Begin MenuItem EditCopy
         SpecialMenu = 0
         Text = "拷贝"
         Index = -2147483648
         ShortcutKey = "C"
         Shortcut = "Cmd+C"
         MenuModifier = True
         AutoEnable = True
      End
      Begin MenuItem EditPaste
         SpecialMenu = 0
         Text = "粘贴"
         Index = -2147483648
         ShortcutKey = "V"
         Shortcut = "Cmd+V"
         MenuModifier = True
         AutoEnable = True
      End
      Begin MenuItem EditClear
         SpecialMenu = 0
         Text = "#App.kEditClear"
         Index = -2147483648
         AutoEnable = True
      End
      Begin MenuItem UntitledMenu0
         SpecialMenu = 0
         Text = "-"
         Index = -2147483648
         AutoEnable = True
      End
      Begin MenuItem EditSelectAll
         SpecialMenu = 0
         Text = "全选"
         Index = -2147483648
         ShortcutKey = "A"
         Shortcut = "Cmd+A"
         MenuModifier = True
         AutoEnable = True
      End
      Begin MenuItem UntitledSeparator
         SpecialMenu = 0
         Text = "-"
         Index = -2147483648
         AutoEnable = True
      End
      Begin MenuItem mmClearLog
         SpecialMenu = 0
         Text = "清除log"
         Index = -2147483648
         AutoEnable = True
      End
      Begin MenuItem UntitledSeparator0
         SpecialMenu = 0
         Text = "-"
         Index = -2147483648
         AutoEnable = True
      End
      Begin MenuItem mmClearTest
         SpecialMenu = 0
         Text = "清除联机测试数据"
         Index = -2147483648
         AutoEnable = True
      End
      Begin MenuItem mmSendTest
         SpecialMenu = 0
         Text = "发送联机测试数据"
         Index = -2147483648
         AutoEnable = True
      End
      Begin MenuItem UntitledSeparator1
         SpecialMenu = 0
         Text = "-"
         Index = -2147483648
         AutoEnable = True
      End
      Begin MenuItem mmRefreshSerials
         SpecialMenu = 0
         Text = "刷新串口设备列表"
         Index = -2147483648
         AutoEnable = True
      End
      Begin MenuItem mmOpenSerial
         SpecialMenu = 0
         Text = "打开串口"
         Index = -2147483648
         AutoEnable = True
      End
      Begin MenuItem mmCloseSerial
         SpecialMenu = 0
         Text = "关闭串口"
         Index = -2147483648
         AutoEnable = True
      End
   End
   Begin MenuItem 帮助Menu
      SpecialMenu = 0
      Text = "帮助"
      Index = -2147483648
      AutoEnable = True
      Begin MenuItem 帮助关于
         SpecialMenu = 0
         Text = "关于"
         Index = -2147483648
         AutoEnable = True
      End
      Begin MenuItem 帮助联系作者
         SpecialMenu = 0
         Text = "联系作者"
         Index = -2147483648
         AutoEnable = True
      End
   End
End
#tag EndMenu

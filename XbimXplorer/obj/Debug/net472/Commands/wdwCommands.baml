   M S B A M L   `   `   `  ����  XbimXplorer&     XbimXplorer.Commands.wdwCommands   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   g cXceed.Wpf.AvalonDock.Themes.Aero, Version=2.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4[ WXceed.Wpf.AvalonDock, Version=2.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4i eXceed.Wpf.AvalonDock.Themes.VS2010, Version=2.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4m iXceed.Wpf.AvalonDock.Themes.Expression, Version=2.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4h	 dXceed.Wpf.AvalonDock.Themes.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f4E
avalonDock,http://schemas.xceed.com/wpf/xaml/avalondock     	 5   	   Bd2http://schemas.microsoft.com/expression/blend/2008     	 5
   	   Lmc;http://schemas.openxmlformats.org/markup-compatibility/2006     	 5   	   $	��300��5   	   .��5      � -   5          � RowDefinitions  5   
   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   � $��0��6   .+�5      �� -   5         ��Name$ 
TxtCommand��5      $��Lucida Console)�6*    �� AcceptsReturn .  �� AutoWordSelection . $��
0,0,0,28.2q�6t   �� 5      -   5        $	��Run��5      $��23��6#   $��Bottom=�6/   $
��0, 5q�6J   6X   5      �� 5   
   -   5         ��Name$ TxtOut��5      $��1��6&   $��Lucida Console)�5      ���	#FFFFFFE1" �� VerticalScrollBarVisibility$
 Auto=�5      $ �� HorizontalScrollBarVisibility$
 Auto=�69   ��.  �� 
IsReadOnly .  �� IsDocumentEnabled . 	 � 	Resources	 5#      
 �� 
TargetType �� Property �� Value��%�   'J�       '�� N     �� 5$      "
 J�6   .�5%      ��  �@��Margin$ 0q�6/   5&      �� 5'      "
 ��6   .�5(      -   5        5)      5+      5,      �� 5-   
   $��5��6   $��0��6#   $��Bottom=�60   $��Stretch=�6K   5.      5/      
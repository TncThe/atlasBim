   M S B A M L   `   `   `  ����  XbimXplorer%    XbimXplorer.LogViewer.LogViewer   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -   5        .��5	      �   � RowDefinitions  5
   
   �� 5      $��* �6   6*   �� 5      $
��Auto �6   6-   �� 5      $
��Auto �6   6-   �� 5      $
��Auto �6   6-   �� 5      $
��Auto �6   6-   .+�5   
   �� -   5         ��Name$
 View��5       $��0��6   $��5q�6.   ��69   �� *LoggedEvents+ � 	Resources 5       �� 
TargetType �� Triggers �� Binding �� Value �� Property �� Value	 �� Path��%�  '��       �� 5      " ��6    5      �� 5       6&   �� *Level+	 Debug6@   .a�5      ��  � ��
 �����6;   5      �� 5       6&   �� *Level+ Warning6@   .a�5      ��  � ��
 � ���6;   5      �� 5       6&   �� *Level+	 Error6@   .a�5      ��  � ��
 �  ��6;   5      .�5       ��  �@�ToolTip 60   �� $	 Summary�5!      5"      
 � ContextMenu
 5#      �� 5$      .@�5%      m� -   5        $
��Copy��5%      6-   m� 5&      -   5        $��Clear 'Verbose' entries��5&      6@   m� 5'      -   5        $��Clear 'Debug' entries��5'      6>   m� 5(      -   5        $!��Clear 'Information' entries��5(      6D   m� 5)      -   5        $��Clear 'Warning' entries��5)      6@   5*       �� View 5,      �� 5-      .P�5.      �� $
��Time��6%    �� Width$ 50��63    �� DisplayMemberBinding 6>   �� *	TimeStamp+�� 5/      $��Message��6%   $	 200��66    6B   �� *	Message+�� 50      $��Level��6%   $ 75��64    6?   �� *Level+�� 51      $��Logger��6%   $	 200��65    6A   �� *Logger+�� 52      $��Thread��6%   $ 60��65    6@   �� *
ThreadId+�� 53      $��Error��6%   $	 200��64    6@   �� *ErrorMessage+54      56      �� 57   
   -   5         ��Name$ Report��57      $��1��6    �� TextWrapping$
 Wrap=�6/   $y�	Collapsed=�6C   $�� ��6Z   �� 58   
   -	   5        $��Verbose��58   <   $��Right=�6   $��2��6/    d� 	IsChecked$
 TrueY�6L   .��6]   	Verbose6f   �� 59   
   -
   5        $��3��59      $y�	Collapsed=�6+   $��5q�6B   .��6N   Test6T   �� 5:   
   -   5        $��4��5:      $��5q�6,   .��68   	Clear All6C   5;      5<      
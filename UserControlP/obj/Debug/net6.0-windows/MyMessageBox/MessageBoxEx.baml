   M S B A M L   `   `   `  ����G  CUserControlP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:UserControlP.MyMessageBoxUserControlP.MyMessageBox  5   	   ,    &UserControlP.MyMessageBox.MessageBoxEx   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:UserControlP.MyMessageBox     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   -   5          �Name$
  root��5	   	    � WindowStyle$
 None=�5
   	    � AllowsTransparency$
 True��5   	    � Title$ MessageBoxEx��5   	   $	��450��6   $	��500��6+   ��5      �� 5       �� Opacity$ 0Q�6    �� Color$ White��6"    � 	Resources 5      <   6UserControlP.MyMessageBox.MsgBoxButtonVisibleConverter   visibleConverter  btnTextStyle �� 
TargetType �� Property	 �� Value��%�   &	        &	        5      6)   �� 5      " ��6!   .�5      ��  � ��$	 15(�6#   �� 5       � ��$	 Center=�6.   �� 5       � ��$	 Center=�6,   �� 5       � ��
	 �  ��6%   5      5      '  !System.Windows.Shell.WindowChrome
   WindowChrome
 5        5         ResizeBorderThickness$ 3q�6      GlassFrameThickness$ 1q�5         CaptionHeight$ 70Q�5      .��5!      �  � RowDefinitions 5"      �� 5#      $��70 �6   �� 5$      $��* �6   �� 5%      $��70 �6   .+�5)      ��   color_green#��[ 6    �� CornerRadius$ 	30 30 0 0��67   ._�5*      �  � ColumnDefinitions 5+   
   �� 5,      $
��auto �6   �� 5-      �� 5.      $
��auto �6   .+�50   
   !  FontAwesome.WPF.FontAwesome  $��
20 10 0 10q�51      $��0��52      
�������$��50(�54         Icon$ 
InfoCircle=�55      $��Center=�56      $��Center=�57      $
��auto��6&   $
��auto��63   �� 58   
   -   5         ��Name$ title��58      $��1��59      $
��Left=�5:      $��Center=�5;      $
��30 0q�5<      $��30(�5=      $
��Bold"�5>      
���������5@      �� *Title+5A   	   5B      �� 5E      $��1��6   
�������#��[ 6-   $��1 0 1 0q�6X   ._�5F      � $��40 20 40 20q�6   .+�5G   
   �� -   5         ��Name$ contents��5G      " �� VerticalScrollBarVisibility$
 Auto=�6$    �� AcceptsReturn$
 True��5H       �� TextWrapping$
 Wrap=�5I      $��25(�5J      $
��Bold"�5K       �� 
IsReadOnly$
 True��5L      $��0q�5M       � Cursor$ Arrow��5N      ��5O      �� *	Message+5P      5Q   	   5R      �� 5U      $��2��6   $��0 1 0 0q�6   
�������
�������$ 	0 0 30 30��6_    J� Effect 5V      3  -System.Windows.Media.Effects.DropShadowEffect  5W   
      Opacity$
 0.01Q�6      
BlurRadius$ 5Q�6*   ._�5Z      �� #��[ 6   $��1 0 1 1q�6:   $ 	0 0 30 30��6T   ._�5[   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5\      �� -   5         ��Name$
 btn1��5\        btnStyle_green#��[ 5`      ��5\   !   �� *Button1Text+��5]      �� *Button1Command+��5^      ��  �� ElementName$
 root��y�5_      �� *Button1Text+ �� 	Converter# [  5`      �� 5a      -   5        $
 btn2��5a      #��[ 5f      ��5b      �� *Button2Command+��5c      �� $
 root����5d      �� *Button2Text+y�5e      �� *Button2Text+# [  5f   ;   �� 5g      -   5        $
 btn3��5g      #��[ 5l      ��5h      �� *Button3Command+��5i      �� $
 root����5j      �� *Button3Text+y�5k      �� *Button3Text+# [  5l   ;   5m      5n   	   5o      5p      5q      
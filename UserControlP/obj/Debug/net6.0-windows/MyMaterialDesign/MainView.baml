   M S B A M L   `   `   `  ����G  CUserControlP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:UserControlP.MyMaterialDesignUserControlP.MyMaterialDesign  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   m;clr-namespace:UserControlP.MyMaterialDesign.CustomInkCanvas-UserControlP.MyMaterialDesign.CustomInkCanvas  6?   ,    &UserControlP.MyMaterialDesign.MainView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:UserControlP.MyMaterialDesign     5   	   LmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes     5   	   9system&clr-namespace:System;assembly=mscorlib     5   	   Wcustominkcanvas;clr-namespace:UserControlP.MyMaterialDesign.CustomInkCanvas     6?     � WindowStyle$  
ToolWindow=�5
   	    � WindowState$ 	Maximized=�5   	    � Title$ MainView��5   	   $
��1080��6   $
��1920��6(    � 	Resources 5         TitleHeight  TitleButtonSize �� 
TargetType �� Property  GamjaFlower �� Value  TitleButton��%�  &	        &	      '�� 4     7  &	 �     7  7  �5      50 �6)   X�5      50Q�60   �� 5      " ��6   .�5      ��  � ��8   6%   �� 5       � ��$ 25(�6#   5      �� 5      " ��6    .�5       ��  � ��
 �����6%   �� 5!       � �� 6%   Z� �� 5"       � �� 6&   Z� �� 5#       � ��8   6    �� 5$       � ��8  6!   �� 5%       � ��$ 10q�6"   5&      5'      .��5(      � ���	#FFD6D6D6 � ColumnDefinitions 5)      �� 5*      �� 5+       � RowDefinitions 5.      �� 5/      #��[  6   �� 50      #��[  6   �� 51      $��* �6   .+�55      � $��2��6     MaterialColorBase#��[ 6    56      �� 57   
   $
��auto �6   �� 58   
   .+�5;      �� #��[ 6   5=   	   �� 5>      $��1��6   	 �� Orientation$	 
Horizontal=�6$   $��Right=�6=   .+�5?   
   �� #��[ 6   5A      �� 5B   
   #��[ 6   5D      5E   	   5F      � 5I      $��1��6    5J      �� 5K   
   $
��1.5* �6   �� 5L   
   $��3* �6   .+�5O      �� $��5q�6   $��2��6   
�������
 �� CornerRadius$
 15��6A   $
��auto��6S   $
��auto��6b   �� 5P      $��8q�6   ���	#FFFFAF00$
 15��61    J� Effect 5Q   
   3  -System.Windows.Media.Effects.DropShadowEffect  5R         
BlurRadius$ 5Q�6      Opacity$	 0.2Q�6,   ._�5T   
   � $��0��6   $��5q�6    .+�5U      �  5V      �� 5W      $��30 �6!   �� 5X      .+�5[      �� $
��20 0q�6   $��1��6&   $��진료기록��66   
�������$
��Left=�6U   $��Center=�6p   5\      5]      5^   	   5_      � 5c      $��2��6   $��5q�6   .+�5d      �� $��1q�6   
�������$
 15��66    �� Padding$ 5q�6H    5e   
     5f      $	 0.2Q�6   $ 20Q�6+   ._�5h   
   ?   9UserControlP.MyMaterialDesign.CustomInkCanvas.MyInkCanvas  5j      5l   	   5m      5n      5o      
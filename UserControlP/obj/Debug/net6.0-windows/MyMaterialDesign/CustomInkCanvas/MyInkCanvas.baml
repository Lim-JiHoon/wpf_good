   M S B A M L   `   `   `  ����G  CUserControlP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullm;clr-namespace:UserControlP.MyMaterialDesign.CustomInkCanvas-UserControlP.MyMaterialDesign.CustomInkCanvas  5      ?    9UserControlP.MyMaterialDesign.CustomInkCanvas.MyInkCanvas   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Mlocal;clr-namespace:UserControlP.MyMaterialDesign.CustomInkCanvas     5        � 	Resources  5	       �� 
TargetType �� 	Resources �� Property �� Value��%?  '��       '�� 
    �� 5
      " ��6    5      ���� 5   
   '��       " ��6   .�5      ��  �@��CornerRadius$ 8��6+   5      5   	   .�5      ��  � ��$ 45��6!   �� 5       � ��$ 45��6    �� 5       � ��$	 1 0q�6!   5      �� 5      " ��6   5      5      .��5      � 
������� � RowDefinitions 5      �� 5      �� 5      $��50 �6   .+�5!      �� -   5         ��Name$	 ink��5!      5#      �� 5'      $��1��6   $��0 1 0 0q�6   ���	#FFEAEAEA J� Effect 5(      3  -System.Windows.Media.Effects.DropShadowEffect  5)   
      
BlurRadius$ 5Q�6   	   Opacity$		 0.2Q�6*   ._�5+      �� 
 �� Orientation$
 
Horizontal=�6   .+�5,   
   �� -   5         ��Name$ btnBlack��5,      
���   ���66   �� *ColorCommand+��5-      ��  �� RelativeSource �� *Self+ �� Path$ 
Background��� 5.   
   -   5        $ btnRed��5.      
���  ����62   �� *ColorCommand+��5/      ��  �� *Self+$ 
Background��� 50   
   -   5        $ btnBlue��50      
����  ���64   �� *ColorCommand+��51      ��  �� *Self+$ 
Background��� 52   
   -   5        $ btnGreen��52      
��� � ���66   �� *ColorCommand+��53      ��  �� *Self+$ 
Background��� 55   
   
������$	��Ink��57      $��10 0 2 0q�58      ��56      �� *EditModeCommand+5:      �� 5;   
   $��EraseByPoint��5<      
��������5;      �� *EditModeCommand+5?      �� 5@   
   $��EraseByStroke��5A      
��������5@      �� *EditModeCommand+5D      �� 5E   
   $
��None��5F      
��������5E      �� *EditModeCommand+5I      5J   	   5K      5L      5M      
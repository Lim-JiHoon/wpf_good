   M S B A M L   `   `   `  ����G  CUserControlP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:UserControlP.MyUserControlUserControlP.MyUserControl  5      *    $UserControlP.MyUserControl.ImageItem   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:UserControlP.MyUserControl     5      -   5        $
��root��5        J� RenderTransformOrigin$  0.5,0.5&�5	   7    � 	Resources 5
         Storyboard_Loaded �� 
TargetName �� TargetProperty9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%�  &	        �� 5      .��5      U� $
 root��6&   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6C   .\�5   
     $ 00:00:00��6   $
 -558Q�62   5   	   U� 5      $
 grid��6&   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6C   .\�5   
     $ 00:00:00.3000000��6   $	 560Q�6:   5   	   5      5      z�5      V� 5      .~�5      �� �� 5      �� 5      T� 5      5       � Triggers 5      :� 5       :� RoutedEvent$ Loaded��6   .[�5      �� #��[  6   5      .��5!      � -   5         �Name$
 grid��5!   	   $  0.5,0.5&�6   z�5"      V� 5#      .~�5$   
   �� �� 5%   
   �� 5&   
   T� 5'   
   5(   	   	 � RowDefinitions	 5*      �� 5+      $��40 �6   �� 5,      .+�5/      �� 
 �� CornerRadius$
 	18 18 0 0��6   $��	20 3 20 0q�6&   ��50      �� 51   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/    �� Opacity$ 1Q�6B    �� RelativeTransform 52      V� 53      .~�54      ��  �� CenterY$	 0.5Q�6    �� CenterX$	 0.5Q�6-   �� 55       �� CenterX$	 0.5Q�6    �� CenterY$	 0.5Q�6,   �� 56       �� Angle$ 0Q�6     �� CenterX$	 0.5Q�6*    �� CenterY$	 0.5Q�68   T� 57      58      .��5:      �  � Color$ 	#FF55C100��6    � Offset$ 1Q�6+   � 5;      $ 	#FF1A5A1D��6   $	 0.5Q�6+   � 5<      $ White��6   $ 0Q�6'   5=      ._�5?      �� $��Center=�6   $��Center=�60    �� Orientation$ 
Horizontal=�6K   .+�5A   
   �� $��25(�6B   $
��Bold"�6P   
���������6   ��  �� ElementName$
 root�� �� Path$ Title�6b   5C   	   5D      �� 5F      $��1 0 1 1q�6   
��� � �$��1��6;   
�������$��	20 0 20 3q�6[   $
 	0 0 18 18��6n    �� Padding$ 10q�6�   ._�5G      �� $��Uniform=�6>   ��6   �� $
 root��$ Image�6>   5I      5J      5K      
   M S B A M L   `   `   `  ����G  CUserControlP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:UserControlP.MyLoginUserControlP.MyLogin  5   	   g cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137akOclr-namespace:MahApps.Metro.IconPacks;assembly=MahApps.Metro.IconPacks.MaterialMahApps.Metro.IconPacks 5   	   "    UserControlP.MyLogin.Window1   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:UserControlP.MyLogin     5   	   e	iconpacksOclr-namespace:MahApps.Metro.IconPacks;assembly=MahApps.Metro.IconPacks.Material     5   	   -   5          � AllowsTransparency$
  True��5	   	   
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � Title$ Window1��5   	   $	��480��6   $	��380��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         LoginStackPanel �� 
TargetType �� Property �� Value  LoginInputStyle  ButtonStyle  ButtonStyle_Flat	 �� BasedOn��%�  &	        &	 �     &	 �    7  �� 5      " ��6$   .�5      ��  � ��$	 0 5q�6'   �� 5       � ��$ 30��6'   �� 5       �@��Orientation$ 
Horizontal=�6&   �� 5       � ��$ Center=�6.   5      �� 5      " ��6$   .�5      ��  � ��
 ���� 6%   �� 5       � ��$ 0q�6*   �� 5       � ��$ Center=�6-   �� 5       � ��
 �����6%   �� 5       � ��$ 15(�6#   5       �� 5"      " ��6    8	   .�5#      ��  � ��$ 22(�6#   �� 5$       � ��$ 40��6!   �� 5%       � ��$	 100��6    �� 5&       � ��$ 10q�6!   5'      5(      .��5)      � .+�5*      � 
 � RowDefinitions
 5+      �� 5,   
   �� 5-   
   .+�50      ��  �� CornerRadius$ 10��6   $��2��6!   ��51   
   �� 52      .��53      �  � Color$ SkyBlue��6    � Offset$	 0.2Q�6+   � 54      $ HotPink��6   $	 1.0Q�6+   55      57   	   �� 59      $��Center=�6   .+�5:   
   �� $H��BC:\c#\git\wpf_study\UserControlP\Images\clicksoft_icon_128x128.png��6   $��80��5;      �� 5<   
   $��
Click Soft��6    �� Padding$ 0 10 0 0q�5=      $��Center=�5>      
�������$��24(�5@      5B   	   �� 5D      $��1��6   .+�5E   
   �� -   5        $��stpnlId��5E      #��[  6$   .+�5F      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ Account=�6'   
�������$
��10 0q�5H   '   ��5I   '   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType 
StackPanel �� Path$ ActualHeight��� 5J      -   5        $��txtId��5J      #��[ 6!   $	��123��6J   $	��200��6U   5K      �� 5L   
   $��1��6I   
�������$��0, 0 , 0, 10q�6g   ��6   ��  �� ElementName$ stpnlId��$ ActualWidth�6g   �� 5M   
   -   5        $��stpnlPwd��5M      #��[  6%   .+�5O        $ FormTextboxPassword=�6'   
�������$
��10 0q�5Q   '   ��5R   '   ��  �� $ FindAncestor=� 
StackPanel$ ActualHeight�G� 5S      -   5        $��txtPwd��5S      #��[ 6&    G� Password$	 123��5T      $	��200��6'   5U      �� 5V   
   $��1��6J   
���������6   �� $ stpnlPwd��$ ActualWidth�6U   �� 5X   
   $
��0 20q�6    �� Orientation$ 
Horizontal=�6#   $��Center=�6<   .+�5Y      �� $��Login��6   #��[ 6#   �� 5Z      $
��Exit��6   #��[ 6"   5[      5\   	   5]      5^      5_      
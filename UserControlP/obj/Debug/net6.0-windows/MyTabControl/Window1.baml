   M S B A M L   `   `   `  ����G  CUserControlP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:UserControlP.MyTabControlUserControlP.MyTabControl  5   	   '    !UserControlP.MyTabControl.Window1   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:UserControlP.MyTabControl     5   	   
���  ��  � Title$  Window1��5	   	   $	��450��6   $	��800��6&    � 	Resources 5
       �� 
TargetType �� Property �� Value �� 
TargetType J� SnapsToDevicePixels �� CornerRadius �� Triggers	 P� Property
 P� Value   color_green � RowDefinitions K� IsItemsHost��%�  '��       7   '�� _    7   �� 5      " ��6   .�5      ��  � ��
 ���� 6%   �� 5       � ��
 �����6%   �� 5       � ��
 ���� 6&   �� 5       � ��$ 0q�6*   �� 5       � ��$
 Left=�6.   �� 5       � ��$	 100��6    �� 5       � ��$ 25��6!   �� 5       � ��$ 0 1 5 0q�6!   �� 5       � ��$ 0q�6"   �� 5       � ��$
 Bold"�6%   �� 5       � ��$	 Top=�6,   �� 5       � �� 5   
   �� 5      " ��6   .R�5      � $
 True��6   .+�5      �� $ 4 4 0 0��6   #��z��5      #��z��5      #��z��5      #��z��5      ._�5       �� $��Center=�5!      $��Center=�5"      $
 True��5#      #��z��5$      $��Header��5%      $|�False��5&      5'      5(       5)      P� 5*      	 �@J�IsMouseOver$

 True��6/   . �5+      ��  � �� �	#FFFFE2E25,      �� 5-       � ��
 �����5.      5/      P� 50      	 �@��
IsSelected$

 True��6.   . �51      �� 8    � ��52      �� 53       � ��
 �����54      55      57      59   	   5:      �� 5<      " ��6   .�5=      ��  � ��
 ���� 6%   �� 5>       � ��8   6&   �� 5?       � ��$ 1q�6*   �� 5@       � ��$ 0q�6"   �� 5A       � �� 5B   
   �� 5C      " ��6   .R�5D      � $
 True��6    5E      �� 5F      $��25 �6    �� 5G      $��* �6    .+�5J      �� $��0��6   
������ $
 True��5L      �� 5N      $��1��6   $ 0 0 5 5��5O      #��z��5P      #��z��5Q      #��z��5R      ._�5S      �� $��SelectedContent��6#   $
 True��5T   #   #��z��5U   #   5V      5W      5X      5Z   	   5[      5\      .��5^      � .+�5_      �� .@�5`      �� $��TabItem��6   .��5a   
   � ���	#FFE5E5E5 � ColumnDefinitions 5b      �� 5c      $	��81* �6   �� 5d      $
��713* �6   5f      5g   	   �� 5h      $��TabItem��6   .��5i   
   � ���	#FFE5E5E56   5j   	   5k      5m      5n      
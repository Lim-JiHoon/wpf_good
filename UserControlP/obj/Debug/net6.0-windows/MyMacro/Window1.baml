   M S B A M L   `   `   `  ����G  CUserControlP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:UserControlP.MyMacroUserControlP.MyMacro  5   	   Y1clr-namespace:UserControlP.MyMacro.Views.Contents#UserControlP.MyMacro.Views.Contents  6p   "    UserControlP.MyMacro.Window1   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:UserControlP.MyMacro     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  6:   @contents1clr-namespace:UserControlP.MyMacro.Views.Contents  6p     � Title$  Window1��5   	   $	��450��6   $	��800��6&    � 	Resources 5	         
MouseMacro6   0UserControlP.MyMacro.Views.Contents.MouseControl   
MousePoint  SendKeysMacro9   3UserControlP.MyMacro.Views.Contents.SendKeysControl   Text �� UpdateSourceTrigger+   %UserControlP.MyMacro.TemplateSelector  selector��%�   &	        &	 @     &	 �     �� 5
      .R�5         6   �� *Point+5      �� 5      .R�5         6!   �� *Keys+$ PropertyChanged=�5        5      6   5      .��5      ]� .+�5      ��  �� Padding$ 2q�6   $	��Top=�6   $��30��6.   ._�5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5       $��* �6   �� 5!      $
��auto �6   �� 5"      $
��auto �6   �� 5#      $
��auto �6   �� 5$      $
��auto �6   .+�5&   
   �� $��0��6   $��3q�6!   $��저장��6L   ��6,   �� *SaveCommand+6L   �� 5'   
   $��1��6   $��3q�6!   $��불러오기��6L   ��6,   �� *LoadCommand+6L   �� 5(   
   $��2��6   $��3q�6!   $��Add SendKeys��6P   ��6,   �� *MacroKeyCommand+6P   �� 5)   
   $��3��6   $��3q�6!   $��	Add Mouse��6R   ��6,   �� *MacroMouseCommand+6R   �� 5*   
   $��6��6   $��3q�6#   $��반복��6M   $��Center=�6Z   $��Center=�6u    d� 	IsChecked 6.   �� *
IsRepeat+6u   �� 5+   
   $��7��6   $��3q�6!   $��
시작(F1)��6,   �� 5,   
   $��8��6   $��3q�6!   $��
중지(F2)��6,   5.   	   5/      � 51       52      �� 53   
   $
��auto �6   �� 54   
   .+�57      �� .+�58   
   �� ��6   �� *MacroKeyCommand+.��65   	키입력6<   �� 59   
   ��6   �� *MacroMouseCommand+.��67   	마우스6<   �� 5:   
   ��6   �� *
RunCommand+.��60   Run6=   �� 5;   
   -   5        .��5;   &   	SendKey6/   5<   	   �� 5>      -   5         ��Name$ lb��5>      $��1��6   #��[ 5A      	 �� SelectedIndex	 5?      �� *SelectedIndex+��5@      �� *
MacroBases+
 �� SelectedItem
 5B      �� *SelectedMacroBase+ �� Mode$ OneWayToSource=���5C   
   �� 5D       �� 
TargetType" ��6   .�5E      ��  �� Property � �� �� Value$ Stretch=�6;   5F      *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5H   
   +  %Microsoft.Xaml.Behaviors.EventTrigger  5I         	EventName$ KeyUp��6   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5J      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     PassEventArgsToCommand$
 True��5K   "      Command 5J   $   �� *KeyDownCommand+5K   "   5L      5N   	   5O      5P      5Q      
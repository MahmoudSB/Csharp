   M S B A M L   `   `   `  ����F  BDuvali_Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Duvali_TestDuvali_Test  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       Duvali_Test.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Duvali_Test     5   	   6Sys&clr-namespace:System;assembly=mscorlib     5   	     � Title$  Duvali��5	   	   $��14(�6   $	��600��6&   $	��800��63    � 	Resources 5         MyButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Triggers P� Property	 P� Value��%�  &	        �� 5   
   " ��6&   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � #��z��6   .+�5      �� $ MyContentPresenter��6/   #��z��5   +   $��Center=�5   +   $��Center=�5   +   5      5      5       5      P� 5       � {�	 .  . �5      ��  � �� �	#FFC3F4C363   �� 5       � ��
 �����63   �� 5       � ��
 �   �64   �� 5       � ��$ 1,1,1,1q�68   �� 5        � ��$ 16(�61   �� 5!       � ��$ Medium"�63   5"      P� 5#       � {�	 . . �5$      ��  � ��
 �   �64   �� 5%       � ��$ 1,1,1,1q�68   5&      5(      5)      .��5+      � -   5        
 �Name$
 MainGrid��5+      ���	#FF454545 � RowDefinitions 5-   
   �� 5.      �� 5/      $��30 �6   .+�52   
   �� -   5         ��Name$ MainStackPanel��52      $��0��6-    �� Orientation$ Vertical=�6:   .+�53      �� -   5        $ Header��53      $ 
Horizontal=�6)   $��50��6B   
�������$��0,1,0,1q�6d   .+�54      �� -   5         ��Name$ btnConnectionPage��54      $��
Connection��64   #��[  6I   $	��100��6p   $��42��6|   $��	175,0,0,0q�6�   6�   �� 55      -   5        $ btnMonitorPage��55      $��Monitor��61   #��[  6C   $	��100��6j   $��42��6v   $��10,0,0,0q�6�   6�   �� 56      -   5        $ btnControlPage��56      $��Control��61   #��[  6C   $	��100��6j   $��42��6v   $��10,0,0,0q�6�   6�   �� 57      -   5        $ btnTrendsPage��57      $��Trends��60   #��[  6A   $	��100��6h   $��42��6t   $��10,0,0,0q�6�   6�   58       � 59      -   5          �Name$ 	MainFrame��59      
�������$	��490��6>     � NavigationUIVisibility$ Hidden=�6K   5:      �� 5<   
   $��1��6   .@�5=      �� .��5>      �� $ 
Horizontal=�6   .+�5?      �� $	��IP:��6   �� 5@      -	   5         ��Name$ tbxIP��5@      $��192.168.10.245��6+   5A      5B      �� 5C      �� 5D      .��5E      �� $ 
Horizontal=�6   .+�5F      �� $��Status:��6   �� 5G      -
   5        $ 	tbxStatus��5G      $��Offline��6/   5H      5I      �� 5J      �� 5K      .��5L      �� $ 
Horizontal=�6   .+�5M      A� -   5         A�Name$ StatusEllipse��5M      $��15��65   $��15��6@   
���   �6]   5N      5O      5P      5R      5S      
   M S B A M L   `   `   `  ����F  BGreenOClock, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null=#clr-namespace:GreenOClock.ViewModelGreenOClock.ViewModel  5   K   $    GreenOClock.Views.ActivityView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2vm#clr-namespace:GreenOClock.ViewModel     6K     � 	Resources  5      4   .GreenOClock.ViewModel.ActivityDisplayViewModel   ActivityDisplayVm(  "GreenOClock.ViewModel.TagConverter  TagDisplayConverter��%:   &	        &	        5	   
   6&     5
   
   6   5      .��5      � $
��auto��6   $��Stretch=�6    � DataContext 67   ��  �� Source# [  .+�5   
   � -   5        $��
wrapPanel1��5   "   $
��auto��6   $	��Top=�64   $��Stretch=�6L   .+�5      �� -   5        $��ActivityName��5   �   $��28��6g   $
��Left=�6s   $	��120��6�   ��6   �� *ActivityName+ �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   9� 5      -   5        $��	expander1��5   2   $
��Tags��6   $	��100��6%   $	��114��6C    9� 
IsExpanded .  .��5      � $
��auto��6   $��Stretch=�6%   .+�5      �� -   5         ��Name$ 
ListOfTags��5   N   $��Stretch=�6   $��1,1,0,0q�6=   $��Stretch=�6b    �� SelectionMode$ Multiple=�6~   ��5      �� *ActivitiesTags+$ PropertyChanged=� �� 	Converter# [ 5      5      5      5      5      
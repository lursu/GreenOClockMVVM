   M S B A M L   `   `   `  ����F  BGreenOClock, Version=0.0.0.1, Culture=neutral, PublicKeyToken=null5clr-namespace:GreenOClock.ViewsGreenOClock.Views  5   	       GreenOClock.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   .vsclr-namespace:GreenOClock.Views     5   	     � Title$  Green O'Clock��5   	   $	��600��5   	   $	��700��5   	    � DataContext 5   	   �� *Main+   Locator �� Source# [   � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ Skins/MainSkin.xaml?�6%   %    5      .��5      � -   5         �Name$ 
LayoutRoot��5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   '   !GreenOClock.Views.WindowFrameView  -   5          Name$ ContentArea��5      $	��Top=�62   $��0��5         GreenOClock.Views.NavBar  5   
   -   5        	  Name$	 NavBar��5      $
��auto��6$   $	��400��62   $��Center=�6>   $��2��6[   5      5      
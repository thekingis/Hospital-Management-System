   M S B A M L   `   `   `  ����U  QHospital Management System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Hospital_Management_SystemHospital_Management_System  5   	   ,    &Hospital_Management_System.LoginWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   4local(clr-namespace:Hospital_Management_System  5   	     � Title$(  "Hospital Management System - Login��5	   	    � WindowState$ 	Maximized=�5
   	    � Icon$ icon.ico��5   	   ��5      �� 5   
    �� ImageSource$ images\background.jpg��6   .��5      �� ��. $
��Auto=�5   	   $
��Auto=�5   	   .��5   
   � $��50q�5      $	��400��5      .+�5      �� .+�5      �� 
�������$��10 20q�5       �� CornerRadius$ 5��5      ._�5      �� $��25q�6!   .+�5      �� -   5         ��Name$ HeadText��5      $��	0 40 0 20q�5      $��25(�5      $��DemiBold"�5      $��Center=�5       �� 5!      -   5         ��Name$ Username��5%      $��20q�5"      $��10 20q�5#      $��17(�5$      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Username��5&         
Foreground
 �����.  (MaterialDesignThemes.Wpf.TextFieldAssist	   UnderlineBrush
	 ����� !  MaterialDesignOutlinedTextBox#��[  5)      G� 5*      -   5        
 G�Name$
 Password��5.      $��20q�5+      $��10 20q�5,      $��17(�5-      $ Password��5/      
 �����
	 ����� % !MaterialDesignOutlinedPasswordBox#��[ 52      �� 53      -   5         ��Name$ LoginButton��58      $��20q�54      $��60��55      $��17(�56      
�������$��LOGIN��59      �� 5:      -   5        $ 
BackButton��5?      $��20q�5;      $��60��5<      $��17(�5=      
�������$��Go Back��5@        MaterialDesignFlatButton#��[ 5A      5B      5C      5D      5E      5F      5G      
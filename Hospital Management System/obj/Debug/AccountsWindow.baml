   M S B A M L   `   `   `  ����U  QHospital Management System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Hospital_Management_SystemHospital_Management_System  5   	   /    )Hospital_Management_System.AccountsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   4local(clr-namespace:Hospital_Management_System  5   	     � Title$   Hospital Management System��5	   	    � WindowState$ 	Maximized=�5
   	    � Icon$ icon.ico��5   	   ��5      �� 5   
    �� ImageSource$ images\background.jpg��6   .��5      �� ��. $
��Auto=�5   	   $
��Auto=�5   	   .��5   
   � $��50q�5      .+�5      �� .+�5      �� 
�������$��100 30q�5       �� CornerRadius$ 5��5      ._�5      �� $��25q�5      .+�5      �  � ColumnDefinitions 5      �� 5   "   $��1* �63   �� 5   "   $��1* �63   .+�5       �� $��0��5!   !   .+�5"   "   �� -   5         ��Name$ 	Firstname��5&   %   $��20q�5#   %   $��10 20q�5$   %   $��17(�5%   %   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
First name��5'   %      
Foreground
 �����.  (MaterialDesignThemes.Wpf.TextFieldAssist	   UnderlineBrush
	 ����� !  MaterialDesignOutlinedTextBox#��[  5*   %   �� 5+   "   -   5        $ Lastname��5/   %   $��20q�5,   %   $��10 20q�5-   %   $��17(�5.   %   $ 	Last name��50   %   
 �����
	 �����#��[  53   %   �� 54   "   $��
20 20 20 5q�55   %   $��17(�56   %   $��DemiBold"�57   %   $��Gender��58   %   $
��Left=�59   %   �� 5:   "   
 �� Orientation$
 
Horizontal=�5;   %   $��	20 0 0 20q�5<   %   .+�5=   &   	� -   5         	�Name$ FemaleG��5>   )   $��0 0 30 0q�5?   )    	� 	GroupName$ Gender��5@   )   $��Female��5A   )   5C   '   	� 5D   &   -   5        $ MaleG��5E   )   $ Gender��5F   )   $
��Male��5G   )   5I   '   5J   #   (  "System.Windows.Controls.DatePicker  5K   "   -   5          Name$ DateOfBirth��5O   %   $��20q�5L   %   $��10 20q�5M   %   $��17(�5N   %   $ Date Of Birth��5P   %   
 �����
	 ����� $  MaterialDesignOutlinedDatePicker#��[ 5S   %   �� 5T   "   -   5        $ PhoneNumber��5X   %   $��20q�5U   %   $��10 20q�5V   %   $��17(�5W   %   $ Phone Number��5Z   %   
 �����
	 �����#��[  5]   %   5^      �� 5_      $��1��5`   !   .+�5a   "   �� -   5        $ Email��5e   %   $��20q�5b   %   $��10 20q�5c   %   $��17(�5d   %   $ Email Address��5f   %   
 �����
	 �����#��[  5i   %   �� 5j   "   -   5        $ Address��5n   %   $��20q�5k   %   $��10 20q�5l   %   $��17(�5m   %   $ Resiential Address��5o   %   
 �����
	 �����#��[  5r   %   �� 5s   "   $��
20 20 20 5q�5t   %   $��17(�5u   %   $��DemiBold"�5v   %   $��Marital Status��5w   %   $
��Left=�5x   %   �� 5y   "   $
 
Horizontal=�5z   %   $��	20 0 0 20q�5{   %   .+�5|   &   	� -	   5        $ SingleRB��5}   )   $��0 0 30 0q�5~   )   $ Status��5   )   $��Single��5�   )   5�   '   	� 5�   &   -
   5        $ 	MarriedRB��5�   )   $��0 0 30 0q�5�   )   $ Status��5�   )   $��Married��5�   )   5�   '   	� 5�   &   -   5        $ 
DivorcedRB��5�   )   $��0 0 30 0q�5�   )   $ Status��5�   )   $��Divorced��5�   )   5�   '   	� 5�   &   -   5        $ 	WidowedRB��5�   )   $ Status��5�   )   $��Widowed��5�   )   5�   '   5�   #   � 5�   "   $��20q�5�   %    5�   &   �� 5�   *   $��1* �6;   �� 5�   *   $��1* �6;   .+�5�   &   �� -   5        $
 City��5�   )   $��0��5�   )   $��0 0 0 5q�5�   )   $��10 20q�5�   )   $��17(�5�   )   $
 City��5�   )   
 �����
	 �����#��[  5�   )   �� 5�   &   -   5        $ State��5�   )   $��1��5�   )   $��5 0 0 0q�5�   )   $��10 20q�5�   )   $��17(�5�   )   $ State��5�   )   
 �����
	 �����#��[  5�   )   5�   #   �� 5�   "   -   5         ��Name$ 
SaveButton��5�   %   $��20q�5�   %   $��60��5�   %   $��17(�5�   %   
�������$
��SAVE��5�   %   5�      5�      5�      5�      5�      5�      5�      5�      
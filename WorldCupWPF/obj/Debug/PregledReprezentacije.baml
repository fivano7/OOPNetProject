   M S B A M L   `   `   `  ����F  BWorldCupWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WorldCupWPFWorldCupWPF  5   	   ?$clr-namespace:WorldCupWPF.PropertiesWorldCupWPF.Properties  5   	   '    !WorldCupWPF.PregledReprezentacije   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WorldCupWPF     5   	   5lang$clr-namespace:WorldCupWPF.Properties     5   	   -   5        &    WorldCupWPF.Properties.Resources"    PregledReprezentacijeNaslov � Title# Z  5	   	    � WindowStartupLocation$ CenterScreen=�6^    � Icon$ /Images/ball.ico��6�   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      $	��30* �6   �� 5       � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��50 �6   �� 5      $��1* �6   �� 5      $��25 �6   .+�5   
   o� $��0��5      $��3��5       .@�5"      m� -   5        $   PregledReprezentacijePostavke#��Z 5"      6q   5#      �� 5%   
   2   +PregledReprezentacijeOmiljenaReprezentacija#��Z 5&      $��1��5'      $��1��5(      $	��Top=�5)      � 5+   
   $��2��5,      $��1��5-       5.      �� 5/      �� 50      �� 51      �� 52      �� 53      .+�56      �� -   5         ��Name$ ddlOmiljenaReprezentacija��57      $��4��58      $��25��59      6   �� 5;      -   5        	 ��Name$	 btnOmiljenaInfo��5<      $
��Info��5=      $��5��5>      $��10 0 0 0q�5?      5@      5B      �� 5E   
   %
   PregledReprezentacijeProtivnik#��Z
 5F      $��3��5G      $��1��5H      $	��Top=�5I      � 5K   
   $��4��5L      $��1��5M       5N      �� 5O      �� 5P      �� 5Q      �� 5R      �� 5S      .+�5V      �� -   5        $ ddlProtivnik��5W      $��4��5X      $��25��5Y      6   �� 5\      -   5        $	 btnProtivnikInfo��5]      $
��Info��5^      $��5��5_      $��10 0 0 0q�5`      5a      5c      �� 5f   
   -   5         ��Name$ lblRezultat��5g      $	��?-?��5h      $��30(�5i      $��5��5j      $��1��5k      $��Center=�5l      $��Center=�5m      �� 5o   
   $��7��5p      $��3��5q      $��Bottom=�5r      .@�5s      �� -   5         ��Name$ lblInfo��5s      $�� ��6)   63   5t      � 5w   
   -	   5         �Name$ 	gridTeren��5x      $��6��5y      $��1��5z      ��5|      �� 5}       �� ImageSource$ /Images/teren.png��6   5�      � 5�   
   -
   5        $ 
gridIgraci��5�      $��6��5�      $��1��5�       5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�       5�      �� 5�      �� 5�      �� 5�      �� 5�      �� 5�      5�      5�      5�      
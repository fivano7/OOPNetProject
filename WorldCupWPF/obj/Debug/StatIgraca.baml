   M S B A M L   `   `   `  ����F  BWorldCupWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WorldCupWPFWorldCupWPF  5   	   ?$clr-namespace:WorldCupWPF.PropertiesWorldCupWPF.Properties  5   	       WorldCupWPF.StatIgraca   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WorldCupWPF     5   	   5lang$clr-namespace:WorldCupWPF.Properties     5   	   &    WorldCupWPF.Properties.Resources    StatIgracaNaslov � Title# Z  5	   	   $	��300��6<   $	��520��6I    � WindowStartupLocation$ CenterScreen=�6U    � Icon$ /Images/ball.ico��6z    � Triggers 5      :� 5   
    :� RoutedEvent$ Window.Loaded��6   .[�5      �� .��5      �� .��5      W�  �� 
TargetName$ lblIgrac��6&    �� TargetProperty$ FontSize�5   &    W� From$ 5X�5   &   		 W� To$	 20X�5   &   
 g� Duration$
 0:0:0.3D�5   &    g� AutoReverse .  5   &   5      5      5      .��5      �  � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5       �� 5!      �� 5"      �� 5#       � ColumnDefinitions 5'      �� 5(      �� 5)      �� 5*      .+�5-   
   � $��0��6   $��3��6   
�������.+�5.      �� -   5         ��Name$ lblIgrac��5/      $��0��50      $��Center=�51      $��Center=�52      $��20(�53      $��0q�54      $
��Bold"�55      $��	ImeIgraca��56      58      �� 5:   
   $��0��6   $��2��6!   $��5��6.   $��	20 5 20 5q�6?   $��2q�6R   
���   ���5;      �� 5<       �� ImageSource$ /Images/RandomIgrac.png��6   5?      �� 5B   
   -   5        $ lblBrojIgraca��5C         StatIgracaBroj#��Z 5D      $��1��5E      $��2��5F      $��15(�5G      $
��Bold"�5H      $��Center=�5I      $
��Left=�5J      $��20 0 0 0q�5K      �� 5M   
   -   5        $ lblBrojIgracaPodatak��5N      $��10��5O      $��2��5P      $��2��5Q      $��15(�5R      $��0q�5S      $��Center=�5T      $
��Left=�5U      �� 5X   
   -   5        $ lblPozicija��5Y         StatIgracaPozicija#��Z 5Z      $��1��5[      $��3��5\      $��15(�5]      $
��Bold"�5^      $��Center=�5_      $
��Left=�5`      $��20 0 0 0q�5a      �� 5c   
   -   5        $ lblPozicijaPodatak��5d      $��Veznjak��5e      $��2��5f      $��3��5g      $��15(�5h      $��0q�5i      $��Center=�5j      $
��Left=�5k      �� 5o   
   -   5        $ 
lblKapetan��5p         StatIgracaKapetan#��Z 5q      $��1��5r      $��4��5s      $��15(�5t      $
��Bold"�5u      $��Center=�5v      $
��Left=�5w      $��20 0 0 0q�5x      �� 5z   
   -   5        $ lblKapetanPodatak��5{      $��Da��5|      $��2��5}      $��4��5~      $��15(�5      $��0q�5�      $��Center=�5�      $
��Left=�5�      �� 5�   
   -   5        $ 	lblGolovi��5�         StatIgracaGolovi#��Z 5�      $��1��5�      $��5��5�      $��15(�5�      $
��Bold"�5�      $��Center=�5�      $
��Left=�5�      $��20 0 0 0q�5�      �� 5�   
   -	   5        $ lblGoloviPodatak��5�      $��2��5�      $��2��5�      $��5��5�      $��15(�5�      $��0q�5�      $��Center=�5�      $
��Left=�5�      �� 5�   
   -
   5        $ lblZuti��5�         StatIgracaZutiKartoni#��Z 5�      $��1��5�      $��6��5�      $��15(�5�      $
��Bold"�5�      $��Center=�5�      $
��Left=�5�      $��20 0 0 0q�5�      �� 5�   
   -   5        $ lblZutiKartoniPodatak��5�      $��0��5�      $��2��5�      $��6��5�      $��15(�5�      $��0q�5�      $��Center=�5�      $
��Left=�5�      5�      5�      
   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Bolnica.xaml_window.DoctorBolnica.xaml_window.Doctor  5   	   1    +Bolnica.xaml_window.Doctor.AnamnesisTherapy   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Bolnica.xaml_window.Doctor     5   	     � Title$  Zdravo��5   	    � Icon$ Slike/heart.ico��6   $	��400��6/   $	��400��6<   .��5	      �  � RowDefinitions 5
   
   �� 5      $��80 �6   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��55 �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6   $��2��6.   ���	#FF929292$��0,0,0,2q�6Z   $	��350��6t   ._�5      �� $��0��6   $��0��6!   $��2��61   $��Center=�6E   $��Center=�6`   $��35(�6}   ���	#FFD44848.��6�   
Terapija6�   5      �� 5   
   -   5        $��lvDataBindingAnamnesis��5   j   $��1��6   $��0��6    $��2��60   $��5��6D   $��20,10,22,10q�6U    �� View 5      �� 5      .P�5      �� $��Ime leka��6%    �� Width$
 Auto��5    %    �� DisplayMemberBinding 5   8   �� *drug.DrugName+5    %   �� 5!      $��Opis recepta��6%   $
 Auto��5"   %    5!   ;   �� *DescriptionPrescription+5"   %   �� 5#      $
��Doza��6%   $
 Auto��5$   %    5#   3   �� *QuantityPrescription+5$   %   �� 5%      $��Datum početka��6%   $
 Auto��5&   %    5%   =   �� *StartDatePrescription+5&   %   �� 5'      $��Datum kraja��6%   $
 Auto��5(   %    5'   :   �� *EndDatePrescription+5(   %   5)      5,      �� 5.   
   -   5        $��0��5.      $��5��6!   $��2��6.   ���	#FF565656$��1,1,2,2q�6W   $��15(�6q   $��0,30,0,0q�6   $��Center=�6�   $��2��6�   $	��130��6�   $��40��6�   ���	#FF3C9B3C
�������.��5/      ��  �� Orientation$ 
Horizontal=�6   .+�50      �� $��15(�6   ���	#FF3C9B3C$��Center=�6=   
�������$��Segoe MDL2 Assets)�6k   $	����6�   $��0,0,0,0q�6�   6�   �� 51      
�������.��6+   Dodaj recept69   52      53      �� 55   
   $��7��6   $��0��6   $��3��6.   ���	#FF565656$��0,1,0,0q�6Z   56      �� 57   
   -   5        $��1��57      $��7��6!   $��60��6.   $��15(�69   ���	#FFD44848���	#FF565656$��1,1,2,2q�6w   $��40��6�   $��90, 0, 0, 0q�6�   
�������.��6�   Izadji6�   �� 58   
   -   5        $��1��58      $��7��6!   $��60��6.   $��15(�69   ���	#FFD44848���	#FF565656$��1,1,2,2q�6v   $��40��6�   $��20, 0, 90, 0q�6�   
�������.��6�   	Kreiraj6�   59      5:      
   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Bolnica.xaml_window.DoctorBolnica.xaml_window.Doctor  5   	   .    (Bolnica.xaml_window.Doctor.AnamnesisOpen   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Bolnica.xaml_window.Doctor     5   	     � Title$  Zdravo��5   	    � Icon$ Slike/heart.ico��6   $	��400��6/   $	��400��6<    � WindowStartupLocation$ CenterScreen=�6H   .��5	      �  � RowDefinitions 5
   
   �� 5      $��80 �6   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��55 �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6   $��2��6.   ���	#FF929292$��0,0,0,2q�6Z   $	��350��6t   ._�5      �� $��0��6   $��0��6!   $��2��61   $��Center=�6E   $��Center=�6`   $��35(�6}   ���	#FFD44848.��6�   Izveštaj o pregledu6�   5      �� 5   
   $��1��6   $��20,0,0,0q�6   $��30��6/   $
��Bold"�6;   .��6M   Vrsta pregleda:6^   �� 5   
   -   5        $��lbTypeAnamnesis��5   F   $��1��6   $��1��6   $	��150��6-   $��30��69   6F   �� 5   
   $��2��6   $��20,0,0,0q�6   $��30��6/   $
��Bold"�6;   .��6M   Pacijent se žali na:6c   �� 5   
   -   5        $��lbDescriptionAnamnesis��5   F   $��2��6   $��1��6   $	��150��6-   $��30��69   6F   �� 5    
   $��3��6   $��20,0,0,0q�6   $��30��6/   $
��Bold"�6;   .��6M   Zaključak i mišljenje:6e   �� 5!   
   -   5        $��lbOpinionForAnamnesis��5!   F   $��3��6   $��1��6   $	��150��6-   $��30��69   6F   �� 5"   
   $��4��6   $��20,0,0,0q�6   $��30��6/   $
��Bold"�6;   .��6M   	Terapija:6X   �� 5$   
   -   5        $��lvDataBindingAnamnesis��5$   i   $��5��6   $��0��6    $��2��60   $��2��6D   $��
20,0,23,10q�6U    �� View 5%      �� 5&      .P�5'      �� $��Ime leka��6%    �� Width$
 Auto��5(   %    �� DisplayMemberBinding 5'   8   �� *drug.DrugName+5(   %   �� 5)      $��Opis recepta��6%   $
 Auto��5*   %    5)   ;   �� *DescriptionPrescription+5*   %   �� 5+      $
��Doza��6%   $
 Auto��5,   %    5+   3   �� *QuantityPrescription+5,   %   �� 5-      $��Datum početka��6%   $
 Auto��5.   %    5-   =   �� *StartDatePrescription+5.   %   �� 5/      $��Datum kraja��6%   $
 Auto��50   %    5/   :   �� *EndDatePrescription+50   %   51      54      �� 55   
   $��7��6   $��0��6   $��3��6.   ���	#FF383838$��0,1,0,0q�6Z   56      �� 57   
   -   5        $��1��57      $��7��6!   $��60��6.   $��15(�69   ���	#FFD44848���	#FF565656$��1,1,2,2q�6v   $��30��6�   $��90, 0, 0, 0q�6�   
�������.��6�   Izađi6�   59      5:      
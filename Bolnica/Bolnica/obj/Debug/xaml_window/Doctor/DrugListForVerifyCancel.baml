   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Bolnica.xaml_window.DoctorBolnica.xaml_window.Doctor  5   	   7 clr-namespace:Bolnica.ValidationBolnica.Validation  5   
   8    2Bolnica.xaml_window.Doctor.DrugListForVerifyCancel   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Bolnica.xaml_window.Doctor     5   	   0val clr-namespace:Bolnica.Validation     5   
     � Title$  Zdravo��5	   	    � Icon$ Slike/heart.ico��6   $	��200��6/   $	��300��6<    � WindowStartupLocation$ CenterScreen=�6H   .��5
      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      5      �� 5      �� 5      6   .+�5   
   �� $��0��6   $��0��6   $	��250��6.   $��2��6:   ���	#FF929292$��0,0,0,2q�6f   ._�5      �� -   5        $��DrugName��5   �   $��0��6   $��0��6!   $��2��61   $��Center=�6E   $��Center=�6`   $��35(�6}   ���	#FFD44848.��6�   Obrazloženje6�   5      �� 5   
   -   5        $��	tbComment��5      $��20,10,20,10q�6$   $��1��69   $��0��6F   $��2��6V   .��6j   ��5      �� 5       �� Path$ Message�6    �� UpdateSourceTrigger$ PropertyChanged=�6)    �� ValidationRules 5      #   Bolnica.Validation.CheckSpace  5      ,  &System.Windows.Controls.ValidationRule   ValidationStep$ RawProposedValue=�6)   6M   3   -Bolnica.Validation.MinMaxValidationRuleString  5      $ ConvertedProposedValue=�69   
	   Min$	 3Q�6a   

   Max$
 30Q�6i   6t   5       .��5!       =� ErrorTemplate 5"      �� 5#      .R�5$      �  5%      �� 5&      �� 5'       5)      �� 5*      �� 5+      .+�5-      �� $��0��64   $��0��6A   6S   �� 5.      $��0��6$   $��1��64   $��8(�6A   
���  ����6N   �� *[0].ErrorContent+6�   �� 5/      $��15(�6    $��0��6.   $��1��6;   
���  ��$��Segoe MDL2 Assets)�6]   $	����6|   6�   50      51      .��52   (   53      �� 54   
   $��7��6   $��0��6   $��3��6.   ���	#FF565656$��0,1,0,0q�6Z   55      �� 56   
   -   5        $��0��56      $��15(�6!   $��2��6/   $��2��6<   $��Right=�6P   $��60��6l   ���	#FFD44848���	#FF565656$��1,1,2,2q�6�   $��30��6�   $��0, 0, 100, 0q�6�   
�������.��6  	Potvrdi6  �� 57   
   -   5        $��1��57      $��15(�6!   $��2��6/   $��Right=�6<   $��60��6X   ���	#FFD44848���	#FF565656$��1,1,2,2q�6�   $��30��6�   $��0, 0, 20, 0q�6�   
�������.��6�   Izađi6   58      59      
   M S B A M L   `   `   `  ����B  >Bolnica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Bolnica.xaml_window.DoctorBolnica.xaml_window.Doctor  5   	   /    )Bolnica.xaml_window.Doctor.DrugListVerify   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Bolnica.xaml_window.Doctor     5   	     � Title$  Zdravo��5   	    � Icon$ Slike/heart.ico��6   $	��400��6/   $	��400��6<    � WindowStartupLocation$ CenterScreen=�6H   .��5	      �  � RowDefinitions 5
   
   �� 5      $��80 �6   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��55 �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6   $��2��6.   ���	#FF929292$��0,0,0,2q�6Z   $	��350��6t   ._�5      �� $��0��6   $��0��6!   $��2��61   $��Center=�6E   $��Center=�6`   $��35(�6}   ���	#FFD44848.��6�   Verifikovani lekovi6�   5      �� 5   
   -   5        $��lvDataBindingDrugs��5   j   $��1��6   $��0��6    $��2��60   $��5��6D   $��20,10,20,10q�6U    �� View 5      �� 5      .P�5      �� $��ID��6%    �� Width$
 Auto��5    %    �� DisplayMemberBinding 5   2   �� *DrugId+5    %   �� 5!      $��Ime leka��6%   $
 Auto��5"   %    5!   7   �� *
DrugName+5"   %   �� 5#      $��	Opis leka��6%   $
 Auto��5$   %    5#   8   �� *DrugDescription+5$   %   �� 5%      $��Količina leka��6%   $
 Auto��5&   %    5%   =   �� *DrugQuantity+5&   %   �� 5'      $��Gramaža leka��6%   $
 Auto��5(   %    5'   ;   �� *
DrugWeight+5(   %   �� 5)      $��Komponente leka��6%   $
 Auto��5*   %    5)   >   �� *DrugComponents+5*   %   �� 5+      $��Zamenski lek��6%   $
 Auto��5,   %    5+   ;   �� *AlternativeDrug+5,   %   5-      50      �� 51   
   -   5        $��0��51      $��15(�6!   $��5��6/   $��2��6<   $��40��6M   $��2��6Y   $	��110��6m   ���	#FFEDEDED���	#FF565656$��1,1,2,2q�6�   $��0, 30, 0, 0q�6�   .��52      ��  �� Orientation$ 
Horizontal=�6   .+�53      �� $��15(�6   $��Center=�6&   ���	#FFEDEDED$��Segoe MDL2 Assets)�6X   $	����6w   $��0,0,0,0q�6�   6�   �� 54      .��6   
Izmeni lek6%   55      56      �� 59   
   $��7��6   $��0��6   $��3��6.   ���	#FF565656$��0,1,0,0q�6Z   5:      �� 5;   
   -   5        $��1��5;      $��15(�6!   $��7��6/   $��60��6<   ���	#FFD44848���	#FF565656$��1,1,2,2q�6v   $��30��6�   $��100, 0, 0, 0q�6�   
�������.��6�   Izađi6�   5=      5>      
   M S B A M L   `   `   `  ����N  JCalendar_with_jokes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Calendar_with_jokesCalendar_with_jokes  5   	   $    Calendar_with_jokes.DayControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Calendar_with_jokes     5   	   $	��104��5   
   $	��114��6   .��5
      �   � RowDefinitions  5   
   �� 5      $��25 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ DayLabelRowBorder��5       �� CornerRadius$ 10��6,   $��0��6>   ���	#FF1F08FD._�5      �� -   5         ��Name$ DayNumberLabel��5      $��1��6,   $
��Bold"�68   $��Robocode)�6J   $��Italic$�6`   5      �� 5   
   -   5         ��Name$ DayAppointmentsStack��5   "   $��1��6   $��Stretch=�6@   
�������$��Stretch=�5      5      �� 5   
   -   5        $��View Day��5       J� Opacity$ 0Q�69   $��8(�6E    J� RenderTransformOrigin$ 0.716,2.824&�6R   ���	#FF64CCF1$��0q�6�   
�������$
��Bold"�6�   $��	0,0,10,10q�6�   $	��5,2q�6�   $��2��6�   5      5      
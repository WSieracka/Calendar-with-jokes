   M S B A M L   `   `   `  ����N  JCalendar_with_jokes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Calendar_with_jokesCalendar_with_jokes  5   	   !    Calendar_with_jokes.ViewDay   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Calendar_with_jokes     5   	     � Title$  ViewDay��5   	   $	��450��6   $	��800��6&    � WindowStartupLocation$ CenterScreen=�62    � 	Resources 5	         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 RoundedButton �� 
TargetType	 �� 
TargetType
 ��Name �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName��%I  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   " ��6&   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5        � ��8  6,   �� 5!       � ��# � ��6+   �� 5"       � ��$ 0q�60   �� 5#       � ��$ Center=�6;   �� 5$       � ��$ Center=�69   �� 5%       � ��$ 1q�6(   �� 5&       � �� 5'      �� 5(      "	 ��6&   .R�5)      �� $
 border��6!   $ 2��61   #��z��6B   #��z��6n   #��z��6�    . ._�5*      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5+       5,      P� 5-       �@��IsDefaulted . . �5.   "   �� $ border��6@   # � ��6T    � ��5/      P� 50       �@J�IsMouseOver . . �51   "   �� $ border��6?   8   � ��6S   �� 52   "   $ border��6@   8   � ��6T   53      P� 54       � �� . . �55   "   �� $ border��6?   8   � ��6S   �� 56   "   $ border��6@   8   � ��6T   57      P� 58       � {� .  . �59   "   �� $ border��6?   8   � ��6S   �� 5:   "   $ border��6@   8   � ��6T   �� 5;   "   $ contentPresenter��6K   8 	  � ��6i   5<      5>      5@      5A      5B      .��5C      � ��5D   
   �� 5E       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5F      �  � Color$ 	#FFC4DDFF��6    � Offset$	 0.0Q�61   � 5G      $ White��6   $	 0.5Q�6-   � 5H      $ 	#FFFADC96��6   $	 1.0Q�61   5I      .+�5K   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
gridEvents��5K         AutoGenerateColumns .  $
��Left=�6f   $	��160��6�   $��	24,24,0,0q�6�   $	��Top=�6�   $	��519��6�   ��6'   �� *
EventsList+   Columns 5L      0  *System.Windows.Controls.DataGridTextColumn  5M      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�6s     5N      $
 Kind��6%    63   �� *Kind+$ PropertyChanged=�6s     5O      $ Description��6%    6:   �� *Description+$ PropertyChanged=�6�   5Q      �� 5R   
   -   5         ��Name$ btnAdd��5R      $	��Add��6!   $
��Left=�6/   $��157,390,0,0q�6J   $	��Top=�6_   $��75��6w   $
��Bold"�6�   ���	#FF64CCF1
�������#��� 
 6�   �� 5S   
   -   5         ��Name$ txtName��5S      $
��Left=�6#   $��23��6>   $��112,263,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5T   
   -   5        $ txtKind��5T      $
��Left=�6#   $��23��6>   $��112,308,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5U   
   -   5        $ txtDescription��5U      $
��Left=�6*   $��23��6E   $��112,352,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5V   
   $
��Left=�6   $��
24,263,0,0q�6/   $
��Wrap=�6C   $
��Name��6W   $	��Top=�6c   �� 5W   
   $
��Left=�6   $��
24,308,0,0q�6/   $
��Wrap=�6C   $
��Kind��6W   $	��Top=�6c    J� RenderTransformOrigin$ 0.534,-0.125&�6{   �� 5X   
   $
��Left=�6   $��
24,352,0,0q�6/   $
��Wrap=�6C   $��Description��6W   $	��Top=�6j   �� 5Y   
   -   5        $ 	btnUpdate��5Y      $��Update��6$   $
��Left=�65   $��694,163,0,0q�6P   $	��Top=�6e   $��75��6}   $
��Bold"�6�   ���	#FF64CCF1
�������#��� 
 6�   �� 5Z   
   -   5        $ 
txtNameUpd��5Z      $
��Left=�6'   $��23��6B   $��
649,39,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5[   
   -   5        $ 
txtKindUpd��5[      $
��Left=�6&   $��23��6A   $��
649,78,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5\   
   -	   5        $ txtDescriptionUpd��5\      $
��Left=�6-   $��23��6H   $��649,115,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   �� 5]   
   $
��Left=�6   $��
574,39,0,0q�6/   $
��Wrap=�6C   $
��Name��6W   $	��Top=�6c   �� 5^   
   $
��Left=�6   $��
574,78,0,0q�6/   $
��Wrap=�6C   $
��Kind��6W   $	��Top=�6c   �� 5_   
   $
��Left=�6   $��574,115,0,0q�6/   $
��Wrap=�6D   $��Description��6X   $	��Top=�6k   �� 5`   
   -
   5        $ 	btnDelete��5`      $��Delete Event��6$   $
��Left=�6;   $��468,206,0,0q�6V   $	��Top=�6k   $��75��6�   $
��Bold"�6�   ���	#FF64CCF1
�������#��� 
 6�   �� 5a   
   -   5         ��Name$ txtJoke��5a      $
��Left=�6&   $��330,250,0,0q�6A   $
��Wrap=�6V   $	��Top=�6j   $	��125��6�   $	��439��6�   $��Arial)�6�   
����� ��� 6�   .F�5b      �� $��18��6   $��19��6*   $ -2.605,-2.083&�65   . �5c      /� .T�5d      J� .*�6%   �� $�RichTextBox��6)   6?   5e      5f      5g      6#   5i      5j      
   M S B A M L   `   `   `  ����G  CExerciseForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ExerciseFormExerciseForm  5   	       ExerciseForm.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ExerciseForm     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   �� $
��Namn��6   $��Right=�6    $��5q�6<   �� 5   
   -   5        $��tbName��5      $��1��6    $	��250��60   $��20��6<   $
��Left=�6H   $��5q�6c   �� 5   
   $��1��6   $��Right=�6!   $��5q�6=   $��
Omfattning��6H   �� 5   
   -   5        $��spExtent��5       �� Orientation$ 
Horizontal=�6%   $��1��6>   $��1��6K   $��Stretch=�6[   $��Stretch=�6w   .+�5      	� -   5         	� 	GroupName$ extent��5      $��Heltid��6L   $��5q�6]    d� 	IsChecked$
 TrueY�6h   	� 5      -   5        $ extent��5      $��Deltid��6K   $��5q�6\   5      �� 5!   
   $��2��6   $��Jag kan��6!   $��Right=�60   $��Bottom=�6L   $��5q�6g   �� 5"   
   $��2��6   $��1��6"   $ 
Horizontal=�62   $��Bottom=�6K   $
��Left=�6f   .+�5#      �� -   5        $��C#��5#      $��5q�6?   �� 5$      -   5        $	��C++��5$      $��5q�6@   �� 5%      -   5        $
��Java��5%      $��5q�6A   5&      �� 5(   
   $��Jag vill arbeta som��6   $��3��6/   $��Right=�6<   $��5q�6X   �� 5)   
   -   5        $��cbRole��5)      $��3��6!   $��1��6.   $
��Left=�6>   $��Bottom=�6Y   $��5q�6t   .@�5*      �� $��Programmerare��6   �� 5+      $��Designer��6   �� 5,      $��Webbutvecklare��6   �� 5-      $	��DBA��6   5.      �� 50   
   $��Jag kan tidigast börja��6   $��4��62   $��Right=�6?   $	��Top=�6[   $��5q�6s   &   System.Windows.Controls.Calendar  52   
   -	   5        $��cStart��52      $��4��6!   $��1��6.   $��5q�6>   $
��Left=�6I   �� 54   
   -
   5        $��btnSend��54      $��5��66   $��1��6C   $��30��6S   $	��100��6_   $
��Left=�6k   $��5q�6�   .��6�   Skicka6�   56      57      
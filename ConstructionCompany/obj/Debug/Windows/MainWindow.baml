   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ConstructionCompanyConstructionCompany  5   	   $    ConstructionCompany.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:ConstructionCompany     5   	     � Title$  
MainWindow��5   	   $	��720��5	   	   $
��1280��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency . .��5      �  � RowDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      $��0.02* �6   �� 5      $��1* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�5      $��2��5      $��	5,0,100,0q�5      .+�5      �� -   5         ��Name$ OrderBut��5         jB#��[  5      
�������$��Заказы��5      $	��120��5       $��0,10,0,0q�5!      $��28(�5"      5#      �� 5$      -   5        $ 	WorkerBut��5$      #��[  5%      
�������$��Рабочие��5'      $	��120��5(      $��0,20,0,0q�5)      $��26(�5*      5+      �� 5,      -   5        $ 
BrigadeBut��5,      #��[  5-      
�������$��Бригады��5/      $	��120��50      $��0,20,0,0q�51      $��26(�52      53      �� 54      -   5        $ MaterialBut��54      #��[  55      
�������$��Материалы��57      $	��150��58      $��0,20,0,0q�59      $��26(�5:      5;      �� 5<      -   5        $ ServicelBut��5<      #��[  5=      
�������$��Услуги��5?      $	��100��5@      $��0,20,0,0q�5A      $��26(�5B      5C      �� 5D      -   5        $ 	CancelBut��5D      #��[  5E      ���	#FFC71F1F$y�Hidden=�5G      $��Отменить��5H      $	��140��5I      $��
200,20,0,0q�5J      $��26(�5K      5L      �� 5M      -   5        $ AddBut��5M      #��[  5N      ���#3dc147$��Добавить��5P      $	��140��5Q      $��0,20,0,0q�5R      $��26(�5S      5T      �� 5U      -   5        $ 
ExitAkkBut��5U      #��[  5V      
�������$��
выйти��5X      $��60��5Y      $��	10,30,0,0q�5Z      $��18(�5[      5\      5]      �� 5^   
   -	   5        $
 Exit��5^      #��[  5_      
�������$��2��5a      $��X��5b      $��30(�5c      $��1230,20,5,0q�5d      5e      �� 5f   
   -
   5        $ Minimize��5f      #��[  5g      
�������$��2��5i      $��-��5j      $��38(�5k      $��1180,20,55,0q�5l      5m      �� 5n   
   $��1��6   $��5��5o      
������� �� RadiusX$ 10��5q      	 �� RadiusY$	 10��5r      
������ 5s      �� 5t   
   -   5        
 ��Name$
 Welcome��5t      $&�� ДОБРО ПОЖАЛОВАТЬ!��5u      $��2��5v      $��50(�5w      $��Center=�5x      $��Center=�5y      
���OO/�5z       � 5{   
   -   5          �Name$
 Main��5{      $��2��5|      $��10q�5}        � NavigationUIVisibility$ Hidden=�5~      5�      5�      5�      
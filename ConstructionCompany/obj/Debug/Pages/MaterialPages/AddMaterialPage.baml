   M S B A M L   `   `   `  ����N  JConstructionCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:ConstructionCompany.Pages.MaterialPages'ConstructionCompany.Pages.MaterialPages  5      =    7ConstructionCompany.Pages.MaterialPages.AddMaterialPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Glocal5clr-namespace:ConstructionCompany.Pages.MaterialPages     5        N� Title$  AddMaterialPage��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $
��0.1* �6    � RowDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $
��0.1* �6   .+�5   
   �� $��2��6   $��1��5      $*��$Название материала:��5      $��24(�5      $��Center=�5       $��Right=�5!      $��	0,0,340,0q�5"      �� 5#   
   -   5         ��Name$ NameBox��5#      $��26(�5$      $��240,40,30,40q�5%      $��2��5&      $��1��5'       �� 	MaxLength$	 100��5(      
�����w�5+      �� 5-   
   $��3��6   $��1��5.      $(��"Еденица измерения:��5/      $��24(�50      $��Center=�51      $��Right=�52      $��	0,0,340,0q�53      �� 54   
   -   5        $ UnitBox��54      $��26(�55      $��240,40,30,40q�56      $��3��57      $��1��58      $	 100��59      
�����w�5<      �� 5>   
   $��2��6   $��2��5?      $��	Цена:��5@      $��24(�5A      $��Center=�5B      $��Right=�5C      $��	0,0,380,0q�5D      �� 5E   
   -   5        $ CostBox��5E      $��26(�5F      $��200,40,60,40q�5G      $��2��5H      $��2��5I      $ 15��5J      
�����w�5M      �� 5N   
   -   5         ��Name$ MaterialFinish��5N         jB#��[  5O      ���#3dc147$��5��5Q      $��2��5R      $��230,60,20,20q�5S      $#��Добавить Объект��5T      $��28(�5U      5V      5X      5Y      